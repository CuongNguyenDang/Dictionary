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
    {   //Database
        public List<string> eng;
        public List<string> wordType;
        public List<string> viet;
        //======================
        public Dictionary_form()
        {
            InitializeComponent();
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

            eng = listEng.ToList();
            wordType = listWordType.ToList();
            viet = listViet.ToList();

            for (int i = 0; i < eng.Count; i++)
            {
                ListEnViWord.Items.Add(eng[i]);
                ListVIEnWord.Items.Add(viet[i]);
            }
           
        }

       public void addNewWord(string word, string pof, string meaning)
        {
            //Add new item
            eng.Add(word);
            wordType.Add(pof);
            viet.Add(meaning);

            ListEnViWord.Items.Add(word);
            ListVIEnWord.Items.Add(meaning);

            this.Refresh();        
           
        }

        private void delWord_Click(object sender, EventArgs e)
        {
            if (ListEnViWord.SelectedIndex != -1)
            {
                ListEnViWord.Items.RemoveAt(ListEnViWord.SelectedIndex);
            }

            if (ListVIEnWord.SelectedIndex != -1)
            {
                ListVIEnWord.Items.RemoveAt(ListVIEnWord.SelectedIndex);
            }
        }
    }
}
