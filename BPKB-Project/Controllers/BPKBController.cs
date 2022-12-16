using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BPKB_Project.Models;
using BPKB_Project.Services.BPKBService;
using Microsoft.AspNetCore.Mvc;

namespace BPKB_Project.Controllers
{
    [ApiController]
    [Route("api/bpkb")]
    public class BPKBController : Controller
    {
        private readonly IBPKBService bpkbService;

        public BPKBController(IBPKBService bpkbService)
        {
            this.bpkbService = bpkbService;
        }

        [HttpGet("")]
        public async Task<ActionResult<List<BPKB>>> GetAllBPKB()
        {
            return await bpkbService.GetAllBPKB();
        }

        [HttpPost]
        public async Task<ActionResult<BPKB>> CreateBPKB([FromBody] BPKB request)
        {
            return await bpkbService.CreateBPKB(request);
        }

        [HttpGet("location")]
        public async Task<ActionResult<List<Location>>> GetAllLocation()
        {
            return await bpkbService.GetAllLocation();
        }
    }
}