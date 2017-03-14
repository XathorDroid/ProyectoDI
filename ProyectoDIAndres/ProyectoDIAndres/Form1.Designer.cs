namespace ProyectoDIAndres
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miNew = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.miList = new System.Windows.Forms.ToolStripMenuItem();
            this.miIconList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herlpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnNew = new System.Windows.Forms.ToolStripButton();
            this.tsBtnDelAll = new System.Windows.Forms.ToolStripButton();
            this.tsBtnDel = new System.Windows.Forms.ToolStripButton();
            this.tsBtnUndo = new System.Windows.Forms.ToolStripButton();
            this.tsBtnRedo = new System.Windows.Forms.ToolStripButton();
            this.panelFondo = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.herlpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(708, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNew});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // miNew
            // 
            this.miNew.Name = "miNew";
            this.miNew.Size = new System.Drawing.Size(98, 22);
            this.miNew.Text = "&New";
            this.miNew.Click += new System.EventHandler(this.miNew_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miIcon,
            this.miList,
            this.miIconList});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // miIcon
            // 
            this.miIcon.Name = "miIcon";
            this.miIcon.Size = new System.Drawing.Size(123, 22);
            this.miIcon.Text = "Icons";
            // 
            // miList
            // 
            this.miList.Name = "miList";
            this.miList.Size = new System.Drawing.Size(123, 22);
            this.miList.Text = "List";
            // 
            // miIconList
            // 
            this.miIconList.Name = "miIconList";
            this.miIconList.Size = new System.Drawing.Size(123, 22);
            this.miIconList.Text = "Icons List";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.helpToolStripMenuItem.Text = "Window";
            // 
            // herlpToolStripMenuItem
            // 
            this.herlpToolStripMenuItem.Name = "herlpToolStripMenuItem";
            this.herlpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.herlpToolStripMenuItem.Text = "Help";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnNew,
            this.tsBtnDelAll,
            this.tsBtnDel,
            this.toolStripSeparator1,
            this.tsBtnUndo,
            this.tsBtnRedo,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(708, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnNew
            // 
            this.tsBtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnNew.Image = global::ProyectoDIAndres.Properties.Resources.plus_box_1_;
            this.tsBtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnNew.Name = "tsBtnNew";
            this.tsBtnNew.Size = new System.Drawing.Size(23, 22);
            this.tsBtnNew.Text = "toolStripButton1";
            this.tsBtnNew.Click += new System.EventHandler(this.tsBtnNew_Click);
            // 
            // tsBtnDelAll
            // 
            this.tsBtnDelAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnDelAll.Image = global::ProyectoDIAndres.Properties.Resources.delete_sweep;
            this.tsBtnDelAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnDelAll.Name = "tsBtnDelAll";
            this.tsBtnDelAll.Size = new System.Drawing.Size(23, 22);
            this.tsBtnDelAll.Text = "toolStripButton1";
            // 
            // tsBtnDel
            // 
            this.tsBtnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnDel.Image = global::ProyectoDIAndres.Properties.Resources.delete;
            this.tsBtnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnDel.Name = "tsBtnDel";
            this.tsBtnDel.Size = new System.Drawing.Size(23, 22);
            this.tsBtnDel.Text = "toolStripButton1";
            // 
            // tsBtnUndo
            // 
            this.tsBtnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnUndo.Image = global::ProyectoDIAndres.Properties.Resources.undo_variant;
            this.tsBtnUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnUndo.Name = "tsBtnUndo";
            this.tsBtnUndo.Size = new System.Drawing.Size(23, 22);
            this.tsBtnUndo.Text = "toolStripButton2";
            // 
            // tsBtnRedo
            // 
            this.tsBtnRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnRedo.Image = global::ProyectoDIAndres.Properties.Resources.redo_variant;
            this.tsBtnRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnRedo.Name = "tsBtnRedo";
            this.tsBtnRedo.Size = new System.Drawing.Size(23, 22);
            this.tsBtnRedo.Text = "toolStripButton3";
            // 
            // panelFondo
            // 
            this.panelFondo.ColumnCount = 4;
            this.panelFondo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.panelFondo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.panelFondo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.panelFondo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.panelFondo.Location = new System.Drawing.Point(0, 49);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.RowCount = 2;
            this.panelFondo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 218F));
            this.panelFondo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 218F));
            this.panelFondo.Size = new System.Drawing.Size(708, 436);
            this.panelFondo.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 485);
            this.Controls.Add(this.panelFondo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(724, 524);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herlpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnNew;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem miIcon;
        private System.Windows.Forms.ToolStripMenuItem miList;
        private System.Windows.Forms.ToolStripMenuItem miIconList;
        private System.Windows.Forms.ToolStripMenuItem miNew;
        private System.Windows.Forms.ToolStripButton tsBtnDelAll;
        private System.Windows.Forms.ToolStripButton tsBtnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnUndo;
        private System.Windows.Forms.ToolStripButton tsBtnRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.TableLayoutPanel panelFondo;
    }
}

