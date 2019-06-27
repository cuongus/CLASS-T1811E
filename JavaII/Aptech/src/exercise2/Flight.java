/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package exercise2;

/**
 *
 * @author giangduy
 */
public class Flight {
    String destinnation;
    int number;
    private String destination;
    
   public Flight() {
       
    }

    public Flight(int number, String destination) {
        this.number = number;
        this.destination = destination;
    }

    @Override
    public String toString() {
        return "Flight{" + "number=" + number + ", destination=" + destination + '}';
    }
    
    public void display() {
        System.out.println(toString());
    }
    
    public String getDestination(){
        return destination;
    }
    
    public int getNumber(){
        return number;
    }
}
