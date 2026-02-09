using MoonSharp.Interpreter;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	public class Vector3ValueProxy : ValueBaseProxy
	{
		private readonly Vector3Value vector3Value;

		public Vector3 Value
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		[MoonSharpHidden]
		public Vector3ValueProxy(Vector3Value target)
			: base(null)
		{
		}
	}
}
