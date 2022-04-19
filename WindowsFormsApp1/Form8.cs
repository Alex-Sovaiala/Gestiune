using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet8.Facturi' table. You can move, or remove it, as needed.
            this.facturiTableAdapter.Fill(this.masterDataSet8.Facturi);
            typeof(DataGridView).InvokeMember(
            "DoubleBuffered",
            BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
            null,
            dataGridView1,
            new object[] { true });
        }


        private void enter(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    this.Validate();
                    this.facturiBindingSource.EndEdit();
                    this.facturiTableAdapter.Update(this.masterDataSet8.Facturi);
                    this.facturiTableAdapter.Fill(this.masterDataSet8.Facturi);







                    MessageBox.Show("Update successful");
                }
                else if (e.KeyData == Keys.Delete)
                {
                    this.Validate();
                    this.facturiBindingSource.EndEdit();
                    this.facturiTableAdapter.Update(this.masterDataSet8.Facturi);








                    MessageBox.Show("Update successful");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }
        private void filterDataGridView()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("Denumire like '%{0}%' AND Furnizor like '%{1}%' AND Data like '%{2}%'", textBox1.Text, textBox2.Text, textBox3.Text);
            dataGridView1.DataSource = bs;
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
            if (headerText.Equals("Cantitate"))
            {
                if (e.FormattedValue.ToString() == "")
                    return;
                int output;

                // Confirm that the cell is an integer.
                if (!int.TryParse(e.FormattedValue.ToString(), out output))
                {
                    dataGridView1.Rows[e.RowIndex].ErrorText =
                        "Cantitate trebuie sa aiba o valoare numerica";
                    e.Cancel = true;
                }
            }
            else if (headerText.Equals("PretUnitar"))
            {
                if (e.FormattedValue.ToString() == "")
                    return;
                decimal output;

                // Confirm that the cell is an integer.
                if (!decimal.TryParse(e.FormattedValue.ToString(), out output))
                {
                    dataGridView1.Rows[e.RowIndex].ErrorText =
                        "PretUnitar trebuie sa aiba o valoare numerica";
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

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 Search = new Form6();
            Search.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 Search = new Form7();
            Search.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 Search = new Form1();
            Search.Show();
            this.Hide();
        }

        private void Iesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
