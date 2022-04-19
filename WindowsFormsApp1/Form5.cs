using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Reflection;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet61.stocuri1' table. You can move, or remove it, as needed.
            this.stocuri1TableAdapter.Fill(this.masterDataSet61.stocuri1);
            // TODO: This line of code loads data into the 'masterDataSet6.stocuri' table. You can move, or remove it, as needed.
            this.stocuriTableAdapter2.FillBy40(this.masterDataSet6.stocuri);
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("Data") )
            {
                string newValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                for (int i = 0; i < dataGridView1.RowCount-1; i++)
                {
                    dataGridView1.Rows[i].Cells[e.ColumnIndex].Value = newValue;
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("Echipa") )
            {
                string newValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    dataGridView1.Rows[i].Cells[e.ColumnIndex].Value = newValue;
                }
            }
            else if  (dataGridView1.Columns[e.ColumnIndex].Name.Equals("Beneficiar") )
                {
                    string newValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                    for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                    {
                        dataGridView1.Rows[i].Cells[e.ColumnIndex].Value = newValue;
                    }
                }
            else if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("Adresa") )
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
                Debug.WriteLine(dataGridView1.CurrentCell.ColumnIndex);
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
            
           //else if (titletext2.Equals("Data"))
          //  {
            //    foreach (DataRow row in dataGridView1.Rows)
            //    {
                    
              //  }
                 
         //   }
        }
        public void addItems(AutoCompleteStringCollection col)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                foreach (DataRow row in masterDataSet61.Tables[1].Rows)
                {

                    col.Add(Convert.ToString(row["Denumire"]));

                }
            }

        }

        private void Salvare_Click(object sender, EventArgs e)
        {

            string StrQuery;
            string StrQuery2;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["masterDB"].ConnectionString))

                {
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        conn.Open();
                        for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                        {
                            if (dataGridView1.Rows[i].Cells[1].Value != null || dataGridView1.Rows[i].Cells[3].Value != null || dataGridView1.Rows[i].Cells[2].Value != null)
                            {
                                int col1, col2, col3;
                                if(dataGridView1.Rows[i].Cells[1].Value == null)
                                    col1 = 0;
                                else col1 = int.Parse((string)dataGridView1.Rows[i].Cells[1].Value);
                                if (dataGridView1.Rows[i].Cells[2].Value == null)
                                    col2 = 0;
                                else col2 = int.Parse((string)dataGridView1.Rows[i].Cells[2].Value);
                                if (dataGridView1.Rows[i].Cells[3].Value == null)
                                    col3 = 0;
                                else col3 = int.Parse((string)dataGridView1.Rows[i].Cells[3].Value);
                                int coldiferenta = col3 - col1;

                                var lista = masterDataSet61.Tables[1].Rows.OfType<DataRow>().Select(dr => dr.Field<string>("Denumire")).ToList();

                                if (lista.Contains(dataGridView1.Rows[i].Cells[0].Value))
                                    {
                                    StrQuery2 = @"Update dbo.Stocuri set Stocuri.Cantitate = Stocuri.Cantitate + " + coldiferenta + " where Denumire Like '" + dataGridView1.Rows[i].Cells[0].Value + "'";

                                    StrQuery = @"INSERT INTO dbo.FISA VALUES (" + "'"
                                     + dataGridView1.Rows[i].Cells[0].Value + "'" + ","
                                     + col1 + ","
                                     + col2 + ","
                                     + col3 + "," + "'"
                                     + dataGridView1.Rows[i].Cells[4].Value + "'" + "," + "'"
                                     + dataGridView1.Rows[i].Cells[5].Value + "'" + "," + "'"
                                     + dataGridView1.Rows[i].Cells[6].Value + "'" + "," + "'"
                                     + dataGridView1.Rows[i].Cells[7].Value + "'" + null + ");";
                                    comm.CommandText = StrQuery;
                                comm.ExecuteNonQuery();
                                comm.CommandText = StrQuery2;
                                    comm.ExecuteNonQuery();
                                }
                                else
                                    MessageBox.Show("Denumire incorecta");
                                
                            }
                        }
                        conn.Close();
                    }
                }
            }
            catch(Exception aaa)
            {
                Console.Write("A");
            }
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

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 Search = new Form6();
            Search.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
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
