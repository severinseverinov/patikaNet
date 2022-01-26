namespace projectToDo
{
    class Card
    {
        private string baslik;
        private string icerik;
        private string atananKisi;
        private Buyukluk boyut;

        public string Baslik { get => baslik; set => baslik = value; }
        public string Icerik { get => icerik; set => icerik = value; }
        public string AtananKisi { get => atananKisi; set => atananKisi = value; }
        internal Buyukluk Boyut { get => boyut; set => boyut = value; }

        public enum Buyukluk
        {
            XS,
            S,
            M,
            L,
            XL
        }

        public Card(string Baslik, string Icerik, string AtananKisi, Buyukluk Boyut)
        {
            this.Baslik = Baslik;
            this.Icerik = Icerik;
            this.AtananKisi = AtananKisi;
            this.Boyut = Boyut;
        }
    }
}