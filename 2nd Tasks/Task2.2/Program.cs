double Orta(int[] ededler)
{
    int max = ededler[0];
    int min = ededler[0];
    foreach (int eded in ededler)
    {
        if (eded > max)
        {
            max = eded;
        }

        if (eded < min)
        {
            min = eded;
        }
    }

    return (double)(max + min) / 2;
}