using System;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace iTool.Network
{
    public class iHttp
    {
        private Uri uri;
        private string url;
        private string html;
        private string _FileName;
        private static HttpClient Client;
        private static HttpClientHandler ClientHandler;
        private static HttpResponseMessage msg;

        /// <summary>
        /// get html of a url as string.
        /// </summary>
        /// <returns></returns>
        public string GetHtml()
        {
            string html = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream;
                if (String.IsNullOrWhiteSpace(response.CharacterSet))
                    readStream = new StreamReader(receiveStream);
                else
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));

                html = readStream.ReadToEnd();
                response.Close();
                readStream.Close();

                return html;
            }
            else
                return null;
        }
        public static string GetHtml(string url)
        {
            string html = string.Empty;
            HttpWebRequest request;
            HttpWebResponse response;
            try
            {
                request = (HttpWebRequest)WebRequest.Create(url);
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (Exception)
            {
                return null;
            }

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream;
                if (String.IsNullOrWhiteSpace(response.CharacterSet))
                    readStream = new StreamReader(receiveStream);
                else
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));

                html = readStream.ReadToEnd();
                response.Close();
                readStream.Close();

                return html;
            }
            else
                return null;
        }
        //public static string GetHtml(string url)
        //{
        //    string html = string.Empty;

        //    HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
        //    request.AutomaticDecompression = DecompressionMethods.GZip;

        //    try
        //    {
        //        using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
        //        using (Stream stream = response.GetResponseStream())
        //        using (StreamReader reader = new StreamReader(stream))
        //        {
        //            html = reader.ReadToEnd();
        //        }
        //        return html;
        //    }
        //    catch { return null; }
        //}
        /// <summary>
        /// Download file from given url and save it with the given file name.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="fileName"></param>
        /// <summary>
        /// object required - save with given file name.
        /// </summary>
        /// <param name="fileName"></param> 
        public void Download(string fileName)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile(this.url, fileName);
            }
        }
        /// <summary>
        /// object required - save with default file name (fetched from url).
        /// </summary>
        public void Download()
        {
            using (var client = new WebClient())
            {
                client.DownloadFile(this.url, this._FileName);
            }
        }
        public static void Download(string url, string fileName)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile(url, fileName);
            }
        }
        public static string GetHtmlByCookies(string url, CookieContainer cookies)
        {
            string html = string.Empty;
            ClientHandler = new HttpClientHandler();
            if (cookies != null)
            {
                ClientHandler.CookieContainer = cookies;
                ClientHandler.UseCookies = true;
                using (Client = new HttpClient(ClientHandler))
                {
                    Task.Run(async () =>
                    {
                        try { msg = await Client.GetAsync(url); }
                        catch (HttpRequestException e)
                        {
                            msg.StatusCode = HttpStatusCode.BadRequest;
                        }
                    }).Wait();
                }
                if (msg.IsSuccessStatusCode)
                    Task.Run(async () => html = await msg.Content.ReadAsStringAsync()).Wait();
            }
            return html;
        }
        public static string GetHtmlByCookies(Uri url, CookieContainer cookies)
        {
            string html = string.Empty;
            ClientHandler.CookieContainer = cookies;
            ClientHandler.UseCookies = true;
            using (Client = new HttpClient(ClientHandler))
            {
                Task.Run(async () =>
                {
                    try { msg = await Client.GetAsync(url); }
                    catch (HttpRequestException e)
                    {
                        msg.StatusCode = HttpStatusCode.BadRequest;
                    }
                }).Wait();
            }
            if (msg.IsSuccessStatusCode)
                Task.Run(async () => html = await msg.Content.ReadAsStringAsync()).Wait();
            return html;
        }
    }
}
