using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using VenPy.Controls;
using VenPy.Connection;
using VenPy.Entities;
using VenPy.Class;
using System.Windows.Forms;
using System.Data;

namespace VenPy.Main
{
    public class MAIN001PView
    {
        #region [ VARIABLES ]

        private ObservableCollection<VENPY_Ubigeos> pv_items;
        private ObservableCollection<VENPY_Ubigeos> pv_itemshierarchical;
        private VENPY_Ubigeos pv_item;
        private VENPY_Ubigeos pv_itemhierarchical;
        private VENPY_Ubigeos pv_itemtreeview;

        #endregion

        #region [ PROPERTIES ]

        public String Title = "Ubigeos";
        public String NameForm = "MAIN001";
        public IMAIN001LView LView { get; set; }
        public IMAIN001MView MView { get; set; }
        public IBLVENPY_Ubigeos BL_VENPY_Ubigeos { get; set; }
        public IEnumerator<VENPY_Ubigeos> EnumeratorUbigeos { get; set; }
        public ObservableCollection<VENPY_Ubigeos> Items
        {
            get { return pv_items; }
            set { pv_items = value; }
        }
        public ObservableCollection<VENPY_Ubigeos> ItemsHierarchical
        {
            get { return pv_itemshierarchical; }
            set { pv_itemshierarchical = value; }
        }
        public VENPY_Ubigeos Item
        {
            get { return pv_item; }
            set { pv_item = value; }
        }
        public VENPY_Ubigeos ItemHierarchical
        {
            get { return pv_itemhierarchical; }
            set { pv_itemhierarchical = value; }
        }
        public VENPY_Ubigeos ItemTreeView
        {
            get { return pv_itemtreeview; }
            set { pv_itemtreeview = value; }
        }

        #endregion

        #region [ CONSTRUCTORS ]

        public MAIN001PView(IMAIN001LView p_lview, IMAIN001MView p_mview)
        {
            try
            {
                LView = p_lview;
                MView = p_mview;
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Title, "Ha ocurrido un error al inicializar el formulario.", ex); }
        }

        #endregion

        #region [ METHODS ]

        public void Load()
        {
            try
            {
                BL_VENPY_Ubigeos = new BLVENPY_Ubigeos();
                LView.LViewLoad();
                MView.MViewLoad();
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Title, "Ha ocurrido un error inicializando la vista.", ex); }
        }
        public void Search()
        {
            try
            {
                Items = new ObservableCollection<VENPY_Ubigeos>();
                ItemsHierarchical = new ObservableCollection<VENPY_Ubigeos>();
                Items = BL_VENPY_Ubigeos.BLUBIGS_All();
                if (Items != null && Items.Count > 0)
                {
                    ItemHierarchical = new VENPY_Ubigeos();
                    ItemHierarchical.UBIG_Code = null;

                    VENPY_Ubigeos l_head = new VENPY_Ubigeos();
                    l_head.UBIG_Code = "00";
                    l_head.UBIG_ParentCode = null;
                    l_head.UBIG_Description = "UBICACIONES";
                    foreach (var item in Items.Where(pr => pr.UBIG_ParentCode == null))
                    { item.UBIG_ParentCode = "00"; }
                    Items.Insert(0, l_head);
                    OrderHierarchically(ref pv_itemhierarchical);
                }
                else
                { Messages.ShowInformationMessage(Title, "No se encontraron resultados."); }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Title, "Ha ocurrido un error al buscar.", ex); }
        }
        public void Export()
        {
            try
            {
                if (Items != null && Items.Count > 0)
                {
                    List<String> l_subTitles = new List<String>();
                    l_subTitles.Add(String.Empty);
                    l_subTitles.Add(String.Format("EMPRESA : {0}", SessionVariables.BusinessName));
                    l_subTitles.Add(String.Format("USUARIO : {0}", SessionVariables.UserFullName));
                    l_subTitles.Add(String.Format("FECHA Y HORA : {0}", DateTime.Now.ToString("dd/MM/yyyy HH:mm")));
                    l_subTitles.Add(String.Empty);

                    List<ExportColumns> l_ExportColumns = new List<ExportColumns>();
                    l_ExportColumns.Add(new ExportColumns() {ColumnName = "UBIG_Code", ColumnCaption = "Código", DataType = typeof(string) });
                    l_ExportColumns.Add(new ExportColumns() {ColumnName = "UBIG_ParentCode", ColumnCaption = "Código Padre", DataType = typeof(string) });
                    l_ExportColumns.Add(new ExportColumns() {ColumnName = "UBIG_SunatCode", ColumnCaption = "Código Sunat", DataType = typeof(string) });
                    l_ExportColumns.Add(new ExportColumns() {ColumnName = "UBIG_InternationalCode", ColumnCaption = "Código Internacional", DataType = typeof(string) });
                    l_ExportColumns.Add(new ExportColumns() {ColumnName = "UBIG_Description", ColumnCaption = "Descripciòn", DataType = typeof(string) });
                    l_ExportColumns.Add(new ExportColumns() {ColumnName = "UBIG_Observations", ColumnCaption = "Observaciones", DataType = typeof(string) });

                    VENPY_PersonalConfiguration l_PersonalConfiguration = new VENPY_PersonalConfiguration();
                    l_PersonalConfiguration = TemporaryFiles.DeserializePersonalConfiguration().Where(filter => filter.BUSI_Code == SessionVariables.BusinessCode && filter.USER_Code == SessionVariables.UserCode && filter.PCON_Key == StaticLists.PCON_Export).FirstOrDefault();
                    if (l_PersonalConfiguration == null || l_PersonalConfiguration.PCON_Value.Equals("0"))
                    {
                        l_PersonalConfiguration = TemporaryFiles.DeserializePersonalConfiguration().Where(filter => filter.BUSI_Code == SessionVariables.BusinessCode && filter.USER_Code == SessionVariables.UserCode && filter.PCON_Key == StaticLists.PCON_MaxRows).FirstOrDefault();
                        Int32 l_maxrows = l_PersonalConfiguration == null ? 0 : Convert.ToInt32(l_PersonalConfiguration.PCON_Value);
                        if (l_maxrows >= Items.Count)
                        { ExportTextFile.ExportToTextFile(Title, Items.ToDataTable(), l_subTitles, l_ExportColumns); }
                        else
                        { Messages.ShowWarningMessage(Title, string.Format("No puede exportar un archivo .txt porque la cantidad de items es mayor a {0} ,revise su configuracion personal", l_maxrows)); }
                    }
                    else
                    { ExportExcel.ExportToExcel(Title, Items.ToDataTable(), l_subTitles, l_ExportColumns); }
                }
                else
                {
                    Messages.ShowInformationMessage(Title, "No existen Registros para Exportar.");
                }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Title, "Ocurrio un error al exportar.", ex); }
        }
        public bool SearchByDescription(String p_UBIG_Description)
        {
            try
            {
                var l_item = pv_items.Where(pr => pr.UBIG_Description.StartsWith(p_UBIG_Description.ToUpper())).FirstOrDefault();
                if (l_item != null)
                {
                    ItemTreeView = l_item;
                    return true;
                }
                else
                {
                    ItemTreeView = null;
                    return false;
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
        public void OrderHierarchically(ref VENPY_Ubigeos p_ItemHierarchical)
        {
            try
            {
                string l_codigo = p_ItemHierarchical.UBIG_Code;
                p_ItemHierarchical.UBIG_Offspring = new ObservableCollection<VENPY_Ubigeos>(pv_items.Where(p => p.UBIG_ParentCode == l_codigo));
                if (p_ItemHierarchical.UBIG_Offspring.Count > 0)
                {
                    for (int i = 0; i < p_ItemHierarchical.UBIG_Offspring.Count; i++)
                    {
                        VENPY_Ubigeos l_subItem = p_ItemHierarchical.UBIG_Offspring[i];
                        l_subItem.UBIG_Code = p_ItemHierarchical.UBIG_Offspring[i].UBIG_Code;
                        l_subItem.AUDI_CreationUser = SessionVariables.UserName;
                        l_subItem.AUDI_ModificationUser = SessionVariables.UserName;
                        OrderHierarchically(ref l_subItem);
                    }
                }
                ItemsHierarchical.Add(p_ItemHierarchical);
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Title, "Ha ocurrido un error al ordernar jerarquicamente.", ex); }
        }
        public void GetListUbigeos(String p_UBIG_Code)
        {
            try
            {
                VerifyMatchingProcessEnumerator(p_UBIG_Code);
                ItemsHierarchical = EnumeratorUbigeos.Current.UBIG_Offspring;
            }
            catch (Exception ex)
            { throw ex; }
        }
        public void VerifyMatchingProcessEnumerator(String p_UBIG_Code)
        {
            try
            {
                var l_matches = FindMatches(p_UBIG_Code, ItemHierarchical);
                EnumeratorUbigeos = l_matches.GetEnumerator();
                EnumeratorUbigeos.MoveNext();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public bool Save()
        {
            try
            {
                MView.GetItem();
                if (Item.Check())
                {
                    string l_message = BL_VENPY_Ubigeos.BLUBIG_Save(ref pv_item);
                    if (string.IsNullOrEmpty(l_message))
                    {
                        Messages.ShowSatisfactoryMessage(Title, "Se ha guardadó satisfactoriamente");
                        Item = new VENPY_Ubigeos();
                        return true;
                    }
                    else
                    {
                        Messages.ShowWarningMessage(Title, l_message);
                        return false;
                    }
                }
                else
                {
                    Messages.ShowInformationMessage(Title, "Falta ingresar datos obligatorios", Item.UBIG_ErrorMessage);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Messages.ShowErrorMessage(Title, "Ha ocurrido un error al guardar el Item.", ex);
                return false;
            }
        }
        public void Refresh()
        {
            try
            {
                LView.Search();
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Title, "Ha ocurrido un error al actualizar la lista.", ex); }
        }
        public void Action(String p_Action)
        {
            try
            {
                if (ItemTreeView != null)
                {
                    VerifyMatchingProcessEnumerator(ItemTreeView.UBIG_Code);
                    switch (p_Action)
                    {
                        case "A":
                            New();
                            break;
                        case "E":
                            Edit();
                            break;
                        case "R":
                            Delete();
                            break;
                    }
                }
                else
                { Messages.ShowWarningMessage(Title, "Debe seleccionar un Item."); }
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void New()
        {
            try
            {
                if (ItemTreeView.UBIG_Code.Length >= 8)
                {
                    Messages.ShowInformationMessage(Title, "Se tienen como Maximo 3 niveles.");
                    return;
                }

                MView.CleanControls();
                Item = new VENPY_Ubigeos();
                Item.Instance = InstanceEntity.Insert;
                Item.UBIG_Code = GetUbigeoCode(ItemTreeView.UBIG_Code);
                Item.UBIG_ParentCode = ItemTreeView.UBIG_Code == "00" ? null : ItemTreeView.UBIG_Code;
                Item.UBIG_SunatCode = Item.UBIG_Code.Replace(".", string.Empty);
                Item.AUDI_CreationUser = SessionVariables.UserName;
                Item.AUDI_CreationDate = DateTime.Now;
                MView.SetItem();
                ((MAIN001MView)MView).ShowDialog();
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Title, "Ha ocurrido un error al agregar un Item.", ex); }
        }
        private void Edit()
        {
            try
            {
                if (ItemTreeView != null)
                {
                    MView.CleanControls();
                    Item = BL_VENPY_Ubigeos.BLUBIGS_AUbigeo(ItemTreeView.UBIG_Code);
                    if (Item != null && !string.IsNullOrEmpty(Item.UBIG_Code))
                    {
                        Item.Instance = InstanceEntity.Update;
                        Item.AUDI_CreationUser = SessionVariables.UserName;
                        Item.AUDI_CreationDate = DateTime.Now;
                        MView.SetItem();
                        ((MAIN001MView)MView).ShowDialog();
                    }
                    else
                    {
                        if (Messages.ShowQuestionMessage(Title, "El Item seleccionado ya no existe en la Base de Datos ¿Desea refrescar la Lista?", Messages.TLabelButtons.lbt_Yes_No) == DialogResult.Yes)
                        {
                            Refresh();
                        }
                    }
                }
                else
                {
                    Messages.ShowInformationMessage(Title, "Debe seleccionar un elemento para poder editarlo.");
                }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Title, "Ha ocurrido un error al modificar el Item.", ex); }
        }
        private void Delete()
        {
            try
            {
                if (ItemTreeView != null)
                {
                    if (ItemTreeView.UBIG_Offspring == null || ItemTreeView.UBIG_Offspring.Count == 0)
                    {
                        if (Messages.ShowQuestionMessage(Title, "¿Esta seguro que desea eliminar el Item seleccionada?", Messages.TLabelButtons.lbt_Yes_No) == DialogResult.Yes)
                        {
                            string l_message = BL_VENPY_Ubigeos.BLUBIGD_AUbigeo(ref pv_itemtreeview);
                            if (string.IsNullOrEmpty(l_message))
                            {
                                Messages.ShowSatisfactoryMessage(Title, "Se ha eliminado satisfactoriamente el Item");
                                Refresh();
                            }
                            else
                            { Messages.ShowWarningMessage(Title, l_message); }
                        }
                    }
                    else
                    {
                        Messages.ShowWarningMessage(Title, "Solo puede eliminar un Item de ultimo nivel.");
                    }
                }
                else
                {
                    Messages.ShowInformationMessage(Title, "Debe seleccionar un elemento para poder editarlo.");
                }
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(Title, "Ha ocurrido un error al eliminar el Item.", ex); }
        }
        private IEnumerable<VENPY_Ubigeos> FindMatches(String p_SearchText, VENPY_Ubigeos p_Options)
        {
            if (p_Options.UBIG_Offspring == null)
            { p_Options.UBIG_Offspring = new ObservableCollection<VENPY_Ubigeos>(); }

            if (p_Options.UBIG_Code == (string)p_SearchText)
            { yield return p_Options; }

            foreach (VENPY_Ubigeos child in p_Options.UBIG_Offspring)
            {
                foreach (VENPY_Ubigeos match in FindMatches(p_SearchText, child))
                { yield return match; }
            }
        }
        private string GetUbigeoCode(String p_UBIG_ParentCode)
        {
            try
            {
                string l_UBIG_Code = string.Empty;
                ObservableCollection<VENPY_Ubigeos> l_ItemsUbigeos = new ObservableCollection<VENPY_Ubigeos>();
                VerifyMatchingProcessEnumerator(p_UBIG_ParentCode);
                l_ItemsUbigeos = EnumeratorUbigeos.Current.UBIG_Offspring;
                if (l_ItemsUbigeos.Count == 0)
                { l_UBIG_Code = p_UBIG_ParentCode + ".01"; }
                else
                {
                    int l_code;
                    string l_max = string.Empty;
                    string[] l_maxSplit;
                    l_max = l_ItemsUbigeos.Max(pr => pr.UBIG_Code);
                    l_maxSplit = l_max.Split('.');
                    for (int i = 0; i < l_maxSplit.Length - 1; i++)
                    {
                        l_UBIG_Code += l_maxSplit[i];
                        l_UBIG_Code += ".";
                    }
                    if (Int32.TryParse(l_maxSplit[l_maxSplit.Length - 1].ToString(), out l_code))
                    { l_UBIG_Code += (l_code + 1).ToString().PadLeft(2, '0'); }
                }
                return l_UBIG_Code;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
