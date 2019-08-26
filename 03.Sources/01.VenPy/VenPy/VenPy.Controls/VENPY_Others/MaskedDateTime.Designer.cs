namespace VenPy.Controls
{
    partial class MaskedDateTime
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.mtbMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // dtpDateTimePicker
            // 
            this.dtpDateTimePicker.Dock = System.Windows.Forms.DockStyle.Right;
            this.dtpDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTimePicker.Location = new System.Drawing.Point(91, 0);
            this.dtpDateTimePicker.Name = "dtpDateTimePicker";
            this.dtpDateTimePicker.Size = new System.Drawing.Size(17, 24);
            this.dtpDateTimePicker.TabIndex = 0;
            // 
            // mtbMaskedTextBox
            // 
            this.mtbMaskedTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtbMaskedTextBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbMaskedTextBox.Location = new System.Drawing.Point(0, 0);
            this.mtbMaskedTextBox.Mask = "00/00/00";
            this.mtbMaskedTextBox.MinimumSize = new System.Drawing.Size(93, 20);
            this.mtbMaskedTextBox.Name = "mtbMaskedTextBox";
            this.mtbMaskedTextBox.Size = new System.Drawing.Size(93, 24);
            this.mtbMaskedTextBox.TabIndex = 2;
            // 
            // MaskedDateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtbMaskedTextBox);
            this.Controls.Add(this.dtpDateTimePicker);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MaskedDateTime";
            this.Size = new System.Drawing.Size(108, 23);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDateTimePicker;
        private System.Windows.Forms.MaskedTextBox mtbMaskedTextBox;
    }
}
