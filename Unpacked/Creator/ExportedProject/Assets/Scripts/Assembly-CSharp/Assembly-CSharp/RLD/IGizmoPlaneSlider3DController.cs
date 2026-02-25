namespace RLD;

[Token(Token = "0x20000D4")]
public interface IGizmoPlaneSlider3DController
{

	[Token(Token = "0x600086B")]
	public void UpdateEpsilons(float zoomFactor) { }

	[Token(Token = "0x6000869")]
	public void UpdateHandles() { }

	[Token(Token = "0x600086A")]
	public void UpdateTransforms(float zoomFactor) { }

}

