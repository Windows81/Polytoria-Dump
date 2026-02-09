using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RLD
{
	public class Object2ObjectSnapSession
	{
		private enum State
		{
			Inactive = 0,
			Active = 1
		}

		private enum SitSurfaceType
		{
			Invalid = 0,
			Grid = 1,
			Object = 2
		}

		private struct SitSurface
		{
			public SitSurfaceType SurfaceType;

			public Vector3 SitPoint;

			public Plane SitPlane;
		}

		private State _state;

		private List<GameObject> _targetObjects;

		private List<GameObject> _targetParents;

		private AABB _targetAABB;

		private SitSurface _sitSurface;

		private bool _sitBelowSurface;

		private Object2ObjectSnapSettings _sharedSettings;

		private Object2ObjectSnapHotkeys _sharedHotkeys;

		private List<LocalTransformSnapshot> _preTargetTransformSnapshots;

		public Object2ObjectSnapSettings SharedSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Object2ObjectSnapHotkeys SharedHotkeys
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

		public event Object2ObjectSnapSessionBeginHandler SessionBegin
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

		public event Object2ObjectSnapSessionEndHandler SessionEnd
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

		private void SnapTargets()
		{
		}

		private bool CalculateTargetAABB()
		{
			return false;
		}

		private bool IdentifySitSurface()
		{
			return false;
		}
	}
}
