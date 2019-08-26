using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace VenPy.Controls
{
    public partial class CustomGridViewTextBoxNumeric : TextBox
    {
        #region [ VARIABLES ]

        //private Int32 pv_maxlength;
        private Int32 pv_entire;
        private Int32 pv_decimals;
        private Boolean pv_negative;
        private Decimal pv_value;
        private String pv_format;
        private String pv_decimalseparator;
        private String pv_thousandseparator;
        private String pv_groupseparator;
        private String pv_negativesign;
        private NumberFormatInfo pv_formatinfo;

        #endregion

        #region [ PROPERTIES ]

        public override Int32 MaxLength
        {
            get { return base.MaxLength; }
            set
            {
                base.MaxLength = value;
            }
        }
        public override String Text
        {
            get { return base.Text; }
            set
            {
                string l_value = value;
                if (!string.IsNullOrEmpty(l_value))
                {
                    if (!decimal.TryParse(l_value, out pv_value) && string.IsNullOrEmpty(Format))
                    {
                        pv_value = 0;
                        base.Text = l_value;
                    }
                    else { base.Text = pv_value.ToString(Format); }
                }
                else { base.Text = null; }
            }
        }
        public Int32 Entire
        {
            get { return pv_entire; }
            set
            {
                if (pv_entire != value)
                { pv_entire = value; }
            }
        }
        public Int32 Decimals
        {
            get { return pv_decimals; }
            set
            {
                if (pv_decimals != value)
                { pv_decimals = value; }
            }
        }
        public Boolean Negative
        {
            get { return pv_negative; }
            set
            {
                if (pv_negative != value)
                { pv_negative = value; }
            }
        }
        public Decimal Value
        {
            get { return pv_value; }
            set { pv_value = value; }
        }
        public String Format
        {
            get
            {
                pv_format = string.Empty;
                string l_entire = "0";
                string l_decimals = string.Empty;
                for (int i = 0; i < Decimals; i++)
                { l_decimals += "0"; }
                for (int i = 2; i <= Entire; i++)
                {
                    l_entire = "#" + l_entire;
                }
                pv_format = l_entire + pv_decimalseparator + l_decimals;
                return pv_format;
            }
        }

        #endregion

        #region [ CONSTRUCTORS ]

        public CustomGridViewTextBoxNumeric()
        {
            Entire = 20;
            Decimals = 8;
            pv_formatinfo = CultureInfo.CurrentCulture.NumberFormat;
            pv_decimalseparator = pv_formatinfo.NumberDecimalSeparator;
            pv_thousandseparator = pv_formatinfo.NumberDecimalSeparator;
            pv_groupseparator = pv_formatinfo.NumberGroupSeparator;
            pv_negativesign = pv_formatinfo.NegativeSign;
            TextAlign = HorizontalAlignment.Right;
            InitializeComponent();
        }

        #endregion

        #region [ METHODS ]

        protected override bool ProcessCmdKey(ref Message p_Message, Keys p_Keys)
        {
            const int WM_KEYDOWN = 256;
            const int WM_SYSKEYDOWN = 260;
            if ((p_Message.Msg == WM_KEYDOWN) || (p_Message.Msg == WM_SYSKEYDOWN))
            {
                switch (p_Keys)
                {
                    case Keys.Tab:
                        KeyEventArgs e = new KeyEventArgs(Keys.Tab);
                        p_Keys = Keys.A;
                        base.OnKeyDown(e);
                        break;
                }
            }
            return base.ProcessCmdKey(ref p_Message, p_Keys);
        }
        protected void ValidateKeyPress(KeyPressEventArgs e)
        {
            string l_keyInput = e.KeyChar.ToString();
            /*Si presiono Backspace deja borrar de todas formas*/
            if ((int)e.KeyChar == (int)Keys.Back) { e.Handled = false; return; }
            /*Si es signo negativo y ya hay uno entonces no deja*/
            if ((l_keyInput.Equals(pv_negativesign)) && (this.Text.IndexOf(pv_negativesign) != -1)) { e.Handled = true; return; }
            /*Si es negativo y no esta al comienzo no deja*/
            if ((l_keyInput.Equals(pv_negativesign)) && (this.SelectionStart > 0)) { e.Handled = true; return; }
            /*Si es punto y/o coma decimal*/
            if (l_keyInput.Equals(pv_decimalseparator))
            {
                /*Si todo el texto esta seleccionado limpiar y colocar el separador*/
                if (this.Text == this.SelectedText) { base.Text = l_keyInput; base.SelectionStart = base.Text.Length; }
                /*Si ya existe punto no deja*/
                if (this.Text.IndexOf(pv_decimalseparator) != -1) { e.Handled = true; return; }
                /*Si ha sido configurado sin decimales tampoco deja*/
                if (pv_decimals == 0) { e.Handled = true; return; }
            }
            if (char.IsDigit(e.KeyChar))
            {
                if (this.Text == this.SelectedText) { base.Text = l_keyInput; base.SelectionStart = base.Text.Length; e.Handled = true; }
            }
            /*Si es un numero*/
            if (char.IsDigit(e.KeyChar))
            {
                /*Si no hay un punto y/o coma decimal*/
                if (this.Text.IndexOf(pv_decimalseparator) == -1)
                {
                    /*Si longitud de numeros ingresados es mayor a la de numeros de enteros no deja*/
                    if (LenghtOnlyNumbers(this.Text) + 1 > pv_entire) { e.Handled = true; return; }
                }
                else /*Si hay un punto y/o coma decimal*/
                {
                    string[] aParts = this.Text.Split(pv_decimalseparator[0]);
                    /*Si estamos ingresando numeros antes del punto*/
                    if (this.SelectionStart < this.Text.IndexOf(pv_decimalseparator))
                    {
                        /*Si longitud de numeros + 1 es mayor a la de numeros de enteros no deja*/
                        if (LenghtOnlyNumbers(aParts[aParts.GetLowerBound(0)]) + 1 > pv_entire) { e.Handled = true; return; }
                    }
                    /*Si estamos ingresando numeros despues del punto*/
                    if (this.SelectionStart > this.Text.IndexOf(pv_decimalseparator))
                    {
                        /*Si longitud de numeros + 1 es mayor es mayor a la de numeros de enteros no deja*/
                        if (LenghtOnlyNumbers(aParts[aParts.GetUpperBound(0)]) + 1 > pv_decimals) { e.Handled = true; return; }
                    }
                }
            }
            else if (l_keyInput.Equals(pv_decimalseparator) || l_keyInput.Equals(pv_negativesign))
            {
                /*Punto y/o coma decimal, Signo negativo, Caracter de miles es correcto*/
                if (l_keyInput.Equals(pv_negativesign))
                {if (!pv_negative) { e.Handled = true; return; }}
            }
            else
            {
                /*Clave invalida*/
                e.Handled = true;
            }
        }
        protected void ClearBase()
        {
            base.Text = null;
        }
        private Int32 LenghtOnlyNumbers(String p_Number)
        {
            char[] l_chars = p_Number.ToCharArray(0, p_Number.Length);
            int l_len = 0;
            for (int i = l_chars.GetLowerBound(0); i <= l_chars.GetUpperBound(0); i++)
            {
                if ("0123456789".IndexOf(l_chars[i]) != -1)
                { l_len += 1; }
            }
            return l_len;
        }
        private String FormatText(String p_Number)
        {
            decimal l_numberFormat = 0;
            if (p_Number.Trim().Length == 0) { l_numberFormat = 0; }
            else if (string.IsNullOrEmpty(p_Number)) { l_numberFormat = 0; }
            else
            {
                try
                {
                    if (p_Number != null)
                    {
                        if (!decimal.TryParse(p_Number, out l_numberFormat))
                        { l_numberFormat = 0; }
                    }
                }
                catch (Exception ex)
                { throw new Exception("Error al convertir la cadena de Texto : '" + p_Number + "' a numérico" + ex.Message, ex); }
            }
            Value = l_numberFormat;
            return l_numberFormat.ToString(pv_format);
        }

        #endregion

        #region [ EVENTS ]

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
        }
        protected override void OnLostFocus(EventArgs e)
        {
            base.Text = FormatText(base.Text);
            base.OnLostFocus(e);
        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            ValidateKeyPress(e);
            base.OnKeyPress(e);
            string _texto_actual = base.Text;
        }
        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
        }

        #endregion
    }
}
