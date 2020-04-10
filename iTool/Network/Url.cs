using System;
using System.IO;
using System.Net;

namespace iTool.Network
{
    //  Properties  //
    public partial class iUrl
    {
        public string url { get; set; }
        public string html { get; set; }
        public string _FileName { get; set; }
        public iUrl(string url)
        {
            this.url = url;
        }
    }
    //  Methods  //
    public partial class iUrl
    {
        /// <summary>
        /// File format (by the url).
        /// </summary>
        /// <returns></returns>
        public string FileFormat()
        {
            string s, format;
            string[] sa;

            sa = this.url.Split('/');
            s = sa[sa.Length - 1];
            sa = s.Split('.');

            if (sa.Length < 2) format = null;
            else format = sa[sa.Length - 1];

            return format;
        }
        /// <summary>
        /// File name (by url)
        /// </summary>
        /// <returns></returns>
        public string FileName()
        {
            string s, name;
            string[] sa;

            sa = this.url.Split('/');
            s = sa[sa.Length - 1];
            sa = s.Split('.');
            name = sa[0];

            return name;
        }
        /// <summary>
        /// complete name of the file (reads from url)
        /// </summary>
        /// <returns></returns>
        public string File()
        {
            string name = this.FileName() + "." + this.FileFormat();
            this._FileName = name;
            return name;
        }

    }
    // Static //
    public partial class iUrl
    {     
        public static string File(string url)
        {
            return FileName(url) + "." + FileFormat(url);
        }
        public static string FileName(string url)
        {
            string s, name;
            string[] sa;

            sa = url.Split('/');
            s = sa[sa.Length - 1];
            sa = s.Split('.');
            name = sa[0];

            return name;
        }
        public static string FileFormat(string url)
        {
            string s, format;
            string[] sa;

            sa = url.Split('/');
            s = sa[sa.Length - 1];
            sa = s.Split('.');

            if (sa.Length < 2) format = null;
            else format = sa[sa.Length - 1];

            return format;
        }        
    }
}