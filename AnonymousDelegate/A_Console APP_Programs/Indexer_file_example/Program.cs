﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Indexer_file_example
{
    class Program
    {
        class FileByteArray
        {
            Stream stream;      // Holds the underlying stream
            // used to access the file.
            // Create a new FileByteArray encapsulating a particular file.
            public FileByteArray(string fileName)
            {
                stream = new FileStream(fileName, FileMode.Open);
            }

            // Close the stream. This should be the last thing done
            // when you are finished.
            public void Close()
            {
                stream.Close();
                stream = null;
            }

            // Indexer to provide read/write access to the file.
            public byte this[long index]   // long is a 64-bit integer
            {
                // Read one byte at offset index and return it.
                get
                {
                    byte[] buffer = new byte[1];
                    stream.Seek(index, SeekOrigin.Begin);
                    stream.Read(buffer, 0, 1);
                    return buffer[0];
                }
                // Write one byte at offset index and return it.
                set
                {
                    byte[] buffer = new byte[1] { value };
                    stream.Seek(index, SeekOrigin.Begin);
                    stream.Write(buffer, 0, 1);
                }
            }

            // Get the total length of the file.
            public long Length
            {
                get
                {
                    return stream.Seek(0, SeekOrigin.End);
                }
            }
        }
        static void Main(string[] args)
        {// Check for arguments.
            if (args.Length == 0)
            {
                Console.WriteLine("indexer <Quick heal new>");
                return;
            }

            FileByteArray file = new FileByteArray(args[0]);
            long len = file.Length;

            // Swap bytes in the file to reverse it.
            for (long i = 0; i < len / 2; ++i)
            {
                byte t;

                // Note that indexing the "file" variable invokes the
                // indexer on the FileByteStream class, which reads
                // and writes the bytes in the file.
                t = file[i];
                file[i] = file[len - i - 1];
                file[len - i - 1] = t;
            }

            file.Close();
        }
    }
}
