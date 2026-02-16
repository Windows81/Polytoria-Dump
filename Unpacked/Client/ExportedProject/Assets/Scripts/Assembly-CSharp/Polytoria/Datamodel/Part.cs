using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Mirror;
using UnityEngine;

namespace Polytoria.Datamodel
{
	[Instantiatable]
	public class Part : DynamicInstance
	{
		public static float MaterialUVScale;

		protected bool isSpawnCached;

		[SyncVar(hook = "OnIsSpawnChanged")]
		protected bool isSpawn;

		[SyncVar(hook = "OnAnchoredChanged")]
		protected bool anchored;

		[SyncVar(hook = "OnCanCollideChanged")]
		protected bool canCollide;

		[SyncVar(hook = "OnColorChange")]
		protected Color color;

		[SyncVar(hook = "OnShapeChange")]
		protected PartShape shape;

		[SyncVar(hook = "OnMaterialChange")]
		protected PartMaterial material;

		[SyncVar(hook = "SetVelocity")]
		private Vector3 velocity;

		[SyncVar(hook = "OnCastShadowsChanged")]
		private bool castShadows;

		[SyncVar(hook = "OnDragChanged")]
		private float drag;

		[SyncVar(hook = "OnAngularDragChanged")]
		private float angularDrag;

		[SyncVar(hook = "OnUseGravityChanged")]
		private bool useGravity;

		[SyncVar(hook = "OnBouncinessChanged")]
		private float bounciness;

		[SyncVar(hook = "OnFrictionChanged")]
		private float friction;

		[SyncVar(hook = "OnFrictionCombineChanged")]
		private PhysicsMaterialCombine frictionCombine;

		[SyncVar(hook = "OnBounceCombineChanged")]
		private PhysicsMaterialCombine bounceCombine;

		private MaterialPropertyBlock materialPropertyBlock;

		private Renderer _renderer;

		private static Dictionary<PartShape, Mesh> shapeMeshes;

		[SyncVar(hook = "SetMass")]
		private float mass;

		private Vector3 lastScale;

		private Environment environment;

		public Action<bool, bool> _Mirror_SyncVarHookDelegate_isSpawn;

		public Action<bool, bool> _Mirror_SyncVarHookDelegate_anchored;

		public Action<bool, bool> _Mirror_SyncVarHookDelegate_canCollide;

		public Action<Color, Color> _Mirror_SyncVarHookDelegate_color;

		public Action<PartShape, PartShape> _Mirror_SyncVarHookDelegate_shape;

		public Action<PartMaterial, PartMaterial> _Mirror_SyncVarHookDelegate_material;

		public Action<Vector3, Vector3> _Mirror_SyncVarHookDelegate_velocity;

		public Action<bool, bool> _Mirror_SyncVarHookDelegate_castShadows;

		public Action<float, float> _Mirror_SyncVarHookDelegate_drag;

		public Action<float, float> _Mirror_SyncVarHookDelegate_angularDrag;

		public Action<bool, bool> _Mirror_SyncVarHookDelegate_useGravity;

		public Action<float, float> _Mirror_SyncVarHookDelegate_bounciness;

		public Action<float, float> _Mirror_SyncVarHookDelegate_friction;

		public Action<PhysicsMaterialCombine, PhysicsMaterialCombine> _Mirror_SyncVarHookDelegate_frictionCombine;

		public Action<PhysicsMaterialCombine, PhysicsMaterialCombine> _Mirror_SyncVarHookDelegate_bounceCombine;

		public Action<float, float> _Mirror_SyncVarHookDelegate_mass;

		[CreatorProperty]
		[Archivable]
		public Color Color
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
		public bool Anchored
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
		public bool CanCollide
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
		public bool IsSpawn
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
		public PartShape Shape
		{
			get
			{
				return default(PartShape);
			}
			set
			{
			}
		}

		[CreatorProperty]
		[Archivable]
		public PartMaterial Material
		{
			get
			{
				return default(PartMaterial);
			}
			set
			{
			}
		}

		[CreatorProperty]
		[Archivable]
		public Vector3 Velocity
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
		public float Drag
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
		public float AngularDrag
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
		public float Mass
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Vector3 AngularVelocity
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
		public bool UseGravity
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
		public float Bounciness
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
		public float Friction
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
		public PhysicsMaterialCombine FrictionCombine
		{
			get
			{
				return default(PhysicsMaterialCombine);
			}
			set
			{
			}
		}

		[CreatorProperty]
		[Archivable]
		public PhysicsMaterialCombine BounceCombine
		{
			get
			{
				return default(PhysicsMaterialCombine);
			}
			set
			{
			}
		}

		[CreatorProperty]
		[Archivable]
		public bool CastShadows
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool NetworkisSpawn
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

		public bool Networkanchored
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

		public bool NetworkcanCollide
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

		public Color Networkcolor
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

		public PartShape Networkshape
		{
			get
			{
				return default(PartShape);
			}
			[param: In]
			set
			{
			}
		}

		public PartMaterial Networkmaterial
		{
			get
			{
				return default(PartMaterial);
			}
			[param: In]
			set
			{
			}
		}

		public Vector3 Networkvelocity
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

		public bool NetworkcastShadows
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

		public float Networkdrag
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

		public float NetworkangularDrag
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

		public bool NetworkuseGravity
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

		public float Networkbounciness
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

		public float Networkfriction
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

		public PhysicsMaterialCombine NetworkfrictionCombine
		{
			get
			{
				return default(PhysicsMaterialCombine);
			}
			[param: In]
			set
			{
			}
		}

		public PhysicsMaterialCombine NetworkbounceCombine
		{
			get
			{
				return default(PhysicsMaterialCombine);
			}
			[param: In]
			set
			{
			}
		}

		public float Networkmass
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

		protected override void OnHide()
		{
		}

		protected override void OnShow()
		{
		}

		private void UpdateMaterial()
		{
		}

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected override void OnNetworkStart()
		{
		}

		protected override void Update()
		{
		}

		protected override void CopyProperties(Instance clone)
		{
		}

		private void SetMass(float oldMass, float newMass)
		{
		}

		private void SetVelocity(Vector3 oldVelocity, Vector3 newVelocity)
		{
		}

		private void OnColorChange(Color oldColor, Color newColor)
		{
		}

		protected override void OnDestroy()
		{
		}

		public void MovePosition(Vector3 pos)
		{
		}

		public void MoveRotation(Vector3 rot)
		{
		}

		public void AddForce(Vector3 force, ForceMode mode)
		{
		}

		public void AddTorque(Vector3 torque, ForceMode mode)
		{
		}

		public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode mode)
		{
		}

		public void AddRelativeForce(Vector3 force, ForceMode mode)
		{
		}

		public void AddRelativeTorque(Vector3 torque, ForceMode mode)
		{
		}

		[ClientRpc]
		private void RpcSetAnchored(bool anchored)
		{
		}

		[ClientRpc]
		protected void RpcSetCanCollide(bool canCollide)
		{
		}

		[ClientRpc]
		private void RpcSetSpawn(bool spawn)
		{
		}

		[ClientRpc]
		private void RpcSetShape(PartShape shape)
		{
		}

		[ClientRpc]
		private void RpcSetMaterial(PartMaterial material)
		{
		}

		[ClientRpc]
		private void RpcSetDrag(float d)
		{
		}

		[ClientRpc]
		private void RpcSetAngularDrag(float d)
		{
		}

		[ClientRpc]
		private void RpcSetUseGravity(bool g)
		{
		}

		[ClientRpc]
		private void RpcSetBounciness(float b)
		{
		}

		[ClientRpc]
		private void RpcSetFriction(float f)
		{
		}

		[ClientRpc]
		private void RpcSetFrictionCombine(PhysicsMaterialCombine c)
		{
		}

		[ClientRpc]
		private void RpcSetBounceCombine(PhysicsMaterialCombine c)
		{
		}

		private void OnCastShadowsChanged(bool old, bool value)
		{
		}

		private void OnIsSpawnChanged(bool old, bool value)
		{
		}

		private void OnAnchoredChanged(bool old, bool value)
		{
		}

		private void OnCanCollideChanged(bool old, bool value)
		{
		}

		private void OnShapeChange(PartShape old, PartShape value)
		{
		}

		private void OnMaterialChange(PartMaterial old, PartMaterial value)
		{
		}

		private void OnDragChanged(float old, float value)
		{
		}

		private void OnAngularDragChanged(float old, float value)
		{
		}

		private void OnUseGravityChanged(bool old, bool value)
		{
		}

		private void OnBouncinessChanged(float old, float value)
		{
		}

		private void OnFrictionChanged(float old, float value)
		{
		}

		private void OnFrictionCombineChanged(PhysicsMaterialCombine old, PhysicsMaterialCombine value)
		{
		}

		private void OnBounceCombineChanged(PhysicsMaterialCombine old, PhysicsMaterialCombine value)
		{
		}

		static Part()
		{
		}

		public override bool Weaved()
		{
			return false;
		}

		protected void UserCode_RpcSetAnchored__Boolean(bool anchored)
		{
		}

		protected static void InvokeUserCode_RpcSetAnchored__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetCanCollide__Boolean(bool canCollide)
		{
		}

		protected static void InvokeUserCode_RpcSetCanCollide__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetSpawn__Boolean(bool spawn)
		{
		}

		protected static void InvokeUserCode_RpcSetSpawn__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetShape__PartShape(PartShape shape)
		{
		}

		protected static void InvokeUserCode_RpcSetShape__PartShape(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetMaterial__PartMaterial(PartMaterial material)
		{
		}

		protected static void InvokeUserCode_RpcSetMaterial__PartMaterial(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetDrag__Single(float d)
		{
		}

		protected static void InvokeUserCode_RpcSetDrag__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetAngularDrag__Single(float d)
		{
		}

		protected static void InvokeUserCode_RpcSetAngularDrag__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetUseGravity__Boolean(bool g)
		{
		}

		protected static void InvokeUserCode_RpcSetUseGravity__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetBounciness__Single(float b)
		{
		}

		protected static void InvokeUserCode_RpcSetBounciness__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetFriction__Single(float f)
		{
		}

		protected static void InvokeUserCode_RpcSetFriction__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetFrictionCombine__PhysicsMaterialCombine(PhysicsMaterialCombine c)
		{
		}

		protected static void InvokeUserCode_RpcSetFrictionCombine__PhysicsMaterialCombine(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetBounceCombine__PhysicsMaterialCombine(PhysicsMaterialCombine c)
		{
		}

		protected static void InvokeUserCode_RpcSetBounceCombine__PhysicsMaterialCombine(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
