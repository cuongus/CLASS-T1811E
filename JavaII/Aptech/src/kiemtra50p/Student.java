/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package kiemtra50p;

/**
 *
 * @author giangduy
 */
public class Student {
    private String firstName;
    private String lastName;
    private String age;
    private Address address;
    private PhoneNumber phoneNumber;
    private Gender gender;

    public void setFirstName(String firstName) {
        this.firstName = firstName;
    }

    public void setLastName(String lastName) {
        this.lastName = lastName;
    }

    public void setAge(String age) {
        this.age = age;
    }

    public void setAddress(Address address) {
        this.address = address;
    }

    public void setPhoneNumber(PhoneNumber phoneNumber) {
        this.phoneNumber = phoneNumber;
    }

    public void setGender(Gender gender) {
        this.gender = gender;
    }

    @Override
    public String toString() {
        return "Student{" + "firstName=" + firstName + ", lastName=" + lastName + ", age=" + age + ", address=" + address + ", phoneNumber=" + phoneNumber + ", gender=" + gender + '}';
    }

    public Student(String firstName, String lastName, String age, Address address, PhoneNumber phoneNumber, Gender gender) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.address = address;
        this.phoneNumber = phoneNumber;
        this.gender = gender;
    }

    void display() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
    
    
    
    
}
