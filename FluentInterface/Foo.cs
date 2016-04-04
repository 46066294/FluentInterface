using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentInterface
{
    public class Foo
    {
        private string _field;
        private string _where;

        public Foo Select(string fields)
        {
            _field = fields;
            return this;
        }

        public Foo Where(string where)
        {
            _where = where;
            return this;
        }

        public string Execute()
        {
            return "Select " + _field + " Where " + _where;
        }

    }

    
}
