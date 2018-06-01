namespace CsharpCentreMousePointer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the mouse pointer class
            // and run the method to centre the mouse pointer

            var MoveMousePointer = new CentreMouse();
            MoveMousePointer.MoveMouseToCentre();
        }
    }
}
