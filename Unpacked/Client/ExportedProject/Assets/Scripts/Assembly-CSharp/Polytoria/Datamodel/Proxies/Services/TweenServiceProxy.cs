using MoonSharp.Interpreter;
using Polytoria.Datamodel.Services;
using Polytoria.Lua;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies.Services
{
	public class TweenServiceProxy
	{
		private readonly TweenService tweenService;

		[MoonSharpHidden]
		public TweenServiceProxy(TweenService target)
		{
		}

		public static int TweenPosition(DynamicInstance target, Vector3 destination, float time, LeanTweenType tweenType = LeanTweenType.linear, DynValue callOnComplete = null)
		{
			return 0;
		}

		public static int TweenRotation(DynamicInstance target, Vector3 destination, float time, LeanTweenType tweenType = LeanTweenType.linear, DynValue callOnComplete = null)
		{
			return 0;
		}

		public static int TweenSize(DynamicInstance target, Vector3 destination, float time, LeanTweenType tweenType = LeanTweenType.linear, DynValue callOnComplete = null)
		{
			return 0;
		}

		[LuaCallbackParameter("callback", typeof(float), "value", false)]
		public static int TweenNumber(float start, float end, float time, DynValue callback, LeanTweenType tweenType = LeanTweenType.linear, DynValue callOnComplete = null)
		{
			return 0;
		}

		[LuaCallbackParameter("callback", typeof(Color), "value", false)]
		public static int TweenColor(Color start, Color end, float time, DynValue callback, LeanTweenType tweenType = LeanTweenType.linear, DynValue callOnComplete = null)
		{
			return 0;
		}

		[LuaCallbackParameter("callback", typeof(Vector3), "value", false)]
		public static int TweenVector3(Vector3 start, Vector3 end, float time, DynValue callback, LeanTweenType tweenType = LeanTweenType.linear, DynValue callOnComplete = null)
		{
			return 0;
		}

		[LuaCallbackParameter("callback", typeof(Vector2), "value", false)]
		public static int TweenVector2(Vector2 start, Vector2 end, float time, DynValue callback, LeanTweenType tweenType = LeanTweenType.linear, DynValue callOnComplete = null)
		{
			return 0;
		}

		public static void Cancel(int id, bool callOnComplete = false)
		{
		}

		public static void CancelAll(bool callOnComplete = false)
		{
		}

		public static void Pause(int id)
		{
		}

		public static void Resume(int id)
		{
		}

		public static bool IsPaused(int id)
		{
			return false;
		}
	}
}
