namespace Humans
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                User user = new User("Ali", "veli", "shefteli", "Ali123");
                user.Age = 28;
                user.ShowFullData();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
