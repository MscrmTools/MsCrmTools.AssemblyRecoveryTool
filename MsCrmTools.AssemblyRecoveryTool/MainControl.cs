using Microsoft.Xrm.Sdk;
using MsCrmTools.AssemblyRecoveryTool.AppCode;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace MsCrmTools.AssemblyRecoveryTool
{
    public partial class MainControl : PluginControlBase, IGitHubPlugin, IHelpPlugin
    {
        private AssemblyManager manager;

        #region Constructor

        /// <summary>
        /// Initializes a new instance of class <see cref="MainControl"/>
        /// </summary>
        public MainControl()
        {
            InitializeComponent();

            // Execute code automatically when plugin is loaded
            Enter += MainControl_Enter;
        }

        /// <summary>
        /// Will initiate loading of assemblies from currently connected server if current connection was updated in main application
        /// </summary>
        /// <param name="sender">Instance of class <see cref="MainControl"/></param>
        /// <param name="e">Event arguments</param>
        private void MainControl_ConnectionUpdated(object sender, ConnectionUpdatedEventArgs e)
        {
            ExecuteMethod(RetrieveAssemblies);
        }

        /// <summary>
        /// Will initiate loading of assemblies from currently connected server
        /// </summary>
        /// <param name="sender">Instance of class <see cref="MainControl"/></param>
        /// <param name="e">Event aguments</param>
        private void MainControl_Enter(object sender, EventArgs e)
        {
            if (sender is MainControl control)
            {
                var plugin = control;
                // In case if connection updated on main application, update assemblies list inside the plugin
                plugin.ConnectionUpdated += MainControl_ConnectionUpdated;

                if (plugin.Service != null)
                {
                    // Execute assemblies retrieve only if Service object is set for correct sender.
                    // This will help plugin act predicatable when it was loaded in offline mode;
                    // Plugin will not insist on connecting to server. Will scinetly obey instead.
                    ExecuteMethod(RetrieveAssemblies);
                }
            }
        }

        #endregion Constructor

        #region Interfaces implementation

        public string RepositoryName => "MsCrmTools.AssemblyRecoveryTool";

        public string UserName => "MscrmTools";

        public string HelpUrl => "https://github.com/MscrmTools/MsCrmTools.AssemblyRecoveryTool/wiki";

        #endregion Interfaces implementation

        #region Events

        private void TsbCloseClick(object sender, EventArgs e)
        {
            CloseTool();
        }

        private void tsbExportToDisk_Click(object sender, EventArgs e)
        {
            if (listView_Assemblies.CheckedItems.Count == 0)
            {
                MessageBox.Show(this, @"Please select at least one assembly in the list!", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var fbDialog = new FolderBrowserDialog
            {
                Description = @"Select a location to recover the assemblies",
                ShowNewFolderButton = true
            };

            if (fbDialog.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(fbDialog.SelectedPath))
                {
                    foreach (ListViewItem item in listView_Assemblies.CheckedItems)
                    {
                        var assembly = (Entity)item.Tag;

                        var filename = $"{item.Text}_{assembly.GetAttributeValue<string>("version")}.dll";
                        filename = Path.Combine(fbDialog.SelectedPath, filename);

                        byte[] buffer = manager.RetrieveAssembly(assembly.Id);

                        using (var writer = new BinaryWriter(File.Open(filename, FileMode.Create)))
                        {
                            writer.Write(buffer);
                        }
                    }

                    MessageBox.Show(this, @"Assemblies recovered!", @"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void tsbLoadAssemblies_Click(object sender, EventArgs e)
        {
            ExecuteMethod(RetrieveAssemblies);
        }

        #endregion Events

        #region Methods

        public void RetrieveAssemblies()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Loading assemblies...",
                Work = (bw, e) =>
                {
                    manager = new AssemblyManager(Service);
                    e.Result = manager.RetrieveAssemblies();
                },
                PostWorkCallBack = e =>
                {
                    listView_Assemblies.Items.Clear();

                    var list = (List<Entity>)e.Result;

                    foreach (Entity pAssembly in list)
                    {
                        var item = new ListViewItem(pAssembly.GetAttributeValue<string>("name"));
                        item.SubItems.Add(pAssembly.GetAttributeValue<string>("version"));
                        item.SubItems.Add(pAssembly.GetAttributeValue<string>("publickeytoken"));
                        item.Tag = pAssembly;

                        listView_Assemblies.Items.Add(item);
                    }
                }
            });
        }

        #endregion Methods
    }
}