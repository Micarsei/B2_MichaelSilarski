using UnrealBuildTool;

public class MS_B2ClientTarget : TargetRules
{
	public MS_B2ClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("MS_B2");
	}
}
