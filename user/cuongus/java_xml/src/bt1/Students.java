/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package bt1;

/**
 *
 * @author anthony_jsc
 */
public class Students {
    String fullname, email, address;

    public Students() {
    }

    public Students(String fullname, String email, String address) {
        this.fullname = fullname;
        this.email = email;
        this.address = address;
    }

    public String getFullname() {
        return fullname;
    }

    public void setFullname(String fullname) {
        this.fullname = fullname;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getAddress() {
        return address;
    }

    public void setAddress(String address) {
        this.address = address;
    }

    @Override
    public String toString() {
        return "Student{" + "fullname=" + fullname + ", email=" + email + ", address=" + address + '}';
    }
}
