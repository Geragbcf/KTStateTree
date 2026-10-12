// Copyright Epic Games, Inc. All Rights Reserved.
using UnrealBuildTool;

public class KTStateTree : ModuleRules
{
	public KTStateTree(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate",
			"PropertyBindingUtils"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"KTStateTree",
			"KTStateTree/Code",
			"KTStateTree/Variant_Horror",
			"KTStateTree/Variant_Horror/UI",
			"KTStateTree/Variant_Shooter",
			"KTStateTree/Variant_Shooter/AI",
			"KTStateTree/Variant_Shooter/UI",
			"KTStateTree/Variant_Shooter/Weapons"
		});
	}
}