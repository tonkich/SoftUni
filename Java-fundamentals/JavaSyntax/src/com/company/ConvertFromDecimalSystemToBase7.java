package com.company;

import java.util.Scanner;

public class ConvertFromDecimalSystemToBase7 {
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        long a = sc.nextLong();
        int baseToConvertTo = 7;
        System.out.println(Long.toString(a, baseToConvertTo));
    }
}
