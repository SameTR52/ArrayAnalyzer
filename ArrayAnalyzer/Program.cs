// See https://aka.ms/new-console-template for more information





int[] sayilar = { -5, -10, -3, 60, 88 }; // dizi ataması yapıldı.

int enBuyuk = sayilar[0]; // ilk değişken yani -5 enBuyuk'e atıldı.

for(int i = 1; i < sayilar.Length; i++) // döngü kuruldu
{
    if (sayilar[i] > enBuyuk) // eğer i deki index ile bulduğumuz değişken büyükse onu enBuyuk'e atadık.
    { 
        enBuyuk = sayilar[i]; // atama burda yapıldı
    }
}

Console.WriteLine("En büyük sayı: " + enBuyuk); // ekrana yazıldı

int enKucuk = sayilar[0]; // Aynısı ama en küçüğünü bulmak için olan kod

for (int i = 1; i < sayilar.Length; i++)
{
    if (sayilar[i] < enKucuk)
    {
        enKucuk = sayilar[i];
    }


}

Console.WriteLine("En küçük sayı: " + enKucuk);

int toplam = 0; // ortalama için toplam oluşturuldu
for (int i = 0; i < sayilar.Length; i++) 
{
    toplam += sayilar[i] // tüm indexler teker teker toplama atandı
}

    double ortalama = (double)toplam / sayilar.Length; // ortalama double olmazsa ondalık basamak kaybedilir

    Console.WriteLine("Sayıların Ortalaması: " + ortalama); // ekrana yazılır
