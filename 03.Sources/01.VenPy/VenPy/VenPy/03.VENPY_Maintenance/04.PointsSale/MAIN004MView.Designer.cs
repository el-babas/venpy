namespace VenPy.Main
{
    partial class MAIN004MView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAIN004MView));
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tlpTitle1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPSAL_Code = new System.Windows.Forms.Label();
            this.txtPSAL_Code = new System.Windows.Forms.TextBox();
            this.lblPSAL_Name = new System.Windows.Forms.Label();
            this.txtPSAL_Name = new System.Windows.Forms.TextBox();
            this.lblPSAL_Status = new System.Windows.Forms.Label();
            this.cmbPSAL_Status = new System.Windows.Forms.ComboBox();
            this.chkPSAL_Main = new System.Windows.Forms.CheckBox();
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
            this.tlpButtons.Location = new System.Drawing.Point(0, 161);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 3;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlpButtons.Size = new System.Drawing.Size(654, 50);
            this.tlpButtons.TabIndex = 1;
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
            this.tlpTitle1.TabIndex = 8;
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
            this.tableLayoutPanel2.AutoScrollMinSize = new System.Drawing.Size(630, 125);
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.Controls.Add(this.lblPSAL_Code, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtPSAL_Code, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblPSAL_Name, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtPSAL_Name, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblPSAL_Status, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbPSAL_Status, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.chkPSAL_Main, 5, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(654, 131);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblPSAL_Code
            // 
            this.lblPSAL_Code.AutoSize = true;
            this.lblPSAL_Code.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSAL_Code.Location = new System.Drawing.Point(10, 7);
            this.lblPSAL_Code.Margin = new System.Windows.Forms.Padding(0, 7, 3, 0);
            this.lblPSAL_Code.Name = "lblPSAL_Code";
            this.lblPSAL_Code.Size = new System.Drawing.Size(57, 17);
            this.lblPSAL_Code.TabIndex = 0;
            this.lblPSAL_Code.Text = "Codigo";
            this.lblPSAL_Code.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtPSAL_Code
            // 
            this.txtPSAL_Code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPSAL_Code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPSAL_Code.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPSAL_Code.ForeColor = System.Drawing.Color.Black;
            this.txtPSAL_Code.Location = new System.Drawing.Point(13, 28);
            this.txtPSAL_Code.MaxLength = 20;
            this.txtPSAL_Code.Name = "txtPSAL_Code";
            this.txtPSAL_Code.ReadOnly = true;
            this.txtPSAL_Code.Size = new System.Drawing.Size(194, 24);
            this.txtPSAL_Code.TabIndex = 1;
            this.txtPSAL_Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPSAL_Name
            // 
            this.lblPSAL_Name.AutoSize = true;
            this.lblPSAL_Name.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSAL_Name.Location = new System.Drawing.Point(10, 67);
            this.lblPSAL_Name.Margin = new System.Windows.Forms.Padding(0, 7, 3, 0);
            this.lblPSAL_Name.Name = "lblPSAL_Name";
            this.lblPSAL_Name.Size = new System.Drawing.Size(64, 17);
            this.lblPSAL_Name.TabIndex = 5;
            this.lblPSAL_Name.Text = "Nombre";
            this.lblPSAL_Name.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtPSAL_Name
            // 
            this.txtPSAL_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPSAL_Name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel2.SetColumnSpan(this.txtPSAL_Name, 5);
            this.txtPSAL_Name.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPSAL_Name.ForeColor = System.Drawing.Color.Black;
            this.txtPSAL_Name.Location = new System.Drawing.Point(13, 88);
            this.txtPSAL_Name.MaxLength = 100;
            this.txtPSAL_Name.Name = "txtPSAL_Name";
            this.txtPSAL_Name.Size = new System.Drawing.Size(614, 24);
            this.txtPSAL_Name.TabIndex = 6;
            // 
            // lblPSAL_Status
            // 
            this.lblPSAL_Status.AutoSize = true;
            this.lblPSAL_Status.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSAL_Status.Location = new System.Drawing.Point(220, 7);
            this.lblPSAL_Status.Margin = new System.Windows.Forms.Padding(0, 7, 3, 0);
            this.lblPSAL_Status.Name = "lblPSAL_Status";
            this.lblPSAL_Status.Size = new System.Drawing.Size(56, 17);
            this.lblPSAL_Status.TabIndex = 2;
            this.lblPSAL_Status.Text = "Estado";
            this.lblPSAL_Status.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbPSAL_Status
            // 
            this.cmbPSAL_Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbPSAL_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPSAL_Status.DropDownWidth = 300;
            this.cmbPSAL_Status.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPSAL_Status.FormattingEnabled = true;
            this.cmbPSAL_Status.Location = new System.Drawing.Point(223, 28);
            this.cmbPSAL_Status.Name = "cmbPSAL_Status";
            this.cmbPSAL_Status.Size = new System.Drawing.Size(194, 24);
            this.cmbPSAL_Status.TabIndex = 3;
            // 
            // chkPSAL_Main
            // 
            this.chkPSAL_Main.AutoSize = true;
            this.chkPSAL_Main.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkPSAL_Main.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPSAL_Main.Location = new System.Drawing.Point(433, 28);
            this.chkPSAL_Main.Name = "chkPSAL_Main";
            this.chkPSAL_Main.Size = new System.Drawing.Size(84, 21);
            this.chkPSAL_Main.TabIndex = 4;
            this.chkPSAL_Main.Text = "Principal";
            this.chkPSAL_Main.UseVisualStyleBackColor = true;
            // 
            // MAIN004MView
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(654, 211);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tlpTitle1);
            this.Controls.Add(this.tlpButtons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(670, 250);
            this.Name = "MAIN004MView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PUNTOS DE VENTA";
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
        private System.Windows.Forms.Label lblPSAL_Code;
        private System.Windows.Forms.TextBox txtPSAL_Code;
        private System.Windows.Forms.Label lblPSAL_Name;
        private System.Windows.Forms.TextBox txtPSAL_Name;
        private System.Windows.Forms.Label lblPSAL_Status;
        private System.Windows.Forms.ComboBox cmbPSAL_Status;
        private System.Windows.Forms.CheckBox chkPSAL_Main;
    }
}