using UnityEngine;
using UnityEngine.UI;

namespace Polytoria.Datamodel.Services
{
	public class CoreUIService : MonoBehaviour
	{
		[SerializeField]
		private GameObject userCard;

		[SerializeField]
		private GameObject chat;

		[SerializeField]
		private GameObject healthBar;

		[SerializeField]
		private GameObject leaderboard;

		[SerializeField]
		private GameObject hotbar;

		[SerializeField]
		private GameObject menuButton;

		[SerializeField]
		private GameObject chatButton;

		[SerializeField]
		private Button resetButton;

		public static CoreUIService Instance { get; private set; }

		public bool UserCardEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ChatEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool HealthBarEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool LeaderboardEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool HotbarEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool MenuButtonEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool CanRespawn
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}
	}
}
