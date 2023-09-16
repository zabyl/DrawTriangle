public static class CreateTriangle
{
    public static void DrawTriangle(int length)
    {
        for (int i = 0; i < length + 1; i++)
        {
            for (int j = 0; j < length - i; j++)
            {
                Console.Write("");
            }
            for (int k = 0; k < i; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    }
}