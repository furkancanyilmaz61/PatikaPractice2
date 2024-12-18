class PatikaPractice2
{
    static void Main(string[] args)
    {
        Console.WriteLine("T.C. Kimlik Numarasi: ");
        string id = Console.ReadLine();

        Console.WriteLine("Adi: ");
        string name= Console.ReadLine();

        Console.WriteLine("Soyadi: ");
        string lastname= Console.ReadLine();

        Console.WriteLine("Telefon Numarasi: ");
        string telephoneno= Console.ReadLine();

        Console.Write("Yaş: ");
        int yas = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ilk Aldigi Urunun Fiyati: ");
        double firstprice= Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ikinci Aldigi Urunun Fiyati: ");
        double lastprice= Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("----------------------------");

        //Toplam harcama 
        double toplamHarcama = firstprice + lastprice;

        //Patika puan hesaplama
        double patikaPuan = toplamHarcama * 0.1;

        //Kullaniciya geri bildirim verme
        Console.WriteLine("\n" + id + " Tc numaralı " + name + " " + lastname + " isimli kişi için kayıt oluşturulmuştur.");
        Console.WriteLine(telephoneno + " telefon numarasına bildirim gönderilmiştir.");
        Console.WriteLine(toplamHarcama + " toplam harcama karşılığı kazanılan %10 patika puan miktarı -> " + patikaPuan + " TL'dir.");








    }
}