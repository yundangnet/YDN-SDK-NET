using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YDN
{
    public interface IQueryable
    {
        void Result();

        void Subscribe();

        void Unsubscribe();
    }
}
