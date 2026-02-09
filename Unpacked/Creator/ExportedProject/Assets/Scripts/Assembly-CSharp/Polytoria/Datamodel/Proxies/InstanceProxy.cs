using MoonSharp.Interpreter;
using Polytoria.Lua;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	public class InstanceProxy
	{
		private readonly Instance target;

		public Instance this[string name] => null;

		public Instance this[int index] => null;

		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string ClassName => null;

		public DynValue Shared => null;

		public bool ClientSpawned => false;

		public Instance Parent
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[LuaEventParameter(typeof(Instance), "child", false)]
		public LuaEvent ChildRemoved => null;

		[LuaEventParameter(typeof(Instance), "child", false)]
		public LuaEvent ChildAdded => null;

		[LuaEventParameter(typeof(Instance), "other", false)]
		public LuaEvent Touched => null;

		[LuaEventParameter(typeof(Instance), "other", false)]
		public LuaEvent TouchEnded => null;

		[LuaEventParameter(typeof(Player), "player", false)]
		public LuaEvent Clicked => null;

		public LuaEvent MouseEnter => null;

		public LuaEvent MouseExit => null;

		[MoonSharpHidden]
		public InstanceProxy(Instance target)
		{
		}

		public Instance GetParent()
		{
			return null;
		}

		public void SetParent(Instance parent)
		{
		}

		public Instance FindChild(string name)
		{
			return null;
		}

		public Instance[] GetChildren()
		{
			return null;
		}

		public Instance[] GetChildrenOfClass(string className)
		{
			return null;
		}

		public Instance FindChildByClass(string className)
		{
			return null;
		}

		public bool IsA(string className)
		{
			return false;
		}

		public bool IsDescendantOf(Instance parent)
		{
			return false;
		}

		public void Destroy(float time = 0f)
		{
		}

		public void Delete(float time = 0f)
		{
		}

		public static Instance New(string className, Instance parent = null)
		{
			return null;
		}

		public Instance Clone()
		{
			return null;
		}

		public Bounds GetBounds()
		{
			return default(Bounds);
		}
	}
}
