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
	public class Game : Instance
	{
		[CompilerGenerated]
		private sealed class _003CWaitForGameLoad_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Game _003C_003E4__this;

			private float _003CstartTime_003E5__2;

			private float _003Ctimeout_003E5__3;

			private int _003ClastInstances_003E5__4;

			private float _003CtimeSinceChange_003E5__5;

			private float _003CminimumTime_003E5__6;

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
			public _003CWaitForGameLoad_003Ed__29(int _003C_003E1__state)
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

		public static Game singleton;

		public LuaEvent Rendered;

		[SyncVar]
		private int gameID;

		[SyncVar]
		private int playersConnected;

		public static string GameName;

		[SyncVar]
		public int instanceCount;

		private int localInstanceCount;

		public bool isGameLoaded;

		public int GameID => 0;

		public int PlayersConnected => 0;

		public int InstanceCount => 0;

		public int LocalInstanceCount => 0;

		public int NetworkgameID
		{
			get
			{
				return 0;
			}
			[param: In]
			set
			{
			}
		}

		public int NetworkplayersConnected
		{
			get
			{
				return 0;
			}
			[param: In]
			set
			{
			}
		}

		public int NetworkinstanceCount
		{
			get
			{
				return 0;
			}
			[param: In]
			set
			{
			}
		}

		public event Action Loaded
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

		public static event Action GameLoadedLocally
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

		protected override void Awake()
		{
		}

		public override void OnStartServer()
		{
		}

		public void InvokeLoaded()
		{
		}

		public void InvokeLoadedLocal()
		{
		}

		public void SetGameID(int id)
		{
		}

		public void BuildNavMesh()
		{
		}

		protected override void Start()
		{
		}

		[IteratorStateMachine(typeof(_003CWaitForGameLoad_003Ed__29))]
		[MoonSharpHidden]
		public IEnumerator WaitForGameLoad()
		{
			return null;
		}

		private void Update()
		{
		}

		[MoonSharpHidden]
		public void InstanceAdded()
		{
		}

		[MoonSharpHidden]
		public void InstanceRemoved()
		{
		}

		public override bool Weaved()
		{
			return false;
		}

		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}
	}
}
