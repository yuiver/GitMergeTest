namespace ConsoleApp1
<<<<<<< HEAD
{    
    // 2023/03/08 Ruler Class Position Change
=======
{
    public class Program
    {

        static void Main(string[] args)
        {
            //  {       2023. 03. 08. make user input system. /Beta
            string userInput = string.Empty;
            Console.WriteLine("This Program Change Cm to Inch");
            Console.Write("Input Cm");
            userInput = Console.ReadLine();

            int cmInput = 0;
            int.TryParse(userInput, out cmInput);
            
            Ruler ruler = new Ruler(cmInput);
            //  {       2023. 03. 08. make user input system. /Beta
            ruler.Run();
        }       //Main(string[] args)
    }       //Class Program
>>>>>>> origin/beta
    public class Ruler
    {
        private const float ONE_INCH = 2.54F;
        public int Centimeter { get; set; } = 0;
        public float Inch
        {
            get { return Centimeter * ONE_INCH; }
            private set { SetInch(value); }
        }       //float Inch
        public Ruler(int cmValue) { Centimeter = cmValue; }
        public void Run()
        {
            Console.WriteLine($"{Centimeter}cm 는 {Inch}inch 입니다.");
        }       //Run()
        private void SetInch(float InchValue)
        {
            Centimeter = (int)(InchValue / ONE_INCH);
        }       //SetInch()
    }       //Class Ruler
}