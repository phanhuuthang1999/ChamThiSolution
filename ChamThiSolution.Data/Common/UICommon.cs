using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DialogResult = System.Windows.Forms.DialogResult;

namespace Common
{
    public static class UICommon
    {
        public enum ModeForm { ThemMoi, CapNhat, SaoChep, Xem };

        public enum EN_GioiTinh
        {
            [Description("Nam")]
            Nam = 1,
            [Description("Nữ")]
            Nu = 0
        }

        public static string GetDescription(this Enum val)
        {
            string name = Enum.GetName(val.GetType(), val);

            System.Reflection.FieldInfo obj = val.GetType().GetField(name);

            if (obj != null)
            {
                object[] attributes = obj.GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);

                return attributes.Length > 0 ? ((System.ComponentModel.DescriptionAttribute)attributes[0]).Description : null;
            }

            return null;
        }

        #region Show Msg

        public static DialogResult ShowMsgInfoString(string pMessageText, params string[] pParameter)
        {
            try
            {
                pMessageText = string.Format(pMessageText, pParameter);

                return XtraMessageBox.Show(pMessageText, "Thông tin!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
            }

            return DialogResult.None;
        }

        public static DialogResult ShowMsgWarningString(string pMessageText, params string[] pParameter)
        {
            try
            {
                pMessageText = string.Format(pMessageText, pParameter);

                return XtraMessageBox.Show(pMessageText, "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
            }

            return DialogResult.None;
        }

        public static DialogResult ShowMsgQuestionString(string pMessageText, params string[] pParameter)
        {
            try
            {
                pMessageText = string.Format(pMessageText, pParameter);

                return XtraMessageBox.Show(pMessageText, "Thông báo?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            catch
            {
            }

            return DialogResult.None;
        }

        public static DialogResult ShowMsgQuestionString(string pMessageText, MessageBoxButtons pMsgButton, params string[] pParameter)
        {
            try
            {
                pMessageText = string.Format(pMessageText, pParameter);

                return XtraMessageBox.Show(pMessageText, "Thông báo?", pMsgButton, MessageBoxIcon.Question);
            }
            catch
            {
            }

            return DialogResult.None;
        }

        public static DialogResult ShowMsgErrorString(string pMessageText, params string[] pParameter)
        {
            try
            {
                pMessageText = string.Format(pMessageText, pParameter);

                return XtraMessageBox.Show(pMessageText, "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
            }

            return DialogResult.None;
        }

        #endregion

        public static byte[] ImageToByteArray(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (var ms = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(ms);
            }

        }

    }
}
