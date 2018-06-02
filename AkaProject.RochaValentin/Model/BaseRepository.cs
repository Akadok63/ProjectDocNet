using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BaseRepository
    {
            protected Context Context { get; set; }

            public BaseRepository()
            {
                this.Context = new Context();
            }
        }
    }
}
