using Microsoft.AspNetCore.Mvc;

namespace KakonDotNetBasicSolution1.Controllers;
public class Home : Controller
{
    [Route("")]
    [Route("Home")]
    [Route("Home/Index")]
    public string Index()
    {
        return "Hello World From Controller";
    }
    
    // '/About'
    [HttpGet("About")]
    public string About()
    {
        return "About page working";
    }
    
    // '/Home/About2'
    public string About2()
    {
        return "About 2 page working";
    }


    // 'v1/api/Home/GetAge'
    public int GetAge()
    {
        return 30;
    }
    
    // '/Home/Users/20'
    // Remember you are using id in the pattern, that's why your variable name inside the argument must named as id;
    public int Users(int id)
    {
        return id;
    }

    // '/Home/Users/ProUser/Kakon'
    [HttpGet("/{Controller}/Users/ProUser/{name?}")]
    public string ProUserName(string name)
    {
        return name ?? "John Doe";
    }
}