
namespace WindowsFormsApp1
{
    partial class Form8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.facturiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet8 = new WindowsFormsApp1.masterDataSet8();
            this.facturiTableAdapter = new WindowsFormsApp1.masterDataSet8TableAdapters.FacturiTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Iesire = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.denumireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretUnitarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoarefaraTVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoarecuTVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.furnizorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet8)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.denumireDataGridViewTextBoxColumn,
            this.cantitateDataGridViewTextBoxColumn,
            this.pretUnitarDataGridViewTextBoxColumn,
            this.valoarefaraTVADataGridViewTextBoxColumn,
            this.tVADataGridViewTextBoxColumn,
            this.valoarecuTVADataGridViewTextBoxColumn,
            this.furnizorDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.facturiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(134, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1140, 632);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enter);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // facturiBindingSource
            // 
            this.facturiBindingSource.DataMember = "Facturi";
            this.facturiBindingSource.DataSource = this.masterDataSet8;
            // 
            // masterDataSet8
            // 
            this.masterDataSet8.DataSetName = "masterDataSet8";
            this.masterDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facturiTableAdapter
            // 
            this.facturiTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Iesire);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 968);
            this.panel1.TabIndex = 18;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.SkyBlue;
            this.button8.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button8.Location = new System.Drawing.Point(11, 639);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(106, 54);
            this.button8.TabIndex = 11;
            this.button8.Text = "Inapoi";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.SkyBlue;
            this.button6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(11, 312);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 54);
            this.button6.TabIndex = 10;
            this.button6.Text = "Facturi";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(11, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Materiale";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SkyBlue;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(11, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 54);
            this.button3.TabIndex = 6;
            this.button3.Text = "Scule";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SkyBlue;
            this.button4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(11, 132);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 54);
            this.button4.TabIndex = 3;
            this.button4.Text = "Masini";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SkyBlue;
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(11, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 54);
            this.button2.TabIndex = 7;
            this.button2.Text = "Fisa Materiale";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Iesire
            // 
            this.Iesire.BackColor = System.Drawing.Color.SkyBlue;
            this.Iesire.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Iesire.Location = new System.Drawing.Point(11, 699);
            this.Iesire.Name = "Iesire";
            this.Iesire.Size = new System.Drawing.Size(106, 54);
            this.Iesire.TabIndex = 9;
            this.Iesire.Text = "Iesire";
            this.Iesire.UseVisualStyleBackColor = false;
            this.Iesire.Click += new System.EventHandler(this.Iesire_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SkyBlue;
            this.button5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(11, 252);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 54);
            this.button5.TabIndex = 8;
            this.button5.Text = "Istoric Fise";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.flowLayoutPanel1);
            this.panel5.Location = new System.Drawing.Point(546, 639);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(591, 100);
            this.panel5.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Location = new System.Drawing.Point(152, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 64);
            this.panel2.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(17, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 28);
            this.label3.TabIndex = 23;
            this.label3.Text = "Furnizor";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.textBox2.Location = new System.Drawing.Point(4, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 27);
            this.textBox2.TabIndex = 15;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Location = new System.Drawing.Point(299, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(141, 64);
            this.panel3.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(36, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 28);
            this.label4.TabIndex = 24;
            this.label4.Text = "Data";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.textBox3.Location = new System.Drawing.Point(3, 31);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(135, 27);
            this.textBox3.TabIndex = 16;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.textBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(141, 64);
            this.flowLayoutPanel1.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "Denumire";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(3, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 27);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // denumireDataGridViewTextBoxColumn
            // 
            this.denumireDataGridViewTextBoxColumn.DataPropertyName = "Denumire";
            this.denumireDataGridViewTextBoxColumn.FillWeight = 163F;
            this.denumireDataGridViewTextBoxColumn.HeaderText = "Denumire";
            this.denumireDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.denumireDataGridViewTextBoxColumn.Name = "denumireDataGridViewTextBoxColumn";
            this.denumireDataGridViewTextBoxColumn.Width = 163;
            // 
            // cantitateDataGridViewTextBoxColumn
            // 
            this.cantitateDataGridViewTextBoxColumn.DataPropertyName = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.HeaderText = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantitateDataGridViewTextBoxColumn.Name = "cantitateDataGridViewTextBoxColumn";
            // 
            // pretUnitarDataGridViewTextBoxColumn
            // 
            this.pretUnitarDataGridViewTextBoxColumn.DataPropertyName = "PretUnitar";
            this.pretUnitarDataGridViewTextBoxColumn.HeaderText = "PretUnitar";
            this.pretUnitarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pretUnitarDataGridViewTextBoxColumn.Name = "pretUnitarDataGridViewTextBoxColumn";
            // 
            // valoarefaraTVADataGridViewTextBoxColumn
            // 
            this.valoarefaraTVADataGridViewTextBoxColumn.DataPropertyName = "Valoare_fara_TVA";
            this.valoarefaraTVADataGridViewTextBoxColumn.HeaderText = "Valoare_fara_TVA";
            this.valoarefaraTVADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valoarefaraTVADataGridViewTextBoxColumn.Name = "valoarefaraTVADataGridViewTextBoxColumn";
            this.valoarefaraTVADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tVADataGridViewTextBoxColumn
            // 
            this.tVADataGridViewTextBoxColumn.DataPropertyName = "TVA";
            this.tVADataGridViewTextBoxColumn.HeaderText = "TVA";
            this.tVADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tVADataGridViewTextBoxColumn.Name = "tVADataGridViewTextBoxColumn";
            this.tVADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valoarecuTVADataGridViewTextBoxColumn
            // 
            this.valoarecuTVADataGridViewTextBoxColumn.DataPropertyName = "Valoare_cu_TVA";
            this.valoarecuTVADataGridViewTextBoxColumn.HeaderText = "Valoare_cu_TVA";
            this.valoarecuTVADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valoarecuTVADataGridViewTextBoxColumn.Name = "valoarecuTVADataGridViewTextBoxColumn";
            this.valoarecuTVADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // furnizorDataGridViewTextBoxColumn
            // 
            this.furnizorDataGridViewTextBoxColumn.DataPropertyName = "Furnizor";
            this.furnizorDataGridViewTextBoxColumn.HeaderText = "Furnizor";
            this.furnizorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.furnizorDataGridViewTextBoxColumn.Name = "furnizorDataGridViewTextBoxColumn";
            this.furnizorDataGridViewTextBoxColumn.Width = 266;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.Width = 150;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            this.iDDataGridViewTextBoxColumn.Width = 111;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 765);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form8";
            this.Text = "Form8";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form8_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enter);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet8)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private masterDataSet8 masterDataSet8;
        private System.Windows.Forms.BindingSource facturiBindingSource;
        private masterDataSet8TableAdapters.FacturiTableAdapter facturiTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Iesire;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretUnitarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoarefaraTVADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tVADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoarecuTVADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn furnizorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
    }
}