namespace Account
{
    public class SavingsAccount
    {
        
        private decimal _anualInterest;
        private string _name;
        private decimal _balance;

        public SavingsAccount(string name, decimal startingBalance, decimal anualInterest = 0.06m)
        {
            this._balance = startingBalance;
            this._name = name;
            this._anualInterest = anualInterest;
        }

        public decimal withdrawal(decimal i)
        {
            return this._balance += - i;
        }

        public void deposit(decimal i)
        {
            this._balance += i;
        }

        public decimal balance()
        {
            return _balance;
        }

        public override string ToString()
        {
            return $"{_name}: {_balance}";
        }

        public void CalcInterestMonth(decimal timeInMonths)
        {
            _balance *= (( (1 + (timeInMonths * _anualInterest / 12))));
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public decimal AnualInterest
        {
            get => _anualInterest;
            set => _anualInterest = value;
        }

        public decimal Balance
        {
            get => _balance;
            set => _balance = value;
        }

    }
}
