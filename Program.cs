internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Konsolda üçgen çizmek için lütfen derinlik giriniz: ");
        int depth = Convert.ToInt32(Console.ReadLine());

        CreateTriangle.DrawTriangle(depth);

    }
}