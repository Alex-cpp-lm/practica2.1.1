namespace practica2._1._1
{
    partial class InventarioForm
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
            txtId = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtNombreCorto = new TextBox();
            txtSerie = new TextBox();
            txtColor = new TextBox();
            txtObservaciones = new TextBox();
            cmbBoxTipoAdqui = new ComboBox();
            cmbBoxArea = new ComboBox();
            txtFechaAdquisicion = new DateTimePicker();
            btnCancelar = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            label8 = new Label();
            txtDescripcion = new TextBox();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.AutoSize = true;
            txtId.Location = new Point(12, 9);
            txtId.Name = "txtId";
            txtId.Size = new Size(195, 15);
            txtId.TabIndex = 0;
            txtId.Text = "ID:  *Se agregará automaticamente*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre corto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "Serie: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 108);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "Color:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(268, 48);
            label4.Name = "label4";
            label4.Size = new Size(123, 15);
            label4.TabIndex = 4;
            label4.Text = "Fecha de Adquisición:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(268, 81);
            label5.Name = "label5";
            label5.Size = new Size(116, 15);
            label5.TabIndex = 5;
            label5.Text = "Tipo de Adquisición:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(268, 113);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 6;
            label6.Text = "Area:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 181);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 7;
            label7.Text = "Observaciones:";
            // 
            // txtNombreCorto
            // 
            txtNombreCorto.Location = new Point(103, 40);
            txtNombreCorto.Name = "txtNombreCorto";
            txtNombreCorto.Size = new Size(159, 23);
            txtNombreCorto.TabIndex = 8;
            // 
            // txtSerie
            // 
            txtSerie.Location = new Point(56, 73);
            txtSerie.Name = "txtSerie";
            txtSerie.Size = new Size(206, 23);
            txtSerie.TabIndex = 9;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(56, 105);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(205, 23);
            txtColor.TabIndex = 10;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(103, 181);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(402, 31);
            txtObservaciones.TabIndex = 11;
            // 
            // cmbBoxTipoAdqui
            // 
            cmbBoxTipoAdqui.FormattingEnabled = true;
            cmbBoxTipoAdqui.Items.AddRange(new object[] { "Online", "En Caja" });
            cmbBoxTipoAdqui.Location = new Point(390, 78);
            cmbBoxTipoAdqui.Name = "cmbBoxTipoAdqui";
            cmbBoxTipoAdqui.Size = new Size(121, 23);
            cmbBoxTipoAdqui.TabIndex = 12;
            // 
            // cmbBoxArea
            // 
            cmbBoxArea.FormattingEnabled = true;
            cmbBoxArea.Location = new Point(308, 110);
            cmbBoxArea.Name = "cmbBoxArea";
            cmbBoxArea.Size = new Size(203, 23);
            cmbBoxArea.TabIndex = 13;
            // 
            // txtFechaAdquisicion
            // 
            txtFechaAdquisicion.Location = new Point(397, 43);
            txtFechaAdquisicion.Name = "txtFechaAdquisicion";
            txtFechaAdquisicion.Size = new Size(114, 23);
            txtFechaAdquisicion.TabIndex = 14;
            txtFechaAdquisicion.Value = new DateTime(2025, 2, 17, 15, 12, 47, 0);
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 255, 128);
            btnCancelar.Location = new Point(44, 218);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 41);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(128, 255, 128);
            btnGuardar.Location = new Point(210, 218);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(105, 41);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 128, 128);
            btnEliminar.Enabled = false;
            btnEliminar.Location = new Point(381, 218);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(105, 41);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 142);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 18;
            label8.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(103, 139);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(402, 36);
            txtDescripcion.TabIndex = 19;
            // 
            // InventarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 264);
            Controls.Add(txtDescripcion);
            Controls.Add(label8);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(txtFechaAdquisicion);
            Controls.Add(cmbBoxArea);
            Controls.Add(cmbBoxTipoAdqui);
            Controls.Add(txtObservaciones);
            Controls.Add(txtColor);
            Controls.Add(txtSerie);
            Controls.Add(txtNombreCorto);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtId);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "InventarioForm";
            Text = "Inventario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtId;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtNombreCorto;
        private TextBox txtSerie;
        private TextBox txtColor;
        private TextBox txtObservaciones;
        private ComboBox cmbBoxTipoAdqui;
        private ComboBox cmbBoxArea;
        private DateTimePicker txtFechaAdquisicion;
        private Button btnCancelar;
        private Button btnGuardar;
        private Button btnEliminar;
        private Label label8;
        private TextBox txtDescripcion;
    }
}