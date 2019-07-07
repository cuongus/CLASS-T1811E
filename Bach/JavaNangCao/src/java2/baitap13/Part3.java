/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package java2.baitap13;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 *
 * @author Admin
 */
public class Part3 {
    String source;

    public Part3() {
    }

    public Part3(String source) {
        this.source = source;
    }

    public String getSource() {
        return source;
    }

    public void setSource(String source) {
        this.source = source;
    }

    public void input() {
        Scanner input = new Scanner(System.in);

        System.out.println("Nhap chuoi: ");
        source = input.nextLine();
    }

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.println("Nhap N so chuoi:");
        int N = Integer.parseInt(input.nextLine());
        List<Part3> stringList = new ArrayList();
        List<StringBuilder> stringBuilder = new ArrayList();

        for (int i = 0; i < N; i++) {
            Part3 part3 = new Part3();
            System.out.printf("Nhap chuoi thu %d", i + 1);
            part3.input();

            stringList.add(part3);
        }

        String[] sourceSplit = part3.getSource().split("\\s");

        int count = 0;
        for (int i = 0; i < sourceSplit.length; i++) {
            if (part3.getSearching().equalsIgnoreCase(sourceSplit[i])) {
                count++;
            }
        }

        System.out.printf("Co %d tu '%s' trong chuoi '%s'.", count, part1.searching, part1.source);
    }
}
