/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package day2_io_if;

import java.util.Scanner;

/**
 *
 * @author janis
 */
public class Day2_IO_if {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {

        // ievada 1. skaitli
        // ievada 2. skaitli
        // ievada 3. skailti - + 
        // ja sk3 ir neagativas vai nulle, tas sk1 - sk2
        // ja sk3 ir pozitivs, tad saskaitam sk1 +sk2
        Scanner sc = new Scanner(System.in);
        System.out.println("Ievadi 1. skaitli:");
        int intOne = sc.nextInt();
        System.out.println("Ievadi 2. skaitli:");
        int intTwo = sc.nextInt();
        System.out.println("Ievada operaciju:");
        String operation = sc.next();

        if ("+".equals(operation)) {
            System.out.println(intOne + intTwo);
        } else if ("-".equals(operation)) {
            System.out.println(intOne - intTwo);
        } else {
            System.out.println("Ievadita neatlauta operacija!!!");
        }

    }

    public static void stringOutput() {
        Scanner sc = new Scanner(System.in);
        System.out.println("Ievadi pirmo skaitli:");
        double b = sc.nextDouble();
        System.out.println("Ievadi otro skiatli:");
        double c = sc.nextDouble();
        System.out.print("Skaitļu summa:");

        System.out.println(b + c);
    }

    static void textOutput(String inputText) {
        System.out.println("The input text:" + inputText);
    }

}
