//Vatandas vatandas1 = new Vatandas();
//Console.ReadLine();
using Business.Concrete;
using Entities.Concrete;

SelamVer(isim: "Özge");
SelamVer();//Merhaba isimsiz
int sonuc = Topla(50);

//Diziler - Arrays

string ogrenci1 = "Engin";
string ogrenci2 = "Kerem";
string ogrenci3 = "Berkay";
string[] ogrenciler = new string[3];
ogrenciler[0] = "Engin";
ogrenciler[1] = "Kerem";
ogrenciler[2] = "Berkay";
//for (int i = 0; i < ogrenciler.Length; i++)
//{
//    Console.WriteLine(ogrenciler[i]);

//}
foreach (string ogrenci in ogrenciler)
{
    Console.WriteLine(ogrenci);
}
List<string> yeniSehirler = new List<string> { "Ankara", "İzmir", "İstanbul" };
yeniSehirler.Add("Adana");
foreach (var sehir in yeniSehirler)
{
    Console.WriteLine(sehir);
}

Person person1 = new Person();
person1.FirstName = "ÖZGE";
person1.LastName = "KESTANE";
person1.DateOfBirthYear = 1997;
person1.NationalIdentity = 123;
Person person2 = new Person();
person2.FirstName = "Engin";
PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);
Console.ReadLine();

Console.ReadLine();









static void SelamVer(string isim = "isimsiz")//default parametre
{
    Console.WriteLine("Merhaba " + isim);
}

static int Topla(int sayi1 = 5, int sayi2 = 10)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam :" + sonuc);
    return sonuc;
}
//pascal casing, büyük harfler başlama, properties
//public class Vatandas
//{
//    //public string ad = "Özge";
//    //public string soyad = "Kestane";
//    //public int dogumYili = 1997;
//    //public long tcNo = 12345678910;
//    // prop yaz taba bas
//    public string Ad { get; set; }
//    public string Soyad { get; set; }
//    public int DogumYili { get; set; }
//    public long TcNo { get; set; }
//}


