using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Polytoria.Datamodel;
using Polytoria.UI;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace Polytoria.Controllers
{
	public class UIController : MonoBehaviour
	{
		public enum HudButton
		{
			Chat = 0,
			Inventory = 1
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass121_0
		{
			public Player player;

			internal void _003CLoadLeaderboardThumbnail_003Eb__0()
			{
			}

			internal void _003CLoadLeaderboardThumbnail_003Eb__1()
			{
			}

			internal void _003CLoadLeaderboardThumbnail_003Eb__2()
			{
			}

			internal void _003CLoadLeaderboardThumbnail_003Eb__3()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CLoadLeaderboardThumbnail_003Ed__121 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Player player;

			private _003C_003Ec__DisplayClass121_0 _003C_003E8__1;

			public RectTransform _plEntry;

			public RectTransform _lbEntry;

			public UIController _003C_003E4__this;

			private UnityWebRequest _003Cuwr_003E5__2;

			private Button _003CreportBtn_003E5__3;

			private UnityWebRequest _003Ctwr_003E5__4;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CLoadLeaderboardThumbnail_003Ed__121(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			private void _003C_003Em__Finally2()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CLoadThumbnail_003Ed__134 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public int userId;

			public UIController _003C_003E4__this;

			private UnityWebRequest _003Cuwr_003E5__2;

			private JSONNode _003Cuser_003E5__3;

			private UnityWebRequest _003Ctwr_003E5__4;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CLoadThumbnail_003Ed__134(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			private void _003C_003Em__Finally2()
			{
			}

			private void _003C_003Em__Finally3()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		public static int maxDebugLogLength;

		public static UIController singleton;

		public Color selectedBtnColor;

		public Color unselectedBtnColor;

		public Color healthBarGreen;

		public Color healthBarRed;

		public MenuTabPair[] tabs;

		public TMP_Text GameName;

		private readonly DateTime timeWhenStarted;

		private RectTransform leaderboardEntry;

		private RectTransform main;

		private RectTransform alwaysOnTop;

		private RectTransform logsParent;

		private RectTransform playerListMenu;

		private GameObject playerListMenuEntry;

		private GameObject debugLogMessageTemplate;

		private MenuButtonAnimation menuController;

		private TMP_Text overviewUsername;

		private TMP_Text timePlaying;

		private TMP_Text playerCount;

		private TMP_Text instanceCount;

		private TMP_Text debugLogs;

		[SerializeField]
		private TMP_Text localText;

		[SerializeField]
		private RectTransform pauseMenu;

		[SerializeField]
		private RectTransform disconnectScreen;

		private CursorLockMode lockState;

		private string localUsername;

		private bool lbOpen;

		private bool PauseDebounce;

		private readonly Dictionary<string, Sprite> badgeIcons;

		private Dictionary<string, GameObject> LeaderboardUsers;

		private Dictionary<string, GameObject> PlayerListUsers;

		private bool ConsoleDebounce;

		public RectTransform Leaderboard { get; private set; }

		public RectTransform LeaderboardContent { get; private set; }

		public RectTransform UserTag { get; private set; }

		public RectTransform PauseMenu { get; private set; }

		public RectTransform ChatButton { get; private set; }

		public RectTransform InventoryButton { get; private set; }

		public RectTransform DebugConsole { get; private set; }

		public Image PauseMenuImg { get; private set; }

		public RectTransform PauseMenuChild { get; private set; }

		public Canvas Canvas { get; private set; }

		public TMP_InputField ChatBar { get; private set; }

		public static bool Paused { get; private set; }

		public static bool ConsoleOpen { get; private set; }

		public Image HealthbarCont { get; private set; }

		public Image Healthbar { get; private set; }

		public Image HealthbarHeart { get; private set; }

		public TMP_Text HealthbarHeartText { get; private set; }

		public UIStaminaBar StaminaBar { get; private set; }

		public event Action Resetted
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Awake()
		{
		}

		public void SetActiveMenuTab(int index)
		{
		}

		public void SetButtonFocused(HudButton type, bool focused)
		{
		}

		private void ToggleLeaderboard()
		{
		}

		private void Update()
		{
		}

		private void UpdateInstanceCount()
		{
		}

		private void UpdateTimer()
		{
		}

		private void UpdatePlayerCount()
		{
		}

		public void ResetCharacter()
		{
		}

		public void ExitGame()
		{
		}

		public void TogglePaused()
		{
		}

		public void SetPaused(bool paused)
		{
		}

		public void SetGameInfo(string gameName)
		{
		}

		public Sprite GetLeaderboardBadgeIcon(string badgeName)
		{
			return null;
		}

		public void AddLeaderboardUser(Player player)
		{
		}

		[IteratorStateMachine(typeof(_003CLoadLeaderboardThumbnail_003Ed__121))]
		private IEnumerator LoadLeaderboardThumbnail(RectTransform _lbEntry, RectTransform _plEntry, Player player)
		{
			return null;
		}

		public void RemoveLeaderboardUser(string username)
		{
		}

		public void SetUserCard(int userId, string username)
		{
		}

		public void ReceiveChat(string username, string message, Color usernameColor)
		{
		}

		public void DebugLog(string message, bool error)
		{
		}

		public void SetHealthFilled(float fill)
		{
		}

		public void SetStaminaFilled(float fill, bool exhausted)
		{
		}

		public void ToggleConsole()
		{
		}

		public void OpenConsoleFromPauseMenu()
		{
		}

		public void SetConsoleOpen(bool open)
		{
		}

		[IteratorStateMachine(typeof(_003CLoadThumbnail_003Ed__134))]
		private IEnumerator LoadThumbnail(int userId)
		{
			return null;
		}

		private Texture2D FlipTexture(Texture2D original)
		{
			return null;
		}

		public void ShowDisconnectMessage(string reason)
		{
		}
	}
}
