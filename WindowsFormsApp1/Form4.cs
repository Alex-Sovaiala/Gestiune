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
    public partial class Form4 : Form
    {
        DateTimePicker dtp = new DateTimePicker();
        Rectangle _Rectangle;
        public Form4()
        {
            InitializeComponent();
            dataGridView1.Controls.Add(dtp);
            dtp.Visible = false;
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.TextChanged += new EventHandler(dtp_TextChange);

           
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masini.masini' table. You can move, or remove it, as needed.
            this.masiniTableAdapter.Fill(this.masini.masini);
            this.dataGridView1.DataSource = this.masiniBindingSource;
            //  FindExpiring();

            List<DataGridViewRow> rows = dataGridView1.Rows.Cast<DataGridViewRow>().ToList();
            foreach (DataGridViewRow row in rows)
            {
                if (row.Cells[2].Value != null)
                {
                    var now = DateTime.Now;
                    var expirationDate = DateTime.ParseExact(row.Cells[2].Value.ToString(), "G", null);
                    var sevenDayBefore = expirationDate.AddDays(-7);

                    if (now > sevenDayBefore && now < expirationDate)
                    {
                        MessageBox.Show("Itp-ul expira in mai putin de 7 zile la masina "+row.Cells[0].Value);
                    }
                    else if (now > expirationDate)
                    {
                        MessageBox.Show("Itp-ul a expirat la masina " + row.Cells[0].Value);
                    }
                }

                if (row.Cells[4].Value != null)
                {
                    var now = DateTime.Now;
                    var expirationDate = DateTime.ParseExact(row.Cells[4].Value.ToString(), "G", null);
                    var sevenDayBefore = expirationDate.AddDays(-7);

                    if (now > sevenDayBefore && now < expirationDate)
                    {
                        MessageBox.Show("RCA-ul expira in mai putin de 7 zile la masina " + row.Cells[0].Value);
                    }
                    else if (now > expirationDate)
                    {
                        MessageBox.Show("RCA-ul a expirat la masina " + row.Cells[0].Value);
                    }
                }

                if (row.Cells[6].Value != null)
                {
                    var now = DateTime.Now;
                    var expirationDate = DateTime.ParseExact(row.Cells[6].Value.ToString(), "G", null);
                    var sevenDayBefore = expirationDate.AddDays(-7);

                    if (now > sevenDayBefore && now < expirationDate)
                    {
                        MessageBox.Show("Rovinieta expira in mai putin de 7 zile la masina " + row.Cells[0].Value);
                    }
                    else if (now > expirationDate)
                    {
                        MessageBox.Show("Rovinieta a expirat la masina " + row.Cells[0].Value);
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        bool  checking=false;
        public void checker()
        {
            checking = true;

            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                for (int j = 0; j < dataGridView1.Rows[i].Cells.Count; j++)
                {
                    var cellValue = dataGridView1.Rows[i].Cells[j].Value;

                    if (cellValue == null ||
                      cellValue == DBNull.Value || string.IsNullOrEmpty(cellValue.ToString()) || string.IsNullOrWhiteSpace(cellValue.ToString()))
                    {
                        checking = false;
                        return;
                    }
                }
            }
        }
        private void enter(object sender, KeyEventArgs e)
        {
            try
            {
                checker();

                if (checking == true)
                {
                    if (e.KeyData == Keys.Enter)
                    {
                        this.Validate();
                        this.masiniBindingSource.EndEdit();
                        this.masiniTableAdapter.Update(this.masini.masini);
                        this.masiniTableAdapter.Fill(this.masini.masini);






                        MessageBox.Show("Update successful");
                    }
                }
                else MessageBox.Show("Campurile nu pot fi goale");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dtp.Visible = false;
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            switch (dataGridView1.Columns[e.ColumnIndex].Name)
            {
                case "dataItpDataGridViewTextBoxColumn":
                    _Rectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true); //  
                    dtp.Size = new Size(_Rectangle.Width, _Rectangle.Height); //  
                    dtp.Location = new Point(_Rectangle.X, _Rectangle.Y); //  
                    dtp.Visible = true;
                    dtp.Focus();

                    break;

                case "dataExpirareItpDataGridViewTextBoxColumn":
                    _Rectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true); //  
                    dtp.Size = new Size(_Rectangle.Width, _Rectangle.Height); //  
                    dtp.Location = new Point(_Rectangle.X, _Rectangle.Y); //  
                    dtp.Visible = true;
                    dtp.Focus();
                    break;

                case "dataRcaDataGridViewTextBoxColumn":
                    _Rectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true); //  
                    dtp.Size = new Size(_Rectangle.Width, _Rectangle.Height); //  
                    dtp.Location = new Point(_Rectangle.X, _Rectangle.Y); //  
                    dtp.Visible = true;
                    dtp.Focus();
                    break;

                case "dataExpirareRcaDataGridViewTextBoxColumn":
                    _Rectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true); //  
                    dtp.Size = new Size(_Rectangle.Width, _Rectangle.Height); //  
                    dtp.Location = new Point(_Rectangle.X, _Rectangle.Y); //  
                    dtp.Visible = true;
                    dtp.Focus();
                    break;

                case "dataRovinietaDataGridViewTextBoxColumn":
                    _Rectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true); //  
                    dtp.Size = new Size(_Rectangle.Width, _Rectangle.Height); //  
                    dtp.Location = new Point(_Rectangle.X, _Rectangle.Y); //  
                    dtp.Visible = true;
                    dtp.Focus();
                    break;

                case "dataExpirareRovinietaDataGridViewTextBoxColumn":
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
        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            dtp.Visible = false;
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

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 Search = new Form1();
            Search.Show();
            this.Hide();
        }

        private void Iesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
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
