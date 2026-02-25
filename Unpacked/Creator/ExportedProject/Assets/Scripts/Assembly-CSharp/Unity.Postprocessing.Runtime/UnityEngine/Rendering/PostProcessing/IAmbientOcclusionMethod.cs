namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000010")]
internal interface IAmbientOcclusionMethod
{

	[Token(Token = "0x6000011")]
	public void CompositeAmbientOnly(PostProcessRenderContext context) { }

	[Token(Token = "0x600000E")]
	public DepthTextureMode GetCameraFlags() { }

	[Token(Token = "0x6000012")]
	public void Release() { }

	[Token(Token = "0x600000F")]
	public void RenderAfterOpaque(PostProcessRenderContext context) { }

	[Token(Token = "0x6000010")]
	public void RenderAmbientOnly(PostProcessRenderContext context) { }

}

