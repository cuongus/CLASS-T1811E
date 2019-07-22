/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package kt45p;

/**
 *
 * @author VUONG GIA BAO
 */
public class PhoneNumber {
    private String type;
    private String number;

    public String getType() {
        return type;
    }

    public String getNumber() {
        return number;
    }

    public void setType(String type) {
        this.type = type;
    }

    public void setNumber(String number) {
        this.number = number;
    }

    @Override
    public String toString() {
        return "PhoneNumber{" + "type=" + type + ", number=" + number + '}';
    }
    
    
     
}