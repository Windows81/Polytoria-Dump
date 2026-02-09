using System;
using UnityEngine;

namespace Polytoria.Lua
{
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
	public class LuaEventParameter : PropertyAttribute
	{
		public LuaEventParameter(Type type, string name, bool nullable = false)
		{
		}
	}
}
