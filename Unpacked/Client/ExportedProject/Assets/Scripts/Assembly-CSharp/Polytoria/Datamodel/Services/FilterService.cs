using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.Networking;

namespace Polytoria.Datamodel.Services
{
	public class FilterService : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CLoadFilter_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

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
			public _003CLoadFilter_003Ed__9(int _003C_003E1__state)
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

		private static List<ProfanityFilterData> filtersCache;

		private static Dictionary<string, Regex> regexCache;

		private static HashSet<string> literals;

		private static Regex combinedRegex;

		public static bool FailedToLoad { get; private set; }

		private void Start()
		{
		}

		[IteratorStateMachine(typeof(_003CLoadFilter_003Ed__9))]
		private IEnumerator LoadFilter()
		{
			return null;
		}

		private static void ParseFilters(string json)
		{
		}

		private static Regex GetCompiledRegex(ProfanityFilterData filter)
		{
			return null;
		}

		private static void RebuildHelpers()
		{
		}

		public static string Filter(string input)
		{
			return null;
		}
	}
}
