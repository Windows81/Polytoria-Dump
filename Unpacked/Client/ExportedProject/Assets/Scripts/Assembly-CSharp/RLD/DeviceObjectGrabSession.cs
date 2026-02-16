using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RLD
{
	public class DeviceObjectGrabSession
	{
		private enum State
		{
			Inactive = 0,
			ActiveSnapToSurface = 1,
			ActiveRotate = 2,
			ActiveRotateAroundAnchor = 3,
			ActiveScale = 4,
			ActiveOffsetFromSurface = 5,
			ActiveAnchorAdjust = 6,
			ActiveOffsetFromAnchor = 7
		}

		public enum GrabSurfaceType
		{
			Invalid = 0,
			Mesh = 1,
			SphericalMesh = 2,
			UnityTerrain = 3,
			TerrainMesh = 4,
			Grid = 5
		}

		private struct GrabSurfaceInfo
		{
			public GrabSurfaceType SurfaceType;

			public Vector3 AnchorPoint;

			public Vector3 AnchorNormal;

			public Plane AnchorPlane;

			public SceneRaycastHit SceneRaycastHit;
		}

		private class GrabTarget
		{
			private GameObject _gameObject;

			private Transform _transform;

			public Vector3 AnchorVector;

			public Vector3 WorldScaleSnapshot;

			public Vector3 AnchorVectorSnapshot;

			public Plane SittingPlane;

			public Vector3 SittingPoint;

			public float OffsetFromSurface;

			public GameObject GameObject => null;

			public Transform Transform => null;

			public GrabTarget(GameObject parentObject)
			{
			}
		}

		private State _state;

		private ObjectGrabSettings _sharedSettings;

		private ObjectGrabHotkeys _sharedHotkeys;

		private ObjectGrabLookAndFeel _sharedLookAndFeel;

		private List<GameObject> _targetParents;

		private List<GrabTarget> _grabTargets;

		private GrabSurfaceInfo _grabSurfaceInfo;

		private int _deltaCaptureId;

		private TransformAxis[] _possibleAlignmentAxes;

		private List<LocalTransformSnapshot> _preTargetTransformSnapshots;

		public ObjectGrabSettings SharedSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ObjectGrabHotkeys SharedHotkeys
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ObjectGrabLookAndFeel SharedLookAndFeel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsActive => false;

		public event ObjectGrabSessionBeginHandler SessionBegin
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event ObjectGrabSessionEndHandler SessionEnd
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Render(Camera renderCamera)
		{
		}

		public void Update(IEnumerable<GameObject> targetObjects)
		{
		}

		public void End()
		{
		}

		private bool Begin(IEnumerable<GameObject> targetObjects)
		{
			return false;
		}

		private void SnapTargetsToSurface()
		{
		}

		private void RotateTargets()
		{
		}

		private void RotateTargetsAroundAnchor()
		{
		}

		private void ScaleTargets()
		{
		}

		private void OffsetTargetsFromSurface()
		{
		}

		private void OffsetTargetsFromAnchor()
		{
		}

		private bool IdentifyGrabTargets(IEnumerable<GameObject> targetObjects)
		{
			return false;
		}

		private void CalculateGrabTargetsAnchorVectors()
		{
		}

		private void StoreGrabTargetsWorldScaleSnapshots()
		{
		}

		private void StoreGrabTargetsAnchorVectorSnapshots()
		{
		}

		private bool IdentifyGrabSurface()
		{
			return false;
		}

		private void SwitchToNextAlignmentAxis()
		{
		}

		private ObjectBounds.QueryConfig GetObjectBoundsQConfig()
		{
			return default(ObjectBounds.QueryConfig);
		}
	}
}
