namespace varyakras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            string voice = animal.GetVoice();
            Console.WriteLine(voice);
        }
    }
}