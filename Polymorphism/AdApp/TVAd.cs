namespace AdApp
{
    public class TVAd: Advert
    {
        int costPerSecond;
        int seconds;
        bool yes;
        public TVAd(int fee, int costPerSecond, int seconds, bool yes) : base(fee)
        {
            this.costPerSecond = costPerSecond;
            this.seconds = seconds;
            this.yes = yes;
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