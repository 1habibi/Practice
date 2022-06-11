using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onemoretry
{
    public partial class Ex2 : Form
    {
        Form1 mainForm;
        public Ex2(Form1 form1)
        {
            InitializeComponent();
            this.mainForm = form1;
            Work();
        }
        private void Work()
        {
            ex2DataGridView.Columns.Clear();
            ex2DataGridView.Rows.Clear();
        }
    }
}
