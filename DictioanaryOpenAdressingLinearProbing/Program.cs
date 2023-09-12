
namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary dictionary = new();
    
            for (int i = 0; i < 66; i++)
            {
                dictionary.Add(i, $"{i}");
            }
       
            Console.WriteLine(dictionary.Get(32));
            Console.WriteLine(dictionary[1]);
            Console.WriteLine(dictionary[-1]);         
            Console.WriteLine(dictionary[77]);//EXCEPTION
        }
    }
}
