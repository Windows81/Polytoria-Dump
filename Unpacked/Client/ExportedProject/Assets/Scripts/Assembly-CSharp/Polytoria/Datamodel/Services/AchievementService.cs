using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Mirror;
using MoonSharp.Interpreter;
using UnityEngine.Networking;

namespace Polytoria.Datamodel.Services
{
	public class AchievementService : NetworkBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDoAward_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public int achievementID;

			public int userID;

			public DynValue callback;

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
			public _003CDoAward_003Ed__11(int _003C_003E1__state)
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
		private sealed class _003CDoHasAchievement_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public int userID;

			public int achievementID;

			public DynValue callback;

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
			public _003CDoHasAchievement_003Ed__13(int _003C_003E1__state)
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

		public int MaxRequestsPerMinute;

		public int RequestsPerPlayerModifier;

		private int requestsThisMinute;

		private int currentMinute;

		public static AchievementService Instance { get; private set; }

		private void Awake()
		{
		}

		public bool UseRequest()
		{
			return false;
		}

		public void Award(int userID, int achievementID, DynValue callback)
		{
		}

		[IteratorStateMachine(typeof(_003CDoAward_003Ed__11))]
		private IEnumerator DoAward(int userID, int achievementID, DynValue callback)
		{
			return null;
		}

		public void HasAchievement(int userID, int achievementID, DynValue callback)
		{
		}

		[IteratorStateMachine(typeof(_003CDoHasAchievement_003Ed__13))]
		private IEnumerator DoHasAchievement(int userID, int achievementID, DynValue callback)
		{
			return null;
		}

		public override bool Weaved()
		{
			return false;
		}
	}
}
