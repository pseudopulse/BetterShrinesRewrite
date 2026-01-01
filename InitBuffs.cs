global using R2API;
using Mono.Cecil.Cil;
using MonoMod.Cil;
using RoR2;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using RoR2.UI;

namespace Evaisa.MoreShrines
{
    internal class InitBuffs
    {
        public static BuffDef maxHPDown;
        public static BuffDef maxHPDownStage;
        public static List<CharacterBody> players = new List<CharacterBody>();

        public static void Add()
        {
            maxHPDown = ScriptableObject.CreateInstance<BuffDef>();

            maxHPDown.name = "Max HP Down";
            maxHPDown.isDebuff = true;
            maxHPDown.canStack = true;
            maxHPDown.iconSprite = EvaResources.HPDebuffIcon;

            maxHPDown.buffColor = Color.red;

            ContentAddition.AddBuffDef(maxHPDown);

            maxHPDownStage = ScriptableObject.CreateInstance<BuffDef>();

            maxHPDownStage.name = "Stage Max HP Down";
            maxHPDownStage.isDebuff = true;
            maxHPDownStage.canStack = true;
            maxHPDownStage.iconSprite = EvaResources.HPDebuffIcon;

            maxHPDownStage.buffColor = Color.red;

            ContentAddition.AddBuffDef(maxHPDownStage);

            RecalculateStatsAPI.GetStatCoefficients += RecalculateHP;
            On.RoR2.Stage.BeginAdvanceStage += Stage_BeginAdvanceStage;

            On.RoR2.UI.BuffIcon.UpdateIcon += BuffIcon_UpdateIcon;
        }

        private static void RecalculateHP(CharacterBody sender, RecalculateStatsAPI.StatHookEventArgs args)
        {
            if (sender) {
                int count = sender.GetBuffCount(maxHPDownStage);
                int count2 = sender.GetBuffCount(maxHPDown);

                args.healthTotalMult *= 1f - (count / 100f);
                args.healthTotalMult *= 1f - (count2 / 100f);
            }
        }

        private static void BuffIcon_UpdateIcon(On.RoR2.UI.BuffIcon.orig_UpdateIcon orig, RoR2.UI.BuffIcon self)
        {
            if (!self.buffDef)
            {
                self.iconImage.sprite = null;
                return;
            }
            if (self.buffDef == maxHPDown || self.buffDef == maxHPDownStage)
            {
                self.iconImage.sprite = self.buffDef.iconSprite;
                self.iconImage.color = self.buffDef.buffColor;
                if (self.buffDef.canStack)
                {
                    BuffIcon.sharedStringBuilder.Clear();
                    BuffIcon.sharedStringBuilder.AppendInt(self.buffCount, 1U, uint.MaxValue);
                    BuffIcon.sharedStringBuilder.Append("%");
                    self.stackCount.enabled = true;
                    self.stackCount.SetText(BuffIcon.sharedStringBuilder);
                    return;
                }
                self.stackCount.enabled = false;
            }
            else
            {
                orig(self);
            }
        }


        private static void Stage_BeginAdvanceStage(On.RoR2.Stage.orig_BeginAdvanceStage orig, Stage self, SceneDef destinationStage)
        {
            foreach(var player in players)
            {
                for(var i = 0; i < player.GetBuffCount(maxHPDownStage); i++)
                {
                    player.RemoveBuff(maxHPDownStage);
                }
            }
            orig(self, destinationStage);
        }

    }
}
