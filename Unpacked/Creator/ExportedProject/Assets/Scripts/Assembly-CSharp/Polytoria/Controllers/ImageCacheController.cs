using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

namespace Polytoria.Controllers
{
	public class ImageCacheController : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CLoadImage_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ImageCacheKey key;

			public int tries;

			public ImageCacheController _003C_003E4__this;

			private string _003Curl_003E5__2;

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
			public _003CLoadImage_003Ed__12(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CWaitForImage_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Action<ImageCacheKey, ImageCacheEntry> callback;

			public ImageCacheKey key;

			public ImageCacheController _003C_003E4__this;

			private float _003Ctime_003E5__2;

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
			public _003CWaitForImage_003Ed__10(int _003C_003E1__state)
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

		private static Dictionary<ImageCacheKey, ImageCacheEntry> cache;

		private Queue<ImageCacheKey> loadQueue;

		private Texture2D fallback;

		private bool loading;

		public static ImageCacheController Instance { get; private set; }

		private void Awake()
		{
		}

		public void GetImage(ImageCacheKey key, Action<ImageCacheKey, ImageCacheEntry> callback)
		{
		}

		[IteratorStateMachine(typeof(_003CWaitForImage_003Ed__10))]
		private IEnumerator WaitForImage(ImageCacheKey key, Action<ImageCacheKey, ImageCacheEntry> callback)
		{
			return null;
		}

		private void Update()
		{
		}

		[IteratorStateMachine(typeof(_003CLoadImage_003Ed__12))]
		private IEnumerator LoadImage(ImageCacheKey key, int tries = 0)
		{
			return null;
		}
	}
}
