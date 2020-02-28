using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Comm
{
    public class FileOperate
    {

        public string FilePath
        {
            set;
            get;
        }

        public FileOperate(string filename)
        {
            if(string.IsNullOrEmpty(filename))
                FilePath = System.AppDomain.CurrentDomain.BaseDirectory + "power.txt";
            else
                FilePath = System.AppDomain.CurrentDomain.BaseDirectory +  filename;
        }


        public bool isExists()
        {

            return File.Exists(FilePath);

        }

        public void writeToFile(string strcontent)
        {
           
                FileStream myfs = new FileStream(FilePath, FileMode.Create);
                //打开方式  
                //1:Create  用指定的名称创建一个新文件,如果文件已经存在则改写旧文件  
                //2:CreateNew 创建一个文件,如果文件存在会发生异常,提示文件已经存在  
                //3:Open 打开一个文件 指定的文件必须存在,否则会发生异常  
                //4:OpenOrCreate 打开一个文件,如果文件不存在则用指定的名称新建一个文件并打开它.  
                //5:Append 打开现有文件,并在文件尾部追加内容.  

                //创建写入器  
                
                StreamWriter mySw = new StreamWriter(myfs);//将文件流给写入器  
                //将录入的内容写入文件  
                mySw.Write(strcontent);
                //关闭写入器  
                mySw.Close();
                //关闭文件流  
                myfs.Close();
            
        }


        public string readFromFile()
        {
            string result="";
             if(File.Exists(FilePath))
             {

                 FileStream myfs = new FileStream(FilePath, FileMode.Open);
                 StreamReader mySr = new StreamReader(myfs, Encoding.UTF8);

                 result = mySr.ReadToEnd();

                 mySr.Close();
                 //关闭文件流  
                 myfs.Close();

             }
             return result;

        }
    }
}
