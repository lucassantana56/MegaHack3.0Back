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
    public class BonusController : ControllerBase
    {
        private readonly BonusRepository _bonusRepository;
        private readonly BonusBLL _bonusBLL;

        public BonusController(BonusRepository bonusRepository, BonusBLL bonusBLL)
        {
            _bonusRepository = bonusRepository;
            _bonusBLL = bonusBLL;
        }
    }
}