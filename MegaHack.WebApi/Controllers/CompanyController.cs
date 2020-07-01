using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MegaHack.Business.BusinessModels;
using MegaHack.Business.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MegaHack.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly CompanyRepository _companyRepository;
        private readonly CompanyBLL _companyBLL;

        public CompanyController(CompanyRepository companyRepository, CompanyBLL companyBLL)
        {
            _companyRepository = companyRepository;
            _companyBLL = companyBLL;
        }

        [HttpGet]
        public IActionResult GetCompanyName(string fiscalId)
        {
            var companyName = _companyBLL.GetCompanyName(fiscalId);
            return Ok(companyName);
        }

        [HttpGet]
        public IActionResult teste()
        {
            return Ok("TESte");
        }
    }
}