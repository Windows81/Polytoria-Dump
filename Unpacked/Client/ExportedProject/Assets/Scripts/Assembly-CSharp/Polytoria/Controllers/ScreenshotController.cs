using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace Polytoria.Controllers
{
	public class ScreenshotController : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDoPublishScreenshot_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ScreenshotController _003C_003E4__this;

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
			public _003CDoPublishScreenshot_003Ed__27(int _003C_003E1__state)
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
		private sealed class _003CDoScreenshot_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public bool hideUI;

			public ScreenshotController _003C_003E4__this;

			private string _003Cpath_003E5__2;

			private string _003Cfilename_003E5__3;

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
			public _003CDoScreenshot_003Ed__24(int _003C_003E1__state)
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

		[SerializeField]
		private RectTransform toast;

		[SerializeField]
		private RectTransform publishModal;

		[SerializeField]
		public TMP_InputField captionInput;

		[SerializeField]
		private Button publishButton;

		[SerializeField]
		private TMP_Text publishError;

		private float toastDuration;

		private float toastTimer;

		private bool toastActive;

		private string screenshotPath;

		private Sprite lastScreenshot;

		private string passphrase;

		private byte[] screenshotBytes;

		public static ScreenshotController instance { get; private set; }

		public bool Focused => false;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void HideToast()
		{
		}

		private void ShowToast()
		{
		}

		public void Screenshot(bool hideUI)
		{
		}

		[IteratorStateMachine(typeof(_003CDoScreenshot_003Ed__24))]
		private IEnumerator DoScreenshot(bool hideUI)
		{
			return null;
		}

		public void OpenScreenshot()
		{
		}

		public void PublishScreenshot()
		{
		}

		[IteratorStateMachine(typeof(_003CDoPublishScreenshot_003Ed__27))]
		private IEnumerator DoPublishScreenshot()
		{
			return null;
		}
	}
}
