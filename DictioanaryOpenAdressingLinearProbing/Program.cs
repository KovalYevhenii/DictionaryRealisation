namespace DictioanaryOpenAdressingLinearProbing
{
    internal class Program
    {
        static void Main(string[] args)
        {

            OtusDictionary dictionary = new();
            dictionary.Add(1, "hello");
            dictionary.Add(-1, "world");
            dictionary.Get(1);

        }
    }
}