//Geriye Değer Döndürmeyen Bir void metot.
//Ekrana sevdiğiniz bir şarkı sözünü yazdırsın. 
using System.Transactions;

Console.WriteLine("<---------- Geriye değer döndürmeyen bir metod ---------->");
static void song(string songText)
{
    Console.WriteLine(songText);
}
song("I found a love, for me\r\nDarling, just dive right in and follow my lead\r\nWell, I found a girl, beautiful and sweet\r\nOh, I never knew you were the someone waiting for me");


//Geriye Tamsayı Döndüren Bir metot
//Rastgele bir sayı üretip bu sayının 2'ye bölümünden kalanı geriye döndürsün.
Console.WriteLine("<---------- Geriye Tamsayı Döndüren Bir metot ---------->");
static int number(int rnd)
{
    int result = rnd % 2;
    return result;
}
Random rnd = new Random();
int numberRnd = rnd.Next(100);
Console.WriteLine($"Rastgele üretilen sayı:{numberRnd}, 2ye bölümünden kalan:{number(numberRnd)}");


//Parametre Alan ve Geriye Değer Döndüren Bir Metot
//Parametre olarak aldığı iki sayının çarpımını geriye dönsün.
Console.WriteLine("<---------- Parametre Alan ve Geriye Değer Döndüren Bir Metot ---------->");
static int multiplication(int numberOne, int numberTwo)
{
    int result = numberOne * numberTwo;
    return result;
}
Console.Write("Lütfen bir sayı giriniz: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Lütfen bir sayı giriniz: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{numberOne} x {numberTwo} = {multiplication(numberOne, numberTwo)} ");


//Parametre Alan ve Geriye Değer Döndürmeyen bir Metot
//Parametre olarak isim ve soyisim bilgilerini alıp " Hoş Geldiniz {isim} {soyisim} " şeklinde ekrana bassın.
Console.WriteLine("<---------- Parametre Alan ve Geriye Değer Döndürmeyen bir Metot ---------->");
static void welcome(string isim, string soyisim)
{
    Console.WriteLine($"Hoş Geldiniz {isim} {soyisim}");
}
Console.Write("Lütfen isminizi giriniz: ");
string name = Console.ReadLine();
Console.Write("Lütfen soyisminizi giriniz: ");
string surname = Console.ReadLine();
welcome(name, surname);