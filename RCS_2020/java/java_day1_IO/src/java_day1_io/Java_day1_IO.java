/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package java_day1_io;

import java.util.Scanner;


/**
 *
 * @author janis
 */
public class Java_day1_IO {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        System.out.println("Hello world!");
        
        // int - vesels skaitls
        // double, float - skaitls ar komatu
        // String - simbolu virkne 
        // char - viens simbols
        // boolean - true vai false
        //  sout 
        
//        int a = 10;
//        int b = 12;
//        int c = a + b + 12;
//        
//        System.out.println(a);
//        a = 12;
//        System.out.println(a+b);
//        
//        String string = "example string";
//        String sumString = string + ", some other text";
//        System.out.println(sumString);
//
//        Scanner sc = new Scanner (System.in);
//        System.out.println("Ievadiet tekstu:");
//        String input = sc.nextLine();
//        
//        System.out.println(input);

        Scanner sc = new Scanner (System.in);
        System.out.println("Ievadi savu vardu:");
        String vards = sc.nextLine();
        System.out.println("Sveiks, " + vards + "!");


    }
    
}
