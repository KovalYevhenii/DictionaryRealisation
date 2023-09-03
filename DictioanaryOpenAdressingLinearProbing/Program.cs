
namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary dictionary = new(32);
           
            dictionary.Add(0, "V 0"); 
            dictionary.Add(32, "Value32");
            dictionary.Add(25, "Value25");
            dictionary.Add(7, "Value7");
            dictionary.Add(3, "Value3");
            dictionary.Add(12, "Value12");
            dictionary.Add(20, "Value20");
            dictionary.Add(18, "Value18");
            dictionary.Add(29, "Value29");
            dictionary.Add(5, "Value5");
            dictionary.Add(21, "Value21");
            dictionary.Add(9, "Value9");
            dictionary.Add(27, "Value27");
            dictionary.Add(8, "Value8");
            dictionary.Add(23, "Value23");
            dictionary.Add(14, "Value14");
            dictionary.Add(17, "Value17");
            dictionary.Add(22, "Value22");
            dictionary.Add(6, "Value6");
            dictionary.Add(31, "Value31");
            dictionary.Add(24, "Value24");
            dictionary.Add(11, "Value11");
            dictionary.Add(30, "Value30");
            dictionary.Add(16, "Value16");
            dictionary.Add(4, "Value4");
            dictionary.Add(26, "Value26");
            dictionary.Add(1, "Value1");
            dictionary.Add(13, "Value13");
            dictionary.Add(19, "Value19");
            dictionary.Add(28, "Value28");
            dictionary.Add(2, "Value2");
            dictionary.Add(234, "Value234");
            dictionary.Add(64, "Value64");
            dictionary.Add(64, "Value64");
            dictionary.Add(65, "Value65");
            dictionary.Add(66, "Value65");
     
            Console.WriteLine(dictionary[66]);
            Console.WriteLine(dictionary[0]);
            Console.WriteLine(dictionary[32]);
            Console.WriteLine(dictionary[1]);
            Console.WriteLine(dictionary[-1]);         
        }
    }
}
