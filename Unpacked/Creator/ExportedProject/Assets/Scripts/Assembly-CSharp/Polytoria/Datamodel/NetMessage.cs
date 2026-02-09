using System.Collections.Generic;
using MoonSharp.Interpreter;
using UnityEngine;

namespace Polytoria.Datamodel
{
	public class NetMessage
	{
		[MoonSharpHidden]
		public readonly Dictionary<string, string> strings;

		[MoonSharpHidden]
		public readonly Dictionary<string, int> ints;

		[MoonSharpHidden]
		public readonly Dictionary<string, float> numbers;

		[MoonSharpHidden]
		public readonly Dictionary<string, bool> bools;

		[MoonSharpHidden]
		public readonly Dictionary<string, Vector2> vec2s;

		[MoonSharpHidden]
		public readonly Dictionary<string, Vector3> vec3s;

		[MoonSharpHidden]
		public readonly Dictionary<string, Color> colors;

		[MoonSharpHidden]
		public readonly Dictionary<string, Instance> instances;

		public NetMessage()
		{
		}

		public void AddString(string key, string value)
		{
		}

		public void AddInt(string key, int value)
		{
		}

		public void AddBool(string key, bool value)
		{
		}

		public void AddNumber(string key, float value)
		{
		}

		public void AddVector2(string key, Vector2 value)
		{
		}

		public void AddVector3(string key, Vector3 value)
		{
		}

		public void AddColor(string key, Color value)
		{
		}

		public void AddInstance(string key, Instance value)
		{
		}

		public string GetString(string key)
		{
			return null;
		}

		public int GetInt(string key)
		{
			return 0;
		}

		public float GetNumber(string key)
		{
			return 0f;
		}

		public bool GetBool(string key)
		{
			return false;
		}

		public Vector2 GetVector2(string key)
		{
			return default(Vector2);
		}

		public Vector3 GetVector3(string key)
		{
			return default(Vector3);
		}

		public Color GetColor(string key)
		{
			return default(Color);
		}

		public Instance GetInstance(string key)
		{
			return null;
		}

		public static NetMessage New()
		{
			return null;
		}

		public NetMessage(Dictionary<string, string> strings, Dictionary<string, int> ints, Dictionary<string, float> numbers, Dictionary<string, bool> bools, Dictionary<string, Vector2> vec2s, Dictionary<string, Vector3> vec3s, Dictionary<string, Color> colors, Dictionary<string, Instance> instances)
		{
		}
	}
}
