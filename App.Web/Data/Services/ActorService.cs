using App.Web.Data.Base;
using App.Web.Models;
using Microsoft.EntityFrameworkCore;
using System.Xml;

namespace App.Web.Data.Services
{
    public class ActorService : EntityBaseRepository<Actor>, IActorService
    {

        private readonly AppDbContext _context;

        public ActorService(AppDbContext context) : base(context) { }
        {
         
        }

       
    }
}
