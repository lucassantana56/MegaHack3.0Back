using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MegaHack.Business.BusinessModels;
using MegaHack.Business.Repository;
using MegaHack.Business.ViewModel;
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

        [HttpPost]
        public IActionResult AddCompany(AddComanyViewModel addComanyViewModel)
        {
            try
            {
                var token = _companyRepository.AddNewCompany(addComanyViewModel);
                return Ok(token);
            }
            catch (Exception e)
            {
                return Ok(e);
                throw;
            }
         
        }

        [HttpGet]
        public IActionResult GetCompanyInfoConsolidate()
        {
            var result = _companyBLL.GetCompanyInfoConsolidate();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Login(LoginCompanyViewModel loginCompanyViewModel)
        {
            var result = _companyBLL.VerifyIfCompanyExist(loginCompanyViewModel);

            if (result != Guid.Empty)
                return Ok(result);

            return NotFound("Invalid credencials");
        }

        
        
    }
}