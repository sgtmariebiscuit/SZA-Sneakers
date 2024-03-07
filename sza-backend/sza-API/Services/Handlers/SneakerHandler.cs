using Repository.EntityFramework.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sza_API.Models;

namespace Services.Handlers
{
    public class SneakerHandler : IHandler<Sneaker, Sneaker>
    {
        private IEntityRepository<Sneaker> _repo;
        public SneakerHandler(IEntityRepository<Sneaker> repo) {
            _repo = repo;
        }

        public async Task<Sneaker> Handle(Sneaker model)
        {
            var response = new Sneaker();
            if (model == null)
            {
                response = null;
                throw new ArgumentNullException("model");
            }

            await _repo.Add(model);
            response = model;
            return response;
        }
    }
}
