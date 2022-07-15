using Microsoft.AspNetCore.Mvc;
using RoverAPI.Interfaces;
using RoverAPI.Models;

namespace RoverAPI.Controllers
{
    [ApiController]
    [Route("/api/rover/pics")]
    public class RoverApiController : ControllerBase
    {

        private IRoverPicService _service = null;

        public RoverApiController(IRoverPicService service) : base()
        {
            _service = service;
        }

        [HttpGet("solDate/{solDate:int}")]
        public ActionResult<ItemResponse<Content>> GetPicsBySolDate(int solDate)
        {
            int iCode = 200;
            BaseResponse? response = null;

            try
            {
                Content pictures = _service.GetPicsBySolDate(solDate);

                if (pictures == null)
                {
                    iCode = 404;
                    response = new ErrorResponse("Resource not found.");
                }
                else
                {
                    response = new ItemResponse<Content> { Item = pictures };

                }
            }
            catch (Exception ex)
            {
                iCode = 500;
                response = new ErrorResponse($"Generic Error: {ex.Message}");
            }

            return StatusCode(iCode, response);

        }
    }
}