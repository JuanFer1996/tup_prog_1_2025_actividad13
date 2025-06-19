namespace ejercicio3
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
            btnIniciar = new Button();
            btnMedida = new Button();
            btnVerTodas = new Button();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(139, 34);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(75, 31);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnMedida
            // 
            btnMedida.Enabled = false;
            btnMedida.Location = new Point(109, 88);
            btnMedida.Name = "btnMedida";
            btnMedida.Size = new Size(137, 23);
            btnMedida.TabIndex = 1;
            btnMedida.Text = "Agregar Medida";
            btnMedida.UseVisualStyleBackColor = true;
            btnMedida.Click += btnMedida_Click;
            // 
            // btnVerTodas
            // 
            btnVerTodas.Enabled = false;
            btnVerTodas.Location = new Point(139, 147);
            btnVerTodas.Name = "btnVerTodas";
            btnVerTodas.Size = new Size(75, 68);
            btnVerTodas.TabIndex = 2;
            btnVerTodas.Text = "Ver todas las medidas";
            btnVerTodas.UseVisualStyleBackColor = true;
            btnVerTodas.Click += btnVerTodas_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 277);
            Controls.Add(btnVerTodas);
            Controls.Add(btnMedida);
            Controls.Add(btnIniciar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnIniciar;
        private Button btnMedida;
        private Button btnVerTodas;
    }
}
