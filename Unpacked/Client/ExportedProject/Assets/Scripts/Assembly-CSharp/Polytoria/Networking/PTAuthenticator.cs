using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Mirror;
using SimpleJSON;
using UnityEngine.Networking;

namespace Polytoria.Networking
{
	public class PTAuthenticator : NetworkAuthenticator
	{
		public struct AuthRequestMessage : NetworkMessage
		{
			public string clientToken;

			public int localUserId;
		}

		public struct AuthResponseMessage : NetworkMessage
		{
			public byte code;

			public string message;

			public int instanceCount;
		}

		[CompilerGenerated]
		private sealed class _003CDelayedDisconnect_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float waitTime;

			public NetworkConnectionToClient conn;

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
			public _003CDelayedDisconnect_003Ed__6(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CValidateToken_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AuthRequestMessage msg;

			public NetworkConnectionToClient conn;

			public PTAuthenticator _003C_003E4__this;

			private AuthResponseMessage _003CauthResponseMessage_003E5__2;

			private bool _003Capprove_003E5__3;

			private JSONNode _003CtokenData_003E5__4;

			private UnityWebRequest _003Cuwr_003E5__5;

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
			public _003CValidateToken_003Ed__5(int _003C_003E1__state)
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

		public override void OnStartServer()
		{
		}

		public override void OnServerAuthenticate(NetworkConnectionToClient conn)
		{
		}

		public void OnAuthRequestMessage(NetworkConnectionToClient conn, AuthRequestMessage msg)
		{
		}

		[IteratorStateMachine(typeof(_003CValidateToken_003Ed__5))]
		public IEnumerator ValidateToken(NetworkConnectionToClient conn, AuthRequestMessage msg)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDelayedDisconnect_003Ed__6))]
		public IEnumerator DelayedDisconnect(NetworkConnectionToClient conn, float waitTime)
		{
			return null;
		}

		public override void OnStartClient()
		{
		}

		public override void OnClientAuthenticate()
		{
		}

		public void OnAuthResponseMessage(AuthResponseMessage msg)
		{
		}
	}
}
