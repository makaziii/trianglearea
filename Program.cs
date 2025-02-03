class TriangleAreaCalculator
{
    static void Main()
    {
        //asking the user for the base
        System.Console.Write("Enter the base of the triangle: ");
        double baseSize = Convert.ToDouble(System.Console.ReadLine());

        System.Console.Write("Enter the height of the triangle: ");
        double height = Convert.ToDouble(System.Console.ReadLine());

        //Calculate the area
        double area = 0.5 * baseSize * height;

        //output the result
        System.Console.WriteLine($"The area of the triangle is: {area}");
    }
}
