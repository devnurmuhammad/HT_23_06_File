namespace HT_23_06_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "text";
            //CreateFileMethod(path);   //Firstly, we have to create files!
            WriteToFile(path, "Nurmuhammad a'lochi bola!");

            void CreateFileMethod(string path)
            {
                for (int i = 0; i < 10; i++)
                {
                    File.Open(path + $"{i}.txt", FileMode.CreateNew);
                }

                Console.WriteLine("Files created!");
            }

            void WriteToFile(string path, string text)
            {
                for (int i = 0; i < 10; i++)
                {
                    File.WriteAllText(path + $"{i}.txt", text);
                }
                Console.WriteLine("Writed to all files!");
            }
        }
    }
}