namespace Jogo_Educativo
{
    partial class Pontuacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pontuacao));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridPontuacao = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPontuacao)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.cbFiltro);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(615, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cbFiltro
            // 
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Location = new System.Drawing.Point(63, 15);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(124, 24);
            this.cbFiltro.TabIndex = 1;
            this.cbFiltro.SelectedValueChanged += new System.EventHandler(this.cbFiltro_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filtrar:";
            // 
            // gridPontuacao
            // 
            this.gridPontuacao.AllowUserToAddRows = false;
            this.gridPontuacao.AllowUserToDeleteRows = false;
            this.gridPontuacao.BackgroundColor = System.Drawing.Color.White;
            this.gridPontuacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPontuacao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridPontuacao.Location = new System.Drawing.Point(0, 54);
            this.gridPontuacao.Name = "gridPontuacao";
            this.gridPontuacao.ReadOnly = true;
            this.gridPontuacao.RowHeadersWidth = 51;
            this.gridPontuacao.RowTemplate.Height = 24;
            this.gridPontuacao.Size = new System.Drawing.Size(615, 256);
            this.gridPontuacao.TabIndex = 1;
            this.gridPontuacao.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridPontuacao_CellFormatting);
            // 
            // Pontuacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(615, 310);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridPontuacao);
            this.DoubleBuffered = true;
            this.Name = "Pontuacao";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pontuação";
            this.Load += new System.EventHandler(this.Pontuacao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPontuacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridPontuacao;
    }
}