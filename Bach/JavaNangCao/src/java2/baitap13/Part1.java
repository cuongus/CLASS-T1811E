/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package java2.baitap13;

import java.util.Scanner;

/**
 *
 * @author Admin
 */
public class Part1 {
    String source;
    String searching;

    public Part1() {
    }

    public Part1(String source, String searching) {
        this.source = source;
        this.searching = searching;
    }

    public String getSource() {
        return source;
    }

    public void setSource(String source) {
        this.source = source;
    }

    public String getSearching() {
        return searching;
    }

    public void setSearching(String searching) {
        this.searching = searching;
    }

    public void input() {
        Scanner input = new Scanner(System.in);

        System.out.println("Nhap chuoi source: ");
        source = input.nextLine();
        System.out.println("Nhap chuoi searching: ");
        searching = input.nextLine();
    }

    public static void main(String[] args) {
        Part1 part1 = new Part1();
        part1.input();
        String[] sourceSplit = part1.getSource().split("\\s");

        int count = 0;
        for (int i = 0; i < sourceSplit.length; i++) {
            if (part1.getSearching().equalsIgnoreCase(sourceSplit[i])) {
                count++;
            }
        }

        System.out.printf("Co %d tu '%s' trong chuoi '%s'.", count, part1.searching, part1.source);
    }
}
