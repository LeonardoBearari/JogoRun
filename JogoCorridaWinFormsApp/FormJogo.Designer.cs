namespace JogoCorridaWinFormsApp
{
    partial class FormJogo
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJogo));
            picCarro = new PictureBox();
            
            TimerJogo = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picCarro).BeginInit();
            
            SuspendLayout();
            // 
            // picCarro
            // 
            picCarro.BackColor = Color.Transparent;
            picCarro.BackgroundImage = (Image)resources.GetObject("picCarro.BackgroundImage");
            picCarro.Location = new Point(173, 574);
            picCarro.Name = "picCarro";
            picCarro.Size = new Size(82, 201);
            picCarro.TabIndex = 0;
            picCarro.TabStop = false;
            // 
            // picObstaculo
            // 
            picObstaculo.BackColor = Color.Transparent;
            picObstaculo.BackgroundImage = (Image)resources.GetObject("picObstaculo.BackgroundImage");
            picObstaculo.Location = new Point(74, 25);
            picObstaculo.Name = "picObstaculo";
            picObstaculo.Size = new Size(94, 91);
            picObstaculo.SizeMode = PictureBoxSizeMode.StretchImage;
            picObstaculo.TabIndex = 1;
            picObstaculo.TabStop = false;
            // 
            // TimerJogo
            // 
            TimerJogo.Interval = 50;
            TimerJogo.Tick += TimerJogo_Tick;
            // 
            // FormJogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Pista;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(859, 872);
            //
            // lblPontuacao
            //
            lblPontuacao = new Label();
            lblPontuacao.AutoSize = false;
            lblPontuacao.BackColor = Color.Transparent;
            lblPontuacao.ForeColor = Color.White;
            lblPontuacao.Font = new Font("Arial", 14, FontStyle.Bold);
            lblPontuacao.TextAlign = ContentAlignment.MiddleRight;
            lblPontuacao.Location = new Point(659, 15);   
            lblPontuacao.Size = new Size(180, 30);
            lblPontuacao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPontuacao.Name = "lblPontuacao";
            lblPontuacao.Text = "Pontos: 0";
            lblPontuacao.TabIndex = 2;
            Controls.Add(lblPontuacao);


            Controls.Add(picCarro);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormJogo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += FormJogo_KeyDown;
            ((System.ComponentModel.ISupportInitialize)picCarro).EndInit();
            
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picCarro;
        
        private System.Windows.Forms.Timer TimerJogo;

        private Label lblPontuacao;
    }
}
