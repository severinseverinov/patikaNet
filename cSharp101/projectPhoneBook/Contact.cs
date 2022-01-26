namespace phoneBook
{
    class Contact{
        private string firstName;
        private string lastName;
        private string phone;

        public Contact(string FirstName, string LastName, string Phone)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Phone = Phone;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Phone { get => phone; set => phone = value; }
    }
}