using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Mirror;
using UnityEngine.Networking;

namespace Polytoria.Datamodel
{
	[Instantiatable]
	public class ImageSky : SkyBase
	{
		private struct ImageLoadQueueEntry
		{
			public string TextureName { get; set; }

			public int ImageId { get; set; }
		}

		private enum SkyboxSide
		{
			Top = 0,
			Bottom = 1,
			Left = 2,
			Right = 3,
			Front = 4,
			Back = 5
		}

		[CompilerGenerated]
		private sealed class _003CLoadSkyboxImage_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ImageSky _003C_003E4__this;

			public ImageLoadQueueEntry entry;

			private UnityWebRequest _003Cuwr_003E5__2;

			private UnityWebRequest _003Ctwr_003E5__3;

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
			public _003CLoadSkyboxImage_003Ed__35(int _003C_003E1__state)
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

		private static readonly string topTextureName;

		private static readonly string bottomTextureName;

		private static readonly string leftTextureName;

		private static readonly string rightTextureName;

		private static readonly string frontTextureName;

		private static readonly string backTextureName;

		private bool processing;

		[SyncVar]
		private int topId;

		[SyncVar]
		private int bottomId;

		[SyncVar]
		private int leftId;

		[SyncVar]
		private int rightId;

		[SyncVar]
		private int frontId;

		[SyncVar]
		private int backId;

		private Queue<ImageLoadQueueEntry> queue;

		[CreatorProperty]
		[Archivable]
		public int TopId
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
		public int BottomId
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
		public int LeftId
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
		public int RightId
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
		public int FrontId
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
		public int BackId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int NetworktopId
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

		public int NetworkbottomId
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

		public int NetworkleftId
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

		public int NetworkrightId
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

		public int NetworkfrontId
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

		public int NetworkbackId
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

		protected override void Start()
		{
		}

		protected override void Apply()
		{
		}

		private void Update()
		{
		}

		[IteratorStateMachine(typeof(_003CLoadSkyboxImage_003Ed__35))]
		private IEnumerator LoadSkyboxImage(ImageLoadQueueEntry entry)
		{
			return null;
		}

		protected override void CopyProperties(Instance clone)
		{
		}

		[ClientRpc]
		private void RpcSetImageId(SkyboxSide side, int id)
		{
		}

		static ImageSky()
		{
		}

		public override bool Weaved()
		{
			return false;
		}

		protected void UserCode_RpcSetImageId__SkyboxSide__Int32(SkyboxSide side, int id)
		{
		}

		protected static void InvokeUserCode_RpcSetImageId__SkyboxSide__Int32(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
