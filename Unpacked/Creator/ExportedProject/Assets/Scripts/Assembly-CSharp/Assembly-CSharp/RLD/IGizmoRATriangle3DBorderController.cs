namespace RLD;

[Token(Token = "0x20000F7")]
public interface IGizmoRATriangle3DBorderController
{

	[Token(Token = "0x6000901")]
	public void UpdateEpsilons(float zoomFactor) { }

	[Token(Token = "0x6000900")]
	public void UpdateHandles() { }

	[Token(Token = "0x6000902")]
	public void UpdateTransforms(float zoomFactor) { }

}

