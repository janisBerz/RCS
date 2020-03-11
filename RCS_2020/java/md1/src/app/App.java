package app;

import java.util.Scanner;

import org.omg.CORBA.portable.ValueOutputStream;

public class App {
    public static void main(String[] args) throws Exception {
        System.out.println("--- 1. Uzdevums ---");
        // task1();

        System.out.println("--- 2. Uzdevums ---");
        // task2();

        System.out.println("--- 3. Uzdevums ---");
         task3();
    }

    static void task1() {
        Scanner sc = new Scanner(System.in);

        System.out.println("Ievadi 1. skaitli:");
        Double sk1 = sc.nextDouble();

        System.out.println("Ievadi 2. skaitli:");
        Double sk2 = sc.nextDouble();

        System.out.println("Ievadi 3. skaitli:");
        Double sk3 = sc.nextDouble();

        System.out.println("Summa: " + (sk1 + sk2 + sk3));

        sc.close();
    }

    static void task2() {
        Scanner sc = new Scanner(System.in);

        System.out.println("Ievadi savu vardu:");
        String firstName = sc.nextLine();

        System.out.println("Ievadi savu vecumu:");
        int age = sc.nextInt();

        System.out.println(String.format("%s ir %s gadus vecs.", firstName, age));
        sc.close();
    }

    static void task3() {
        Scanner sc = new Scanner(System.in);

        System.out.println("Ievadi pirmo skailti:");
        int intOne = sc.nextInt();

        System.out.println("Ievadi otro vecumu:");
        int intTwo = sc.nextInt();

        if (intOne > intTwo) {
            System.out.println(intOne);
        }else{
            System.out.println(intTwo);
        }
        sc.close();
    }

}