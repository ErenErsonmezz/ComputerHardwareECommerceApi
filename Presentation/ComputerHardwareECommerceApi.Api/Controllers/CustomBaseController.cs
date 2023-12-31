using ComputerHardwareECommerceApi.Application.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace ComputerHardwareECommerceApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomBaseController : ControllerBase
    {
        public IActionResult CreateActionResult<T>(CustomResponseDto<T> responseDto)
        {
            if (responseDto.StatusCode==204)
            {
                return new ObjectResult(null) { StatusCode = responseDto.StatusCode};
            }
            return new ObjectResult(responseDto) { StatusCode=responseDto.StatusCode};
        }
    }
}
