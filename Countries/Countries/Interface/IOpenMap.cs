using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countries.Interface
{
    public interface IOpenMap
    {
        void OpenMap(double lat, double lon);
    }
}
