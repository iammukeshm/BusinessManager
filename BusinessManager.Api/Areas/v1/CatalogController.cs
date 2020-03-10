using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessManager.Api.Controllers;
using BusinessManager.Application.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusinessManager.Api.Areas.v1
{
    [ApiController]
    [ApiVersion("1.0")]
    public class CatalogController : ApiController
    {
        [HttpGet("products")]
        public async Task<IActionResult> GetAllProductsAsync()
        {
            //var products = await Mediator.Send(new GetAllProductsQuery());
            string data = "a";
            var result = Result<string>.Success("",data);
            return Ok(result);
        }
    }
}