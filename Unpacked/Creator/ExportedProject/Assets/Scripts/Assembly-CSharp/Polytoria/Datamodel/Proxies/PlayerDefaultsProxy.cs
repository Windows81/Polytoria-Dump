using MoonSharp.Interpreter;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	public class PlayerDefaultsProxy : InstanceProxy
	{
		private readonly PlayerDefaults playerDefaults;

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

		[MoonSharpHidden]
		public PlayerDefaultsProxy(PlayerDefaults target)
			: base(null)
		{
		}
	}
}
