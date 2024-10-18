namespace AdressBook
{
    partial class AdressBook
    {
        /// </summary>
        private System.ComponentModel.IContainer components = null;

       
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
            textBoxName = new TextBox();
            textBoxTelefon = new TextBox();
            textBoxPostort = new TextBox();
            textBoxPostnummer = new TextBox();
            textBoxGatudress = new TextBox();
            textBoxMail = new TextBox();
            buttonSpara = new Button();
            buttonUppdatera = new Button();
            buttonTabort = new Button();
            buttonSöka = new Button();
            Kontaktlist = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxSearch = new TextBox();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.BackColor = SystemColors.Window;
            textBoxName.Location = new Point(25, 98);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(209, 27);
            textBoxName.TabIndex = 0;
            // 
            // textBoxTelefon
            // 
            textBoxTelefon.Location = new Point(25, 299);
            textBoxTelefon.Name = "textBoxTelefon";
            textBoxTelefon.Size = new Size(209, 27);
            textBoxTelefon.TabIndex = 1;
            // 
            // textBoxPostort
            // 
            textBoxPostort.Location = new Point(25, 246);
            textBoxPostort.Name = "textBoxPostort";
            textBoxPostort.Size = new Size(209, 27);
            textBoxPostort.TabIndex = 2;
            // 
            // textBoxPostnummer
            // 
            textBoxPostnummer.Location = new Point(25, 199);
            textBoxPostnummer.Name = "textBoxPostnummer";
            textBoxPostnummer.Size = new Size(209, 27);
            textBoxPostnummer.TabIndex = 3;
            // 
            // textBoxGatudress
            // 
            textBoxGatudress.Location = new Point(25, 148);
            textBoxGatudress.Name = "textBoxGatudress";
            textBoxGatudress.Size = new Size(209, 27);
            textBoxGatudress.TabIndex = 4;
            // 
            // textBoxMail
            // 
            textBoxMail.Location = new Point(25, 352);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(209, 27);
            textBoxMail.TabIndex = 5;
         //  textBoxMail.TextChanged += textBoxMail_TextChanged;
            // 
            // buttonSpara
            // 
            buttonSpara.BackColor = Color.PaleGreen;
            buttonSpara.Location = new Point(257, 374);
            buttonSpara.Name = "buttonSpara";
            buttonSpara.Size = new Size(94, 29);
            buttonSpara.TabIndex = 6;
            buttonSpara.Text = "Spara";
            buttonSpara.UseVisualStyleBackColor = false;
            buttonSpara.Click += buttonSpara_Click;
            // 
            // buttonUppdatera
            // 
            buttonUppdatera.BackColor = Color.SkyBlue;
            buttonUppdatera.Location = new Point(511, 374);
            buttonUppdatera.Name = "buttonUppdatera";
            buttonUppdatera.Size = new Size(94, 29);
            buttonUppdatera.TabIndex = 8;
            buttonUppdatera.Text = "Uppdatera";
            buttonUppdatera.UseVisualStyleBackColor = false;
            buttonUppdatera.Click += buttonUppdatera_Click;
            // 
            // buttonTabort
            // 
            buttonTabort.BackColor = Color.Salmon;
            buttonTabort.Location = new Point(386, 374);
            buttonTabort.Name = "buttonTabort";
            buttonTabort.Size = new Size(94, 29);
            buttonTabort.TabIndex = 9;
            buttonTabort.Text = "Tabort";
            buttonTabort.UseVisualStyleBackColor = false;
            buttonTabort.Click += buttonTabort_Click;
            // 
            // buttonSöka
            // 
            buttonSöka.BackColor = Color.Silver;
            buttonSöka.Location = new Point(257, 434);
            buttonSöka.Name = "buttonSöka";
            buttonSöka.Size = new Size(94, 29);
            buttonSöka.TabIndex = 10;
            buttonSöka.Text = "Söka";
            buttonSöka.UseVisualStyleBackColor = false;
            buttonSöka.Click += buttonSöka_Click;
            // 
            // Kontaktlist
            // 
            Kontaktlist.FormattingEnabled = true;
            Kontaktlist.Location = new Point(257, 95);
            Kontaktlist.Name = "Kontaktlist";
            Kontaktlist.Size = new Size(357, 264);
            Kontaktlist.TabIndex = 11;
          //  Kontaktlist.SelectedIndexChanged += Kontaktlist_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 75);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 12;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 128);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 13;
            label2.Text = "Adress";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 178);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 14;
            label3.Text = "Postnr";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 229);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 15;
            label4.Text = "Postort";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 276);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 16;
            label5.Text = "Telefon";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 329);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 17;
            label6.Text = "Email";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(421, 434);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(193, 27);
            textBoxSearch.TabIndex = 18;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // AdressBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(650, 495);
            Controls.Add(textBoxSearch);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Kontaktlist);
            Controls.Add(buttonSöka);
            Controls.Add(buttonTabort);
            Controls.Add(buttonUppdatera);
            Controls.Add(buttonSpara);
            Controls.Add(textBoxMail);
            Controls.Add(textBoxGatudress);
            Controls.Add(textBoxPostnummer);
            Controls.Add(textBoxPostort);
            Controls.Add(textBoxTelefon);
            Controls.Add(textBoxName);
            Name = "AdressBook";
            Text = "AdressBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxTelefon;
        private TextBox textBoxPostort;
        private TextBox textBoxPostnummer;
        private TextBox textBoxGatudress;
        private TextBox textBoxMail;
        private Button buttonSpara;
        private Button buttonUppdatera;
        private Button buttonTabort;
        private Button buttonSöka;
        private ListBox Kontaktlist;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxSearch;
    }
}
