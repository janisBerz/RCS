/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package day3_if_methods;

import java.util.Scanner;

/**
 *
 * @author janis
 */
public class Day3_if_methods {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        
        String strg = sumStrings("qwerty-","azerty-","matroshka");
        
        System.out.println(strg);
    }
    
    static String sumStrings(String text1, String text2, String text3){
        
        String returnString = text1 + text2 + text3;
        return returnString;
    }
    
    
    static void sum(int a, int b){
        System.out.println(a+b);
    }

    static void task4(){
        Scanner sc = new Scanner(System.in);
        
        System.out.println("Ievaid vardu: ");
        String a = sc.nextLine();
        System.out.println("Uzmini vardu:");
        String b = sc.nextLine();
        
        if (a.equals(b)) {
            System.out.println("Uzmineji");
            
        }else{
            System.out.println("Neuzmineji!!!");
        }
        
        
        
        
        
    }
    
    static void task3() {
        Scanner sc = new Scanner(System.in);
        String inputString = sc.nextLine();

        System.out.println("Ievadi virkni: ");
        int stringLenght = inputString.length();

        if (stringLenght >= 3 && stringLenght <= 8) {
            System.out.println("Viss ok");
        } else {
            System.out.println("Nav ok");
        }
    }

    static void task1() {

        Scanner sc = new Scanner(System.in);

        System.out.println("Ievadi tekstu:");
        String a = sc.nextLine();

        int stringLenght = a.length();

        if (stringLenght > 8) {
            System.out.println("Nepareizi!");
        } else if (stringLenght < 8) {
            System.out.print("Tavs teksts ir:");
            System.out.println(a);
        } else {
            System.out.println("Vertibas vienadas");
        }
    }

    static void task2() {

        Scanner sc = new Scanner(System.in);

        System.out.println("Ievadi pirmo skailti:");
        Double sk1 = sc.nextDouble();

        System.out.println("Ievadi otro skaitli:");
        Double sk2 = sc.nextDouble();

        System.out.println("Ievadi operaciju:");
        String op = sc.next();

        switch (op) {
            case "+":
                System.out.println("Summa: " + (sk1 + sk2));
                break;
            case "-":
                System.out.println("Starpiba: " + (sk1 - sk2));
                break;
            case "*":
                System.out.println("Reizinajums: " + (sk1 * sk2));
                break;
            case "/":
                System.out.println("Dalijums: " + (sk1 / sk2));
                break;
            default:
                System.out.println("Ievadi operaciju!!!");
        }
    }

    static void exampleIf() {
        Scanner sc = new Scanner(System.in);

        System.out.println("Ievadiet pirmo skailti");

        int sk1 = sc.nextInt();

        System.out.println("Ievadiet otro skailti");

        int sk2 = sc.nextInt();

        if (sk1 > sk2) {
            System.out.println("Lielaks ir" + sk1);
        } else if (sk1 < sk2) {
            System.out.println("Lielaks ir" + sk2);
        } else {
            System.out.println("Abi skailti ir vienadi");
        }

    }

}
