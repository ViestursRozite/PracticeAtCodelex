namespace AdApp
{
    public class Hoarding: Advert
    {
        private int _rate;
        //per day
        private int _numDays;

        public Hoarding(int fee, int rate, int numDays) : base(fee)
        {
            this._numDays = numDays;
            this._rate = rate;
        }

        public new int Cost() 
        {
            return base.Cost();
        }

        public override string ToString() 
        {
            return base.ToString();
        }
    }
}