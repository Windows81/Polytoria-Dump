using MoonSharp.Interpreter;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	public class DynamicInstanceProxy : InstanceProxy
	{
		private readonly DynamicInstance dynamicInstance;

		public Vector3 Position
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 Rotation
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 LocalPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 LocalRotation
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 Size
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 LocalSize
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Quaternion Quaternion
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		public Quaternion LocalQuaternion
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		public Vector3 Forward => default(Vector3);

		public Vector3 Up => default(Vector3);

		public Vector3 Right => default(Vector3);

		[MoonSharpHidden]
		public DynamicInstanceProxy(DynamicInstance target)
			: base(null)
		{
		}

		public void LookAt(Vector3 lookTarget, Vector3 worldUp)
		{
		}

		public void LookAt(Vector3 lookTarget)
		{
		}

		public void LookAt(DynamicInstance dynamicInstance)
		{
		}

		public void Translate(Vector3 translation)
		{
		}

		public void RotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		public void Rotate(Vector3 eulerAngles)
		{
		}

		public Vector3 InverseTransformPoint(Vector3 point)
		{
			return default(Vector3);
		}

		public Vector3 TransformPoint(Vector3 point)
		{
			return default(Vector3);
		}

		public Vector3 InverseTransformDirection(Vector3 direction)
		{
			return default(Vector3);
		}

		public Vector3 TransformDirection(Vector3 direction)
		{
			return default(Vector3);
		}

		public Vector3 InverseTransformVector(Vector3 vector)
		{
			return default(Vector3);
		}

		public Vector3 TransformVector(Vector3 vector)
		{
			return default(Vector3);
		}
	}
}
