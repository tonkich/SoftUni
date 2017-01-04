package com.company;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
public class GhettoNumeralSystem {
    public static void main(String[] args) {
        Scanner sc=new Scanner(System.in);
        System.out.println("Enter a number you want to convert to Ghetto Numeral System");
        int number = sc.nextInt();
        List<String> ghettoNumbersList = new ArrayList<String>();
        while(number > 0)
        {
            int lastDigit = number % 10;
            String ghettoNumber = ghettoNumberDatabase(lastDigit);
            ghettoNumbersList.add(ghettoNumber);
            number = number / 10;
        }
        for (int i = ghettoNumbersList.size() - 1; i >= 0; i--) {
            System.out.print(ghettoNumbersList.get(i));
        }
        System.out.println();
    }
    private static String ghettoNumberDatabase(int number){
        String[] ghettoNumeralSystem=new String[]{"Gee","Bro","Zuz","Ma","Duh","Yo","Dis","Hood","Jam","Mack"};
        String ghettoNumber = ghettoNumeralSystem[number];
        return ghettoNumber;
    }
}