namespace AdApp
{
    public class NewspaperAd : Advert
    {
        private int column;
        private int rate;

        public NewspaperAd(int fee, int column, int rate) : base(fee)
        {
            this.column = column;
            this.rate = rate;
        }

        private new int Cost()
        {
            var fee = base.Cost();
            return fee;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}