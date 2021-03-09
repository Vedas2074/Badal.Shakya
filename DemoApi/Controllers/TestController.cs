using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("Test")]


public class TestContoller : ControllerBase
{
    [HttpGet]
    [Route("names")]
    
    public string[] GetNames()
    {
        return new string[] {"Badal Shakya", "Badal Shakya1"};
    }

    [HttpGet]
    [Route("capitalizeNames")]
    
    public IEnumerable<string> CapitalizeNames()
    {
        var names = new string[] {"Badal Shakya", "Badal Shakya1"};
        var cNames = names.Select(x => x.ToUpper());
        return cNames;
    }
}