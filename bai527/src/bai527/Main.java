/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package bai527;

import java.io.FileInputStream;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author VUONG GIA BAO
 */
public class Main {
    public static void main(String[] args) {
        List<ClassRoom> classList = new ArrayList<>();
        int choose;
        Scanner input = new Scanner(System.in);
        String content = getContentFromFile("student.json");
        JSONArray array = new JSONArray(content);
        List<Student> studentList = new ArrayList<>();

        do{
            showMenu();
            choose = Integer.parseInt(input.nextLine());
            switch(choose){
                case 1: 
                   
                    for (int i = 0; i < array.length(); i++) {
                        JSONObject obj = array.getJSONObject(i);

                        Student std = new Student();
                        std.parser(obj);

                        studentList.add(std);
                    }

                    
                    break;
                case 2:
                    for (Student student : studentList) {
                        System.out.println(student);
                    }
                    
                    break;
                case 3:
                    break;
                default:
                    System.err.println("Nhap so menu sai");
                    break;
            }
        }while (choose != 3);
    }
    static void showMenu(){
        System.out.println("1. Nhap thong tin sinh vien tu file Json.");
        System.out.println("2. Hien thi thong tin sinh vien.");
        System.out.println("3. Luu thong tin lop hoc");
    }

    private static String getContentFromFile(String filename) {
        //throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
        FileInputStream fis = null;
        
        StringBuilder builder = new StringBuilder();
        
        try {
            fis = new FileInputStream(filename);
            int read;
            while((read = fis.read()) != -1) {
                builder.append((char) read);
            }
        } catch(Exception e) {
        } finally {
            if(fis != null) {
                try {
                    fis.close();
                } catch (IOException ex) {
                    Logger.getLogger(Main.class.getName()).log(Level.SEVERE, null, ex);
                }
            }
        }
        
        return builder.toString();
    }
}