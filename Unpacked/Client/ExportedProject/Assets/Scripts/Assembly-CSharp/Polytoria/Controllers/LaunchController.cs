using System.Collections.Generic;
using UnityEngine;

namespace Polytoria.Controllers
{
	public class LaunchController : MonoBehaviour
	{
		public static LaunchController singleton;

		public static NetworkType launchType;

		public static string clientToken;

		public static string serverToken;

		public static bool isSolo;

		public static string soloMapPath;

		public static string soloUserName;

		public static int soloUserID;

		public static int soloID;

		public static bool isLocal;

		public static int localGameId;

		public static int localUserId;

		public static string localMapPath;

		[SerializeField]
		private NetworkType editorLaunchType;

		[SerializeField]
		private string testToken;

		[SerializeField]
		private bool doPlaySolo;

		[SerializeField]
		private string playSoloTestMap;

		[SerializeField]
		private string playSoloTestUserName;

		[SerializeField]
		private int playSoloTestUserID;

		[SerializeField]
		private bool doLocal;

		[SerializeField]
		private int testLocalUserId;

		[SerializeField]
		private int testLocalGameId;

		[SerializeField]
		private string testLocalMapPath;

		[SerializeField]
		private string testMobileLaunchURI;

		private void Start()
		{
		}

		public void LaunchAs(NetworkType netType, string token)
		{
		}

		private Dictionary<string, string> GetCommandLineArgs()
		{
			return null;
		}

		private void OnDeepLinkActivated(string uri)
		{
		}

		public static string GetActiveToken()
		{
			return null;
		}
	}
}
