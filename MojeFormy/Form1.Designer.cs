namespace MojeFormy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnClose = new Button();
            label1 = new Label();
            label2 = new Label();
            txtImie = new TextBox();
            txtNazwisko = new TextBox();
            btnWynik = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.BackColor = Color.RoyalBlue;
            btnClose.Cursor = Cursors.Hand;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(688, 520);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 41);
            btnClose.TabIndex = 0;
            btnClose.Text = "Zamknij aplikację";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += klikniecie;
            btnClose.MouseLeave += button1_MouseLeave;
            btnClose.MouseHover += zmien_kolor_tla;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(19, 119);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 1;
            label1.Text = "podaj imię";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(19, 179);
            label2.Name = "label2";
            label2.Size = new Size(121, 21);
            label2.TabIndex = 2;
            label2.Text = "podaj nazwisko";
            // 
            // txtImie
            // 
            txtImie.Location = new Point(175, 122);
            txtImie.Name = "txtImie";
            txtImie.Size = new Size(254, 23);
            txtImie.TabIndex = 3;
            // 
            // txtNazwisko
            // 
            txtNazwisko.Location = new Point(175, 177);
            txtNazwisko.Name = "txtNazwisko";
            txtNazwisko.Size = new Size(254, 23);
            txtNazwisko.TabIndex = 4;
            // 
            // btnWynik
            // 
            btnWynik.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnWynik.BackColor = Color.RoyalBlue;
            btnWynik.Cursor = Cursors.Hand;
            btnWynik.ForeColor = Color.White;
            btnWynik.Location = new Point(309, 220);
            btnWynik.Name = "btnWynik";
            btnWynik.Size = new Size(120, 41);
            btnWynik.TabIndex = 5;
            btnWynik.Text = "Pokaż wynik";
            btnWynik.UseVisualStyleBackColor = false;
            btnWynik.Click += btnWynik_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(463, 122);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(332, 139);
            listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 573);
            Controls.Add(listBox1);
            Controls.Add(btnWynik);
            Controls.Add(txtNazwisko);
            Controls.Add(txtImie);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Moja forma";
            Load += Form1_Load;
            MouseDoubleClick += Form1_MouseDoubleClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Label label1;
        private Label label2;
        private TextBox txtImie;
        private TextBox txtNazwisko;
        private Button btnWynik;
        private ListBox listBox1;
    }
}