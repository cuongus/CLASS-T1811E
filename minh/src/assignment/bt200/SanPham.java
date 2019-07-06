/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package assignment.bt200;

import java.util.Scanner;

/**
 *
 * @author Minh
 */
public class SanPham extends DanhMuc {

    String maSP;
    String tenSP;
    int giaSP;
    String ngayNhap;
    String ngayBan;
    String hanSD;
    String moTa;

    public SanPham() {
    }

    public SanPham(String maSP, String tenSP, int giaSP, String ngayNhap, String ngayBan, String hanSD, String moTa, String maDM, String tenDM) {
        super(maDM, tenDM);
        this.maSP = maSP;
        this.tenSP = tenSP;
        this.giaSP = giaSP;
        this.ngayNhap = ngayNhap;
        this.ngayBan = ngayBan;
        this.hanSD = hanSD;
        this.moTa = moTa;
    }

    public String getMaSP() {
        return maSP;
    }

    public void setMaSP(String maSP) {
        this.maSP = maSP;
    }

    public String getTenSP() {
        return tenSP;
    }

    public void setTenSP(String tenSP) {
        this.tenSP = tenSP;
    }

    public int getGiaSP() {
        return giaSP;
    }

    public void setGiaSP(int giaSP) {
        this.giaSP = giaSP;
    }

    public String getNgayNhap() {
        return ngayNhap;
    }

    public void setNgayNhap(String ngayNhap) {
        this.ngayNhap = ngayNhap;
    }

    public String getNgayBan() {
        return ngayBan;
    }

    public void setNgayBan(String ngayBan) {
        this.ngayBan = ngayBan;
    }

    public String getHanSD() {
        return hanSD;
    }

    public void setHanSD(String hanSD) {
        this.hanSD = hanSD;
    }

    public String getMoTa() {
        return moTa;
    }

    public void setMoTa(String moTa) {
        this.moTa = moTa;
    }

    public void input() {
        Scanner input = new Scanner(System.in);

        System.out.println("Nhap ma san pham: ");
        maSP = input.nextLine();

        System.out.println("Nhap ten san pham: ");
        tenSP = input.nextLine();

        System.out.println("Nhap gia: ");
        giaSP = Integer.parseInt(input.nextLine());

        System.out.println("Nhap ngay nhap: ");
        ngayNhap = input.nextLine();

        System.out.println("Nhap ngay ban: ");
        ngayBan = input.nextLine();

        System.out.println("Nhap han su dung: ");
        hanSD = input.nextLine();

        System.out.println("Nhap mo ta: ");
        moTa = input.nextLine();
    }

    @Override
    public String toString() {
        return "SanPham{" + "San pham: " + tenSP + ", Ma san pham: " + maSP + ", Gia: " + giaSP + ", Ngay nhap: " + ngayNhap + ", Ngay ban: " + ngayBan + ", Han su dung: " + hanSD + ", Mo ta: " + moTa + '}';
    }

    public void display() {
        System.out.println(toString());
    }

}
