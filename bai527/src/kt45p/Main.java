/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package kt45p;

import java.io.BufferedInputStream;
import java.io.IOException;
import java.net.MalformedURLException;
import java.net.URL;
import java.util.Scanner;
import java.util.logging.Level;
import java.util.logging.Logger;



/**
 *
 * @author VUONG GIA BAO
 */
public class Main {
    private static Student[] list;
    
    public static void main(String[] args) {
        new Thread(() -> {
            try {
                String content = getContentFromURL("https://raw.githubusercontent.com/tranvandiep/T1811E/master/users/example.json");
                Gson gson = new Gson();
                list = gson.fromJson(content, Student[].class);
            }catch (IOException ex) {
                Logger.getLogger(Main.class.getName()).log(Level.SEVERE, null, ex);
            }
        }).start();
        
        int choose;
        Scanner input = new Scanner(System.in);
        
        do {
            showMenu();
            choose = input.nextInt();
            
            switch(choose) {
                case 1:
                    if(list != null) {
                        for (Student student : list) {
                            student.display();
                        }
                    }
                    break;
                case 2:
                    System.out.println("Exit");
                    break;
            }
        } while(choose != 2);
    }
    
    public static void showMenu() {
        System.out.println("1. Hiển thị dữ liệu ra màn hình");
        System.out.println("2. Thêm/sửa/xoá đối tượng ");
        System.out.println("3. Export dữ liệu ra file xml tương ứng ");
        System.out.println("4. Thoát");
    }
    
    public static String getContentFromURL(final String urlString)
        throws MalformedURLException, IOException {
        StringBuilder builder = new StringBuilder();
        
        BufferedInputStream in = null;
        try {
            in = new BufferedInputStream(new URL(urlString).openStream());

            final byte data[] = new byte[1024];
            int count;
            while ((count = in.read(data, 0, 1024)) != -1) {
                String result = new String(data, 0, count);
                builder.append(result);
            }
        } finally {
            if (in != null) {
                in.close();
            }
        }
        
        return builder.toString();
    }
}