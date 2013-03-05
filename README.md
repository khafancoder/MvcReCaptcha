MvcReCaptcha
============

Updated version of MvcReCaptcha, now usable with MVC3 and .Net 4.0

More Info:
http://mvcrecaptcha.codeplex.com/



Usage
============
View:

      @Html.GenerateCaptcha("white")
 

 
 
Controller:

    [HttpPost, MvcReCaptcha.CaptchaValidator]
    public ActionResult SampleAction(SampleModel model)
    {
            if (ModelState.IsValid)
            {
                //captcha entered correctly
                
            }
            else
            {
                //there are some errors
                
                //show related error message if entered captcha was incorrect
                if (ModelState["recaptcha"] != null)
                    ModelState.AddModelError("", "Incorrect Captcha! Try Again");
            }
  

            return View(model);  
    }
