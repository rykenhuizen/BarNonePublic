namespace ToText.ConsoleApp
{
    class Console
    {
        static void Main(string[] args)
        {
            var toText = new Business.ToText();
            
            System.Console.WriteLine( Business.ToText.GetText(@"C:\Users\Rykenhuizen\Documents\Source\BarNonePublic\SampleDocs\dummy.pdf"));
            System.Console.ReadLine();
        }
    }
}
