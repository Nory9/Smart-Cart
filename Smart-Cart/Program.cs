namespace Smart_Cart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                UserInterface userInterface = new UserInterface();
                userInterface.InterfaceFlow();
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.Message);
            }
            
            }
    }
}
