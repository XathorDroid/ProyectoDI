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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miNew = new System.Windows.Forms.ToolStripMenuItem();
            this.miSave = new System.Windows.Forms.ToolStripMenuItem();
            this.miLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miView = new System.Windows.Forms.ToolStripMenuItem();
            this.miIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.miIconList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.miEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.miSpain = new System.Windows.Forms.ToolStripMenuItem();
            this.herlpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.miGitHub = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnSave = new System.Windows.Forms.ToolStripButton();
            this.tsBtnLoad = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnDelAll = new System.Windows.Forms.ToolStripButton();
            this.tsBtnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnUndo = new System.Windows.Forms.ToolStripButton();
            this.tsBtnRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnView = new System.Windows.Forms.ToolStripSplitButton();
            this.tsMiIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMiIconList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelFondo = new System.Windows.Forms.FlowLayoutPanel();
            this.msPanel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsNew = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsRemoveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.msControls = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.myTips = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.msPanel.SuspendLayout();
            this.msControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.miView,
            this.toolsToolStripMenuItem,
            this.miLanguage,
            this.herlpToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            this.myTips.SetToolTip(this.menuStrip1, resources.GetString("menuStrip1.ToolTip"));
            // 
            // fileToolStripMenuItem
            // 
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNew,
            this.miSave,
            this.miLoad,
            this.miExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            // 
            // miNew
            // 
            resources.ApplyResources(this.miNew, "miNew");
            this.miNew.Name = "miNew";
            this.miNew.Click += new System.EventHandler(this.miNew_Click);
            // 
            // miSave
            // 
            resources.ApplyResources(this.miSave, "miSave");
            this.miSave.Name = "miSave";
            // 
            // miLoad
            // 
            resources.ApplyResources(this.miLoad, "miLoad");
            this.miLoad.Name = "miLoad";
            // 
            // miExit
            // 
            resources.ApplyResources(this.miExit, "miExit");
            this.miExit.Name = "miExit";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // miView
            // 
            resources.ApplyResources(this.miView, "miView");
            this.miView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miIcon,
            this.miIconList});
            this.miView.Name = "miView";
            // 
            // miIcon
            // 
            resources.ApplyResources(this.miIcon, "miIcon");
            this.miIcon.Checked = true;
            this.miIcon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.miIcon.Name = "miIcon";
            this.miIcon.Click += new System.EventHandler(this.miIcon_Click);
            // 
            // miIconList
            // 
            resources.ApplyResources(this.miIconList, "miIconList");
            this.miIconList.Name = "miIconList";
            this.miIconList.Click += new System.EventHandler(this.miIconList_Click);
            // 
            // toolsToolStripMenuItem
            // 
            resources.ApplyResources(this.toolsToolStripMenuItem, "toolsToolStripMenuItem");
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            // 
            // miLanguage
            // 
            resources.ApplyResources(this.miLanguage, "miLanguage");
            this.miLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miEnglish,
            this.miSpain});
            this.miLanguage.Name = "miLanguage";
            // 
            // miEnglish
            // 
            resources.ApplyResources(this.miEnglish, "miEnglish");
            this.miEnglish.Name = "miEnglish";
            this.miEnglish.Click += new System.EventHandler(this.miEnglish_Click);
            // 
            // miSpain
            // 
            resources.ApplyResources(this.miSpain, "miSpain");
            this.miSpain.Name = "miSpain";
            this.miSpain.Click += new System.EventHandler(this.miSpain_Click);
            // 
            // herlpToolStripMenuItem
            // 
            resources.ApplyResources(this.herlpToolStripMenuItem, "herlpToolStripMenuItem");
            this.herlpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAbout,
            this.miGitHub});
            this.herlpToolStripMenuItem.Name = "herlpToolStripMenuItem";
            // 
            // miAbout
            // 
            resources.ApplyResources(this.miAbout, "miAbout");
            this.miAbout.Name = "miAbout";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // miGitHub
            // 
            resources.ApplyResources(this.miGitHub, "miGitHub");
            this.miGitHub.Name = "miGitHub";
            this.miGitHub.Click += new System.EventHandler(this.miGitHub_Click);
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnNew,
            this.toolStripSeparator3,
            this.tsBtnSave,
            this.tsBtnLoad,
            this.toolStripSeparator5,
            this.tsBtnDelAll,
            this.tsBtnDel,
            this.toolStripSeparator4,
            this.tsBtnEdit,
            this.toolStripSeparator1,
            this.tsBtnUndo,
            this.tsBtnRedo,
            this.toolStripSeparator2,
            this.tsBtnView,
            this.toolStripSeparator6});
            this.toolStrip1.Name = "toolStrip1";
            this.myTips.SetToolTip(this.toolStrip1, resources.GetString("toolStrip1.ToolTip"));
            // 
            // tsBtnNew
            // 
            resources.ApplyResources(this.tsBtnNew, "tsBtnNew");
            this.tsBtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnNew.Image = global::ProyectoDIAndres.Properties.Resources.plus_box_1_;
            this.tsBtnNew.Name = "tsBtnNew";
            this.tsBtnNew.Click += new System.EventHandler(this.miNew_Click);
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // tsBtnSave
            // 
            resources.ApplyResources(this.tsBtnSave, "tsBtnSave");
            this.tsBtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnSave.Image = global::ProyectoDIAndres.Properties.Resources.content_save;
            this.tsBtnSave.Name = "tsBtnSave";
            // 
            // tsBtnLoad
            // 
            resources.ApplyResources(this.tsBtnLoad, "tsBtnLoad");
            this.tsBtnLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnLoad.Image = global::ProyectoDIAndres.Properties.Resources.download;
            this.tsBtnLoad.Name = "tsBtnLoad";
            // 
            // toolStripSeparator5
            // 
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            // 
            // tsBtnDelAll
            // 
            resources.ApplyResources(this.tsBtnDelAll, "tsBtnDelAll");
            this.tsBtnDelAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnDelAll.Image = global::ProyectoDIAndres.Properties.Resources.delete_sweep;
            this.tsBtnDelAll.Name = "tsBtnDelAll";
            this.tsBtnDelAll.Click += new System.EventHandler(this.tsBtnDelAll_Click);
            // 
            // tsBtnDel
            // 
            resources.ApplyResources(this.tsBtnDel, "tsBtnDel");
            this.tsBtnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnDel.Image = global::ProyectoDIAndres.Properties.Resources.delete;
            this.tsBtnDel.Name = "tsBtnDel";
            this.tsBtnDel.Click += new System.EventHandler(this.cmsRemove_Click);
            // 
            // toolStripSeparator4
            // 
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            // 
            // tsBtnEdit
            // 
            resources.ApplyResources(this.tsBtnEdit, "tsBtnEdit");
            this.tsBtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnEdit.Image = global::ProyectoDIAndres.Properties.Resources.lead_pencil;
            this.tsBtnEdit.Name = "tsBtnEdit";
            this.tsBtnEdit.Click += new System.EventHandler(this.tsBtnEdit_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // tsBtnUndo
            // 
            resources.ApplyResources(this.tsBtnUndo, "tsBtnUndo");
            this.tsBtnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnUndo.Image = global::ProyectoDIAndres.Properties.Resources.undo_variant;
            this.tsBtnUndo.Name = "tsBtnUndo";
            // 
            // tsBtnRedo
            // 
            resources.ApplyResources(this.tsBtnRedo, "tsBtnRedo");
            this.tsBtnRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnRedo.Image = global::ProyectoDIAndres.Properties.Resources.redo_variant;
            this.tsBtnRedo.Name = "tsBtnRedo";
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // tsBtnView
            // 
            resources.ApplyResources(this.tsBtnView, "tsBtnView");
            this.tsBtnView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMiIcon,
            this.tsMiIconList});
            this.tsBtnView.Image = global::ProyectoDIAndres.Properties.Resources.view_list;
            this.tsBtnView.Name = "tsBtnView";
            // 
            // tsMiIcon
            // 
            resources.ApplyResources(this.tsMiIcon, "tsMiIcon");
            this.tsMiIcon.Checked = true;
            this.tsMiIcon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsMiIcon.Name = "tsMiIcon";
            this.tsMiIcon.Click += new System.EventHandler(this.miIcon_Click);
            // 
            // tsMiIconList
            // 
            resources.ApplyResources(this.tsMiIconList, "tsMiIconList");
            this.tsMiIconList.Name = "tsMiIconList";
            this.tsMiIconList.Click += new System.EventHandler(this.miIconList_Click);
            // 
            // toolStripSeparator6
            // 
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            // 
            // panelFondo
            // 
            resources.ApplyResources(this.panelFondo, "panelFondo");
            this.panelFondo.AllowDrop = true;
            this.panelFondo.ContextMenuStrip = this.msPanel;
            this.panelFondo.Name = "panelFondo";
            this.myTips.SetToolTip(this.panelFondo, resources.GetString("panelFondo.ToolTip"));
            this.panelFondo.Click += new System.EventHandler(this.panelFondo_Click);
            // 
            // msPanel
            // 
            resources.ApplyResources(this.msPanel, "msPanel");
            this.msPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsNew,
            this.cmsRemoveAll});
            this.msPanel.Name = "msPanel";
            this.myTips.SetToolTip(this.msPanel, resources.GetString("msPanel.ToolTip"));
            // 
            // cmsNew
            // 
            resources.ApplyResources(this.cmsNew, "cmsNew");
            this.cmsNew.Name = "cmsNew";
            this.cmsNew.Click += new System.EventHandler(this.miNew_Click);
            // 
            // cmsRemoveAll
            // 
            resources.ApplyResources(this.cmsRemoveAll, "cmsRemoveAll");
            this.cmsRemoveAll.Name = "cmsRemoveAll";
            this.cmsRemoveAll.Click += new System.EventHandler(this.tsBtnDelAll_Click);
            // 
            // msControls
            // 
            resources.ApplyResources(this.msControls, "msControls");
            this.msControls.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem1,
            this.cmsRemove});
            this.msControls.Name = "msControls";
            this.myTips.SetToolTip(this.msControls, resources.GetString("msControls.ToolTip"));
            // 
            // editToolStripMenuItem1
            // 
            resources.ApplyResources(this.editToolStripMenuItem1, "editToolStripMenuItem1");
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.tsBtnEdit_Click);
            // 
            // cmsRemove
            // 
            resources.ApplyResources(this.cmsRemove, "cmsRemove");
            this.cmsRemove.Name = "cmsRemove";
            this.cmsRemove.Click += new System.EventHandler(this.cmsRemove_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelFondo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.myTips.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.msPanel.ResumeLayout(false);
            this.msControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miView;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miLanguage;
        private System.Windows.Forms.ToolStripMenuItem herlpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnNew;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem miIcon;
        private System.Windows.Forms.ToolStripMenuItem miIconList;
        private System.Windows.Forms.ToolStripMenuItem miNew;
        private System.Windows.Forms.ToolStripButton tsBtnDelAll;
        private System.Windows.Forms.ToolStripButton tsBtnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnUndo;
        private System.Windows.Forms.ToolStripButton tsBtnRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSplitButton tsBtnView;
        private System.Windows.Forms.ToolStripMenuItem tsMiIcon;
        private System.Windows.Forms.ToolStripMenuItem tsMiIconList;
        public System.Windows.Forms.FlowLayoutPanel panelFondo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ContextMenuStrip msPanel;
        private System.Windows.Forms.ToolStripMenuItem cmsNew;
        private System.Windows.Forms.ToolStripMenuItem cmsRemoveAll;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cmsRemove;
        private System.Windows.Forms.ToolTip myTips;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        public System.Windows.Forms.ContextMenuStrip msControls;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsBtnEdit;
        private System.Windows.Forms.ToolStripMenuItem miSave;
        private System.Windows.Forms.ToolStripMenuItem miLoad;
        private System.Windows.Forms.ToolStripButton tsBtnSave;
        private System.Windows.Forms.ToolStripButton tsBtnLoad;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
        private System.Windows.Forms.ToolStripMenuItem miGitHub;
        private System.Windows.Forms.ToolStripMenuItem miEnglish;
        private System.Windows.Forms.ToolStripMenuItem miSpain;
    }
}

