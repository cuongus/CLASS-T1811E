/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package bai13;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 *
 * @author giangduy
 */
public class Chuong {
    int maChuong;
    List<Animal> animalList = new ArrayList<>();
    Scanner input = new Scanner(System.in);

    public Chuong() {
    }

    public Chuong(int maChuong) {
        this.maChuong = maChuong;
    }

    public int getMaChuong() {
        return maChuong;
    }

    public void setMaChuong(int maChuong) {
        this.maChuong = maChuong;
    }

    public void nhapChuong() {
        System.out.println("Nhap ma chuong: ");
        maChuong = Integer.parseInt(input.nextLine());
    }

    public void themConVat(Animal a) {
        animalList.add(a);
    }

    public void xoaConVat(String ten) {
        for (int i = 0; i < animalList.size(); i++) {
            if (animalList.get(i).getTen().equalsIgnoreCase(ten)) {
                animalList.remove(i);
                break;
            }
        }
    }

    public void hienThiAll() {
        animalList.forEach((animal) -> {
            animal.xemThongTin();
        });
    }
}
