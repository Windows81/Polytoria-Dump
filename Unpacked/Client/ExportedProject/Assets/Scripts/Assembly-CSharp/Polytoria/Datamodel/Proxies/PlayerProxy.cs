using MoonSharp.Interpreter;
using Polytoria.Lua;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	public class PlayerProxy : InstanceProxy
	{
		private readonly Player player;

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

		public bool IsInputFocused => false;

		public Seat SittingIn => null;

		public Vector3 Forward => default(Vector3);

		public Vector3 Right => default(Vector3);

		public bool IsAdmin => false;

		public bool IsCreator => false;

		public int UserID => 0;

		[LuaEventParameter(typeof(string), "message", false)]
		[LuaEventParameter(typeof(PlayerChatEvent), "event", false)]
		public LuaEvent Chatted => null;

		public LuaEvent Died => null;

		public LuaEvent Respawned => null;

		[MoonSharpHidden]
		public PlayerProxy(Player target)
			: base(null)
		{
		}

		[LuaCallbackParameter("callback", typeof(bool), "success", false)]
		[LuaCallbackParameter("callback", typeof(bool), "owned", false)]
		public void OwnsItem(int assetId, DynValue callback)
		{
		}

		public void Kick(string reason = "You have been kicked from the server.")
		{
		}

		public void Sit(Seat seat)
		{
		}

		public void Unsit(bool addForce = true)
		{
		}

		public void Respawn()
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

		public void LookAt(Vector3 lookTarget, Vector3 worldUp)
		{
		}

		public void LookAt(Vector3 lookTarget)
		{
		}

		public void LookAt(DynamicInstance instance)
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
	}
}
