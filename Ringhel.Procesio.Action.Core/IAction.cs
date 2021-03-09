using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ringhel.Procesio.Action.Core
{
    public interface IAction
    {
        Task Execute();
    }
}
