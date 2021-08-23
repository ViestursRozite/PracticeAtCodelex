namespace AdApp
{
    public class Hoarding: Advert
    {
        private int rate;
        //per day
        private int numDays;

        public Hoarding(int fee, int rate, int numDays) : base(fee)
        {
            this.numDays = numDays;
            this.rate = rate;
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