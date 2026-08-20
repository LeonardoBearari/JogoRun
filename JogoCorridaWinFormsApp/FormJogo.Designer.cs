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
            picObstaculo = new PictureBox();
            TimerJogo = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picCarro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picObstaculo).BeginInit();
            SuspendLayout();
            // 
            // picCarro
            // 
            picCarro.BackColor = Color.Transparent;
            picCarro.BackgroundImage = (Image)resources.GetObject("picCarro.BackgroundImage");
            picCarro.Location = new Point(401, 304);
            picCarro.Name = "picCarro";
            picCarro.Size = new Size(425, 351);
            picCarro.TabIndex = 0;
            picCarro.TabStop = false;
            // 
            // picObstaculo
            // 
            picObstaculo.BackColor = Color.Transparent;
            picObstaculo.BackgroundImage = Properties.Resources.obstaculo;
            picObstaculo.Image = Properties.Resources.obstaculo;
            picObstaculo.Location = new Point(60, 12);
            picObstaculo.Name = "picObstaculo";
            picObstaculo.Size = new Size(215, 127);
            picObstaculo.TabIndex = 1;
            picObstaculo.TabStop = false;
            // 
            // TimerJogo
            // 
            TimerJogo.Interval = 200;
            TimerJogo.Tick += TimerJogo_Tick;
            // 
            // FormJogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Pista;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(859, 872);
            Controls.Add(picObstaculo);
            Controls.Add(picCarro);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormJogo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += FormJogo_KeyDown;
            ((System.ComponentModel.ISupportInitialize)picCarro).EndInit();
            ((System.ComponentModel.ISupportInitialize)picObstaculo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picCarro;
        private PictureBox picObstaculo;
        private System.Windows.Forms.Timer TimerJogo;
    }
}
