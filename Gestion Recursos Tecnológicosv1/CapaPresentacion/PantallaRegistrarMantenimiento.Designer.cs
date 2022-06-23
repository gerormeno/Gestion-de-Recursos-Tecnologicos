
namespace Gestion_Recursos_Tecnológicos
{
    partial class PantallaRegistrarMantenimiento
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaRegistrarMantenimiento));
            this.grillaRecursosTecnologicos = new System.Windows.Forms.DataGridView();
            this.btnIngresarAMantenimiento = new System.Windows.Forms.Button();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.txtRazonMantenimiento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuarioLogueado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFechaActual = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grillaTurnosACancelar = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cientifico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaYHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notificarViaMail = new System.Windows.Forms.RadioButton();
            this.notificarViaWSP = new System.Windows.Forms.RadioButton();
            this.numeroRT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoRecurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grillaRecursosTecnologicos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTurnosACancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaRecursosTecnologicos
            // 
            this.grillaRecursosTecnologicos.AllowUserToAddRows = false;
            this.grillaRecursosTecnologicos.AllowUserToDeleteRows = false;
            this.grillaRecursosTecnologicos.AllowUserToResizeRows = false;
            this.grillaRecursosTecnologicos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(85)))));
            this.grillaRecursosTecnologicos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grillaRecursosTecnologicos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(188)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(188)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaRecursosTecnologicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grillaRecursosTecnologicos.ColumnHeadersHeight = 24;
            this.grillaRecursosTecnologicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grillaRecursosTecnologicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroRT,
            this.tipoRecurso,
            this.marca,
            this.modelo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grillaRecursosTecnologicos.DefaultCellStyle = dataGridViewCellStyle2;
            this.grillaRecursosTecnologicos.EnableHeadersVisualStyles = false;
            this.grillaRecursosTecnologicos.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.grillaRecursosTecnologicos.Location = new System.Drawing.Point(6, 19);
            this.grillaRecursosTecnologicos.MultiSelect = false;
            this.grillaRecursosTecnologicos.Name = "grillaRecursosTecnologicos";
            this.grillaRecursosTecnologicos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaRecursosTecnologicos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grillaRecursosTecnologicos.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.grillaRecursosTecnologicos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grillaRecursosTecnologicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaRecursosTecnologicos.Size = new System.Drawing.Size(397, 315);
            this.grillaRecursosTecnologicos.TabIndex = 3;
            this.grillaRecursosTecnologicos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaRecursosTecnologicos_CellClick);
            this.grillaRecursosTecnologicos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaRecursosTecnologicos_CellContentClick);
            this.grillaRecursosTecnologicos.SelectionChanged += new System.EventHandler(this.grillaRecursosTecnologicos_SelectionChanged);
            // 
            // btnIngresarAMantenimiento
            // 
            this.btnIngresarAMantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(188)))), ((int)(((byte)(164)))));
            this.btnIngresarAMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarAMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarAMantenimiento.ForeColor = System.Drawing.Color.Black;
            this.btnIngresarAMantenimiento.Location = new System.Drawing.Point(645, 543);
            this.btnIngresarAMantenimiento.Name = "btnIngresarAMantenimiento";
            this.btnIngresarAMantenimiento.Size = new System.Drawing.Size(165, 72);
            this.btnIngresarAMantenimiento.TabIndex = 5;
            this.btnIngresarAMantenimiento.Text = "Ingresar a mantenimiento";
            this.btnIngresarAMantenimiento.UseVisualStyleBackColor = false;
            this.btnIngresarAMantenimiento.Click += new System.EventHandler(this.btnIngresarAMantenimiento_Click);
            // 
            // calendario
            // 
            this.calendario.BackColor = System.Drawing.Color.Turquoise;
            this.calendario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calendario.Enabled = false;
            this.calendario.Location = new System.Drawing.Point(6, 375);
            this.calendario.MaxSelectionCount = 1;
            this.calendario.Name = "calendario";
            this.calendario.ShowToday = false;
            this.calendario.TabIndex = 3;
            this.calendario.TitleBackColor = System.Drawing.Color.OrangeRed;
            this.calendario.TrailingForeColor = System.Drawing.Color.Red;
            this.calendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendario_DateSelected);
            // 
            // txtRazonMantenimiento
            // 
            this.txtRazonMantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(38)))), ((int)(((byte)(66)))));
            this.txtRazonMantenimiento.Enabled = false;
            this.txtRazonMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonMantenimiento.ForeColor = System.Drawing.Color.White;
            this.txtRazonMantenimiento.Location = new System.Drawing.Point(266, 375);
            this.txtRazonMantenimiento.Multiline = true;
            this.txtRazonMantenimiento.Name = "txtRazonMantenimiento";
            this.txtRazonMantenimiento.Size = new System.Drawing.Size(544, 162);
            this.txtRazonMantenimiento.TabIndex = 4;
            this.txtRazonMantenimiento.TextChanged += new System.EventHandler(this.txtRazonMantenimiento_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(188)))), ((int)(((byte)(164)))));
            this.label1.Location = new System.Drawing.Point(155, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(592, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "REGISTRAR MANTENIMIENTO CORRECTIVO";
            // 
            // lblUsuarioLogueado
            // 
            this.lblUsuarioLogueado.AutoSize = true;
            this.lblUsuarioLogueado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogueado.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioLogueado.Location = new System.Drawing.Point(6, 7);
            this.lblUsuarioLogueado.Name = "lblUsuarioLogueado";
            this.lblUsuarioLogueado.Size = new System.Drawing.Size(111, 15);
            this.lblUsuarioLogueado.TabIndex = 8;
            this.lblUsuarioLogueado.Text = "Usuario logueado: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fecha estimada de fin de mantenimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(263, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Motivo de mantenimiento:";
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.AutoSize = true;
            this.lblFechaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaActual.ForeColor = System.Drawing.Color.White;
            this.lblFechaActual.Location = new System.Drawing.Point(70, 22);
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(47, 15);
            this.lblFechaActual.TabIndex = 12;
            this.lblFechaActual.Text = "Fecha: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblUsuarioLogueado);
            this.groupBox1.Controls.Add(this.lblFechaActual);
            this.groupBox1.Location = new System.Drawing.Point(604, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 42);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.notificarViaWSP);
            this.groupBox2.Controls.Add(this.notificarViaMail);
            this.groupBox2.Controls.Add(this.grillaTurnosACancelar);
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Controls.Add(this.grillaRecursosTecnologicos);
            this.groupBox2.Controls.Add(this.btnIngresarAMantenimiento);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtRazonMantenimiento);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.calendario);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(816, 620);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccione un RT y complete los campos";
            // 
            // grillaTurnosACancelar
            // 
            this.grillaTurnosACancelar.AllowUserToAddRows = false;
            this.grillaTurnosACancelar.AllowUserToDeleteRows = false;
            this.grillaTurnosACancelar.AllowUserToResizeRows = false;
            this.grillaTurnosACancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(85)))));
            this.grillaTurnosACancelar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grillaTurnosACancelar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(188)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(188)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaTurnosACancelar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grillaTurnosACancelar.ColumnHeadersHeight = 24;
            this.grillaTurnosACancelar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grillaTurnosACancelar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.cientifico,
            this.fechaYHora});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grillaTurnosACancelar.DefaultCellStyle = dataGridViewCellStyle6;
            this.grillaTurnosACancelar.EnableHeadersVisualStyles = false;
            this.grillaTurnosACancelar.Location = new System.Drawing.Point(413, 19);
            this.grillaTurnosACancelar.MultiSelect = false;
            this.grillaTurnosACancelar.Name = "grillaTurnosACancelar";
            this.grillaTurnosACancelar.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaTurnosACancelar.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grillaTurnosACancelar.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            this.grillaTurnosACancelar.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.grillaTurnosACancelar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaTurnosACancelar.Size = new System.Drawing.Size(397, 315);
            this.grillaTurnosACancelar.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "N° de RT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // cientifico
            // 
            this.cientifico.HeaderText = "Científico";
            this.cientifico.Name = "cientifico";
            this.cientifico.ReadOnly = true;
            this.cientifico.Width = 160;
            // 
            // fechaYHora
            // 
            this.fechaYHora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechaYHora.HeaderText = "Fecha y hora de reserva";
            this.fechaYHora.Name = "fechaYHora";
            this.fechaYHora.ReadOnly = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(188)))), ((int)(((byte)(164)))));
            this.btnCancelar.Location = new System.Drawing.Point(6, 543);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(165, 72);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gestion_Recursos_Tecnológicos.Properties.Resources.logo_128;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // notificarViaMail
            // 
            this.notificarViaMail.AutoSize = true;
            this.notificarViaMail.Checked = true;
            this.notificarViaMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificarViaMail.Location = new System.Drawing.Point(464, 559);
            this.notificarViaMail.Name = "notificarViaMail";
            this.notificarViaMail.Size = new System.Drawing.Size(134, 22);
            this.notificarViaMail.TabIndex = 12;
            this.notificarViaMail.TabStop = true;
            this.notificarViaMail.Text = "Notificar vía mail";
            this.notificarViaMail.UseVisualStyleBackColor = true;
            // 
            // notificarViaWSP
            // 
            this.notificarViaWSP.AutoSize = true;
            this.notificarViaWSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificarViaWSP.Location = new System.Drawing.Point(464, 580);
            this.notificarViaWSP.Name = "notificarViaWSP";
            this.notificarViaWSP.Size = new System.Drawing.Size(175, 22);
            this.notificarViaWSP.TabIndex = 13;
            this.notificarViaWSP.Text = "Notificar vía WhatsApp";
            this.notificarViaWSP.UseVisualStyleBackColor = true;
            // 
            // numeroRT
            // 
            this.numeroRT.HeaderText = "N° RT";
            this.numeroRT.Name = "numeroRT";
            this.numeroRT.ReadOnly = true;
            this.numeroRT.Width = 60;
            // 
            // tipoRecurso
            // 
            this.tipoRecurso.HeaderText = "Tipo recurso";
            this.tipoRecurso.Name = "tipoRecurso";
            this.tipoRecurso.ReadOnly = true;
            this.tipoRecurso.Width = 150;
            // 
            // marca
            // 
            this.marca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            // 
            // modelo
            // 
            this.modelo.HeaderText = "Modelo";
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            this.modelo.Width = 75;
            // 
            // PantallaRegistrarMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(39)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(842, 744);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PantallaRegistrarMantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión Recursos Tecnológicos";
            this.Load += new System.EventHandler(this.PantallaRegistrarMantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaRecursosTecnologicos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTurnosACancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grillaRecursosTecnologicos;
        private System.Windows.Forms.Button btnIngresarAMantenimiento;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.TextBox txtRazonMantenimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsuarioLogueado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFechaActual;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView grillaTurnosACancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cientifico;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaYHora;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton notificarViaWSP;
        private System.Windows.Forms.RadioButton notificarViaMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroRT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoRecurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
    }
}

