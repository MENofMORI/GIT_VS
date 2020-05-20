namespace WindowsFormsApp1
{
    partial class FormMain
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.daneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńDaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyszukajDaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.zablokujPanelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.odblokujPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nazwa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sztuki = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(57, 17);
            this.toolStripStatusLabel.Text = "Brak akcji";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.daneToolStripMenuItem,
            this.usuńDaneToolStripMenuItem,
            this.wyszukajDaneToolStripMenuItem,
            this.ustawieniaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // daneToolStripMenuItem
            // 
            this.daneToolStripMenuItem.Name = "daneToolStripMenuItem";
            this.daneToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.daneToolStripMenuItem.Text = "Pobierz dane";
            this.daneToolStripMenuItem.Click += new System.EventHandler(this.daneToolStripMenuItem_Click);
            this.daneToolStripMenuItem.MouseEnter += new System.EventHandler(this.daneToolStripMenuItem_MouseEnter);
            this.daneToolStripMenuItem.MouseLeave += new System.EventHandler(this.daneToolStripMenuItem_MouseLeave);
            // 
            // usuńDaneToolStripMenuItem
            // 
            this.usuńDaneToolStripMenuItem.Name = "usuńDaneToolStripMenuItem";
            this.usuńDaneToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.usuńDaneToolStripMenuItem.Text = "Usuń dane";
            this.usuńDaneToolStripMenuItem.Click += new System.EventHandler(this.usuńDaneToolStripMenuItem_Click);
            this.usuńDaneToolStripMenuItem.MouseEnter += new System.EventHandler(this.usunDaneToolStripMenuItem_MouseEnter);
            this.usuńDaneToolStripMenuItem.MouseLeave += new System.EventHandler(this.usunDaneToolStripMenuItem_MouseLeave);
            // 
            // wyszukajDaneToolStripMenuItem
            // 
            this.wyszukajDaneToolStripMenuItem.Name = "wyszukajDaneToolStripMenuItem";
            this.wyszukajDaneToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.wyszukajDaneToolStripMenuItem.Text = "Wyszukaj dane";
            this.wyszukajDaneToolStripMenuItem.Click += new System.EventHandler(this.wyszukajDaneToolStripMenuItem_Click);
            this.wyszukajDaneToolStripMenuItem.MouseEnter += new System.EventHandler(this.wyszukajDaneToolStripMenuItem_MouseEnter);
            this.wyszukajDaneToolStripMenuItem.MouseLeave += new System.EventHandler(this.wyszukajDaneToolStripMenuItem_MouseLeave);
            // 
            // ustawieniaToolStripMenuItem
            // 
            this.ustawieniaToolStripMenuItem.Name = "ustawieniaToolStripMenuItem";
            this.ustawieniaToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.ustawieniaToolStripMenuItem.Text = "Ustawienia";
            this.ustawieniaToolStripMenuItem.Click += new System.EventHandler(this.ustawieniaToolStripMenuItem_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zablokujPanelToolStripMenuItem1,
            this.odblokujPanelToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip4";
            this.contextMenuStrip.Size = new System.Drawing.Size(156, 48);
            // 
            // zablokujPanelToolStripMenuItem1
            // 
            this.zablokujPanelToolStripMenuItem1.Name = "zablokujPanelToolStripMenuItem1";
            this.zablokujPanelToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.zablokujPanelToolStripMenuItem1.Text = "Zablokuj Panel";
            this.zablokujPanelToolStripMenuItem1.Click += new System.EventHandler(this.zablokujPanelToolStripMenuItem1_Click);
            // 
            // odblokujPanelToolStripMenuItem
            // 
            this.odblokujPanelToolStripMenuItem.Name = "odblokujPanelToolStripMenuItem";
            this.odblokujPanelToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.odblokujPanelToolStripMenuItem.Text = "Odblokuj Panel";
            this.odblokujPanelToolStripMenuItem.Click += new System.EventHandler(this.odblokujPanelToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Nazwa,
            this.Cena,
            this.Sztuki,
            this.Kategoria});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 24);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(800, 404);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.DisplayIndex = 4;
            this.Id.Width = 50;
            // 
            // Nazwa
            // 
            this.Nazwa.DisplayIndex = 0;
            this.Nazwa.Width = 300;
            // 
            // Cena
            // 
            this.Cena.DisplayIndex = 1;
            this.Cena.Width = 100;
            // 
            // Sztuki
            // 
            this.Sztuki.DisplayIndex = 2;
            this.Sztuki.Width = 50;
            // 
            // Kategoria
            // 
            this.Kategoria.DisplayIndex = 3;
            this.Kategoria.Width = 100;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem daneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńDaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem zablokujPanelToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem odblokujPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyszukajDaneToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Nazwa;
        private System.Windows.Forms.ColumnHeader Cena;
        private System.Windows.Forms.ColumnHeader Sztuki;
        private System.Windows.Forms.ColumnHeader Kategoria;
        private System.Windows.Forms.ColumnHeader Id;
    }
}