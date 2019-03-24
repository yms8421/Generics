namespace BilgeAdam.Generics
{
    interface ISummable<T>
    {
        decimal Sum(T left, T right); 
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