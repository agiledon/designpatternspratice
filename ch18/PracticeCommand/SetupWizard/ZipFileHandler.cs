using System;
using System.IO;
using System.Collections.Generic;

using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip.Compression;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace DonOfDesign.PracticePatterns.SetupWizard
{
	/// <summary>
	/// ZipOp 的摘要说明。
	/// </summary>
	public class ZipFileHandler
	{
		public ZipFileHandler()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}

		private ZipOutputStream outputStream = null;
		private ZipInputStream inputStream = null;
		private Crc32 crc = null;

		//压缩多个文件到一个文件中;
		public void CompressFile(string[] fileNames,string targetFile)
		{
			crc = new Crc32();
			outputStream = new ZipOutputStream(File.Create(targetFile));
		
			outputStream.SetLevel(6); // 0 - store only to 9 - means best compression
		
			foreach (string file in fileNames) 
			{
				FileStream fs = File.OpenRead(file);
			
				byte[] buffer = new byte[fs.Length];
				fs.Read(buffer, 0, buffer.Length);
				ZipEntry entry = new ZipEntry(file);				
			
				entry.DateTime = DateTime.Now;
			
				// set Size and the crc, because the information
				// about the size and crc should be stored in the header
				// if it is not set it is automatically written in the footer.
				// (in this case size == crc == -1 in the header)
				// Some ZIP programs have problems with zip files that don't store
				// the size and crc in the header.
				entry.Size = fs.Length;
				fs.Close();
			
				crc.Reset();
				crc.Update(buffer);
			
				entry.Crc  = crc.Value;
			
				outputStream.PutNextEntry(entry);
			
				outputStream.Write(buffer, 0, buffer.Length);
			
			}
		
			outputStream.Finish();
			outputStream.Close();

		}


		public void BeginCompress(string targetFile)
		{
			crc = new Crc32();
			outputStream = new ZipOutputStream(File.Create(targetFile));
		
			outputStream.SetLevel(6); // 0 - store only to 9 - means best compression
		}

		public void EndCompress()
		{
			outputStream.Finish();
			outputStream.Close();
		}

		public void CompressFile(string fileName)
		{
			FileStream fs = File.OpenRead(fileName);
			
			byte[] buffer = new byte[fs.Length];
			fs.Read(buffer, 0, buffer.Length);
			ZipEntry entry = new ZipEntry(fileName);				
			
			entry.DateTime = DateTime.Now;			
			
			entry.Size = fs.Length;
			fs.Close();
			
			crc.Reset();
			crc.Update(buffer);
			
			entry.Crc  = crc.Value;
			
			outputStream.PutNextEntry(entry);
			
			outputStream.Write(buffer, 0, buffer.Length);
		}


		//解压缩文件,按压缩文件原有的目录结构解压;
		public void Decompress(string targetFile)
		{
			inputStream = new ZipInputStream(File.OpenRead(targetFile));
		
			ZipEntry theEntry;
			while ((theEntry = inputStream.GetNextEntry()) != null) 
			{	
				string directoryName = Path.GetDirectoryName(theEntry.Name);
				string fileName      = Path.GetFileName(theEntry.Name);
			
				// create directory
				Directory.CreateDirectory(directoryName);
			
				if (fileName != String.Empty) 
				{					
					FileStream streamWriter = File.Create(theEntry.Name);
				
					int size = 2048;
					byte[] data = new byte[2048];
					while (true) 
					{
						size = inputStream.Read(data, 0, data.Length);
						if (size > 0) 
						{
							streamWriter.Write(data, 0, size);
						} 
						else 
						{
							break;
						}
					}
				
					streamWriter.Close();
				}
			}
			inputStream.Close();
		}


		//解压缩文件,放到指定目录下;
		public void Decompress(string targetFile,string targetDir)
		{
			inputStream = new ZipInputStream(File.OpenRead(targetFile));            
			ZipEntry theEntry;	
		
			// create directory
			Directory.CreateDirectory(targetDir);

			while ((theEntry = inputStream.GetNextEntry()) != null) 
			{				
				string fileName = Path.GetFileName(theEntry.Name);	
				string targetFileName = targetDir + "\\" + fileName;
			
				if (fileName != String.Empty) 
				{						
					FileStream streamWriter = File.Create(targetFileName);
				
					int size = 2048;
					byte[] data = new byte[2048];
					while (true) 
					{
						size = inputStream.Read(data, 0, data.Length);
						if (size > 0) 
						{
							streamWriter.Write(data, 0, size);
						} 
						else 
						{
							break;
						}
					}
				
					streamWriter.Close();
				}
			}
			inputStream.Close();
		}

        public void BeginDecompress(string targetFile, string targetDir,ref List<string> fileNameList)
        {
            fileNameList.Clear();
            inputStream = new ZipInputStream(File.OpenRead(targetFile));

            ZipEntry theEntry;

            // create directory
            Directory.CreateDirectory(targetDir);

            while ((theEntry = inputStream.GetNextEntry()) != null)
            {
                string fileName = Path.GetFileName(theEntry.Name);
                string targetFileName = targetDir + "\\" + fileName;
                if (fileName != string.Empty)
                {
                    fileNameList.Add(targetFileName);
                }
            }
        }	

		public void DecompressSingleFile(string targetFile,string targetDir,string fileName)
		{	
			inputStream = new ZipInputStream(File.OpenRead(targetFile)); 
			ZipEntry theEntry;

			while ((theEntry = inputStream.GetNextEntry()) != null) 
			{
				string tempFileName = Path.GetFileName(theEntry.Name);
				string targetFileName = targetDir + "\\" + tempFileName;

				if (fileName == targetFileName) 
				{						
					FileStream streamWriter = File.Create(fileName);					
				
					int size = 2048;
					byte[] data = new byte[2048];
					while (true) 
					{	
						size = inputStream.Read(data, 0, data.Length);
						if (size > 0) 
						{
							streamWriter.Write(data, 0, size);
						} 
						else 
						{
							break;
						}
					}
				
					streamWriter.Close();
				}	
			}

			inputStream.Close();
					
		}		
	}
}
