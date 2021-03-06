namespace CapaPresentacion
{
    partial class FrmAgregarNuevoPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanelGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelLeft = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanelCentral = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.labelSubTitulo = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.labelTransporte = new System.Windows.Forms.Label();
            this.labelResponsable = new System.Windows.Forms.Label();
            this.comboBoxTransportes = new System.Windows.Forms.ComboBox();
            this.comboBoxEmpleados = new System.Windows.Forms.ComboBox();
            this.labelFechaOrdenado = new System.Windows.Forms.Label();
            this.labelCostoEnvio = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxCostoEnvio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.labelSinFecha = new System.Windows.Forms.Label();
            this.checkBoxSinFecha = new System.Windows.Forms.CheckBox();
            this.panelFechaRequrido = new System.Windows.Forms.Panel();
            this.dateTimePickerFechaRequerido = new System.Windows.Forms.DateTimePicker();
            this.comboBoxClientes = new System.Windows.Forms.ComboBox();
            this.dateTimePickerFechaOrdenado = new System.Windows.Forms.DateTimePicker();
            this.labelFechaRequerido = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelSubTitulo2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxDescuento = new System.Windows.Forms.TextBox();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.labelDescuento = new System.Windows.Forms.Label();
            this.buttonAgregarProducto = new System.Windows.Forms.Button();
            this.buttonEliminarProducto = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelPeso = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.labelProducto = new System.Windows.Forms.Label();
            this.comboBoxProductos = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.toolTipAgregarProducto = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEliminarProducto = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanelGeneral.SuspendLayout();
            this.tableLayoutPanelLeft.SuspendLayout();
            this.tableLayoutPanelCentral.SuspendLayout();
            this.tableLayoutPanelTop.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.panelFechaRequrido.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelGeneral
            // 
            this.tableLayoutPanelGeneral.ColumnCount = 2;
            this.tableLayoutPanelGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.56531F));
            this.tableLayoutPanelGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.43469F));
            this.tableLayoutPanelGeneral.Controls.Add(this.tableLayoutPanelLeft, 0, 0);
            this.tableLayoutPanelGeneral.Controls.Add(this.tableLayoutPanelCentral, 1, 0);
            this.tableLayoutPanelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelGeneral.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanelGeneral.Name = "tableLayoutPanelGeneral";
            this.tableLayoutPanelGeneral.RowCount = 1;
            this.tableLayoutPanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelGeneral.Size = new System.Drawing.Size(1243, 804);
            this.tableLayoutPanelGeneral.TabIndex = 0;
            // 
            // tableLayoutPanelLeft
            // 
            this.tableLayoutPanelLeft.ColumnCount = 1;
            this.tableLayoutPanelLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLeft.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLeft.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanelLeft.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.tableLayoutPanelLeft.Name = "tableLayoutPanelLeft";
            this.tableLayoutPanelLeft.RowCount = 2;
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.36641F));
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.63359F));
            this.tableLayoutPanelLeft.Size = new System.Drawing.Size(102, 796);
            this.tableLayoutPanelLeft.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CapaPresentacion.Properties.Resources.pedidos;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 90);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanelCentral
            // 
            this.tableLayoutPanelCentral.ColumnCount = 1;
            this.tableLayoutPanelCentral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCentral.Controls.Add(this.tableLayoutPanelTop, 0, 0);
            this.tableLayoutPanelCentral.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCentral.Location = new System.Drawing.Point(110, 0);
            this.tableLayoutPanelCentral.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.tableLayoutPanelCentral.Name = "tableLayoutPanelCentral";
            this.tableLayoutPanelCentral.RowCount = 2;
            this.tableLayoutPanelCentral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.62006F));
            this.tableLayoutPanelCentral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.37994F));
            this.tableLayoutPanelCentral.Size = new System.Drawing.Size(1129, 800);
            this.tableLayoutPanelCentral.TabIndex = 1;
            // 
            // tableLayoutPanelTop
            // 
            this.tableLayoutPanelTop.ColumnCount = 4;
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.98565F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.46099F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.80378F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.95036F));
            this.tableLayoutPanelTop.Controls.Add(this.labelSubTitulo, 0, 0);
            this.tableLayoutPanelTop.Controls.Add(this.labelCliente, 0, 1);
            this.tableLayoutPanelTop.Controls.Add(this.labelTransporte, 0, 2);
            this.tableLayoutPanelTop.Controls.Add(this.labelResponsable, 0, 3);
            this.tableLayoutPanelTop.Controls.Add(this.comboBoxTransportes, 1, 2);
            this.tableLayoutPanelTop.Controls.Add(this.comboBoxEmpleados, 1, 3);
            this.tableLayoutPanelTop.Controls.Add(this.labelFechaOrdenado, 2, 1);
            this.tableLayoutPanelTop.Controls.Add(this.labelCostoEnvio, 2, 3);
            this.tableLayoutPanelTop.Controls.Add(this.tableLayoutPanel7, 3, 3);
            this.tableLayoutPanelTop.Controls.Add(this.tableLayoutPanel8, 3, 2);
            this.tableLayoutPanelTop.Controls.Add(this.comboBoxClientes, 1, 1);
            this.tableLayoutPanelTop.Controls.Add(this.dateTimePickerFechaOrdenado, 3, 1);
            this.tableLayoutPanelTop.Controls.Add(this.labelFechaRequerido, 2, 2);
            this.tableLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTop.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTop.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            this.tableLayoutPanelTop.RowCount = 4;
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.97727F));
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.86364F));
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.2236F));
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.60248F));
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelTop.Size = new System.Drawing.Size(1125, 196);
            this.tableLayoutPanelTop.TabIndex = 0;
            // 
            // labelSubTitulo
            // 
            this.labelSubTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSubTitulo.AutoSize = true;
            this.labelSubTitulo.Font = new System.Drawing.Font("Candara", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubTitulo.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelSubTitulo.Location = new System.Drawing.Point(4, 1);
            this.labelSubTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSubTitulo.Name = "labelSubTitulo";
            this.labelSubTitulo.Size = new System.Drawing.Size(155, 54);
            this.labelSubTitulo.TabIndex = 0;
            this.labelSubTitulo.Text = "DATOS";
            // 
            // labelCliente
            // 
            this.labelCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.Location = new System.Drawing.Point(8, 62);
            this.labelCliente.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(104, 33);
            this.labelCliente.TabIndex = 1;
            this.labelCliente.Text = "Cliente:";
            // 
            // labelTransporte
            // 
            this.labelTransporte.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTransporte.AutoSize = true;
            this.labelTransporte.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTransporte.Location = new System.Drawing.Point(8, 109);
            this.labelTransporte.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.labelTransporte.Name = "labelTransporte";
            this.labelTransporte.Size = new System.Drawing.Size(148, 33);
            this.labelTransporte.TabIndex = 2;
            this.labelTransporte.Text = "Transporte:";
            // 
            // labelResponsable
            // 
            this.labelResponsable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelResponsable.AutoSize = true;
            this.labelResponsable.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResponsable.Location = new System.Drawing.Point(8, 156);
            this.labelResponsable.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.labelResponsable.Name = "labelResponsable";
            this.labelResponsable.Size = new System.Drawing.Size(168, 33);
            this.labelResponsable.TabIndex = 3;
            this.labelResponsable.Text = "Responsable:";
            // 
            // comboBoxTransportes
            // 
            this.comboBoxTransportes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTransportes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTransportes.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTransportes.FormattingEnabled = true;
            this.comboBoxTransportes.Location = new System.Drawing.Point(194, 106);
            this.comboBoxTransportes.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTransportes.Name = "comboBoxTransportes";
            this.comboBoxTransportes.Size = new System.Drawing.Size(390, 40);
            this.comboBoxTransportes.TabIndex = 1;
            // 
            // comboBoxEmpleados
            // 
            this.comboBoxEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmpleados.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEmpleados.FormattingEnabled = true;
            this.comboBoxEmpleados.Location = new System.Drawing.Point(194, 153);
            this.comboBoxEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEmpleados.Name = "comboBoxEmpleados";
            this.comboBoxEmpleados.Size = new System.Drawing.Size(390, 40);
            this.comboBoxEmpleados.TabIndex = 2;
            // 
            // labelFechaOrdenado
            // 
            this.labelFechaOrdenado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFechaOrdenado.AutoSize = true;
            this.labelFechaOrdenado.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaOrdenado.Location = new System.Drawing.Point(592, 62);
            this.labelFechaOrdenado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFechaOrdenado.Name = "labelFechaOrdenado";
            this.labelFechaOrdenado.Size = new System.Drawing.Size(211, 33);
            this.labelFechaOrdenado.TabIndex = 7;
            this.labelFechaOrdenado.Text = "Fecha Ordenado:";
            // 
            // labelCostoEnvio
            // 
            this.labelCostoEnvio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCostoEnvio.AutoSize = true;
            this.labelCostoEnvio.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCostoEnvio.Location = new System.Drawing.Point(592, 156);
            this.labelCostoEnvio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCostoEnvio.Name = "labelCostoEnvio";
            this.labelCostoEnvio.Size = new System.Drawing.Size(192, 33);
            this.labelCostoEnvio.TabIndex = 9;
            this.labelCostoEnvio.Text = "Costo de Envío:";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.27642F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.72358F));
            this.tableLayoutPanel7.Controls.Add(this.textBoxCostoEnvio, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(821, 149);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(304, 47);
            this.tableLayoutPanel7.TabIndex = 13;
            // 
            // textBoxCostoEnvio
            // 
            this.textBoxCostoEnvio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCostoEnvio.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCostoEnvio.Location = new System.Drawing.Point(4, 4);
            this.textBoxCostoEnvio.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCostoEnvio.MaxLength = 10;
            this.textBoxCostoEnvio.Name = "textBoxCostoEnvio";
            this.textBoxCostoEnvio.Size = new System.Drawing.Size(120, 40);
            this.textBoxCostoEnvio.TabIndex = 6;
            this.textBoxCostoEnvio.Text = "0";
            this.textBoxCostoEnvio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxCostoEnvio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCostoEnvio_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "$";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.66116F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.33884F));
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel9, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.panelFechaRequrido, 0, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(821, 102);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(304, 47);
            this.tableLayoutPanel8.TabIndex = 4;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.83334F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.16667F));
            this.tableLayoutPanel9.Controls.Add(this.labelSinFecha, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.checkBoxSinFecha, 1, 0);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(214, 0);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(90, 46);
            this.tableLayoutPanel9.TabIndex = 5;
            // 
            // labelSinFecha
            // 
            this.labelSinFecha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSinFecha.AutoSize = true;
            this.labelSinFecha.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSinFecha.Location = new System.Drawing.Point(8, 6);
            this.labelSinFecha.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.labelSinFecha.Name = "labelSinFecha";
            this.labelSinFecha.Size = new System.Drawing.Size(55, 33);
            this.labelSinFecha.TabIndex = 0;
            this.labelSinFecha.Text = "No:";
            // 
            // checkBoxSinFecha
            // 
            this.checkBoxSinFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSinFecha.AutoSize = true;
            this.checkBoxSinFecha.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSinFecha.Location = new System.Drawing.Point(67, 4);
            this.checkBoxSinFecha.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxSinFecha.Name = "checkBoxSinFecha";
            this.checkBoxSinFecha.Size = new System.Drawing.Size(19, 38);
            this.checkBoxSinFecha.TabIndex = 5;
            this.checkBoxSinFecha.TabStop = false;
            this.checkBoxSinFecha.Text = "checkBox1";
            this.checkBoxSinFecha.UseVisualStyleBackColor = true;
            this.checkBoxSinFecha.CheckedChanged += new System.EventHandler(this.checkBoxSinFecha_CheckedChanged);
            // 
            // panelFechaRequrido
            // 
            this.panelFechaRequrido.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelFechaRequrido.Controls.Add(this.dateTimePickerFechaRequerido);
            this.panelFechaRequrido.Location = new System.Drawing.Point(4, 4);
            this.panelFechaRequrido.Margin = new System.Windows.Forms.Padding(4);
            this.panelFechaRequrido.Name = "panelFechaRequrido";
            this.panelFechaRequrido.Size = new System.Drawing.Size(206, 39);
            this.panelFechaRequrido.TabIndex = 4;
            // 
            // dateTimePickerFechaRequerido
            // 
            this.dateTimePickerFechaRequerido.CalendarFont = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaRequerido.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePickerFechaRequerido.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaRequerido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaRequerido.Location = new System.Drawing.Point(0, 0);
            this.dateTimePickerFechaRequerido.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimePickerFechaRequerido.MinDate = new System.DateTime(1899, 11, 1, 0, 0, 0, 0);
            this.dateTimePickerFechaRequerido.Name = "dateTimePickerFechaRequerido";
            this.dateTimePickerFechaRequerido.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerFechaRequerido.Size = new System.Drawing.Size(205, 38);
            this.dateTimePickerFechaRequerido.TabIndex = 4;
            this.dateTimePickerFechaRequerido.Value = new System.DateTime(2015, 6, 4, 0, 0, 0, 0);
            // 
            // comboBoxClientes
            // 
            this.comboBoxClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClientes.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClientes.FormattingEnabled = true;
            this.comboBoxClientes.Location = new System.Drawing.Point(194, 60);
            this.comboBoxClientes.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxClientes.Name = "comboBoxClientes";
            this.comboBoxClientes.Size = new System.Drawing.Size(390, 40);
            this.comboBoxClientes.TabIndex = 0;
            // 
            // dateTimePickerFechaOrdenado
            // 
            this.dateTimePickerFechaOrdenado.CalendarFont = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaOrdenado.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePickerFechaOrdenado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaOrdenado.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaOrdenado.Location = new System.Drawing.Point(825, 60);
            this.dateTimePickerFechaOrdenado.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerFechaOrdenado.MinDate = new System.DateTime(1899, 11, 1, 0, 0, 0, 0);
            this.dateTimePickerFechaOrdenado.Name = "dateTimePickerFechaOrdenado";
            this.dateTimePickerFechaOrdenado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerFechaOrdenado.Size = new System.Drawing.Size(205, 38);
            this.dateTimePickerFechaOrdenado.TabIndex = 3;
            this.dateTimePickerFechaOrdenado.Value = new System.DateTime(2015, 6, 4, 0, 0, 0, 0);
            // 
            // labelFechaRequerido
            // 
            this.labelFechaRequerido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFechaRequerido.AutoSize = true;
            this.labelFechaRequerido.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaRequerido.Location = new System.Drawing.Point(592, 109);
            this.labelFechaRequerido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFechaRequerido.Name = "labelFechaRequerido";
            this.labelFechaRequerido.Size = new System.Drawing.Size(214, 33);
            this.labelFechaRequerido.TabIndex = 8;
            this.labelFechaRequerido.Text = "Fecha Requerido:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewProductos, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 196);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 0, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.82427F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.36032F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.906882F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1125, 600);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.AllowUserToAddRows = false;
            this.dataGridViewProductos.AllowUserToDeleteRows = false;
            this.dataGridViewProductos.AllowUserToOrderColumns = true;
            this.dataGridViewProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.dataGridViewProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewProductos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProductos.ColumnHeadersHeight = 35;
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.producto,
            this.cantidad,
            this.precio,
            this.descuento});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProductos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProductos.EnableHeadersVisualStyles = false;
            this.dataGridViewProductos.Location = new System.Drawing.Point(16, 170);
            this.dataGridViewProductos.Margin = new System.Windows.Forms.Padding(16, 4, 4, 4);
            this.dataGridViewProductos.MultiSelect = false;
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.ReadOnly = true;
            this.dataGridViewProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewProductos.RowHeadersVisible = false;
            this.dataGridViewProductos.RowHeadersWidth = 51;
            this.dataGridViewProductos.RowTemplate.ReadOnly = true;
            this.dataGridViewProductos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductos.ShowCellErrors = false;
            this.dataGridViewProductos.ShowCellToolTips = false;
            this.dataGridViewProductos.ShowEditingIcon = false;
            this.dataGridViewProductos.ShowRowErrors = false;
            this.dataGridViewProductos.Size = new System.Drawing.Size(1105, 371);
            this.dataGridViewProductos.TabIndex = 3;
            this.dataGridViewProductos.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewProductos_RowPrePaint);
            // 
            // numero
            // 
            this.numero.HeaderText = "";
            this.numero.MinimumWidth = 6;
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Width = 21;
            // 
            // producto
            // 
            this.producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.producto.HeaderText = "PRODUCTO";
            this.producto.MinimumWidth = 6;
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            this.producto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cantidad
            // 
            this.cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.cantidad.DefaultCellStyle = dataGridViewCellStyle3;
            this.cantidad.HeaderText = "CANT.";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cantidad.Width = 75;
            // 
            // precio
            // 
            this.precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.NullValue = "0";
            this.precio.DefaultCellStyle = dataGridViewCellStyle4;
            this.precio.HeaderText = "PRECIO";
            this.precio.MinimumWidth = 6;
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.precio.Width = 105;
            // 
            // descuento
            // 
            this.descuento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.descuento.DefaultCellStyle = dataGridViewCellStyle5;
            this.descuento.HeaderText = "DESC.";
            this.descuento.MinimumWidth = 6;
            this.descuento.Name = "descuento";
            this.descuento.ReadOnly = true;
            this.descuento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.descuento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.descuento.Width = 95;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.labelSubTitulo2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.88462F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.11538F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1125, 162);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // labelSubTitulo2
            // 
            this.labelSubTitulo2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSubTitulo2.AutoSize = true;
            this.labelSubTitulo2.Font = new System.Drawing.Font("Candara", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubTitulo2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelSubTitulo2.Location = new System.Drawing.Point(4, 1);
            this.labelSubTitulo2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSubTitulo2.Name = "labelSubTitulo2";
            this.labelSubTitulo2.Size = new System.Drawing.Size(262, 54);
            this.labelSubTitulo2.TabIndex = 2;
            this.labelSubTitulo2.Text = "PRODUCTOS";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 10;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.94313F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.00948F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.03791F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.50237F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.57346F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.00474F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.85782F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.8584817F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.50237F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.50237F));
            this.tableLayoutPanel3.Controls.Add(this.textBoxDescuento, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelCantidad, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelDescuento, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonAgregarProducto, 9, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonEliminarProducto, 8, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelPeso, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxCantidad, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 108);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1122, 49);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // textBoxDescuento
            // 
            this.textBoxDescuento.BackColor = System.Drawing.Color.Orange;
            this.textBoxDescuento.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescuento.Location = new System.Drawing.Point(856, 4);
            this.textBoxDescuento.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescuento.MaxLength = 6;
            this.textBoxDescuento.Name = "textBoxDescuento";
            this.textBoxDescuento.Size = new System.Drawing.Size(92, 40);
            this.textBoxDescuento.TabIndex = 10;
            this.textBoxDescuento.Text = "0";
            this.textBoxDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDescuento_KeyPress);
            // 
            // labelCantidad
            // 
            this.labelCantidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidad.Location = new System.Drawing.Point(8, 8);
            this.labelCantidad.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(125, 33);
            this.labelCantidad.TabIndex = 3;
            this.labelCantidad.Text = "Cantidad:";
            // 
            // labelDescuento
            // 
            this.labelDescuento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelDescuento.AutoSize = true;
            this.labelDescuento.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescuento.Location = new System.Drawing.Point(697, 8);
            this.labelDescuento.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.labelDescuento.Name = "labelDescuento";
            this.labelDescuento.Size = new System.Drawing.Size(145, 33);
            this.labelDescuento.TabIndex = 5;
            this.labelDescuento.Text = "Descuento:";
            // 
            // buttonAgregarProducto
            // 
            this.buttonAgregarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAgregarProducto.BackgroundImage = global::CapaPresentacion.Properties.Resources.agregar_producto;
            this.buttonAgregarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAgregarProducto.Location = new System.Drawing.Point(1066, 0);
            this.buttonAgregarProducto.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAgregarProducto.Name = "buttonAgregarProducto";
            this.buttonAgregarProducto.Size = new System.Drawing.Size(56, 49);
            this.buttonAgregarProducto.TabIndex = 11;
            this.toolTipAgregarProducto.SetToolTip(this.buttonAgregarProducto, "Agregar Producto a la Lista");
            this.buttonAgregarProducto.UseVisualStyleBackColor = true;
            this.buttonAgregarProducto.Click += new System.EventHandler(this.buttonAgregarProducto_Click);
            // 
            // buttonEliminarProducto
            // 
            this.buttonEliminarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEliminarProducto.BackgroundImage = global::CapaPresentacion.Properties.Resources.eliminar_producto;
            this.buttonEliminarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEliminarProducto.Location = new System.Drawing.Point(1016, 0);
            this.buttonEliminarProducto.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEliminarProducto.Name = "buttonEliminarProducto";
            this.buttonEliminarProducto.Size = new System.Drawing.Size(50, 49);
            this.buttonEliminarProducto.TabIndex = 10;
            this.toolTipEliminarProducto.SetToolTip(this.buttonEliminarProducto, "Eliminar Producto seleccionado");
            this.buttonEliminarProducto.UseVisualStyleBackColor = true;
            this.buttonEliminarProducto.Click += new System.EventHandler(this.buttonEliminarProducto_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.31551F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.68449F));
            this.tableLayoutPanel6.Controls.Add(this.textBoxPrecio, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.labelPrecio, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(392, 0);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(247, 49);
            this.tableLayoutPanel6.TabIndex = 9;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.BackColor = System.Drawing.Color.Orange;
            this.textBoxPrecio.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrecio.Location = new System.Drawing.Point(110, 4);
            this.textBoxPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPrecio.MaxLength = 10;
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(132, 40);
            this.textBoxPrecio.TabIndex = 9;
            this.textBoxPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrecio_KeyPress);
            // 
            // labelPrecio
            // 
            this.labelPrecio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.Location = new System.Drawing.Point(4, 8);
            this.labelPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(95, 33);
            this.labelPrecio.TabIndex = 8;
            this.labelPrecio.Text = "Precio:";
            // 
            // labelPeso
            // 
            this.labelPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPeso.AutoSize = true;
            this.labelPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeso.Location = new System.Drawing.Point(647, 9);
            this.labelPeso.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(30, 31);
            this.labelPeso.TabIndex = 13;
            this.labelPeso.Text = "$";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(957, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "%";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.BackColor = System.Drawing.Color.Orange;
            this.textBoxCantidad.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCantidad.Location = new System.Drawing.Point(194, 4);
            this.textBoxCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCantidad.MaxLength = 10;
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(147, 40);
            this.textBoxCantidad.TabIndex = 8;
            this.textBoxCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCantidad_KeyPress);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.98565F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.01435F));
            this.tableLayoutPanel4.Controls.Add(this.labelProducto, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.comboBoxProductos, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 57);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1125, 47);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // labelProducto
            // 
            this.labelProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelProducto.AutoSize = true;
            this.labelProducto.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducto.Location = new System.Drawing.Point(8, 7);
            this.labelProducto.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.labelProducto.Name = "labelProducto";
            this.labelProducto.Size = new System.Drawing.Size(129, 33);
            this.labelProducto.TabIndex = 2;
            this.labelProducto.Text = "Producto:";
            // 
            // comboBoxProductos
            // 
            this.comboBoxProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProductos.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProductos.FormattingEnabled = true;
            this.comboBoxProductos.Location = new System.Drawing.Point(195, 4);
            this.comboBoxProductos.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxProductos.Name = "comboBoxProductos";
            this.comboBoxProductos.Size = new System.Drawing.Size(926, 40);
            this.comboBoxProductos.TabIndex = 7;
            this.comboBoxProductos.SelectedValueChanged += new System.EventHandler(this.comboBoxProductos_SelectedValueChanged);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.tableLayoutPanel5.Controls.Add(this.buttonGuardar, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.buttonCancelar, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(4, 552);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1117, 48);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGuardar.BackColor = System.Drawing.Color.Orange;
            this.buttonGuardar.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Location = new System.Drawing.Point(267, 0);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(284, 48);
            this.buttonGuardar.TabIndex = 0;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelar.BackColor = System.Drawing.Color.Orange;
            this.buttonCancelar.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(565, 0);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(284, 48);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FrmAgregarNuevoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 804);
            this.Controls.Add(this.tableLayoutPanelGeneral);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1261, 851);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1261, 851);
            this.Name = "FrmAgregarNuevoPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Nuevo Pedido";
            this.tableLayoutPanelGeneral.ResumeLayout(false);
            this.tableLayoutPanelLeft.ResumeLayout(false);
            this.tableLayoutPanelCentral.ResumeLayout(false);
            this.tableLayoutPanelTop.ResumeLayout(false);
            this.tableLayoutPanelTop.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.panelFechaRequrido.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGeneral;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCentral;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelSubTitulo;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Label labelTransporte;
        private System.Windows.Forms.Label labelResponsable;
        private System.Windows.Forms.ComboBox comboBoxClientes;
        private System.Windows.Forms.ComboBox comboBoxTransportes;
        private System.Windows.Forms.ComboBox comboBoxEmpleados;
        private System.Windows.Forms.Label labelFechaOrdenado;
        private System.Windows.Forms.Label labelFechaRequerido;
        private System.Windows.Forms.Label labelCostoEnvio;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaRequerido;
        private System.Windows.Forms.Label labelSubTitulo2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox textBoxCostoEnvio;
        private System.Windows.Forms.Label labelProducto;
        private System.Windows.Forms.ComboBox comboBoxProductos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textBoxDescuento;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label labelDescuento;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Button buttonAgregarProducto;
        private System.Windows.Forms.Button buttonEliminarProducto;
        private System.Windows.Forms.ToolTip toolTipAgregarProducto;
        private System.Windows.Forms.ToolTip toolTipEliminarProducto;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelPeso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label labelSinFecha;
        private System.Windows.Forms.CheckBox checkBoxSinFecha;
        private System.Windows.Forms.Panel panelFechaRequrido;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaOrdenado;


    }
}