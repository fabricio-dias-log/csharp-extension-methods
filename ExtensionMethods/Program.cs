namespace ExtensionMethods;

class Program {
    static void Main(string[] args) {
        DateTime dt = new DateTime(2025, 07, 28, 20, 10, 45);
        Console.WriteLine(dt.ElapsedTime());
    }
}