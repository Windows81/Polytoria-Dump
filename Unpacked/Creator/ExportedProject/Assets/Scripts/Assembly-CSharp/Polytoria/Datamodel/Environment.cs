using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Mirror;
using MoonSharp.Interpreter;
using Unity.AI.Navigation;
using UnityEngine;

namespace Polytoria.Datamodel
{
	public class Environment : Instance
	{
		[CompilerGenerated]
		private sealed class _003CExplosionForce_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Collider col;

			public float force;

			public Vector3 position;

			public float radius;

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
			public _003CExplosionForce_003Ed__36(int _003C_003E1__state)
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

		[SyncVar]
		private SkyboxPreset skybox;

		[SyncVar]
		private Vector3 gravity;

		[SyncVar]
		private bool fogEnabled;

		[SyncVar]
		private float fogStartDistance;

		[SyncVar]
		private float fogEndDistance;

		[SyncVar]
		private Color fogColor;

		[SyncVar]
		private float partDestroyHeight;

		[SyncVar]
		private bool autoGenerateNavMesh;

		private NavMeshSurface surface;

		private GameObject explosionPrefab;

		[CreatorProperty]
		[Archivable]
		public SkyboxPreset Skybox
		{
			get
			{
				return default(SkyboxPreset);
			}
			set
			{
			}
		}

		[CreatorProperty]
		[Archivable]
		public Vector3 Gravity
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		[CreatorProperty]
		[Archivable]
		public bool FogEnabled
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
		public float FogStartDistance
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
		public float FogEndDistance
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
		public Color FogColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		[CreatorProperty]
		[Archivable]
		public float PartDestroyHeight
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
		public bool AutoGenerateNavMesh
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public SkyboxPreset Networkskybox
		{
			get
			{
				return default(SkyboxPreset);
			}
			[param: In]
			set
			{
			}
		}

		public Vector3 Networkgravity
		{
			get
			{
				return default(Vector3);
			}
			[param: In]
			set
			{
			}
		}

		public bool NetworkfogEnabled
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

		public float NetworkfogStartDistance
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

		public float NetworkfogEndDistance
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

		public Color NetworkfogColor
		{
			get
			{
				return default(Color);
			}
			[param: In]
			set
			{
			}
		}

		public float NetworkpartDestroyHeight
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

		public bool NetworkautoGenerateNavMesh
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

		protected override void Awake()
		{
		}

		public void CreateExplosion(Vector3 position, float radius = 10f, float force = 5000f, bool affectKinematic = true, DynValue callback = null, float damage = 100000f)
		{
		}

		[IteratorStateMachine(typeof(_003CExplosionForce_003Ed__36))]
		private IEnumerator ExplosionForce(Collider col, Vector3 position, float radius, float force)
		{
			return null;
		}

		public RayResult? Raycast(Vector3 origin, Vector3 direction, float maxDistance = 1f / 0f, List<Instance> ignoreList = null)
		{
			return null;
		}

		public RayResult[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance = 1f / 0f, List<Instance> ignoreList = null)
		{
			return null;
		}

		public Instance[] OverlapSphere(Vector3 position, float radius, List<Instance> ignoreList = null)
		{
			return null;
		}

		public Instance[] OverlapBox(Vector3 center, Vector3 size, Vector3 rotation, List<Instance> ignoreList = null)
		{
			return null;
		}

		protected override void Start()
		{
		}

		public void RebuildNavMesh(Instance root = null)
		{
		}

		public Vector3 GetPointOnNavMesh(Vector3 position, float maxDistance = 100f)
		{
			return default(Vector3);
		}

		[ClientRpc]
		private void RpcSetSkybox(SkyboxPreset sky)
		{
		}

		[ClientRpc]
		private void RpcExplode(Vector3 position, float radius)
		{
		}

		private void AddPlrExplosionForce(Player player, Vector3 position, float radius, float force)
		{
		}

		[TargetRpc]
		private void ApplyForceTargetRpc(NetworkConnection target, Vector3 force)
		{
		}

		[ClientRpc]
		private void RpcSetGravity(Vector3 g)
		{
		}

		[ClientRpc]
		private void RpcSetFogEnabled(bool enabled)
		{
		}

		[ClientRpc]
		private void RpcSetFogStartDistance(float dist)
		{
		}

		[ClientRpc]
		private void RpcSetFogEndDistance(float dist)
		{
		}

		[ClientRpc]
		private void RpcSetFogColor(Color c)
		{
		}

		public override bool Weaved()
		{
			return false;
		}

		protected void UserCode_RpcSetSkybox__SkyboxPreset(SkyboxPreset sky)
		{
		}

		protected static void InvokeUserCode_RpcSetSkybox__SkyboxPreset(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcExplode__Vector3__Single(Vector3 position, float radius)
		{
		}

		protected static void InvokeUserCode_RpcExplode__Vector3__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_ApplyForceTargetRpc__NetworkConnection__Vector3(NetworkConnection target, Vector3 force)
		{
		}

		protected static void InvokeUserCode_ApplyForceTargetRpc__NetworkConnection__Vector3(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetGravity__Vector3(Vector3 g)
		{
		}

		protected static void InvokeUserCode_RpcSetGravity__Vector3(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetFogEnabled__Boolean(bool enabled)
		{
		}

		protected static void InvokeUserCode_RpcSetFogEnabled__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetFogStartDistance__Single(float dist)
		{
		}

		protected static void InvokeUserCode_RpcSetFogStartDistance__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetFogEndDistance__Single(float dist)
		{
		}

		protected static void InvokeUserCode_RpcSetFogEndDistance__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetFogColor__Color(Color c)
		{
		}

		protected static void InvokeUserCode_RpcSetFogColor__Color(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		static Environment()
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
