namespace Exemenu
{
    partial class FrmAzul
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mns_azul = new System.Windows.Forms.MenuStrip();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_azul = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_ama = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_verme = new System.Windows.Forms.ToolStripMenuItem();
            this.mns_azul.SuspendLayout();
            this.SuspendLayout();
            // 
            // mns_azul
            // 
            this.mns_azul.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirToolStripMenuItem});
            this.mns_azul.Location = new System.Drawing.Point(0, 0);
            this.mns_azul.Name = "mns_azul";
            this.mns_azul.Size = new System.Drawing.Size(800, 24);
            this.mns_azul.TabIndex = 2;
            this.mns_azul.Text = "menuStrip2";
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_azul,
            this.tsmi_ama,
            this.tsmi_verme});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.exibirToolStripMenuItem.Text = "Exibir";
            // 
            // tsmi_azul
            // 
            this.tsmi_azul.Name = "tsmi_azul";
            this.tsmi_azul.Size = new System.Drawing.Size(180, 22);
            this.tsmi_azul.Text = "FrmAzul";
            this.tsmi_azul.Click += new System.EventHandler(this.tsmi_azul_Click);
            // 
            // tsmi_ama
            // 
            this.tsmi_ama.Name = "tsmi_ama";
            this.tsmi_ama.Size = new System.Drawing.Size(180, 22);
            this.tsmi_ama.Text = "FrmAmarelo";
            this.tsmi_ama.Click += new System.EventHandler(this.tsmi_ama_Click);
            // 
            // tsmi_verme
            // 
            this.tsmi_verme.Name = "tsmi_verme";
            this.tsmi_verme.Size = new System.Drawing.Size(180, 22);
            this.tsmi_verme.Text = "FrmVermelho";
            this.tsmi_verme.Click += new System.EventHandler(this.tsmi_verme_Click);
            // 
            // FrmAzul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mns_azul);
            this.Name = "FrmAzul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Azul";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mns_azul.ResumeLayout(false);
            this.mns_azul.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mns_azul;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_azul;
        private System.Windows.Forms.ToolStripMenuItem tsmi_ama;
        private System.Windows.Forms.ToolStripMenuItem tsmi_verme;
    }
}

