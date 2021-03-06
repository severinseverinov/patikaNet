namespace projectToDo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Members> kisiler = new List<Members>();
            List<Card> TODO = new List<Card>();
            List<Card> INPROGRESS = new List<Card>();
            List<Card> DONE = new List<Card>();

            kisiler.Add(new Members(1, "Sevgin", "Serbest"));
            kisiler.Add(new Members(2, "Elif", "Serbest"));
            kisiler.Add(new Members(3, "Cihangir", "Serbest"));
            kisiler.Add(new Members(4, "Nil Nisa", "Serbest"));
            kisiler.Add(new Members(5, "Ali", "Veli"));

            TODO.Add(new Card("Spor", "Fitness", "Sevgin SERBEST", Card.Buyukluk.XS));
            TODO.Add(new Card("Yabancı Dil", "Almanca Çalış", "Elif SERBEST", Card.Buyukluk.S));
            INPROGRESS.Add(new Card("Okul", "Ödevlerini Yap", "Cihangir SERBEST", Card.Buyukluk.M));
            INPROGRESS.Add(new Card("Okul", "Ödevlerini Yap", "Orhun Yamaç", Card.Buyukluk.L));
            DONE.Add(new Card("Doktor", "Ameliyat yap", "Ali VELİ", Card.Buyukluk.XL));

            BManager boardManager = new BManager();
            int number = 0;

            while (number != 5)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz: ");
                Console.WriteLine("******************************************");
                Console.WriteLine("(1) Board Listelemek");
                Console.WriteLine("(2) Board'a Kart Eklemek");
                Console.WriteLine("(3) Board'dan Kart Silmek");
                Console.WriteLine("(4) Kart Taşımak");
                Console.WriteLine("(5) Çıkış yapın");
                int choose = Convert.ToInt32(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        boardManager.ListCard(TODO, INPROGRESS, DONE);
                        break;
                    case 2:
                        boardManager.AddCard(TODO,kisiler);
                        break;
                    case 3:
                        boardManager.DeleteCard(TODO, INPROGRESS, DONE);
                        break;
                    case 4:
                        boardManager.ChangeCard(TODO, INPROGRESS, DONE);
                        break;
                    case 5:
                        number = 5;
                        break;
                }
            }
           




        }
    }
}
