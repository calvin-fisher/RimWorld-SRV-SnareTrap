using RimWorld;
using Verse;

namespace SurvivalistsAdditions {

  public class SrvSettings : ModSettings
  {
		internal static int Snare_FailChance = 10;
		internal static int Snare_BreakChance = 2;
		internal static bool Snare_AllowPositiveNotification = true;
		internal static bool Snare_AllowNegativeNotification = true;
		internal static NotificationType Snare_NotificationType = NotificationType.Letter;

    public override void ExposeData() {
      base.ExposeData();
			Scribe_Values.Look(ref Snare_FailChance, "Snare_FailChance", 10);
			Scribe_Values.Look(ref Snare_BreakChance, "Snare_BreakChance", 2);
			Scribe_Values.Look(ref Snare_AllowPositiveNotification, "Snare_AllowPositiveNotification", true);
			Scribe_Values.Look(ref Snare_AllowNegativeNotification, "Snare_AllowNegativeNotification", true);
			Scribe_Values.Look(ref Snare_NotificationType, "Snare_NotificationType", NotificationType.Letter);
    }
  }
}
