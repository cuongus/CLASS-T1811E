/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package bt527;

/**
 *
 * @author anthony_jsc
 */
public class Student {
    String fullname;
    String birthday;
    String email;
    String address;
    String gender;

    public Student() {
    }

    public Student(String fullname, String birthday, String email, String address, String gender) {
        this.fullname = fullname;
        this.birthday = birthday;
        this.email = email;
        this.address = address;
        this.gender = gender;
    }

    public String getFullname() {
        return fullname;
    }

    public String getBirthday() {
        return birthday;
    }

    public String getEmail() {
        return email;
    }

    public String getAddress() {
        return address;
    }

    public String getGender() {
        return gender;
    }

    public void setFullname(String fullname) {
        this.fullname = fullname;
    }

    public void setBirthday(String birthday) {
        this.birthday = birthday;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public void setAddress(String address) {
        this.address = address;
    }

    public void setGender(String gender) {
        this.gender = gender;
    }

    @Override
    public String toString() {
        return "Student{" + "fullname=" + fullname + ", birthday=" + birthday + ", email=" + email + ", address=" + address + ", gender=" + gender + '}';
    }
    
    
}
