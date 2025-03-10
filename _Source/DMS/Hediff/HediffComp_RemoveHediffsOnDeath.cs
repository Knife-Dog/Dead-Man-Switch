﻿using Verse;

namespace DMS
{
    //在死亡後添加或移除Hediff
    public class HediffComp_RemoveHediffsOnDeath : HediffComp
    {
        public override void Notify_PawnDied()
        {
            base.Notify_PawnDied();
            OnDeathHediffOperation();
        }
        private void OnDeathHediffOperation()
        {
            HediffsExtension extension = Def.GetModExtension<HediffsExtension>() ?? null;
            if (extension == null) return;
            for (int i = 0; i < this.Def.GetModExtension<HediffsExtension>().hediffs.Count; i++)
            {
                if (Pawn.health.hediffSet.HasHediff(extension.hediffs[i].hediffDef))
                {
                    Pawn.health.RemoveHediff(Pawn.health.hediffSet.GetFirstHediffOfDef(extension.hediffs[i].hediffDef));
                }
            }
        }
    }
}
