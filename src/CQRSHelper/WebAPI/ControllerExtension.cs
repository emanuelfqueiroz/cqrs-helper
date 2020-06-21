using CQRSHelper._Common;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI
{
    public class ApiController : ControllerBase
    {
        internal IActionResult Response(Response response)
        {
            if (response.Status)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }


    }
}
