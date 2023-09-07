namespace CompositeParttenDemo;
class Program
{
    static void Main(string[] args)
    {
        var root = new Directory("Root");

        var folder1 = new Directory("Folder1");
        var folder2 = new Directory("Folder2");

        root.Add(folder1);
        root.Add(folder2);

        folder1.Add(new FileItem("MyBook.txt", 12000));
        folder1.Add(new FileItem("MyVideo.mkv", 1000000));

        var subfolder1 = new Directory("Sub folder1");
        subfolder1.Add(new FileItem("MyMusic.mp3", 20000));
        subfolder1.Add(new FileItem("MyResume.pdf", 18000));
        folder1.Add(subfolder1);

        folder2.Add(new FileItem("AndroidApp.apk", 250000));
        folder2.Add(new FileItem("WPFApp.exe", 87000000));

        Console.WriteLine(root.GetSizeinKB() + "KB");
    }
}
