# Decorator

Ідея декоратора: 

Декоратор дозволяє додавати нові можливості об’єкту без зміни його коду.

Як працює код: 

Ми маємо базовий букет, але «обгортаємо» його декоратором, який додає пакування.
Це зручно, коли треба динамічно додавати функції — наприклад, “з листівкою”, “в коробці”, “з доставкою”.

Навіщо: 

замість створення сотень підкласів можна комбінувати прикраси.

## Код
```csharp
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

```
## Результат
![Результат виконання](sc9.png)
