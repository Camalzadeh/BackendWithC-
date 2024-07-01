namespace DataBaseAndClasses;
class Program
{
    static void Main(string[] args)
    {
        ApplicationDbContext db = new ApplicationDbContext();
        Kitab kitab = new Kitab
        {
            Ad = "Riyaziyyat",
            Janr = Janrlar.ElmiFantastika,
            SehifeSayi = 12,
            Qiymet = 12.5
        };
        Insan insan = new Insan
        {
            Ad = "Tariyel",
            Soyad = "Cabbarov"
        };
        Muellim muellim = new Muellim
        {
            Ad = "Rafiq",
            Soyad = "Ekberov",
            Maas = 500
        };

        db.Kitablar.Add(kitab);
        db.Insanlar.Add(insan);
        db.Muellimler.Add(muellim);
        db.SaveChanges();
    }
}