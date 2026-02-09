using System.Runtime.InteropServices;
using Mirror;
using UnityEngine;

namespace Polytoria.Datamodel
{
	public class PlayerDefaults : Instance
	{
		[SyncVar]
		private float maxHealth;

		[SyncVar]
		private float walkSpeed;

		[SyncVar]
		private float sprintSpeed;

		[SyncVar]
		private bool staminaEnabled;

		[SyncVar]
		private float stamina;

		[SyncVar]
		private float maxStamina;

		[SyncVar]
		private float staminaRegen;

		[SyncVar]
		private float jumpPower;

		[SyncVar]
		private float respawnTime;

		[SyncVar]
		private Color chatColor;

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
		[Archivable]
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
		[Archivable]
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
		[Archivable]
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
		[Archivable]
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

		[CreatorProperty]
		[Archivable]
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

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		public void LoadDefaults(Player player)
		{
		}

		[Command(requiresAuthority = false)]
		private void CmdLoadDefaults(Player player)
		{
		}

		public override bool Weaved()
		{
			return false;
		}

		protected void UserCode_CmdLoadDefaults__Player(Player player)
		{
		}

		protected static void InvokeUserCode_CmdLoadDefaults__Player(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		static PlayerDefaults()
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
