using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary_winform
{
    public class SpeakText
    {
        private WebBrowser wbWeb;

        public WebBrowser WbWeb
        {
            get { return wbWeb; }
            set { wbWeb = value; }
        }

        public SpeakText(WebBrowser wb)
        {
            this.WbWeb = wb;
        }

        private void SetText(string data)
        {
            HtmlElement element;
            element = WbWeb.Document.GetElementById("txtRead");
            if (element == null) element = WbWeb.Document.GetElementById("text");
            if (element != null) element.SetAttribute("value", data);
        }

        private void Speak()
        {
            HtmlElement element;
            element = WbWeb.Document.GetElementById("btTTS");
            if (element == null) element = WbWeb.Document.GetElementById("playbutton");
            if (element != null) element.InvokeMember("click");
        }

        public void Speak(string data)
        {
            if (data == "") SetText(" ");
            else SetText(data);
            Speak();
        }
    }
}
