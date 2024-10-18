

namespace AdressBook
{
    public partial class AdressBook : Form
    {
        private List<Kontakt> kontakter = new List<Kontakt>();
        private string filePath = @"C:\Users\hoori\OneDrive\C\AdressBook.txt";

        public AdressBook()
        {
            InitializeComponent();
            ReadFil();  //my StreamReader
            VisaKontakter(); 

            //  event handler is properly connected
            Kontaktlist.SelectedIndexChanged += new EventHandler(listBoxKontakter_SelectedIndexChanged);
        }

        // Spara en ny kontakt (adding en ny )
        private void buttonSpara_Click(object sender, EventArgs e)
        {
            Kontakt kontakt = new Kontakt(
        textBoxName.Text,
        textBoxGatudress.Text,
        textBoxPostnummer.Text,
        textBoxPostort.Text,
        textBoxTelefon.Text,
        textBoxMail.Text
    );

            kontakter.Add(kontakt);
            WriteFil();  // Spara till fil
            VisaKontakter(); // Uppdatera listan
        }
        // Uppdatera en vald kontakt
        private void buttonUppdatera_Click(object sender, EventArgs e)
        {
            if (Kontaktlist.SelectedItem is Kontakt selectedKontakt)
            {
                // Update the existing contact's properties directly
                selectedKontakt.Namn = textBoxName.Text;
                selectedKontakt.Gatuadress = textBoxGatudress.Text;
                selectedKontakt.Postnummer = textBoxPostnummer.Text;
                selectedKontakt.Postort = textBoxPostort.Text;
                selectedKontakt.Telefon = textBoxTelefon.Text;
                selectedKontakt.Epost = textBoxMail.Text;

                // Save changes to file
                WriteFil();

           
            }
        }


        // Ta bort vald kontakt
        private void buttonTabort_Click(object sender, EventArgs e)
        {
            if (Kontaktlist.SelectedItem is Kontakt kontakt)
            {
                kontakter.Remove(kontakt);  // Ta bort kontakt fr�n listan
                WriteFil();  // Spara �ndringen till fil
                VisaKontakter(); // Uppdatera listan
              
            }
          


        }

        // S�ka efter kontakter baserat p� namn n�r anv�ndaren klickar p� knappen
        private void buttonS�ka_Click(object sender, EventArgs e)
        {
            string search = textBoxSearch.Text; // Anv�nd text fr�n s�krutan

            // Kolla om s�kf�ltet �r tomt, om ja visa alla kontakter
            if (string.IsNullOrWhiteSpace(search))
            {
                VisaKontakter(); // Visa alla kontakter om s�krutan �r tom
                return;
            }

           
            // Filter contacts based on name or address (case-insensitive)
            var resultat = kontakter.Where(kontakt =>
                kontakt.Namn.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                kontakt.Gatuadress.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                kontakt.Postort.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                kontakt.Postnummer.Contains(search, StringComparison.OrdinalIgnoreCase)).ToList();



            Kontaktlist.DataSource = null;  // Rensa listan innan ny bindning
            Kontaktlist.DataSource = resultat; // Visa s�kresultaten
            Kontaktlist.DisplayMember = "Namn";  // Visa namnet i listboxen
        }

        // searchin while anv�ndaren skriver i s�krutan
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string search = textBoxSearch.Text.Trim();  // cleaning extra mellanslag

            // Visa alla kontakter om s�krutan �r tom
            if (string.IsNullOrWhiteSpace(search))
            {
                VisaKontakter();
                return;
            }

            // Filtrera kontakter d�r namnet matchar s�ktermen (case-insensitive)
            var resultat = kontakter.Where(kontakt => kontakt.Namn.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

            // Uppdatera listboxen med filtrerade resultat
            Kontaktlist.DataSource = null;
            Kontaktlist.DataSource = resultat;
            Kontaktlist.DisplayMember = "Namn";
        }

        // N�r en kontakt v�ljs i listboxen, fyll i f�lten med dennes uppgifter
        private void listBoxKontakter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kontrollera om ett objekt �r valt
            if (Kontaktlist.SelectedItem is Kontakt kontakt)
            {
                // Fyll i textf�lten med choosen kontaktens detaljer
                textBoxName.Text = kontakt.Namn;
                textBoxGatudress.Text = kontakt.Gatuadress;
                textBoxPostnummer.Text = kontakt.Postnummer;
                textBoxPostort.Text = kontakt.Postort;
                textBoxTelefon.Text = kontakt.Telefon;
                textBoxMail.Text = kontakt.Epost;
            }
        }
        // ???? ???? ???? ????? ?????
        // Visa alla kontakter i listboxen
        private void VisaKontakter()
        {
            Kontaktlist.DataSource = null;
            Kontaktlist.DataSource = kontakter;
            Kontaktlist.DisplayMember = "Namn";  // Visa namnet i listboxen


            // Clear the input fields
            ClearInputFields();
        }

        // Method to clear input fields
        private void ClearInputFields()
        {
            textBoxName.Clear();
            textBoxGatudress.Clear();
            textBoxPostnummer.Clear();
            textBoxPostort.Clear();
            textBoxTelefon.Clear();
            textBoxMail.Clear();
        }

        // Spara alla kontakter till filen med StreamWriter
        private void WriteFil()
        {
            using (var writer = new StreamWriter(filePath))
            {
                foreach (var kontakt in kontakter)
                {
                    writer.WriteLine($"{kontakt.Namn},{kontakt.Gatuadress},{kontakt.Postnummer},{kontakt.Postort},{kontakt.Telefon},{kontakt.Epost}");
                }
            }
        }

        // StreamRead kontakter fr�n filen
        //The using statement ensures that the file is properly
        //closed after reading, even if an error occurs.
        //StreamReader is a class used to read characters from a text file.
        /// </summary>
        private void ReadFil()
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] delar = line.Split(','); 
                        Kontakt kontakt = new Kontakt 
                        {
                            Namn = delar[0],
                            Gatuadress = delar[1],
                            Postnummer = delar[2],
                            Postort = delar[3],
                            Telefon = delar[4],
                            Epost = delar[5]
                        };
                        kontakter.Add(kontakt);
                    }
                }

            }
        }

    }
}
