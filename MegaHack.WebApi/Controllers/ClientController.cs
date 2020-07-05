using System;
using MegaHack.Business.BusinessModels;
using MegaHack.Business.Repository;
using MegaHack.Business.ViewModel;
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

        [HttpPost]
        public IActionResult AddClient(AddClientViewModel addClientViewModel)
        {
            var result = _clientRepository.AddClient(addClientViewModel);
            if (result == Guid.Empty)
                return BadRequest("Email invalid");

            return Ok(result);

        }
    }
}