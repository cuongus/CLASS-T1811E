/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package bai527;


/**
 *
 * @author VUONG GIA BAO
 */
public class Student {

    private String fullname;
    private String email;
    private String address;
    private String birthday;
    private String gender;
    

    public Student() {
    }

    public Student(String fullname, String email, String address, String birthday, String gender) {
        this.fullname = fullname;
        this.email = email;
        this.address = address;
        this.birthday = birthday;
        this.gender = gender;
    }

   

    public String getFullname() {
        return fullname;
    }

    public void setFullname(String fullname) {
        this.fullname = fullname;
    }

    public String getBirthday() {
        return birthday;
    }

    public void setBirthday(String birthday) {
        this.birthday = birthday;
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

    public String getGender() {
        return gender;
    }

    public void setGender(String gender) {
        this.gender = gender;
    }

   
       
    @Override
    public String toString() {
        return "Student{" + "fullname=" + fullname + ", birthday=" + birthday + ", email=" + email + ", address=" + address + ", gender=" + gender + '}';
    }
    
    
}
