namespace MojeFormy
{
    partial class Samochody
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            markaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kolorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rocznikDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            samochodBindingSource = new BindingSource(components);
            txtModel = new TextBox();
            txtMarka = new TextBox();
            label2 = new Label();
            label1 = new Label();
            colorDialog1 = new ColorDialog();
            cbKolor = new ComboBox();
            label3 = new Label();
            nmRocznik = new NumericUpDown();
            label4 = new Label();
            btnDodaj = new Button();
            btnUsun = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)samochodBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmRocznik).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { markaDataGridViewTextBoxColumn, modelDataGridViewTextBoxColumn, kolorDataGridViewTextBoxColumn, rocznikDataGridViewTextBoxColumn });
            dataGridView1.DataSource = samochodBindingSource;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1235, 307);
            dataGridView1.TabIndex = 0;
            // 
            // markaDataGridViewTextBoxColumn
            // 
            markaDataGridViewTextBoxColumn.DataPropertyName = "Marka";
            markaDataGridViewTextBoxColumn.HeaderText = "Marka";
            markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            modelDataGridViewTextBoxColumn.HeaderText = "Model";
            modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // kolorDataGridViewTextBoxColumn
            // 
            kolorDataGridViewTextBoxColumn.DataPropertyName = "Kolor";
            kolorDataGridViewTextBoxColumn.HeaderText = "Kolor";
            kolorDataGridViewTextBoxColumn.Name = "kolorDataGridViewTextBoxColumn";
            // 
            // rocznikDataGridViewTextBoxColumn
            // 
            rocznikDataGridViewTextBoxColumn.DataPropertyName = "Rocznik";
            rocznikDataGridViewTextBoxColumn.HeaderText = "Rocznik";
            rocznikDataGridViewTextBoxColumn.Name = "rocznikDataGridViewTextBoxColumn";
            // 
            // samochodBindingSource
            // 
            samochodBindingSource.DataSource = typeof(Samochod);
            // 
            // txtModel
            // 
            txtModel.DataBindings.Add(new Binding("Text", samochodBindingSource, "Model", true));
            txtModel.Location = new Point(92, 418);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(254, 23);
            txtModel.TabIndex = 8;
            // 
            // txtMarka
            // 
            txtMarka.DataBindings.Add(new Binding("Text", samochodBindingSource, "Marka", true));
            txtMarka.Location = new Point(92, 363);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(254, 23);
            txtMarka.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(18, 420);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 6;
            label2.Text = "model";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(18, 360);
            label1.Name = "label1";
            label1.Size = new Size(54, 21);
            label1.TabIndex = 5;
            label1.Text = "marka";
            // 
            // cbKolor
            // 
            cbKolor.DataBindings.Add(new Binding("SelectedItem", samochodBindingSource, "Kolor", true));
            cbKolor.FormattingEnabled = true;
            cbKolor.Items.AddRange(new object[] { "Złoty", "Srebrny", "Zielony", "Czerwony", "Biały", "Czarny", "Niebieski" });
            cbKolor.Location = new Point(92, 476);
            cbKolor.Name = "cbKolor";
            cbKolor.Size = new Size(254, 23);
            cbKolor.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(15, 476);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 10;
            label3.Text = "kolor";
            // 
            // nmRocznik
            // 
            nmRocznik.DataBindings.Add(new Binding("Value", samochodBindingSource, "Rocznik", true));
            nmRocznik.Location = new Point(226, 533);
            nmRocznik.Maximum = new decimal(new int[] { 2026, 0, 0, 0 });
            nmRocznik.Minimum = new decimal(new int[] { 2020, 0, 0, 0 });
            nmRocznik.Name = "nmRocznik";
            nmRocznik.Size = new Size(120, 23);
            nmRocznik.TabIndex = 11;
            nmRocznik.Value = new decimal(new int[] { 2020, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(15, 535);
            label4.Name = "label4";
            label4.Size = new Size(62, 21);
            label4.TabIndex = 12;
            label4.Text = "rocznik";
            // 
            // btnDodaj
            // 
            btnDodaj.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDodaj.BackColor = Color.RoyalBlue;
            btnDodaj.Cursor = Cursors.Hand;
            btnDodaj.ForeColor = Color.White;
            btnDodaj.Location = new Point(18, 586);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(120, 41);
            btnDodaj.TabIndex = 13;
            btnDodaj.Text = "Dodaj do tabeli";
            btnDodaj.UseVisualStyleBackColor = false;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnUsun
            // 
            btnUsun.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUsun.BackColor = Color.RoyalBlue;
            btnUsun.Cursor = Cursors.Hand;
            btnUsun.ForeColor = Color.White;
            btnUsun.Location = new Point(226, 586);
            btnUsun.Name = "btnUsun";
            btnUsun.Size = new Size(120, 41);
            btnUsun.TabIndex = 14;
            btnUsun.Text = "Usuń z tabeli";
            btnUsun.UseVisualStyleBackColor = false;
            btnUsun.Click += btnUsun_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.RoyalBlue;
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = Color.White;
            button1.Location = new Point(410, 468);
            button1.Name = "button1";
            button1.Size = new Size(120, 41);
            button1.TabIndex = 15;
            button1.Text = "Wybierz kolor";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Samochody
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1259, 639);
            Controls.Add(button1);
            Controls.Add(btnUsun);
            Controls.Add(btnDodaj);
            Controls.Add(label4);
            Controls.Add(nmRocznik);
            Controls.Add(label3);
            Controls.Add(cbKolor);
            Controls.Add(txtModel);
            Controls.Add(txtMarka);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Samochody";
            Text = "Samochody";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)samochodBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmRocznik).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kolorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rocznikDataGridViewTextBoxColumn;
        private BindingSource samochodBindingSource;
        private TextBox txtModel;
        private TextBox txtMarka;
        private Label label2;
        private Label label1;
        private ColorDialog colorDialog1;
        private ComboBox cbKolor;
        private Label label3;
        private NumericUpDown nmRocznik;
        private Label label4;
        private Button btnDodaj;
        private Button btnUsun;
        private Button button1;
    }
}