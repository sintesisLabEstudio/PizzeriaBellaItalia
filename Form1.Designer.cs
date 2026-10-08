namespace PizzeríaBellaItalia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpCliente = new GroupBox();
            txtTelefono = new TextBox();
            txtCliente = new TextBox();
            lblTelefono = new Label();
            lblNombre = new Label();
            grpPizza = new GroupBox();
            cboMasa = new ComboBox();
            lblMasa = new Label();
            cboTamano = new ComboBox();
            lblTamano = new Label();
            grpIngredientes = new GroupBox();
            chkTocino = new CheckBox();
            chkPepperoni = new CheckBox();
            chkAceitunas = new CheckBox();
            chkChampinones = new CheckBox();
            chkQuesoExtra = new CheckBox();
            grpEntrega = new GroupBox();
            chkConvenioEstudiante = new CheckBox();
            rdbDelivery = new RadioButton();
            rdbRetiro = new RadioButton();
            lblSubtotalValor = new Label();
            lblIvaValor = new Label();
            lblTotalValor = new Label();
            lblDeliveryValor = new Label();
            lblDescuentoValor = new Label();
            grpResumen = new GroupBox();
            lblDescuentoNombre = new Label();
            lblDeliveryNombre = new Label();
            lblIvaNombre = new Label();
            lblTotalNombre = new Label();
            lblSubtotalNombre = new Label();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnConfirmar = new Button();
            grpCliente.SuspendLayout();
            grpPizza.SuspendLayout();
            grpIngredientes.SuspendLayout();
            grpEntrega.SuspendLayout();
            grpResumen.SuspendLayout();
            SuspendLayout();
            // 
            // grpCliente
            // 
            grpCliente.Controls.Add(txtTelefono);
            grpCliente.Controls.Add(txtCliente);
            grpCliente.Controls.Add(lblTelefono);
            grpCliente.Controls.Add(lblNombre);
            grpCliente.Location = new Point(22, 44);
            grpCliente.Name = "grpCliente";
            grpCliente.Size = new Size(308, 111);
            grpCliente.TabIndex = 0;
            grpCliente.TabStop = false;
            grpCliente.Text = "Datos del Cliente";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(150, 56);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 3;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(6, 56);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(125, 27);
            txtCliente.TabIndex = 2;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(150, 26);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 1;
            lblTelefono.Text = "Telefono:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(25, 26);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // grpPizza
            // 
            grpPizza.Controls.Add(cboMasa);
            grpPizza.Controls.Add(lblMasa);
            grpPizza.Controls.Add(cboTamano);
            grpPizza.Controls.Add(lblTamano);
            grpPizza.Location = new Point(22, 182);
            grpPizza.Name = "grpPizza";
            grpPizza.Size = new Size(308, 125);
            grpPizza.TabIndex = 1;
            grpPizza.TabStop = false;
            grpPizza.Text = "Tamaño y Masa:";
            // 
            // cboMasa
            // 
            cboMasa.FormattingEnabled = true;
            cboMasa.Location = new Point(81, 72);
            cboMasa.Name = "cboMasa";
            cboMasa.Size = new Size(114, 28);
            cboMasa.TabIndex = 4;
            // 
            // lblMasa
            // 
            lblMasa.AutoSize = true;
            lblMasa.Location = new Point(6, 76);
            lblMasa.Name = "lblMasa";
            lblMasa.Size = new Size(47, 20);
            lblMasa.TabIndex = 3;
            lblMasa.Text = "Masa:";
            // 
            // cboTamano
            // 
            cboTamano.FormattingEnabled = true;
            cboTamano.Location = new Point(81, 38);
            cboTamano.Name = "cboTamano";
            cboTamano.Size = new Size(114, 28);
            cboTamano.TabIndex = 2;
            // 
            // lblTamano
            // 
            lblTamano.AutoSize = true;
            lblTamano.Location = new Point(6, 41);
            lblTamano.Name = "lblTamano";
            lblTamano.Size = new Size(64, 20);
            lblTamano.TabIndex = 1;
            lblTamano.Text = "Tamaño:";
            // 
            // grpIngredientes
            // 
            grpIngredientes.Controls.Add(chkTocino);
            grpIngredientes.Controls.Add(chkPepperoni);
            grpIngredientes.Controls.Add(chkAceitunas);
            grpIngredientes.Controls.Add(chkChampinones);
            grpIngredientes.Controls.Add(chkQuesoExtra);
            grpIngredientes.Location = new Point(395, 44);
            grpIngredientes.Name = "grpIngredientes";
            grpIngredientes.Size = new Size(322, 180);
            grpIngredientes.TabIndex = 3;
            grpIngredientes.TabStop = false;
            grpIngredientes.Text = "Adicionales ($800 c/u)";
            // 
            // chkTocino
            // 
            chkTocino.AutoSize = true;
            chkTocino.Location = new Point(10, 149);
            chkTocino.Name = "chkTocino";
            chkTocino.Size = new Size(75, 24);
            chkTocino.TabIndex = 5;
            chkTocino.Text = "Tocino";
            chkTocino.UseVisualStyleBackColor = true;
            // 
            // chkPepperoni
            // 
            chkPepperoni.AutoSize = true;
            chkPepperoni.Location = new Point(10, 59);
            chkPepperoni.Name = "chkPepperoni";
            chkPepperoni.Size = new Size(98, 24);
            chkPepperoni.TabIndex = 4;
            chkPepperoni.Text = "Pepperoni";
            chkPepperoni.UseVisualStyleBackColor = true;
            // 
            // chkAceitunas
            // 
            chkAceitunas.AutoSize = true;
            chkAceitunas.Location = new Point(10, 119);
            chkAceitunas.Name = "chkAceitunas";
            chkAceitunas.Size = new Size(95, 24);
            chkAceitunas.TabIndex = 2;
            chkAceitunas.Text = "Aceitunas";
            chkAceitunas.UseVisualStyleBackColor = true;
            // 
            // chkChampinones
            // 
            chkChampinones.AutoSize = true;
            chkChampinones.Location = new Point(10, 89);
            chkChampinones.Name = "chkChampinones";
            chkChampinones.Size = new Size(121, 24);
            chkChampinones.TabIndex = 1;
            chkChampinones.Text = "Champiñones";
            chkChampinones.UseVisualStyleBackColor = true;
            // 
            // chkQuesoExtra
            // 
            chkQuesoExtra.AutoSize = true;
            chkQuesoExtra.Location = new Point(10, 29);
            chkQuesoExtra.Name = "chkQuesoExtra";
            chkQuesoExtra.Size = new Size(110, 24);
            chkQuesoExtra.TabIndex = 0;
            chkQuesoExtra.Text = "Queso Extra";
            chkQuesoExtra.UseVisualStyleBackColor = true;
            // 
            // grpEntrega
            // 
            grpEntrega.Controls.Add(chkConvenioEstudiante);
            grpEntrega.Controls.Add(rdbDelivery);
            grpEntrega.Controls.Add(rdbRetiro);
            grpEntrega.Location = new Point(395, 258);
            grpEntrega.Name = "grpEntrega";
            grpEntrega.Size = new Size(322, 109);
            grpEntrega.TabIndex = 4;
            grpEntrega.TabStop = false;
            grpEntrega.Text = "Servicio y Descuento";
            // 
            // chkConvenioEstudiante
            // 
            chkConvenioEstudiante.AutoSize = true;
            chkConvenioEstudiante.Location = new Point(17, 69);
            chkConvenioEstudiante.Name = "chkConvenioEstudiante";
            chkConvenioEstudiante.Size = new Size(281, 24);
            chkConvenioEstudiante.TabIndex = 2;
            chkConvenioEstudiante.Text = "Convenio Estudiante/IPVG (10% Dcto)";
            chkConvenioEstudiante.UseVisualStyleBackColor = true;
            // 
            // rdbDelivery
            // 
            rdbDelivery.AutoSize = true;
            rdbDelivery.Location = new Point(166, 39);
            rdbDelivery.Name = "rdbDelivery";
            rdbDelivery.Size = new Size(129, 24);
            rdbDelivery.TabIndex = 1;
            rdbDelivery.Text = "Retiro en Local";
            rdbDelivery.UseVisualStyleBackColor = true;
            // 
            // rdbRetiro
            // 
            rdbRetiro.AutoSize = true;
            rdbRetiro.Checked = true;
            rdbRetiro.Location = new Point(17, 39);
            rdbRetiro.Name = "rdbRetiro";
            rdbRetiro.Size = new Size(129, 24);
            rdbRetiro.TabIndex = 0;
            rdbRetiro.TabStop = true;
            rdbRetiro.Text = "Retiro en Local";
            rdbRetiro.UseVisualStyleBackColor = true;
            // 
            // lblSubtotalValor
            // 
            lblSubtotalValor.AutoSize = true;
            lblSubtotalValor.Location = new Point(224, 34);
            lblSubtotalValor.Name = "lblSubtotalValor";
            lblSubtotalValor.Size = new Size(53, 20);
            lblSubtotalValor.TabIndex = 5;
            lblSubtotalValor.Text = "$0 CLP";
            // 
            // lblIvaValor
            // 
            lblIvaValor.AutoSize = true;
            lblIvaValor.Location = new Point(223, 124);
            lblIvaValor.Name = "lblIvaValor";
            lblIvaValor.Size = new Size(53, 20);
            lblIvaValor.TabIndex = 6;
            lblIvaValor.Text = "$0 CLP";
            // 
            // lblTotalValor
            // 
            lblTotalValor.AutoSize = true;
            lblTotalValor.Location = new Point(222, 163);
            lblTotalValor.Name = "lblTotalValor";
            lblTotalValor.Size = new Size(53, 20);
            lblTotalValor.TabIndex = 7;
            lblTotalValor.Text = "$0 CLP";
            // 
            // lblDeliveryValor
            // 
            lblDeliveryValor.AutoSize = true;
            lblDeliveryValor.Location = new Point(224, 95);
            lblDeliveryValor.Name = "lblDeliveryValor";
            lblDeliveryValor.Size = new Size(53, 20);
            lblDeliveryValor.TabIndex = 8;
            lblDeliveryValor.Text = "$0 CLP";
            // 
            // lblDescuentoValor
            // 
            lblDescuentoValor.AutoSize = true;
            lblDescuentoValor.Location = new Point(224, 63);
            lblDescuentoValor.Name = "lblDescuentoValor";
            lblDescuentoValor.Size = new Size(53, 20);
            lblDescuentoValor.TabIndex = 9;
            lblDescuentoValor.Text = "$0 CLP";
            // 
            // grpResumen
            // 
            grpResumen.Controls.Add(lblDescuentoNombre);
            grpResumen.Controls.Add(lblDeliveryNombre);
            grpResumen.Controls.Add(lblIvaNombre);
            grpResumen.Controls.Add(lblTotalNombre);
            grpResumen.Controls.Add(lblSubtotalNombre);
            grpResumen.Controls.Add(lblSubtotalValor);
            grpResumen.Controls.Add(lblDescuentoValor);
            grpResumen.Controls.Add(lblIvaValor);
            grpResumen.Controls.Add(lblDeliveryValor);
            grpResumen.Controls.Add(lblTotalValor);
            grpResumen.Location = new Point(22, 390);
            grpResumen.Name = "grpResumen";
            grpResumen.Size = new Size(311, 208);
            grpResumen.TabIndex = 10;
            grpResumen.TabStop = false;
            grpResumen.Text = "Detalle de Pago";
            // 
            // lblDescuentoNombre
            // 
            lblDescuentoNombre.AutoSize = true;
            lblDescuentoNombre.Location = new Point(11, 63);
            lblDescuentoNombre.Name = "lblDescuentoNombre";
            lblDescuentoNombre.Size = new Size(124, 20);
            lblDescuentoNombre.TabIndex = 15;
            lblDescuentoNombre.Text = "Descuento (10%):";
            // 
            // lblDeliveryNombre
            // 
            lblDeliveryNombre.AutoSize = true;
            lblDeliveryNombre.Location = new Point(11, 95);
            lblDeliveryNombre.Name = "lblDeliveryNombre";
            lblDeliveryNombre.Size = new Size(125, 20);
            lblDeliveryNombre.TabIndex = 14;
            lblDeliveryNombre.Text = "Recargo Delivery:";
            // 
            // lblIvaNombre
            // 
            lblIvaNombre.AutoSize = true;
            lblIvaNombre.Location = new Point(11, 124);
            lblIvaNombre.Name = "lblIvaNombre";
            lblIvaNombre.Size = new Size(127, 20);
            lblIvaNombre.TabIndex = 13;
            lblIvaNombre.Text = "IVA Chileno (19%)";
            // 
            // lblTotalNombre
            // 
            lblTotalNombre.AutoSize = true;
            lblTotalNombre.Location = new Point(11, 163);
            lblTotalNombre.Name = "lblTotalNombre";
            lblTotalNombre.Size = new Size(117, 20);
            lblTotalNombre.TabIndex = 12;
            lblTotalNombre.Text = "TOTAL A PAGAR:";
            // 
            // lblSubtotalNombre
            // 
            lblSubtotalNombre.AutoSize = true;
            lblSubtotalNombre.Location = new Point(11, 34);
            lblSubtotalNombre.Name = "lblSubtotalNombre";
            lblSubtotalNombre.Size = new Size(106, 20);
            lblSubtotalNombre.TabIndex = 10;
            lblSubtotalNombre.Text = "Subtotal Pizza:";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(452, 415);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(184, 29);
            btnCalcular.TabIndex = 11;
            btnCalcular.Text = "Calcular Total";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(452, 469);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(184, 29);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Nuevo Pedido";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(452, 510);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(184, 29);
            btnConfirmar.TabIndex = 13;
            btnConfirmar.Text = "Confirmar Pedido";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 659);
            Controls.Add(btnConfirmar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(grpResumen);
            Controls.Add(grpEntrega);
            Controls.Add(grpIngredientes);
            Controls.Add(grpPizza);
            Controls.Add(grpCliente);
            Name = "Form1";
            Text = "Sistema de Pedidos - Pizzería Bella Italia (v1.0)";
            grpCliente.ResumeLayout(false);
            grpCliente.PerformLayout();
            grpPizza.ResumeLayout(false);
            grpPizza.PerformLayout();
            grpIngredientes.ResumeLayout(false);
            grpIngredientes.PerformLayout();
            grpEntrega.ResumeLayout(false);
            grpEntrega.PerformLayout();
            grpResumen.ResumeLayout(false);
            grpResumen.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpCliente;
        private TextBox txtTelefono;
        private TextBox txtCliente;
        private Label lblTelefono;
        private Label lblNombre;
        private GroupBox grpPizza;
        private Label lblTamano;
        private ComboBox cboMasa;
        private Label lblMasa;
        private ComboBox cboTamano;
        private GroupBox grpIngredientes;
        private CheckBox chkTocino;
        private CheckBox chkPepperoni;
        private CheckBox chkAceitunas;
        private CheckBox chkChampinones;
        private CheckBox chkQuesoExtra;
        private GroupBox grpEntrega;
        private RadioButton rdbDelivery;
        private RadioButton rdbRetiro;
        private CheckBox chkConvenioEstudiante;
        private Label lblSubtotalValor;
        private Label lblIvaValor;
        private Label lblTotalValor;
        private Label lblDeliveryValor;
        private Label lblDescuentoValor;
        private GroupBox grpResumen;
        private Label lblDescuentoNombre;
        private Label lblDeliveryNombre;
        private Label lblIvaNombre;
        private Label lblTotalNombre;
        private Label lblSubtotalNombre;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnConfirmar;
    }
}
