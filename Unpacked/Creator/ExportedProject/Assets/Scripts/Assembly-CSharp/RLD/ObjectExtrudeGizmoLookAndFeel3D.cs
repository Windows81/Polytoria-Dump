using System;
using UnityEngine;

namespace RLD
{
	[Serializable]
	public class ObjectExtrudeGizmoLookAndFeel3D : Settings
	{
		[SerializeField]
		private Color _boxWireColor;

		[SerializeField]
		private GizmoLineSlider3DLookAndFeel[] _sglSlidersLookAndFeel;

		[SerializeField]
		private bool[] _extrudeSliderVis;

		public bool UseZoomFactor => false;

		public Color BoxWireColor => default(Color);

		public GizmoCap3DType SliderCapType => default(GizmoCap3DType);

		public GizmoShadeMode SliderCapShadeMode => default(GizmoShadeMode);

		public GizmoFillMode3D SliderCapFillMode => default(GizmoFillMode3D);

		public Color XColor => default(Color);

		public Color YColor => default(Color);

		public Color ZColor => default(Color);

		public Color HoveredColor => default(Color);

		public float SliderBoxCapWidth => 0f;

		public float SliderBoxCapHeight => 0f;

		public float SliderBoxCapDepth => 0f;

		public float SliderConeCapHeight => 0f;

		public float SliderConeCapBaseRadius => 0f;

		public float SliderPyramidCapWidth => 0f;

		public float SliderPyramidCapHeight => 0f;

		public float SliderPyramidCapDepth => 0f;

		public float SliderTriPrismCapWidth => 0f;

		public float SliderTriPrismCapHeight => 0f;

		public float SliderTriPrismCapDepth => 0f;

		public float SliderSphereCapRadius => 0f;

		public bool IsExtrudeSliderVisible(int axisIndex, AxisSign axisSign)
		{
			return false;
		}

		public void SetExtrudeSliderVisible(int axisIndex, AxisSign axisSign, bool isVisible)
		{
		}

		public void SetBoxWireColor(Color color)
		{
		}

		public void SetSliderCapType(GizmoCap3DType capType)
		{
		}

		public void SetSliderBoxCapWidth(float width)
		{
		}

		public void SetSliderBoxCapHeight(float height)
		{
		}

		public void SetSliderBoxCapDepth(float depth)
		{
		}

		public void SetSliderConeCapHeight(float height)
		{
		}

		public void SetSliderConeCapBaseRadius(float radius)
		{
		}

		public void SetSliderPyramidCapWidth(float width)
		{
		}

		public void SetSliderPyramidCapHeight(float height)
		{
		}

		public void SetSliderPyramidCapDepth(float depth)
		{
		}

		public void SetSliderTriPrismCapWidth(float width)
		{
		}

		public void SetSliderTriPrismCapHeight(float height)
		{
		}

		public void SetSliderTriPrismCapDepth(float depth)
		{
		}

		public void SetSliderSphereCapRadius(float radius)
		{
		}

		public void SetUseZoomFactor(bool useZoomFactor)
		{
		}

		public void SetSliderCapShadeMode(GizmoShadeMode shadeMode)
		{
		}

		public void SetSliderCapFillMode(GizmoFillMode3D fillMode)
		{
		}

		public void SetAxisColor(int axisIndex, Color color)
		{
		}

		public void SetHoveredColor(Color hoveredColor)
		{
		}

		public void ConnectSliderLookAndFeel(GizmoLineSlider3D slider, int axisIndex, AxisSign axisSign)
		{
		}

		private GizmoLineSlider3DLookAndFeel GetSglSliderLookAndFeel(int axisIndex, AxisSign axisSign)
		{
			return null;
		}
	}
}
