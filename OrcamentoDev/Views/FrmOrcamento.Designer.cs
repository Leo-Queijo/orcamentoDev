namespace OrcamentoDev.Views
{
    partial class FrmOrcamento
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
            lblCliente = new Label();
            btnSalvar = new Button();
            chkUrgente = new CheckBox();
            txtCliente = new TextBox();
            lblProjeto = new Label();
            lblHoras = new Label();
            lblValorHora = new Label();
            lblResultado = new Label();
            btnCalcular = new Button();
            txtValorHora = new TextBox();
            txtHoras = new TextBox();
            txtProjeto = new TextBox();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(213, 56);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(97, 15);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Nome do Cliente";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(463, 379);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(156, 37);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Salvar Orçamento";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // chkUrgente
            // 
            chkUrgente.AutoSize = true;
            chkUrgente.Location = new Point(213, 261);
            chkUrgente.Name = "chkUrgente";
            chkUrgente.Size = new Size(205, 19);
            chkUrgente.TabIndex = 2;
            chkUrgente.Text = "Projeto Urgente (Adicional 20%%)";
            chkUrgente.UseVisualStyleBackColor = true;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(359, 48);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(226, 23);
            txtCliente.TabIndex = 3;
            // 
            // lblProjeto
            // 
            lblProjeto.AutoSize = true;
            lblProjeto.Location = new Point(213, 95);
            lblProjeto.Name = "lblProjeto";
            lblProjeto.Size = new Size(99, 15);
            lblProjeto.TabIndex = 4;
            lblProjeto.Text = "Descrição Projeto";
            // 
            // lblHoras
            // 
            lblHoras.AutoSize = true;
            lblHoras.Location = new Point(213, 141);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(94, 15);
            lblHoras.TabIndex = 5;
            lblHoras.Text = "Horas Estimadas";
            // 
            // lblValorHora
            // 
            lblValorHora.AutoSize = true;
            lblValorHora.Location = new Point(213, 188);
            lblValorHora.Name = "lblValorHora";
            lblValorHora.Size = new Size(78, 15);
            lblValorHora.TabIndex = 6;
            lblValorHora.Text = "Valor Hora R$";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(213, 310);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(78, 15);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "Valor Total R$";
            lblResultado.Click += lblResultado_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(323, 379);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(111, 37);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular Valor";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtValorHora
            // 
            txtValorHora.Location = new Point(358, 180);
            txtValorHora.Name = "txtValorHora";
            txtValorHora.Size = new Size(227, 23);
            txtValorHora.TabIndex = 9;
            // 
            // txtHoras
            // 
            txtHoras.Location = new Point(358, 133);
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(227, 23);
            txtHoras.TabIndex = 10;
            // 
            // txtProjeto
            // 
            txtProjeto.Location = new Point(358, 87);
            txtProjeto.Name = "txtProjeto";
            txtProjeto.Size = new Size(227, 23);
            txtProjeto.TabIndex = 11;
            // 
            // FrmOrcamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtProjeto);
            Controls.Add(txtHoras);
            Controls.Add(txtValorHora);
            Controls.Add(btnCalcular);
            Controls.Add(lblResultado);
            Controls.Add(lblValorHora);
            Controls.Add(lblHoras);
            Controls.Add(lblProjeto);
            Controls.Add(txtCliente);
            Controls.Add(chkUrgente);
            Controls.Add(btnSalvar);
            Controls.Add(lblCliente);
            Name = "FrmOrcamento";
            Text = "FrmOrcamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCliente;
        private Button btnSalvar;
        private CheckBox chkUrgente;
        private TextBox txtCliente;
        private Label lblProjeto;
        private Label lblHoras;
        private Label lblValorHora;
        private Label lblResultado;
        private Button btnCalcular;
        private TextBox txtValorHora;
        private TextBox txtHoras;
        private TextBox txtProjeto;
    }
}