import java.util.Scanner;
public class Main
{
    public static void main(String[] args) {
        System.out.println("Введите количество баллов: ");
        Scanner sc = new Scanner(System.in);
        int a = sc.nextInt();

        if (a<=25)
            System.out.println("Несдача");

        if((a<=50)&&(a>25))
            System.out.println("Удовлетворительно");

        if((a<=75)&&(a>50))
            System.out.println("Хорошо");

        if((a<=100)&&(a>75))
            System.out.println("Отлично!");
    }
}