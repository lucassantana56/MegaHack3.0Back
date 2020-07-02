using MegaHack.Business.Context;
using MegaHack.Business.ViewModel;
using MegaHack.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MegaHack.Business.Repository
{

    private readonly MegaHackContext _context;

    public ClientRepository(MegaHackContext context)
    {
        _context = context;
    }

    public class ClientRepository
    {
    }
}