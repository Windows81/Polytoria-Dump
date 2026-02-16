using System;
using UnityEngine;

namespace Polytoria.Lua
{
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public class LuaCallbackParameter : PropertyAttribute
	{
		public LuaCallbackParameter(string callback, Type type, string name, bool nullable = false)
		{
		}
	}
}
