using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YDN
{
    public interface Queryable
    {
        void Result();

        void Subscribe();

        void Unsubscribe();
    }
}
