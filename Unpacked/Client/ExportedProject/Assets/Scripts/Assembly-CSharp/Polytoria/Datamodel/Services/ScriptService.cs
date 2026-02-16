using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Mirror;
using MoonSharp.Interpreter;

namespace Polytoria.Datamodel.Services
{
	public class ScriptService : Instance
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass25_0
		{
			public ScriptService _003C_003E4__this;

			public Script script;

			internal void _003CRunScriptInstance_003Eb__0(string s)
			{
			}

			internal DynValue _003CRunScriptInstance_003Eb__1(ModuleScript ms)
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CInvokeEvent_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DynValue func;

			public ScriptService _003C_003E4__this;

			public object[] par;

			private DynValue _003Ccoroutine_003E5__2;

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
			public _003CInvokeEvent_003Ed__33(int _003C_003E1__state)
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
		private sealed class _003CRunScriptInstance_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ScriptService _003C_003E4__this;

			public BaseScript scriptInstance;

			private _003C_003Ec__DisplayClass25_0 _003C_003E8__1;

			private DynValue _003Ccoroutine_003E5__2;

			private float _003Ctimeout_003E5__3;

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
			public _003CRunScriptInstance_003Ed__25(int _003C_003E1__state)
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

		public const string payload = "function wait(N)\ncoroutine.yield(N);\nreturn os.time();\nend";

		private List<BaseScript> scripts;

		private List<BaseScript> scriptsLocal;

		private HashSet<string> allowList;

		private RSACryptoServiceProvider rsa;

		private bool receivedAllowlist;

		private string[] _hashes;

		private byte[] _signature;

		private string _pubKey;

		public static ScriptService Instance { get; private set; }

		protected override void Awake()
		{
		}

		[MoonSharpHidden]
		public void RunScripts()
		{
		}

		[MoonSharpHidden]
		public void RunLocalScripts()
		{
		}

		private void GenerateAllowList()
		{
		}

		public void SendAllowList(Player player)
		{
		}

		[TargetRpc]
		public void TargetReceiveAllowList(NetworkConnection target, string[] hashes, byte[] sig, string pubKey)
		{
		}

		private void GetLocalScripts(Instance parent, List<LocalScript> results)
		{
		}

		[ClientRpc]
		public void RpcReceiveAllowlist(string[] hashes, byte[] sig, string pubKey)
		{
		}

		private void ReceivedAllowList(string[] hashes, byte[] sig, string pubKey)
		{
		}

		private void CheckForLocalScripts(Instance parent)
		{
		}

		private void CheckForScripts(Instance parent)
		{
		}

		[MoonSharpHidden]
		public void RunScript(BaseScript s)
		{
		}

		[IteratorStateMachine(typeof(_003CRunScriptInstance_003Ed__25))]
		private IEnumerator RunScriptInstance(BaseScript scriptInstance)
		{
			return null;
		}

		public void LuaSpawn(DynValue func)
		{
		}

		public DynValue LuaRequire(ModuleScript moduleScript, Script script)
		{
			return null;
		}

		public void LuaPrint(string message, bool error = false)
		{
		}

		[ClientRpc]
		private void RpcOnLuaPrintReceive(string message, bool error)
		{
		}

		private DynValue ResumeScriptCoroutine(DynValue coroutine, string identifier, params object[] par)
		{
			return null;
		}

		private DynValue ExecuteScriptInstance(Script script, BaseScript s)
		{
			return null;
		}

		[MoonSharpHidden]
		public void CallFunc(DynValue func, params object[] par)
		{
		}

		[IteratorStateMachine(typeof(_003CInvokeEvent_003Ed__33))]
		[MoonSharpHidden]
		public IEnumerator InvokeEvent(DynValue func, params object[] par)
		{
			return null;
		}

		private float Tick()
		{
			return 0f;
		}

		private float GameTime()
		{
			return 0f;
		}

		public override bool Weaved()
		{
			return false;
		}

		protected void UserCode_TargetReceiveAllowList__NetworkConnection__String_005B_005D__Byte_005B_005D__String(NetworkConnection target, string[] hashes, byte[] sig, string pubKey)
		{
		}

		protected static void InvokeUserCode_TargetReceiveAllowList__NetworkConnection__String_005B_005D__Byte_005B_005D__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcReceiveAllowlist__String_005B_005D__Byte_005B_005D__String(string[] hashes, byte[] sig, string pubKey)
		{
		}

		protected static void InvokeUserCode_RpcReceiveAllowlist__String_005B_005D__Byte_005B_005D__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcOnLuaPrintReceive__String__Boolean(string message, bool error)
		{
		}

		protected static void InvokeUserCode_RpcOnLuaPrintReceive__String__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		static ScriptService()
		{
		}
	}
}
