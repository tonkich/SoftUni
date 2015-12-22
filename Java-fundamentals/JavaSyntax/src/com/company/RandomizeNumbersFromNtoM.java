package com.company;

import java.util.Random;
import java.util.Scanner;
public class RandomizeNumbersFromNtoM {
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        int a = sc.nextInt();
        Scanner sc1 = new Scanner(System.in);
        int b = sc1.nextInt();
        Random rand = new Random();
        for (int i = a; i < b; i++) {
            int randomInteger = rand.nextInt((b-a)+1)+a;
            System.out.println("Random Integer in Java: " + randomInteger);
        }
    }
}