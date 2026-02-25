namespace RLD;

[Token(Token = "0x20000B7")]
public interface IGizmoPlaneSlider2DController
{

	[Token(Token = "0x60006FE")]
	public Vector2 GetRealExtentPoint(Shape2DExtentPoint extentPt) { }

	[Token(Token = "0x60006FD")]
	public void UpdateEpsilons() { }

	[Token(Token = "0x60006FB")]
	public void UpdateHandles() { }

	[Token(Token = "0x60006FC")]
	public void UpdateTransforms() { }

}

