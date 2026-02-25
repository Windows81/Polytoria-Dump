namespace RLD;

[Token(Token = "0x2000028")]
public interface IGizmoCap3DController
{

	[Token(Token = "0x6000145")]
	public void CapSlider3D(Vector3 sliderDirection, Vector3 sliderEndPt, float zoomFactor) { }

	[Token(Token = "0x6000146")]
	public void CapSlider3DInvert(Vector3 sliderDirection, Vector3 sliderEndPt, float zoomFactor) { }

	[Token(Token = "0x6000147")]
	public float GetSliderAlignedRealLength(float zoomFactor) { }

	[Token(Token = "0x6000143")]
	public void UpdateHandles() { }

	[Token(Token = "0x6000144")]
	public void UpdateTransforms(float zoomFactor) { }

}

