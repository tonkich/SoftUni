package com.company;

import java.util.ArrayList;
import java.util.Scanner;

public class SequenceOfEqualStrings {
    public static void main(String args[]){
        Scanner input = new Scanner(System.in);
        String text = input.nextLine();
        String[] arrayOfStrings = text.split(" ");
        ArrayList<String> results = new ArrayList<String>();
        results.add(arrayOfStrings[0]);

        if (arrayOfStrings.length == 1) {
            System.out.println(arrayOfStrings[0]);
        }

        for (int i = 0; i < arrayOfStrings.length - 1; i++) {
            if (arrayOfStrings[i].equals(arrayOfStrings[i + 1])) {
                results.add(arrayOfStrings[i + 1]);
                if (i == arrayOfStrings.length - 2) {
                    printSequence(results);
                }
            } else {
                printSequence(results);
                System.out.println();
                results.clear();
                results.add(arrayOfStrings[i + 1]);
                if (i == arrayOfStrings.length - 2) {
                    printSequence(results);
                }
            }
        }

    }

    public static void printSequence(ArrayList<String> results) {
        for (String result : results) {
            System.out.print(result + " ");
        }
    }
}
