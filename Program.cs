namespace StaticSınıfVeÜyler;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Çalışan Sayısı: "+Calısan.ÇalışanSay1);
        // Calısan c1 =new Calısan("Bedirhan","Gökkaya","software");
        // Console.WriteLine(Calısan.ÇalışanSay1);

        Console.WriteLine("İki Sayının toplamı: "+ Mat.top(42,68));
        Console.Write("İki Sayının Çıkartması: "+ Mat.cık(166,66));

    }
}

class Calısan // class içerisindeki statik olan alanlar calışanlar sınıfında ilk kez erişildiğinde bir kere çalışır tekrardan sınıfa erişilirse veya o sınıfdan bir nesne türetilirse sıfırdan tekrardan başlamaz kaluğı yerden devam eder.
{
    private static int ÇalışanSay;

    public static int ÇalışanSay1 { get => ÇalışanSay; }

    private string Isim;
    private string Soyisim;
    private string Depratman;

    static Calısan() // Statik kurucuların erişim belirteci olmaz.
    {
        ÇalışanSay=0;

    }

    public Calısan(string ısim, string soyisim, string depratman)
    {
        this.Isim=ısim;
        this.Soyisim=soyisim;
        this.Depratman=depratman;
        ÇalışanSay++;
    }

}

static class Mat //statik sınıflarda sadece statik metotlar kullanılabilir.
{
    public static int top(int a, int b)
    {
        return a+b;
    }

    public static int cık(int a, int b)
    {
        return a-b;
    }
}
