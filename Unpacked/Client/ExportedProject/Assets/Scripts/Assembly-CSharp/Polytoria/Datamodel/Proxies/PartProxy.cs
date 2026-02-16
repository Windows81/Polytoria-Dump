using MoonSharp.Interpreter;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	public class PartProxy : DynamicInstanceProxy
	{
		private readonly Part part;

		public Color Color
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public bool Anchored
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool CanCollide
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsSpawn
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public PartShape Shape
		{
			get
			{
				return default(PartShape);
			}
			set
			{
			}
		}

		public PartMaterial Material
		{
			get
			{
				return default(PartMaterial);
			}
			set
			{
			}
		}

		public Vector3 Velocity
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public float Drag
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float AngularDrag
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Mass
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Vector3 AngularVelocity
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public bool UseGravity
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float Bounciness
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Friction
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool CastShadows
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[MoonSharpHidden]
		public PartProxy(Part target)
			: base(null)
		{
		}

		public void MovePosition(Vector3 pos)
		{
		}

		public void MoveRotation(Vector3 rot)
		{
		}

		public void AddForce(Vector3 force, ForceMode mode = ForceMode.Force)
		{
		}

		public void AddTorque(Vector3 torque, ForceMode mode = ForceMode.Force)
		{
		}

		public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode mode = ForceMode.Force)
		{
		}

		public void AddRelativeForce(Vector3 force, ForceMode mode = ForceMode.Force)
		{
		}

		public void AddRelativeTorque(Vector3 torque, ForceMode mode = ForceMode.Force)
		{
		}
	}
}
