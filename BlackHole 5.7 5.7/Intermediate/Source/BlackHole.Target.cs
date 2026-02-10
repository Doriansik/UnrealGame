using UnrealBuildTool;

public class BlackHoleTarget : TargetRules
{
	public BlackHoleTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("BlackHole");
	}
}
