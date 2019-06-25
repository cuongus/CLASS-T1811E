/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package java2.bai13;

import java.util.Scanner;

/**
 *
 * @author Minh
 */
public abstract class Animal {

    String Ten;
    int Tuoi;
    String MoTa;

    public Animal() {
    }

    public Animal(String Ten) {
        this.Ten = Ten;
    }

    public Animal(String Ten, int Tuoi) {
        this.Ten = Ten;
        this.Tuoi = Tuoi;
    }

    public Animal(String Ten, int Tuoi, String MoTa) {
        this.Ten = Ten;
        this.Tuoi = Tuoi;
        this.MoTa = MoTa;
    }

    public String getTen() {
        return Ten;
    }

    public void setTen(String Ten) {
        this.Ten = Ten;
    }

    public int getTuoi() {
        return Tuoi;
    }

    public void setTuoi(int Tuoi) {
        this.Tuoi = Tuoi;
    }

    public String getMoTa() {
        return MoTa;
    }

    public void setMoTa(String MoTa) {
        this.MoTa = MoTa;
    }

    public void nhapConVat() {
        Scanner input = new Scanner(System.in);

        System.out.println("Nhap ten: ");
        Ten = input.nextLine();

        System.out.println("Nhap tuoi: ");
        Tuoi = Integer.parseInt(input.nextLine());

        System.out.println("Nhap mo ta: ");
        MoTa = input.nextLine();
    }

    @Override
    public String toString() {
        return "Animal{" + "Ten=" + Ten + ", Tuoi=" + Tuoi + ", MoTa=" + MoTa + '}';
    }

    public void xemThongTin() {
        System.out.println(toString());
    }

    public abstract void tiengKeu();
}
