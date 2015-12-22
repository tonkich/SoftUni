package com.company;
import java.io.*;

public class ALLCAPITALS {
    public static void main(String[] args) {
        BufferedReader bfr = null;
        try {
            bfr = new BufferedReader(
                    new FileReader("E:\\JavaHomework\\Streams-and-Files\\src\\com\\company\\lines1.txt"));

        String fullText = "";
        String tempStr;

        while ((tempStr = bfr.readLine()) != null) {
            fullText += tempStr.toUpperCase() + "\r\n";
        }

        PrintWriter prw = new PrintWriter(
                new BufferedWriter(
                        new FileWriter("E:\\JavaHomework\\Streams-and-Files\\src\\com\\company\\lines1.txt")));
        prw.write(fullText);
        prw.flush();
        bfr.close();
        prw.close();
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }

    }
}
