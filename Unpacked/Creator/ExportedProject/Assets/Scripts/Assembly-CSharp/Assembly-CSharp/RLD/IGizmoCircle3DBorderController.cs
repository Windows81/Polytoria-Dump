namespace RLD;

[Token(Token = "0x20000EB")]
public interface IGizmoCircle3DBorderController
{

	[Token(Token = "0x60008CD")]
	public void UpdateEpsilons(float zoomFactor) { }

	[Token(Token = "0x60008CC")]
	public void UpdateHandles() { }

	[Token(Token = "0x60008CE")]
	public void UpdateTransforms(float zoomFactor) { }

}

