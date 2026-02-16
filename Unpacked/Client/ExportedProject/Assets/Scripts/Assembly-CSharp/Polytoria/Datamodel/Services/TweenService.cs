using MoonSharp.Interpreter;
using UnityEngine;

namespace Polytoria.Datamodel.Services
{
	public class TweenService
	{
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

		public static int TweenNumber(float start, float end, float time, DynValue callback, LeanTweenType tweenType = LeanTweenType.linear, DynValue callOnComplete = null)
		{
			return 0;
		}

		public static int TweenColor(Color start, Color end, float time, DynValue callback, LeanTweenType tweenType = LeanTweenType.linear, DynValue callOnComplete = null)
		{
			return 0;
		}

		public static int TweenVector3(Vector3 start, Vector3 end, float time, DynValue callback, LeanTweenType tweenType = LeanTweenType.linear, DynValue callOnComplete = null)
		{
			return 0;
		}

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
