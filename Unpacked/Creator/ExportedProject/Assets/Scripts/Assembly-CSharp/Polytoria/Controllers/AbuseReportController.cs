using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;

namespace Polytoria.Controllers
{
	public class AbuseReportController : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CSubmitAbuseReport_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

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
			public _003CSubmitAbuseReport_003Ed__6(int _003C_003E1__state)
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

		[SerializeField]
		private TMP_InputField input;

		[SerializeField]
		private RectTransform defaultPanel;

		[SerializeField]
		private RectTransform finishedPanel;

		public void Submit()
		{
		}

		public void Return()
		{
		}

		public void Cancel()
		{
		}

		[IteratorStateMachine(typeof(_003CSubmitAbuseReport_003Ed__6))]
		private IEnumerator SubmitAbuseReport(string message)
		{
			return null;
		}
	}
}
