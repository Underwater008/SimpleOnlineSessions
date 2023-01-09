// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class SimpleOnlineSessions : ModuleRules
{
	public SimpleOnlineSessions(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "EnhancedInput" });
	}
}
