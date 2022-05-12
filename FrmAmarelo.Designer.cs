namespace Exemenu
{
    partial class FrmAmarelo
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
            this.mns_ama = new System.Windows.Forms.MenuStrip();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_azul = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_ama = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_verme = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mns_ama.SuspendLayout();
            this.SuspendLayout();
            // 
            // mns_ama
            // 
            this.mns_ama.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirToolStripMenuItem});
            this.mns_ama.Location = new System.Drawing.Point(0, 0);
            this.mns_ama.Name = "mns_ama";
            this.mns_ama.Size = new System.Drawing.Size(800, 24);
            this.mns_ama.TabIndex = 1;
            this.mns_ama.Text = "menuStrip2";
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmAmarelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mns_ama);
            this.Name = "FrmAmarelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amarelo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mns_ama.ResumeLayout(false);
            this.mns_ama.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mns_ama;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_azul;
        private System.Windows.Forms.ToolStripMenuItem tsmi_ama;
        private System.Windows.Forms.ToolStripMenuItem tsmi_verme;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}