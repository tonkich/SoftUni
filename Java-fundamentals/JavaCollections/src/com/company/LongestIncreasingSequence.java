package com.company;

import java.util.Scanner;

public class LongestIncreasingSequence {
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine();
        String[] numbersArray = input.split(" ");

        int[] numbers = new int[numbersArray.length];
        numbers = convertToInt(numbersArray, numbers);

        int counter = 1;
        int maxLength = 1;
        int end = 0;

        System.out.println(numbers[0] + " ");
        for (int i = 1; i < numbers.length; i++)
        {
            if (numbers[i] > numbers[i - 1])
            {
                counter++;
                System.out.println(numbers[i] + " ");
            }
            else
            {
                counter = 1;
                System.out.println();
                System.out.print(numbers[i] + " ");
            }
            if (counter > maxLength)
            {
                maxLength = counter;
                end = i;
            }
        }
        System.out.println();
        System.out.print("Longest: ");
        for (int j = end - maxLength + 1; j <= end; j++)
        {
            System.out.print(numbers[j] + " ");
        }
    }

    private static int[] convertToInt(String[] numbersArray, int[] numbers) {
        for (int i = 0; i < numbersArray.length; i++) {
            numbers[i] = Integer.parseInt(numbersArray[i]);
        }
        return numbers;
    }
}
