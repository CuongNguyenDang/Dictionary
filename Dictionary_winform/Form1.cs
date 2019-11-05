using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary_winform
{
    public partial class Dictionary_form : Form
    {
        WebBrowser wbEng, wbVie;
        SpeakText En, Vie;
        Queue<string> log = new Queue<string>();

        #region Cuong
        //======================
        public Dictionary_form()
        {
            InitializeComponent();

            //Load English speaker browser
            wbEng = new WebBrowser();
            wbEng.Width = 0;
            wbEng.Height = 0;
            wbEng.Visible = false;
            wbEng.ScriptErrorsSuppressed = true;
            wbEng.Navigate(Constant.EnglishLink);

            this.Controls.Add(wbEng);

            En = new SpeakText(wbEng);
            //=============================
            //Load Vietnamese speaker browser
            wbVie = new WebBrowser();
            wbVie.Width = 0;
            wbVie.Height = 0;
            wbVie.Visible = false;
            wbVie.ScriptErrorsSuppressed = true;
            wbVie.Navigate(Constant.VietNamLink);
            this.Controls.Add(wbVie);

            Vie = new SpeakText(wbVie);
            //===============================

        }

        private void addWord_Click(object sender, EventArgs e)
        {
            AddWordForm f = new AddWordForm(this);
            f.Show();
        }

        private void Dictionary_form_Load(object sender, EventArgs e)
        {
            Database db = new Database();
            var listEng = from c in db.EnglishVietnamese select c.Eng;
            var listViet = from d in db.EnglishVietnamese select d.Viet;
            var listWordType = from b in db.EnglishVietnamese select b.PoF;

            List<string> eng = listEng.ToList();
            List<string> wordType = listWordType.ToList();
            List<string> viet = listViet.ToList();

            for (int i = 0; i < eng.Count; i++)
            {
                ListEnViWord.Items.Add(eng[i]);
                ListVIEnWord.Items.Add(viet[i]);
            }

        }

        public void addNewWord(string word, string pof, string meaning)
        {
            //Add new item

            ListEnViWord.Items.Add(word);
            ListVIEnWord.Items.Add(meaning);

            this.Refresh();

        }

        private void delWord_Click(object sender, EventArgs e)
        {
            if (ListEnViWord.SelectedIndex != -1)
            {
                int pos = ListEnViWord.SelectedIndex;
                ListEnViWord.Items.RemoveAt(pos);
                ListVIEnWord.Items.RemoveAt(pos);
                txtMeaning.Text = "";
            }

            if (ListVIEnWord.SelectedIndex != -1)
            {
                int pos = ListVIEnWord.SelectedIndex;
                ListVIEnWord.Items.RemoveAt(pos);
                ListEnViWord.Items.RemoveAt(pos);
                txtMeaning.Text = "";
            }
        }

        private void ListEnViWord_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListEnViWord.SelectedIndex != -1)
                txtMeaning.Text = ListVIEnWord.Items[ListEnViWord.SelectedIndex].ToString();
        }

        private void ListVIEnWord_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListVIEnWord.SelectedIndex != -1)
                txtMeaning.Text = ListEnViWord.Items[ListVIEnWord.SelectedIndex].ToString();
        }

        private void ReadWord_Click(object sender, EventArgs e)
        {
            int mode = SearchBox.SelectedIndex; //Eng = 1,  Viet = 0
            if (mode == 1) En.Speak(txtMeaning.Text);
            else Vie.Speak(txtMeaning.Text);
        }
        #endregion
        #region Phuc
        private void txtKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) FindWord();
        }

        private void SearchWord_Click(object sender, EventArgs e)
        {
            FindWord();
        }

        private void randomWord_Click(object sender, EventArgs e)
        {
            int size = ListEnViWord.Items.Count;
            Random rand = new Random();
            int index = rand.Next(size - 1);
            bool temp = true;
            if (SearchBox.SelectedIndex == 0) ListEnViWord.SetSelected(index, temp);
            else ListVIEnWord.SetSelected(index, temp);
        }

        private void FindWord()
        {
            string key = txtKey.Text;
            int pos = ListEnViWord.FindString(key);
            if (pos != -1) txtMeaning.Text = ListVIEnWord.Items[pos].ToString();
            else txtMeaning.Text = "";
        }

        #endregion
    }
}
