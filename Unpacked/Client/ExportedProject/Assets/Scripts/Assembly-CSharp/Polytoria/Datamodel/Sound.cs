using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Mirror;
using Polytoria.Lua;
using UnityEngine;
using UnityEngine.Networking;

namespace Polytoria.Datamodel
{
	[Instantiatable]
	[RequireComponent(typeof(AudioSource))]
	public class Sound : DynamicInstance
	{
		private struct AudioCacheEntry
		{
			public AudioClip clip;

			public bool loading;
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass39_0
		{
			public int id;

			internal bool _003CGetAudioClip_003Eb__0()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003CGetAudioClip_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public int id;

			public Sound _003C_003E4__this;

			private _003C_003Ec__DisplayClass39_0 _003C_003E8__1;

			private UnityWebRequest _003Cuwr_003E5__2;

			private UnityWebRequest _003Cuwr2_003E5__3;

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
			public _003CGetAudioClip_003Ed__39(int _003C_003E1__state)
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
		private sealed class _003CplayC_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Sound _003C_003E4__this;

			private bool _003Cplayed_003E5__2;

			private int _003Ctimeout_003E5__3;

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
			public _003CplayC_003Ed__56(int _003C_003E1__state)
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

		private static Dictionary<int, AudioCacheEntry> audioCache;

		private AudioSource audioSource;

		private AudioClip clip;

		[SyncVar]
		private int soundID;

		[SyncVar]
		private bool _isPlaying;

		[SyncVar]
		private bool autoplay;

		[SyncVar]
		private float volume;

		[SyncVar]
		private float time;

		[SyncVar]
		private bool loop;

		[SyncVar]
		private bool playInWorld;

		[SyncVar]
		private float pitch;

		[SyncVar]
		private float maxDistance;

		public LuaEvent Loaded;

		private bool loading;

		public bool Playing => false;

		public bool Loading => false;

		[CreatorProperty]
		[Archivable]
		public int SoundID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[CreatorProperty]
		[Archivable]
		public float Pitch
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[CreatorProperty]
		[Archivable]
		public float MaxDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Length => 0f;

		public new Vector3 Size
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public new Vector3 Rotation
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public float Time
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[CreatorProperty]
		[Archivable]
		public bool Autoplay
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[CreatorProperty]
		[Archivable]
		public bool Loop
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[CreatorProperty]
		[Archivable]
		public bool PlayInWorld
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[CreatorProperty]
		[Archivable]
		public float Volume
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int NetworksoundID
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

		public bool Network_isPlaying
		{
			get
			{
				return false;
			}
			[param: In]
			set
			{
			}
		}

		public bool Networkautoplay
		{
			get
			{
				return false;
			}
			[param: In]
			set
			{
			}
		}

		public float Networkvolume
		{
			get
			{
				return 0f;
			}
			[param: In]
			set
			{
			}
		}

		public float Networktime
		{
			get
			{
				return 0f;
			}
			[param: In]
			set
			{
			}
		}

		public bool Networkloop
		{
			get
			{
				return false;
			}
			[param: In]
			set
			{
			}
		}

		public bool NetworkplayInWorld
		{
			get
			{
				return false;
			}
			[param: In]
			set
			{
			}
		}

		public float Networkpitch
		{
			get
			{
				return 0f;
			}
			[param: In]
			set
			{
			}
		}

		public float NetworkmaxDistance
		{
			get
			{
				return 0f;
			}
			[param: In]
			set
			{
			}
		}

		[IteratorStateMachine(typeof(_003CGetAudioClip_003Ed__39))]
		private IEnumerator GetAudioClip(int id)
		{
			return null;
		}

		[ClientRpc]
		private void RpcSetSoundId(int id)
		{
		}

		public void Play()
		{
		}

		public void PlayOneShot(float volume = 1f)
		{
		}

		[ClientRpc]
		public void RpcPlayOneShot(float volume)
		{
		}

		[IteratorStateMachine(typeof(_003CplayC_003Ed__56))]
		private IEnumerator playC()
		{
			return null;
		}

		public void Stop()
		{
		}

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected override void Update()
		{
		}

		protected override void CopyProperties(Instance clone)
		{
		}

		protected override void OnHide()
		{
		}

		protected override void OnShow()
		{
		}

		[ClientRpc]
		private void RpcStop()
		{
		}

		[ClientRpc]
		private void RpcPlay()
		{
		}

		[ClientRpc]
		private void RpcSetTime(float t)
		{
		}

		[ClientRpc]
		private void RpcSetVolume(float vol)
		{
		}

		[ClientRpc]
		private void RpcSetPitch(float p)
		{
		}

		[ClientRpc]
		private void RpcSetMaxDistance(float d)
		{
		}

		[ClientRpc]
		private void RpcChangeBoolProperty(int property, bool value)
		{
		}

		static Sound()
		{
		}

		public override bool Weaved()
		{
			return false;
		}

		protected void UserCode_RpcSetSoundId__Int32(int id)
		{
		}

		protected static void InvokeUserCode_RpcSetSoundId__Int32(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcPlayOneShot__Single(float volume)
		{
		}

		protected static void InvokeUserCode_RpcPlayOneShot__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcStop()
		{
		}

		protected static void InvokeUserCode_RpcStop(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcPlay()
		{
		}

		protected static void InvokeUserCode_RpcPlay(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetTime__Single(float t)
		{
		}

		protected static void InvokeUserCode_RpcSetTime__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetVolume__Single(float vol)
		{
		}

		protected static void InvokeUserCode_RpcSetVolume__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetPitch__Single(float p)
		{
		}

		protected static void InvokeUserCode_RpcSetPitch__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetMaxDistance__Single(float d)
		{
		}

		protected static void InvokeUserCode_RpcSetMaxDistance__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcChangeBoolProperty__Int32__Boolean(int property, bool value)
		{
		}

		protected static void InvokeUserCode_RpcChangeBoolProperty__Int32__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}
	}
}
