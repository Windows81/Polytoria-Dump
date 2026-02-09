using MoonSharp.Interpreter;
using Polytoria.Lua;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	public class NPCProxy : DynamicInstanceProxy
	{
		private readonly NPC npc;

		public LuaEvent Died => null;

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

		public float NavDestinationDistance => 0f;

		public bool NavDestinationReached => false;

		public bool NavDestinationValid => false;

		public bool Grounded => false;

		[MoonSharpHidden]
		public NPCProxy(NPC target)
			: base(null)
		{
		}

		public void Respawn()
		{
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

		public void SetNavDestination(Vector3 destination)
		{
		}

		public void EquipTool(Tool tool)
		{
		}

		public void DropTool()
		{
		}
	}
}
