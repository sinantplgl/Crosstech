﻿using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Interfaces
{
    public interface IAbilityService
    {
        IEnumerable<Ability> GetAllAbilities();
        Ability GetAbility(Guid id);
        Ability CreateAbility(Ability ability);
        void UpdateAbility(Ability ability);
        void DeleteAbility(Ability ability);
    }
}
