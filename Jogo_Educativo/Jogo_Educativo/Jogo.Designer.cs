namespace Jogo_Educativo
{
    partial class Jogo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jogo));
            this.cbJogador = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbDificil = new System.Windows.Forms.RadioButton();
            this.rbFacil = new System.Windows.Forms.RadioButton();
            this.btnIniciarJogo = new System.Windows.Forms.Button();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.lblExplicacao = new System.Windows.Forms.Label();
            this.btnEnviarResposta = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbImagens = new System.Windows.Forms.PictureBox();
            this.lbltime = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagens)).BeginInit();
            this.SuspendLayout();
            // 
            // cbJogador
            // 
            this.cbJogador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJogador.FormattingEnabled = true;
            this.cbJogador.Location = new System.Drawing.Point(70, 40);
            this.cbJogador.Name = "cbJogador";
            this.cbJogador.Size = new System.Drawing.Size(159, 24);
            this.cbJogador.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Jogador";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbJogador);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 85);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jogador";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbDificil);
            this.groupBox2.Controls.Add(this.rbFacil);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(286, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 85);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nível de Dificuldade";
            // 
            // rbDificil
            // 
            this.rbDificil.AutoSize = true;
            this.rbDificil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDificil.Location = new System.Drawing.Point(20, 52);
            this.rbDificil.Name = "rbDificil";
            this.rbDificil.Size = new System.Drawing.Size(60, 20);
            this.rbDificil.TabIndex = 1;
            this.rbDificil.Text = "Difícil";
            this.rbDificil.UseVisualStyleBackColor = true;
            // 
            // rbFacil
            // 
            this.rbFacil.AutoSize = true;
            this.rbFacil.Checked = true;
            this.rbFacil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFacil.Location = new System.Drawing.Point(20, 25);
            this.rbFacil.Name = "rbFacil";
            this.rbFacil.Size = new System.Drawing.Size(57, 20);
            this.rbFacil.TabIndex = 0;
            this.rbFacil.TabStop = true;
            this.rbFacil.Text = "Fácil";
            this.rbFacil.UseVisualStyleBackColor = true;
            // 
            // btnIniciarJogo
            // 
            this.btnIniciarJogo.Location = new System.Drawing.Point(578, 43);
            this.btnIniciarJogo.Name = "btnIniciarJogo";
            this.btnIniciarJogo.Size = new System.Drawing.Size(138, 28);
            this.btnIniciarJogo.TabIndex = 6;
            this.btnIniciarJogo.Text = "Iniciar o Jogo";
            this.btnIniciarJogo.UseVisualStyleBackColor = true;
            this.btnIniciarJogo.Click += new System.EventHandler(this.btnIniciarJogo_Click);
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Checked = true;
            this.rb1.Location = new System.Drawing.Point(21, 275);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(103, 20);
            this.rb1.TabIndex = 8;
            this.rb1.TabStop = true;
            this.rb1.Text = "radioButton3";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(21, 412);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(103, 20);
            this.rb4.TabIndex = 9;
            this.rb4.Text = "radioButton4";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(21, 367);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(103, 20);
            this.rb3.TabIndex = 10;
            this.rb3.Text = "radioButton5";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(21, 319);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(103, 20);
            this.rb2.TabIndex = 11;
            this.rb2.Text = "radioButton6";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // lblExplicacao
            // 
            this.lblExplicacao.AutoSize = true;
            this.lblExplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplicacao.Location = new System.Drawing.Point(12, 244);
            this.lblExplicacao.Name = "lblExplicacao";
            this.lblExplicacao.Size = new System.Drawing.Size(272, 16);
            this.lblExplicacao.TabIndex = 3;
            this.lblExplicacao.Text = "Marque a alternativa correta da conta acima:";
            // 
            // btnEnviarResposta
            // 
            this.btnEnviarResposta.Location = new System.Drawing.Point(12, 448);
            this.btnEnviarResposta.Name = "btnEnviarResposta";
            this.btnEnviarResposta.Size = new System.Drawing.Size(138, 31);
            this.btnEnviarResposta.TabIndex = 12;
            this.btnEnviarResposta.Text = "Enviar resposta";
            this.btnEnviarResposta.UseVisualStyleBackColor = true;
            this.btnEnviarResposta.Click += new System.EventHandler(this.btnEnviarResposta_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbImagens
            // 
            this.pbImagens.Image = global::Jogo_Educativo.Properties.Resources.Imagem_10;
            this.pbImagens.Location = new System.Drawing.Point(12, 103);
            this.pbImagens.Name = "pbImagens";
            this.pbImagens.Size = new System.Drawing.Size(459, 130);
            this.pbImagens.TabIndex = 13;
            this.pbImagens.TabStop = false;
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.Location = new System.Drawing.Point(317, 367);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(73, 20);
            this.lbltime.TabIndex = 14;
            this.lbltime.Text = "00:00:00";
            // 
            // Jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(746, 501);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.pbImagens);
            this.Controls.Add(this.btnEnviarResposta);
            this.Controls.Add(this.lblExplicacao);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb3);
            this.Controls.Add(this.rb4);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.btnIniciarJogo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "Jogo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo";
            this.Load += new System.EventHandler(this.Jogo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbJogador;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbDificil;
        private System.Windows.Forms.RadioButton rbFacil;
        private System.Windows.Forms.Button btnIniciarJogo;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.Label lblExplicacao;
        private System.Windows.Forms.Button btnEnviarResposta;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbImagens;
        private System.Windows.Forms.Label lbltime;
    }
}