namespace Implementacion_PPAI.Clases.No_Persistente
{
    partial class PantallaInformeProductosMasPedidos
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
            this.listaSubCategorias = new System.Windows.Forms.CheckedListBox();
            this.listaCategorias = new System.Windows.Forms.CheckedListBox();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.pnlSeleccionOpcion = new System.Windows.Forms.Panel();
            this.opcionAscendente = new System.Windows.Forms.RadioButton();
            this.opcionDescendente = new System.Windows.Forms.RadioButton();
            this.btnSeleccionarOpcion = new System.Windows.Forms.Button();
            this.pckFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pckFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCorrecto = new System.Windows.Forms.Button();
            this.lblErrorPeriodo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSeleccionarPeriodo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pnlSeleccionVisualizacion = new System.Windows.Forms.Panel();
            this.opcionExcel = new System.Windows.Forms.RadioButton();
            this.opcionPantalla = new System.Windows.Forms.RadioButton();
            this.opcionPDF = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSeleccionarVisualizacion = new System.Windows.Forms.Button();
            this.pnlSeleccionOpcion.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.pnlSeleccionVisualizacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaSubCategorias
            // 
            this.listaSubCategorias.CheckOnClick = true;
            this.listaSubCategorias.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaSubCategorias.FormattingEnabled = true;
            this.listaSubCategorias.Location = new System.Drawing.Point(68, 80);
            this.listaSubCategorias.Name = "listaSubCategorias";
            this.listaSubCategorias.Size = new System.Drawing.Size(471, 224);
            this.listaSubCategorias.TabIndex = 11;
            // 
            // listaCategorias
            // 
            this.listaCategorias.CheckOnClick = true;
            this.listaCategorias.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaCategorias.FormattingEnabled = true;
            this.listaCategorias.Location = new System.Drawing.Point(68, 80);
            this.listaCategorias.Name = "listaCategorias";
            this.listaCategorias.Size = new System.Drawing.Size(471, 224);
            this.listaCategorias.TabIndex = 9;
            this.listaCategorias.SelectedIndexChanged += new System.EventHandler(this.listaCategorias_SelectedIndexChanged);
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.btnGenerarReporte.FlatAppearance.BorderSize = 0;
            this.btnGenerarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarReporte.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnGenerarReporte.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnGenerarReporte.Location = new System.Drawing.Point(178, 59);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(170, 29);
            this.btnGenerarReporte.TabIndex = 10;
            this.btnGenerarReporte.Text = "Generar Informe";
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // pnlSeleccionOpcion
            // 
            this.pnlSeleccionOpcion.Controls.Add(this.opcionAscendente);
            this.pnlSeleccionOpcion.Controls.Add(this.opcionDescendente);
            this.pnlSeleccionOpcion.Location = new System.Drawing.Point(57, 59);
            this.pnlSeleccionOpcion.Name = "pnlSeleccionOpcion";
            this.pnlSeleccionOpcion.Size = new System.Drawing.Size(198, 67);
            this.pnlSeleccionOpcion.TabIndex = 14;
            // 
            // opcionAscendente
            // 
            this.opcionAscendente.AutoSize = true;
            this.opcionAscendente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcionAscendente.Location = new System.Drawing.Point(3, 7);
            this.opcionAscendente.Name = "opcionAscendente";
            this.opcionAscendente.Size = new System.Drawing.Size(179, 25);
            this.opcionAscendente.TabIndex = 11;
            this.opcionAscendente.TabStop = true;
            this.opcionAscendente.Text = "Orden Ascendente";
            this.opcionAscendente.UseVisualStyleBackColor = true;
            // 
            // opcionDescendente
            // 
            this.opcionDescendente.AutoSize = true;
            this.opcionDescendente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcionDescendente.Location = new System.Drawing.Point(3, 38);
            this.opcionDescendente.Name = "opcionDescendente";
            this.opcionDescendente.Size = new System.Drawing.Size(188, 25);
            this.opcionDescendente.TabIndex = 12;
            this.opcionDescendente.TabStop = true;
            this.opcionDescendente.Text = "Orden Descendente";
            this.opcionDescendente.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionarOpcion
            // 
            this.btnSeleccionarOpcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.btnSeleccionarOpcion.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarOpcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarOpcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnSeleccionarOpcion.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSeleccionarOpcion.Location = new System.Drawing.Point(80, 132);
            this.btnSeleccionarOpcion.Name = "btnSeleccionarOpcion";
            this.btnSeleccionarOpcion.Size = new System.Drawing.Size(118, 29);
            this.btnSeleccionarOpcion.TabIndex = 10;
            this.btnSeleccionarOpcion.Text = "Seleccionar";
            this.btnSeleccionarOpcion.UseVisualStyleBackColor = false;
            this.btnSeleccionarOpcion.Click += new System.EventHandler(this.btnSeleccionarOpcion_Click);
            // 
            // pckFechaHasta
            // 
            this.pckFechaHasta.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pckFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pckFechaHasta.Location = new System.Drawing.Point(177, 96);
            this.pckFechaHasta.Name = "pckFechaHasta";
            this.pckFechaHasta.Size = new System.Drawing.Size(121, 27);
            this.pckFechaHasta.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(56, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha desde:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(56, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha hasta:";
            // 
            // pckFechaDesde
            // 
            this.pckFechaDesde.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pckFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pckFechaDesde.Location = new System.Drawing.Point(177, 59);
            this.pckFechaDesde.Name = "pckFechaDesde";
            this.pckFechaDesde.Size = new System.Drawing.Size(121, 27);
            this.pckFechaDesde.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(71, 675);
            this.panel2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1320, 74);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(67, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restaurante";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(227)))), ((int)(((byte)(210)))));
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.groupBox5);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.groupBox3);
            this.flowLayoutPanel1.Controls.Add(this.groupBox4);
            this.flowLayoutPanel1.Controls.Add(this.groupBox6);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(71, 74);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1249, 675);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1206, 59);
            this.panel4.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(422, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Informe de productos más pedidos";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.btnCancelar);
            this.groupBox5.Controls.Add(this.btnGenerarReporte);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(3, 68);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(600, 172);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "1.Informe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label5.Location = new System.Drawing.Point(7, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Seleccione una opción:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(128)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelar.Location = new System.Drawing.Point(178, 100);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(170, 29);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCorrecto);
            this.groupBox1.Controls.Add(this.lblErrorPeriodo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnSeleccionarPeriodo);
            this.groupBox1.Controls.Add(this.pckFechaHasta);
            this.groupBox1.Controls.Add(this.pckFechaDesde);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(609, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 172);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "2.Período";
            // 
            // lblCorrecto
            // 
            this.lblCorrecto.Enabled = false;
            this.lblCorrecto.FlatAppearance.BorderSize = 0;
            this.lblCorrecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCorrecto.Image = global::Implementacion_PPAI.Properties.Resources.check;
            this.lblCorrecto.Location = new System.Drawing.Point(304, 89);
            this.lblCorrecto.Name = "lblCorrecto";
            this.lblCorrecto.Size = new System.Drawing.Size(195, 45);
            this.lblCorrecto.TabIndex = 14;
            this.lblCorrecto.Text = "¡Correcto!";
            this.lblCorrecto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.lblCorrecto.UseVisualStyleBackColor = true;
            this.lblCorrecto.Visible = false;
            // 
            // lblErrorPeriodo
            // 
            this.lblErrorPeriodo.Enabled = false;
            this.lblErrorPeriodo.FlatAppearance.BorderSize = 0;
            this.lblErrorPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblErrorPeriodo.Image = global::Implementacion_PPAI.Properties.Resources.error;
            this.lblErrorPeriodo.Location = new System.Drawing.Point(304, 89);
            this.lblErrorPeriodo.Name = "lblErrorPeriodo";
            this.lblErrorPeriodo.Size = new System.Drawing.Size(195, 45);
            this.lblErrorPeriodo.TabIndex = 13;
            this.lblErrorPeriodo.Text = "¡Fecha no válida!";
            this.lblErrorPeriodo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.lblErrorPeriodo.UseVisualStyleBackColor = true;
            this.lblErrorPeriodo.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.Location = new System.Drawing.Point(7, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ingrese un período:";
            // 
            // btnSeleccionarPeriodo
            // 
            this.btnSeleccionarPeriodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.btnSeleccionarPeriodo.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarPeriodo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnSeleccionarPeriodo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSeleccionarPeriodo.Location = new System.Drawing.Point(180, 129);
            this.btnSeleccionarPeriodo.Name = "btnSeleccionarPeriodo";
            this.btnSeleccionarPeriodo.Size = new System.Drawing.Size(118, 29);
            this.btnSeleccionarPeriodo.TabIndex = 8;
            this.btnSeleccionarPeriodo.Text = "Seleccionar";
            this.btnSeleccionarPeriodo.UseVisualStyleBackColor = false;
            this.btnSeleccionarPeriodo.Click += new System.EventHandler(this.TomarSeleccionPeriodo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.listaCategorias);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 360);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "3.Categorías";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label7.Location = new System.Drawing.Point(7, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(255, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Seleccione una o varias categorias:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.listaSubCategorias);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(609, 246);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(600, 360);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "4.Subcategorías";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label8.Location = new System.Drawing.Point(8, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(279, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Seleccione una o varias subcategorias:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.pnlSeleccionOpcion);
            this.groupBox4.Controls.Add(this.btnSeleccionarOpcion);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(3, 612);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(600, 210);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "5.Ordenamiento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label9.Location = new System.Drawing.Point(10, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "Ingrese una opción:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.pnlSeleccionVisualizacion);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.btnSeleccionarVisualizacion);
            this.groupBox6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(609, 612);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(600, 210);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "6.Visualización";
            // 
            // pnlSeleccionVisualizacion
            // 
            this.pnlSeleccionVisualizacion.Controls.Add(this.opcionExcel);
            this.pnlSeleccionVisualizacion.Controls.Add(this.opcionPantalla);
            this.pnlSeleccionVisualizacion.Controls.Add(this.opcionPDF);
            this.pnlSeleccionVisualizacion.Location = new System.Drawing.Point(68, 59);
            this.pnlSeleccionVisualizacion.Name = "pnlSeleccionVisualizacion";
            this.pnlSeleccionVisualizacion.Size = new System.Drawing.Size(135, 102);
            this.pnlSeleccionVisualizacion.TabIndex = 15;
            // 
            // opcionExcel
            // 
            this.opcionExcel.AutoSize = true;
            this.opcionExcel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcionExcel.Location = new System.Drawing.Point(3, 69);
            this.opcionExcel.Name = "opcionExcel";
            this.opcionExcel.Size = new System.Drawing.Size(68, 25);
            this.opcionExcel.TabIndex = 13;
            this.opcionExcel.TabStop = true;
            this.opcionExcel.Text = "Excel";
            this.opcionExcel.UseVisualStyleBackColor = true;
            // 
            // opcionPantalla
            // 
            this.opcionPantalla.AutoSize = true;
            this.opcionPantalla.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcionPantalla.Location = new System.Drawing.Point(3, 7);
            this.opcionPantalla.Name = "opcionPantalla";
            this.opcionPantalla.Size = new System.Drawing.Size(121, 25);
            this.opcionPantalla.TabIndex = 11;
            this.opcionPantalla.TabStop = true;
            this.opcionPantalla.Text = "Por Pantalla";
            this.opcionPantalla.UseVisualStyleBackColor = true;
            // 
            // opcionPDF
            // 
            this.opcionPDF.AutoSize = true;
            this.opcionPDF.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcionPDF.Location = new System.Drawing.Point(3, 38);
            this.opcionPDF.Name = "opcionPDF";
            this.opcionPDF.Size = new System.Drawing.Size(57, 25);
            this.opcionPDF.TabIndex = 12;
            this.opcionPDF.TabStop = true;
            this.opcionPDF.Text = "PDF";
            this.opcionPDF.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label10.Location = new System.Drawing.Point(7, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(279, 19);
            this.label10.TabIndex = 12;
            this.label10.Text = "Seleccione una forma de visualización:";
            // 
            // btnSeleccionarVisualizacion
            // 
            this.btnSeleccionarVisualizacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.btnSeleccionarVisualizacion.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarVisualizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarVisualizacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnSeleccionarVisualizacion.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSeleccionarVisualizacion.Location = new System.Drawing.Point(85, 167);
            this.btnSeleccionarVisualizacion.Name = "btnSeleccionarVisualizacion";
            this.btnSeleccionarVisualizacion.Size = new System.Drawing.Size(118, 29);
            this.btnSeleccionarVisualizacion.TabIndex = 10;
            this.btnSeleccionarVisualizacion.Text = "Seleccionar";
            this.btnSeleccionarVisualizacion.UseVisualStyleBackColor = false;
            this.btnSeleccionarVisualizacion.Click += new System.EventHandler(this.btnSeleccionarVisualizacion_Click);
            // 
            // PantallaInformeProductosMasPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 749);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.Name = "PantallaInformeProductosMasPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informe de productos mas pedidos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PantallaInformeProductosMasPedidos_Load);
            this.pnlSeleccionOpcion.ResumeLayout(false);
            this.pnlSeleccionOpcion.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.pnlSeleccionVisualizacion.ResumeLayout(false);
            this.pnlSeleccionVisualizacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker pckFechaHasta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker pckFechaDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton opcionDescendente;
        private System.Windows.Forms.RadioButton opcionAscendente;
        private System.Windows.Forms.Button btnSeleccionarOpcion;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlSeleccionOpcion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSeleccionarPeriodo;
        public System.Windows.Forms.CheckedListBox listaCategorias;
        public System.Windows.Forms.CheckedListBox listaSubCategorias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSeleccionarVisualizacion;
        private System.Windows.Forms.Panel pnlSeleccionVisualizacion;
        private System.Windows.Forms.RadioButton opcionExcel;
        private System.Windows.Forms.RadioButton opcionPantalla;
        private System.Windows.Forms.RadioButton opcionPDF;
        private System.Windows.Forms.Button lblErrorPeriodo;
        private System.Windows.Forms.Button lblCorrecto;
    }
}