using System;
using System.Windows.Forms;
using System.ServiceModel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

namespace VenPy.Controls
{
    public partial class Messages : Form
    {
        #region [ ENUM ]

        /// <summary>
        /// Types of Messages
        /// </summary>
        public enum TMessages
        {
            msg_Error = 0,
            msg_Question = 1,
            msg_Infomation = 2,
            msg_Warnig = 3,
            msg_Satisfactory = 4,
            msg_DetailedInformation = 5,
            msg_ErrorAccept = 6,
            msg_DetailedWarning = 7
        }
        /// <summary>
        /// Types of Buttons
        /// </summary>
        public enum TButtons
        {
            btn_Accept,
            btn_Cancel,
            btn_Detail,
            btn_Yes,
            btn_No,
            btn_Any
        };
        /// <summary>
        /// Types of Buttons 2
        /// </summary>
        public enum TLabelButtons
        {
            lbt_Accept_Cancel,
            lbt_Yes_No
        };

        #endregion

        #region [ VARIABLES ]

        private TMessages pv_TypeMessage;
        private TButtons pv_TypeButton;
        private TLabelButtons pv_TypeLabelButton;

        #endregion

        #region [ PROPERTIES ]

        public TButtons TypeButtonMessage
        {
            get { return pv_TypeButton; }
            set { pv_TypeButton = value; SelectionButton(value); }
        }
        public TMessages TypeMessage
        {
            get { return pv_TypeMessage; }
            set { pv_TypeMessage = value; DefineMessage(); }
        }
        public TLabelButtons TypeLabelButton
        {
            get { return pv_TypeLabelButton; }
            set
            {
                pv_TypeLabelButton = value;
                if (pv_TypeLabelButton == TLabelButtons.lbt_Accept_Cancel)
                {
                    btnAccept.Text = "&Aceptar";
                    btnCancel.Text = "&Cancelar";
                }
                else if (pv_TypeLabelButton == TLabelButtons.lbt_Yes_No)
                {
                    btnAccept.Text = "&Si";
                    btnDetails.Text = "&No";
                    btnCancel.Text = string.Empty;
                    btnCancel.Visible = false;
                }
                else
                {
                    btnAccept.Text = "&Aceptar";
                    btnCancel.Text = "&Cancelar";
                }
            }
        }
        public bool SeeDetailButton
        {
            get { return btnDetails.Visible; }
            set { btnDetails.Visible = value; }
        }
        public string MessageTitle
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }
        public string Message
        {
            get { return lblMessage.Text; }
            set { lblMessage.Text = value; }
        }
        public string Detail
        {
            get { return txtDetails.Text; }
            set { txtDetails.Text = value; }
        }

        #endregion

        #region [ FORM ]

        /// <summary>
        /// Dialogs Form Builder
        /// </summary>
        public Messages()
        {
            InitializeComponent();
            btnAccept.Click += new EventHandler(BtnAccept_Click);
            btnCancel.Click += new EventHandler(BtnCancel_Click);
            btnDetails.Click += new EventHandler(BtnDetails_Click);
        }
        /// <summary>
        /// Event that is launched when the Form is started
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Menssages_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDetails.Text))
            {
                txtDetails.Visible = false;
                Height = 265;
            }
        }

        #endregion

        #region [ METHODS ]

        /// <summary>
        /// Select the Button according to the User's Choice
        /// </summary>
        /// <param name="_opcion"></param>
        private void SelectionButton(TButtons p_option)
        {
            if (p_option == TButtons.btn_Accept)
            {
                if (btnAccept.Visible)
                {
                    btnAccept.Focus();
                }
                else if (btnCancel.Visible)
                {
                    btnCancel.Focus();
                }
                else if (btnDetails.Visible)
                {
                    btnDetails.Focus();
                }
            }
            else if (p_option == TButtons.btn_Cancel)
            {
                if (btnCancel.Visible)
                {
                    btnCancel.Focus();
                }
                else if (btnAccept.Visible)
                {
                    btnAccept.Focus();
                }
                else if (btnDetails.Visible)
                {
                    btnDetails.Focus();
                }
            }
            else if (p_option == TButtons.btn_Detail)
            {
                if (btnDetails.Visible)
                {
                    btnDetails.Focus();
                }
                else if (btnAccept.Visible)
                {
                    btnAccept.Focus();
                }
                else if (btnCancel.Visible)
                {
                    btnCancel.Focus();
                }
            }
            else if (p_option == TButtons.btn_Yes)
            {
                SelectionButton(TButtons.btn_Accept);
            }
            else if (p_option == TButtons.btn_No)
            {
                SelectionButton(TButtons.btn_Cancel);
            }
            else
            {
                if (btnAccept.Visible)
                {
                    btnAccept.Focus();
                }
                else if (btnCancel.Visible)
                {
                    btnCancel.Focus();
                }
                else if (btnDetails.Visible)
                {
                    btnDetails.Focus();
                }
            }
        }
        /// <summary>
        /// Build the Form according to the Type of Message
        /// </summary>
        private void DefineMessage()
        {
            switch (pv_TypeMessage)
            {
                case TMessages.msg_Error:
                    btnAccept.Visible = true;
                    btnDetails.Visible = true;
                    btnCancel.Visible = false;
                    ptbIcon.Image = ltsImages.Images[0];
                    tlpTitulo.BackColor = Color.FromArgb(195, 34, 28);
                    break;
                case TMessages.msg_Question:
                    btnAccept.Visible = true;
                    btnDetails.Visible = false;
                    btnCancel.Visible = true;
                    ptbIcon.Image = ltsImages.Images[1];
                    tlpTitulo.BackColor = Color.FromArgb(93, 176, 255);
                    break;
                case TMessages.msg_Warnig:
                    btnAccept.Visible = true;
                    btnDetails.Visible = false;
                    btnCancel.Visible = false;
                    ptbIcon.Image = ltsImages.Images[2];
                    tlpTitulo.BackColor = Color.FromArgb(246, 197, 0);
                    break;
                case TMessages.msg_Infomation:
                    btnAccept.Visible = true;
                    btnDetails.Visible = false;
                    btnCancel.Visible = false;
                    ptbIcon.Image = ltsImages.Images[3];
                    tlpTitulo.BackColor = Color.FromArgb(239, 121, 0);
                    break;
                case TMessages.msg_Satisfactory:
                    btnAccept.Visible = true;
                    btnDetails.Visible = false;
                    btnCancel.Visible = false;
                    ptbIcon.Image = ltsImages.Images[4];
                    tlpTitulo.BackColor = Color.FromArgb(8, 86, 5);
                    break;
                case TMessages.msg_DetailedInformation:
                    btnAccept.Visible = true;
                    btnDetails.Visible = true;
                    btnCancel.Visible = false;
                    ptbIcon.Image = ltsImages.Images[3];
                    tlpTitulo.BackColor = Color.FromArgb(239, 121, 0);
                    break;
                case TMessages.msg_DetailedWarning:
                    btnAccept.Visible = true;
                    btnDetails.Visible = true;
                    btnCancel.Visible = false;
                    ptbIcon.Image = ltsImages.Images[2];
                    tlpTitulo.BackColor = Color.FromArgb(246, 197, 0);
                    break;
                case TMessages.msg_ErrorAccept:
                    btnAccept.Visible = true;
                    btnDetails.Visible = false;
                    btnCancel.Visible = false;
                    ptbIcon.Image = ltsImages.Images[0];
                    tlpTitulo.BackColor = Color.FromArgb(195, 34, 28);
                    break;
            }
        }

        #endregion

        #region [ MESSAGES ]

        #region [ ERROR MESSAGE ]

        /// <summary>
        /// Show an Error Message
        /// </summary>
        /// <param name="p_title"></param>
        /// <param name="p_message"></param>
        /// <param name="p_exception"></param>
        /// <param name="p_button"></param>
        /// <returns></returns>
        public static DialogResult ShowErrorMessage(string p_title, string p_message, Exception p_exception, TButtons p_button = TButtons.btn_Detail)
        {
            Messages l_Messages = new Messages();
            string l_tecnichalMessage = string.Empty;
            if (p_exception != null)
            {
                if (p_message.Length == 0)
                {
                    p_message = p_exception.Message;
                    l_tecnichalMessage += Environment.NewLine;
                }
                else
                { l_tecnichalMessage += "Descripción: " + p_exception.Message + Environment.NewLine; }
                l_tecnichalMessage += "Origen: " + p_exception.Source + Environment.NewLine;
                l_tecnichalMessage += "Método Origen: " + p_exception.TargetSite.ToString() + Environment.NewLine;
                l_tecnichalMessage += "Seguimiento del Error: " + p_exception.StackTrace + Environment.NewLine;
                if (p_exception.InnerException != null)
                {
                    l_tecnichalMessage = l_tecnichalMessage + p_exception.InnerException.Message;
                }
            }
            else
            {
                l_tecnichalMessage = "No hay detalles del error.";
            }
            l_Messages.TypeMessage = TMessages.msg_Error;
            l_Messages.MessageTitle = p_title;
            l_Messages.Message = p_message;
            l_Messages.Detail = l_tecnichalMessage;
            l_Messages.TypeButtonMessage = p_button;
            return l_Messages.ShowDialog();
        }
        /// <summary>
        /// Show an Error Message
        /// </summary>
        /// <param name="p_title"></param>
        /// <param name="p_message"></param>
        /// <param name="p_exception"></param>
        /// <returns></returns>
        public static DialogResult ShowErrorMessage(string p_title, string p_message, Exception p_exception)
        {
            Messages l_Messages = new Messages();
            string l_tecnichalMessage = string.Empty;
            if (p_exception != null)
            {
                if (p_message.Length == 0)
                {
                    p_message = p_exception.Message;
                    try
                    {
                        if (p_exception != null && ((FaultException<ExceptionDetail>)(p_exception)).Detail != null)
                        {
                            if (((FaultException<ExceptionDetail>)(p_exception)).Detail.InnerException != null)
                            {
                                l_tecnichalMessage += "Descripción: " + ((FaultException<ExceptionDetail>)(p_exception)).Detail.InnerException.Message;
                                l_tecnichalMessage += Environment.NewLine;
                            }
                            else
                            {
                                l_tecnichalMessage += "Descripción: " + ((FaultException<ExceptionDetail>)(p_exception)).Detail.Message;
                                l_tecnichalMessage += Environment.NewLine;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        if (p_exception != null)
                        {
                            l_tecnichalMessage += "Descripción: " + p_exception.Message;
                            l_tecnichalMessage += Environment.NewLine;
                        }
                    }
                }
                else
                { l_tecnichalMessage += "Descripción: " + p_exception.Message + Environment.NewLine; }
                l_tecnichalMessage += "Origen: " + p_exception.Source + Environment.NewLine;
                l_tecnichalMessage += "Método Origen: " + p_exception.TargetSite.ToString() + Environment.NewLine;
                l_tecnichalMessage += "Seguimiento del Error: " + p_exception.StackTrace + Environment.NewLine;
                if (p_exception.InnerException != null)
                {
                    l_tecnichalMessage = l_tecnichalMessage + p_exception.InnerException.Message;
                }
            }
            else
            {
                l_tecnichalMessage = "No hay detalles del error.";
            }
            l_Messages.TypeMessage = TMessages.msg_Error;
            l_Messages.MessageTitle = p_title;
            l_Messages.Message = p_message;
            l_Messages.Detail = l_tecnichalMessage;
            return l_Messages.ShowDialog();
        }
        /// <summary>
        /// Show an Error Message
        /// </summary>
        /// <param name="p_title"></param>
        /// <param name="p_message"></param>
        /// <returns></returns>
        public static DialogResult ShowErrorMessage(string p_title, string p_message)
        {
            Messages l_Messages = new Messages();
            string l_tecnichalMessage = string.Empty;
            l_tecnichalMessage = "No hay detalles del error.";
            l_Messages.TypeMessage = TMessages.msg_Error;
            l_Messages.MessageTitle = p_title;
            l_Messages.Message = p_message;
            l_Messages.Detail = l_tecnichalMessage;
            l_Messages.TypeButtonMessage = TButtons.btn_Detail;
            return l_Messages.ShowDialog();
        }
        /// <summary>
        /// Show an Error Message
        /// </summary>
        /// <param name="p_title"></param>
        /// <param name="p_message"></param>
        /// <param name="p_show_details"></param>
        /// <returns></returns>
        public static DialogResult ShowErrorMessage(string p_title, string p_message, bool p_show_details)
        {
            Messages l_Messages = new Messages();
            string l_tecnichalMessage = string.Empty;
            l_tecnichalMessage = "No hay detalles del error.";
            if (p_show_details)
            {
                l_Messages.TypeMessage = TMessages.msg_Error;
            }
            else
            {
                l_Messages.TypeMessage = TMessages.msg_ErrorAccept;
            }
            l_Messages.MessageTitle = p_title;
            l_Messages.Message = p_message;
            l_Messages.Detail = l_tecnichalMessage;
            l_Messages.TypeButtonMessage = TButtons.btn_Detail;
            return l_Messages.ShowDialog();
        }

        #endregion

        #region [ QUESTION MESSAGE ]

        /// <summary>
        /// Show an Question Message
        /// </summary>
        /// <param name="p_title"></param>
        /// <param name="p_message"></param>
        /// <param name="p_detail"></param>
        /// <param name="p_button"></param>
        /// <param name="p_seeDetail"></param>
        /// <returns></returns>
        public static DialogResult ShowQuestionMessage(string p_title, string p_message, string p_detail, TButtons p_button = TButtons.btn_Accept, bool p_seeDetail = false)
        {
            Messages l_Messages = new Messages();
            l_Messages.TypeMessage = TMessages.msg_Question;
            l_Messages.MessageTitle = p_title;
            l_Messages.Message = p_message;
            l_Messages.Detail = p_detail;
            l_Messages.TypeButtonMessage = p_button;
            l_Messages.SeeDetailButton = p_seeDetail;
            l_Messages.TypeLabelButton = TLabelButtons.lbt_Accept_Cancel;
            return l_Messages.ShowDialog();
        }
        /// <summary>
        /// Show an Question Message
        /// </summary>
        /// <param name="p_title"></param>
        /// <param name="p_message"></param>
        /// <param name="p_detail"></param>
        /// <param name="p_labelBoton"></param>
        /// <param name="p_button"></param>
        /// <param name="p_seeDetail"></param>
        /// <returns></returns>
        public static DialogResult ShowQuestionMessage(string p_title, string p_message, string p_detail, TLabelButtons p_labelBoton, TButtons p_button = TButtons.btn_Accept, bool p_seeDetail = false)
        {
            Messages l_Messages = new Messages();
            l_Messages.TypeMessage = TMessages.msg_Question;
            l_Messages.MessageTitle = p_title;
            l_Messages.Message = p_message;
            l_Messages.Detail = p_detail;
            l_Messages.TypeButtonMessage = p_button;
            l_Messages.SeeDetailButton = p_seeDetail;
            l_Messages.TypeLabelButton = p_labelBoton;
            return l_Messages.ShowDialog();
        }
        /// <summary>
        /// Show an Question Message
        /// </summary>
        /// <param name="p_title"></param>
        /// <param name="p_message"></param>
        /// <returns></returns>
        public static DialogResult ShowQuestionMessage(string p_title, string p_message)
        {
            Messages l_Messages = new Messages();
            l_Messages.TypeMessage = TMessages.msg_Question;
            l_Messages.MessageTitle = p_title;
            l_Messages.Message = p_message;
            l_Messages.Detail = string.Empty;
            l_Messages.TypeButtonMessage = TButtons.btn_Accept;
            l_Messages.SeeDetailButton = false;
            l_Messages.TypeLabelButton = TLabelButtons.lbt_Accept_Cancel;
            return l_Messages.ShowDialog();
        }
        /// <summary>
        /// Show an Question Message
        /// </summary>
        /// <param name="p_title"></param>
        /// <param name="p_message"></param>
        /// <param name="p_detail"></param>
        /// <returns></returns>
        public static DialogResult ShowQuestionMessage(string p_title, string p_message, string p_detail)
        {
            Messages l_Messages = new Messages();
            l_Messages.TypeMessage = TMessages.msg_Question;
            l_Messages.MessageTitle = p_title;
            l_Messages.Message = p_message;
            l_Messages.Detail = p_detail;
            l_Messages.TypeButtonMessage = TButtons.btn_Accept;
            if (!String.IsNullOrEmpty(p_detail))
            { l_Messages.SeeDetailButton = p_detail.Trim().Length > 0; }
            l_Messages.TypeLabelButton = TLabelButtons.lbt_Accept_Cancel;
            return l_Messages.ShowDialog();
        }
        /// <summary>
        /// Show an Question Message
        /// </summary>
        /// <param name="p_title"></param>
        /// <param name="p_message"></param>
        /// <param name="p_labelBoton"></param>
        /// <returns></returns>
        public static DialogResult ShowQuestionMessage(string p_title, string p_message, TLabelButtons p_labelBoton)
        {
            Messages l_Messages = new Messages();
            l_Messages.TypeMessage = TMessages.msg_Question;
            l_Messages.MessageTitle = p_title;
            l_Messages.Message = p_message;
            l_Messages.Detail = string.Empty;
            l_Messages.TypeButtonMessage = TButtons.btn_Accept;
            l_Messages.SeeDetailButton = true;
            l_Messages.TypeLabelButton = p_labelBoton;
            return l_Messages.ShowDialog();
        }
        /// <summary>
        /// Show an Question Message
        /// </summary>
        /// <param name="p_title"></param>
        /// <param name="p_message"></param>
        /// <param name="p_detail"></param>
        /// <param name="p_selectedButton"></param>
        /// <returns></returns>
        public static DialogResult ShowQuestionMessage(string p_title, string p_message, string p_detail, TButtons p_selectedButton)
        {
            Messages l_Messages = new Messages();
            l_Messages.TypeMessage = TMessages.msg_Question;
            l_Messages.MessageTitle = p_title;
            l_Messages.Message = p_message;
            l_Messages.Detail = p_detail;
            l_Messages.TypeButtonMessage = p_selectedButton;
            l_Messages.SeeDetailButton = p_detail.Trim().Length > 0;
            l_Messages.TypeLabelButton = TLabelButtons.lbt_Accept_Cancel;
            return l_Messages.ShowDialog();
        }
        /// <summary>
        /// Show an Question Message
        /// </summary>
        /// <param name="p_title"></param>
        /// <param name="p_message"></param>
        /// <param name="p_detail"></param>
        /// <param name="p_labelBoton"></param>
        /// <returns></returns>
        public static DialogResult ShowQuestionMessage(string p_title, string p_message, string p_detail, TLabelButtons p_labelBoton)
        {
            Messages l_Messages = new Messages();
            l_Messages.TypeMessage = TMessages.msg_Question;
            l_Messages.MessageTitle = p_title;
            l_Messages.Message = p_message;
            l_Messages.Detail = p_detail;
            l_Messages.TypeButtonMessage = TButtons.btn_Accept;
            l_Messages.SeeDetailButton = p_detail.Trim().Length > 0;
            l_Messages.TypeLabelButton = p_labelBoton;
            return l_Messages.ShowDialog();
        }
        /// <summary>
        /// Show an Question Message
        /// </summary>
        /// <param name="p_title"></param>
        /// <param name="p_message"></param>
        /// <param name="p_detail"></param>
        /// <param name="p_labelBoton"></param>
        /// <param name="p_selectedButton"></param>
        /// <returns></returns>
        public static DialogResult ShowQuestionMessage(string p_title, string p_message, string p_detail, TLabelButtons p_labelBoton, TButtons p_selectedButton)
        {
            Messages l_Messages = new Messages();
            l_Messages.TypeMessage = TMessages.msg_Question;
            l_Messages.MessageTitle = p_title;
            l_Messages.Message = p_message;
            l_Messages.Detail = p_detail;
            l_Messages.TypeButtonMessage = p_selectedButton;
            l_Messages.SeeDetailButton = p_detail.Trim().Length > 0;
            l_Messages.TypeLabelButton = p_labelBoton;
            return l_Messages.ShowDialog();
        }

        #endregion

        #region [ INFORMATION MESSAGE ]

        /// <summary>
        /// Show an Information Message
        /// </summary>
        /// <param name="p_title"></param>
        /// <param name="p_message"></param>
        /// <param name="p_button"></param>
        /// <returns></returns>
        public static DialogResult ShowInformationMessage(string p_title, string p_message, TButtons p_button = TButtons.btn_Accept)
        {
            Messages l_Messages = new Messages();
            l_Messages.TypeMessage = TMessages.msg_Infomation;
            l_Messages.MessageTitle = p_title;
            l_Messages.Message = p_message;
            l_Messages.TypeButtonMessage = p_button;
            return l_Messages.ShowDialog();
        }
        /// <summary>
        /// Show an Information Message
        /// </summary>
        /// <param name="p_title"></param>
        /// <param name="p_message"></param>
        /// <param name="p_detail"></param>
        /// <param name="p_button"></param>
        /// <returns></returns>
        public static DialogResult ShowInformationMessage(string p_title, string p_message, string p_detail, TButtons p_button = TButtons.btn_Detail)
        {
            Messages l_Messages = new Messages();
            l_Messages.TypeMessage = TMessages.msg_DetailedInformation;
            l_Messages.MessageTitle = p_title;
            l_Messages.Message = p_message;
            l_Messages.Detail = p_detail;
            l_Messages.TypeButtonMessage = p_button;
            return l_Messages.ShowDialog();
        }
        /// <summary>
        /// Show an Information Message
        /// </summary>
        /// <param name="p_title"></param>
        /// <param name="p_message"></param>
        /// <param name="p_detail"></param>
        /// <returns></returns>
        public static DialogResult ShowInformationMessage(string p_title, string p_message, string p_detail)
        {
            Messages l_Messages = new Messages();
            l_Messages.TypeMessage = TMessages.msg_DetailedInformation;
            l_Messages.MessageTitle = p_title;
            l_Messages.Message = p_message;
            l_Messages.Detail = p_detail;
            l_Messages.SeeDetailButton = (p_detail != null ? (p_detail.Trim().Length > 0) : false);
            l_Messages.TypeButtonMessage = TButtons.btn_Accept;
            return l_Messages.ShowDialog();
        }

        #endregion

        #region [ SATISFACTORY MESSAGE ]

        /// <summary>
        /// Show an Satisfactory Message
        /// </summary>
        /// <param name="p_title"></param>
        /// <param name="p_message"></param>
        /// <param name="p_button"></param>
        /// <returns></returns>
        public static DialogResult ShowSatisfactoryMessage(string p_title, string p_message, TButtons p_button = TButtons.btn_Accept)
        {
            Messages l_Messages = new Messages();
            l_Messages.TypeMessage = TMessages.msg_Satisfactory;
            l_Messages.MessageTitle = p_title;
            l_Messages.Message = p_message;
            l_Messages.TypeButtonMessage = p_button;
            return l_Messages.ShowDialog();
        }
        /// <summary>
        /// Show an Satisfactory Message
        /// </summary>
        /// <param name="p_title"></param>
        /// <param name="p_message"></param>
        /// <returns></returns>
        public static DialogResult ShowSatisfactoryMessage(string p_title, string p_message)
        {
            Messages l_Messages = new Messages();
            l_Messages.TypeMessage = TMessages.msg_Satisfactory;
            l_Messages.MessageTitle = p_title;
            l_Messages.Message = p_message;
            l_Messages.SeeDetailButton = false;
            l_Messages.TypeButtonMessage = TButtons.btn_Accept;
            return l_Messages.ShowDialog();
        }
        /// <summary>
        /// Show an Satisfactory Message
        /// </summary>
        /// <param name="p_title"></param>
        /// <param name="p_message"></param>
        /// <param name="p_detail"></param>
        /// <returns></returns>
        public static DialogResult ShowSatisfactoryMessage(string p_title, string p_message, string p_detail)
        {
            Messages l_Messages = new Messages();
            l_Messages.TypeMessage = TMessages.msg_Satisfactory;
            l_Messages.MessageTitle = p_title;
            l_Messages.Message = p_message;
            l_Messages.Detail = p_detail;
            l_Messages.SeeDetailButton = p_detail.Trim().Length > 0;
            l_Messages.TypeButtonMessage = TButtons.btn_Accept;
            if (!string.IsNullOrEmpty(p_detail))
            {
                l_Messages.Height = 395;
                l_Messages.btnDetails.Text = "Detalles <<";
            }
            return l_Messages.ShowDialog();
        }

        #endregion

        #region [ WARNING MESSAGE ]

        /// <summary>
        /// Show an Warning Message
        /// </summary>
        /// <param name="p_title"></param>
        /// <param name="p_message"></param>
        /// <param name="p_button"></param>
        /// <returns></returns>
        public static DialogResult ShowWarningMessage(string p_title, string p_message, TButtons p_button = TButtons.btn_Accept)
        {
            Messages l_Messages = new Messages();
            l_Messages.TypeMessage = TMessages.msg_Warnig;
            l_Messages.MessageTitle = p_title;
            l_Messages.Message = p_message;
            l_Messages.TypeButtonMessage = p_button;
            return l_Messages.ShowDialog();
        }
        /// <summary>
        /// Show an Warning Message
        /// </summary>
        /// <param name="p_title"></param>
        /// <param name="p_message"></param>
        /// <param name="p_detail"></param>
        /// <param name="p_button"></param>
        /// <returns></returns>
        public static DialogResult ShowWarningMessage(string p_title, string p_message, string p_detail, TButtons p_button = TButtons.btn_Detail)
        {
            Messages l_Messages = new Messages();
            l_Messages.TypeMessage = TMessages.msg_DetailedWarning;
            l_Messages.MessageTitle = p_title;
            l_Messages.Message = p_message;
            l_Messages.Detail = p_detail;
            l_Messages.TypeButtonMessage = p_button;
            return l_Messages.ShowDialog();
        }
        /// <summary>
        /// Show an Warning Message
        /// </summary>
        /// <param name="p_title"></param>
        /// <param name="p_message"></param>
        /// <param name="p_detail"></param>
        /// <returns></returns>
        public static DialogResult ShowWarningMessage(string p_title, string p_message, string p_detail)
        {
            Messages l_Messages = new Messages();
            l_Messages.TypeMessage = TMessages.msg_DetailedWarning;
            l_Messages.MessageTitle = p_title;
            l_Messages.Message = p_message;
            l_Messages.Detail = p_detail;
            l_Messages.SeeDetailButton = (p_detail != null ? (p_detail.Trim().Length > 0) : false);
            l_Messages.TypeButtonMessage = TButtons.btn_Accept;
            return l_Messages.ShowDialog();
        }

        #endregion


        #endregion

        #region [ EVENTS ]

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            if (pv_TypeLabelButton == TLabelButtons.lbt_Accept_Cancel)
            {
                DialogResult = DialogResult.OK;
            }
            else if (pv_TypeLabelButton == TLabelButtons.lbt_Yes_No)
            {
                DialogResult = DialogResult.Yes;
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
            Close();
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (pv_TypeLabelButton == TLabelButtons.lbt_Accept_Cancel)
            {
                DialogResult = DialogResult.Cancel;
            }
            else if (pv_TypeLabelButton == TLabelButtons.lbt_Yes_No)
            {
                DialogResult = DialogResult.Cancel;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }
        private void BtnDetails_Click(object sender, EventArgs e)
        {
            if (pv_TypeLabelButton == TLabelButtons.lbt_Accept_Cancel)
            {
                txtDetails.Visible = !(txtDetails.Visible);
                if (txtDetails.Visible)
                {
                    Height = 435;
                    btnDetails.Text = "Detalles <<";
                }
                else
                {
                    Height = 265;
                    btnDetails.Text = "Detalles >>";
                }
            }
            else if (pv_TypeLabelButton == TLabelButtons.lbt_Yes_No)
            {
                DialogResult = DialogResult.No;
            }
            else
            {
                txtDetails.Visible = !(txtDetails.Visible);
                if (txtDetails.Visible)
                {
                    Height = 435;
                    btnDetails.Text = "Detalles <<";
                }
                else
                {
                    Height = 265;
                    btnDetails.Text = "Detalles >>";
                }
            }
        }

        #endregion 
    }
}
