import usb.*;

public class Main {
    public static void main(String[] args) {
        UsbStick usb1 = new UsbStick("flitsmeista", 64.0, FileSystems.NTFS);

        usb1.storeFile("MyDocument.txt", 0.2);
        usb1.storeFile("Avatar_BluRay_RIP.iso", 50.0);
        usb1.storeFile("Avatar_HD_Compressed.mp4", 2.5);
        usb1.printSpecs();
        usb1.deleteFile("Avatar_BluRay_RIP.iso");
        usb1.printSpecs();
        usb1.format("roadstar", FileSystems.exFAT);
        usb1.printSpecs();
    }
}
