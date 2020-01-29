using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProj.Classes.Entity;

namespace FinalProj.Classes
{
    public interface IState
    {
        bool Eatable(AbstractEntity predator, AbstractEntity prey);
        bool PassThrough(AbstractEntity entity);
    }
}
