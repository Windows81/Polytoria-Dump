using System.Collections.Generic;
using System.Runtime.InteropServices;
using Mirror;
using MoonSharp.Interpreter;
using Polytoria.Controllers;
using Polytoria.Lua;
using UnityEngine;
using UnityEngine.AI;

namespace Polytoria.Datamodel
{
	[Instantiatable]
	public class NPC : DynamicInstance, IToolHolder
	{
		[SerializeField]
		private LayerMask ignoreLayer;

		[SerializeField]
		private GameObject head;

		[SerializeField]
		private GameObject torso;

		[SerializeField]
		private GameObject leftArm;

		[SerializeField]
		private GameObject rightArm;

		[SerializeField]
		private GameObject leftLeg;

		[SerializeField]
		private GameObject rightLeg;

		[SerializeField]
		private List<Rigidbody> deathBodyParts;

		[SerializeField]
		private Transform toolAttachPoint;

		[SyncVar]
		private float maxHealth;

		[SyncVar]
		private float health;

		[SyncVar]
		private float walkSpeed;

		[SyncVar]
		private float jumpPower;

		private int shirtID;

		private int pantsID;

		private int faceID;

		[SyncVar]
		private bool anchored;

		[SyncVar]
		private bool grounded;

		private Rigidbody rb;

		private Collider col;

		private Animator anim;

		private NetworkAnimator netAnim;

		private NPCAppearance appearance;

		private NavMeshAgent agent;

		public float maxStepHeight;

		public float stepSearchOvershoot;

		private PhysicsMaterial airMaterial;

		private PhysicsMaterial groundMaterial;

		private float jumpCooldown;

		private List<ContactPoint> allCPs;

		private Vector3 lastVelocity;

		private Dictionary<Rigidbody, Vector3> defaultBodyPartPos;

		private Instance moveTarget;

		public LuaEvent Died;

		private bool isDead;

		[MoonSharpHidden]
		public Transform ToolAttachmentPoint => null;

		public Instance MoveTarget
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[CreatorProperty]
		[Archivable]
		public Color HeadColor
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
		public Color TorsoColor
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
		public Color LeftArmColor
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
		public Color RightArmColor
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
		public Color LeftLegColor
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
		public Color RightLegColor
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

		public float NavDestinationDistance => 0f;

		public bool NavDestinationReached => false;

		public bool NavDestinationValid => false;

		[CreatorProperty]
		[Archivable]
		public float Health
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
		public float MaxHealth
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
		public float WalkSpeed
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
		public float JumpPower
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
		public int ShirtID
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
		public int PantsID
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
		public int FaceID
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

		public bool Grounded => false;

		public float NetworkmaxHealth
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

		public float Networkhealth
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

		public float NetworkwalkSpeed
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

		public float NetworkjumpPower
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

		public bool Networkgrounded
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

		[ClientRpc]
		private void RpcSetWalkSpeed(float walkSpeed)
		{
		}

		protected override void Awake()
		{
		}

		protected override void OnNetworkStart()
		{
		}

		protected override void Start()
		{
		}

		public override void OnStartClient()
		{
		}

		protected override void Update()
		{
		}

		public void SetNavDestination(Vector3 pos)
		{
		}

		private void Die()
		{
		}

		[ClientRpc]
		private void RpcSetAnimatorActive(bool active)
		{
		}

		private void SetAnimatorActive(bool active)
		{
		}

		public void Respawn()
		{
		}

		private void FixedUpdate()
		{
		}

		private void MoveDirection(Vector3 dir)
		{
		}

		private void OnCollisionStay(Collision col)
		{
		}

		private bool FindGround(out ContactPoint groundCP, List<ContactPoint> allCPs)
		{
			groundCP = default(ContactPoint);
			return false;
		}

		private bool FindStep(out Vector3 stepUpOffset, List<ContactPoint> allCPs, ContactPoint groundCP, Vector3 currVelocity)
		{
			stepUpOffset = default(Vector3);
			return false;
		}

		private bool ResolveStepUp(out Vector3 stepUpOffset, ContactPoint stepTestCP, ContactPoint groundCP)
		{
			stepUpOffset = default(Vector3);
			return false;
		}

		private bool IsGrounded()
		{
			return false;
		}

		public void Jump()
		{
		}

		public void LoadAppearance(int userID)
		{
		}

		public void ClearAppearance()
		{
		}

		public Tool GetEquippedTool()
		{
			return null;
		}

		public void EquipTool(Tool tool)
		{
		}

		public void DropTool()
		{
		}

		[MoonSharpHidden]
		public void PlayAnim(string _anim)
		{
		}

		[TargetRpc]
		[MoonSharpHidden]
		public void PlayAnimTargetRpc(string _anim)
		{
		}

		[ClientRpc]
		private void RpcJumpSound()
		{
		}

		protected override void CopyProperties(Instance clone)
		{
		}

		[ClientRpc]
		private void RpcSetAnchored(bool a)
		{
		}

		protected override void OnHide()
		{
		}

		protected override void OnShow()
		{
		}

		public override bool Weaved()
		{
			return false;
		}

		protected void UserCode_RpcSetWalkSpeed__Single(float walkSpeed)
		{
		}

		protected static void InvokeUserCode_RpcSetWalkSpeed__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetAnimatorActive__Boolean(bool active)
		{
		}

		protected static void InvokeUserCode_RpcSetAnimatorActive__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_PlayAnimTargetRpc__String(string _anim)
		{
		}

		protected static void InvokeUserCode_PlayAnimTargetRpc__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcJumpSound()
		{
		}

		protected static void InvokeUserCode_RpcJumpSound(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetAnchored__Boolean(bool a)
		{
		}

		protected static void InvokeUserCode_RpcSetAnchored__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		static NPC()
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
