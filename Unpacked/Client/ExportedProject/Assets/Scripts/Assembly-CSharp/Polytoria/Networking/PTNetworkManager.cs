using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Mirror;
using Polytoria.Datamodel;
using UnityEngine;
using UnityEngine.Networking;

namespace Polytoria.Networking
{
	public class PTNetworkManager : NetworkManager
	{
		private enum ServerEventType
		{
			ServerStarted = 0,
			ServerStopped = 1,
			ClientConnected = 2,
			ClientDisconnected = 3
		}

		[CompilerGenerated]
		private sealed class _003CHeartbeatLoop_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PTNetworkManager _003C_003E4__this;

			private UnityWebRequest _003Cuwr_003E5__2;

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
			public _003CHeartbeatLoop_003Ed__33(int _003C_003E1__state)
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

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CLogEvent_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

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
			public _003CLogEvent_003Ed__32(int _003C_003E1__state)
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

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private Dictionary<int, AuthUserData> playerConnData;

		private Dictionary<int, Player> playerPrefabs;

		public static PTNetworkManager instance;

		[Range(1f, 60f)]
		[SerializeField]
		private float serverHeartbeatRate;

		[Range(1f, 100f)]
		[SerializeField]
		private int maxServerTimeout;

		private int emptyServerPings;

		public override void Awake()
		{
		}

		public override void OnValidate()
		{
		}

		public override void Start()
		{
		}

		public override void LateUpdate()
		{
		}

		public override void OnDestroy()
		{
		}

		public override void ConfigureHeadlessFrameRate()
		{
		}

		public override void OnApplicationQuit()
		{
		}

		public override void ServerChangeScene(string newSceneName)
		{
		}

		public override void OnServerChangeScene(string newSceneName)
		{
		}

		public override void OnServerSceneChanged(string sceneName)
		{
		}

		public override void OnClientChangeScene(string newSceneName, SceneOperation sceneOperation, bool customHandling)
		{
		}

		public override void OnClientSceneChanged()
		{
		}

		public override void OnServerConnect(NetworkConnectionToClient conn)
		{
		}

		public override void OnServerReady(NetworkConnectionToClient conn)
		{
		}

		public override void OnServerAddPlayer(NetworkConnectionToClient conn)
		{
		}

		public override void OnServerDisconnect(NetworkConnectionToClient conn)
		{
		}

		public override void OnServerError(NetworkConnectionToClient conn, TransportError transportError, string message)
		{
		}

		public override void OnClientConnect()
		{
		}

		public override void OnClientDisconnect()
		{
		}

		public override void OnClientNotReady()
		{
		}

		public override void OnClientError(TransportError transportError, string message)
		{
		}

		public override void OnStartHost()
		{
		}

		public override void OnStartServer()
		{
		}

		public void ClientConnected(int userID)
		{
		}

		public void ClientDisconnected(int userID)
		{
		}

		public void ShutdownServer()
		{
		}

		[IteratorStateMachine(typeof(_003CLogEvent_003Ed__32))]
		private IEnumerator LogEvent(ServerEventType eventType, Dictionary<string, string> data = null, bool shutdownOnComplete = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CHeartbeatLoop_003Ed__33))]
		private IEnumerator HeartbeatLoop()
		{
			return null;
		}

		public override void OnStartClient()
		{
		}

		public override void OnStopHost()
		{
		}

		public override void OnStopServer()
		{
		}

		public override void OnStopClient()
		{
		}

		public Player GetPlayerPrefab(int connId)
		{
			return null;
		}

		public void AddUserForConnID(int connId, AuthUserData userData)
		{
		}

		public AuthUserData GetUserDataFromConnID(int connId)
		{
			return default(AuthUserData);
		}

		public List<int> GetConnectedUserIDs()
		{
			return null;
		}
	}
}
