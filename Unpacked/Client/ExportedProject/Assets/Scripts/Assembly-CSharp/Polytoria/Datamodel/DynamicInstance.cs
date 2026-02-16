using System;
using System.Runtime.InteropServices;
using Mirror;
using MoonSharp.Interpreter;
using UnityEngine;

namespace Polytoria.Datamodel
{
	public class DynamicInstance : Instance
	{
		[Range(0.01f, 1f)]
		public float transformSyncInterval;

		[Range(0f, 2f)]
		public float positionThreshold;

		[Range(0f, 2f)]
		public float rotationThreshold;

		[Range(0f, 2f)]
		public float scaleThreshold;

		private Rigidbody _rb;

		[SerializeField]
		private bool syncVelocity;

		[SerializeField]
		private float velocitySensitivity;

		[SerializeField]
		private bool syncAngularVelocity;

		[SerializeField]
		private float angularVelocitySensitivity;

		protected float timeAlive;

		private bool first;

		private bool requestedTransform;

		private const float MIN_SIZE = 0.01f;

		private double lastServerSendTime;

		[SyncVar(hook = "OnVelocityChanged")]
		private Vector3 _velocity;

		[SyncVar(hook = "OnAngularVelocityChanged")]
		private Vector3 _angularVelocity;

		[SyncVar(hook = "OnIsKinematicChanged")]
		private bool _isKinematic;

		[SyncVar(hook = "OnUseGravityChanged")]
		private bool _useGravity;

		[SyncVar(hook = "OnDragChanged")]
		private float _drag;

		[SyncVar(hook = "OnAngularDragChanged")]
		private float _angularDrag;

		private ClientSyncState previousValue;

		private Vector3 lastPos;

		private Vector3 lastSize;

		private Quaternion lastRot;

		private Vector3 serverPosition;

		private Vector3 serverSize;

		private Quaternion serverRotation;

		private bool isDirty;

		private bool isChildOfPlayerTool;

		private Players players;

		public Action<Vector3, Vector3> _Mirror_SyncVarHookDelegate__velocity;

		public Action<Vector3, Vector3> _Mirror_SyncVarHookDelegate__angularVelocity;

		public Action<bool, bool> _Mirror_SyncVarHookDelegate__isKinematic;

		public Action<bool, bool> _Mirror_SyncVarHookDelegate__useGravity;

		public Action<float, float> _Mirror_SyncVarHookDelegate__drag;

		public Action<float, float> _Mirror_SyncVarHookDelegate__angularDrag;

		protected virtual bool DoTransformSync => false;

		[MoonSharpHidden]
		public SyncMode SyncMode { get; set; }

		[CreatorProperty]
		[Archivable]
		public Vector3 Position
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
		public Vector3 Rotation
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
		public Vector3 LocalPosition
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
		public Vector3 LocalRotation
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
		public Vector3 Size
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
		public Vector3 LocalSize
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		[Archivable]
		public Quaternion Quaternion
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		[Archivable]
		public Quaternion LocalQuaternion
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		public Vector3 Forward => default(Vector3);

		public Vector3 Right => default(Vector3);

		public Vector3 Up => default(Vector3);

		private bool IgnoreSync => false;

		public Vector3 Network_velocity
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

		public Vector3 Network_angularVelocity
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

		public bool Network_isKinematic
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

		public bool Network_useGravity
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

		public float Network_drag
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

		public float Network_angularDrag
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

		private void OnVelocityChanged(Vector3 _, Vector3 newValue)
		{
		}

		private void OnAngularVelocityChanged(Vector3 _, Vector3 newValue)
		{
		}

		private void OnIsKinematicChanged(bool _, bool newValue)
		{
		}

		private void OnUseGravityChanged(bool _, bool newValue)
		{
		}

		private void OnDragChanged(float _, float newValue)
		{
		}

		private void OnAngularDragChanged(float _, float newValue)
		{
		}

		protected override void Awake()
		{
		}

		private void OnGameLoadedLocally()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void RequestTransform()
		{
		}

		public void ApplyTransform()
		{
		}

		public void CheckIfChildOfPlayerTool()
		{
		}

		protected override void Start()
		{
		}

		public override void OnStartClient()
		{
		}

		private void UpdateServer()
		{
		}

		private void UpdateClient()
		{
		}

		protected virtual void Update()
		{
		}

		private bool HasTransformChanged()
		{
			return false;
		}

		private void CacheTransform()
		{
		}

		protected override void CopyProperties(Instance clone)
		{
		}

		private void SyncPhysics()
		{
		}

		private void UpdateTransform()
		{
		}

		[MoonSharpHidden]
		public void SyncTransformRecursively()
		{
		}

		[ClientRpc(includeOwner = false)]
		protected void RpcSyncTransform(Vector3 position, Quaternion rotation, Vector3 size)
		{
		}

		[Command(requiresAuthority = false)]
		private void CmdRequestTransform(NetworkConnectionToClient sender = null)
		{
		}

		[TargetRpc]
		private void SetTransformTargetRpc(NetworkConnection target, Vector3 position, Quaternion rotation, Vector3 size)
		{
		}

		public void LookAt(Vector3 target, Vector3 worldUp)
		{
		}

		public void LookAt(Vector3 target)
		{
		}

		public void LookAt(DynamicInstance target)
		{
		}

		public void Translate(Vector3 translation)
		{
		}

		public void RotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		public void Rotate(Vector3 eulerAngles)
		{
		}

		public Vector3 InverseTransformPoint(Vector3 point)
		{
			return default(Vector3);
		}

		public Vector3 TransformPoint(Vector3 point)
		{
			return default(Vector3);
		}

		public Vector3 InverseTransformDirection(Vector3 direction)
		{
			return default(Vector3);
		}

		public Vector3 TransformDirection(Vector3 direction)
		{
			return default(Vector3);
		}

		public Vector3 InverseTransformVector(Vector3 vector)
		{
			return default(Vector3);
		}

		public Vector3 TransformVector(Vector3 vector)
		{
			return default(Vector3);
		}

		public override bool Weaved()
		{
			return false;
		}

		protected void UserCode_RpcSyncTransform__Vector3__Quaternion__Vector3(Vector3 position, Quaternion rotation, Vector3 size)
		{
		}

		protected static void InvokeUserCode_RpcSyncTransform__Vector3__Quaternion__Vector3(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_CmdRequestTransform__NetworkConnectionToClient(NetworkConnectionToClient sender)
		{
		}

		protected static void InvokeUserCode_CmdRequestTransform__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_SetTransformTargetRpc__NetworkConnection__Vector3__Quaternion__Vector3(NetworkConnection target, Vector3 position, Quaternion rotation, Vector3 size)
		{
		}

		protected static void InvokeUserCode_SetTransformTargetRpc__NetworkConnection__Vector3__Quaternion__Vector3(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		static DynamicInstance()
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
