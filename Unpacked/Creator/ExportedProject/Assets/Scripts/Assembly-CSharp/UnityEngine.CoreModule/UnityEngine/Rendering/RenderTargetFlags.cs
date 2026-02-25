namespace UnityEngine.Rendering;

[Flags]
[Token(Token = "0x20002BB")]
public enum RenderTargetFlags
{
	None = 0,
	ReadOnlyDepth = 1,
	ReadOnlyStencil = 2,
	ReadOnlyDepthStencil = 3,
}

