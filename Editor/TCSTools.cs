// ----------------------------------------
// 
// TCSTools.cs by Frédéric Cornélis
// 
// ©2021 - TeCum Studio. All rights reserved.
// 
// Created:  17/10/2021 - 12:17
// Modified: 17/10/2021 - 15:19
// 
// ----------------------------------------

using UnityEditor;
using static UnityEditor.AssetDatabase;

namespace TeCumStudio.Tools
{
	public static class TCSTools
	{
		[MenuItem("TeCum Studio/Helpers/Create Default Folders")]
		private static void CreateDefaultFolders ()
		{
			Folders.CreateDirectories("_Project", "Art", "Scripts", "Scenes", "Prefabs");
			Refresh();
		}


		[MenuItem("TeCum Studio/Helpers/Load Custom Packages")]
		private static async void LoadNewManifest ()
		{
			await Packages.ReplacePackagesFromGist("ea0036108f4d0e125e10d8d710376816");
		}


		[MenuItem("TeCum Studio/Helpers/Package/New Input System")]
		private static void AddNewInputSystem ()
		{
			Packages.InstallUnityPackage("inputsystem");
		}


		[MenuItem("TeCum Studio/Helpers/Package/Visual Effect Graph")]
		private static void AddVisualEffectGraph ()
		{
			Packages.InstallUnityPackage("visualeffectgraph");
		}


		[MenuItem("TeCum Studio/Helpers/Package/Animation Rigging")]
		private static void AddAnimationRigging ()
		{
			Packages.InstallUnityPackage("animation.rigging");
		}


		[MenuItem("TeCum Studio/Helpers/Package/Visual Studio")]
		private static void AddVisualStudioEditor ()
		{
			Packages.InstallUnityPackage("ide.visualstudio");
		}


		[MenuItem("TeCum Studio/Helpers/Package/Visual Studio Code")]
		private static void AddVisualStudioCodeEditor ()
		{
			Packages.InstallUnityPackage("ide.vscode");
		}


		[MenuItem("TeCum Studio/Tools/Build Tags, Layers and Scenes Classes")]
		private static void BuildTagLayerSceneClasses ()
		{
			TagsLayersScenesBuilder.RebuildTagsAndLayersClasses();
		}
	}
}
