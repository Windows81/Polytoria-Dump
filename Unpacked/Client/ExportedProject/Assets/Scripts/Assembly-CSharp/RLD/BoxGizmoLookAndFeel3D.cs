using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	[Serializable]
	public class BoxGizmoLookAndFeel3D : Settings
	{
		[SerializeField]
		private Color _boxWireColor;

		[SerializeField]
		private GizmoCap2DLookAndFeel[] _tickLookAndFeel;

		public Color BoxWireColor => default(Color);

		public Color XTickColor => default(Color);

		public Color YTickColor => default(Color);

		public Color ZTickColor => default(Color);

		public Color TickBorderColor => default(Color);

		public Color TickHoveredColor => default(Color);

		public Color TickHoveredBorderColor => default(Color);

		public GizmoCap2DType TickType => default(GizmoCap2DType);

		public float TickQuadWidth => 0f;

		public float TickQuadHeight => 0f;

		public float TickCircleRadius => 0f;

		public List<Enum> GetAllowedTickTypes()
		{
			return null;
		}

		public bool IsTickTypeAllowed(GizmoCap2DType tickType)
		{
			return false;
		}

		public void SetBoxWireColor(Color color)
		{
		}

		public void SetAxisTickColor(int axisIndex, Color color)
		{
		}

		public void SetTickBorderColor(Color color)
		{
		}

		public void SetTickHoveredColor(Color color)
		{
		}

		public void SetTickHoveredBorderColor(Color color)
		{
		}

		public void SetTickType(GizmoCap2DType tickType)
		{
		}

		public void SetTickQuadWidth(float width)
		{
		}

		public void SetTickQuadHeight(float height)
		{
		}

		public void SetTickCircleRadius(float radius)
		{
		}

		public void ConnectTickLookAndFeel(GizmoCap2D tick, int axisIndex, AxisSign axisSign)
		{
		}

		private GizmoCap2DLookAndFeel GetTickLookAndFeel(int axisIndex, AxisSign axisSign)
		{
			return null;
		}
	}
}
