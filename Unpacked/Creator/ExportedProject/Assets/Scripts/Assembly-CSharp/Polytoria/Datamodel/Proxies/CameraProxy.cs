using MoonSharp.Interpreter;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	public class CameraProxy : DynamicInstanceProxy
	{
		private readonly Camera camera;

		public CameraMode Mode
		{
			get
			{
				return default(CameraMode);
			}
			set
			{
			}
		}

		public float FOV
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool Orthographic
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float OrthographicSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Distance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float MinDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float MaxDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float HorizontalSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float VerticalSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float ScrollSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool ClipThroughWalls
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float FlySpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float FastFlySpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float FreeLookSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float LerpSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool FollowLerp
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float SensitivityMultiplier
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Vector3 PositionOffset
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 RotationOffset
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public bool IsFirstPerson => false;

		public DynamicInstance FollowTarget
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[MoonSharpHidden]
		public CameraProxy(Camera target)
			: base(null)
		{
		}
	}
}
