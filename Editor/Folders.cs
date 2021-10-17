// ----------------------------------------
// 
// Folders.cs by Frédéric Cornélis
// 
// ©2021 - TeCum Studio. All rights reserved.
// 
// Created:  17/10/2021 - 14:57
// Modified: 17/10/2021 - 14:57
// 
// ----------------------------------------

using System.IO;
using UnityEngine;

namespace TeCumStudio.Tools
{
	public static class Folders
	{
		public static void CreateDirectories (string root, params string[] directories)
		{
			string fullPath = Path.Combine(Application.dataPath, root);

			foreach (string directory in directories)
			{
				if (!Directory.Exists(Path.Combine(fullPath, directory)))
				{
					Directory.CreateDirectory(Path.Combine(fullPath, directory));
				}
			}
		}
	}
}
