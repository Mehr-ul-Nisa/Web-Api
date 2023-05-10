using Azure.Core.Pipeline;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_Api.Model;

namespace Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SignupController : ControllerBase
    {
        private readonly DataDbContext _dataDbContext;

        public SignupController(DataDbContext dataDbContext)
        {
            _dataDbContext = dataDbContext;
        }

        [HttpPut("SignupData")]

        public IActionResult SaveRegisteration([FromBody] Signup signup) {
        _dataDbContext.Signup.Add(signup);
            _dataDbContext.SaveChanges();

            return Ok();
        }



        [HttpGet("ViewRegisterationData")]
        public IEnumerable<Signup> GetSignups()
        {

            return _dataDbContext.Signup;
        }
    }
}
