using Microsoft.AspNetCore.Mvc;
namespace Demo_Session_31.Controlers


{
    public class MoviesController : Controller
    {
        //Actions: public non-static function
        //Actions has spacial DataTypes [Action Result]
        //public string Test()
        //{
        //    return "Hii test";
        //}



        //public string GetMovie(int id)
        //{
        //    return $"Id : {id}";
        //}
        //[HttpGet]
        //[ActionName("hamada")]
        //public IActionResult GetMovie(int? id)
        //{
        //    //ContentResult result = new ContentResult();

        //    //result.Content = $"id : {id}";
        //    //result.ContentType="text/html";


        //    //return result;
        //    return Content($"id:{id}", "text/html");
        //}
        //Action Parameter Binding
        //1-form
        //2-Segment
        //3-Query string/Query Params
        //4-File









        //public RedirectToActionResult Test(string Id)
        //{
        //    RedirectToActionResult  result= new RedirectToActionResult("GetMovie", "Movies", new {id =Id});    
        //    return result;

        //public RedirectResult Test01() {



        //    RedirectResult result = new RedirectResult("http://www.facebook.com/");
        //    return result;
        
        
        //}









    }
}
