using System;
using System.Collections.Generic;
using System.Text;

namespace WebappCore.BaseEnity
{
    public interface IEntityBase<TId>
    {
        TId Id { get; }
    }
}
