﻿using System.Collections.Generic;
using Verse;

namespace DMS
{
    public class MechWeaponExtension : DefModExtension
    {

        public bool EnableWeaponFilter = true;  //根據WeaponTag
        public List<string> UsableWeaponTags = new List<string>();

        public bool EnableTechLevelFilter = false; //根據科技等級
        public List<string> UsableTechLevels = new List<string>();

        public bool EnableClassFilter = false; //根據文化分類
        public List<string> UsableWeaponClasses = new List<string>();

        public List<string> BypassUsableWeapons = new List<string>();//特例可以直接用的
    }
}
