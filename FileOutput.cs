using System;
using System.IO;

namespace Java_to_CSharp_Exercise
{
    class FileOutput
    {
        private string filename;
        private BufferedStream writer;
        public FileOutput(string filename) {
            this.filename = filename;

            try { writer = new BufferedStream(new FileStream(filename, FileMode.Create, FileAccess.Write)); }
            catch (Exception e) { Console.WriteLine($"File Open Error: {filename} {e}"); }
        }

        public void FileWrite(string line) {
            foreach (char c in line) { writer.WriteByte((byte)c); }
            writer.WriteByte((byte)'\n');
        }

        public void FileClose() {
            try {
                writer.Flush();
                writer.Close();
            }
            catch (IOException e) { Console.WriteLine(e.ToString()); }
        }
    }
}
