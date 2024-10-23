using System;
using System.IO;

namespace mod_1_assignment.animals 
{
    // https://www.geeksforgeeks.org/how-to-read-and-write-a-text-file-in-c-sharp/
    public class FileInput 
    {
        private readonly string _filePath;
        private readonly StreamReader? _fileContent;
        
        // public FileInput(fileName)
        // this.fileName = fileName
        // open file using buffered reader
        public FileInput(string filePath)
        {
            this._filePath = filePath;
            
            if (File.Exists(_filePath))
            {
                _fileContent = new StreamReader(_filePath);

            } 
            else 
            {
                Console.WriteLine("Cannot find file in path \"" + _filePath + "\"!");
            }
        }

        // public void fileRead()
        // while { print file by readyLine() }
        public void FileRead() 
        {
            string line;
            try 
            {
                // StreamReader _fileContent = new StreamReader(_filePath); 
                while ((line = _fileContent.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    
                }
                _fileContent.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("File Write Error: " + _filePath + " " + e);
            }
        }

        // public string fileReadLine
        // read line
        public string FileReadLine()
        {
            try 
            {
                // StreamReader _fileContent = new StreamReader(_filePath); 
                string line = _fileContent.ReadLine();
                return line;
            }
            catch (Exception e)
            {
                Console.WriteLine("File Write Error: " + _filePath + " " + e);
                return null;
            }
        }

        // public void fileClose
        // close file
        public void FileClose()
        {
            if (_fileContent != null)
            {            
                try
                {
                    _fileContent.Close();
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.StackTrace);
                }
            }
        }


    }
}