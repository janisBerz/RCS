/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package day4_methodswithreturn;

import java.util.ArrayList;
import java.util.Scanner;

/**
 *
 * @author janis
 */
public class Day4_MethodsWithReturn {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
    
    Scanner sc = new Scanner(System.in);
    String inputString = null;
    
        
        while(inputString.length() > 0){
            System.out.print("Ievadi tekstu: ");
            inputString = sc.next();
            stringArray.add(inputString);
        }
        
        String joined = String.join(", ", stringArray);
        
        String stringSumm = sumStrings(joined);
        System.out.println();

    }
    

    static String sumStrings(String args) {

        String a = null;
        for (String i : args) {
            a += i;
        }
        return a;
    }

}
