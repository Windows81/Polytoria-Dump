using System.Collections.Generic;
using MoonSharp.Interpreter;
using UnityEngine;

namespace Polytoria.Datamodel
{
	public class Camera : DynamicInstance
	{
		public static float sensitivityModifier;

		public static Camera Instance;

		public static LayerMask clipIgnoreLayers;

		public static List<MeshRenderer> disableOnFirstPerson;

		private UnityEngine.Camera cam;

		private Transform target;

		private float distance;

		private float distanceLerp;

		private float xSpeed;

		private float ySpeed;

		private float yMinLimit;

		private float yMaxLimit;

		private float distanceMax;

		private float minDist;

		private float maxDist;

		private bool clipThroughWalls;

		private float scrollSensitivity;

		private float flySpeed;

		private float fastFlySpeed;

		private float freeLookSensitivity;

		private float x;

		private float y;

		private bool init;

		private bool wasLocked;

		private bool looking;

		private bool locked;

		private bool wasFirstPerson;

		private int lastDisableFPCount;

		private DynamicInstance followTargetInstance;

		private Transform followTargetTransform;

		private bool DoLerp => false;

		[CreatorProperty]
		[Archivable]
		public CameraMode Mode { get; set; }

		[CreatorProperty]
		[Archivable]
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

		[CreatorProperty]
		[Archivable]
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

		[CreatorProperty]
		[Archivable]
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

		[CreatorProperty]
		[Archivable]
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

		[CreatorProperty]
		[Archivable]
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

		[CreatorProperty]
		[Archivable]
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

		public float LerpSpeed { get; set; }

		public bool FollowLerp { get; set; }

		[CreatorProperty]
		[Archivable]
		public bool CanLock { get; set; }

		public bool CtrlLocked { get; set; }

		public float SensitivityMultiplier { get; set; }

		[CreatorProperty]
		[Archivable]
		public Vector3 PositionOffset { get; set; }

		[CreatorProperty]
		[Archivable]
		public Vector3 RotationOffset { get; set; }

		public bool IsFirstPerson => false;

		protected override bool DoTransformSync => false;

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

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		[MoonSharpHidden]
		private void SetFollowTarget(DynamicInstance instance)
		{
		}

		private void LateUpdate()
		{
		}

		private void UpdateFollow()
		{
		}

		private void UpdateFollowTarget()
		{
		}

		private void UpdateFollowMode(Transform followTarget)
		{
		}

		private void HandleLockInput()
		{
		}

		private float HandleScrollInput()
		{
			return 0f;
		}

		private void HandleFirstPersonRendering()
		{
		}

		private bool ShouldProcessCameraInput()
		{
			return false;
		}

		private void HandleCursorLocking()
		{
		}

		private void HandleCameraRotation()
		{
		}

		private void HandleScrollZoom(float scroll)
		{
		}

		private void ApplyCameraTransform(Transform followTarget)
		{
		}

		private void ClampDistance()
		{
		}

		private void CalculateWallClipping(Transform followTarget)
		{
		}

		private void UpdateFree()
		{
		}

		private void HandleFreeMovement()
		{
		}

		private void HandleFreeLook()
		{
		}

		private void HandleFreeZoom()
		{
		}

		private void HandleFreeLookToggle()
		{
		}

		private void StartLooking()
		{
		}

		private void StopLooking()
		{
		}

		private void OnDisable()
		{
		}

		private static float ClampAngle(float angle, float min, float max)
		{
			return 0f;
		}

		[MoonSharpHidden]
		public void SetTarget(Transform target)
		{
		}

		public override bool Weaved()
		{
			return false;
		}
	}
}
