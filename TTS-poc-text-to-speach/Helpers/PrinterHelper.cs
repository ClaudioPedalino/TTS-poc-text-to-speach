namespace TTS_poc_text_to_speach.Helpers
{
    internal static class PrinterHelper
    {
        internal static void PrintInput(Person item)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Name: {item.FirstName} {item.LastName}");
            Console.WriteLine($"Email: {item.Email}\n");
            Console.ResetColor();
        }
    }
}
