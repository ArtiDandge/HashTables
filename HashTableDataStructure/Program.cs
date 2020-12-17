using System;

namespace HashTableDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Hash Table Data Strcture***********");
            MyMapNode<String, String> myHashMap = new MyMapNode<string, string>(5);
            myHashMap.Add("0", "To");
            myHashMap.Add("1", "be");
            myHashMap.Add("2", "be");
            myHashMap.Add("3", "be");
            myHashMap.Add("4", "to");
            myHashMap.Add("5", "be");
            string hashS = myHashMap.Get("5");
            Console.WriteLine(hashS);
        }
    }
}
