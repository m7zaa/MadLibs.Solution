
using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
    public class HomeController : Controller
    {

        [Route("/")]
        public ActionResult Index() { return View(); }



        [Route("/form")]
        public ActionResult Form() { return View(); }


        [Route("/story-celebs")]
        public ActionResult StorCelebs(string celebrity1, string celebrity2, string celebrity3, string noun1, string noun2, string verb)
        {
            MadLibsVariable myMadLibsVariable = new MadLibsVariable();
            myMadLibsVariable.Celebrity1 = celebrity1;
            myMadLibsVariable.Celebrity2 = celebrity2;
            myMadLibsVariable.Celebrity3 = celebrity3;
            myMadLibsVariable.Verb1 = verb;
            myMadLibsVariable.Noun1 = noun1;
            myMadLibsVariable.Noun2 = noun2;
            return View(myMadLibsVariable);
        }
    }
}
