using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using PizzeriaBellaItalia.Dominio;

namespace PizzeriaBellaItalia.Presentacion;

public partial class FormPedido : Form
{
    private readonly GestionPedidos gesPed = new();

    public FormPedido()
    {
        InitializeComponent();
    }

    private void FormPedido_Load(object sender, EventArgs e)
    {
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        PoblarComboBoxesConDiccionarios();
        LimpiarFormulario();
    }

    // -------------------------------------------------------------------- BOTÓN CALCULAR
    private void BtnCalcular_Click(object sender, EventArgs e)
    {
        if (!ValidaInputs()) return;

        PedidoPizza pedido = new()
        {
            Cliente = txtCliente.Text.Trim(),
            Telefono = txtTelefono.Text.Trim(),
            TamanoNombre = cboTamano.Text,
            PrecioBaseTamano = Convert.ToInt32(cboTamano.SelectedValue),
            MasaNombre = cboMasa.Text,
            RecargoMasa = Convert.ToInt32(cboMasa.SelectedValue),
            QuesoExtra = chkQuesoExtra.Checked,
            Pepperoni = chkPepperoni.Checked,
            Champinones = chkChampinones.Checked,
            Aceitunas = chkAceitunas.Checked,
            Tocino = chkTocino.Checked,
            EsDelivery = rdbDelivery.Checked,
            AplicaConvenioEstudiante = chkConvenioEstudiante.Checked
        };

        lblSubtotalValor.Text = $"$ {pedido.CalcularSubtotalPizza():N0} CLP";
        lblDescuentoValor.Text = $"- $ {pedido.CalcularMontoDescuento():N0} CLP";
        lblDeliveryValor.Text = $"+ $ {pedido.CalcularCostoDelivery():N0} CLP";
        lblIvaValor.Text = $"+ $ {pedido.CalcularMontoIva():N0} CLP";
        lblTotalValor.Text = $"$ {pedido.CalcularTotalPagar():N0} CLP";

        gesPed.AgregarPedido(pedido);

        lstResultados.DataSource = null;
        lstResultados.DataSource = gesPed.pedidos;

        grpResumen.Enabled = true;
    }

    // -------------------------------------------------------------------- OTROS BOTONES
    private void BtnLimpiar_Click(object sender, EventArgs e)
    {
        LimpiarFormulario();
    }

    private void BtnSalir_Click(object sender, EventArgs e)
    {
        DialogResult respuesta = MessageBox.Show(
            "¿Está seguro de que desea salir del sistema?",
            "Confirmar Salida",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

        if (respuesta == DialogResult.Yes)
        {
            this.Close();
        }
    }

    // -------------------------------------------------------------------- MÉTODOS AUXILIARES
    private void PoblarComboBoxesConDiccionarios()
    {
        Dictionary<string, int> opcionesTamano = new()
        {
            { "Seleccione uno", -1 },
            { "Personal (1 Persona)", 5000 },
            { "Mediana (2 a 3 Personas)", 8500 },
            { "Familiar (4 a 5 Personas)", 12000 }
        };

        cboTamano.DataSource = new BindingSource { DataSource = opcionesTamano };
        cboTamano.DisplayMember = "Key";
        cboTamano.ValueMember = "Value";
        cboTamano.DropDownStyle = ComboBoxStyle.DropDownList;

        Dictionary<string, int> opcionesMasa = new()
        {
            { "Seleccione uno", -1 },
            { "Masa Tradicional (Sin Recargo)", 0 },
            { "Masa Delgada (Sin Recargo)", 0 },
            { "Borde de Queso (+$1.500)", 1500 }
        };

        cboMasa.DataSource = new BindingSource { DataSource = opcionesMasa };
        cboMasa.DisplayMember = "Key";
        cboMasa.ValueMember = "Value";
        cboMasa.DropDownStyle = ComboBoxStyle.DropDownList;
    }

    private bool ValidaInputs()
    {
        if (string.IsNullOrWhiteSpace(txtCliente.Text))
        {
            MessageBox.Show(
                "Por favor, ingrese el nombre del cliente antes de calcular.",
                "Validación de Datos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            txtCliente.Focus();
            return false;
        }

        if (cboTamano.SelectedValue == null || Convert.ToInt32(cboTamano.SelectedValue) == -1 ||
            cboMasa.SelectedValue == null || Convert.ToInt32(cboMasa.SelectedValue) == -1)
        {
            MessageBox.Show(
                "Por favor, seleccione un tamaño y un tipo de masa válidos.",
                "Validación de Datos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return false;
        }
        return true;
    }

    private void LimpiarFormulario()
    {
        txtCliente.Clear();
        txtTelefono.Clear();

        if (cboTamano.Items.Count > 0) cboTamano.SelectedIndex = 0;
        if (cboMasa.Items.Count > 0) cboMasa.SelectedIndex = 0;

        chkQuesoExtra.Checked = false;
        chkPepperoni.Checked = false;
        chkChampinones.Checked = false;
        chkAceitunas.Checked = false;
        chkTocino.Checked = false;

        rdbRetiro.Checked = true;
        chkConvenioEstudiante.Checked = false;

        lblSubtotalValor.Text = "$ 0 CLP";
        lblDescuentoValor.Text = "$ 0 CLP";
        lblDeliveryValor.Text = "$ 0 CLP";
        lblIvaValor.Text = "$ 0 CLP";
        lblTotalValor.Text = "$ 0 CLP";

        grpResumen.Enabled = false;

        txtCliente.Focus();
    }
}