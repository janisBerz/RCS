package app;

import java.util.Scanner;

public class App {
    public static void main(String[] args) throws Exception {
        createArray();
    }

    public static void createArray() {

        String[] stringArray = new String[3];
        Scanner sc = new Scanner(System.in);

        for (int i = 0; i < stringArray.length; i++) {

            System.out.println(String.format("Ievadi %s. skaitli", i));
            stringArray[i] = sc.next();
        }

        for (int i = 0; i < stringArray.length; i++) {
            System.out.println(String.format("Masiva indekss %s. vertiba: %s", i, stringArray[i]));
        }

    }

}