/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package java2.bai13;

/**
 *
 * @author Minh
 */
public class Dog extends Animal {

    public Dog() {
    }

    public Dog(String Ten) {
        super(Ten);
    }

    public Dog(String Ten, int Tuoi) {
        super(Ten, Tuoi);
    }

    public Dog(String Ten, int Tuoi, String MoTa) {
        super(Ten, Tuoi, MoTa);
    }

    @Override
    public void tiengKeu() {
        System.out.println("Gau.");
    }

}
