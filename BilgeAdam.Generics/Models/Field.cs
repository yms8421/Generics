namespace BilgeAdam.Generics
{
    class Field : ISummable<Field>
    {
        public int Edge1 { get; set; }
        public int Edge2 { get; set; }

        public int GetArea()
        {
            return Edge1 * Edge2;
        }

        public decimal Sum(Field left, Field right)
        {
            return left + right;
        }

        public static decimal operator + (Field left, Field right)
        {
            return left.GetArea() + right.GetArea();
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