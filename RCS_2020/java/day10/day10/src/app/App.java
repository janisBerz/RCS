package app;

import java.util.Scanner;

import javax.sound.sampled.SourceDataLine;

public class App {
    public static void main(String[] args) throws Exception {
        topPair();
    }

    static void topPair() {
        Scanner sc = new Scanner(System.in);
        int[] primaryArray = { 12, 24, 1, 4, 5 };

        int summa = Integer.MIN_VALUE;
        int x = 0;
        int y = 0;

        for (int i = 0; i < primaryArray.length; i++) {
            if (summa < primaryArray[i] + primaryArray[i + 1]) {
                summa = primaryArray[i] + primaryArray[i + 1];

                x = primaryArray[i];
                y = primaryArray[i+1];
            }
        }

        System.out.println(x+"," +y);

    }

    static void outputIndex() {

        Scanner sc = new Scanner(System.in);
        int[] primaryArray = { 12, 24, 1, 4, 5, 7, 8, 45, 54, 32 };

        System.out.println(String.format("Ievadi skaitli"));
        int inputInt = sc.nextInt();

        for (int i = 0; i < primaryArray.length; i++) {

            if (primaryArray[i] == inputInt) {
                System.out.print("Tavs skaitlis atrodas pozicija: " + i);
            }
        }
    }

    static void outputEven() {

        Scanner sc = new Scanner(System.in);
        int[] primaryArray = new int[3];
        // int[] secondaryArray = new int[primaryArray.length];

        for (int i = 0; i < primaryArray.length; i++) {

            System.out.println(String.format("Ievadi %s. skaitli", i));
            int inputInt = sc.nextInt();
            primaryArray[i] = inputInt;
        }

        for (int g = 0; g < primaryArray.length; g++) {

            if ((primaryArray[g] % 2) == 0) {
                System.out.print(primaryArray[g] + " ");
            }
        }

    }
}
