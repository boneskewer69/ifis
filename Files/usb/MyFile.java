package usb;

public class MyFile {
    private String fileName;
    private double fileSize;

    MyFile(String p_fileName, double p_fileSize) {
        this.fileName = p_fileName;
        this.fileSize = p_fileSize;
    }

    public String getFileName() {
        return this.fileName;
    }

    public double getFileSize() {
        return this.fileSize;
    }
}
