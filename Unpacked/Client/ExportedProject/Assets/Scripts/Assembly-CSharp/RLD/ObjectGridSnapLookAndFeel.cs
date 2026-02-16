using System;
using UnityEngine;

namespace RLD
{
	[Serializable]
	public class ObjectGridSnapLookAndFeel : Settings
	{
		[SerializeField]
		private PivotPointShapeType _pivotShapeType;

		[SerializeField]
		private Color _pivotPointFillColor;

		[SerializeField]
		private Color _pivotPointBorderColor;

		[SerializeField]
		private float _pivotCircleRadius;

		[SerializeField]
		private float _pivotSquareSideLength;

		[SerializeField]
		private bool _drawPivotBorder;

		[SerializeField]
		private Color _boxLineColor;

		[SerializeField]
		private bool _drawBoxes;

		public PivotPointShapeType PivotShapeType
		{
			get
			{
				return default(PivotPointShapeType);
			}
			set
			{
			}
		}

		public Color PivotPointFillColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color PivotPointBorderColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public float PivotCircleRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float PivotSquareSideLength
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool DrawPivotBorder
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Color BoxLineColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public bool DrawBoxes
		{
			get
			{
				return false;
			}
			set
			{
			}
		}
	}
}
