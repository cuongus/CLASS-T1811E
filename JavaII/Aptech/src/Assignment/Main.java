/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Assignment;

import com.sun.corba.se.impl.orbutil.ObjectWriter;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.ObjectOutputStream;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import java.util.Scanner;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author giangduy
 */
public class Main {
   static Scanner input = new Scanner(System.in);
    static List<DanhMuc> DMList = new ArrayList<>();
    static List<SanPham> SPList = new ArrayList<>();
    static Date date;
    static Date today = new Date(System.currentTimeMillis());

    public static void main(String[] args) {
        int choose;

        do {
            showMenu();
            choose = Integer.parseInt(input.nextLine());

            switch (choose) {
                case 1:
                    inputDanhMuc();
                    break;
                case 2:
                    inputSanPham();
                    break;
                case 3:
                    for (SanPham SPL : SPList) {
                        if (SPL.ngayBan != null) {
                            SPL.display();
                        }
                    }
                    break;
                case 4:
                    for (SanPham SPL : SPList) {
                        if (SPL.ngayBan == null) {
                            SPL.display();
                        }
                    }
                    break;
                case 5:
                    listQuaHanSD();
                    break;
                case 6:
                    listSapHetHSD();
                    break;
                case 7:
                    timKiemSP();
                    break;
                case 8:
                    luuFile();
                    break;
                case 9:
                    docFile();
                    break;
                case 10:
                    System.out.println("Goodbye!");
                    break;
                default:
                    System.err.println("Nhap sai!");
                    break;
            }
        } while (choose != 10);
    }

    static void inputDanhMuc() {
        System.out.println("Nhap so danh muc muon nhap: ");
        int n = Integer.parseInt(input.nextLine());

        for (int i = 0; i < n; i++) {
            DanhMuc danhMuc = new DanhMuc();
            danhMuc.input();

            DMList.add(danhMuc);
        }
    }

    static void inputSanPham() {
        System.out.println("Nhap ma danh muc muon them: ");
        for (int i = 0; i < DMList.size(); i++) {
            System.out.println(DMList.get(i).getMaDM());
        }
        String chonDM = input.nextLine();

        System.out.println("Nhap so san pham muon them: ");
        int n = Integer.parseInt(input.nextLine());

        DanhMuc danhMuc = new DanhMuc(chonDM);
        if (danhMuc != null) {
            for (int i = 0; i < n; i++) {
                SanPham sanPham = new SanPham();
                sanPham.input();

                SPList.add(sanPham);
            }
        }
    }

    static void listQuaHanSD() {
        System.out.println("Danh sach san pham qua han su dung: ");
        for (SanPham SPL : SPList) {
            try {
                date = new SimpleDateFormat("dd/MM/yyyy").parse(SPL.getHanSD());
                if (date.compareTo(today) < 0) {
                    SPL.display();
                }
            } catch (ParseException ex) {
                Logger.getLogger(Main.class.getName()).log(Level.SEVERE, null, ex);
            }
        }
    }

    static void listSapHetHSD() {
        System.out.println("Danh sach san pham sap het han su dung: ");
        for (SanPham SPL : SPList) {
            Date date;
            try {
                date = new SimpleDateFormat("dd/MM/yyyy").parse(SPL.getHanSD());
                if (date.compareTo(today) >= 0 && date.compareTo(today) <= 7) {
                    SPL.display();
                }
            } catch (ParseException ex) {
                Logger.getLogger(Main.class.getName()).log(Level.SEVERE, null, ex);
            }
        }
    }

    static void timKiemSP() {
        System.out.println("Nhap ten san pham can tim: ");
        String find = input.nextLine();
        int count = 0;

        for (int i = 0; i < SPList.size(); i++) {
            if (SPList.get(i).getTenSP().equalsIgnoreCase(find)) {
                SPList.get(i).display();
                count++;
            }
        }
        System.out.println("So luong: " + count);
    }

    static void luuFile() {
        FileOutputStream fos = null;
        ObjectOutputStream oos = null;

        try {
            fos = new FileOutputStream("category.dat");
            oos = new ObjectOutputStream(fos);

            oos.writeObject(DMList);
        } catch (Exception e) {
        } finally {
            if (fos != null) {
                try {
                    fos.close();
                } catch (IOException ex) {
                    Logger.getLogger(Main.class.getName()).log(Level.SEVERE, null, ex);
                }
            }
            if (oos != null) {
                try {
                    oos.close();
                } catch (IOException ex) {
                    Logger.getLogger(Main.class.getName()).log(Level.SEVERE, null, ex);
                }
            }
        }

        try {
            fos = new FileOutputStream("sell.dat");
            oos = new ObjectOutputStream(fos);

            for (SanPham SPL : SPList) {
                if (SPL.ngayBan != null) {
                    oos.writeObject(SPL);
                }
            }
        } catch (IOException ex) {
            Logger.getLogger(Main.class.getName()).log(Level.SEVERE, null, ex);
        } finally {
            if (fos != null) {
                try {
                    fos.close();
                } catch (IOException ex) {
                    Logger.getLogger(Main.class.getName()).log(Level.SEVERE, null, ex);
                }
            }
            if (oos != null) {
                try {
                    oos.close();
                } catch (IOException ex) {
                    Logger.getLogger(Main.class.getName()).log(Level.SEVERE, null, ex);
                }
            }
        }

        try {
            fos = new FileOutputStream("expire.dat");
            oos = new ObjectOutputStream(fos);

            for (SanPham SPL : SPList) {
                try {
                    date = new SimpleDateFormat("dd/MM/yyyy").parse(SPL.getHanSD());
                    if (date.compareTo(today) < 0) {
                        oos.writeObject(SPL);
                    }
                } catch (ParseException ex) {
                    Logger.getLogger(Main.class.getName()).log(Level.SEVERE, null, ex);
                }
            }
        } catch (IOException ex) {
            Logger.getLogger(Main.class.getName()).log(Level.SEVERE, null, ex);
        } finally {
            if (fos != null) {
                try {
                    fos.close();
                } catch (IOException ex) {
                    Logger.getLogger(Main.class.getName()).log(Level.SEVERE, null, ex);
                }
            }
            if (oos != null) {
                try {
                    oos.close();
                } catch (IOException ex) {
                    Logger.getLogger(Main.class.getName()).log(Level.SEVERE, null, ex);
                }
            }
        }
    }

    static void docFile() {
        FileReader fr = null;

        try {
            System.out.println("Danh muc san pham: ");
            fr = new FileReader("category.dat");
            System.out.println(fr);

            System.out.println("San pham da ban: ");
            fr = new FileReader("Sell.dat");
            System.out.println(fr);

            System.out.println("San pham da het han: ");
            fr = new FileReader("expire.dat");
            System.out.println(fr);
        } catch (FileNotFoundException ex) {
            Logger.getLogger(Main.class.getName()).log(Level.SEVERE, null, ex);
        } finally {
            if (fr != null) {
                try {
                    fr.close();
                } catch (IOException ex) {
                    Logger.getLogger(Main.class.getName()).log(Level.SEVERE, null, ex);
                }
            }
        }
    }

    static void showMenu() {
        System.out.println("1. Nhap danh muc.");
        System.out.println("2. Nhap san pham.");
        System.out.println("3. In san pham da ban.");
        System.out.println("4. In san pham ton kho.");
        System.out.println("5. In san pham qua han su dung.");
        System.out.println("6. In san pham sap het han su dung.");
        System.out.println("7. Tim kiem san pham.");
        System.out.println("8. Luu vao file.");
        System.out.println("9. Doc tu file.");
        System.out.println("10. Thoat.");
        System.out.println("Choose: ");
    } 
}
