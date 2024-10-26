// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class UE5VoxelTutorialEditorTarget : TargetRules
{
	public UE5VoxelTutorialEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
        bOverrideBuildEnvironment = true; // 强制允许修改
        DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "UE5VoxelTutorial" } );
	}
}
