using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public double Price { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>
{
new Product { Id = 1, Name = "Ноутбук", Category = "Електроніка", Price = 1200 },
new Product { Id = 2, Name = "Футболка", Category = "Одяг", Price = 20 },
new Product { Id = 3, Name = "Шоколадка", Category = "Їжа", Price = 2.5 },
new Product { Id = 4, Name = "Смартфон", Category = "Електроніка", Price = 800 },
new Product { Id = 5, Name = "Джинси", Category = "Одяг", Price = 50 },
new Product { Id = 6, Name = "Морозиво", Category = "Їжа", Price = 3 },
new Product { Id = 7, Name = "Телевізор", Category = "Електроніка", Price = 1500 },
new Product { Id = 8, Name = "Кросівки", Category = "Взуття", Price = 80 },
new Product { Id = 9, Name = "Піча", Category = "Їжа", Price = 10 },
new Product { Id = 10, Name = "Монітор", Category = "Електроніка", Price = 300 },
new Product { Id = 11, Name = "Світшот", Category = "Одяг", Price = 35 },
new Product { Id = 12, Name = "Книга", Category = "Книги", Price = 15 },
new Product { Id = 13, Name = "Браслет", Category = "Прикраси", Price = 25 },
new Product { Id = 14, Name = "Чайник", Category = "Побутова техніка", Price = 40 },
new Product { Id = 15, Name = "Батонцик", Category = "Їжа", Price = 1.5 },
new Product { Id = 16, Name = "Мишка", Category = "Електроніка", Price = 10 },
new Product { Id = 17, Name = "Портфель", Category = "Аксесуари", Price = 70 },
new Product { Id = 18, Name = "Спортивний костюм", Category = "Спорт", Price = 100 },
new Product { Id = 19, Name = "Кавоварка", Category = "Побутова техніка", Price = 60 },
new Product { Id = 20, Name = "Годинник", Category = "Прикраси", Price = 120 }
};
        //"Завдання 1 Вибрати всі товари з категорії "Електроніка".
        Console.WriteLine("Завдання 1 \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
        var electronics = products.Where(x => x.Category == "Електроніка");
        foreach (var product in electronics) Console.WriteLine(product.Name + "\n");

        //"Завдання 2 Знайти найдорожчий товар.
        Console.WriteLine("Завдання 2 \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
        double max = products.Max(x => x.Price);
        Console.WriteLine("Найвища ціна = " + max + "\n");

        //"Завдання 3 Підрахувати загальну вартість всіх товарів.
        Console.WriteLine("Завдання 3 \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
        double allvalue = products.Sum(x => x.Price);
        Console.WriteLine("Загальна вартість всіх товарів = " + allvalue + "\n");

        //"Завдання 4 Відсортувати товари за ціною у зростаючому порядку.
        Console.WriteLine("Завдання 4 \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
        var valueOrderBy = products.OrderBy(x => x.Price);
        foreach (var product in valueOrderBy) Console.WriteLine(product.Category +"\t"+ product.Name + "\t" + product.Price + "\n");

        //"Завдання 5 Вибрати унікальні категорії товарів.
     
        Console.WriteLine("Завдання 5 \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
        var unique = products.Select(x => x.Category).Distinct();
        foreach (var category in unique)
            Console.WriteLine(category + "\n");


        //"Завдання 6 Знайти кількість товарів у кожній категорії.
        Console.WriteLine("Завдання 6 \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
        foreach (var category in products.Select(x => x.Category).Distinct())
        {
            var numberOfItems = products.Count(x => x.Category == category);
            Console.WriteLine(category + "\t" + numberOfItems + "\n");


        }
        //"Завдання 7 Вибрати товари з назвами, які починаються на букву "С".
        Console.WriteLine("Завдання 7 \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
        string startWithsC;
        foreach (var product in products) if (product.Name.StartsWith("С")) Console.WriteLine(product.Name + "\n");

        //"Завдання 8 Знайти середню ціну товарів.
        Console.WriteLine("Завдання 8 \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
        var AveragePrice = products.Average(x => x.Price);
        Console.WriteLine(AveragePrice + "\n");

        //"Завдання 9 Вибрати товари, ціна яких менше 50.
        Console.WriteLine("Завдання 9 \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
        var lessthan50 = products.Where(x => x.Price < 50);
        foreach (var product in lessthan50) Console.WriteLine(product.Name + "\t" + product.Category + "\t" + product.Price + "\n");

        //"Завдання 10 Підрахувати кількість товарів з ціною більше 100.
        Console.WriteLine("Завдання 10 \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
        var morethan100 = products.Where(x => x.Price > 100);
        foreach (var product in morethan100) Console.WriteLine(product.Name + "\t" + product.Category + "\t" + product.Price + "\n");

        //"Завдання 11 Вибрати перші 5 товарів.
        Console.WriteLine("Завдання 11   \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
        var take5 = products.Take(5);
        foreach (var product in take5) Console.WriteLine(product.Name + "\t" + product.Category  +  "\t" + product.Price + "\n");

        //"Завдання 12 Повернути останній товар.
        Console.WriteLine("Завдання 12   \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
        var thelastone = products.Last();
        Console.WriteLine(thelastone.Name + "\t" + thelastone.Category + "\t" + thelastone.Price + "\n");

        //"Завдання 15 Вибрати товари, ціна яких лежить у діапазоні від 10 до 100.
        Console.WriteLine("Завдання 15   \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
        var between10and100 = products.Where(x => x.Price < 100 && x.Price > 10);
        foreach (var product in between10and100) Console.WriteLine(product.Name + "\t" + product.Category + "\t" + product.Price + "\n");

        //"Завдання 16 Знайти найменшу ціну серед товарів.
        Console.WriteLine("Завдання 16   \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
        double min = products.Min(x => x.Price);
        Console.WriteLine("Найнижча ціна = " + min + "\n");

        //"Завдання 17 Вибрати товари, що містять слово "Кава" в назві.
        Console.WriteLine("Завдання 17   \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
        var kava = products.Where(x => x.Name.Contains("Кава"));
        foreach (var product in kava)
            Console.WriteLine(product.Name + "\t" + product.Category + "\t" + product.Price + "\n");

        //"Завдання 18 Підрахувати загальну кількість товарів.
        Console.WriteLine("Завдання 18   \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
        var totalItems = products.Count();
        Console.WriteLine("Кількість всіх товарів " + totalItems);
    }



}