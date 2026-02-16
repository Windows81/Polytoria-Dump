using MoonSharp.Interpreter;
using Polytoria.Lua;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	public class UIFieldProxy : InstanceProxy
	{
		private readonly UIField uiField;

		public LuaEvent MouseUp => null;

		public LuaEvent MouseDown => null;

		public Vector2 PositionOffset
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 PositionRelative
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public float Rotation
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Vector2 SizeOffset
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 SizeRelative
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 PivotPoint
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public bool Visible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ClipDescendants
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[MoonSharpHidden]
		public UIFieldProxy(UIField target)
			: base(null)
		{
		}
	}
}
