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
    public class ClientController : ControllerBase
    {
        private readonly ClientRepository _clientRepository;
        private readonly ClientBLL _clientBLL;

        public ClientController(ClientRepository clientRepository, ClientBLL clientBLL)
        {
            _clientRepository = clientRepository;
            _clientBLL = clientBLL;
        }
    }
}