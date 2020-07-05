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
    public class BonusController : ControllerBase
    {
        private readonly BonusRepository _bonusRepository;
        private readonly BonusBLL _bonusBLL;

        public BonusController(BonusRepository bonusRepository, BonusBLL bonusBLL)
        {
            _bonusRepository = bonusRepository;
            _bonusBLL = bonusBLL;
        }

        [HttpGet]
        public IActionResult GetBonus(string tokenCompany)
        {
            var result = _bonusBLL.GetClientBonus(tokenCompany);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult AddBonus(AddBonusViewModel addBonusViewmodel)
        {
            try
            {
                _bonusRepository.CreateBonus(addBonusViewmodel);
                return Ok("Deu Certo !");
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        //update p
    }
}