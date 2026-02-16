using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Mirror;
using MoonSharp.Interpreter;
using UnityEngine;
using UnityEngine.Networking;

namespace Polytoria.Datamodel.Services
{
	public class ChatService : NetworkBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CLogChatMessage_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ChatService _003C_003E4__this;

			public int userId;

			public string message;

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
			public _003CLogChatMessage_003Ed__9(int _003C_003E1__state)
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

		public const int MaxMessageLength = 128;

		public static ChatService Instance;

		private Players _players;

		private void Awake()
		{
		}

		public void BroadcastMessage(string message)
		{
		}

		public void UnicastMessage(string message, Player player)
		{
		}

		[MoonSharpHidden]
		public void SendChat(string message)
		{
		}

		private string FilterChatExploits(string message)
		{
			return null;
		}

		private void DoSendChat(string message, Color color, Player player)
		{
		}

		[IteratorStateMachine(typeof(_003CLogChatMessage_003Ed__9))]
		private IEnumerator LogChatMessage(int userId, string message)
		{
			return null;
		}

		[Command(requiresAuthority = false)]
		private void CmdSendChat(string message, NetworkConnectionToClient sender = null)
		{
		}

		[ClientRpc]
		private void SendChatClientRpc(string message, string username, Color color, Player player)
		{
		}

		[TargetRpc]
		private void SendChatTargetRpc(NetworkConnection target, string message, string username, Color color)
		{
		}

		[MoonSharpHidden]
		public new void Invoke(string methodName, float time)
		{
		}

		[MoonSharpHidden]
		public new void InvokeRepeating(string methodName, float time, float repeatRate)
		{
		}

		public override bool Weaved()
		{
			return false;
		}

		protected void UserCode_CmdSendChat__String__NetworkConnectionToClient(string message, NetworkConnectionToClient sender)
		{
		}

		protected static void InvokeUserCode_CmdSendChat__String__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_SendChatClientRpc__String__String__Color__Player(string message, string username, Color color, Player player)
		{
		}

		protected static void InvokeUserCode_SendChatClientRpc__String__String__Color__Player(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_SendChatTargetRpc__NetworkConnection__String__String__Color(NetworkConnection target, string message, string username, Color color)
		{
		}

		protected static void InvokeUserCode_SendChatTargetRpc__NetworkConnection__String__String__Color(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		static ChatService()
		{
		}
	}
}
