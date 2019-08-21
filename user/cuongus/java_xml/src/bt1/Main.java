/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package bt1;

import javax.xml.parsers.SAXParser;
import javax.xml.parsers.SAXParserFactory;

/**
 *
 * @author anthony_jsc
 */
public class Main {
    public static void main(String[] args) throws Exception {
        // TODO code application logic here
        SAXParserFactory factory = SAXParserFactory.newInstance();
        SAXParser parser = factory.newSAXParser();
        
        StudentsParser haParser = new StudentsParser();
        
        parser.parse("stuInfor.xml", haParser);
        haParser.showAll();
    }
}
