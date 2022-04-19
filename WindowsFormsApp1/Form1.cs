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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form4 Search = new Form4();
            Search.Opacity = 0;
            Search.Show();
            Search.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Search = new Form2();
            Search.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 Search = new Form3();
            Search.Show();
            this.Hide();
        }



        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void Iesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 Search = new Form8();
            Search.Show();
            this.Hide();
        }

        //       private void button2_Click(object sender, EventArgs e)
        //      {
        //          Form3 Search = new Form3();
        //         Search.Show();
        //          this.Hide();
        //    }

        //     private void button3_Click(object sender, EventArgs e)
        //   {
        //     Form4 Search = new Form4();
        //     Search.Show();
        //      this.Hide();
        //  }
    }
}
