// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class RustExampleTarget : TargetRules
{
	public RustExampleTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange(new[] { "RustExample" });
	}
}