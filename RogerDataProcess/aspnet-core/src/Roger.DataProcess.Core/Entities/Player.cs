using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace Roger.DataProcess.Entities
{
    public class Player : Entity<long>, IHasCreationTime
    {
        public const string DefaultPlayerName = "DefaultPlayer";

        public virtual string PlayerName { get; set; }

        public virtual long MapID { get; set; }

        public virtual DateTime CreationTime { get; set; }

        public virtual Map Map { get; set; }
        public Player()
        {
            CreationTime = DateTime.Now;
            MapID = 1;
        }
    }
}
