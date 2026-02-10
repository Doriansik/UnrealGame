using UnrealBuildTool;

public class BlackHoleServerTarget : TargetRules
{
	public BlackHoleServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("BlackHole");
	}
}
