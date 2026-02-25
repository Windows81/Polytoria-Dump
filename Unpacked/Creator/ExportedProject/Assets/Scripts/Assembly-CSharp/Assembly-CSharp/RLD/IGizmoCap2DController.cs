namespace RLD;

[Token(Token = "0x200001B")]
public interface IGizmoCap2DController
{

	[Token(Token = "0x60000B1")]
	public void CapSlider2D(Vector2 sliderDirection, Vector2 sliderEndPt) { }

	[Token(Token = "0x60000B2")]
	public void CapSlider2DInvert(Vector2 sliderDirection, Vector2 sliderEndPt) { }

	[Token(Token = "0x60000B3")]
	public float GetSliderAlignedRealLength() { }

	[Token(Token = "0x60000AF")]
	public void UpdateHandles() { }

	[Token(Token = "0x60000B0")]
	public void UpdateTransforms() { }

}

