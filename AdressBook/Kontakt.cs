namespace AdressBook
{
    public class Kontakt
    {
        public string Namn { get; set; }
        public string Gatuadress { get; set; }
        public string Postnummer { get; set; }
        public string Postort { get; set; }
        public string Telefon { get; set; }
        public string Epost { get; set; }

        // Konstruktor som tar alla egenskaper som parametrar
        public Kontakt(string namn, string gatuadress, string postnummer, string postort, string telefon, string epost)
        {
            Namn = namn;
            Gatuadress = gatuadress;
            Postnummer = postnummer;
            Postort = postort;
            Telefon = telefon;
            Epost = epost;
        }

       
        public Kontakt()
        {
        }
    }
}
