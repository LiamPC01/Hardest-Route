using UnrealBuildTool;

public class HardestRouteTarget : TargetRules
{
	public HardestRouteTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("HardestRoute");
	}
}
