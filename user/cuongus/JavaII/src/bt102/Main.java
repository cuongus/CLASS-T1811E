/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package bt102;

import java.util.ArrayList;
import java.util.Scanner;

/**
 *
 * @author anthony_jsc
 */
public class Main {
    public static void main(String[] args) {
        
        ArrayList<String> list = new ArrayList<>();
        
        ArrayList<Integer> soNguyen = new ArrayList<>();
        
        Scanner input = new Scanner(System.in);
        String source;
        String searching;
        
        int strt = 0;
        int cnt = -1;
        int idx = -1;
        
        System.out.println("Nhap vao chuoi source: ");
        source = input.nextLine();
        System.out.println("Nhap vao chuoi searching: ");
        searching = input.nextLine();
        
         while (strt != -1)
            {
                strt = source.indexOf(searching, idx + 1);
                cnt += 1;
                idx = strt;
            }
        System.out.println("So lan xuat hien cua chuoi searching vua nhap: " + cnt);
        
        System.out.println("*------------------------------*");
        
        System.out.println("Nhap so phan tu cua mang: ");
        int m = Integer.parseInt(input.nextLine());
        for (int i = 0; i < m; i++) {
            System.out.println("Nhap phan tu thu "+ i + ":");
            int n = Integer.parseInt(input.nextLine());
            soNguyen.add(n);
        }
        
        System.out.println("*------------------------------*");
        
        for (int i = 0; i < soNguyen.size(); i++) {
            System.out.println("Phan tu thu " + i + ": " + soNguyen.get(i));
        }
    }
}
