namespace VenPy.Main
{
    partial class MAIN008MView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAIN008MView));
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tlpTitle1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvPRLI_PriceListDetail = new VenPy.Controls.CustomDataGridView();
            this.lblPRLI_Code = new System.Windows.Forms.Label();
            this.txtPRLI_Code = new System.Windows.Forms.TextBox();
            this.navPROD_MeasurementUnitsProducts = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.lblPRLI_PriceListDetail = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblTBLE_CodeMND = new System.Windows.Forms.Label();
            this.cmbTBLE_CodeMND = new System.Windows.Forms.ComboBox();
            this.lblPRLI_Name = new System.Windows.Forms.Label();
            this.txtPRLI_Name = new System.Windows.Forms.TextBox();
            this.lblTBLE_CodeTAI = new System.Windows.Forms.Label();
            this.cmbTBLE_CodeTAI = new System.Windows.Forms.ComboBox();
            this.lblPRLI_Description = new System.Windows.Forms.Label();
            this.txtPRLI_Description = new System.Windows.Forms.TextBox();
            this.chkPRLI_Active = new System.Windows.Forms.CheckBox();
            this.tlpButtons.SuspendLayout();
            this.tlpTitle1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRLI_PriceListDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navPROD_MeasurementUnitsProducts)).BeginInit();
            this.navPROD_MeasurementUnitsProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpButtons
            // 
            this.tlpButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.tlpButtons.ColumnCount = 4;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpButtons.Controls.Add(this.btnCancel, 2, 1);
            this.tlpButtons.Controls.Add(this.btnSave, 1, 1);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpButtons.Location = new System.Drawing.Point(0, 456);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 3;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlpButtons.Size = new System.Drawing.Size(864, 50);
            this.tlpButtons.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(757, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 34);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(174)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(122)))), ((int)(((byte)(182)))));
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(657, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 34);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // tlpTitle1
            // 
            this.tlpTitle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.tlpTitle1.ColumnCount = 1;
            this.tlpTitle1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTitle1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTitle1.Controls.Add(this.lblTitle1, 0, 0);
            this.tlpTitle1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpTitle1.Location = new System.Drawing.Point(0, 0);
            this.tlpTitle1.Name = "tlpTitle1";
            this.tlpTitle1.RowCount = 1;
            this.tlpTitle1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpTitle1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpTitle1.Size = new System.Drawing.Size(864, 30);
            this.tlpTitle1.TabIndex = 0;
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.ForeColor = System.Drawing.Color.White;
            this.lblTitle1.Location = new System.Drawing.Point(3, 0);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(858, 30);
            this.lblTitle1.TabIndex = 0;
            this.lblTitle1.Text = "Datos Generales";
            this.lblTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.AutoScrollMinSize = new System.Drawing.Size(855, 395);
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.tableLayoutPanel2.ColumnCount = 9;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.Controls.Add(this.dgvPRLI_PriceListDetail, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.lblPRLI_Code, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtPRLI_Code, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.navPROD_MeasurementUnitsProducts, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.lblTBLE_CodeMND, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbTBLE_CodeMND, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblPRLI_Name, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtPRLI_Name, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblTBLE_CodeTAI, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.cmbTBLE_CodeTAI, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblPRLI_Description, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtPRLI_Description, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.chkPRLI_Active, 5, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 21;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(864, 426);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // dgvPRLI_PriceListDetail
            // 
            this.dgvPRLI_PriceListDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPRLI_PriceListDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPRLI_PriceListDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel2.SetColumnSpan(this.dgvPRLI_PriceListDetail, 7);
            this.dgvPRLI_PriceListDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(134)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPRLI_PriceListDetail.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPRLI_PriceListDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPRLI_PriceListDetail.EnableHeadersVisualStyles = false;
            this.dgvPRLI_PriceListDetail.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvPRLI_PriceListDetail.Location = new System.Drawing.Point(13, 148);
            this.dgvPRLI_PriceListDetail.Name = "dgvPRLI_PriceListDetail";
            this.dgvPRLI_PriceListDetail.RowHeadersVisible = false;
            this.tableLayoutPanel2.SetRowSpan(this.dgvPRLI_PriceListDetail, 13);
            this.dgvPRLI_PriceListDetail.Size = new System.Drawing.Size(824, 264);
            this.dgvPRLI_PriceListDetail.TabIndex = 12;
            // 
            // lblPRLI_Code
            // 
            this.lblPRLI_Code.AutoSize = true;
            this.lblPRLI_Code.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPRLI_Code.Location = new System.Drawing.Point(10, 7);
            this.lblPRLI_Code.Margin = new System.Windows.Forms.Padding(0, 7, 3, 0);
            this.lblPRLI_Code.Name = "lblPRLI_Code";
            this.lblPRLI_Code.Size = new System.Drawing.Size(57, 17);
            this.lblPRLI_Code.TabIndex = 0;
            this.lblPRLI_Code.Text = "Codigo";
            this.lblPRLI_Code.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtPRLI_Code
            // 
            this.txtPRLI_Code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPRLI_Code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPRLI_Code.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPRLI_Code.ForeColor = System.Drawing.Color.Black;
            this.txtPRLI_Code.Location = new System.Drawing.Point(13, 28);
            this.txtPRLI_Code.MaxLength = 20;
            this.txtPRLI_Code.Name = "txtPRLI_Code";
            this.txtPRLI_Code.ReadOnly = true;
            this.txtPRLI_Code.Size = new System.Drawing.Size(194, 24);
            this.txtPRLI_Code.TabIndex = 1;
            this.txtPRLI_Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // navPROD_MeasurementUnitsProducts
            // 
            this.navPROD_MeasurementUnitsProducts.AddNewItem = null;
            this.tableLayoutPanel2.SetColumnSpan(this.navPROD_MeasurementUnitsProducts, 3);
            this.navPROD_MeasurementUnitsProducts.CountItem = this.bindingNavigatorCountItem;
            this.navPROD_MeasurementUnitsProducts.DeleteItem = null;
            this.navPROD_MeasurementUnitsProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navPROD_MeasurementUnitsProducts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblPRLI_PriceListDetail,
            this.toolStripSeparator2,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.toolStripSeparator1});
            this.navPROD_MeasurementUnitsProducts.Location = new System.Drawing.Point(10, 120);
            this.navPROD_MeasurementUnitsProducts.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.navPROD_MeasurementUnitsProducts.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.navPROD_MeasurementUnitsProducts.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.navPROD_MeasurementUnitsProducts.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.navPROD_MeasurementUnitsProducts.Name = "navPROD_MeasurementUnitsProducts";
            this.navPROD_MeasurementUnitsProducts.PositionItem = this.bindingNavigatorPositionItem;
            this.navPROD_MeasurementUnitsProducts.Size = new System.Drawing.Size(410, 25);
            this.navPROD_MeasurementUnitsProducts.TabIndex = 11;
            this.navPROD_MeasurementUnitsProducts.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // lblPRLI_PriceListDetail
            // 
            this.lblPRLI_PriceListDetail.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblPRLI_PriceListDetail.Name = "lblPRLI_PriceListDetail";
            this.lblPRLI_PriceListDetail.Size = new System.Drawing.Size(57, 22);
            this.lblPRLI_PriceListDetail.Text = "Precios";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // lblTBLE_CodeMND
            // 
            this.lblTBLE_CodeMND.AutoSize = true;
            this.lblTBLE_CodeMND.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTBLE_CodeMND.Location = new System.Drawing.Point(220, 7);
            this.lblTBLE_CodeMND.Margin = new System.Windows.Forms.Padding(0, 7, 3, 0);
            this.lblTBLE_CodeMND.Name = "lblTBLE_CodeMND";
            this.lblTBLE_CodeMND.Size = new System.Drawing.Size(63, 17);
            this.lblTBLE_CodeMND.TabIndex = 2;
            this.lblTBLE_CodeMND.Text = "Moneda";
            this.lblTBLE_CodeMND.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbTBLE_CodeMND
            // 
            this.cmbTBLE_CodeMND.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbTBLE_CodeMND.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTBLE_CodeMND.DropDownWidth = 300;
            this.cmbTBLE_CodeMND.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTBLE_CodeMND.FormattingEnabled = true;
            this.cmbTBLE_CodeMND.Location = new System.Drawing.Point(223, 28);
            this.cmbTBLE_CodeMND.Name = "cmbTBLE_CodeMND";
            this.cmbTBLE_CodeMND.Size = new System.Drawing.Size(194, 24);
            this.cmbTBLE_CodeMND.TabIndex = 3;
            // 
            // lblPRLI_Name
            // 
            this.lblPRLI_Name.AutoSize = true;
            this.lblPRLI_Name.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPRLI_Name.Location = new System.Drawing.Point(430, 7);
            this.lblPRLI_Name.Margin = new System.Windows.Forms.Padding(0, 7, 3, 0);
            this.lblPRLI_Name.Name = "lblPRLI_Name";
            this.lblPRLI_Name.Size = new System.Drawing.Size(64, 17);
            this.lblPRLI_Name.TabIndex = 5;
            this.lblPRLI_Name.Text = "Nombre";
            this.lblPRLI_Name.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtPRLI_Name
            // 
            this.txtPRLI_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPRLI_Name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel2.SetColumnSpan(this.txtPRLI_Name, 3);
            this.txtPRLI_Name.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPRLI_Name.ForeColor = System.Drawing.Color.Black;
            this.txtPRLI_Name.Location = new System.Drawing.Point(433, 28);
            this.txtPRLI_Name.MaxLength = 50;
            this.txtPRLI_Name.Name = "txtPRLI_Name";
            this.txtPRLI_Name.Size = new System.Drawing.Size(404, 24);
            this.txtPRLI_Name.TabIndex = 6;
            // 
            // lblTBLE_CodeTAI
            // 
            this.lblTBLE_CodeTAI.AutoSize = true;
            this.lblTBLE_CodeTAI.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTBLE_CodeTAI.Location = new System.Drawing.Point(10, 67);
            this.lblTBLE_CodeTAI.Margin = new System.Windows.Forms.Padding(0, 7, 3, 0);
            this.lblTBLE_CodeTAI.Name = "lblTBLE_CodeTAI";
            this.lblTBLE_CodeTAI.Size = new System.Drawing.Size(126, 17);
            this.lblTBLE_CodeTAI.TabIndex = 7;
            this.lblTBLE_CodeTAI.Text = "Tipo Afectación IGV";
            this.lblTBLE_CodeTAI.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbTBLE_CodeTAI
            // 
            this.cmbTBLE_CodeTAI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTBLE_CodeTAI.DropDownWidth = 300;
            this.cmbTBLE_CodeTAI.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTBLE_CodeTAI.FormattingEnabled = true;
            this.cmbTBLE_CodeTAI.Location = new System.Drawing.Point(13, 88);
            this.cmbTBLE_CodeTAI.Name = "cmbTBLE_CodeTAI";
            this.cmbTBLE_CodeTAI.Size = new System.Drawing.Size(194, 24);
            this.cmbTBLE_CodeTAI.TabIndex = 8;
            // 
            // lblPRLI_Description
            // 
            this.lblPRLI_Description.AutoSize = true;
            this.lblPRLI_Description.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPRLI_Description.Location = new System.Drawing.Point(220, 67);
            this.lblPRLI_Description.Margin = new System.Windows.Forms.Padding(0, 7, 3, 0);
            this.lblPRLI_Description.Name = "lblPRLI_Description";
            this.lblPRLI_Description.Size = new System.Drawing.Size(78, 17);
            this.lblPRLI_Description.TabIndex = 9;
            this.lblPRLI_Description.Text = "Descripción";
            this.lblPRLI_Description.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtPRLI_Description
            // 
            this.txtPRLI_Description.BackColor = System.Drawing.SystemColors.Window;
            this.txtPRLI_Description.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel2.SetColumnSpan(this.txtPRLI_Description, 5);
            this.txtPRLI_Description.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPRLI_Description.ForeColor = System.Drawing.Color.Black;
            this.txtPRLI_Description.Location = new System.Drawing.Point(223, 88);
            this.txtPRLI_Description.MaxLength = 100;
            this.txtPRLI_Description.Name = "txtPRLI_Description";
            this.txtPRLI_Description.Size = new System.Drawing.Size(614, 24);
            this.txtPRLI_Description.TabIndex = 10;
            // 
            // chkPRLI_Active
            // 
            this.chkPRLI_Active.AutoSize = true;
            this.chkPRLI_Active.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPRLI_Active.Location = new System.Drawing.Point(433, 123);
            this.chkPRLI_Active.Name = "chkPRLI_Active";
            this.chkPRLI_Active.Size = new System.Drawing.Size(70, 19);
            this.chkPRLI_Active.TabIndex = 4;
            this.chkPRLI_Active.Text = "Activo";
            this.chkPRLI_Active.UseVisualStyleBackColor = true;
            // 
            // MAIN008MView
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(864, 506);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tlpTitle1);
            this.Controls.Add(this.tlpButtons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(880, 545);
            this.Name = "MAIN008MView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LISTA DE PRECIOS";
            this.tlpButtons.ResumeLayout(false);
            this.tlpTitle1.ResumeLayout(false);
            this.tlpTitle1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRLI_PriceListDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navPROD_MeasurementUnitsProducts)).EndInit();
            this.navPROD_MeasurementUnitsProducts.ResumeLayout(false);
            this.navPROD_MeasurementUnitsProducts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel tlpTitle1;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblPRLI_Code;
        private System.Windows.Forms.TextBox txtPRLI_Code;
        private System.Windows.Forms.Label lblPRLI_Name;
        private System.Windows.Forms.TextBox txtPRLI_Name;
        private System.Windows.Forms.Label lblPRLI_Description;
        private System.Windows.Forms.TextBox txtPRLI_Description;
        private System.Windows.Forms.CheckBox chkPRLI_Active;
        private System.Windows.Forms.Label lblTBLE_CodeMND;
        private System.Windows.Forms.ComboBox cmbTBLE_CodeMND;
        private System.Windows.Forms.Label lblTBLE_CodeTAI;
        private System.Windows.Forms.ComboBox cmbTBLE_CodeTAI;
        private Controls.CustomDataGridView dgvPRLI_PriceListDetail;
        private System.Windows.Forms.BindingNavigator navPROD_MeasurementUnitsProducts;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripLabel lblPRLI_PriceListDetail;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}