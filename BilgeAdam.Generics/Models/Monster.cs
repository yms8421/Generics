namespace BilgeAdam.Generics
{
    class Monster : ISummable<Monster>
    {
        public string Name { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public int Health { get; set; }

        public decimal Sum(Monster left, Monster right)
        {
            return left.Attack + right.Attack;
        }
    }

    //interface ISummable
    //{
    //    decimal Sum(int left, int right);
    //    decimal Sum(decimal left, decimal right);
    //}
}
/*
 string bir değer ile toplanan tüm değerler .ToString() ile öncelikle string'e çevrilir ve sonra toplanır
     */