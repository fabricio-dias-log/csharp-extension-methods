namespace ExtensionMethods;

class Program {
    static void Main(string[] args) {
        DateTime dt = new DateTime(2025, 06, 28, 20, 10, 45);
        Console.WriteLine(dt.ElapsedTime());
        
        string s1 = "This is a very long string that needs to be cut off at some point.";
        Console.WriteLine(s1.Cut(15));
    }
}