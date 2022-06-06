using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36.MIInterfaceHierarchy
{
    internal interface IShape:IDrawable,IPrintable
    {
        int GetNumberOfSides();
    }
}
