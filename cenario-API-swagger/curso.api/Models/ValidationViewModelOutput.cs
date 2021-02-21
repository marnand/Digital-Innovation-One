using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso.api.Models
{
    public class ValidationViewModelOutput
    {
        public IEnumerable<string> Erros { get; private set; }

        public ValidationViewModelOutput(IEnumerable<string> erros)
        {
            Erros = erros;
        }
    }
}
