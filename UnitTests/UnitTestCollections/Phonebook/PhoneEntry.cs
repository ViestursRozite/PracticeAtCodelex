namespace PhoneBook
{
    public class PhoneEntry
    {

        private string name;
        private string number;
        public PhoneEntry(string name, string number)
        {
            this.name = name;
            this.number = number;
        }
        public string Name { get { return name; } }
        public string Number { get { return number; } }
    }
}