using System;
using UnityEngine;

namespace RLD
{
	[Serializable]
	public class ObjectGrabSettings : Settings
	{
		[SerializeField]
		private bool _alignAxis;

		[SerializeField]
		private TransformAxis _alignmentAxis;

		[SerializeField]
		private float _rotationSensitivity;

		[SerializeField]
		private float _scaleSensitivity;

		[SerializeField]
		private float _offsetFromSurfaceSensitivity;

		[SerializeField]
		private float _offsetFromAnchorSensitivity;

		[SerializeField]
		private ObjectGrabSurfaceFlags _surfaceFlags;

		[SerializeField]
		private float _defaultOffsetFromSurface;

		[SerializeField]
		private int _surfaceLayers;

		[SerializeField]
		private ObjectLayerGrabSettings[] _layerGrabSettings;

		[SerializeField]
		private int _sphericalMeshLayers;

		[SerializeField]
		private int _terrainMeshLayers;

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

		public float RotationSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float ScaleSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float OffsetFromSurfaceSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float OffsetFromAnchorSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public ObjectGrabSurfaceFlags SurfaceFlags
		{
			get
			{
				return default(ObjectGrabSurfaceFlags);
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

		public int SurfaceLayers
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int SphericalMeshLayers
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int TerrainMeshLayers
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public ObjectLayerGrabSettings GetLayerGrabSettings(int layer)
		{
			return null;
		}
	}
}
