package com.company;

import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;

public class CopyJpgFile {
    public static void main(String[] args) throws IOException {
        FileInputStream f1 = new FileInputStream("E:\\JavaHomework\\Streams-and-Files\\src\\com\\company\\neverwinter.jpg");
        FileOutputStream f2 = new FileOutputStream("E:\\JavaHomework\\Streams-and-Files\\src\\com\\company\\my-copied-picture.jpg");
        int byteContainer;
        while((byteContainer = f1.read())!=-1)
        {
            f2.write(byteContainer);
        }
        f2.close();
        f2.close();
    }
}
