// ----------------------------------------
// 
// Packages.cs by Frédéric Cornélis
// 
// ©2021 - TeCum Studio. All rights reserved.
// 
// Created:  17/10/2021 - 14:57
// Modified: 17/10/2021 - 15:06
// 
// ----------------------------------------

using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using UnityEditor.PackageManager;
using UnityEngine;

namespace TeCumStudio.Tools
{
	public static class Packages
	{
		public static async Task ReplacePackagesFromGist (string id, string user = "TeCumStudio")
		{
			string url = GetGistUrl(id, user);
			string content = await GetContents(url);

			ReplacePackageFile(content);
		}


		public static void InstallUnityPackage (string packageName)
		{
			Client.Add($"com.unity.{packageName}");
		}


		private static string GetGistUrl (string id, string user = "TeCumStudio")
		{
			return $"https://gist.githubusercontent.com/{user}/{id}/raw";
		}


		private static async Task<string> GetContents (string url)
		{
			using HttpClient client = new HttpClient();

			HttpResponseMessage response = await client.GetAsync(url);
			string content = await response.Content.ReadAsStringAsync();

			return content;
		}


		private static void ReplacePackageFile (string content)
		{
			string existing = Path.Combine(Application.dataPath, "../Packages/manifest.json");

			File.WriteAllText(existing, content);
			Client.Resolve();
		}
	}
}
