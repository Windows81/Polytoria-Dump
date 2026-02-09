using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RLD
{
	public class ObjectGridSnapSession
	{
		private enum State
		{
			Inactive = 0,
			SelectPivot = 1,
			Snap = 2
		}

		private List<GameObject> _targetParents;

		private List<GameObject> _targetObjects;

		private List<LocalTransformSnapshot> _preTargetTransformSnapshots;

		private Vector3 _snapPivotPoint;

		private State _state;

		private ObjectGridSnapHotkeys _sharedHotkeys;

		private ObjectGridSnapLookAndFeel _sharedLookAndFeel;

		public bool IsActive => false;

		public ObjectGridSnapLookAndFeel SharedLookAndFeel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ObjectGridSnapHotkeys SharedHotkeys
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public event ObjectGridSnapSessionBeginHandler SessionBegin
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

		public event ObjectGridSnapSessionEndHandler SessionEnd
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

		private bool IdentifyTargetParents(IEnumerable<GameObject> targetObjects)
		{
			return false;
		}

		private bool IdentifyTargetObjects(IEnumerable<GameObject> targetObjects)
		{
			return false;
		}

		private void SelectPivot()
		{
		}

		private ObjectBounds.QueryConfig GetObjectBoundsQConfig()
		{
			return default(ObjectBounds.QueryConfig);
		}

		private void Snap()
		{
		}
	}
}
