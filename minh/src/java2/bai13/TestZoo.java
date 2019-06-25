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
public class TestZoo {

    static Scanner input = new Scanner(System.in);
    static Zoo zoo = new Zoo();

    public static void main(String[] args) {
        List<Animal> animalList = new ArrayList<>();
        List<Chuong> DanhSachChuong = new ArrayList<>();
        int choose;

        do {
            menu();
            System.out.println("Choose: ");
            choose = Integer.parseInt(input.nextLine());

            switch (choose) {
                case 1:
                    themChuong();
                    break;
                case 2:
                    xoaChuong();
                    break;
                case 3:
                    themConVat();
                    break;
                case 4:
                    zoo.xoaConVat();
                    break;
                case 5:
                    zoo.hienThiAll();
                    break;
                case 6:
                    System.out.println("Goodbye!");
                    break;
                default:
                    System.err.println("Chon sai.");
                    break;
            }
        } while (choose != 6);

    }

    static void themChuong() {
        System.out.println("Nhap so chuong can them: ");
        int n = Integer.parseInt(input.nextLine());

        for (int i = 0; i < n; i++) {
            Chuong chuong = new Chuong();
            chuong.nhapChuong();

            zoo.themChuong(chuong);
        }
    }

    static void xoaChuong() {
        System.out.println("Nhap ma chuong muon xoa: ");
        int delChuong = Integer.parseInt(input.nextLine());

        zoo.xoaChuong(delChuong);
    }

    static void themConVat() {
        zoo.themConVat();
    }

    static void menu() {
        System.out.println("1. Them Chuong");
        System.out.println("2. Xoa Chuong");
        System.out.println("3. Them Con Vat");
        System.out.println("4. Xoa Con Vat");
        System.out.println("5. Xem tat ca con vat");
        System.out.println("6. Thoat");
    }
}
