namespace EjemploWindowsForms
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contenedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delegadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interésCompuestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contenedoresToolStripMenuItem,
            this.delegadosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contenedoresToolStripMenuItem
            // 
            this.contenedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabControlToolStripMenuItem});
            this.contenedoresToolStripMenuItem.Name = "contenedoresToolStripMenuItem";
            this.contenedoresToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.contenedoresToolStripMenuItem.Text = "Contenedores";
            // 
            // tabControlToolStripMenuItem
            // 
            this.tabControlToolStripMenuItem.Name = "tabControlToolStripMenuItem";
            this.tabControlToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.tabControlToolStripMenuItem.Text = "TabControl";
            this.tabControlToolStripMenuItem.Click += new System.EventHandler(this.tabControlToolStripMenuItem_Click);
            // 
            // delegadosToolStripMenuItem
            // 
            this.delegadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.interésCompuestoToolStripMenuItem});
            this.delegadosToolStripMenuItem.Name = "delegadosToolStripMenuItem";
            this.delegadosToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.delegadosToolStripMenuItem.Text = "Delegados";
            // 
            // interésCompuestoToolStripMenuItem
            // 
            this.interésCompuestoToolStripMenuItem.Name = "interésCompuestoToolStripMenuItem";
            this.interésCompuestoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.interésCompuestoToolStripMenuItem.Text = "Interés compuesto";
            this.interésCompuestoToolStripMenuItem.Click += new System.EventHandler(this.interésCompuestoToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Uso de Formularios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem contenedoresToolStripMenuItem;
        private ToolStripMenuItem tabControlToolStripMenuItem;
        private ToolStripMenuItem delegadosToolStripMenuItem;
        private ToolStripMenuItem interésCompuestoToolStripMenuItem;
    }
}