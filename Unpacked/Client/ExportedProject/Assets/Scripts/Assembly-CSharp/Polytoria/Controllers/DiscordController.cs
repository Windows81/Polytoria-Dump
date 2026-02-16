using Discord;
using UnityEngine;

namespace Polytoria.Controllers
{
	public class DiscordController : MonoBehaviour
	{
		private global::Discord.Discord discord;

		private ActivityManager activityManager;

		private Activity currentActivity;

		public static DiscordController Instance { get; private set; }

		public Activity Activity => default(Activity);

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void UpdateActivity(Activity activity)
		{
		}

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
