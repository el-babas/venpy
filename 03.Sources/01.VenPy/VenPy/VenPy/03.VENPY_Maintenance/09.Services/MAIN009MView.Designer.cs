namespace VenPy.Main
{
    partial class MAIN009MView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAIN009MView));
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tlpTitle1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSERV_Name = new System.Windows.Forms.Label();
            this.txtSERV_Name = new System.Windows.Forms.TextBox();
            this.lblSERV_Description = new System.Windows.Forms.Label();
            this.txtSERV_Description = new System.Windows.Forms.TextBox();
            this.lblTBLE_CodeFAS = new System.Windows.Forms.Label();
            this.cmbTBLE_CodeFAS = new System.Windows.Forms.ComboBox();
            this.lblSERV_Code = new System.Windows.Forms.Label();
            this.txtSERV_Code = new System.Windows.Forms.TextBox();
            this.chkSERV_Active = new System.Windows.Forms.CheckBox();
            this.lblTBLE_CodeUNM = new System.Windows.Forms.Label();
            this.cmbTBLE_CodeUNM = new System.Windows.Forms.ComboBox();
            this.lblTBLE_CodeMND = new System.Windows.Forms.Label();
            this.cmbTBLE_CodeMND = new System.Windows.Forms.ComboBox();
            this.lblTBLE_CodeTAI = new System.Windows.Forms.Label();
            this.cmbTBLE_CodeTAI = new System.Windows.Forms.ComboBox();
            this.lblSERV_UnitValue = new System.Windows.Forms.Label();
            this.lblSERV_UnitPrice = new System.Windows.Forms.Label();
            this.lblSERV_IGV = new System.Windows.Forms.Label();
            this.txnSERV_UnitValue = new VenPy.Controls.TextBoxNumeric();
            this.txnSERV_UnitPrice = new VenPy.Controls.TextBoxNumeric();
            this.txnSERV_IGV = new VenPy.Controls.TextBoxNumeric();
            this.tlpButtons.SuspendLayout();
            this.tlpTitle1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.tlpButtons.Location = new System.Drawing.Point(0, 341);
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
            this.tableLayoutPanel2.AutoScrollMinSize = new System.Drawing.Size(630, 300);
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.Controls.Add(this.lblSERV_Name, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtSERV_Name, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblSERV_Description, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.txtSERV_Description, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.lblTBLE_CodeFAS, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbTBLE_CodeFAS, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblSERV_Code, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtSERV_Code, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.chkSERV_Active, 5, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblTBLE_CodeUNM, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.cmbTBLE_CodeUNM, 1, 10);
            this.tableLayoutPanel2.Controls.Add(this.lblTBLE_CodeMND, 3, 9);
            this.tableLayoutPanel2.Controls.Add(this.cmbTBLE_CodeMND, 3, 10);
            this.tableLayoutPanel2.Controls.Add(this.lblTBLE_CodeTAI, 5, 9);
            this.tableLayoutPanel2.Controls.Add(this.cmbTBLE_CodeTAI, 5, 10);
            this.tableLayoutPanel2.Controls.Add(this.lblSERV_UnitValue, 1, 12);
            this.tableLayoutPanel2.Controls.Add(this.txnSERV_UnitValue, 1, 13);
            this.tableLayoutPanel2.Controls.Add(this.lblSERV_IGV, 3, 12);
            this.tableLayoutPanel2.Controls.Add(this.txnSERV_UnitPrice, 5, 13);
            this.tableLayoutPanel2.Controls.Add(this.lblSERV_UnitPrice, 5, 12);
            this.tableLayoutPanel2.Controls.Add(this.txnSERV_IGV, 3, 13);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 15;
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
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(654, 311);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblSERV_Name
            // 
            this.lblSERV_Name.AutoSize = true;
            this.lblSERV_Name.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERV_Name.Location = new System.Drawing.Point(10, 67);
            this.lblSERV_Name.Margin = new System.Windows.Forms.Padding(0, 7, 3, 0);
            this.lblSERV_Name.Name = "lblSERV_Name";
            this.lblSERV_Name.Size = new System.Drawing.Size(64, 17);
            this.lblSERV_Name.TabIndex = 4;
            this.lblSERV_Name.Text = "Nombre";
            this.lblSERV_Name.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtSERV_Name
            // 
            this.txtSERV_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSERV_Name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel2.SetColumnSpan(this.txtSERV_Name, 3);
            this.txtSERV_Name.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSERV_Name.ForeColor = System.Drawing.Color.Black;
            this.txtSERV_Name.Location = new System.Drawing.Point(13, 88);
            this.txtSERV_Name.MaxLength = 50;
            this.txtSERV_Name.Name = "txtSERV_Name";
            this.txtSERV_Name.Size = new System.Drawing.Size(404, 24);
            this.txtSERV_Name.TabIndex = 5;
            // 
            // lblSERV_Description
            // 
            this.lblSERV_Description.AutoSize = true;
            this.lblSERV_Description.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERV_Description.Location = new System.Drawing.Point(10, 127);
            this.lblSERV_Description.Margin = new System.Windows.Forms.Padding(0, 7, 3, 0);
            this.lblSERV_Description.Name = "lblSERV_Description";
            this.lblSERV_Description.Size = new System.Drawing.Size(78, 17);
            this.lblSERV_Description.TabIndex = 7;
            this.lblSERV_Description.Text = "Descripción";
            this.lblSERV_Description.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtSERV_Description
            // 
            this.txtSERV_Description.BackColor = System.Drawing.SystemColors.Window;
            this.txtSERV_Description.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel2.SetColumnSpan(this.txtSERV_Description, 5);
            this.txtSERV_Description.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSERV_Description.ForeColor = System.Drawing.Color.Black;
            this.txtSERV_Description.Location = new System.Drawing.Point(13, 148);
            this.txtSERV_Description.MaxLength = 100;
            this.txtSERV_Description.Name = "txtSERV_Description";
            this.txtSERV_Description.Size = new System.Drawing.Size(614, 24);
            this.txtSERV_Description.TabIndex = 8;
            // 
            // lblTBLE_CodeFAS
            // 
            this.lblTBLE_CodeFAS.AutoSize = true;
            this.lblTBLE_CodeFAS.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTBLE_CodeFAS.Location = new System.Drawing.Point(430, 7);
            this.lblTBLE_CodeFAS.Margin = new System.Windows.Forms.Padding(0, 7, 3, 0);
            this.lblTBLE_CodeFAS.Name = "lblTBLE_CodeFAS";
            this.lblTBLE_CodeFAS.Size = new System.Drawing.Size(54, 17);
            this.lblTBLE_CodeFAS.TabIndex = 2;
            this.lblTBLE_CodeFAS.Text = "Familia";
            this.lblTBLE_CodeFAS.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbTBLE_CodeFAS
            // 
            this.cmbTBLE_CodeFAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbTBLE_CodeFAS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTBLE_CodeFAS.DropDownWidth = 300;
            this.cmbTBLE_CodeFAS.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTBLE_CodeFAS.FormattingEnabled = true;
            this.cmbTBLE_CodeFAS.Location = new System.Drawing.Point(433, 28);
            this.cmbTBLE_CodeFAS.Name = "cmbTBLE_CodeFAS";
            this.cmbTBLE_CodeFAS.Size = new System.Drawing.Size(194, 24);
            this.cmbTBLE_CodeFAS.TabIndex = 3;
            // 
            // lblSERV_Code
            // 
            this.lblSERV_Code.AutoSize = true;
            this.lblSERV_Code.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERV_Code.Location = new System.Drawing.Point(220, 7);
            this.lblSERV_Code.Margin = new System.Windows.Forms.Padding(0, 7, 3, 0);
            this.lblSERV_Code.Name = "lblSERV_Code";
            this.lblSERV_Code.Size = new System.Drawing.Size(57, 17);
            this.lblSERV_Code.TabIndex = 0;
            this.lblSERV_Code.Text = "Codigo";
            this.lblSERV_Code.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtSERV_Code
            // 
            this.txtSERV_Code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSERV_Code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSERV_Code.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSERV_Code.ForeColor = System.Drawing.Color.Black;
            this.txtSERV_Code.Location = new System.Drawing.Point(223, 28);
            this.txtSERV_Code.MaxLength = 20;
            this.txtSERV_Code.Name = "txtSERV_Code";
            this.txtSERV_Code.ReadOnly = true;
            this.txtSERV_Code.Size = new System.Drawing.Size(194, 24);
            this.txtSERV_Code.TabIndex = 1;
            this.txtSERV_Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkSERV_Active
            // 
            this.chkSERV_Active.AutoSize = true;
            this.chkSERV_Active.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSERV_Active.Location = new System.Drawing.Point(433, 88);
            this.chkSERV_Active.Name = "chkSERV_Active";
            this.chkSERV_Active.Size = new System.Drawing.Size(65, 21);
            this.chkSERV_Active.TabIndex = 6;
            this.chkSERV_Active.Text = "Activo";
            this.chkSERV_Active.UseVisualStyleBackColor = true;
            // 
            // lblTBLE_CodeUNM
            // 
            this.lblTBLE_CodeUNM.AutoSize = true;
            this.lblTBLE_CodeUNM.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTBLE_CodeUNM.Location = new System.Drawing.Point(10, 187);
            this.lblTBLE_CodeUNM.Margin = new System.Windows.Forms.Padding(0, 7, 3, 0);
            this.lblTBLE_CodeUNM.Name = "lblTBLE_CodeUNM";
            this.lblTBLE_CodeUNM.Size = new System.Drawing.Size(87, 17);
            this.lblTBLE_CodeUNM.TabIndex = 9;
            this.lblTBLE_CodeUNM.Text = "Uni. Medida";
            this.lblTBLE_CodeUNM.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbTBLE_CodeUNM
            // 
            this.cmbTBLE_CodeUNM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbTBLE_CodeUNM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTBLE_CodeUNM.DropDownWidth = 300;
            this.cmbTBLE_CodeUNM.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTBLE_CodeUNM.FormattingEnabled = true;
            this.cmbTBLE_CodeUNM.Location = new System.Drawing.Point(13, 208);
            this.cmbTBLE_CodeUNM.Name = "cmbTBLE_CodeUNM";
            this.cmbTBLE_CodeUNM.Size = new System.Drawing.Size(194, 24);
            this.cmbTBLE_CodeUNM.TabIndex = 10;
            // 
            // lblTBLE_CodeMND
            // 
            this.lblTBLE_CodeMND.AutoSize = true;
            this.lblTBLE_CodeMND.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTBLE_CodeMND.Location = new System.Drawing.Point(220, 187);
            this.lblTBLE_CodeMND.Margin = new System.Windows.Forms.Padding(0, 7, 3, 0);
            this.lblTBLE_CodeMND.Name = "lblTBLE_CodeMND";
            this.lblTBLE_CodeMND.Size = new System.Drawing.Size(63, 17);
            this.lblTBLE_CodeMND.TabIndex = 11;
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
            this.cmbTBLE_CodeMND.Location = new System.Drawing.Point(223, 208);
            this.cmbTBLE_CodeMND.Name = "cmbTBLE_CodeMND";
            this.cmbTBLE_CodeMND.Size = new System.Drawing.Size(194, 24);
            this.cmbTBLE_CodeMND.TabIndex = 12;
            // 
            // lblTBLE_CodeTAI
            // 
            this.lblTBLE_CodeTAI.AutoSize = true;
            this.lblTBLE_CodeTAI.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTBLE_CodeTAI.Location = new System.Drawing.Point(430, 187);
            this.lblTBLE_CodeTAI.Margin = new System.Windows.Forms.Padding(0, 7, 3, 0);
            this.lblTBLE_CodeTAI.Name = "lblTBLE_CodeTAI";
            this.lblTBLE_CodeTAI.Size = new System.Drawing.Size(145, 17);
            this.lblTBLE_CodeTAI.TabIndex = 13;
            this.lblTBLE_CodeTAI.Text = "Tipo Afectación IGV";
            this.lblTBLE_CodeTAI.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbTBLE_CodeTAI
            // 
            this.cmbTBLE_CodeTAI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbTBLE_CodeTAI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTBLE_CodeTAI.DropDownWidth = 300;
            this.cmbTBLE_CodeTAI.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTBLE_CodeTAI.FormattingEnabled = true;
            this.cmbTBLE_CodeTAI.Location = new System.Drawing.Point(433, 208);
            this.cmbTBLE_CodeTAI.Name = "cmbTBLE_CodeTAI";
            this.cmbTBLE_CodeTAI.Size = new System.Drawing.Size(194, 24);
            this.cmbTBLE_CodeTAI.TabIndex = 14;
            // 
            // lblSERV_UnitValue
            // 
            this.lblSERV_UnitValue.AutoSize = true;
            this.lblSERV_UnitValue.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERV_UnitValue.Location = new System.Drawing.Point(10, 247);
            this.lblSERV_UnitValue.Margin = new System.Windows.Forms.Padding(0, 7, 3, 0);
            this.lblSERV_UnitValue.Name = "lblSERV_UnitValue";
            this.lblSERV_UnitValue.Size = new System.Drawing.Size(102, 17);
            this.lblSERV_UnitValue.TabIndex = 15;
            this.lblSERV_UnitValue.Text = "Valor Unitario";
            this.lblSERV_UnitValue.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblSERV_UnitPrice
            // 
            this.lblSERV_UnitPrice.AutoSize = true;
            this.lblSERV_UnitPrice.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERV_UnitPrice.Location = new System.Drawing.Point(430, 247);
            this.lblSERV_UnitPrice.Margin = new System.Windows.Forms.Padding(0, 7, 3, 0);
            this.lblSERV_UnitPrice.Name = "lblSERV_UnitPrice";
            this.lblSERV_UnitPrice.Size = new System.Drawing.Size(108, 17);
            this.lblSERV_UnitPrice.TabIndex = 19;
            this.lblSERV_UnitPrice.Text = "Precio Unitario";
            this.lblSERV_UnitPrice.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblSERV_IGV
            // 
            this.lblSERV_IGV.AutoSize = true;
            this.lblSERV_IGV.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSERV_IGV.Location = new System.Drawing.Point(220, 247);
            this.lblSERV_IGV.Margin = new System.Windows.Forms.Padding(0, 7, 3, 0);
            this.lblSERV_IGV.Name = "lblSERV_IGV";
            this.lblSERV_IGV.Size = new System.Drawing.Size(47, 17);
            this.lblSERV_IGV.TabIndex = 17;
            this.lblSERV_IGV.Text = "I.G.V.";
            this.lblSERV_IGV.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txnSERV_UnitValue
            // 
            this.txnSERV_UnitValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txnSERV_UnitValue.Decimals = 0;
            this.txnSERV_UnitValue.Entire = 9;
            this.txnSERV_UnitValue.Format = "###,###,##0.";
            this.txnSERV_UnitValue.Location = new System.Drawing.Point(13, 268);
            this.txnSERV_UnitValue.MaxLength = 10;
            this.txnSERV_UnitValue.Name = "txnSERV_UnitValue";
            this.txnSERV_UnitValue.Negative = true;
            this.txnSERV_UnitValue.NoFormat = false;
            this.txnSERV_UnitValue.Size = new System.Drawing.Size(194, 24);
            this.txnSERV_UnitValue.Standars = VenPy.Controls.FormatStandards.Any;
            this.txnSERV_UnitValue.TabIndex = 16;
            this.txnSERV_UnitValue.Text = "0";
            this.txnSERV_UnitValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txnSERV_UnitValue.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // txnSERV_UnitPrice
            // 
            this.txnSERV_UnitPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txnSERV_UnitPrice.Decimals = 0;
            this.txnSERV_UnitPrice.Entire = 9;
            this.txnSERV_UnitPrice.Format = "###,###,##0.";
            this.txnSERV_UnitPrice.Location = new System.Drawing.Point(433, 268);
            this.txnSERV_UnitPrice.MaxLength = 10;
            this.txnSERV_UnitPrice.Name = "txnSERV_UnitPrice";
            this.txnSERV_UnitPrice.Negative = true;
            this.txnSERV_UnitPrice.NoFormat = false;
            this.txnSERV_UnitPrice.Size = new System.Drawing.Size(194, 24);
            this.txnSERV_UnitPrice.Standars = VenPy.Controls.FormatStandards.Any;
            this.txnSERV_UnitPrice.TabIndex = 20;
            this.txnSERV_UnitPrice.Text = "0";
            this.txnSERV_UnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txnSERV_UnitPrice.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // txnSERV_IGV
            // 
            this.txnSERV_IGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txnSERV_IGV.Decimals = 0;
            this.txnSERV_IGV.Entire = 9;
            this.txnSERV_IGV.Format = "###,###,##0.";
            this.txnSERV_IGV.Location = new System.Drawing.Point(223, 268);
            this.txnSERV_IGV.MaxLength = 10;
            this.txnSERV_IGV.Name = "txnSERV_IGV";
            this.txnSERV_IGV.Negative = true;
            this.txnSERV_IGV.NoFormat = false;
            this.txnSERV_IGV.Size = new System.Drawing.Size(194, 24);
            this.txnSERV_IGV.Standars = VenPy.Controls.FormatStandards.Any;
            this.txnSERV_IGV.TabIndex = 18;
            this.txnSERV_IGV.Text = "0";
            this.txnSERV_IGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txnSERV_IGV.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // MAIN009MView
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(654, 391);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tlpTitle1);
            this.Controls.Add(this.tlpButtons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(670, 430);
            this.Name = "MAIN009MView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SERVICIOS";
            this.tlpButtons.ResumeLayout(false);
            this.tlpTitle1.ResumeLayout(false);
            this.tlpTitle1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel tlpTitle1;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblSERV_Code;
        private System.Windows.Forms.TextBox txtSERV_Code;
        private System.Windows.Forms.Label lblSERV_Name;
        private System.Windows.Forms.TextBox txtSERV_Name;
        private System.Windows.Forms.Label lblSERV_Description;
        private System.Windows.Forms.TextBox txtSERV_Description;
        private System.Windows.Forms.CheckBox chkSERV_Active;
        private System.Windows.Forms.Label lblTBLE_CodeFAS;
        private System.Windows.Forms.ComboBox cmbTBLE_CodeFAS;
        private System.Windows.Forms.Label lblTBLE_CodeUNM;
        private System.Windows.Forms.ComboBox cmbTBLE_CodeUNM;
        private System.Windows.Forms.Label lblTBLE_CodeMND;
        private System.Windows.Forms.ComboBox cmbTBLE_CodeMND;
        private System.Windows.Forms.Label lblTBLE_CodeTAI;
        private System.Windows.Forms.ComboBox cmbTBLE_CodeTAI;
        private System.Windows.Forms.Label lblSERV_UnitValue;
        private System.Windows.Forms.Label lblSERV_UnitPrice;
        private System.Windows.Forms.Label lblSERV_IGV;
        private Controls.TextBoxNumeric txnSERV_UnitValue;
        private Controls.TextBoxNumeric txnSERV_UnitPrice;
        private Controls.TextBoxNumeric txnSERV_IGV;
    }
}