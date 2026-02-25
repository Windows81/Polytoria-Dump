namespace RLD;

[Token(Token = "0x20000C6")]
public interface IGizmoLineSlider3DController
{

	[Token(Token = "0x60007A9")]
	public float GetRealSizeAlongDirection(Vector3 direction, float zoomFactor) { }

	[Token(Token = "0x60007A8")]
	public void UpdateEpsilons(float zoomFactor) { }

	[Token(Token = "0x60007A6")]
	public void UpdateHandles() { }

	[Token(Token = "0x60007A7")]
	public void UpdateTransforms(float zoomFactor) { }

}

