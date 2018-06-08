using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library;

namespace WenZiMaSaiKe
{


    public partial class _Default : Page
    {
        const string errorCHN = "抱歉！出了一个BUG，这次翻译不了…请把下面显示的错误消息告诉开发者，用来改进这个软件吧：";
        const string emptyString = "";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Encode_Click(object sender, EventArgs e)
        {
            try
            {
                ErrorTips.Text = emptyString;
                ErrorText.Text = emptyString;

                string rawText = RawText.Text;
                string key = KeyString.Text;

                byte[] temp = EncoderV1.GetRawCodeFromText(rawText);
                EncoderV1.AssembleKeywords(key);
                string tempText = EncryptedText.Text = EncoderV1.ReplaceHexWithKeyText(temp);

                if (key == null || key == "") ErrorText.Text = "请输入神秘代码哦。";
                else if (tempText == null) ErrorText.Text = 
                        "对不起！您输入的神秘代码或原文有问题，我无法正常打码…注意不要使用重复字词作为密码哦！";
            }
            catch (Exception ex)
            {
                ErrorTips.Text = errorCHN;
                ErrorText.Text = ex.Message;
            }
        }

        protected void Decode_Click(object sender, EventArgs e)
        {
            try
            {
                ErrorTips.Text = emptyString;
                ErrorText.Text = emptyString;

                string encryptedText = EncryptedText.Text;
                string key = KeyString.Text;

                EncoderV1.AssembleKeywords(key);

                string temp = EncoderV1.DecodeEncyptedTextToHexArray(encryptedText);

                if (key == null || key == "") ErrorText.Text =  "请输入神秘代码哦。";
                else if (temp == null && encryptedText != null) ErrorText.Text =
                         "对不起！您输入的神秘代码或待解码密文有问题，我解不出来…";

                RawText.Text = temp;
            }
            catch (Exception ex)
            {
                ErrorTips.Text = errorCHN;
                ErrorText.Text = ex.Message;
            }
        }
    }
}