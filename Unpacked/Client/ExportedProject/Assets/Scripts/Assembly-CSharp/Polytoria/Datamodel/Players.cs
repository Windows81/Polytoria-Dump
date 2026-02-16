using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Mirror;
using MoonSharp.Interpreter;
using Polytoria.Lua;

namespace Polytoria.Datamodel
{
	public class Players : Instance
	{
		[CompilerGenerated]
		private sealed class _003CDelayedPlayerAddEvent_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Players _003C_003E4__this;

			public Player player;

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
			public _003CDelayedPlayerAddEvent_003Ed__15(int _003C_003E1__state)
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

		public LuaEvent PlayerAdded;

		public LuaEvent PlayerRemoved;

		private Player _localPlayer;

		[SyncVar]
		private bool playerCollisions;

		public Player LocalPlayer => null;

		[Archivable]
		[CreatorProperty]
		public bool PlayerCollisionEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool NetworkplayerCollisions
		{
			get
			{
				return false;
			}
			[param: In]
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		public Player[] GetPlayers()
		{
			return null;
		}

		public Player GetPlayer(string username)
		{
			return null;
		}

		public Player GetPlayerByID(int id)
		{
			return null;
		}

		[MoonSharpHidden]
		public void AddPlayer(Player player)
		{
		}

		[IteratorStateMachine(typeof(_003CDelayedPlayerAddEvent_003Ed__15))]
		private IEnumerator DelayedPlayerAddEvent(Player player)
		{
			return null;
		}

		[MoonSharpHidden]
		public void NotifyPlayerDestroyed(Player player)
		{
		}

		[ClientRpc]
		private void PlayerAddedClientRpc(Player p)
		{
		}

		[ClientRpc]
		private void PlayerRemovedClientRpc(string name)
		{
		}

		[ClientRpc]
		private void RpcSetPlayerCollisions(bool enabled)
		{
		}

		[MoonSharpHidden]
		public void SetLocalPlayer(Player player)
		{
		}

		public override bool Weaved()
		{
			return false;
		}

		protected void UserCode_PlayerAddedClientRpc__Player(Player p)
		{
		}

		protected static void InvokeUserCode_PlayerAddedClientRpc__Player(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_PlayerRemovedClientRpc__String(string name)
		{
		}

		protected static void InvokeUserCode_PlayerRemovedClientRpc__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetPlayerCollisions__Boolean(bool enabled)
		{
		}

		protected static void InvokeUserCode_RpcSetPlayerCollisions__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		static Players()
		{
		}

		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}
	}
}
