using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Handlers
{
    public interface IHandler<TIn, TOut>
    where TIn : class
    where TOut : class
    {
        public Task<TOut?> Handle(TIn model);
    }
}
