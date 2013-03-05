using System.IO;
using Recaptcha;
using System.Web.UI;
using System.Web.Mvc;
using System.Configuration;
using System.Web;

namespace MvcReCaptcha.Helpers
{
    /// <summary>
    /// 
    /// </summary>
    public static class ReCaptchaHelper
    {
        /// <summary>
        /// Html Helper to build and render the Captcha control
        /// </summary>
        /// <param name="helper">HtmlHelper class provides a set of helper methods whose purpose is to help you create HTML controls programmatically</param>
        /// <returns></returns>
        public static IHtmlString GenerateCaptcha(this HtmlHelper helper, string theme = "clean")
        {
            var captchaControl = new RecaptchaControl
                                     {
                                         ID = "recaptcha",
                                         Theme = theme,
                                         PublicKey = ConfigurationManager.AppSettings["ReCaptchaPublicKey"],
                                         PrivateKey = ConfigurationManager.AppSettings["ReCaptchaPrivateKey"]
                                     };
            var htmlWriter = new HtmlTextWriter(new StringWriter());
            captchaControl.RenderControl(htmlWriter);

            return new HtmlString(htmlWriter.InnerWriter.ToString());
        }
    }
}