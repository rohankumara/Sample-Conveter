using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conveter
{
    public partial class Conveter : Form
    {
        public Conveter()
        {
            InitializeComponent();
        }

        private void bt_Click(object sender, EventArgs e)
        {
            double Number1 = int.Parse(mv.Text);
            double Result = Number1 /1000;

            kmv.Text = Result.ToString();

        }
    }
}
