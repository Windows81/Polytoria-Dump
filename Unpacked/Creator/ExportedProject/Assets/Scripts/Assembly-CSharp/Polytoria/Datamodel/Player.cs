using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Mirror;
using MoonSharp.Interpreter;
using Polytoria.Controllers;
using Polytoria.Datamodel.Services;
using Polytoria.Lua;
using Polytoria.Types;
using TMPro;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Networking;

namespace Polytoria.Datamodel
{
	[RequireComponent(typeof(ParentConstraint))]
	public class Player : Instance, IToolHolder
	{
		[CompilerGenerated]
		private sealed class _003CCheckOwnsItemFromAPI_003Ed__206 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DynValue callback;

			public int assetId;

			public Player _003C_003E4__this;

			private ScriptService _003Css_003E5__2;

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
			public _003CCheckOwnsItemFromAPI_003Ed__206(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CDelayedDisconnect_003Ed__237 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Player _003C_003E4__this;

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
			public _003CDelayedDisconnect_003Ed__237(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CDiscordLoop_003Ed__195 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

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
			public _003CDiscordLoop_003Ed__195(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CDoDie_003Ed__220 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Player _003C_003E4__this;

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
			public _003CDoDie_003Ed__220(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CLoadMetadata_003Ed__205 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Player _003C_003E4__this;

			public string authToken;

			private UnityWebRequest _003Cuwr_003E5__2;

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
			public _003CLoadMetadata_003Ed__205(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CPostPlayerLoad_003Ed__194 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Player _003C_003E4__this;

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
			public _003CPostPlayerLoad_003Ed__194(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CStopScream_003Ed__209 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Player _003C_003E4__this;

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
			public _003CStopScream_003Ed__209(int _003C_003E1__state)
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

		public static bool kicked;

		private static readonly int maxRequestsPerMin;

		private static readonly int hatCheckCacheLength;

		private readonly Array keyCodes;

		private static FootstepCollection footstepSounds;

		private const float footstepInterval = 0.3f;

		private float footstepTimer;

		private int footstepIndex;

		private AudioSource footstepPlayer;

		private ParentConstraint parentConstraint;

		private float maxHealth;

		[SyncVar]
		private float walkSpeed;

		[SyncVar]
		private float sprintSpeed;

		[SyncVar]
		private float health;

		[SerializeField]
		private bool isSprinting;

		[SerializeField]
		private bool sprintExhausted;

		[SerializeField]
		[SyncVar]
		private bool staminaEnabled;

		[SerializeField]
		[SyncVar]
		private float stamina;

		[SerializeField]
		[SyncVar]
		private float maxStamina;

		[SerializeField]
		[SyncVar]
		private float staminaRegen;

		[SerializeField]
		private float jumpPower;

		[SyncVar]
		private float respawnTime;

		[SyncVar]
		private int userID;

		[SyncVar]
		private bool loaded;

		[SyncVar]
		private bool isCreator;

		[SyncVar]
		private bool isAdmin;

		[SyncVar]
		private Color chatColor;

		[SyncVar]
		private string avatarHash;

		[SyncVar]
		private bool canMove;

		[SyncVar]
		private bool anchored;

		[SyncVar]
		public string LeaderboardBadgeId;

		[SerializeField]
		private float turnSmoothing;

		[SerializeField]
		private LayerMask ignoreLayer;

		[SerializeField]
		private Animator anim;

		[SerializeField]
		private Rigidbody rb;

		[SerializeField]
		private List<MeshRenderer> disableOnFP;

		[SerializeField]
		private List<Rigidbody> deathBodyParts;

		[SerializeField]
		private Transform toolAttachPoint;

		[SerializeField]
		private Transform camAttachment;

		private int shirtID;

		private int pantsID;

		private int faceID;

		private float coyoteTime;

		private float coyoteTimer;

		private Collider col;

		private PhysicsMaterial airMaterial;

		private PhysicsMaterial groundMaterial;

		private Dictionary<Rigidbody, Vector3> defaultBodyPartPos;

		private Transform head;

		private Transform leftArm;

		private Transform rightArm;

		private Transform torso;

		private Transform leftLeg;

		private Transform rightLeg;

		private NetworkAnimator netAnim;

		public float maxStepHeight;

		public float stepSearchOvershoot;

		private List<ContactPoint> allCPs;

		private Vector3 lastVelocity;

		private float afkTimer;

		private float maxAfkTime;

		private bool isDead;

		private float jumpCooldown;

		private float currentSpeed;

		private TMP_Text nametag;

		private Vector3 oldPos;

		[SyncVar]
		private Seat sittingIn;

		public LuaEvent Chatted;

		public LuaEvent Died;

		public LuaEvent Respawned;

		private Environment _env;

		private Dictionary<int, bool> assetOwnCache;

		private Dictionary<int, int> assetCacheCheckTimes;

		private static Dictionary<int, int> assetCheckCounts;

		private float defaultFov;

		private float sprintFov;

		private AppearanceLoaderBase appearance;

		private Camera cam;

		private bool climbing;

		private bool isEmote;

		protected NetworkBehaviourSyncVar ___sittingInNetId;

		[MoonSharpHidden]
		public bool IsLocalPlayer => false;

		[MoonSharpHidden]
		public bool IsLoaded => false;

		[CreatorProperty]
		public float RespawnTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

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
		public float SprintSpeed
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
		public bool StaminaEnabled
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
		public float Stamina
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
		public float MaxStamina
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
		public float StaminaRegen
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

		public Color ChatColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public bool CanMove
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

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

		public bool IsInputFocused => false;

		public string AvatarHash => null;

		public Seat SittingIn => null;

		public Vector3 Forward => default(Vector3);

		public Vector3 Right => default(Vector3);

		public bool IsAdmin => false;

		public bool IsCreator => false;

		private bool IsSitting => false;

		private bool IsMovementAllowed => false;

		[CreatorProperty]
		public int UserID
		{
			get
			{
				return 0;
			}
			private set
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

		[MoonSharpHidden]
		public Transform ToolAttachmentPoint => null;

		private Camera Camera
		{
			get
			{
				return null;
			}
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

		public float NetworksprintSpeed
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

		public bool NetworkstaminaEnabled
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

		public float Networkstamina
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

		public float NetworkmaxStamina
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

		public float NetworkstaminaRegen
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

		public float NetworkrespawnTime
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

		public int NetworkuserID
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

		public bool Networkloaded
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

		public bool NetworkisCreator
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

		public bool NetworkisAdmin
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

		public Color NetworkchatColor
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

		public string NetworkavatarHash
		{
			get
			{
				return null;
			}
			[param: In]
			set
			{
			}
		}

		public bool NetworkcanMove
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

		public string NetworkLeaderboardBadgeId
		{
			get
			{
				return null;
			}
			[param: In]
			set
			{
			}
		}

		public Seat NetworksittingIn
		{
			get
			{
				return null;
			}
			[param: In]
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		private void Move(float hor, float ver)
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

		private void SetChildLayers(Transform root, LayerMask layer)
		{
		}

		[IteratorStateMachine(typeof(_003CPostPlayerLoad_003Ed__194))]
		private IEnumerator PostPlayerLoad()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDiscordLoop_003Ed__195))]
		private IEnumerator DiscordLoop()
		{
			return null;
		}

		[Command]
		private void NotifyJoin()
		{
		}

		public void OwnsItem(int assetId, DynValue callback)
		{
		}

		private void OnCollisionStay(Collision col)
		{
		}

		protected override void OnCollisionExit(Collision col)
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

		[MoonSharpHidden]
		public void SetLoaded(string authToken)
		{
		}

		[IteratorStateMachine(typeof(_003CLoadMetadata_003Ed__205))]
		private IEnumerator LoadMetadata(string authToken)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCheckOwnsItemFromAPI_003Ed__206))]
		private IEnumerator CheckOwnsItemFromAPI(int assetId, DynValue callback)
		{
			return null;
		}

		private void SendChat()
		{
		}

		[IteratorStateMachine(typeof(_003CStopScream_003Ed__209))]
		private IEnumerator StopScream()
		{
			return null;
		}

		private void UpdateFootsteps()
		{
		}

		private void DoFootstep()
		{
		}

		private void Die()
		{
		}

		[Command]
		private void CmdDied()
		{
		}

		private void DropTools()
		{
		}

		[Command]
		private void CmdDropTools()
		{
		}

		private void DoDropTools()
		{
		}

		[Command]
		[MoonSharpHidden]
		public void EquipTool(Tool tool)
		{
		}

		[ClientRpc]
		private void RpcSetAnimatorActive(bool active)
		{
		}

		[TargetRpc]
		[MoonSharpHidden]
		public void SetTransformAttrTargetRpc(string attr, Vector3 value)
		{
		}

		[IteratorStateMachine(typeof(_003CDoDie_003Ed__220))]
		private IEnumerator DoDie()
		{
			return null;
		}

		[MoonSharpHidden]
		public void SetUserID(int userID)
		{
		}

		public void LoadAppearance(int userID)
		{
		}

		public void ClearAppearance()
		{
		}

		public void ResetAppearance()
		{
		}

		private bool IsGrounded()
		{
			return false;
		}

		protected override void OnCollisionEnter(Collision collision)
		{
		}

		protected override void OnTriggerEnter(Collider collider)
		{
		}

		protected override void OnTriggerExit(Collider collider)
		{
		}

		[Command]
		private void CmdTouched(GameObject other)
		{
		}

		[Command]
		private void CmdTouchEnded(GameObject other)
		{
		}

		private bool PressingMovementKeys()
		{
			return false;
		}

		private void UpdateFov(bool sprinting)
		{
		}

		[Command]
		private void CmdJumpSound()
		{
		}

		[ClientRpc]
		private void RpcJumpSound()
		{
		}

		private void DoJumpSound()
		{
		}

		public void Kick(string reason = "You have been kicked from the server.")
		{
		}

		[IteratorStateMachine(typeof(_003CDelayedDisconnect_003Ed__237))]
		private IEnumerator DelayedDisconnect()
		{
			return null;
		}

		[TargetRpc]
		private void SendDisconnectMessageTargetRpc(string message)
		{
		}

		public void Sit(Seat seat)
		{
		}

		[TargetRpc]
		private void UnsitTargetRpc(bool addForce)
		{
		}

		public void Unsit(bool addForce = true)
		{
		}

		[Command]
		[MoonSharpHidden]
		public void CmdSetSittingIn(Seat seat)
		{
		}

		private void SetSittingIn(Seat seat)
		{
		}

		[Command]
		private void CmdNotifyRespawn()
		{
		}

		private void ServerRespawn()
		{
		}

		public void Respawn()
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

		[TargetRpc]
		[MoonSharpHidden]
		public void TargetSetPosition(Vector3 pos)
		{
		}

		[ClientRpc]
		private void RpcSetRespawnTime(float time)
		{
		}

		[ClientRpc]
		private void RpcSetMaxHealth(float maxHealth)
		{
		}

		[ClientRpc]
		private void RpcSetHealth(float health)
		{
		}

		[Command]
		private void CmdSetHealth(float health)
		{
		}

		[ClientRpc]
		private void RpcSetWalkSpeed(float walkSpeed)
		{
		}

		[ClientRpc]
		private void RpcSetSprintSpeed(float sprintSpeed)
		{
		}

		[ClientRpc]
		private void RpcSetMaxStamina(float val)
		{
		}

		[ClientRpc]
		private void RpcSetStamina(float val)
		{
		}

		[ClientRpc]
		private void RpcSetStaminaRegen(float val)
		{
		}

		[ClientRpc]
		private void RpcSetStaminaEnabled(bool val)
		{
		}

		[ClientRpc]
		private void RpcSetJumpPower(float jumpPower)
		{
		}

		[ClientRpc]
		private void RpcSetChatColor(Color col)
		{
		}

		[ClientRpc]
		private void RpcSetCanMove(bool canMove)
		{
		}

		[ClientRpc]
		private void RpcSetAnchored(bool anchored)
		{
		}

		[ClientRpc]
		private void RpcSetColor(BodyPart bodyPart, Color color)
		{
		}

		static Player()
		{
		}

		public override bool Weaved()
		{
			return false;
		}

		protected void UserCode_PlayAnimTargetRpc__String(string _anim)
		{
		}

		protected static void InvokeUserCode_PlayAnimTargetRpc__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_NotifyJoin()
		{
		}

		protected static void InvokeUserCode_NotifyJoin(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_CmdDied()
		{
		}

		protected static void InvokeUserCode_CmdDied(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_CmdDropTools()
		{
		}

		protected static void InvokeUserCode_CmdDropTools(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_EquipTool__Tool(Tool tool)
		{
		}

		protected static void InvokeUserCode_EquipTool__Tool(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetAnimatorActive__Boolean(bool active)
		{
		}

		protected static void InvokeUserCode_RpcSetAnimatorActive__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_SetTransformAttrTargetRpc__String__Vector3(string attr, Vector3 value)
		{
		}

		protected static void InvokeUserCode_SetTransformAttrTargetRpc__String__Vector3(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_CmdTouched__GameObject(GameObject other)
		{
		}

		protected static void InvokeUserCode_CmdTouched__GameObject(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_CmdTouchEnded__GameObject(GameObject other)
		{
		}

		protected static void InvokeUserCode_CmdTouchEnded__GameObject(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_CmdJumpSound()
		{
		}

		protected static void InvokeUserCode_CmdJumpSound(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcJumpSound()
		{
		}

		protected static void InvokeUserCode_RpcJumpSound(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_SendDisconnectMessageTargetRpc__String(string message)
		{
		}

		protected static void InvokeUserCode_SendDisconnectMessageTargetRpc__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_UnsitTargetRpc__Boolean(bool addForce)
		{
		}

		protected static void InvokeUserCode_UnsitTargetRpc__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_CmdSetSittingIn__Seat(Seat seat)
		{
		}

		protected static void InvokeUserCode_CmdSetSittingIn__Seat(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_CmdNotifyRespawn()
		{
		}

		protected static void InvokeUserCode_CmdNotifyRespawn(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_TargetSetPosition__Vector3(Vector3 pos)
		{
		}

		protected static void InvokeUserCode_TargetSetPosition__Vector3(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetRespawnTime__Single(float time)
		{
		}

		protected static void InvokeUserCode_RpcSetRespawnTime__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetMaxHealth__Single(float maxHealth)
		{
		}

		protected static void InvokeUserCode_RpcSetMaxHealth__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetHealth__Single(float health)
		{
		}

		protected static void InvokeUserCode_RpcSetHealth__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_CmdSetHealth__Single(float health)
		{
		}

		protected static void InvokeUserCode_CmdSetHealth__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetWalkSpeed__Single(float walkSpeed)
		{
		}

		protected static void InvokeUserCode_RpcSetWalkSpeed__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetSprintSpeed__Single(float sprintSpeed)
		{
		}

		protected static void InvokeUserCode_RpcSetSprintSpeed__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetMaxStamina__Single(float val)
		{
		}

		protected static void InvokeUserCode_RpcSetMaxStamina__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetStamina__Single(float val)
		{
		}

		protected static void InvokeUserCode_RpcSetStamina__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetStaminaRegen__Single(float val)
		{
		}

		protected static void InvokeUserCode_RpcSetStaminaRegen__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetStaminaEnabled__Boolean(bool val)
		{
		}

		protected static void InvokeUserCode_RpcSetStaminaEnabled__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetJumpPower__Single(float jumpPower)
		{
		}

		protected static void InvokeUserCode_RpcSetJumpPower__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetChatColor__Color(Color col)
		{
		}

		protected static void InvokeUserCode_RpcSetChatColor__Color(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetCanMove__Boolean(bool canMove)
		{
		}

		protected static void InvokeUserCode_RpcSetCanMove__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetAnchored__Boolean(bool anchored)
		{
		}

		protected static void InvokeUserCode_RpcSetAnchored__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_RpcSetColor__BodyPart__Color(BodyPart bodyPart, Color color)
		{
		}

		protected static void InvokeUserCode_RpcSetColor__BodyPart__Color(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
