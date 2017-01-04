package com.company;

import java.util.Scanner;

public class CalculateExpression {
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        double a = sc.nextDouble();
        Scanner sc1 = new Scanner(System.in);
        double b = sc1.nextDouble();
        Scanner sc2 = new Scanner(System.in);
        double c = sc2.nextDouble();
        double f1sqrt = (((a*a)+(b*b))/((a*a)-(b*b)));
        double f1pow = (a + b + c)/Math.sqrt(c);
        double f1 = Math.pow(f1sqrt,f1pow);
        double f02 = ((a*a)+(b*b)-Math.pow(c,3));
        double f002 = (a-b);
        double f2 = Math.pow(f02,f002);
        double avg1 = (a + b + c)/3;
        double avg2 = (f1 + f2)/2;
        double diff = avg1-avg2;
        System.out.printf("F1 result: %.2f; F2 result: %.2f; Diff: %.2f;",f1,f2,diff);
    }
}
