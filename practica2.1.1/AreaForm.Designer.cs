namespace practica2._1._1
{
    partial class AreaForm
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
            txtBoxNombre = new TextBox();
            txtBoxUbicacion = new TextBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
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
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 2;
            label2.Text = "Ubicación:";
            // 
            // txtBoxNombre
            // 
            txtBoxNombre.Location = new Point(75, 36);
            txtBoxNombre.Name = "txtBoxNombre";
            txtBoxNombre.Size = new Size(174, 23);
            txtBoxNombre.TabIndex = 3;
            // 
            // txtBoxUbicacion
            // 
            txtBoxUbicacion.Location = new Point(75, 75);
            txtBoxUbicacion.Name = "txtBoxUbicacion";
            txtBoxUbicacion.Size = new Size(174, 23);
            txtBoxUbicacion.TabIndex = 4;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Yellow;
            btnCancelar.Location = new Point(12, 123);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Lime;
            btnGuardar.Location = new Point(93, 123);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Enabled = false;
            btnEliminar.Location = new Point(174, 123);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // AreaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 157);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(txtBoxUbicacion);
            Controls.Add(txtBoxNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtId);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AreaForm";
            Text = "AREA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtId;
        private Label label1;
        private Label label2;
        private TextBox txtBoxNombre;
        private TextBox txtBoxUbicacion;
        private Button btnCancelar;
        private Button btnGuardar;
        private Button btnEliminar;
    }
}