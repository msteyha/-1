using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Dictionary<string, object> dictionary = new Dictionary<string, object>
        {
            { "Fruits", new List<string> { "Яблуко", "Банан", "Апельсин" } },
            { "Vegetables", new List<string> { "Помідор", "Огірок", "Морква" } },
            { "Prices", new List<string> { "50 гривень", "75 гривень", "40 гривень" } }
        };

        int count = 0;

        foreach (var item in dictionary)
        {
            if (item.Value is IEnumerable && !(item.Value is string))
            {
                count++;
            }
        }

        Console.WriteLine("Кількість записів списком: " + count);

        string json = JsonSerializer.Serialize(dictionary, new JsonSerializerOptions
        {
            WriteIndented = true
        });

        File.WriteAllText("products.json", json);
    }
}