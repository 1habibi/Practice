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
    public partial class Ex1 : Form
    {
        Form1 mainForm;
        public int rowIndex;
        public int minRow;
        public Ex1(Form1 form1)
        {
            InitializeComponent();
            this.mainForm = form1;
            Work();
        }
        private void Work()
        {  
            ex1DataGridView.Columns.Clear();
            ex1DataGridView.Rows.Clear();
           
            ex1DataGridView.Columns.Add("mark", "mark");
            ex1DataGridView.Columns.Add("mileage", "mileage");
            ex1DataGridView.Columns.Add("cost", "cost");

            minRow = Convert.ToInt32(mainForm.dataGridView1.Rows[0].Cells[2].Value);
            
            for (int i = 1; i < mainForm.dataGridView1.RowCount; i++)
            {
                if (Convert.ToInt32(mainForm.dataGridView1.Rows[i].Cells[2].Value) < minRow)
                {
                    minRow = Convert.ToInt32(mainForm.dataGridView1.Rows[i].Cells[2].Value);
                    rowIndex = i;
                }
            }
            ex1DataGridView.Rows.Add(mainForm.dataGridView1.Rows[rowIndex].Cells[0].Value, mainForm.dataGridView1.Rows[rowIndex].Cells[1].Value, mainForm.dataGridView1.Rows[rowIndex].Cells[2].Value);
        }
    }
}
