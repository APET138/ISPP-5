import java.util.Scanner;
public class TriangleType {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Введите длину стороны a: ");
        double a = scanner.nextDouble();
        System.out.print("Введите длину стороны b: ");
        double b = scanner.nextDouble();
        System.out.print("Введите длину стороны c: ");
        double c = scanner.nextDouble();
        if (isTriangle(a, b, c))
        {
            System.out.println("Такой треугольник может существовать.");

            if (isEquilateral(a, b, c))
            {
                System.out.println("Треугольник равносторонний.");
            }
            else if (isIsosceles(a, b, c))
            {
                System.out.println("Треугольник равнобедренный.");
            }
            else if (isRightAngled(a, b, c))
            {
                System.out.println("Треугольник прямоугольный.");
            }
            else
            {
                System.out.println("Треугольник разносторонний.");
            }
        }
        else
        {
            System.out.println("Такой треугольник не существует.");
        }
    }
    public static boolean isTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }
    public static boolean isEquilateral(double a, double b, double c)
    {
        return a == b && b == c;
    }
    public static boolean isIsosceles(double a, double b, double c)
    {
        return a == b || a == c || b == c;
    }
    public static boolean isRightAngled(double a, double b, double c)
    {
        double[] sides = {a, b, c};
        java.util.Arrays.sort(sides);
        return Math.pow(sides[0], 2) + Math.pow(sides[1], 2) == Math.pow(sides[2], 2);
    }
}