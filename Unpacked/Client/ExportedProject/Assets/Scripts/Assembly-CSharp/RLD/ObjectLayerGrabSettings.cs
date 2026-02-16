using System;
using UnityEngine;

namespace RLD
{
	[Serializable]
	public class ObjectLayerGrabSettings
	{
		[SerializeField]
		private int _layer;

		[SerializeField]
		private bool _isActive;

		[SerializeField]
		private bool _alignAxis;

		[SerializeField]
		private TransformAxis _alignmentAxis;

		[SerializeField]
		private float _defaultOffsetFromSurface;

		public int Layer => 0;

		public bool IsActive
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool AlignAxis
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public TransformAxis AlignmentAxis
		{
			get
			{
				return default(TransformAxis);
			}
			set
			{
			}
		}

		public float DefaultOffsetFromSurface
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public ObjectLayerGrabSettings(int layer)
		{
		}
	}
}
