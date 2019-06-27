/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package exercise1;

import java.util.Scanner;

/**
 *
 * @author giangduy
 */
public class Bank {
    double balance;
    double rate;
    
    public Bank(){
        
    }
    public Bank(double balance, double rate){
        this.balance = balance;
        this.rate = rate;
    }
    public void input() {
        Scanner input = new Scanner(System.in);
        
        
        System.out.println("nhap balance: ");
        balance = Double.parseDouble(input.nextLine());
        System.out.println("nhap rate: ");
        rate = Double.parseDouble(input.nextLine());
    }
    
    public double calculateInterest(){
        double interest;
        interest = balance * (rate / 1200);
        return interest;
    }
}



