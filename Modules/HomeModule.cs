using Nancy;
using System.Collections;
using LeetSpeak.Objects;

namespace LeetSpeak
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Get["/result"] = _ => {
        string inputString = Request.Query["user-word"];
        LeetTranslator translator = new LeetTranslator();
        string outputString = translator.Translate(inputString);

        return View["index.cshtml", outputString];
      };
    }
  }
}
