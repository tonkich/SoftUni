package com.company;
import java.io.*;
import java.util.ArrayList;

public class SaveAnArrayListOfDoubles {
    public static void main(String[] args) throws IOException, ClassNotFoundException {
        ObjectOutputStream oos = new ObjectOutputStream( new FileOutputStream(
                "E:\\JavaHomework\\Streams-and-Files\\src\\com\\company\\doubles.list"));
        ArrayList<Double> doubles = new ArrayList<>();
        doubles.add(1313.6);
        doubles.add(1717.5);
        doubles.add(1.46);
        oos.writeObject(doubles);
        oos.flush();
        ObjectInputStream ois = new ObjectInputStream(
                new FileInputStream("E:\\JavaHomework\\Streams-and-Files\\src\\com\\company\\doubles.list"));
        System.out.println(ois.readObject());
        ois.close();
    }
}

