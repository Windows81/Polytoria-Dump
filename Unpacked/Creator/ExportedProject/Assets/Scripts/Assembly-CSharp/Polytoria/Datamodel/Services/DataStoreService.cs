using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Mirror;
using UnityEngine.Networking;

namespace Polytoria.Datamodel.Services
{
	public class DataStoreService : NetworkBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDoLoadFromServer_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GetDataStoreQueueEntry entry;

			public DataStoreService _003C_003E4__this;

			private Datastore _003Cds_003E5__2;

			private UnityWebRequest _003Cuwr_003E5__3;

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
			public _003CDoLoadFromServer_003Ed__20(int _003C_003E1__state)
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
		private sealed class _003CDoWriteToServer_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public object value;

			public string key;

			public Datastore ds;

			public Action<bool> callback;

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
			public _003CDoWriteToServer_003Ed__22(int _003C_003E1__state)
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

		public int MaxReadRequestsPerMinute;

		public int ReadRequestsPerPlayerModifier;

		public int MaxWriteRequestsPerMinute;

		public int WriteRequestsPerPlayerModifier;

		private Queue<GetDataStoreQueueEntry> getDataStoreQueue;

		private Dictionary<string, Datastore> datastores;

		private int readRequestsThisMinute;

		private int writeRequestThisMinute;

		private int currentMinute;

		private bool isGettingDatastore;

		public static DataStoreService Instance { get; private set; }

		private void Awake()
		{
		}

		public Datastore GetDatastore(string key)
		{
			return null;
		}

		private void Update()
		{
		}

		public bool UseReadRequest()
		{
			return false;
		}

		public bool UseWriteRequest()
		{
			return false;
		}

		public void LoadFromServer(Datastore ds, Action<bool> callback)
		{
		}

		[IteratorStateMachine(typeof(_003CDoLoadFromServer_003Ed__20))]
		private IEnumerator DoLoadFromServer(GetDataStoreQueueEntry entry)
		{
			return null;
		}

		public void WriteToServer(Datastore ds, string key, object value, Action<bool> callback)
		{
		}

		[IteratorStateMachine(typeof(_003CDoWriteToServer_003Ed__22))]
		private IEnumerator DoWriteToServer(Datastore ds, string key, object value, Action<bool> callback)
		{
			return null;
		}

		public override bool Weaved()
		{
			return false;
		}
	}
}
