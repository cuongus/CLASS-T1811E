/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package vidu2;

/**
 *
 * @author anthony_jsc
 */
public class ClassRom {
    public int x, y;
    
    private static ClassRom instance = null;
    
    private ClassRom(){
    }
    
    public synchronized static ClassRom getInstance(){
        if(instance == null){
            instance = new ClassRom();
        }
        return instance;
    }
}
