namespace RegistrationTest.Controllers;

using Microsoft.AspNetCore.Mvc;
using RegistrationTest.Models;
using RegistrationTest.Services.Abstraction;

[ApiController]
[Route("api/[controller]")]
public class ModelController : ControllerBase
{
    [HttpGet("car")]
    public ActionResult<string> GetCarModel(IModelProvider<CarModel> modelProvider)
    {
        return Ok(modelProvider.GetModel());
    }

    [HttpGet("user")]
    public ActionResult<string> GetUserModel(IModelProvider<UserModel> modelProvider)
    {
        return Ok(modelProvider.GetModel());
    }

    [HttpGet("project")]
    public ActionResult<string> GetProjectModel(IModelProvider<ProjectModel> modelProvider)
    {
        return Ok(modelProvider.GetModel());
    }
}
