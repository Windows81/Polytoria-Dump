using System;
using UnityEngine;

namespace RLD
{
	[Serializable]
	public class ObjectSelectionLookAndFeel : Settings
	{
		[SerializeField]
		private bool _drawHighlight;

		[SerializeField]
		private SelectionBoxBorderStyle _selectionBoxBorderStyle;

		[SerializeField]
		private float _wireCornerLinePercentage;

		[SerializeField]
		private SelectionBoxRenderMode _selectionBoxRenderMode;

		[SerializeField]
		private Color _selectionBoxBorderColor;

		[SerializeField]
		private float _selectionBoxInflateAmount;

		[SerializeField]
		private Color _selectionRectBorderColor;

		[SerializeField]
		private Color _selectionRectFillColor;

		public bool DrawHighlight
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public SelectionBoxBorderStyle SelBoxBorderStyle
		{
			get
			{
				return default(SelectionBoxBorderStyle);
			}
			set
			{
			}
		}

		public float WireCornerLinePercentage
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public SelectionBoxRenderMode SelBoxRenderMode
		{
			get
			{
				return default(SelectionBoxRenderMode);
			}
			set
			{
			}
		}

		public Color SelectionBoxBorderColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public float SelectionBoxInflateAmount
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Color SelectionRectBorderColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color SelectionRectFillColor
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
