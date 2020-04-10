using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
 
namespace iTool.Network
{
    public class iCookie
    {
        public Uri uri;
        public iCookie(string url) => this.uri = new Uri(url);
        public async Task<List<Cookie>> GetCookies()
        {
            var cookieContainer = new CookieContainer();
            using (var httpClientHandler = new HttpClientHandler { CookieContainer = cookieContainer })
            {
                using (var httpClient = new HttpClient(httpClientHandler))
                {
                    await httpClient.GetAsync(this.uri);
                    return cookieContainer.GetCookies(uri).Cast<Cookie>().ToList();
                }
            }
        }
        public List<Cookie> GetCookies(CookieContainer cookieJar)
        {
            try
            {
                return cookieJar.GetCookies(this.uri).Cast<Cookie>().ToList();
            }
            catch (ArgumentException)
            {
                return null;
            }
        }
        // Static methods
        public static async Task<List<Cookie>> GetCookies(string url)
        {
            var cookieContainer = new CookieContainer();
            var uri = new Uri(url);
            using (var httpClientHandler = new HttpClientHandler { CookieContainer = cookieContainer })
            {
                using (var httpClient = new HttpClient(httpClientHandler))
                {
                    await httpClient.GetAsync(uri);
                    return cookieContainer.GetCookies(uri).Cast<Cookie>().ToList();
                }
            }
        }
        public static List<Cookie> GetCookies(CookieContainer cookieJar, string url)
        {
            var uri = new Uri(url);
            try
            {
                return cookieJar.GetCookies(uri).Cast<Cookie>().ToList();
            }
            catch (ArgumentException)
            {
                return null;
            }
        }
        public static List<Cookie> GetCookies(CookieContainer cookieJar, Uri uri)
        {
            try
            {
                return cookieJar.GetCookies(uri).Cast<Cookie>().ToList();
            }
            catch (ArgumentException)
            {
                return null;
            }
        }
    }
}
