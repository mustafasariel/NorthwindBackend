using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        IRegionService _regionService;
        public RegionsController(IRegionService regionService)
        {
            _regionService = regionService;
        }

        [HttpGet(template:"getall")]
        public  IActionResult GetList()
        {
            var result = _regionService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }

        [HttpGet(template:"getbyid")]
        public IActionResult GetById(int regionId)
        {
            var result = _regionService.GetById(regionId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }

        [HttpPost(template:"add")]
        public IActionResult Add(Region region)
        {
            var result = _regionService.Add(region);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }
        [HttpPost(template: "delete")]
        public IActionResult Delete(Region region)
        {
            var result = _regionService.Delete(region);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }
        [HttpPost(template: "update")]
        public IActionResult Update(Region region)
        {
            var result = _regionService.Update(region);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }
    }
}