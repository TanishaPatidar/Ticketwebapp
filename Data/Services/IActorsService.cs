using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ticketwebapp.Models;

namespace Ticketwebapp.Data.Services
{
   public  interface IActorsService
    {
        //get data from database
      Task<  IEnumerable<Actor> >GetAllAsync();

      Task<  Actor> GetByIdAsync(int id);

        //add data in database
        Task  AddAsync(Actor actor);
        Actor Update(int id,Actor newActor);

        //Delete method

        void Delete(int id);
        void Add(Actor actor);
    }
}
