namespace VenPy.Main
{
    partial class MAIN007MView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAIN007MView));
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tlpTitle1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvPROD_MeasurementUnitsProducts = new VenPy.Controls.CustomDataGridView();
            this.lblPROD_Name = new System.Windows.Forms.Label();
            this.txtPROD_Name = new System.Windows.Forms.TextBox();
            this.lblPROD_Description = new System.Windows.Forms.Label();
            this.txtPROD_Description = new System.Windows.Forms.TextBox();
            this.lblPROD_Code = new System.Windows.Forms.Label();
            this.txtPROD_Code = new System.Windows.Forms.TextBox();
            this.lblTBLE_CodeFAP = new System.Windows.Forms.Label();
            this.cmbTBLE_CodeFAP = new System.Windows.Forms.ComboBox();
            this.lblTBLE_CodeUNM = new System.Windows.Forms.Label();
            this.cmbTBLE_CodeUNM = new System.Windows.Forms.ComboBox();
            this.lblTBLE_CodeMAR = new System.Windows.Forms.Label();
            this.cmbTBLE_CodeMAR = new System.Windows.Forms.ComboBox();
            this.lblPROD_Model = new System.Windows.Forms.Label();
            this.txtPROD_Model = new System.Windows.Forms.TextBox();
            this.lblPROD_Serie = new System.Windows.Forms.Label();
            this.txtPROD_Serie = new System.Windows.Forms.TextBox();
            this.chkPROD_Original = new System.Windows.Forms.CheckBox();
            this.chkPROD_Active = new System.Windows.Forms.CheckBox();
            this.navPROD_MeasurementUnitsProducts = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.lblPROD_MeasurementUnitsProducts = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddDetail = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlpButtons.SuspendLayout();
            this.tlpTitle1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPROD_MeasurementUnitsProducts)).BeginInit();
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
            this.tlpButtons.Location = new System.Drawing.Point(0, 396);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 3;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlpButtons.Size = new System.Drawing.Size(654, 50);
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
            this.btnCancel.Location = new System.Drawing.Point(547, 8);
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
            this.btnSave.Location = new System.Drawing.Point(447, 8);
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
            this.tlpTitle1.Size = new System.Drawing.Size(654, 30);
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
            this.lblTitle1.Size = new System.Drawing.Size(648, 30);
            this.lblTitle1.TabIndex = 0;
            this.lblTitle1.Text = "Datos Generales";
            this.lblTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.AutoScrollMinSize = new System.Drawing.Size(630, 360);
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.Controls.Add(this.dgvPROD_MeasurementUnitsProducts, 3, 10);
            this.tableLayoutPanel2.Controls.Add(this.lblPROD_Name, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtPROD_Name, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblPROD_Description, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.txtPROD_Description, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.lblPROD_Code, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtPROD_Code, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblTBLE_CodeFAP, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbTBLE_CodeFAP, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblTBLE_CodeUNM, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbTBLE_CodeUNM, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblTBLE_CodeMAR, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.cmbTBLE_CodeMAR, 1, 10);
            this.tableLayoutPanel2.Controls.Add(this.lblPROD_Model, 1, 12);
            this.tableLayoutPanel2.Controls.Add(this.txtPROD_Model, 1, 13);
            this.tableLayoutPanel2.Controls.Add(this.lblPROD_Serie, 1, 15);
            this.tableLayoutPanel2.Controls.Add(this.txtPROD_Serie, 1, 16);
            this.tableLayoutPanel2.Controls.Add(this.chkPROD_Original, 5, 4);
            this.tableLayoutPanel2.Controls.Add(this.chkPROD_Active, 5, 3);
            this.tableLayoutPanel2.Controls.Add(this.navPROD_MeasurementUnitsProducts, 3, 9);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 18;
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(654, 366);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // dgvPROD_MeasurementUnitsProducts
            // 
            this.dgvPROD_MeasurementUnitsProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPROD_MeasurementUnitsProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPROD_MeasurementUnitsProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel2.SetColumnSpan(this.dgvPROD_MeasurementUnitsProducts, 3);
            this.dgvPROD_MeasurementUnitsProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(134)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPROD_MeasurementUnitsProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPROD_MeasurementUnitsProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPROD_MeasurementUnitsProducts.EnableHeadersVisualStyles = false;
            this.dgvPROD_MeasurementUnitsProducts.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvPROD_MeasurementUnitsProducts.Location = new System.Drawing.Point(223, 208);
            this.dgvPROD_MeasurementUnitsProducts.Name = "dgvPROD_MeasurementUnitsProducts";
            this.dgvPROD_MeasurementUnitsProducts.RowHeadersVisible = false;
            this.tableLayoutPanel2.SetRowSpan(this.dgvPROD_MeasurementUnitsProducts, 7);
            this.dgvPROD_MeasurementUnitsProducts.Size = new System.Drawing.Size(404, 144);
            this.dgvPROD_MeasurementUnitsProducts.TabIndex = 19;
            // 
            // lblPROD_Name
            // 
            this.lblPROD_Name.AutoSize = true;
            this.lblPROD_Name.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPROD_Name.Location = new System.Drawing.Point(10, 67);
            this.lblPROD_Name.Margin = new System.Windows.Forms.Padding(0, 7, 3, 0);
            this.lblPROD_Name.Name = "lblPROD_Name";
            this.lblPROD_Name.Size = new System.Drawing.Size(64, 17);
            this.lblPROD_Name.TabIndex = 6;
            this.lblPROD_Name.Text = "Nombre";
            this.lblPROD_Name.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtPROD_Name
            // 
            this.txtPROD_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPROD_Name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel2.SetColumnSpan(this.txtPROD_Name, 3);
            this.txtPROD_Name.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPROD_Name.ForeColor = System.Drawing.Color.Black;
            this.txtPROD_Name.Location = new System.Drawing.Point(13, 88);
            this.txtPROD_Name.MaxLength = 50;
            this.txtPROD_Name.Name = "txtPROD_Name";
            this.txtPROD_Name.Size = new System.Drawing.Size(404, 24);
            this.txtPROD_Name.TabIndex = 7;
            // 
            // lblPROD_Description
            // 
            this.lblPROD_Description.AutoSize = true;
            this.lblPROD_Description.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPROD_Description.Location = new System.Drawing.Point(10, 127);
            this.lblPROD_Description.Margin = new System.Windows.Forms.Padding(0, 7, 3, 0);
            this.lblPROD_Description.Name = "lblPROD_Description";
            this.lblPROD_Description.Size = new System.Drawing.Size(78, 17);
            this.lblPROD_Description.TabIndex = 10;
            this.lblPROD_Description.Text = "Descripción";
            this.lblPROD_Description.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtPROD_Description
            // 
            this.txtPROD_Description.BackColor = System.Drawing.SystemColors.Window;
            this.txtPROD_Description.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel2.SetColumnSpan(this.txtPROD_Description, 5);
            this.txtPROD_Description.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPROD_Description.ForeColor = System.Drawing.Color.Black;
            this.txtPROD_Description.Location = new System.Drawing.Point(13, 148);
            this.txtPROD_Description.MaxLength = 100;
            this.txtPROD_Description.Name = "txtPROD_Description";
            this.txtPROD_Description.Size = new System.Drawing.Size(614, 24);
            this.txtPROD_Description.TabIndex = 11;
            // 
            // lblPROD_Code
            // 
            this.lblPROD_Code.AutoSize = true;
            this.lblPROD_Code.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPROD_Code.Location = new System.Drawing.Point(10, 7);
            this.lblPROD_Code.Margin = new System.Windows.Forms.Padding(0, 7, 3, 0);
            this.lblPROD_Code.Name = "lblPROD_Code";
            this.lblPROD_Code.Size = new System.Drawing.Size(57, 17);
            this.lblPROD_Code.TabIndex = 0;
            this.lblPROD_Code.Text = "Codigo";
            this.lblPROD_Code.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtPROD_Code
            // 
            this.txtPROD_Code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPROD_Code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPROD_Code.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPROD_Code.ForeColor = System.Drawing.Color.Black;
            this.txtPROD_Code.Location = new System.Drawing.Point(13, 28);
            this.txtPROD_Code.MaxLength = 20;
            this.txtPROD_Code.Name = "txtPROD_Code";
            this.txtPROD_Code.ReadOnly = true;
            this.txtPROD_Code.Size = new System.Drawing.Size(194, 24);
            this.txtPROD_Code.TabIndex = 1;
            this.txtPROD_Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTBLE_CodeFAP
            // 
            this.lblTBLE_CodeFAP.AutoSize = true;
            this.lblTBLE_CodeFAP.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTBLE_CodeFAP.Location = new System.Drawing.Point(220, 7);
            this.lblTBLE_CodeFAP.Margin = new System.Windows.Forms.Padding(0, 7, 3, 0);
            this.lblTBLE_CodeFAP.Name = "lblTBLE_CodeFAP";
            this.lblTBLE_CodeFAP.Size = new System.Drawing.Size(54, 17);
            this.lblTBLE_CodeFAP.TabIndex = 2;
            this.lblTBLE_CodeFAP.Text = "Familia";
            this.lblTBLE_CodeFAP.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbTBLE_CodeFAP
            // 
            this.cmbTBLE_CodeFAP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbTBLE_CodeFAP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTBLE_CodeFAP.DropDownWidth = 300;
            this.cmbTBLE_CodeFAP.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTBLE_CodeFAP.FormattingEnabled = true;
            this.cmbTBLE_CodeFAP.Location = new System.Drawing.Point(223, 28);
            this.cmbTBLE_CodeFAP.Name = "cmbTBLE_CodeFAP";
            this.cmbTBLE_CodeFAP.Size = new System.Drawing.Size(194, 24);
            this.cmbTBLE_CodeFAP.TabIndex = 3;
            // 
            // lblTBLE_CodeUNM
            // 
            this.lblTBLE_CodeUNM.AutoSize = true;
            this.lblTBLE_CodeUNM.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTBLE_CodeUNM.Location = new System.Drawing.Point(430, 7);
            this.lblTBLE_CodeUNM.Margin = new System.Windows.Forms.Padding(0, 7, 3, 0);
            this.lblTBLE_CodeUNM.Name = "lblTBLE_CodeUNM";
            this.lblTBLE_CodeUNM.Size = new System.Drawing.Size(139, 17);
            this.lblTBLE_CodeUNM.TabIndex = 4;
            this.lblTBLE_CodeUNM.Text = "Uni. Medida Mínima";
            this.lblTBLE_CodeUNM.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbTBLE_CodeUNM
            // 
            this.cmbTBLE_CodeUNM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbTBLE_CodeUNM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTBLE_CodeUNM.DropDownWidth = 300;
            this.cmbTBLE_CodeUNM.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTBLE_CodeUNM.FormattingEnabled = true;
            this.cmbTBLE_CodeUNM.Location = new System.Drawing.Point(433, 28);
            this.cmbTBLE_CodeUNM.Name = "cmbTBLE_CodeUNM";
            this.cmbTBLE_CodeUNM.Size = new System.Drawing.Size(194, 24);
            this.cmbTBLE_CodeUNM.TabIndex = 5;
            // 
            // lblTBLE_CodeMAR
            // 
            this.lblTBLE_CodeMAR.AutoSize = true;
            this.lblTBLE_CodeMAR.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTBLE_CodeMAR.Location = new System.Drawing.Point(10, 187);
            this.lblTBLE_CodeMAR.Margin = new System.Windows.Forms.Padding(0, 7, 3, 0);
            this.lblTBLE_CodeMAR.Name = "lblTBLE_CodeMAR";
            this.lblTBLE_CodeMAR.Size = new System.Drawing.Size(44, 17);
            this.lblTBLE_CodeMAR.TabIndex = 12;
            this.lblTBLE_CodeMAR.Text = "Marca";
            this.lblTBLE_CodeMAR.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbTBLE_CodeMAR
            // 
            this.cmbTBLE_CodeMAR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTBLE_CodeMAR.DropDownWidth = 300;
            this.cmbTBLE_CodeMAR.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTBLE_CodeMAR.FormattingEnabled = true;
            this.cmbTBLE_CodeMAR.Location = new System.Drawing.Point(13, 208);
            this.cmbTBLE_CodeMAR.Name = "cmbTBLE_CodeMAR";
            this.cmbTBLE_CodeMAR.Size = new System.Drawing.Size(194, 24);
            this.cmbTBLE_CodeMAR.TabIndex = 13;
            // 
            // lblPROD_Model
            // 
            this.lblPROD_Model.AutoSize = true;
            this.lblPROD_Model.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPROD_Model.Location = new System.Drawing.Point(10, 247);
            this.lblPROD_Model.Margin = new System.Windows.Forms.Padding(0, 7, 3, 0);
            this.lblPROD_Model.Name = "lblPROD_Model";
            this.lblPROD_Model.Size = new System.Drawing.Size(51, 17);
            this.lblPROD_Model.TabIndex = 14;
            this.lblPROD_Model.Text = "Modelo";
            this.lblPROD_Model.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtPROD_Model
            // 
            this.txtPROD_Model.BackColor = System.Drawing.SystemColors.Window;
            this.txtPROD_Model.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPROD_Model.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPROD_Model.ForeColor = System.Drawing.Color.Black;
            this.txtPROD_Model.Location = new System.Drawing.Point(13, 268);
            this.txtPROD_Model.MaxLength = 50;
            this.txtPROD_Model.Name = "txtPROD_Model";
            this.txtPROD_Model.Size = new System.Drawing.Size(194, 24);
            this.txtPROD_Model.TabIndex = 15;
            // 
            // lblPROD_Serie
            // 
            this.lblPROD_Serie.AutoSize = true;
            this.lblPROD_Serie.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPROD_Serie.Location = new System.Drawing.Point(10, 307);
            this.lblPROD_Serie.Margin = new System.Windows.Forms.Padding(0, 7, 3, 0);
            this.lblPROD_Serie.Name = "lblPROD_Serie";
            this.lblPROD_Serie.Size = new System.Drawing.Size(37, 17);
            this.lblPROD_Serie.TabIndex = 16;
            this.lblPROD_Serie.Text = "Serie";
            this.lblPROD_Serie.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtPROD_Serie
            // 
            this.txtPROD_Serie.BackColor = System.Drawing.SystemColors.Window;
            this.txtPROD_Serie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPROD_Serie.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPROD_Serie.ForeColor = System.Drawing.Color.Black;
            this.txtPROD_Serie.Location = new System.Drawing.Point(13, 328);
            this.txtPROD_Serie.MaxLength = 50;
            this.txtPROD_Serie.Name = "txtPROD_Serie";
            this.txtPROD_Serie.Size = new System.Drawing.Size(194, 24);
            this.txtPROD_Serie.TabIndex = 17;
            // 
            // chkPROD_Original
            // 
            this.chkPROD_Original.AutoSize = true;
            this.chkPROD_Original.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPROD_Original.Location = new System.Drawing.Point(433, 88);
            this.chkPROD_Original.Name = "chkPROD_Original";
            this.chkPROD_Original.Size = new System.Drawing.Size(71, 21);
            this.chkPROD_Original.TabIndex = 9;
            this.chkPROD_Original.Text = "Original";
            this.chkPROD_Original.UseVisualStyleBackColor = true;
            // 
            // chkPROD_Active
            // 
            this.chkPROD_Active.AutoSize = true;
            this.chkPROD_Active.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPROD_Active.Location = new System.Drawing.Point(433, 63);
            this.chkPROD_Active.Name = "chkPROD_Active";
            this.chkPROD_Active.Size = new System.Drawing.Size(65, 19);
            this.chkPROD_Active.TabIndex = 8;
            this.chkPROD_Active.Text = "Activo";
            this.chkPROD_Active.UseVisualStyleBackColor = true;
            // 
            // navPROD_MeasurementUnitsProducts
            // 
            this.navPROD_MeasurementUnitsProducts.AddNewItem = null;
            this.tableLayoutPanel2.SetColumnSpan(this.navPROD_MeasurementUnitsProducts, 3);
            this.navPROD_MeasurementUnitsProducts.CountItem = this.bindingNavigatorCountItem;
            this.navPROD_MeasurementUnitsProducts.DeleteItem = null;
            this.navPROD_MeasurementUnitsProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navPROD_MeasurementUnitsProducts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblPROD_MeasurementUnitsProducts,
            this.toolStripSeparator2,
            this.btnAddDetail,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.toolStripSeparator1});
            this.navPROD_MeasurementUnitsProducts.Location = new System.Drawing.Point(220, 180);
            this.navPROD_MeasurementUnitsProducts.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.navPROD_MeasurementUnitsProducts.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.navPROD_MeasurementUnitsProducts.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.navPROD_MeasurementUnitsProducts.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.navPROD_MeasurementUnitsProducts.Name = "navPROD_MeasurementUnitsProducts";
            this.navPROD_MeasurementUnitsProducts.PositionItem = this.bindingNavigatorPositionItem;
            this.navPROD_MeasurementUnitsProducts.Size = new System.Drawing.Size(410, 25);
            this.navPROD_MeasurementUnitsProducts.TabIndex = 18;
            this.navPROD_MeasurementUnitsProducts.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // lblPROD_MeasurementUnitsProducts
            // 
            this.lblPROD_MeasurementUnitsProducts.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblPROD_MeasurementUnitsProducts.Name = "lblPROD_MeasurementUnitsProducts";
            this.lblPROD_MeasurementUnitsProducts.Size = new System.Drawing.Size(145, 22);
            this.lblPROD_MeasurementUnitsProducts.Text = "Unidades de Medida";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAddDetail
            // 
            this.btnAddDetail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddDetail.Image = global::VenPy.Main.Properties.Resources.add_16x16;
            this.btnAddDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(23, 22);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // MAIN007MView
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(654, 446);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tlpTitle1);
            this.Controls.Add(this.tlpButtons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(670, 485);
            this.Name = "MAIN007MView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PRODUCTOS";
            this.tlpButtons.ResumeLayout(false);
            this.tlpTitle1.ResumeLayout(false);
            this.tlpTitle1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPROD_MeasurementUnitsProducts)).EndInit();
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
        private System.Windows.Forms.Label lblPROD_Code;
        private System.Windows.Forms.TextBox txtPROD_Code;
        private System.Windows.Forms.Label lblPROD_Name;
        private System.Windows.Forms.TextBox txtPROD_Name;
        private System.Windows.Forms.Label lblPROD_Description;
        private System.Windows.Forms.TextBox txtPROD_Description;
        private System.Windows.Forms.CheckBox chkPROD_Active;
        private System.Windows.Forms.CheckBox chkPROD_Original;
        private System.Windows.Forms.Label lblTBLE_CodeFAP;
        private System.Windows.Forms.ComboBox cmbTBLE_CodeFAP;
        private System.Windows.Forms.Label lblTBLE_CodeUNM;
        private System.Windows.Forms.ComboBox cmbTBLE_CodeUNM;
        private System.Windows.Forms.Label lblTBLE_CodeMAR;
        private System.Windows.Forms.Label lblPROD_Model;
        private System.Windows.Forms.Label lblPROD_Serie;
        private System.Windows.Forms.TextBox txtPROD_Serie;
        private System.Windows.Forms.TextBox txtPROD_Model;
        private System.Windows.Forms.ComboBox cmbTBLE_CodeMAR;
        private Controls.CustomDataGridView dgvPROD_MeasurementUnitsProducts;
        private System.Windows.Forms.BindingNavigator navPROD_MeasurementUnitsProducts;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripLabel lblPROD_MeasurementUnitsProducts;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAddDetail;
    }
}