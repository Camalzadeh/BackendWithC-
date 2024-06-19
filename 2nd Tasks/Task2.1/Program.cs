List<String> AIleBaslayanlar(List<String> adlar)
{
    List<String> secilmisAdlar = new List<String>();
    foreach (String ad in adlar)
    {
        if (ad.StartsWith('a') || ad.StartsWith('A'))
        {
            secilmisAdlar.Add(ad);
        }
    }
    return secilmisAdlar;
}