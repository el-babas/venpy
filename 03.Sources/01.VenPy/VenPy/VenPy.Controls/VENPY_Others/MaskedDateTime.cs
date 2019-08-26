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
    public enum CustomDateFormat
    {
        Date,
        Hour,
        DateTime
    }
    public partial class MaskedDateTime : UserControl
    {
        #region [ VARIABLES ]

        private int pv_digitsYear;
        private int pv_index;
        private bool pv_esc = false;
        private bool pv_currentDate = false;
        private bool pv_activateCursor = false;
        private bool pv_incorrectDate = false;
        private bool pv_day;
        private bool pv_month;
        private bool pv_changeDate;
        private bool pv_setDate;
        private string pv_title = "Fecha";
        private string pv_dateSeparator;
        private string pv_hourSeparator;
        private CustomDateFormat pv_customDateFormat;

        #endregion

        #region [ PROPERTIES ]

        public bool MDTActivateCursor
        {
            get { return pv_activateCursor; }
            set { pv_activateCursor = value; }
        }
        public bool MDTIncorrectDate
        {
            get { return pv_incorrectDate; }
            set { pv_incorrectDate = value; }
        }
        public bool MDTChangeDate
        {
            get { return pv_changeDate; }
            set { pv_changeDate = value; }
        }
        public bool MDTMonth
        {
            get { return pv_month; }
        }
        public bool MDTDay
        {
            get { return pv_day; }
        }
        public bool MDTCurrentDate
        {
            get { return pv_currentDate; }
            set
            {
                pv_currentDate = value;
                if (value)
                {
                    MDTMaskedTextBox.Text = Fill(DateTime.Now.Day.ToString(), 2) + Fill(DateTime.Now.Month.ToString(), 2) + DateTime.Now.Year.ToString();
                    pv_day = true;
                    pv_month = true;
                }
                else
                {
                    MDTMaskedTextBox.Text = "";
                    pv_day = false;
                    pv_month = false;
                }
            }
        }
        public int MDTDigitsYear
        {
            get { return pv_digitsYear; }
            set
            {
                pv_digitsYear = value;
                string l_valor = "";
                mtbMaskedTextBox.Mask = "00" + pv_dateSeparator + "00" + pv_dateSeparator + Fill(l_valor, pv_digitsYear);
            }
        }
        public MaskedTextBox MDTMaskedTextBox
        {
            get { return mtbMaskedTextBox; }
            set { mtbMaskedTextBox = value; }
        }
        public DateTimePicker MDTDateTimePicke
        {
            get { return dtpDateTimePicker; }
            set { dtpDateTimePicker = value; }
        }
        public Nullable<DateTime> MDTDate
        {
            get
            {
                DateTime l_fecha;
                if (DateTime.TryParse(mtbMaskedTextBox.Text, out l_fecha))
                { return l_fecha; }
                else
                { return null; }
            }
            set
            {
                if (value.HasValue)
                {
                    pv_setDate = true;
                    if (value.Value > dtpDateTimePicker.MaxDate)
                    { dtpDateTimePicker.Value = dtpDateTimePicker.MaxDate; }
                    else
                    { dtpDateTimePicker.Value = value.Value; }
                    switch (MDTFormat)
                    {
                        case CustomDateFormat.Date:
                            pv_setDate = true;
                            SetDate();
                            break;
                        case CustomDateFormat.DateTime:
                            pv_setDate = true;
                            SetDateTime();
                            break;
                        case CustomDateFormat.Hour:
                            pv_setDate = true;
                            SetHour();
                            break;
                    }
                }
                else
                {
                    dtpDateTimePicker.Value = DateTime.Now;
                    mtbMaskedTextBox.Text = "";
                }
                SelectedDateChanged?.Invoke(null, EventArgs.Empty);
            }
        }
        public CustomDateFormat MDTFormat
        {
            get { return pv_customDateFormat; }
            set
            {
                pv_customDateFormat = value;
                switch (value)
                {
                    case CustomDateFormat.Date:
                        mtbMaskedTextBox.Mask = "00/00/0000";
                        dtpDateTimePicker.Visible = true;
                        break;
                    case CustomDateFormat.Hour:
                        mtbMaskedTextBox.Mask = "00:00";
                        dtpDateTimePicker.Visible = false;
                        break;
                    case CustomDateFormat.DateTime:
                        mtbMaskedTextBox.Mask = "00/00/0000 00:00";
                        dtpDateTimePicker.Visible = true;
                        break;
                }
            }
        }

        #endregion

        #region [ CONSTRUCTORS ]

        public MaskedDateTime()
        {
            InitializeComponent();
            GotFocus += new EventHandler(MaskedDateTime_GotFocus);
            dtpDateTimePicker.CloseUp += new EventHandler(DtpDateTimePicker_CloseUp);
            dtpDateTimePicker.PreviewKeyDown += new PreviewKeyDownEventHandler(DtpDateTimePicker_PreviewKeyDown);
            dtpDateTimePicker.LostFocus += new EventHandler(DtpDateTimePicker_LostFocus);
            dtpDateTimePicker.ValueChanged += new EventHandler(DtpDateTimePicker_ValueChanged);
            dtpDateTimePicker.MouseEnter += new EventHandler(DtpDateTimePicker_MouseEnter);
            dtpDateTimePicker.DropDown += new EventHandler(DtpDateTimePicker_DropDown);
            mtbMaskedTextBox.LostFocus += new EventHandler(MtbMaskedTextBox_lostFocus);
            mtbMaskedTextBox.TextChanged += new EventHandler(MtbMaskedTextBox_TextChanged);
            mtbMaskedTextBox.KeyPress += new KeyPressEventHandler(MtbMaskedTextBox_KeyPress);
            pv_customDateFormat = CustomDateFormat.Date;
            pv_dateSeparator = CultureInfo.CurrentCulture.DateTimeFormat.DateSeparator.ToString();
            pv_hourSeparator = CultureInfo.CurrentCulture.DateTimeFormat.TimeSeparator.ToString();
            pv_digitsYear = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern.ToString().Split(pv_dateSeparator[0])[2].ToString().Trim().Length;
            pv_index = 2;
            pv_incorrectDate = false;
            pv_changeDate = false;
        }

        #endregion

        #region [ METHODS ]

        public void FocusControl()
        {
            dtpDateTimePicker.Focus();
        }
        public void SetNewDate()
        {
            try
            {
                dtpDateTimePicker.ValueChanged -= DtpDateTimePicker_ValueChanged;
                dtpDateTimePicker.ValueChanged += DtpDateTimePicker_ValueChanged;
            }
            catch (Exception ex)
            { Messages.ShowErrorMessage(pv_title, "No se puede cambiar la fecha", ex); }
        }
        public void ValidateDate()
        {
            string l_message = string.Empty;
            if (!CorrectDate(mtbMaskedTextBox.Text))
            {
                if (mtbMaskedTextBox.Text.Length < 3)
                {
                    Validate(mtbMaskedTextBox.Text);
                    if (!pv_day) { l_message += "- Dia Incorrecto \n"; }
                    if (!pv_month) { l_message += "- Mes Incorrecto \n"; }
                    if (pv_incorrectDate)
                    { Messages.ShowInformationMessage(pv_title, "Fecha Incorrecta: \n" + l_message); }
                }
                else
                {
                    pv_day = pv_month = false;
                    if (pv_incorrectDate)
                    { Messages.ShowInformationMessage(pv_title, "Fecha Incorrecta."); }
                    if (MDTChangeDate)
                    { SelectedDateChanged?.Invoke(null, EventArgs.Empty); }
                }
            }
            else
            { pv_day = pv_month = true; }
        }
        public void ValidateHour()
        {
            if (!CorrectDate(mtbMaskedTextBox.Text))
            {
                mtbMaskedTextBox.ResetText();
                Messages.ShowInformationMessage(pv_title, "Hora Incorrecta.");
            }
        }
        public void ValidateDateTime()
        {
            if (!CorrectDate(mtbMaskedTextBox.Text))
            {
                mtbMaskedTextBox.ResetText();
                Messages.ShowInformationMessage(pv_title, "Fecha y Hora Incorrecta.");
            }
        }
        private int Days(int p_Year, int p_Month)
        {
            int[] l_dias = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int l_resultado = l_dias[p_Month - 1];
            if (p_Month == 2 && LeapYear(p_Year))
            { l_resultado++; }
            return l_resultado;
        }
        private void SetDate()
        {
            if (pv_digitsYear == 4 || pv_digitsYear == 2)
            {
                if (pv_digitsYear == 4) { pv_index = 0; }
                string l_dia = dtpDateTimePicker.Value.Day.ToString();
                string l_mes = dtpDateTimePicker.Value.Month.ToString();
                string l_anio = dtpDateTimePicker.Value.Year.ToString();
                mtbMaskedTextBox.Text = Fill(l_dia, 2) + Fill(l_mes, 2) + l_anio.Substring(pv_index, pv_digitsYear);
                MtbMaskedTextBox_lostFocus(null, null);
            }
            pv_changeDate = true;
        }
        private void SetHour()
        {
            if (pv_digitsYear == 4 || pv_digitsYear == 2)
            {
                if (pv_digitsYear == 4) { pv_index = 0; }
                string l_dia = dtpDateTimePicker.Value.Day.ToString();
                string l_mes = dtpDateTimePicker.Value.Month.ToString();
                string l_anio = dtpDateTimePicker.Value.Year.ToString();
                if (pv_setDate)
                {
                    mtbMaskedTextBox.Text = Fill(dtpDateTimePicker.Value.Hour.ToString(), 2) + Fill(dtpDateTimePicker.Value.Minute.ToString(), 2);
                    pv_setDate = false;
                }
                else { mtbMaskedTextBox.Text = Fill("0", 2) + Fill("0", 2); }
                MtbMaskedTextBox_lostFocus(null, null);
            }
            pv_changeDate = true;
        }
        private void SetDateTime()
        {
            if (pv_digitsYear == 4 || pv_digitsYear == 2)
            {
                if (pv_digitsYear == 4) { pv_index = 0; }
                string l_dia = dtpDateTimePicker.Value.Day.ToString();
                string l_mes = dtpDateTimePicker.Value.Month.ToString();
                string l_anio = dtpDateTimePicker.Value.Year.ToString();
                string l_texto = Fill(l_dia, 2) + Fill(l_mes, 2) + l_anio.Substring(pv_index, pv_digitsYear);
                if (pv_setDate)
                {
                    l_texto += Fill(dtpDateTimePicker.Value.Hour.ToString(), 2) + Fill(dtpDateTimePicker.Value.Minute.ToString(), 2);
                    pv_setDate = false;
                }
                else { l_texto += Fill("0", 2) + Fill("0", 2); }
                mtbMaskedTextBox.Text = l_texto;
                MtbMaskedTextBox_lostFocus(null, null);
            }
            pv_changeDate = true;
        }
        private void Validate(string p_Date)
        {
            string[] l_fecha = p_Date.Split(pv_dateSeparator.ToCharArray());
            int l_dia = Convert.ToInt16(l_fecha[0]);
            int l_mes = Convert.ToInt16(l_fecha[1]);
            int l_anio = Convert.ToInt16(l_fecha[2]);
            if (l_mes < 1 || l_mes > 12)
            { pv_month = false; }
            else { pv_month = true; }
            if (pv_month)
            {
                if (l_dia < 0 || l_dia >= Days(l_anio, l_mes))
                { pv_day = false; }
                else { pv_day = true; }
            }
            else { pv_day = false; }
        }
        private bool CorrectDate(string p_Date)
        {
            bool l_correcto;
            try
            {
                DateTime l_fecha = DateTime.Parse(p_Date);
                l_correcto = true;
            }
            catch (Exception)
            {
                l_correcto = false;
            }
            return l_correcto;
        }
        private bool LeapYear(int p_Year)
        {
            return (p_Year % 4 == 0 && p_Year % 100 != 0) || p_Year % 400 == 0;
        }
        private string Fill(string p_Value, int p_Quantity)
        {
            return p_Value.PadLeft(p_Quantity, '0');
        }

        #endregion

        #region [ EVENTS ]

        public event EventHandler SelectedDateChanged;
        private void MaskedDateTime_GotFocus(object sender, EventArgs e)
        {
            this.FocusControl();
        }
        private void DtpDateTimePicker_CloseUp(object sender, EventArgs e)
        {
            if (!pv_esc)
            {
                switch (MDTFormat)
                {
                    case CustomDateFormat.Date:
                        SetDate();
                        break;
                    case CustomDateFormat.DateTime:
                        SetDateTime();
                        break;
                    case CustomDateFormat.Hour:
                        SetHour();
                        break;
                }
            }
            pv_esc = false;
        }
        private void DtpDateTimePicker_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            { pv_esc = true; }
        }
        private void DtpDateTimePicker_LostFocus(object sender, EventArgs e)
        {
            pv_esc = true;
        }
        private void DtpDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (!pv_esc)
            {
                switch (MDTFormat)
                {
                    case CustomDateFormat.Date:
                        SetDate();
                        break;
                    case CustomDateFormat.DateTime:
                        SetDateTime();
                        break;
                    case CustomDateFormat.Hour:
                        SetHour();
                        break;
                }
            }
            SetNewDate();
            SelectedDateChanged?.Invoke(null, EventArgs.Empty);
        }
        private void DtpDateTimePicker_MouseEnter(object sender, EventArgs e)
        {
            if (pv_activateCursor)
            { SetDate(); }
        }
        private void DtpDateTimePicker_DropDown(object sender, EventArgs e)
        {
            try
            {
                dtpDateTimePicker.ValueChanged -= DtpDateTimePicker_ValueChanged;
                if (dtpDateTimePicker.Value.Year < 1990)
                { dtpDateTimePicker.Value = DateTime.Now; }
                DateTime l_fecha;
                if (DateTime.TryParse(mtbMaskedTextBox.Text, out l_fecha))
                {
                    if (l_fecha.Year > 1800)
                    {
                        dtpDateTimePicker.Value = l_fecha.AddDays(-1).AddDays(1);
                        dtpDateTimePicker.Text = l_fecha.ToShortDateString();
                        dtpDateTimePicker.Refresh();
                    }
                }
                dtpDateTimePicker.ValueChanged += DtpDateTimePicker_ValueChanged;
            }
            catch (Exception)
            { }
        }
        private void MtbMaskedTextBox_lostFocus(object sender, EventArgs e)
        {
            pv_day = true;
            pv_month = true;
            switch (MDTFormat)
            {
                case CustomDateFormat.Date:
                    if (mtbMaskedTextBox.Text != "  " + pv_dateSeparator + "  " + pv_dateSeparator)
                    { ValidateDate(); }
                    break;
                case CustomDateFormat.DateTime:
                    string _espacio_anios = (pv_digitsYear == 4) ? "    " : " ";
                    string _espacio_fecha_hora = " ";
                    if (mtbMaskedTextBox.Text != "  " + pv_dateSeparator + "  " + pv_dateSeparator + _espacio_anios + _espacio_fecha_hora + "  " + pv_hourSeparator)
                    { ValidateDateTime(); }
                    break;
                case CustomDateFormat.Hour:
                    if (mtbMaskedTextBox.Text != "  " + pv_hourSeparator)
                    { ValidateHour(); }
                    break;
            }
        }
        private void MtbMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar) < 48 && e.KeyChar != 8) || e.KeyChar > 57)
            { e.Handled = true; }
            pv_changeDate = true;
        }
        private void MtbMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!pv_day && !pv_month)
                {
                    dtpDateTimePicker.ValueChanged -= DtpDateTimePicker_ValueChanged;
                    DateTime l_fecha;
                    if (DateTime.TryParse(mtbMaskedTextBox.Text, out l_fecha))
                    {
                        if (l_fecha.Year > 1800)
                        {
                            dtpDateTimePicker.Text = l_fecha.ToString("dd/MM/yyyy HH:mm");
                            SelectedDateChanged?.Invoke(null, EventArgs.Empty);
                        }
                    }
                    dtpDateTimePicker.ValueChanged += DtpDateTimePicker_ValueChanged;
                }
            }
            catch (Exception)
            { }
        }

        #endregion
    }
}
