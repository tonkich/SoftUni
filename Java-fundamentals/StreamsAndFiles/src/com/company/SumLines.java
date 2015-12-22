package com.company;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;

public class SumLines {
    public static void main(String[] args) {
        BufferedReader br = null;
        try {
            String sCurrentLine;
            br = new BufferedReader(new FileReader("E:\\JavaHomework\\Streams-and-Files\\lines.txt"));
            while ((sCurrentLine = br.readLine()) != null) {
                int total = 0;
                for (int i=0; i < sCurrentLine.length(); i++)
                {
                    char c =sCurrentLine.charAt(i);
                    total = total + c;
                }
                System.out.println(total);
            }
        } catch (IOException e) {
            e.printStackTrace();
        } finally {
            try {
                if (br != null)br.close();
            } catch (IOException ex) {
                ex.printStackTrace();
            }
        }
    }
}

