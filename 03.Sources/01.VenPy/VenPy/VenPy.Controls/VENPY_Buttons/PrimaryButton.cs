using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VenPy.Controls
{
    public partial class PrimaryButton : Button
    {
        #region [ VARIABLES ]

        /// <summary>
        /// Variable ToolTip 
        /// </summary>
        private String pv_toolTip;

        #endregion

        #region [ PROPERTIES ]

        /// <summary>
        /// Property ToolTip
        /// </summary>
        public String ToolTip
        {
            get { return pv_toolTip; }
            set
            {
                if (pv_toolTip != value)
                {
                    pv_toolTip = value;
                    ToolTip L_toolTip = new ToolTip();
                    L_toolTip.SetToolTip(this, pv_toolTip);
                }
            }
        }

        #endregion

        #region [ BUILDERS ]

        /// <summary>
        /// Custom Control Builder PrimaryButton
        /// </summary>
        public PrimaryButton()
        {
            InitializeComponent();
            AutoSize = true;
            BackColor = Color.FromArgb(55, 72, 80);
            Dock = DockStyle.Fill;
            FlatAppearance.BorderSize = 2;
            FlatAppearance.BorderColor = Color.FromArgb(131, 134, 136);
            FlatStyle = FlatStyle.Flat;
            Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            ForeColor = Color.White;
            Margin = new Padding(0);
            ImageAlign = ContentAlignment.MiddleLeft;
            TextAlign = ContentAlignment.MiddleRight;
            Text = "PrimaryButton";
            UseVisualStyleBackColor = false;
            MouseEnter += new EventHandler(PrimaryButton_MouseEnter);
            MouseLeave += new EventHandler(PrimaryButton_MouseLeave);
        }

        #endregion

        #region [ EVENTS ]

        /// <summary>
        /// Event when removing the button pointer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrimaryButton_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(55, 72, 80);
            FlatAppearance.BorderColor = Color.FromArgb(131, 134, 136);
            ForeColor = Color.White;
        }
        /// <summary>
        /// Event when putting the pointer on the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrimaryButton_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(131, 134, 136);
            FlatAppearance.BorderColor = Color.FromArgb(55, 72, 80);
            ForeColor = Color.White;
        }

        #endregion
    }
}
