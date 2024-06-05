// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class RustExampleEditorTarget : TargetRules
{
	public RustExampleEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange(new[] { "RustExample" });
	}
}