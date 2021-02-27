using Microsoft.EntityFrameworkCore;
using SovaProject.Data.Entities;
using SovaProject.Data.interfeces;
using SovaProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SovaProject.Data.Repository
{
    public class TarufRepository : IAllTarufs
    {
        private readonly AppDBContent appDBContent;
        public TarufRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Taruf> Tarufs => appDBContent.Taruf.Include(c => c.Category);


        public IEnumerable<Taruf> getFavTarufs => appDBContent.Taruf.Where(p => p.isFavorite).Include(c => c.Category);

        public Taruf getObjectTaruf(int tarufId) => appDBContent.Taruf.FirstOrDefault(p => p.id == tarufId);
    }
}
