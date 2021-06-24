package usb;

import java.util.ArrayList;

public class UsbStick {
    private String name;
    private FileSystems fileSystem;
    private double capacity;
    private ArrayList<MyFile> fileArr;
    
    public UsbStick(String p_name, double p_capacity, FileSystems p_fileSystem) {
        this.name = p_name;
        this.capacity = p_capacity;
        this.fileArr = new ArrayList<MyFile>();
        this.fileSystem = p_fileSystem;
    }

    public void storeFile(String fileName, double fileSize) {
        double used = 0.0;     
        
        for (MyFile file : fileArr) {
            used += file.getFileSize();
        }

        if (fileSize + used < this.capacity) {
            this.fileArr.add(new MyFile(fileName, fileSize));
        } else {
            System.out.println("File: '" + fileName + "' is too big and cannot be stored.");
        }
    }

    public void deleteFile(String fileName) {
        for (MyFile file : fileArr) {
            if (file.getFileName() == fileName) {
                System.out.println("File '" + fileName + "' will be removed...");
                this.fileArr.remove(file);
                return;
            }
        }
        System.out.println("File '" + fileName + "' not found.");
    }

    public void format(String p_newName, FileSystems p_fileSystems) {
        this.name = p_newName;
        this.fileSystem = p_fileSystems;
        this.fileArr.clear();
        System.out.println("Drive: " + this.name + " was formatted to " + this.fileSystem + ". Capacity of drive: " + this.capacity + " GB");
    }

    public void printSpecs() {
        double used = 0.0;     
        
        for (MyFile file : fileArr) {
            used += file.getFileSize();
        }
        
        System.out.println("\n---------------------\n---------------------\nDrive: " + this.name + ", " + this.fileSystem + ", " + this.capacity + " GB, " + used + " GB used\n---------------------");
        System.out.println("Filename and Filesize\n---------------------");

        if (fileArr.size() == 0) {
            System.out.println("No files found.");
        } else {
            for (MyFile file : fileArr) {
                System.out.println(file.getFileName() + ", " + file.getFileSize() + " GB");
            }
        }

        System.out.println("---------------------");
    }
}
