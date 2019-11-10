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
    public partial class History : Form
    {
        List<string> log = new List<string>();
        public History()
        {
            InitializeComponent();
        }

        public History(List<string> log)
        {
            InitializeComponent();
            this.log = log;
        }

        private void History_Load(object sender, EventArgs e)
        {
            MinimizeBox = false;
            MaximizeBox = false;
            lbLog.DataSource = log;
            this.Refresh();
        }
    }
}
