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
    public partial class AddWordForm : Form
    {
        private Dictionary_form form1 = new Dictionary_form();
        public AddWordForm()
        {
            InitializeComponent();
        }

        public AddWordForm(Dictionary_form form)
        {
            form1 = form;
            InitializeComponent();
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            form1.addNewWord(txtWord.Text, txtWordType.Text, txtMeaning.Text);
            this.Close();
        }
    }
}
