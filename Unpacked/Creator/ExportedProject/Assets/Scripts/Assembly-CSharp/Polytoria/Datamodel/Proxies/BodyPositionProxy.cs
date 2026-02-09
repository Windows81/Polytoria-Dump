using MoonSharp.Interpreter;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	public class BodyPositionProxy : InstanceProxy
	{
		private readonly BodyPosition bodyPosition;

		public Vector3 TargetPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public float Force
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float AcceptanceDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[MoonSharpHidden]
		public BodyPositionProxy(BodyPosition target)
			: base(null)
		{
		}
	}
}
