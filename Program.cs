
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
      
        Console.OutputEncoding = Encoding.UTF8;

        string path = "C:\\Users\\o.murha\\source\\repos\\лабораторна 1 (2 семестр)\\лабораторна 1 (2 семестр)\\TextFile1.txt"; 

        List<int> symbolCounts = new List<int>();

        
        string[] lines = File.ReadAllLines(path);

        foreach (string line in lines)
        {
            symbolCounts.Add(line.Length);
        }

        for (int i = 0; i < symbolCounts.Count; i++)
        {
            Console.WriteLine($"Рядок {i + 1}: {symbolCounts[i]} символів");
        }
    }
}