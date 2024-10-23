namespace mod_1_assignment.animals 
{
    // https://www.geeksforgeeks.org/how-to-read-and-write-a-text-file-in-c-sharp/
    public class FileOutput
    {
        private string _filePath;
        private StreamWriter _writer;

        // public FileOutput
        // initiate file
        public FileOutput(String filePath){
            this._filePath = filePath;

            // using StreamWriter writer = new(_filePath);
            _writer = new(_filePath);
            _writer.Write("");
        }

        // public void fileWrite(String line)
        // write to file
        public void FileWrite(string line)
        {
            try{
                // _writer.WriteLine(line);
                // using StreamWriter writer = new(_filePath, true);
                _writer.WriteLine(line);
            }
            catch (Exception e)
            {
                Console.WriteLine("File Write Error: " + _filePath + " " + e);
            }
        }

        // public void fileClose() 
        // close file
        public void FileClose()
        {
            // File.ReadAllText(_filePath);
            _writer.Close();
        }
    }

}