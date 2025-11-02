using System;

class Bouquet
{
    public virtual void Show() => Console.WriteLine("Простий букетdotnet");
}

class WrappedBouquet : Bouquet
{
    private Bouquet bouquet;
    public WrappedBouquet(Bouquet b) { bouquet = b; }

    public override void Show()
    {
        bouquet.Show();
        Console.WriteLine("Додано пакування");
    }
}

class Program
{
    static void Main()
    {
        Bouquet b = new Bouquet();
        Bouquet wrapped = new WrappedBouquet(b);
        wrapped.Show();
    }
}








