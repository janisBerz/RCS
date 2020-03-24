/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package day7;

import java.util.Scanner;

/**
 *
 * @author janis
 */
public class Day7 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Ievadi skaitli a: ");
        int inputValueA = sc.nextInt();
        System.out.println("Ievadi skaitli b: ");
        int inputValueB = sc.nextInt();

        powerBy(inputValueA, inputValueB);
    }

    static void powerBy(int inputA, int inputB) {

        int hashStringB = inputA;

        for (int i = 1; i < inputB; i++) {
            

            hashStringB *= inputA; 
            
        }
        System.out.println(hashStringB);
    }

    static void calcHashMatrix(int inputA, int inputB) {

        for (int i = 0; i < inputA; i++) {
            String hashStringB = "";

            for (int a = 0; a < inputB; a++) {
                hashStringB += "#";
            }
            System.out.println(hashStringB);
        }
        System.out.println();
    }

    static void calcHashString(int inputInt) {

        String hashString = "";
        for (int i = 0; i < inputInt; i++) {
            hashString += "#";
        }
        System.out.println(hashString);
    }

    static int calcFak(int a) {

        int i = 0;

        int z = 0;

        while (i < a) {

            i++;
            a = i * i;
            System.out.println("i:" + i);
            System.out.println("rez: " + z);
        }

        return a;
    }

}
