using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        DateTimePicker dtp = new DateTimePicker();
        Rectangle _Rectangle;
        public Form3()
        {
            InitializeComponent();
            dataGridView1.Controls.Add(dtp);
            dtp.Visible = false;
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.TextChanged += new EventHandler(dtp_TextChange);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet1.Scule' table. You can move, or remove it, as needed.
            this.sculeTableAdapter.Fill(this.masterDataSet1.Scule);

            this.dataGridView1.DataSource = this.sculeBindingSource1;

        }

        private void enter(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    this.Validate();
                    this.sculeBindingSource.EndEdit();
                    this.sculeTableAdapter.Update(this.masterDataSet1.Scule);
                    this.sculeTableAdapter.Fill(this.masterDataSet1.Scule);
  




                    MessageBox.Show("Update successful");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[luatDataGridViewCheckBoxColumn.Name].Value = true;
            }
        }
        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dtp.Visible = false;
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            switch (dataGridView1.Columns[e.ColumnIndex].Name)
            {
                case "dataGridViewTextBoxColumn5":
                        _Rectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true); //  
                        dtp.Size = new Size(_Rectangle.Width, _Rectangle.Height); //  
                        dtp.Location = new Point(_Rectangle.X, _Rectangle.Y); //  
                        dtp.Visible = true;
                        dtp.Focus();

                    break;
                    
                case "dataGridViewTextBoxColumn4":
                        _Rectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true); //  
                        dtp.Size = new Size(_Rectangle.Width, _Rectangle.Height); //  
                        dtp.Location = new Point(_Rectangle.X, _Rectangle.Y); //  
                        dtp.Visible = true;
                      dtp.Focus();
                    break;
                    
            }
            
        }
        private void dtp_TextChange(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell.Value = dtp.Text.ToString();
        }

        private void dataGridView1_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            dtp.Visible = false;


        }
        private void dataGridView1_ColumnWadded(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            dtp.Visible = false;
        }

        private void sculeBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Search = new Form2();
            Search.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 Search = new Form4();
            Search.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 Search = new Form5();
            Search.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 Search = new Form6();
            Search.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 Search = new Form1();
            Search.Show();
            this.Hide();
        }

        private void Iesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 Search = new Form7();
            Search.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 Search = new Form8();
            Search.Show();
            this.Hide();
        }
    }
}
