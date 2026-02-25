namespace RLD;

[Token(Token = "0x20000F2")]
public interface IGizmoQuad3DBorderController
{

	[Token(Token = "0x60008EB")]
	public void UpdateEpsilons(float zoomFactor) { }

	[Token(Token = "0x60008EA")]
	public void UpdateHandles() { }

	[Token(Token = "0x60008EC")]
	public void UpdateTransforms(float zoomFactor) { }

}

