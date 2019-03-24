namespace BilgeAdam.Generics
{
    class MathHelper
    {
        #region Overloads
        public int Sum(int n1, int n2)
        {
            return n1 + n2;
        }

        public string Sum(string s1, string s2)
        {
            return s1 + s2;
        }

        #endregion
        public decimal Sum<T>(T p1, T p2) where T : ISummable<T>
        {
            return p1.Sum(p1, p2);
            #region keko Yöntem
            //Generic methoda asla uygun olmayan yöntem!!!!

            //if (typeof(T) == typeof(int))
            //{
            //    var p1AsString = p1.ToString();
            //    var p2AsString = p2.ToString();
            //    var result = int.Parse(p1AsString) + int.Parse(p2AsString);
            //    return (T)result;
            //}
            //else if (typeof(T) == typeof(string))
            //{
            //    var p1AsString = p1.ToString();
            //    var p2AsString = p2.ToString();
            //    var result = p1AsString + p2AsString;
            //    return (T)result;
            //} 
            #endregion
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