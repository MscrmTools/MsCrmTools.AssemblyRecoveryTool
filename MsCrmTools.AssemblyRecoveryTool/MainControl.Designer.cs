namespace MsCrmTools.AssemblyRecoveryTool
{
    partial class MainControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainControl));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbReloadAssemblies = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExportToDisk = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tslFilter = new System.Windows.Forms.ToolStripLabel();
            this.tstbFilter = new System.Windows.Forms.ToolStripTextBox();
            this.toolImageList = new System.Windows.Forms.ImageList(this.components);
            this.listView_Assemblies = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tsbClearFilter = new System.Windows.Forms.ToolStripButton();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.toolStripSeparator1,
            this.tsbReloadAssemblies,
            this.toolStripSeparator2,
            this.tsbExportToDisk,
            this.toolStripSeparator3,
            this.tslFilter,
            this.tstbFilter,
            this.tsbClearFilter});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.toolStripMenu.Size = new System.Drawing.Size(1822, 50);
            this.toolStripMenu.TabIndex = 2;
            this.toolStripMenu.Text = "tsMain";
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(46, 44);
            this.tsbClose.Text = "Close this tool";
            this.tsbClose.Click += new System.EventHandler(this.TsbCloseClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // tsbReloadAssemblies
            // 
            this.tsbReloadAssemblies.Image = ((System.Drawing.Image)(resources.GetObject("tsbReloadAssemblies.Image")));
            this.tsbReloadAssemblies.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReloadAssemblies.Name = "tsbReloadAssemblies";
            this.tsbReloadAssemblies.Size = new System.Drawing.Size(229, 44);
            this.tsbReloadAssemblies.Text = "Reload assemblies";
            this.tsbReloadAssemblies.Click += new System.EventHandler(this.tsbLoadAssemblies_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 50);
            // 
            // tsbExportToDisk
            // 
            this.tsbExportToDisk.Image = ((System.Drawing.Image)(resources.GetObject("tsbExportToDisk.Image")));
            this.tsbExportToDisk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExportToDisk.Name = "tsbExportToDisk";
            this.tsbExportToDisk.Size = new System.Drawing.Size(180, 44);
            this.tsbExportToDisk.Text = "Export to disk";
            this.tsbExportToDisk.Click += new System.EventHandler(this.tsbExportToDisk_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 50);
            // 
            // tslFilter
            // 
            this.tslFilter.Name = "tslFilter";
            this.tslFilter.Size = new System.Drawing.Size(68, 44);
            this.tslFilter.Text = "Filter";
            // 
            // tstbFilter
            // 
            this.tstbFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstbFilter.Name = "tstbFilter";
            this.tstbFilter.Size = new System.Drawing.Size(300, 50);
            this.tstbFilter.ToolTipText = "Filter by name";
            this.tstbFilter.TextChanged += new System.EventHandler(this.tstbFilter_TextChanged);
            // 
            // toolImageList
            // 
            this.toolImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("toolImageList.ImageStream")));
            this.toolImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.toolImageList.Images.SetKeyName(0, "nologo.png");
            // 
            // listView_Assemblies
            // 
            this.listView_Assemblies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Assemblies.CheckBoxes = true;
            this.listView_Assemblies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_Assemblies.FullRowSelect = true;
            this.listView_Assemblies.GridLines = true;
            this.listView_Assemblies.HideSelection = false;
            this.listView_Assemblies.Location = new System.Drawing.Point(6, 54);
            this.listView_Assemblies.Margin = new System.Windows.Forms.Padding(6);
            this.listView_Assemblies.Name = "listView_Assemblies";
            this.listView_Assemblies.Size = new System.Drawing.Size(1806, 1091);
            this.listView_Assemblies.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView_Assemblies.TabIndex = 13;
            this.listView_Assemblies.UseCompatibleStateImageBehavior = false;
            this.listView_Assemblies.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "AssemblyName";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Version";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Public Key Token";
            this.columnHeader3.Width = 200;
            // 
            // tsbClearFilter
            // 
            this.tsbClearFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbClearFilter.Image = global::MsCrmTools.AssemblyRecoveryTool.Properties.Resources.Clear_16;
            this.tsbClearFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClearFilter.Name = "tsbClearFilter";
            this.tsbClearFilter.Size = new System.Drawing.Size(46, 44);
            this.tsbClearFilter.Text = "Clear filter";
            this.tsbClearFilter.Click += new System.EventHandler(this.tsbClearFilter_Click);
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView_Assemblies);
            this.Controls.Add(this.toolStripMenu);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(1822, 1154);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ImageList toolImageList;
        private System.Windows.Forms.ListView listView_Assemblies;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbReloadAssemblies;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbExportToDisk;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel tslFilter;
        private System.Windows.Forms.ToolStripTextBox tstbFilter;
        private System.Windows.Forms.ToolStripButton tsbClearFilter;
    }
}
