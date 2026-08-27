namespace JogoCorridaWinFormsApp
{
    partial class FormInicio
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
            groupBox1 = new GroupBox();
            btnSair = new Button();
            btnDificil = new Button();
            btnMedio = new Button();
            btnFacil = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSair);
            groupBox1.Controls.Add(btnDificil);
            groupBox1.Controls.Add(btnMedio);
            groupBox1.Controls.Add(btnFacil);
            groupBox1.Location = new Point(12, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(731, 483);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selecione o nível";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Red;
            btnSair.Location = new Point(200, 265);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(248, 48);
            btnSair.TabIndex = 3;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnDificil
            // 
            btnDificil.BackColor = Color.FromArgb(0, 192, 192);
            btnDificil.Location = new Point(411, 202);
            btnDificil.Name = "btnDificil";
            btnDificil.Size = new Size(158, 57);
            btnDificil.TabIndex = 2;
            btnDificil.Text = "Difícil";
            btnDificil.UseVisualStyleBackColor = false;
            btnDificil.Click += btnDificil_Click;
            // 
            // btnMedio
            // 
            btnMedio.BackColor = Color.Cyan;
            btnMedio.Location = new Point(247, 202);
            btnMedio.Name = "btnMedio";
            btnMedio.Size = new Size(158, 57);
            btnMedio.TabIndex = 1;
            btnMedio.Text = "Médio";
            btnMedio.UseVisualStyleBackColor = false;
            btnMedio.Click += btnMedio_Click;
            // 
            // btnFacil
            // 
            btnFacil.BackColor = Color.FromArgb(128, 255, 255);
            btnFacil.Location = new Point(83, 202);
            btnFacil.Name = "btnFacil";
            btnFacil.Size = new Size(158, 57);
            btnFacil.TabIndex = 0;
            btnFacil.Text = "Fácil";
            btnFacil.UseVisualStyleBackColor = false;
            btnFacil.Click += btnFacil_Click;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 573);
            Controls.Add(groupBox1);
            Name = "FormInicio";
            Text = "FormInicio";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnFacil;
        private Button btnSair;
        private Button btnDificil;
        private Button btnMedio;
    }
}