using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.validators
{
    public interface IValidator<T>
    {
        void validate(T t);
    }
}
