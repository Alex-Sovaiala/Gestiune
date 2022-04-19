
namespace WindowsFormsApp1
{
    partial class Form6
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
            this.fISABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet7 = new WindowsFormsApp1.masterDataSet7();
            this.fISATableAdapter = new WindowsFormsApp1.masterDataSet7TableAdapters.FISATableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Iesire = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.denumireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bucEliberateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bucFolositeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bucReturDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beneficiarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.echipaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fISABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet7)).BeginInit();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.denumireDataGridViewTextBoxColumn,
            this.bucEliberateDataGridViewTextBoxColumn,
            this.bucFolositeDataGridViewTextBoxColumn,
            this.bucReturDataGridViewTextBoxColumn,
            this.beneficiarDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.echipaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fISABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(134, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1140, 632);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enter);
            // 
            // fISABindingSource
            // 
            this.fISABindingSource.DataMember = "FISA";
            this.fISABindingSource.DataSource = this.masterDataSet7;
            // 
            // masterDataSet7
            // 
            this.masterDataSet7.DataSetName = "masterDataSet7";
            this.masterDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fISATableAdapter
            // 
            this.fISATableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 54);
            this.button1.TabIndex = 4;
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
            this.button3.Location = new System.Drawing.Point(12, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 54);
            this.button3.TabIndex = 8;
            this.button3.Text = "Scule";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SkyBlue;
            this.button4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(12, 132);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 54);
            this.button4.TabIndex = 9;
            this.button4.Text = "Masini";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SkyBlue;
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(12, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 54);
            this.button2.TabIndex = 10;
            this.button2.Text = "Fisa Materiale";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.SkyBlue;
            this.button6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(12, 639);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 54);
            this.button6.TabIndex = 12;
            this.button6.Text = "Inapoi";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Iesire
            // 
            this.Iesire.BackColor = System.Drawing.Color.SkyBlue;
            this.Iesire.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Iesire.Location = new System.Drawing.Point(12, 699);
            this.Iesire.Name = "Iesire";
            this.Iesire.Size = new System.Drawing.Size(106, 54);
            this.Iesire.TabIndex = 13;
            this.Iesire.Text = "Iesire";
            this.Iesire.UseVisualStyleBackColor = false;
            this.Iesire.Click += new System.EventHandler(this.Iesire_Click);
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
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.textBox2.Location = new System.Drawing.Point(4, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 27);
            this.textBox2.TabIndex = 15;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
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
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.textBox4.Location = new System.Drawing.Point(3, 31);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(135, 27);
            this.textBox4.TabIndex = 17;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.SlateGray;
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.Iesire);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(128, 890);
            this.panel3.TabIndex = 21;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.SkyBlue;
            this.button7.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button7.Location = new System.Drawing.Point(12, 312);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(106, 54);
            this.button7.TabIndex = 30;
            this.button7.TabStop = false;
            this.button7.Text = "Istoric Facturi";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SkyBlue;
            this.button5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(12, 252);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 54);
            this.button5.TabIndex = 29;
            this.button5.TabStop = false;
            this.button5.Text = "Adaugare Facturi";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "Beneficiar";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(25, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 28);
            this.label3.TabIndex = 23;
            this.label3.Text = "Adresa";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(25, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 28);
            this.label5.TabIndex = 25;
            this.label5.Text = "Echipa";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(152, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 64);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Location = new System.Drawing.Point(299, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 64);
            this.panel2.TabIndex = 28;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.textBox4);
            this.panel4.Location = new System.Drawing.Point(446, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(141, 64);
            this.panel4.TabIndex = 28;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.flowLayoutPanel1);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Location = new System.Drawing.Point(418, 653);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(591, 100);
            this.panel5.TabIndex = 29;
            // 
            // denumireDataGridViewTextBoxColumn
            // 
            this.denumireDataGridViewTextBoxColumn.DataPropertyName = "Denumire";
            this.denumireDataGridViewTextBoxColumn.HeaderText = "Denumire";
            this.denumireDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.denumireDataGridViewTextBoxColumn.Name = "denumireDataGridViewTextBoxColumn";
            this.denumireDataGridViewTextBoxColumn.Width = 163;
            // 
            // bucEliberateDataGridViewTextBoxColumn
            // 
            this.bucEliberateDataGridViewTextBoxColumn.DataPropertyName = "Buc_Eliberate";
            this.bucEliberateDataGridViewTextBoxColumn.HeaderText = "Buc_Eliberate";
            this.bucEliberateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bucEliberateDataGridViewTextBoxColumn.Name = "bucEliberateDataGridViewTextBoxColumn";
            // 
            // bucFolositeDataGridViewTextBoxColumn
            // 
            this.bucFolositeDataGridViewTextBoxColumn.DataPropertyName = "Buc_Folosite";
            this.bucFolositeDataGridViewTextBoxColumn.HeaderText = "Buc_Folosite";
            this.bucFolositeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bucFolositeDataGridViewTextBoxColumn.Name = "bucFolositeDataGridViewTextBoxColumn";
            // 
            // bucReturDataGridViewTextBoxColumn
            // 
            this.bucReturDataGridViewTextBoxColumn.DataPropertyName = "Buc_Retur";
            this.bucReturDataGridViewTextBoxColumn.HeaderText = "Buc_Retur";
            this.bucReturDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bucReturDataGridViewTextBoxColumn.Name = "bucReturDataGridViewTextBoxColumn";
            // 
            // beneficiarDataGridViewTextBoxColumn
            // 
            this.beneficiarDataGridViewTextBoxColumn.DataPropertyName = "Beneficiar";
            this.beneficiarDataGridViewTextBoxColumn.HeaderText = "Beneficiar";
            this.beneficiarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.beneficiarDataGridViewTextBoxColumn.Name = "beneficiarDataGridViewTextBoxColumn";
            this.beneficiarDataGridViewTextBoxColumn.Width = 150;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.Width = 266;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // echipaDataGridViewTextBoxColumn
            // 
            this.echipaDataGridViewTextBoxColumn.DataPropertyName = "Echipa";
            this.echipaDataGridViewTextBoxColumn.HeaderText = "Echipa";
            this.echipaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.echipaDataGridViewTextBoxColumn.Name = "echipaDataGridViewTextBoxColumn";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 765);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form6";
            this.Text = "Form6";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fISABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet7)).EndInit();
            this.panel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private masterDataSet7 masterDataSet7;
        private System.Windows.Forms.BindingSource fISABindingSource;
        private masterDataSet7TableAdapters.FISATableAdapter fISATableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button Iesire;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bucEliberateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bucFolositeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bucReturDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beneficiarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn echipaDataGridViewTextBoxColumn;
    }
}