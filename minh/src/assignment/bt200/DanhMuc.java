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
public class DanhMuc {

    String maDM;
    String tenDM;

    public DanhMuc() {
    }

    public DanhMuc(String maDM) {
        this.maDM = maDM;
    }

    public DanhMuc(String maDM, String tenDM) {
        this.maDM = maDM;
        this.tenDM = tenDM;
    }

    public String getMaDM() {
        return maDM;
    }

    public void setMaDM(String maDM) {
        this.maDM = maDM;
    }

    public String getTenDM() {
        return tenDM;
    }

    public void setTenDM(String tenDM) {
        this.tenDM = tenDM;
    }

    public void input() {
        Scanner input = new Scanner(System.in);

        System.out.println("Nhap ma danh muc: ");
        maDM = input.nextLine();
        System.out.println("Nhap ten danh muc: ");
        tenDM = input.nextLine();
    }

    @Override
    public String toString() {
        return "DanhMuc{" + "Ma danh muc: " + maDM + ", Ten danh muc: " + tenDM + '}';
    }

    public void display() {
        System.out.println(toString());
    }

}
