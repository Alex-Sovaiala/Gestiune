
namespace WindowsFormsApp1
{
    partial class Form7
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Iesire = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stocuriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet4 = new WindowsFormsApp1.masterDataSet4();
            this.button7 = new System.Windows.Forms.Button();
            this.stocuriTableAdapter = new WindowsFormsApp1.masterDataSet4TableAdapters.stocuriTableAdapter();
            this.masterDataSet41 = new WindowsFormsApp1.masterDataSet4();
            this.stocuri1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stocuri1TableAdapter = new WindowsFormsApp1.masterDataSet4TableAdapters.stocuri1TableAdapter();
            this.denumireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantitate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PretUnitar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valoare_fara_TVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valoare_cu_TVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Furnizor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocuriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocuri1BindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(128, 929);
            this.panel1.TabIndex = 17;
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
            this.button6.Text = "Istoric Facturi";
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.denumireDataGridViewTextBoxColumn,
            this.Cantitate,
            this.PretUnitar,
            this.Valoare_fara_TVA,
            this.TVA,
            this.Valoare_cu_TVA,
            this.Furnizor,
            this.Data});
            this.dataGridView1.DataSource = this.stocuriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(134, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1140, 632);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // stocuriBindingSource
            // 
            this.stocuriBindingSource.DataMember = "stocuri";
            this.stocuriBindingSource.DataSource = this.masterDataSet4;
            // 
            // masterDataSet4
            // 
            this.masterDataSet4.DataSetName = "masterDataSet4";
            this.masterDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(134, 644);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 19;
            this.button7.Text = "Salvare";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // stocuriTableAdapter
            // 
            this.stocuriTableAdapter.ClearBeforeFill = true;
            // 
            // masterDataSet41
            // 
            this.masterDataSet41.DataSetName = "masterDataSet4";
            this.masterDataSet41.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stocuri1BindingSource
            // 
            this.stocuri1BindingSource.DataMember = "stocuri1";
            this.stocuri1BindingSource.DataSource = this.masterDataSet41;
            // 
            // stocuri1TableAdapter
            // 
            this.stocuri1TableAdapter.ClearBeforeFill = true;
            // 
            // denumireDataGridViewTextBoxColumn
            // 
            this.denumireDataGridViewTextBoxColumn.DataPropertyName = "Denumire";
            this.denumireDataGridViewTextBoxColumn.HeaderText = "Denumire";
            this.denumireDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.denumireDataGridViewTextBoxColumn.Name = "denumireDataGridViewTextBoxColumn";
            this.denumireDataGridViewTextBoxColumn.Width = 163;
            // 
            // Cantitate
            // 
            this.Cantitate.HeaderText = "Cantitate";
            this.Cantitate.MinimumWidth = 6;
            this.Cantitate.Name = "Cantitate";
            // 
            // PretUnitar
            // 
            this.PretUnitar.HeaderText = "PretUnitar";
            this.PretUnitar.MinimumWidth = 6;
            this.PretUnitar.Name = "PretUnitar";
            // 
            // Valoare_fara_TVA
            // 
            this.Valoare_fara_TVA.HeaderText = "Valoare_fara_TVA";
            this.Valoare_fara_TVA.MinimumWidth = 6;
            this.Valoare_fara_TVA.Name = "Valoare_fara_TVA";
            this.Valoare_fara_TVA.ReadOnly = true;
            // 
            // TVA
            // 
            this.TVA.HeaderText = "TVA";
            this.TVA.MinimumWidth = 6;
            this.TVA.Name = "TVA";
            this.TVA.ReadOnly = true;
            // 
            // Valoare_cu_TVA
            // 
            this.Valoare_cu_TVA.HeaderText = "Valoare_cu_TVA";
            this.Valoare_cu_TVA.MinimumWidth = 6;
            this.Valoare_cu_TVA.Name = "Valoare_cu_TVA";
            this.Valoare_cu_TVA.ReadOnly = true;
            // 
            // Furnizor
            // 
            this.Furnizor.HeaderText = "Furnizor";
            this.Furnizor.MinimumWidth = 6;
            this.Furnizor.Name = "Furnizor";
            this.Furnizor.Width = 266;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.MinimumWidth = 6;
            this.Data.Name = "Data";
            this.Data.Width = 150;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 765);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form7";
            this.Text = "Form7";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form7_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocuriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocuri1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Iesire;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private masterDataSet4 masterDataSet4;
        private System.Windows.Forms.BindingSource stocuriBindingSource;
        private masterDataSet4TableAdapters.stocuriTableAdapter stocuriTableAdapter;
        private System.Windows.Forms.Button button7;
        private masterDataSet4 masterDataSet41;
        private System.Windows.Forms.BindingSource stocuri1BindingSource;
        private masterDataSet4TableAdapters.stocuri1TableAdapter stocuri1TableAdapter;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantitate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PretUnitar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valoare_fara_TVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valoare_cu_TVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Furnizor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
    }
}