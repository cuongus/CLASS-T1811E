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
public class Gender {
 private String type;

    public String getType() {
        return type;
    }

    public void setType(String type) {
        this.type = type;
    }

    @Override
    public String toString() {
        return "Gender{" + "type=" + type + '}';
    }
    
    
}