using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanityArchiver
{
    class CompressingFile
    {

        public void Compress(FileInfo fileToCompress)
        {

            using (FileStream originalFileStrem = fileToCompress.OpenRead())
            {
                if ((File.GetAttributes(fileToCompress.FullName) &
                  FileAttributes.Hidden) != FileAttributes.Hidden & fileToCompress.Extension != ".gz")
                {
                    using (FileStream compressedFileStream = File.Create(fileToCompress.FullName + ".gz"))
                    {
                        using (GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                        {
                            originalFileStrem.CopyTo(compressionStream);
                        }
                    }
                }
            }
        }

        public void Decompress(FileInfo fileDecompress)
        {
            string directoryPath = @"d:\teszt\e";
            DirectoryInfo directorySelected = new DirectoryInfo(directoryPath);
            using (FileStream originalFileStrem = fileDecompress.OpenRead())
            {
                string currentFileName =  fileDecompress.FullName;
                string newFileName = currentFileName.Remove(currentFileName.Length - fileDecompress.Extension.Length);

                
                using (FileStream decompressedFileStream = File.Create(newFileName))
                {

                    using (GZipStream decompressionStream = new GZipStream(originalFileStrem, CompressionMode.Decompress))
                    {
                        decompressionStream.CopyTo(decompressedFileStream);
                    
                    }
                }
            }
        }
    }
}
