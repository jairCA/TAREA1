namespace Laboratorio_7_Formulario
{
    partial class frmArquitecto
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
            lblCodigo = new Label();
            lblNombre = new Label();
            lblContrato = new Label();
            lblEspecialidad = new Label();
            lblActividad = new Label();
            lblAfiliacion = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            cboCondicion = new ComboBox();
            cboEspecialidad = new ComboBox();
            cboActividad = new ComboBox();
            cboAfiliacion = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(12, 22);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Codigo";
            lblCodigo.Click += label1_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(238, 22);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblContrato
            // 
            lblContrato.AutoSize = true;
            lblContrato.Location = new Point(558, 22);
            lblContrato.Name = "lblContrato";
            lblContrato.Size = new Size(128, 15);
            lblContrato.TabIndex = 2;
            lblContrato.Text = "Condicion de Contrato";
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Location = new Point(12, 77);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(72, 15);
            lblEspecialidad.TabIndex = 3;
            lblEspecialidad.Text = "Especialidad";
            lblEspecialidad.Click += label4_Click;
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.Location = new Point(238, 77);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(99, 15);
            lblActividad.TabIndex = 4;
            lblActividad.Text = "Tipo de Actividad";
            lblActividad.Click += label5_Click;
            // 
            // lblAfiliacion
            // 
            lblAfiliacion.AutoSize = true;
            lblAfiliacion.Location = new Point(558, 77);
            lblAfiliacion.Name = "lblAfiliacion";
            lblAfiliacion.Size = new Size(99, 15);
            lblAfiliacion.TabIndex = 5;
            lblAfiliacion.Text = "Tipo de Afiliacion";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(12, 40);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(128, 23);
            txtCodigo.TabIndex = 6;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(238, 40);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(275, 23);
            txtNombre.TabIndex = 7;
            // 
            // cboCondicion
            // 
            cboCondicion.FormattingEnabled = true;
            cboCondicion.Items.AddRange(new object[] { "ESTABLE", "CONTRATADO" });
            cboCondicion.Location = new Point(558, 40);
            cboCondicion.Name = "cboCondicion";
            cboCondicion.Size = new Size(173, 23);
            cboCondicion.TabIndex = 8;
            cboCondicion.SelectedIndexChanged += cboCondicion_SelectedIndexChanged;
            // 
            // cboEspecialidad
            // 
            cboEspecialidad.FormattingEnabled = true;
            cboEspecialidad.Items.AddRange(new object[] { "ESTRUCTURAS", "RECURSOS HIDRICOS" });
            cboEspecialidad.Location = new Point(12, 95);
            cboEspecialidad.Name = "cboEspecialidad";
            cboEspecialidad.Size = new Size(165, 23);
            cboEspecialidad.TabIndex = 9;
            // 
            // cboActividad
            // 
            cboActividad.FormattingEnabled = true;
            cboActividad.Items.AddRange(new object[] { "SUPERVICION DE OBRAS", "SUPERVICION DE VIAS" });
            cboActividad.Location = new Point(238, 95);
            cboActividad.Name = "cboActividad";
            cboActividad.Size = new Size(165, 23);
            cboActividad.TabIndex = 10;
            // 
            // cboAfiliacion
            // 
            cboAfiliacion.FormattingEnabled = true;
            cboAfiliacion.Items.AddRange(new object[] { "AFP", "SNP" });
            cboAfiliacion.Location = new Point(558, 95);
            cboAfiliacion.Name = "cboAfiliacion";
            cboAfiliacion.Size = new Size(165, 23);
            cboAfiliacion.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(28, 397);
            button1.Name = "button1";
            button1.Size = new Size(128, 23);
            button1.TabIndex = 12;
            button1.Text = "Crear Objeto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(209, 397);
            button2.Name = "button2";
            button2.Size = new Size(229, 23);
            button2.TabIndex = 13;
            button2.Text = "Mostrar Informacion del Objeto";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(488, 397);
            button3.Name = "button3";
            button3.Size = new Size(110, 23);
            button3.TabIndex = 14;
            button3.Text = "Limpiar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(660, 397);
            button4.Name = "button4";
            button4.Size = new Size(110, 23);
            button4.TabIndex = 15;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(28, 124);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(695, 267);
            txtResultado.TabIndex = 16;
            txtResultado.TextChanged += textBox1_TextChanged;
            // 
            // frmArquitecto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResultado);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cboAfiliacion);
            Controls.Add(cboActividad);
            Controls.Add(cboEspecialidad);
            Controls.Add(cboCondicion);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(lblAfiliacion);
            Controls.Add(lblActividad);
            Controls.Add(lblEspecialidad);
            Controls.Add(lblContrato);
            Controls.Add(lblNombre);
            Controls.Add(lblCodigo);
            Name = "frmArquitecto";
            Text = "fmrArquitecto";
            Load += frmArquitecto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private Label lblNombre;
        private Label lblContrato;
        private Label lblEspecialidad;
        private Label lblActividad;
        private Label lblAfiliacion;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private ComboBox cboCondicion;
        private ComboBox cboEspecialidad;
        private ComboBox cboActividad;
        private ComboBox cboAfiliacion;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox txtResultado;
    }
}
