/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package java2.bai13;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 *
 * @author Minh
 */
public class Zoo {

    List<Chuong> DanhSachChuong = new ArrayList<>();
    Scanner input = new Scanner(System.in);

    public Chuong getChuong(int maChuong) {
        for (int i = 0; i < DanhSachChuong.size(); i++) {
            if (DanhSachChuong.get(i).getMaChuong() == maChuong) {
                return DanhSachChuong.get(i);
            }
        }
        return null;
    }

    public void themChuong(Chuong c) {
        DanhSachChuong.add(c);
    }

    public void xoaChuong(int maChuong) {
        for (int i = 0; i < DanhSachChuong.size(); i++) {
            if (DanhSachChuong.get(i).getMaChuong() == maChuong) {
                DanhSachChuong.remove(i);
                break;
            }
        }
    }

    public void themConVat() {
        System.out.println("Nhap ma chuong muon them: ");
        for (int i = 0; i < DanhSachChuong.size(); i++) {
            System.out.println(DanhSachChuong.get(i).getMaChuong());
        }

        int chonChuong = Integer.parseInt(input.nextLine());

        System.out.println("Nhap loai con vat: ");
        System.out.println("1. Tiger");
        System.out.println("2. Dog");
        System.out.println("3. Cat");

        int choose = Integer.parseInt(input.nextLine());

        Animal animal = null;
        switch (choose) {
            case 1:
                animal = new Tiger();
                break;
            case 2:
                animal = new Dog();
                break;
            case 3:
                animal = new Cat();
                break;
            default:
                System.err.println("Nhap sai.");
                break;
        }
        animal.nhapConVat();

        Chuong chuong = getChuong(chonChuong);
        if (chuong != null) {
            chuong.themConVat(animal);
        }
    }

    public void xoaConVat() {
        System.out.println("Nhap ten con vat muon xoa: ");
        String xoaTen = input.nextLine();

        for (Chuong chuong : DanhSachChuong) {
            chuong.xoaConVat(xoaTen);
        }
    }

    public void hienThiAll() {
        for (Chuong chuong : DanhSachChuong) {
            chuong.hienThiAll();
        }
    }
}
