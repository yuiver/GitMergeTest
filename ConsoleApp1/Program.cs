namespace ConsoleApp1
{
    public class Program
    {

        static void Main(string[] args)
        {
            Ruler ruler = new Ruler(10);
            ruler.Run();
        }       //Main(string[] args)
    }       //Class Program
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