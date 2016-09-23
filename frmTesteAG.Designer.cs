namespace AG.WinForms
{
    partial class frmTesteAG
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblFim = new System.Windows.Forms.Label();
            this.lblTempoTotalSegundo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.txtFrase = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPopulacao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaximoGeracoes = new System.Windows.Forms.TextBox();
            this.chkElitismo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(528, 472);
            this.listBox1.TabIndex = 0;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(626, 190);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(35, 13);
            this.lblInicio.TabIndex = 1;
            this.lblInicio.Text = "label1";
            // 
            // lblFim
            // 
            this.lblFim.AutoSize = true;
            this.lblFim.Location = new System.Drawing.Point(626, 227);
            this.lblFim.Name = "lblFim";
            this.lblFim.Size = new System.Drawing.Size(35, 13);
            this.lblFim.TabIndex = 2;
            this.lblFim.Text = "label2";
            // 
            // lblTempoTotalSegundo
            // 
            this.lblTempoTotalSegundo.AutoSize = true;
            this.lblTempoTotalSegundo.Location = new System.Drawing.Point(626, 263);
            this.lblTempoTotalSegundo.Name = "lblTempoTotalSegundo";
            this.lblTempoTotalSegundo.Size = new System.Drawing.Size(35, 13);
            this.lblTempoTotalSegundo.TabIndex = 3;
            this.lblTempoTotalSegundo.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(557, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tempo total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dt. Fim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dt. Inicio";
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(699, 151);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(75, 23);
            this.btnExecutar.TabIndex = 7;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // txtFrase
            // 
            this.txtFrase.Location = new System.Drawing.Point(546, 39);
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.Size = new System.Drawing.Size(232, 20);
            this.txtFrase.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(546, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Frase";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(549, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "População";
            // 
            // txtPopulacao
            // 
            this.txtPopulacao.Location = new System.Drawing.Point(549, 76);
            this.txtPopulacao.Name = "txtPopulacao";
            this.txtPopulacao.Size = new System.Drawing.Size(95, 20);
            this.txtPopulacao.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(679, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Max. gerações";
            // 
            // txtMaximoGeracoes
            // 
            this.txtMaximoGeracoes.Location = new System.Drawing.Point(679, 76);
            this.txtMaximoGeracoes.Name = "txtMaximoGeracoes";
            this.txtMaximoGeracoes.Size = new System.Drawing.Size(95, 20);
            this.txtMaximoGeracoes.TabIndex = 12;
            // 
            // chkElitismo
            // 
            this.chkElitismo.AutoSize = true;
            this.chkElitismo.Location = new System.Drawing.Point(549, 103);
            this.chkElitismo.Name = "chkElitismo";
            this.chkElitismo.Size = new System.Drawing.Size(94, 17);
            this.chkElitismo.TabIndex = 14;
            this.chkElitismo.Text = "Utilizar elitismo";
            this.chkElitismo.UseVisualStyleBackColor = true;
            // 
            // frmTesteAG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 498);
            this.Controls.Add(this.chkElitismo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaximoGeracoes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPopulacao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFrase);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTempoTotalSegundo);
            this.Controls.Add(this.lblFim);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.listBox1);
            this.Name = "frmTesteAG";
            this.Text = "Formar frases (Algoritmo Genético)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblFim;
        private System.Windows.Forms.Label lblTempoTotalSegundo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.TextBox txtFrase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPopulacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaximoGeracoes;
        private System.Windows.Forms.CheckBox chkElitismo;


    }
}

