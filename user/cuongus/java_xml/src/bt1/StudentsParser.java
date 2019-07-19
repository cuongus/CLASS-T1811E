/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package bt1;

import java.util.ArrayList;
import java.util.List;
import org.xml.sax.Attributes;
import org.xml.sax.SAXException;
import org.xml.sax.helpers.DefaultHandler;

/**
 *
 * @author anthony_jsc
 */
public class StudentsParser extends DefaultHandler{
    //List<Students> studentList = new ArrayList<>();
    ArrayList<Students> studentList = new ArrayList<>();
    Students std;
    
    boolean isFullname = false, isEmail = false, isAddress = false;
    
    public StudentsParser() {
    }
    
    public void showAll() {
        studentList.forEach((student) -> {
            System.out.println(student);
        });
    }

    @Override
    public void startElement(String uri, String localName, String qName, Attributes attributes) throws SAXException {
        if(qName.equalsIgnoreCase("student")) {
            std = new Students();
        } else if(qName.equalsIgnoreCase("fullname")) {
            isFullname = true;
        } else if(qName.equalsIgnoreCase("email")) {
            isEmail = true;
        } else if(qName.equalsIgnoreCase("address")) {
            isAddress = true;
        }
    }

    @Override
    public void endElement(String uri, String localName, String qName) throws SAXException {
        if(qName.equalsIgnoreCase("student")) {
            studentList.add(std);
        } else if(qName.equalsIgnoreCase("fullname")) {
            isFullname = false;
        } else if(qName.equalsIgnoreCase("email")) {
            isEmail = false;
        } else if(qName.equalsIgnoreCase("address")) {
            isAddress = false;
        }
    }

    @Override
    public void characters(char[] ch, int start, int length) throws SAXException {
        if(isFullname) {
//            System.out.println(new String(ch, start, length));
            std.setFullname(new String(ch, start, length));
        } else if(isAddress) {
            std.setAddress(new String(ch, start, length));
        } else if(isEmail) {
            std.setEmail(new String(ch, start, length));
        }
    }
}
