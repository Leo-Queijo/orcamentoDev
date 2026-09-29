namespace OrcamentoDev.Views
{
    partial class FrmSplash
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
            components = new System.ComponentModel.Container();
            lblTituloSplash = new Label();
            prgCarregando = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            lblCarregando = new Label();
            SuspendLayout();
            // 
            // lblTituloSplash
            // 
            lblTituloSplash.AutoSize = true;
            lblTituloSplash.Location = new Point(365, 35);
            lblTituloSplash.Name = "lblTituloSplash";
            lblTituloSplash.Size = new Size(132, 15);
            lblTituloSplash.TabIndex = 0;
            lblTituloSplash.Text = "Sistema de Orçamentos";
            // 
            // prgCarregando
            // 
            prgCarregando.Location = new Point(-3, 180);
            prgCarregando.Name = "prgCarregando";
            prgCarregando.Size = new Size(886, 44);
            prgCarregando.Style = ProgressBarStyle.Marquee;
            prgCarregando.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lblCarregando
            // 
            lblCarregando.AutoSize = true;
            lblCarregando.Location = new Point(404, 98);
            lblCarregando.Name = "lblCarregando";
            lblCarregando.Size = new Size(119, 15);
            lblCarregando.TabIndex = 2;
            lblCarregando.Text = "Carregando Módulos";
            // 
            // FrmSplash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(884, 224);
            Controls.Add(lblCarregando);
            Controls.Add(prgCarregando);
            Controls.Add(lblTituloSplash);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSplash";
            Text = "Splash";
            Load += FrmSplash_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloSplash;
        private ProgressBar prgCarregando;
        private System.Windows.Forms.Timer timer1;
        private Label lblCarregando;
    }
}