using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MoonSharp.Interpreter;
using UnityEngine;
using UnityEngine.Networking;

namespace Polytoria.Datamodel.Services
{
	public class HttpService : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDoRequest_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string url;

			public string method;

			public string body;

			public Table headers;

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
			public _003CDoRequest_003Ed__11(int _003C_003E1__state)
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

		public static HttpService instance;

		private static int maxRequestsPerMinute;

		private static int requestsThisMinute;

		private static int currentMinute;

		private void Awake()
		{
		}

		private static bool RateLimit(DynValue callback = null)
		{
			return false;
		}

		public static void Get(string url, DynValue callback = null, Table headers = null)
		{
		}

		public static void Post(string url, string body, DynValue callback = null, Table headers = null)
		{
		}

		public static void Put(string url, string body, DynValue callback = null, Table headers = null)
		{
		}

		public static void Delete(string url, DynValue callback = null, Table headers = null)
		{
		}

		public static void Patch(string url, string body, DynValue callback = null, Table headers = null)
		{
		}

		[IteratorStateMachine(typeof(_003CDoRequest_003Ed__11))]
		private static IEnumerator DoRequest(string method, string url, string body = null, DynValue callback = null, Table headers = null)
		{
			return null;
		}
	}
}
