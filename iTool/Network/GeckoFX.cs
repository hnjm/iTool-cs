namespace iTool.Network
{
    public class GeckoFX
    {
        /* Uncomment if you have Gecko referenced in your winform project.
        /// <summary>
        /// Run JavaScript code on browser - can use codes from files such as Jquery lib too.
        /// </summary>
        /// <param name="browser"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public static string JSval(ref Gecko.GeckoWebBrowser browser, string code)
        {
            string result = string.Empty;
            using (Gecko.AutoJSContext context = new Gecko.AutoJSContext(browser.Window))
            {
                try
                {
                    context.EvaluateScript(code, out result);
                }
                catch (Gecko.GeckoException e)
                {
                    System.Windows.Forms.MessageBox.Show(e.Message, "Error",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Error);
                }
            }
            return result;
            //browser.Navigate($"javascript:void({code})");
            //Application.DoEvents();
        }
        */
    }
}
