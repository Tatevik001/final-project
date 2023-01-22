using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        string[] array = {"hello", "2", "world", ":-)"};
        List<string> list = new List<string>();

        foreach (string item in array) {
            if (item.Length <= 3) {
                list.Add(item);
            }
        }

        foreach (string item in list) {
            Console.WriteLine(item);
        }
    }
}