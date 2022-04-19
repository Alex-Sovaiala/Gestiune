using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.Stocuri' table. You can move, or remove it, as needed.
            this.stocuriTableAdapter.Fill(this.masterDataSet.Stocuri);
            // this.comboBox1.DataSource = this.masterDataSet.Stocuri1;
            this.dataGridView1.DataSource = this.stocuriBindingSource;


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
            else return;


        }

        void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Clear the row error in case the user presses ESC.   
            dataGridView1.Rows[e.RowIndex].ErrorText = String.Empty;
        }
        private void updatetabel(object sender, EventArgs e)
        {

        }

        private void enter(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    this.Validate();
                    this.stocuriBindingSource.EndEdit();
                    this.stocuriTableAdapter.Update(this.masterDataSet.Stocuri);
                    this.stocuriTableAdapter.Fill(this.masterDataSet.Stocuri);







                    MessageBox.Show("Update successful");
                }
                else if (e.KeyData == Keys.Delete)
                {
                    this.Validate();
                    this.stocuriBindingSource.EndEdit();
                    this.stocuriTableAdapter.Update(this.masterDataSet.Stocuri);








                    MessageBox.Show("Update successful");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.stocuriTableAdapter.Fill(this.masterDataSet.Stocuri);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void filltipdataToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.stocuri1TableAdapter.Filltipdata(this.masterDataSet.Stocuri1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {


        }



        private void fillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
 

        }

        private void stocuriBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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

        private void Iesire_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Search = new Form1();
            Search.Show();
            this.Hide();
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

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            BindingSource test = new BindingSource();
            test.DataSource = dataGridView1.DataSource;

            textBox1.Text = string.Concat(textBox1.Text.Where(char.IsLetterOrDigit));

            test.Filter = string.Format("Denumire LIKE '%{0}%'", textBox1.Text);

        }
    }
}
