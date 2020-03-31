package app;

import java.util.Scanner;

public class App {
    public static void main(String[] args) throws Exception {
        reverseArrayElements();
    }

    public static void reverseArrayElements() {

        Scanner sc = new Scanner(System.in);
        int[] primaryArray = new int[4];
        int[] secondaryArray = new int[4];

        for (int i = 0; i < primaryArray.length; i++) {

            System.out.println(String.format("Ievadi %s. skaitli", i));
            primaryArray[i] = sc.nextInt();
        }

        for (int i = 0; i < secondaryArray.length; i++) {

            secondaryArray[i] = primaryArray[secondaryArray.length - 1 - i];
        }

        for (int i = 0; i < secondaryArray.length; i++) {
            System.out.print(secondaryArray[i] + " ");
        }

    }

}