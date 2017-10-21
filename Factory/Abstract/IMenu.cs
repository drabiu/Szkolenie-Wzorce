using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedzenie
{
    public interface IMenu
    {
        List<IMenuItem> Items();
        //void Select();
    }
}
