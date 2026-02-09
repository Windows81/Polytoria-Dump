using System;
using UnityEngine;

namespace RLD
{
	[Serializable]
	public class PrefabPreviewLookAndFeel : Settings
	{
		private static readonly float _minBkAlpha;

		[SerializeField]
		private Color _bkColor;

		[SerializeField]
		private int _previewWidth;

		[SerializeField]
		private int _previewHeight;

		[SerializeField]
		private float _lightIntensity;

		public Color BkColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public int PreviewWidth
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int PreviewHeight
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float LightIntensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}
	}
}
