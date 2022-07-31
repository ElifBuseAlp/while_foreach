// while 




// 1 den n'e (n dahil) konsoldan alıp ort. yazdırmak

/*
Console.WriteLine("Lütfen sayı giriniz:");
int n = Convert.ToInt32(Console.ReadLine());

int sayac = 1;
int toplam = 0;

while ( sayac <= n)
{
    toplam += sayac;
    sayac++;
}

Console.WriteLine(toplam/n);
*/


// a dan z ye tüm harfleri konsola yazdır

/*
char cha = 'a';

while (cha <= 'z')
{
    Console.Write(cha);
    cha++;
}
*/


/////---------foreach-----------

string[] arabalar = {"bmw","toyota","ford","kia"};

foreach (var araba in arabalar)
{
    Console.WriteLine(araba);
}

int[] sayiDizisi = {2,4,5,1,2,4};
int toplam = 0 ;

foreach(int i in sayiDizisi)
{
    toplam += i ; //toplam = toplam + i
    Console.WriteLine(toplam);
}


Console.ReadLine();