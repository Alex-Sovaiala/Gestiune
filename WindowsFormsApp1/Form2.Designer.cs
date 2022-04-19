
namespace WindowsFormsApp1
{
    partial class Form2
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
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stocuriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new WindowsFormsApp1.masterDataSet();
            this.stocuriBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stocuriTableAdapter = new WindowsFormsApp1.masterDataSetTableAdapters.StocuriTableAdapter();
            this.stocuriBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.stocuriBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.stocuriBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.stocuriBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.stocuri1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stocuri1TableAdapter = new WindowsFormsApp1.masterDataSetTableAdapters.Stocuri1TableAdapter();
            this.stocuri1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stocuri1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.stocuriBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Iesire = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocuriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocuriBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocuriBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocuriBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocuriBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocuriBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocuri1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocuri1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocuri1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocuriBindingSource6)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.denumireDataGridViewTextBoxColumn,
            this.cantitateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stocuriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(141, 19);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(433, 632);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enter);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.FillWeight = 76.14214F;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // denumireDataGridViewTextBoxColumn
            // 
            this.denumireDataGridViewTextBoxColumn.DataPropertyName = "Denumire";
            this.denumireDataGridViewTextBoxColumn.FillWeight = 133.2271F;
            this.denumireDataGridViewTextBoxColumn.HeaderText = "Denumire";
            this.denumireDataGridViewTextBoxColumn.Name = "denumireDataGridViewTextBoxColumn";
            // 
            // cantitateDataGridViewTextBoxColumn
            // 
            this.cantitateDataGridViewTextBoxColumn.DataPropertyName = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.FillWeight = 90.63071F;
            this.cantitateDataGridViewTextBoxColumn.HeaderText = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.Name = "cantitateDataGridViewTextBoxColumn";
            this.cantitateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // stocuriBindingSource
            // 
            this.stocuriBindingSource.DataMember = "Stocuri";
            this.stocuriBindingSource.DataSource = this.masterDataSetBindingSource;
            this.stocuriBindingSource.CurrentChanged += new System.EventHandler(this.stocuriBindingSource_CurrentChanged);
            // 
            // masterDataSetBindingSource
            // 
            this.masterDataSetBindingSource.DataSource = this.masterDataSet;
            this.masterDataSetBindingSource.Position = 0;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stocuriBindingSource1
            // 
            this.stocuriBindingSource1.DataMember = "Stocuri";
            this.stocuriBindingSource1.DataSource = this.masterDataSetBindingSource;
            // 
            // stocuriTableAdapter
            // 
            this.stocuriTableAdapter.ClearBeforeFill = true;
            // 
            // stocuriBindingSource2
            // 
            this.stocuriBindingSource2.DataMember = "Stocuri";
            this.stocuriBindingSource2.DataSource = this.masterDataSetBindingSource;
            // 
            // stocuriBindingSource3
            // 
            this.stocuriBindingSource3.DataMember = "Stocuri";
            this.stocuriBindingSource3.DataSource = this.masterDataSetBindingSource;
            // 
            // stocuriBindingSource4
            // 
            this.stocuriBindingSource4.DataMember = "Stocuri";
            this.stocuriBindingSource4.DataSource = this.masterDataSetBindingSource;
            // 
            // stocuriBindingSource5
            // 
            this.stocuriBindingSource5.DataMember = "Stocuri";
            this.stocuriBindingSource5.DataSource = this.masterDataSetBindingSource;
            // 
            // stocuri1BindingSource
            // 
            this.stocuri1BindingSource.DataMember = "Stocuri1";
            this.stocuri1BindingSource.DataSource = this.masterDataSet;
            // 
            // stocuri1TableAdapter
            // 
            this.stocuri1TableAdapter.ClearBeforeFill = true;
            // 
            // stocuri1BindingSource1
            // 
            this.stocuri1BindingSource1.DataMember = "Stocuri1";
            this.stocuri1BindingSource1.DataSource = this.masterDataSetBindingSource;
            // 
            // stocuri1BindingSource2
            // 
            this.stocuri1BindingSource2.DataMember = "Stocuri1";
            this.stocuri1BindingSource2.DataSource = this.masterDataSetBindingSource;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SkyBlue;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 54);
            this.button3.TabIndex = 7;
            this.button3.Text = "Scule";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SkyBlue;
            this.button4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(12, 72);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 54);
            this.button4.TabIndex = 8;
            this.button4.Text = "Masini";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SkyBlue;
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(12, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 54);
            this.button2.TabIndex = 9;
            this.button2.Text = "Fisa Materiale";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SkyBlue;
            this.button5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(12, 192);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 54);
            this.button5.TabIndex = 10;
            this.button5.Text = "Istoric Fise";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(12, 639);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 54);
            this.button1.TabIndex = 11;
            this.button1.Text = "Inapoi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Iesire
            // 
            this.Iesire.BackColor = System.Drawing.Color.SkyBlue;
            this.Iesire.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Iesire.Location = new System.Drawing.Point(12, 699);
            this.Iesire.Name = "Iesire";
            this.Iesire.Size = new System.Drawing.Size(106, 54);
            this.Iesire.TabIndex = 12;
            this.Iesire.Text = "Iesire";
            this.Iesire.UseVisualStyleBackColor = false;
            this.Iesire.Click += new System.EventHandler(this.Iesire_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.SlateGray;
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.Iesire);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(128, 765);
            this.panel3.TabIndex = 17;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.SkyBlue;
            this.button7.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button7.Location = new System.Drawing.Point(12, 312);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(106, 54);
            this.button7.TabIndex = 19;
            this.button7.Text = "Istoric Facturi";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.SkyBlue;
            this.button6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(12, 252);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 54);
            this.button6.TabIndex = 18;
            this.button6.Text = "Adaugare Facturi";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(627, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Cautare";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(596, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 27);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 765);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocuriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocuriBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocuriBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocuriBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocuriBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocuriBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocuri1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocuri1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocuri1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocuriBindingSource6)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource masterDataSetBindingSource;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource stocuriBindingSource;
        private masterDataSetTableAdapters.StocuriTableAdapter stocuriTableAdapter;
        private System.Windows.Forms.BindingSource stocuriBindingSource1;
        private System.Windows.Forms.BindingSource stocuriBindingSource2;
        private System.Windows.Forms.BindingSource stocuriBindingSource3;
        private System.Windows.Forms.BindingSource stocuriBindingSource4;
        private System.Windows.Forms.BindingSource stocuriBindingSource5;
        private System.Windows.Forms.BindingSource stocuri1BindingSource;
        private masterDataSetTableAdapters.Stocuri1TableAdapter stocuri1TableAdapter;
        private System.Windows.Forms.BindingSource stocuri1BindingSource1;
        private System.Windows.Forms.BindingSource stocuri1BindingSource2;
        private System.Windows.Forms.BindingSource stocuriBindingSource6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Iesire;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}