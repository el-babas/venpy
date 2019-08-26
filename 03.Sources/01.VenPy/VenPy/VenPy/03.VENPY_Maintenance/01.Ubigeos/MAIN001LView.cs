using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using VenPy.Controls;
using VenPy.Connection;
using VenPy.Entities;
using VenPy.Class;

namespace VenPy.Main
{
    public partial class MAIN001LView : UserControl, IMAIN001LView
    {
        #region [ PROPERTIES ]

        public TabPage TabPageControl { get; set; }
        public MAIN001PView Presenter { get; set; }
        public BindingSource BSItems { get; set; }

        #endregion

        #region [ FORM ]

        public MAIN001LView(TabPage p_tabPageControl)
        {
            TabPageControl = p_tabPageControl;
            InitializeComponent();
            BSItems = new BindingSource();
            btnClose.Click += new EventHandler(BtnClose_Click);
            btnSearch.Click += new EventHandler(BtnSearch_Click);
            btnExport.Click += new EventHandler(BtnExport_Click);
            tsmAdd.Click += new EventHandler(CmsContextMenu_Click);
            tsmEdit.Click += new EventHandler(CmsContextMenu_Click);
            tsmRemove.Click += new EventHandler(CmsContextMenu_Click);
            txtUBIG_Description.KeyUp += new KeyEventHandler(TxtUBIG_Description_KeyUp);
            tvwItems.AfterSelect += new TreeViewEventHandler(this.TvwItems_AfterSelect);
            cmsContextMenu.Opening += new CancelEventHandler(this.CmsContextMenu_Opening);
        }
        public void LViewLoad()
        {
            try
            {
                CleanControls();
                Search();
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error cargando la vista.", ex); }
        }

        #endregion

        #region [ METHODS }

        private void CleanControls()
        {
            try
            {
                txtUBIG_Description.Text = string.Empty;
                tvwItems.Nodes.Clear();
                tvwItems.ImageList = ltsImages;
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error limpiando los controles.", ex); }
        }
        public void Search()
        {
            try
            {
                Presenter.Search();
                if (Presenter.Items != null && Presenter.Items.Count > 0)
                {
                    LoadTreeView();
                }
                else
                { Messages.ShowInformationMessage(Presenter.Title, "No se encontraron resultados."); }

            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al buscar.", ex); }
        }
        private void SearchByDescription()
        {
            try
            {
                TreeNode[] tNodes;
                if (Presenter.SearchByDescription(txtUBIG_Description.Text))
                {
                    TreeNode treenoded = new TreeNode();
                    tNodes = tvwItems.Nodes.Find(Presenter.ItemTreeView.UBIG_Code, true);
                    if (tNodes.Length > 0)
                    {
                        tvwItems.SelectedNode = tNodes[0];
                        tvwItems.SelectedNode.Expand();
                        tvwItems.Select();
                    }
                }
                else
                { Messages.ShowInformationMessage(Presenter.Title, "No se encotro el Item con la descripcion"); }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al buscar por descripcion.", ex); }
        }
        private void LoadTreeView()
        {
            try
            {
                tvwItems.Visible = false;
                tvwItems.Nodes.Clear();
                TreeNode l_tNode;

                Presenter.GetListUbigeos(Presenter.ItemHierarchical.UBIG_Code);

                foreach (var item in Presenter.ItemHierarchical.UBIG_Offspring)
                {
                    l_tNode = new TreeNode();
                    l_tNode.Tag = item;
                    l_tNode.Text = item.UBIG_Code.Trim().ToString() + " - " + item.UBIG_Description;
                    l_tNode.Name = item.UBIG_Code.ToString();
                    l_tNode.Expand();
                    tvwItems.Nodes.Add(l_tNode);
                    Presenter.GetListUbigeos(item.UBIG_Code);
                    BuildTreeView(Presenter.ItemsHierarchical, l_tNode);
                }
                tvwItems.Nodes[0].Expand();
                tvwItems.Visible = true;
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al cargar el arbol.", ex); }
        }
        private void BuildTreeView(ObservableCollection<VENPY_Ubigeos> p_Enumerable, TreeNode p_TreeNode)
        {
            try
            {
                foreach (VENPY_Ubigeos item in p_Enumerable)
                {
                    TreeNode l_treenode = new TreeNode();
                    l_treenode.Tag = item;
                    l_treenode.Text = item.UBIG_Code.Trim().ToString() + " - " + item.UBIG_Description;
                    l_treenode.Name = item.UBIG_Code.ToString();
                    l_treenode.Expand();
                    p_TreeNode.Nodes.Add(l_treenode);
                    tvwItems.Update();
                    Presenter.GetListUbigeos(((VENPY_Ubigeos)l_treenode.Tag).UBIG_Code);
                    BuildTreeView(Presenter.ItemsHierarchical, l_treenode);
                }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ha ocurrido un error al construir el arbol.", ex); }
        }

        #endregion

        #region [ EVENTS ]

        public event CloseFormEventArgs.CloseFormEventHandler CloseForm;
        private void BtnClose_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                CloseForm?.Invoke(null, new CloseFormEventArgs(TabPageControl, Presenter.NameForm));
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                SearchByDescription();
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ocurrio un error al ejecutar la busqueda.", ex); }
        }
        private void BtnExport_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Presenter.Export();
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ocurrio un error al exportar.", ex); }
        }
        private void CmsContextMenu_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripMenuItem l_boton = new ToolStripMenuItem();
                l_boton = (ToolStripMenuItem)sender;
                switch (l_boton.Name.ToString())
                {
                    case "tsmAdd":
                        Presenter.Action("A");
                        break;
                    case "tsmEdit":
                        Presenter.Action("E");
                        break;
                    case "tsmRemove":
                        Presenter.Action("R");
                        break;
                }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ocurrio un error al ejecutar una accion.", ex); }
        }
        private void TxtUBIG_Description_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                { SearchByDescription(); }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ocurrio un error al ejecutar la busqueda.", ex); }
        }
        private void TvwItems_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (tvwItems.SelectedNode != null)
                {
                    Presenter.ItemTreeView = (VENPY_Ubigeos)tvwItems.SelectedNode.Tag;
                }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ocurrio un error al seleccionar un Item.", ex); }
        }
        private void CmsContextMenu_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                TreeNode node = new TreeNode();
                node = tvwItems.SelectedNode;
                if (node != null)
                {
                    if (Presenter.ItemTreeView.UBIG_ParentCode == null)
                    {
                        cmsContextMenu.Items[0].Enabled = true;
                        cmsContextMenu.Items[1].Enabled = false;
                        cmsContextMenu.Items[2].Enabled = false;
                    }
                    else
                    {
                        cmsContextMenu.Items[0].Enabled = true;
                        cmsContextMenu.Items[1].Enabled = true;
                        cmsContextMenu.Items[2].Enabled = true;
                    }
                }
                else
                { e.Cancel = true; }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Presenter.Title, "Ocurrio un error al mostrar el menú.", ex); }
        }

        #endregion

    }
}
