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
    public partial class Form1 : Form
    {
        public DataTable dt = new DataTable();
        public bool isOpen = false;
        public Form1()
        {
            InitializeComponent();
            browseTextBox.ReadOnly = true; 
        } 
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentCell != null)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(rowIndex);
            }   
            // dataGridView1.Refresh();
        }
        private void exportButton_Click(object sender, EventArgs e)
        {
            List<string> lines = new List<string>();
            DataGridViewColumnCollection header = dataGridView1.Columns;
            bool firstDone = false;
            StringBuilder headerLine = new StringBuilder();
            foreach (DataGridViewColumn col in header)
            {
                if (!firstDone)
                {
                    headerLine.Append(col.Name);
                    firstDone = true;
                }
                else
                {
                    headerLine.Append(";" + col.Name);
                }
            }
            lines.Add(headerLine.ToString());
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                StringBuilder dataLine = new StringBuilder();
                firstDone = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (!firstDone)
                    {
                        dataLine.Append(cell.Value);
                        firstDone = true;
                    }
                    else
                    {
                        dataLine.Append(";" + cell.Value);
                    }
                }
                lines.Add(dataLine.ToString());
            }
            string file = @"d:\\somefile.csv";
            System.IO.File.WriteAllLines(file, lines);
            System.Diagnostics.Process.Start(file);
        }
        private void LoadFile_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            FileOpen(browseTextBox.Text);
            // dataGridView1.DataSource = new CSVtoDGV().FileOpen(browseTextBox.Text);
        }
        private void FileOpen(string filePath)
        {
            isOpen = true;
            string[] lines = System.IO.File.ReadAllLines(filePath);
            if (lines.Length > 0)
            {
                //first line to create header
                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(';');
                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }
                //For Data
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(';');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                    }
                    dt.Rows.Add(dr);
                }
            }
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            browseTextBox.Text = dlg.FileName;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            FileOpen(browseTextBox.Text);
        }
        private void addRowButton_Click(object sender, EventArgs e)
        {
            AddForm af = new AddForm(this);
            af.ShowDialog();
        }

        private void ex1Button_Click(object sender, EventArgs e)
        {
            Ex1 ex1 = new Ex1(this);
            ex1.ShowDialog();
        }
    }
}
