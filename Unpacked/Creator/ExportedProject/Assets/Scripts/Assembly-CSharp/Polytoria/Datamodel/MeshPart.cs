using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Mirror;
using UnityEngine;

namespace Polytoria.Datamodel
{
	[Instantiatable]
	public class MeshPart : Part
	{
		[SyncVar(hook = "AssetIDChanged")]
		protected int assetID;

		[SyncVar(hook = "PlayAnimationOnStartChanged")]
		private bool playAnimationOnStart;

		[SyncVar(hook = "CollisionTypeChanged")]
		private CollisionType collisionType;

		private Animation anim;

		private Dictionary<string, List<Animation>> animationsByName;

		public Bounds defaultBounds;

		public Action<int, int> _Mirror_SyncVarHookDelegate_assetID;

		public Action<bool, bool> _Mirror_SyncVarHookDelegate_playAnimationOnStart;

		public Action<CollisionType, CollisionType> _Mirror_SyncVarHookDelegate_collisionType;

		[CreatorProperty]
		[Archivable]
		public int AssetID
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
		public CollisionType CollisionType
		{
			get
			{
				return default(CollisionType);
			}
			set
			{
			}
		}

		public new PartShape Shape => default(PartShape);

		public new PartMaterial Material => default(PartMaterial);

		public string CurrentAnimation => null;

		public bool IsAnimationPlaying => false;

		[CreatorProperty]
		[Archivable]
		public bool PlayAnimationOnStart
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
		public new bool CanCollide
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int NetworkassetID
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

		public bool NetworkplayAnimationOnStart
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

		public CollisionType NetworkcollisionType
		{
			get
			{
				return default(CollisionType);
			}
			[param: In]
			set
			{
			}
		}

		public void UpdateColliders()
		{
		}

		protected override void Awake()
		{
		}

		private void LoadMesh()
		{
		}

		public void Hide()
		{
		}

		private void RefreshAnimationComponents()
		{
		}

		public void PlayAnimation(string name, string objectPath = "", float speed = 1f, bool loop = true)
		{
		}

		public void StopAnimation(string name = null)
		{
		}

		private void StopAllAnimations()
		{
		}

		public string[] GetAnimations()
		{
			return null;
		}

		public string[] GetAnimationSources(string animationName)
		{
			return null;
		}

		public AnimationInfo[] GetAnimationInfo()
		{
			return null;
		}

		private string GetRelativePath(Transform root, Transform target)
		{
			return null;
		}

		protected override void OnHide()
		{
		}

		protected override void OnShow()
		{
		}

		protected override void CopyProperties(Instance clone)
		{
		}

		[ClientRpc]
		private void RpcSetAssetID(int id)
		{
		}

		private void PlayAnimationOnStartChanged(bool oldValue, bool newValue)
		{
		}

		private void CollisionTypeChanged(CollisionType oldValue, CollisionType newValue)
		{
		}

		private void AssetIDChanged(int oldValue, int newValue)
		{
		}

		public override bool Weaved()
		{
			return false;
		}

		protected void UserCode_RpcSetAssetID__Int32(int id)
		{
		}

		protected static void InvokeUserCode_RpcSetAssetID__Int32(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		static MeshPart()
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
