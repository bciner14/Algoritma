using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Lütfen string ve index değerlerini giriniz (örnek: Algoritma,3):");

        while (true)
        {
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) break;

            try
            {
                InputParser parser = new InputParser();
                (string text, int index) = parser.ParseInput(input);

                StringModifier modifier = new StringModifier();
                string result = modifier.RemoveCharacterAtIndex(text, index);

                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
            }
        }
    }
}

