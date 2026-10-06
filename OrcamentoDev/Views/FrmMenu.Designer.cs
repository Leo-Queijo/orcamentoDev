namespace OrcamentoDev.Views
{
    partial class FrmMenu
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
            lblBoasVindas = new Label();
            btnNovoOrcamento = new Button();
            btnRelatorio = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // lblBoasVindas
            // 
            lblBoasVindas.AutoSize = true;
            lblBoasVindas.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBoasVindas.ForeColor = SystemColors.MenuText;
            lblBoasVindas.Location = new Point(331, 95);
            lblBoasVindas.Name = "lblBoasVindas";
            lblBoasVindas.Size = new Size(375, 28);
            lblBoasVindas.TabIndex = 0;
            lblBoasVindas.Text = "Bem-Vindo ao Sistema de Orçamentos";
            lblBoasVindas.Click += lblBoasVindas_Click;
            // 
            // btnNovoOrcamento
            // 
            btnNovoOrcamento.Location = new Point(318, 294);
            btnNovoOrcamento.Name = "btnNovoOrcamento";
            btnNovoOrcamento.Size = new Size(117, 23);
            btnNovoOrcamento.TabIndex = 1;
            btnNovoOrcamento.Text = "Novo Orçamento";
            btnNovoOrcamento.UseVisualStyleBackColor = true;
            btnNovoOrcamento.Click += btnNovoOrcamento_Click;
            // 
            // btnRelatorio
            // 
            btnRelatorio.Location = new Point(474, 294);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(75, 23);
            btnRelatorio.TabIndex = 2;
            btnRelatorio.Text = "Relatorio";
            btnRelatorio.UseVisualStyleBackColor = true;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(574, 294);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 3;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 356);
            Controls.Add(btnSair);
            Controls.Add(btnRelatorio);
            Controls.Add(btnNovoOrcamento);
            Controls.Add(lblBoasVindas);
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal - Orçamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBoasVindas;
        private Button btnNovoOrcamento;
        private Button btnRelatorio;
        private Button btnSair;
    }
}