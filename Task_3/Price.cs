namespace Task_3
{
    struct Price
    {
        public string Product { set; get; }
        public string Shop { set; get; }
        public int Cost { set; get; }

        public Price(string prodict, string shop, int cost)
        {
            Product = prodict;
            Shop = shop;
            Cost = cost;
        }
    }
}
