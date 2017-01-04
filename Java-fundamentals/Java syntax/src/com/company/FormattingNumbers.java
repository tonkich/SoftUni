package com.company;
import java.util.Scanner;

public class FormattingNumbers {
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        int a = sc.nextInt();
        if  (500<=a || a<=0){
            throw new ArithmeticException("a must be between 0 and 500");
        }
        Scanner sc1 = new Scanner(System.in);
        double b = sc1.nextDouble();
        Scanner sc2 = new Scanner(System.in);
        double c = sc2.nextDouble();
        String aInBinaryString = Integer.toBinaryString(a);
        int aBin = Integer.parseInt(aInBinaryString);
        System.out.printf("|%-10X|%010d|%10.2f|%-10.3f|",a,aBin,b,c);
    }
}
