using System;
using System.ComponentModel.Design;

int dogrusayisi = 0; // dogru cevap sayisini tutmak icin int turunde degiskene atadik

Console.WriteLine("Kim milyoner olmak ister yarismasina hosgeldiniz.\n 1 Milyon TL lik Buyuk odul Icin Yarisiyorsun !! \n Hazirsan ilk soru ile basliyoruz." );
Console.WriteLine("Iki soruya dogru cevap verisen butuk odulu kazanirsin.");
Console.WriteLine("1 --> Kizinca Tukuren Hayvan Turu hangisidir? \n a)Lama b)Deve \n Cevabiniz: a/b");
string cevap1= Console.ReadLine().ToLower(); // Kullanicidan alina cevabi kucuk harfe donusturerek aliyoruz   

switch (cevap1)
{
    case "a":
        Console.WriteLine("Dogru cevap! ikinci soruya Geciyoruz.");
        dogrusayisi++; // Eger dorgu ceavi girdiyse dogrusayisi degiskeni 1 artacak.
        break;
    case "b":
        Console.WriteLine("Yanlis Cavap!");
        break;
    default:
        Console.WriteLine("Hatali girdi");
        break;

}

if (dogrusayisi<2) //Dogru sayisi 2den kucukse 2. soruya geciyoruz.
{
    Console.WriteLine("2 --> Dunya'ya En Yakin Gezegen hangisidir ? \n a)Venus b)Mars \n Cevabiniz: a/b");
    string cevap2 = Console.ReadLine().ToLower();

    switch (cevap2)
    {
        case "a":
            Console.WriteLine("Dogru cevap! .");
            dogrusayisi++; // Dogru girdiyse degisken degeri 1 daha artacak ve iki soruyu bildigi icin buyuk odulu kazanacak.
            break;
        case "b":
            Console.WriteLine("Yanlis Cavap!");
            break;
        default:
            Console.WriteLine("Hatali girdi");
            break;
    }   
}
    if (dogrusayisi == 1) //2. soruyu bilemediyse  1 soru daha soruyoruz
    {
        Console.WriteLine("3 --> Turkiye'nin Baskenti hangisidir? \n a)istanbul b)Ankara \n Cevabiniz: a/b");
        string cevap3 = Console.ReadLine().ToLower();

        switch (cevap3)
        {
            case "a":
                Console.WriteLine("Yanlis Cevap! .");
                
                break;
            case "b":
                Console.WriteLine("DogruCevap!");
            dogrusayisi++;
                break;
            default:
                Console.WriteLine("Hatali girdi");
                break;
        }
    }

Console.WriteLine("Sonuc :");

if (dogrusayisi  >= 2)
{
    Console.WriteLine("Tebrikler! 1 Milyon TL odulu kazandiniz.");
}
else
{
    Console.WriteLine("Uzgunum, 1 Milyon TL odulu kazanamadiniz :( .");
}
