namespace VenPy.Main
{
    partial class MAIN011MView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAIN011MView));
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tlpTitle1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSEND = new System.Windows.Forms.Label();
            this.lblSIGV = new System.Windows.Forms.Label();
            this.txnSIGV = new VenPy.Controls.TextBoxNumeric();
            this.chkSALI = new System.Windows.Forms.CheckBox();
            this.htxSEND = new VenPy.Controls.HelpEntity();
            this.chkSTCO = new System.Windows.Forms.CheckBox();
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
            this.tlpButtons.Location = new System.Drawing.Point(0, 331);
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
            this.lblTitle1.Text = "Ajustes Generales";
            this.lblTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.AutoScrollMinSize = new System.Drawing.Size(630, 295);
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.Controls.Add(this.lblSEND, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSIGV, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.txnSIGV, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.htxSEND, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.chkSALI, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.chkSTCO, 5, 1);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(654, 301);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblSEND
            // 
            this.lblSEND.AutoSize = true;
            this.lblSEND.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSEND.Location = new System.Drawing.Point(10, 7);
            this.lblSEND.Margin = new System.Windows.Forms.Padding(0, 7, 3, 0);
            this.lblSEND.Name = "lblSEND";
            this.lblSEND.Size = new System.Drawing.Size(136, 17);
            this.lblSEND.TabIndex = 0;
            this.lblSEND.Text = "Entidad Desconocida";
            this.lblSEND.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblSIGV
            // 
            this.lblSIGV.AutoSize = true;
            this.lblSIGV.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSIGV.Location = new System.Drawing.Point(220, 7);
            this.lblSIGV.Margin = new System.Windows.Forms.Padding(0, 7, 3, 0);
            this.lblSIGV.Name = "lblSIGV";
            this.lblSIGV.Size = new System.Drawing.Size(106, 17);
            this.lblSIGV.TabIndex = 2;
            this.lblSIGV.Text = "Porcenaje I.G.V.";
            this.lblSIGV.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txnSIGV
            // 
            this.txnSIGV.Decimals = 2;
            this.txnSIGV.Entire = 3;
            this.txnSIGV.Format = "##0.00";
            this.txnSIGV.Location = new System.Drawing.Point(223, 28);
            this.txnSIGV.MaxLength = 6;
            this.txnSIGV.Name = "txnSIGV";
            this.txnSIGV.Negative = false;
            this.txnSIGV.NoFormat = false;
            this.txnSIGV.Size = new System.Drawing.Size(194, 24);
            this.txnSIGV.Standars = VenPy.Controls.FormatStandards.Percent;
            this.txnSIGV.TabIndex = 3;
            this.txnSIGV.Text = "0.00";
            this.txnSIGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txnSIGV.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // chkSALI
            // 
            this.chkSALI.AutoSize = true;
            this.chkSALI.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSALI.Location = new System.Drawing.Point(433, 3);
            this.chkSALI.Name = "chkSALI";
            this.chkSALI.Size = new System.Drawing.Size(121, 19);
            this.chkSALI.TabIndex = 4;
            this.chkSALI.Text = "Actualizar Listas";
            this.chkSALI.UseVisualStyleBackColor = true;
            // 
            // htxSEND
            // 
            this.htxSEND.AcceptedLength = 0;
            this.htxSEND.BusinessCode = 0;
            this.htxSEND.EnableHelpButton = true;
            this.htxSEND.EntityType = 0;
            this.htxSEND.FillZeros = false;
            this.htxSEND.Location = new System.Drawing.Point(13, 28);
            this.htxSEND.MaxLength = 20;
            this.htxSEND.MyInstanceHelp = VenPy.Controls.HelpEntity.InstanceHelp.Enable;
            this.htxSEND.MyTypeFiler = VenPy.Controls.HelpEntity.TypeFilter.DocumentNumber;
            this.htxSEND.Name = "htxSEND";
            this.htxSEND.Size = new System.Drawing.Size(194, 24);
            this.htxSEND.TabIndex = 1;
            this.htxSEND.Type = VenPy.Controls.HelpEntity.TypeTextBoxHelp.Alphanumeric;
            this.htxSEND.UseEntityType = true;
            this.htxSEND.Value = null;
            // 
            // chkSTCO
            // 
            this.chkSTCO.AutoSize = true;
            this.chkSTCO.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSTCO.Location = new System.Drawing.Point(433, 28);
            this.chkSTCO.Name = "chkSTCO";
            this.chkSTCO.Size = new System.Drawing.Size(90, 21);
            this.chkSTCO.TabIndex = 4;
            this.chkSTCO.Text = "T.C. Oficial";
            this.chkSTCO.UseVisualStyleBackColor = true;
            // 
            // MAIN011MView
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(654, 381);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tlpTitle1);
            this.Controls.Add(this.tlpButtons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(670, 420);
            this.Name = "MAIN011MView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AJUSTES";
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
        private System.Windows.Forms.Label lblSIGV;
        private System.Windows.Forms.Label lblSEND;
        private Controls.TextBoxNumeric txnSIGV;
        private System.Windows.Forms.CheckBox chkSALI;
        private Controls.HelpEntity htxSEND;
        private System.Windows.Forms.CheckBox chkSTCO;
    }
}