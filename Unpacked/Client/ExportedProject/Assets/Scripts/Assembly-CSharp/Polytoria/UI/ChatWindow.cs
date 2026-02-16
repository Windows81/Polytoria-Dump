using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Polytoria.UI
{
	public class ChatWindow : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass28_0
		{
			public TMP_Text txt;

			internal void _003CinactiveFade_003Eb__0(float val)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CinactiveFade_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ChatMessageRef t;

			private _003C_003Ec__DisplayClass28_0 _003C_003E8__1;

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
			public _003CinactiveFade_003Ed__28(int _003C_003E1__state)
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

		private Image darken;

		private Scrollbar scrollbar;

		private Image focusImage;

		public TMP_InputField input;

		private ScrollRect scrollRect;

		public static ChatWindow instance;

		private RectTransform chatMessage;

		private ChatWindowState _state;

		private RectTransform PopContainer;

		public Vector2 normalSize;

		public Vector2 focusedSize;

		public float stateChangeCooldown;

		public float StateChangeRateLimit;

		public UICommandList commandList;

		private List<ChatMessageRef> chatMessages;

		private const float chatStayTime = 10f;

		private const float chatFadeTime = 0.3f;

		public RectTransform ChatContainer { get; private set; }

		public bool Focused => false;

		public ChatWindowState state
		{
			get
			{
				return default(ChatWindowState);
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		[IteratorStateMachine(typeof(_003CinactiveFade_003Ed__28))]
		private IEnumerator inactiveFade(ChatMessageRef t)
		{
			return null;
		}

		private void Update()
		{
		}

		public void ToggleFocused()
		{
		}

		public void SetInactive()
		{
		}

		private void scrollViewToBottom()
		{
		}

		public void PushChat(string username, string message, Color usernameColor)
		{
		}
	}
}
