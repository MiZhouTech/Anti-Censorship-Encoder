using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;

namespace WindowsForms
{
    public partial class FormMain : Form
    {
        string language = "CHN";
        const string errorCHN = "抱歉！出了一个BUG，这次翻译不了…请把下面显示的错误消息告诉开发者，用来改进这个软件吧：";
        const string errorENG = "Sorry, a bug appeared... Please report the error message below to the developer: ";
        string errorLangNow; 
        const string titleENG = "Text Mosaic - Censorship Avoider - v0.0.0";
        const string titleCHN = "文字打码助手 - 测试版 v0.0.0";
        const string emptyString = "";

        public FormMain()
        {
            errorLangNow = errorCHN;
            InitializeComponent();
        }

        private void Encode_Click(object sender, EventArgs e)
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

                if (key == null || key == "") ErrorText.Text = language == "CHN" ? "请输入神秘代码哦。" : "Please type in your key";
                else if (tempText == null) ErrorText.Text = language == "CHN" ? 
                        "对不起！您输入的神秘代码或原文有问题，我无法正常打码…注意不要使用重复字词作为密码哦！" :
                    "Sorry, the key or the raw text you typed in does not work. Note that you should not use repeated words/letter sequence.";
            }
            catch (Exception ex)
            {
                ErrorTips.Text = errorLangNow;
                ErrorText.Text = ex.Message;
            }

        }

        private void Decode_Click(object sender, EventArgs e)
        {
            try
            {
                ErrorTips.Text = emptyString;
                ErrorText.Text = emptyString;

                string encryptedText = EncryptedText.Text;
                string key = KeyString.Text;

                EncoderV1.AssembleKeywords(key);

                string temp = EncoderV1.DecodeEncyptedTextToHexArray(encryptedText);

                if (key == null || key == "") ErrorText.Text = language == "CHN" ? "请输入神秘代码哦。" : "Please type in your key";
                else if (temp == null && encryptedText !=null) ErrorText.Text = language == "CHN" ?
                        "对不起！您输入的神秘代码或待解码密文有问题，我解不出来…" :
                    "Sorry, the key or encrypted text you typed in does not work.";

                RawText.Text = temp;
            }
            catch (Exception ex)
            {
                ErrorTips.Text = errorLangNow;
                ErrorText.Text = ex.Message;
            }

        }

        private void LanguageButton_Click(object sender, EventArgs e)
        {
            if (language=="CHN")
            {
                errorLangNow = errorENG;
                language = "ENG";
            }
            else
            {
                errorLangNow = errorCHN;
                language = "CHN";
            }

            Text = language == "CHN" ? titleCHN : titleENG;
            Encode.Text = language == "CHN" ? "打码 >>" : "Encode >>";
            Decode.Text = language == "CHN" ? "<< 解码" : "<< Decode";
            KeyTips.Text = language == "CHN" ? "输入神秘代码：（格式： 用杠-分割的-替换字符-最长-可-16组-字词-互相-不能-重复-，-不足时-会有-默认-标点-补位）" 
                : "Key to use: (format: A-string of-UP TO-16-fields of words-separated-by dash-without-duplication-if-bugs-appear-pls-try-other-combinations)";
            RawText.Text = emptyString;
            EncryptedText.Text = emptyString;
            ErrorTips.Text = emptyString;
            ErrorText.Text = emptyString;
        }
    }
}
