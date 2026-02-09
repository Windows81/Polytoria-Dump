using System.Collections.Generic;
using Polytoria.Lua;
using UnityEngine;

namespace Polytoria.Datamodel.Services
{
	public class InputService
	{
		public static LuaEvent KeyDown;

		public static LuaEvent KeyUp;

		public static Vector3 MousePosition => default(Vector3);

		public static bool CursorLocked
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool CursorVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static int ScreenWidth => 0;

		public static int ScreenHeight => 0;

		public static bool AnyKey => false;

		public static bool AnyKeyDown => false;

		public static bool IsInputFocused => false;

		public static Vector3 GetMouseWorldPosition()
		{
			return default(Vector3);
		}

		public static Vector3 GetMouseWorldPoint()
		{
			return default(Vector3);
		}

		public static Vector3 ScreenToWorldPoint(Vector3 pos)
		{
			return default(Vector3);
		}

		public static Vector3 ScreenToViewportPoint(Vector3 pos)
		{
			return default(Vector3);
		}

		public static Vector3 WorldToScreenPoint(Vector3 pos)
		{
			return default(Vector3);
		}

		public static Vector3 WorldToViewportPoint(Vector3 pos)
		{
			return default(Vector3);
		}

		public static Vector3 ViewportToWorldPoint(Vector3 pos)
		{
			return default(Vector3);
		}

		public static Vector3 ViewportToScreenPoint(Vector3 pos)
		{
			return default(Vector3);
		}

		public static RayResult? ScreenPointToRay(Vector3 pos, List<Instance> ignoreList = null)
		{
			return null;
		}

		public static RayResult? ViewportPointToRay(Vector3 pos, List<Instance> ignoreList = null)
		{
			return null;
		}

		public static bool GetButton(string buttonName)
		{
			return false;
		}

		public static bool GetButtonDown(string buttonName)
		{
			return false;
		}

		public static bool GetButtonUp(string buttonName)
		{
			return false;
		}

		public static float GetAxis(string axisName)
		{
			return 0f;
		}

		public static float GetAxisRaw(string axisName)
		{
			return 0f;
		}

		public static bool GetKey(KeyCode key)
		{
			return false;
		}

		public static bool GetKeyDown(KeyCode key)
		{
			return false;
		}

		public static bool GetKeyUp(KeyCode key)
		{
			return false;
		}

		public static bool GetMouseButton(int button)
		{
			return false;
		}

		public static bool GetMouseButtonDown(int button)
		{
			return false;
		}

		public static bool GetMouseButtonUp(int button)
		{
			return false;
		}
	}
}
