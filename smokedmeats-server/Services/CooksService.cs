using System;
using System.Linq;
using System.Collections.Generic;
using smokedmeats_server.Models;
using smokedmeats_server.Repositories;
using smokedmeats_server.Exceptions;

namespace smokedmeats_server.Services
{
    public class CooksService
    {
        private readonly CooksRepository _crepo;
        private readonly VaultCooksRepository _vrepo;

        public CooksService(CooksRepository crepo, VaultCooksRepository vrepo)
        {
            _crepo = crepo;
            _vrepo = vrepo;
        }

        internal IEnumerable<Cook> getCooks()
        {
            return _crepo.GetCooks();
        }

        internal Cook GetById(int id, string userId)
        {
            return _crepo.GetByID(id);
        }



    }
}