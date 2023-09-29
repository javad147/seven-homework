using System;

//2.Parametr olaraq string qebul eden metod yazmalisiz. Hemin metod qebul etdiyi stringi tersine formada ekranda gostersin. (Cavid gelirse , ekranda divaC gorsensin).
static void NickName(string Ad)
{
    string esas = Ad;
    string reverse = new string(esas.Reverse().ToArray());
    Console.WriteLine(reverse);
}
//NickName("Javad");

//3.1 Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.
static void IsDivision(int N = 21)
{
    if (N % 3 == 0 && N % 7 == 0)
        Console.WriteLine(N + " ededi 3 ve 7-ye bolunur");
    else
        Console.WriteLine("Bolunmur");
}
//IsDivision(84);

// 3.2 n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.
static void SumOfEvenNumbers(int a, int b)
{
    if (a % 2 == 0 && b % 2 == 0)
        Console.WriteLine("2 ededin cemi: " + (a + b));
    else
        Console.WriteLine("Cut eded daxil edin!");
}
//SumOfEvenNumbers(5, 15);

//3.3 Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.
static void AnOddNumber(int n, int m)
{
    int count = 0;
    if (n > m)
        Console.WriteLine("Sefdir!");
    else
        for (int i = n; i <= m; i++)
            if (i % 2 == 1)
                count++;
    Console.WriteLine(count);
}
//AnOddNumber(5, 17);

// 3.4 Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.
static void OddSum(int n, int m)
{
    int sum = 0;
    if (n > m)
        Console.WriteLine("Sefdir");
    else
        for (int i = n; i <= m; i++)
            if (i % 2 == 1)
                sum += i;
    Console.WriteLine(sum);
}
//OddSum(4, 9);

//3.5 Verilmish arrayin icindeki tek ededlerin cemini tapin.
static void ArrayTheSumOfASingleNumber()
{
    int[] arr = { 5, 6, 7, 9, 16 };
    int sum = 0;
    foreach (int item in arr)
        if (item % 2 == 1)
            sum += item;
    Console.WriteLine(sum);
}
//ArrayTheSumOfASingleNumber();

// 3.6 Verilmish arrayin icindeki cut ededlerin sayini tapin.
static void ArrayOfEvenNumber()
{
    int[] arr = { 5, 6, 7, 9, 16, 88 };
    int count = 0;
    foreach (int item in arr)
        if (item % 2 == 0)
            count++;
    Console.WriteLine(count);
}
//ArrayOfEvenNumber();

//3.7 Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.

static void IsPrime(int n) 
{
   int count = 0;
   for (int i = 1; i <=1; i++)
    {
        if (n % i == 2)
        {
        count ++;
        }
    }
    if (count == 2)
    {
        Console.WriteLine("Eded murekkebdir");
    }
    else
    {
        Console.WriteLine("Eded sadedir");
    }

}
//IsPrime(5);

// 3.8 n ededi gelir. 2-ni hansisa quvvete yukseltdikde n-in alinan cavaba beraber olub-olmamasını tapın. 
static void Power(int n)
{
    if ((n & (n - 1)) == 0)
        Console.WriteLine(n + " ededi 2'nin quvvetidir.");
    else
        Console.WriteLine(n + " ededi 2'nin quvveti deyildir.");
}
//Power(2);

// 3.9 Verilmish arrayin-in elementlerinin icinden 1-20 arasinda olanlarinin hasilini tapmaq.
static void ArrayProduct()
{
    int[] array = { 6, 8, 20 };
    int multiply = 1;
    foreach (int item in array)
        if (item <= 20 && item >= 1)
            multiply *= item;
    Console.WriteLine("1-den 20-e qeder olan reqemlerin hasili: " + multiply);
}
//ArrayProduct();



// 3.10 Verilmish arrayin elementlerininden cut olanlarinin ceminin kvadratini tapmaq.
static void ArrayPower()
{
    int[] arr = { 5, 6, 7, 9, 4 };
    int sum = 0;
    int power = 0;
    foreach (int item in arr)
        if (item % 2 == 0)
            sum += item;
    power = sum * sum;
    Console.WriteLine("Cut edelerin ceminin kvadrati: " + (power));
}
//ArrayPower();
