/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package day6;

import java.util.Scanner;

/**
 *
 * @author janis
 */
public class Day6 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int positives = 0;
        int negatives = 0;
        int zeros = 0;
        
        //Double[] data;
        int[] data = new int[10];

        for (int i = 1; i < 11; i++) {
            System.out.println(String.format("Ievadi %s. sk.:", i));
            int inputInt = sc.nextInt();

            if (inputInt > 0) {
                positives++;
            }
            if (inputInt < 0) {
                negatives++;
            }
            if (inputInt == 0) {
                zeros++;
            }
            
            data[0] = positives;
            data[1] = negatives;
            data[2] = zeros;
            
        }
        System.out.println(String.format("Pozitivie sk.: %s., negativie sk.: %s, nulles: %s", data[0], data[1], data[2]));
    }

}
