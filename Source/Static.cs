using UnityEngine;
using Verse;

namespace SurvivalistsAdditions {
  [StaticConstructorOnStartup]
  public static class Static {

    public const int GenericWaitDuration = 200;

    public static string ModName = "SRV_ModName".Translate();

		public static string DisableSnare = "SRV_MenuOption_DisableSnare".Translate();

		public static string ToolTip_Snare_FailChance = "SRV_ToolTip_Snare_FailChance".Translate();
		public static string ToolTip_Snare_BreakChance = "SRV_ToolTip_Snare_BreakChance".Translate();
		public static string ToolTip_Snare_AllowPositiveLetter = "SRV_ToolTip_Snare_AllowPositive".Translate();
		public static string ToolTip_Snare_AllowNegativeLetter = "SRV_ToolTip_Snare_AllowNegative".Translate();
		public static string ToolTip_Snare_NotificationType = "SRV_ToolTip_Snare_NotificationType".Translate();

		public static string ToHumanString(this NotificationType nt) {
			if (nt == NotificationType.None) {
				return "SRV_NotificationType_None".Translate();
			}
			if (nt == NotificationType.SilentText) {
				return "SRV_NotificationType_SilentText".Translate();
			}
			if (nt == NotificationType.TextWithSound) {
				return "SRV_NotificationType_TextWithSound".Translate();
			}
			if (nt == NotificationType.Letter) {
				return "SRV_NotificationType_Letter".Translate();
			}
			return "ERROR";
		}
	}
}
