using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Model;
using MagicVilla_VillaAPI.Model.dto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Linq.Expressions;
using System.Text.Json;

namespace MagicVilla_VillaAPI.Controllers
{
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPIController: ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDto> GetVillas()
        {
            return VillaStore.list;

        }
        [HttpGet("id")]
        public IActionResult GetVilla(int id)
        {

            VillaDto data=VillaStore.list.Where(x => x.Id == id).FirstOrDefault();
            if (data != null)
            {
              
                return Content(JsonConvert.SerializeObject(data));
            }
            else
            {
                return NotFound("Resource Not Found");
            }

        }
    }
}
