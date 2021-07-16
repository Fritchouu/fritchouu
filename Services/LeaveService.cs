using System;
using System.Collections.Generic;
using System.Linq;
using WebApi.Entities;
using WebApi.Helpers;
using WebApi.Models;

namespace WebApi.Services
{
    public interface ILeaveService
    {
        void Add(Leave entity);

        Leave GetById(int id);

        IEnumerable<Leave> GetAll();

        void ChangeStatut(Leave Leave, Leave entity);

        IEnumerable<Leave> GetStatut(string Statut);

    }

}