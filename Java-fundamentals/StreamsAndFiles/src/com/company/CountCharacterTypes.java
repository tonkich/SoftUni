package com.company;

import java.io.*;

public class CountCharacterTypes {
    public static void main(String[] args) throws IOException {
        String vowelSymbols = "aoeiou";
        String punctuationSymbols = "!,.?";
        Integer vowels = 0;
        Integer consonants = 0;
        Integer punctuation = 0;
        FileInputStream f1 = null;
        try {
            f1 = new FileInputStream(new File("E:\\JavaHomework\\Streams-and-Files\\src\\com\\company\\words.txt"));
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        }
        FileWriter f2 = null;
        try {
            f2 = new FileWriter(new File("E:\\JavaHomework\\Streams-and-Files\\src\\com\\company\\count-chars.txt"));
        } catch (IOException e) {
            e.printStackTrace();
        }
        int symbol;
        while((symbol = f1.read())!=-1){
            char ch = (char)symbol;
            if(vowelSymbols.contains(ch+"")){
                vowels++;
            }else if(punctuationSymbols.contains(ch+"")){
                punctuation++;
            }else if(Character.isLetter(ch)){
                consonants++;
            }
        }
        f2.write(String.format("Vowels: %d%n",vowels));
        f2.write(String.format("Consonants: %d%n",consonants));
        f2.write(String.format("Punctuation: %d%n",punctuation));
        f1.close();
        f2.close();
        }

}

