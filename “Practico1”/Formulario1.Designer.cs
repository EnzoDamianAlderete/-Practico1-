namespace _Practico1_
{
    partial class Formulario1
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
            BGuardar = new Button();
            BEliminar = new Button();
            LNombre = new Label();
            LApellido = new Label();
            TBNombre = new TextBox();
            TBApellido = new TextBox();
            TBResultado = new TextBox();
            BSalir = new Button();
            SuspendLayout();
            // 
            // BGuardar
            // 
            BGuardar.Location = new Point(60, 201);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(75, 23);
            BGuardar.TabIndex = 0;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = true;
            BGuardar.Click += BGuardar_Click;
            // 
            // BEliminar
            // 
            BEliminar.Location = new Point(179, 201);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(75, 23);
            BEliminar.TabIndex = 1;
            BEliminar.Text = "Eliminar";
            BEliminar.UseVisualStyleBackColor = true;
            BEliminar.Click += BEliminar_Click;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(57, 37);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(51, 15);
            LNombre.TabIndex = 2;
            LNombre.Text = "Nombre";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(57, 104);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 3;
            LApellido.Text = "Apellido";
            // 
            // TBNombre
            // 
            TBNombre.Location = new Point(60, 65);
            TBNombre.Name = "TBNombre";
            TBNombre.Size = new Size(194, 23);
            TBNombre.TabIndex = 4;
            TBNombre.TextChanged += TBNombre_TextChanged;
            // 
            // TBApellido
            // 
            TBApellido.Location = new Point(60, 138);
            TBApellido.Name = "TBApellido";
            TBApellido.Size = new Size(194, 23);
            TBApellido.TabIndex = 5;
            TBApellido.TextChanged += textBox2_TextChanged;
            // 
            // TBResultado
            // 
            TBResultado.Cursor = Cursors.No;
            TBResultado.Location = new Point(290, 65);
            TBResultado.Multiline = true;
            TBResultado.Name = "TBResultado";
            TBResultado.Size = new Size(164, 96);
            TBResultado.TabIndex = 6;
            // 
            // BSalir
            // 
            BSalir.Location = new Point(379, 201);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(75, 23);
            BSalir.TabIndex = 7;
            BSalir.Text = "Salir";
            BSalir.UseVisualStyleBackColor = true;
            BSalir.Click += BSalir_Click;
            // 
            // Formulario1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 261);
            Controls.Add(BSalir);
            Controls.Add(TBResultado);
            Controls.Add(TBApellido);
            Controls.Add(TBNombre);
            Controls.Add(LApellido);
            Controls.Add(LNombre);
            Controls.Add(BEliminar);
            Controls.Add(BGuardar);
            Name = "Formulario1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mi Primer Forms";
            Load += Formulario1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BGuardar;
        private Button BEliminar;
        private Label LNombre;
        private Label LApellido;
        private TextBox TBNombre;
        private TextBox TBApellido;
        private TextBox TBResultado;
        private Button BSalir;
    }
}
