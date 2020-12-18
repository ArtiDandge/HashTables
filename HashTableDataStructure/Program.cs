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
            myHashMap.Add("2", "or");
            myHashMap.Add("3", "not");
            myHashMap.Add("4", "to");
            myHashMap.Add("5", "be");
            string hashS = myHashMap.Get("5");
            Console.WriteLine(hashS);

            MyMapNode<String, String> myHashMap2 = new MyMapNode<string, string>(20);
            string sentence = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] words = sentence.Split(" ");
            int keys = 0;
            foreach(string word in words)
            {
                int k = keys++;
                string key = k.ToString();
                myHashMap2.Add(word,key);
            }

            string value = myHashMap2.Get("Paranoids");
            myHashMap2.GetArrayPosition(value);
            myHashMap2.Remove("avoidable");          
        }
    }
}
