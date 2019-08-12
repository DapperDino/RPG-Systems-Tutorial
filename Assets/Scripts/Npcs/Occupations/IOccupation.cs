﻿using UnityEngine;

namespace DapperDino.Npcs.Occupations
{
    public interface IOccupation
    {
        string Name { get; }
        void Trigger(GameObject other);
    }
}
