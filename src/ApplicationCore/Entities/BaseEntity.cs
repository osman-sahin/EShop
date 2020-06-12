using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public abstract class BaseEntity   // abstract new'lenemez. Db'de oluşturulmaz
    {
        public virtual int Id { get; set; }
    }
}
