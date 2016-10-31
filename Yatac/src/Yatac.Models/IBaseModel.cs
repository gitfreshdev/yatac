using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yatac.Models
{
    public interface IBaseModel
    {
        Guid Id { get; set; }
    }
}
