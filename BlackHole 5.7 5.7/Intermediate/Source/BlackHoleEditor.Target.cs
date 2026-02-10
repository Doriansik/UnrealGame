using UnrealBuildTool;

public class BlackHoleEditorTarget : TargetRules
{
	public BlackHoleEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("BlackHole");
	}
}
