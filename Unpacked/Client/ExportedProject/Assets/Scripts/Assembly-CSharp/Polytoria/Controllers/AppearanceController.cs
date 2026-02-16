using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using GLTFast;
using Polytoria.Datamodel;
using SimpleJSON;
using UnityEngine;
using UnityEngine.Networking;

namespace Polytoria.Controllers
{
	public class AppearanceController : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass8_0
		{
			public Transform headObj;

			public Transform leftArmObj;

			public Transform rightArmObj;

			public Transform torsoObj;

			public Transform leftLegObj;

			public Transform rightLegObj;

			public Action<ImageCacheKey, ImageCacheEntry> _003C_003E9__0;

			public Action<ImageCacheKey, ImageCacheEntry> _003C_003E9__1;

			public Action<ImageCacheKey, ImageCacheEntry> _003C_003E9__2;

			internal void _003CProcessPlayerAppearance_003Eb__0(ImageCacheKey key, ImageCacheEntry entry)
			{
			}

			internal void _003CProcessPlayerAppearance_003Eb__1(ImageCacheKey key, ImageCacheEntry entry)
			{
			}

			internal void _003CProcessPlayerAppearance_003Eb__2(ImageCacheKey key, ImageCacheEntry entry)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CProcessPlayerAppearance_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Player player;

			private _003C_003Ec__DisplayClass8_0 _003C_003E8__1;

			public AppearanceController _003C_003E4__this;

			private UnityWebRequest _003Cuwr_003E5__2;

			private JSONNode.Enumerator _003C_003E7__wrap2;

			private GameObject _003Chat_003E5__4;

			private GltfImport _003Cgltf_003E5__5;

			private Task<bool> _003Ct_003E5__6;

			private Task<bool> _003Ctask_003E5__7;

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
			public _003CProcessPlayerAppearance_003Ed__8(int _003C_003E1__state)
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

		private Queue<Player> playerQueue;

		private bool isProcessing;

		public static AppearanceController Instance { get; private set; }

		private void Awake()
		{
		}

		private void Update()
		{
		}

		[IteratorStateMachine(typeof(_003CProcessPlayerAppearance_003Ed__8))]
		private IEnumerator ProcessPlayerAppearance(Player player)
		{
			return null;
		}

		public void AddPlayerToQueue(Player player)
		{
		}
	}
}
