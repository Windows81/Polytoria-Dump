using System;
using UnityEngine;

namespace RLD
{
	[Serializable]
	public class ObjectGrabLookAndFeel : Settings
	{
		[SerializeField]
		private bool _drawAnchorLines;

		[SerializeField]
		private Color _anchorLineColor;

		[SerializeField]
		private bool _drawObjectPosTicks;

		[SerializeField]
		private bool _drawAnchorPosTick;

		[SerializeField]
		private Color _objectPosTickColor;

		[SerializeField]
		private Color _anchorPosTickColor;

		[SerializeField]
		private float _objectPosTickSize;

		[SerializeField]
		private float _anchorPosTickSize;

		[SerializeField]
		private bool _drawObjectBoxes;

		[SerializeField]
		private Color _objectBoxWireColor;

		public bool DrawAnchorLines
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Color AnchorLineColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public bool DrawObjectPosTicks
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool DrawAnchorPosTick
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Color ObjectPosTickColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public float ObjectPosTickSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Color AnchorPosTickColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public float AnchorPosTickSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool DrawObjectBoxes
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Color ObjectBoxWireColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}
	}
}
