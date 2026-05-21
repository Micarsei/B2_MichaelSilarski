using UnrealBuildTool;

public class MS_B2Target : TargetRules
{
	public MS_B2Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("MS_B2");
	}
}
