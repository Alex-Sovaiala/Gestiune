using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet41.stocuri1' table. You can move, or remove it, as needed.
            this.stocuri1TableAdapter.Fill(this.masterDataSet41.stocuri1);
            // TODO: This line of code loads data into the 'masterDataSet4.stocuri' table. You can move, or remove it, as needed.
            this.stocuriTableAdapter.Fill(this.masterDataSet4.stocuri);

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
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("Furnizor"))
            {
                string newValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    dataGridView1.Rows[i].Cells[e.ColumnIndex].Value = newValue;
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("Data"))
            {
                string newValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    dataGridView1.Rows[i].Cells[e.ColumnIndex].Value = newValue;
                }
            }

        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            string titleText = dataGridView1.Columns[0].HeaderText;
            //   string titletext2 = dataGridView1.Columns[4].

            if (titleText.Equals("Denumire") && dataGridView1.CurrentCell.ColumnIndex == 0)
            {

                TextBox autoText = e.Control as TextBox;
                if (autoText != null)
                {
                    autoText.AutoCompleteMode = AutoCompleteMode.Suggest;
                    autoText.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
                    addItems(DataCollection);
                    autoText.AutoCompleteCustomSource = DataCollection;
                }
            }
            else
            {
                TextBox autoText = e.Control as TextBox;
                if (autoText != null)
                {
                    autoText.AutoCompleteMode = AutoCompleteMode.Suggest;
                    autoText.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
                    autoText.AutoCompleteCustomSource = null;
                }
            }

        }

        public void addItems(AutoCompleteStringCollection col)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                foreach (DataRow row in masterDataSet41.Tables[1].Rows)
                {

                    col.Add(Convert.ToString(row["Denumire"]));

                }
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string StrQuery;
            string StrQuery2;
            decimal valoare_fara_tva;
            decimal tva;
            decimal valoare_cu_tva;
            int cantitateprincipala;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["masterDB"].ConnectionString))

                {
                    using (SqlCommand comm = new SqlCommand())
                    {




                        comm.Connection = conn;
                        conn.Open();
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            valoare_fara_tva = int.Parse((string)dataGridView1.Rows[i].Cells[1].Value) * decimal.Parse((string)dataGridView1.Rows[i].Cells[2].Value); ;
                            tva = valoare_fara_tva * 1.19m - valoare_fara_tva;
                            valoare_cu_tva = valoare_fara_tva - 1.19m;
                            cantitateprincipala = int.Parse((string)dataGridView1.Rows[i].Cells[1].Value);
                            StrQuery2 = @"Update dbo.Stocuri set Stocuri.Cantitate = Stocuri.Cantitate + " + cantitateprincipala + " where Denumire Like '" + dataGridView1.Rows[i].Cells[0].Value + "'";
                            StrQuery = @"INSERT INTO dbo.Facturi VALUES (" + "'"
                                 + dataGridView1.Rows[i].Cells[0].Value + "'" + ","
                                 + dataGridView1.Rows[i].Cells[1].Value + ","
                                 + dataGridView1.Rows[i].Cells[2].Value + ","
                                 + valoare_fara_tva + "," 
                                 + tva +"," + 
                                 + valoare_cu_tva + "," + "'" 
                                 + dataGridView1.Rows[i].Cells[6].Value + "'" + "," + "'"
                                 + dataGridView1.Rows[i].Cells[7].Value + "'" + null + ");";
                                comm.CommandText = StrQuery;
                            comm.ExecuteNonQuery();
                            comm.CommandText = StrQuery2;

                            comm.ExecuteNonQuery();

                        }
                        conn.Close();
                    }
                }
            }
            catch (Exception aaa)
            {
                Console.Write("A");
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

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 Search = new Form6();
            Search.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form8 Search = new Form8();
            Search.Show();
            this.Hide();
        }

        private void Iesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 Search = new Form1();
            Search.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
