namespace Leson10;

public class Program
{
    
    public static void Main(string[] args )
    {
         // / Users / rostislavnosovskij / Projects / Leson10

        SearchFile(args[0], args[1]);
        foreach (var filePath in list)
        {
            Console.WriteLine("Строка " + args[1]+ " найдена в файле: \n" + filePath +"\n В следующих строках: ");
            using (StreamReader sr = new StreamReader(filePath))
            {
                int counter = 1;
                while (!sr.EndOfStream)
                {
                    var str = sr.ReadLine();
                    if (str.Contains(args[2]))
                    {
                        Console.WriteLine($"{counter} строка: {str}");
                    }
                }
            }
        }
            
        }
    

    static List<string> list = new List<string>();

    public static void SearchFile(string path, string fileName )
    {
        
        var files = Directory.GetFiles(path);
        foreach(var file in files)
        {
            if(Path.GetFileName(file).Contains("."+fileName))
            {
                list.Add(file);
            }
        }
        foreach(var dir in Directory.GetDirectories(path))
        {
            SearchFile(dir, fileName);
        }
    }
    
}

















