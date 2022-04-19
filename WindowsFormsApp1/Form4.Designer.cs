
namespace WindowsFormsApp1
{
    partial class Form4
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
            this.numarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataItpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataExpirareItpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataExpirareRcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRovinietaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataExpirareRovinietaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masiniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masini = new WindowsFormsApp1.Masini();
            this.masiniTableAdapter = new WindowsFormsApp1.MasiniTableAdapters.masiniTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Iesire = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masiniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masini)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numarDataGridViewTextBoxColumn,
            this.dataItpDataGridViewTextBoxColumn,
            this.dataExpirareItpDataGridViewTextBoxColumn,
            this.dataRcaDataGridViewTextBoxColumn,
            this.dataExpirareRcaDataGridViewTextBoxColumn,
            this.dataRovinietaDataGridViewTextBoxColumn,
            this.dataExpirareRovinietaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.masiniBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(134, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(967, 632);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            this.dataGridView1.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView1_ColumnWidthChanged);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enter);
            // 
            // numarDataGridViewTextBoxColumn
            // 
            this.numarDataGridViewTextBoxColumn.DataPropertyName = "Numar";
            this.numarDataGridViewTextBoxColumn.HeaderText = "Numar";
            this.numarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numarDataGridViewTextBoxColumn.Name = "numarDataGridViewTextBoxColumn";
            this.numarDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataItpDataGridViewTextBoxColumn
            // 
            this.dataItpDataGridViewTextBoxColumn.DataPropertyName = "DataItp";
            this.dataItpDataGridViewTextBoxColumn.HeaderText = "DataItp";
            this.dataItpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataItpDataGridViewTextBoxColumn.Name = "dataItpDataGridViewTextBoxColumn";
            this.dataItpDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataExpirareItpDataGridViewTextBoxColumn
            // 
            this.dataExpirareItpDataGridViewTextBoxColumn.DataPropertyName = "DataExpirareItp";
            this.dataExpirareItpDataGridViewTextBoxColumn.HeaderText = "DataExpirareItp";
            this.dataExpirareItpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataExpirareItpDataGridViewTextBoxColumn.Name = "dataExpirareItpDataGridViewTextBoxColumn";
            this.dataExpirareItpDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataRcaDataGridViewTextBoxColumn
            // 
            this.dataRcaDataGridViewTextBoxColumn.DataPropertyName = "DataRca";
            this.dataRcaDataGridViewTextBoxColumn.HeaderText = "DataRca";
            this.dataRcaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataRcaDataGridViewTextBoxColumn.Name = "dataRcaDataGridViewTextBoxColumn";
            this.dataRcaDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataExpirareRcaDataGridViewTextBoxColumn
            // 
            this.dataExpirareRcaDataGridViewTextBoxColumn.DataPropertyName = "DataExpirareRca";
            this.dataExpirareRcaDataGridViewTextBoxColumn.HeaderText = "DataExpirareRca";
            this.dataExpirareRcaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataExpirareRcaDataGridViewTextBoxColumn.Name = "dataExpirareRcaDataGridViewTextBoxColumn";
            this.dataExpirareRcaDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataRovinietaDataGridViewTextBoxColumn
            // 
            this.dataRovinietaDataGridViewTextBoxColumn.DataPropertyName = "DataRovinieta";
            this.dataRovinietaDataGridViewTextBoxColumn.HeaderText = "DataRovinieta";
            this.dataRovinietaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataRovinietaDataGridViewTextBoxColumn.Name = "dataRovinietaDataGridViewTextBoxColumn";
            this.dataRovinietaDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataExpirareRovinietaDataGridViewTextBoxColumn
            // 
            this.dataExpirareRovinietaDataGridViewTextBoxColumn.DataPropertyName = "DataExpirareRovinieta";
            this.dataExpirareRovinietaDataGridViewTextBoxColumn.HeaderText = "DataExpirareRovinieta";
            this.dataExpirareRovinietaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataExpirareRovinietaDataGridViewTextBoxColumn.Name = "dataExpirareRovinietaDataGridViewTextBoxColumn";
            this.dataExpirareRovinietaDataGridViewTextBoxColumn.Width = 150;
            // 
            // masiniBindingSource
            // 
            this.masiniBindingSource.DataMember = "masini";
            this.masiniBindingSource.DataSource = this.masini;
            // 
            // masini
            // 
            this.masini.DataSetName = "Masini";
            this.masini.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // masiniTableAdapter
            // 
            this.masiniTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 54);
            this.button1.TabIndex = 2;
            this.button1.TabStop = false;
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
            this.button3.TabStop = false;
            this.button3.Text = "Scule";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SkyBlue;
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(12, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 54);
            this.button2.TabIndex = 9;
            this.button2.TabStop = false;
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
            this.button5.TabStop = false;
            this.button5.Text = "Istoric Fise";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SkyBlue;
            this.button4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(12, 639);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 54);
            this.button4.TabIndex = 13;
            this.button4.TabStop = false;
            this.button4.Text = "Inapoi";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Iesire
            // 
            this.Iesire.BackColor = System.Drawing.Color.SkyBlue;
            this.Iesire.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Iesire.Location = new System.Drawing.Point(12, 699);
            this.Iesire.Name = "Iesire";
            this.Iesire.Size = new System.Drawing.Size(106, 54);
            this.Iesire.TabIndex = 14;
            this.Iesire.TabStop = false;
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
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.Iesire);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(128, 890);
            this.panel3.TabIndex = 19;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.SkyBlue;
            this.button7.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button7.Location = new System.Drawing.Point(12, 312);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(106, 54);
            this.button7.TabIndex = 23;
            this.button7.TabStop = false;
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
            this.button6.TabIndex = 22;
            this.button6.TabStop = false;
            this.button6.Text = "Adaugare Facturi";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 765);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.Text = "Form4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masiniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masini)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Masini masini;
        private System.Windows.Forms.BindingSource masiniBindingSource;
        private MasiniTableAdapters.masiniTableAdapter masiniTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Iesire;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn numarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataItpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataExpirareItpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataExpirareRcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRovinietaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataExpirareRovinietaDataGridViewTextBoxColumn;
    }
}