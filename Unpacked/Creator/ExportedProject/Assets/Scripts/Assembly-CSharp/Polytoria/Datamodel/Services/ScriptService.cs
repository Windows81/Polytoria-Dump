using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Mirror;
using MoonSharp.Interpreter;

namespace Polytoria.Datamodel.Services
{
	public class ScriptService : Instance
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass13_0
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
		private sealed class _003CInvokeEvent_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
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
			public _003CInvokeEvent_003Ed__21(int _003C_003E1__state)
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
		private sealed class _003CRunScriptInstance_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ScriptService _003C_003E4__this;

			public BaseScript scriptInstance;

			private _003C_003Ec__DisplayClass13_0 _003C_003E8__1;

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
			public _003CRunScriptInstance_003Ed__13(int _003C_003E1__state)
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

		[IteratorStateMachine(typeof(_003CRunScriptInstance_003Ed__13))]
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

		[IteratorStateMachine(typeof(_003CInvokeEvent_003Ed__21))]
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
