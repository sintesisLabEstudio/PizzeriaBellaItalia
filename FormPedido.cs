using PizzeriaBellaItalia.Dominio;
using System.Globalization;

namespace PizzeriaBellaItalia.Presentacion;

public partial class FormPedido : Form
{
    public FormPedido()
    {
        InitializeComponent();
    }
    private void FormPedido_Load(object sender, EventArgs e)
    {
        // Configurar cultura invariable para evitar errores de símbolos regionales
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        PoblarComboBoxesConDiccionarios();
        LimpiarFormulario();
    }

    private void PoblarComboBoxesConDiccionarios()
    {
        // 1. Diccionario de Tamaños (Key: Nombre del Tamaño, Value: Precio Base)
        Dictionary<string, int> opcionesTamano = new Dictionary<string, int>
                {
                    { "Personal (1 Persona)", 5000 },
                    { "Mediana (2 a 3 Personas)", 8500 },
                    { "Familiar (4 a 5 Personas)", 12000 }
                };

        cboTamano.DataSource = new BindingSource(opcionesTamano, null);
        cboTamano.DisplayMember = "Key";    // Lo que el usuario VE en el desplegable
        cboTamano.ValueMember = "Value";    // El VALOR numérico devuelto por SelectedValue
        cboTamano.DropDownStyle = ComboBoxStyle.DropDownList;

        // 2. Diccionario de Masas (Key: Nombre del Tipo de Masa, Value: Recargo Adicional)
        Dictionary<string, int> opcionesMasa = new Dictionary<string, int>
                {
                    { "Masa Tradicional (Sin Recargo)", 0 },
                    { "Masa Delgada (Sin Recargo)", 0 },
                    { "Borde de Queso (+$1.500)", 1500 }
                };

        cboMasa.DataSource = new BindingSource(opcionesMasa, null);
        cboMasa.DisplayMember = "Key";
        cboMasa.ValueMember = "Value";
        cboMasa.DropDownStyle = ComboBoxStyle.DropDownList;
    }

    private void btnCalcular_Click(object sender, EventArgs e)
    {
        // 1. Validar nombre del cliente
        if (string.IsNullOrWhiteSpace(txtCliente.Text))
        {
            MessageBox.Show("Por favor, ingrese el nombre del cliente antes de calcular.",
                            "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtCliente.Focus();
            return;
        }

        // 2. Validar selecciones de ComboBox
        if (cboTamano.SelectedValue == null || cboMasa.SelectedValue == null)
        {
            MessageBox.Show("Por favor, seleccione el tamaño y tipo de masa.",
                            "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // 3. Extraer nombres (Key) y valores (Value) desde los ComboBoxes enlazados
        string tamanoNombre = cboTamano.Text;
        int precioBaseTamano = (int)cboTamano.SelectedValue;

        string masaNombre = cboMasa.Text;
        int recargoMasa = (int)cboMasa.SelectedValue;

        // 4. Instanciar el objeto de dominio y asignar valores
        PedidoPizza pedido = new PedidoPizza
        {
            Cliente = txtCliente.Text.Trim(),
            Telefono = txtTelefono.Text.Trim(),
            TamanoNombre = tamanoNombre,
            PrecioBaseTamano = precioBaseTamano,
            MasaNombre = masaNombre,
            RecargoMasa = recargoMasa,

            QuesoExtra = chkQuesoExtra.Checked,
            Pepperoni = chkPepperoni.Checked,
            Champinones = chkChampinones.Checked,
            Aceitunas = chkAceitunas.Checked,
            Tocino = chkTocino.Checked,

            EsDelivery = rdbDelivery.Checked,
            AplicaConvenioEstudiante = chkConvenioEstudiante.Checked
        };

        // 5. Presentar los desgloses en la interfaz
        lblSubtotalValor.Text = $"$ {pedido.CalcularSubtotalPizza():N0} CLP";
        lblDescuentoValor.Text = $"- $ {pedido.CalcularMontoDescuento():N0} CLP";
        lblDeliveryValor.Text = $"+ $ {pedido.CalcularCostoDelivery():N0} CLP";
        lblIvaValor.Text = $"+ $ {pedido.CalcularMontoIva():N0} CLP";
        lblTotalValor.Text = $"$ {pedido.CalcularTotalPagar():N0} CLP";

        grpResumen.Enabled = true;
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
        LimpiarFormulario();
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

        txtCliente.Focus();
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
        DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea salir del sistema?",
                                                 "Confirmar Salida",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

        if (respuesta == DialogResult.Yes)
        {
            this.Close();
        }
    }
}


