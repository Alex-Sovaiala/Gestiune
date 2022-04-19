using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Reflection;

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet7.FISA' table. You can move, or remove it, as needed.
            this.fISATableAdapter.Fill(this.masterDataSet7.FISA);
          
            typeof(DataGridView).InvokeMember(
           "DoubleBuffered",
           BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
           null,
           dataGridView1,
           new object[] { true });

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellValidating(object sender,
       DataGridViewCellValidatingEventArgs e)
        {
            string headerText =
                dataGridView1.Columns[e.ColumnIndex].HeaderText;

            // Abort validation if cell is not in the Age column.
            if (headerText.Equals("Buc_Eliberate"))
            {
                if (e.FormattedValue.ToString() == "")
                    return;
                int output;

                // Confirm that the cell is an integer.
                if (!int.TryParse(e.FormattedValue.ToString(), out output))
                {
                    dataGridView1.Rows[e.RowIndex].ErrorText =
                        "Buc_eliberate trebuie sa aiba o valoare numerica";
                    e.Cancel = true;
                }
            }
            else if (headerText.Equals("Buc_Folosite"))
            {
                if (e.FormattedValue.ToString() == "")
                    return;
                int output;

                // Confirm that the cell is an integer.
                if (!int.TryParse(e.FormattedValue.ToString(), out output))
                {
                    dataGridView1.Rows[e.RowIndex].ErrorText =
                        "Buc_Folosite trebuie sa aiba o valoare numerica";
                    e.Cancel = true;
                }
            }
            else if (headerText.Equals("Buc_Retur"))
            {
                if (e.FormattedValue.ToString() == "")
                    return;
                int output;

                // Confirm that the cell is an integer.
                if (!int.TryParse(e.FormattedValue.ToString(), out output))
                {
                    dataGridView1.Rows[e.RowIndex].ErrorText =
                        "Buc_Retur trebuie sa aiba o valoare numerica";
                    e.Cancel = true;
                }
            }
            else return;


        }

        void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Clear the row error in case the user presses ESC.   
            dataGridView1.Rows[e.RowIndex].ErrorText = String.Empty;
        }
        private void enter(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    this.Validate();
                    this.fISABindingSource.EndEdit();
                    this.fISATableAdapter.Update(this.masterDataSet7.FISA);
                    this.fISATableAdapter.Fill(this.masterDataSet7.FISA);







                    MessageBox.Show("Update successful");
                }
                else if (e.KeyData == Keys.Delete)
                {
                    this.Validate();
                    this.fISABindingSource.EndEdit();
                    this.fISATableAdapter.Update(this.masterDataSet7.FISA);








                    MessageBox.Show("Update successful");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Search = new Form2();
            Search.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 Search = new Form3();
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

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 Search = new Form1();
            Search.Show();
            this.Hide();
        }

        private void Iesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void filterDataGridView()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;

            bs.Filter = string.Format("Beneficiar like '%{0}%' AND Adresa like '%{1}%' AND Data like '%{2}%' AND Echipa like '%{3}%'", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            dataGridView1.DataSource = bs;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = string.Concat(textBox1.Text.Where(char.IsLetterOrDigit));
            filterDataGridView();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = string.Concat(textBox2.Text.Where(char.IsLetterOrDigit));
            filterDataGridView();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = string.Concat(textBox3.Text.Where(char.IsLetterOrDigit));
            filterDataGridView();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = string.Concat(textBox4.Text.Where(char.IsLetterOrDigit));
            filterDataGridView();
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
