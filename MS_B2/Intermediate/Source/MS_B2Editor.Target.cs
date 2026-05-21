using UnrealBuildTool;

public class MS_B2EditorTarget : TargetRules
{
	public MS_B2EditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("MS_B2");
	}
}
