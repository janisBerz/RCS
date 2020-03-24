/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package day8;

import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.IntStream;

/**
 *
 * @author janis
 */
public class Day8 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        getTheBiggest();
    }

    public static void getTheBiggest() {

        Scanner sc = new Scanner(System.in);

        int[] intArray = new int[8];
        for (int i = 1; i < 7; i++) {
            System.out.print(String.format("Ievadi %s. skaitli: ", i));
            intArray[i] = sc.nextInt();
        }

        int[] array23 = IntStream.of(intArray).sorted().toArray();

        System.out.println("Lielakais skaitlis: " + array23[7]);

    }

    public static void guessMe() {

        Scanner sc = new Scanner(System.in);
        System.out.print("Gamer 1#, enter the secret name: ");
        String playerOneSecret = sc.nextLine();

        int i = 0;
        int attempts = 5;

        while (true) {

            System.out.print("Gamer 2# guess the secret: ");
            String choice = sc.nextLine();

            if (choice.equals(playerOneSecret)) {

                System.out.println("Gamer 2# won!");
                break;
            }
            if (i > attempts) {
                System.out.println("Gamer 1# won! The secret is: " + playerOneSecret);
                break;
            }

            i++;
            System.out.println(String.format("You have %s attempts left!", (attempts - i)));
        }
    }

    public static void toContinue() {
        Scanner sc = new Scanner(System.in);
        int inputNum = 0;
        int inputNumSum = 0;

        String e = "y";

        while (e.equals("y")) {
            System.out.println("Ivadi skaitli: ");
            inputNum = sc.nextInt();
            sc.nextLine();
            inputNumSum += inputNum;

            System.out.println("Velies turpinat (y/n)?: ");
            e = sc.nextLine();
            if (e.equals("n")) {
                break;
            }
        }
        System.out.println("Skatlu summa: " + inputNumSum);
    }

}
