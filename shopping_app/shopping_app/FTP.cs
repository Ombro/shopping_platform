using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Globalization;
using System.Windows.Forms;

namespace shopping_app
{
    public class FTP
    {
        public string ftpServerIP;
        public string ftpRemotePath;
        public string ftpUserID;
        public string ftpPassword;
        public string ftpURI;

        public FTP()
        {
            ftpServerIP = "139.199.210.74";
            ftpRemotePath = "imgs/";
            ftpUserID = "hhb";
            ftpPassword = "hhb345792307";
            ftpURI = "ftp://" + ftpServerIP + "/" + ftpRemotePath;
        }

        private string Upload(string filename)
        {
            FileInfo fileInf = new FileInfo(filename);
            if (!fileInf.Exists)
            {
                return filename + " 不存在!\n";
            }
            string uri = ftpURI + fileInf.Name;
            FtpWebRequest reqFTP;
            reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(uri));
            reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
            reqFTP.KeepAlive = false;
            reqFTP.Method = WebRequestMethods.Ftp.UploadFile;
            reqFTP.UseBinary = true;
            reqFTP.UsePassive = false; //选择主动还是被动模式
                                       //Entering Passive Mode
            reqFTP.ContentLength = fileInf.Length;
            int buffLength = 2048;
            byte[] buff = new byte[buffLength];
            int contentLen;
            FileStream fs = fileInf.OpenRead();
            try
            {
                Stream strm = reqFTP.GetRequestStream();
                contentLen = fs.Read(buff, 0, buffLength);
                while (contentLen != 0)
                {
                    strm.Write(buff, 0, contentLen);
                    contentLen = fs.Read(buff, 0, buffLength);
                }
                strm.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Upload Error:" + ex.Message);
                return "同步 " + filename + "时连接不上服务器!\n";
            }
            return "";
        }

        //上传文件
        public string UploadFile(string filePaths)
        {
            StringBuilder sb = new StringBuilder();
            if (filePaths != null && filePaths.Length > 0)
            {
                sb.Append(Upload(filePaths));
            }
            return sb.ToString();
        }



        //下载
        public void Download(string filePath, string fileName)
        {
            FtpWebRequest reqFTP;
            try
            {
                FileStream outputStream = new FileStream(filePath + "/" + fileName, FileMode.Create);
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpURI + fileName));
                reqFTP.Method = WebRequestMethods.Ftp.DownloadFile;
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                Stream ftpStream = response.GetResponseStream();
                long cl = response.ContentLength;
                int bufferSize = 2048;
                int readCount;
                byte[] buffer = new byte[bufferSize];
                readCount = ftpStream.Read(buffer, 0, bufferSize);
                while (readCount > 0)
                {
                    outputStream.Write(buffer, 0, readCount);
                    readCount = ftpStream.Read(buffer, 0, bufferSize);
                }
                ftpStream.Close();
                outputStream.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Download Error:" + ex.Message);
            }
        }

        //删除
        public void Delete(string fileName)
        {
            try
            {
                string uri = ftpURI + fileName;
                FtpWebRequest reqFTP;
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(uri));
                reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                reqFTP.KeepAlive = false;
                reqFTP.Method = WebRequestMethods.Ftp.DeleteFile;
                string result = String.Empty;
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                long size = response.ContentLength;
                Stream datastream = response.GetResponseStream();
                StreamReader sr = new StreamReader(datastream);
                result = sr.ReadToEnd();
                sr.Close();
                datastream.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete Error:" + ex.Message);
            }
        }


        //重命名
        public void Rename(String currentFilename, String newFilename)
        {
            FtpWebRequest reqFTP;
            try
            {
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpURI + currentFilename));
                reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                reqFTP.Method = WebRequestMethods.Ftp.Rename;
                reqFTP.RenameTo = newFilename;
                reqFTP.UseBinary = true;
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                Stream ftpStream = response.GetResponseStream();

                ftpStream.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rename Error:" + ex.Message);
            }
        }

        //static void Main()
        //{
        //string file = "c:\\aq3.gifa";
        //FileInfo fileInf = new FileInfo(file);
        //if (!fileInf.Exists)
        //{
        // Console.WriteLine(file + " no exists");
        //}
        //else {
        // Console.WriteLine("yes");
        //}
        //Console.ReadLine();
        //    FTP fw = new FTP();
        //    string[] filePaths = { "c:\\aq3.gif1", "c:\\aq2.gif1", "c:\\bsmain_runtime.log" };
        //    Console.WriteLine(fw.UploadFile(filePaths));
        //    Console.ReadLine();
        //}
    }
}
