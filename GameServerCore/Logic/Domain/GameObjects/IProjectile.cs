﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServerCore.Logic.Domain.GameObjects
{
    public interface IProjectile : IObjMissile
    {
        List<IGameObject> ObjectsHit { get; }
        IAttackableUnit Owner { get; }
        int ProjectileId { get; }
    }
}
