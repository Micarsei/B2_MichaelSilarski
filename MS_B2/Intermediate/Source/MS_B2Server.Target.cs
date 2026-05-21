using UnrealBuildTool;

public class MS_B2ServerTarget : TargetRules
{
	public MS_B2ServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("MS_B2");
	}
}
