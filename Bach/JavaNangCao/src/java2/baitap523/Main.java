/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package java2.baitap523;

/**
 *
 * @author Admin
 */
public class Main {
    public static void main(String[] args) throws InterruptedException {
        Thread1 t1 = new Thread1();
        Thread2 t2 = new Thread2();
        
        t1.start();
        t2.start();
        
        t1.join();
        t2.join();
        
        System.out.println("Hien thi ket qua sinh ra ngau nhien cua 2 Thread 1 & 2");
        System.out.println("T1: ");
        for (int i = 0; i < t1.list.size(); i++) {
            System.out.println("" + t1.list.get(i));
        }
        
        System.out.println("T2: ");
        for (int i = 0; i < t2.list.size(); i++) {
            System.out.println("" + t1.list.get(i));
        }
    }
}
