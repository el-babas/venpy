using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace VenPy.Controls
{
    public partial class TextBoxNumeric : TextBox
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
        private FormatStandards pv_standars;
        private IContainer pv_components = null;

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
                    else
                    {
                        if (NoFormat)
                        { base.Text = pv_value.ToString(); }
                        else
                        { base.Text = pv_value.ToString(this.Format); }
                    }
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
                {
                    pv_entire = value;
                    UpdateValues();
                }
            }
        }
        public Int32 Decimals
        {
            get { return pv_decimals; }
            set
            {
                if (pv_decimals != value)
                {
                    pv_decimals = value;
                    UpdateValues();
                    UpdateDecimalFormat();
                }
            }
        }
        public Decimal Value
        {
            get { return pv_value; }
            set
            {
                pv_value = value;
                if (!string.IsNullOrEmpty(Format))
                { this.Text = value.ToString(Format); }
                else
                { this.Text = value.ToString(); }
                ValueChanged?.Invoke(pv_value, EventArgs.Empty);
            }
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
                    if ((l_entire.Replace(pv_groupseparator, "").ToString().Length % 3) == 0 && i != Entire)
                    { l_entire = pv_groupseparator + l_entire; }
                }
                pv_format = l_entire + pv_decimalseparator + l_decimals;
                return pv_format;
            }
            set { pv_format = value; }
        }
        public Boolean Negative
        {
            get { return pv_negative; }
            set
            {
                if (pv_negative != value)
                {
                    pv_negative = value;
                    UpdateValues();
                }
            }
        }
        public Boolean NoFormat { get; set; }
        public FormatStandards Standars
        {
            get { return pv_standars; }
            set
            {
                pv_standars = value;
                switch (pv_standars)
                {
                    case FormatStandards.Any:
                        Entire = 9;
                        Decimals = 0;
                        Format = "########0";
                        base.Text = "0";
                        base.MaxLength = (pv_negative) ? 1 : 0;
                        base.MaxLength = base.MaxLength + pv_entire;
                        break;
                    case FormatStandards.General:
                        Entire = 9;
                        Decimals = 0;
                        Format = "########0";
                        base.Text = "0";
                        base.MaxLength = (pv_negative) ? 1 : 0;
                        base.MaxLength = base.MaxLength + pv_entire;
                        break;
                    case FormatStandards.Decimal:
                        Entire = 9;
                        Decimals = 2;
                        Format = "########0.00";
                        base.Text = string.Format("0{0}00", pv_decimalseparator);
                        base.MaxLength = (pv_negative) ? 1 : 0;
                        base.MaxLength = base.MaxLength + pv_entire + 1 + pv_decimals;
                        break;
                    case FormatStandards.Money:
                        Entire = 9;
                        Decimals = 2;
                        Format = "########0.00";
                        base.Text = string.Format("0{0}00", pv_decimalseparator);
                        base.MaxLength = (pv_negative) ? 1 : 0;
                        base.MaxLength = base.MaxLength + pv_entire + 1 + pv_decimals;
                        break;
                    case FormatStandards.Percent:
                        Entire = 3;
                        Decimals = 2;
                        Format = "##0.00";
                        base.Text = "0.00";
                        base.MaxLength = (pv_negative) ? 1 : 0;
                        base.MaxLength = base.MaxLength + pv_entire + 1 + pv_decimals;
                        break;
                }
            }
        }

        #endregion

        #region [ CONSTRUCTORS ]

        public TextBoxNumeric()
        {
            pv_formatinfo = CultureInfo.CurrentCulture.NumberFormat;
            pv_decimalseparator = pv_formatinfo.NumberDecimalSeparator;
            pv_thousandseparator = pv_formatinfo.NumberDecimalSeparator;
            pv_groupseparator = pv_formatinfo.NumberGroupSeparator;
            pv_negativesign = pv_formatinfo.NegativeSign;
            this.DefaultValues();
            base.TextAlign = HorizontalAlignment.Right;
            InitializeComponent();
        }

        #endregion

        #region [ METHODS ]

        private void InitializeComponent()
        {
            pv_components = new Container();
        }
        protected override void Dispose(bool p_Disposing)
        {
            if (p_Disposing && (pv_components != null))
            {
                pv_components.Dispose();
            }
            base.Dispose(p_Disposing);
        }
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
            if (!this.ReadOnly)
            {
                string l_keyInput = e.KeyChar.ToString();
                /*Si presiono Backspace deja borrar de todas formas*/
                if ((int)e.KeyChar == (int)Keys.Back) { e.Handled = false; return; }
                /*Si es signo negativo y ya hay uno entonces no deja*/
                if ((l_keyInput.Equals(pv_negativesign)) && (Text.IndexOf(pv_negativesign) != -1)) { e.Handled = true; return; }
                /*Si es negativo y no esta al comienzo no deja*/
                if ((l_keyInput.Equals(pv_negativesign)) && (SelectionStart > 0)) { e.Handled = true; return; }
                /*Si es punto y/o coma decimal*/
                if (l_keyInput.Equals(pv_decimalseparator))
                {
                    if (Decimals <= 0) { e.Handled = true; return; }
                    else
                    {
                        /*Si todo el texto esta seleccionado limpiar y colocar el separador*/
                        if (Text == SelectedText) { base.Text = l_keyInput; base.SelectionStart = base.Text.Length; }
                        /*Si ya existe punto no deja*/
                        if (Text.IndexOf(pv_decimalseparator) != -1) { e.Handled = true; return; }
                        /*Si ha sido configurado sin decimales tampoco deja*/
                        if (pv_decimals == 0) { e.Handled = true; return; }
                    }
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
                else if (l_keyInput.Equals(pv_decimalseparator) || l_keyInput.Equals(pv_groupseparator) || l_keyInput.Equals(pv_negativesign))
                {
                    /*Punto y/o coma decimal, Signo negativo, Caracter de miles es correcto*/
                    if (l_keyInput.Equals(pv_negativesign))
                    { if (!pv_negative) { e.Handled = true; return; } }
                }
                else
                {
                    /*Clave invalida*/
                    e.Handled = true;
                }
            }
            else
            {
                /*Clave invalida*/
                e.Handled = true;
            }
        }
        protected void UpdateDecimalFormat()
        {
            switch (Decimals)
            {
                case 0:
                    base.Text = "0";
                    break;
                case 1:
                    base.Text = String.Format("0{0}0", pv_decimalseparator);
                    break;
                case 2:
                    base.Text = String.Format("0{0}00", pv_decimalseparator);
                    break;
                case 3:
                    base.Text = String.Format("0{0}000", pv_decimalseparator);
                    break;
                case 4:
                    base.Text = String.Format("0{0}0000", pv_decimalseparator);
                    break;
                case 5:
                    base.Text = String.Format("0{0}00000", pv_decimalseparator);
                    break;
                case 6:
                    base.Text = String.Format("0{0}000000", pv_decimalseparator);
                    break;
                case 7:
                    base.Text = String.Format("0{0}0000000", pv_decimalseparator);
                    break;
            }
        }
        protected void UpdateValues()
        {
            switch (this.Standars)
            {
                case FormatStandards.Any:
                    base.Text = "0";
                    base.MaxLength = (Negative) ? 1 : 0;
                    base.MaxLength = base.MaxLength + Entire;
                    break;
                case FormatStandards.General:
                    base.Text = "0";
                    base.MaxLength = (Negative) ? 1 : 0;
                    base.MaxLength = base.MaxLength + Entire;
                    break;
                case FormatStandards.Decimal:
                    base.Text = "0.00";
                    base.MaxLength = (Negative) ? 1 : 0;
                    base.MaxLength = base.MaxLength + Entire + 1 + Decimals;
                    break;
                case FormatStandards.Money:
                    base.Text = "0.00";
                    base.MaxLength = (Negative) ? 1 : 0;
                    base.MaxLength = base.MaxLength + Entire + 1 + Decimals;
                    break;
                case FormatStandards.Percent:
                    base.Text = "0.00";
                    base.MaxLength = (Negative) ? 1 : 0;
                    base.MaxLength = base.MaxLength + Entire + 1 + Decimals;
                    break;
            }
        }
        protected void DefaultValues()
        {
            pv_negative = true;
            pv_decimals = 2;
            pv_entire = 9;
            pv_format = "#######0.00";
            base.MaxLength = (pv_negative) ? 1 : 0;
            base.MaxLength = base.MaxLength + pv_entire + 1 + pv_decimals;
            NoFormat = false;
        }
        protected void SetClear()
        {
            switch (pv_standars)
            {
                case FormatStandards.Any:
                    base.Text = "0";
                    break;
                case FormatStandards.General:
                    base.Text = "0";
                    break;
                case FormatStandards.Decimal:
                    base.Text = "0.00";
                    break;
                case FormatStandards.Money:
                    base.Text = "0.00";
                    break;
                case FormatStandards.Percent:
                    base.Text = "0.00";
                    break;
            }
        }
        protected void ClearBase()
        {
            base.Text = null;
        }
        private int LenghtOnlyNumbers(string p_Number)
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
        private string FormatText(string p_Number)
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
            if (NoFormat)
            { return l_numberFormat.ToString(); }
            else
            { return l_numberFormat.ToString(this.Format); }
        }
        public void init()
        {
            SetClear();
        }
        public new void Clear()
        {
            SetClear();
        }

        #endregion

        #region [ Eventos ]

        public event EventHandler ValueChanged;
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

    public enum FormatStandards
    {
        Any = 0,
        General = 1,
        Decimal = 2,
        Money = 3,
        Percent = 4
    }
}
