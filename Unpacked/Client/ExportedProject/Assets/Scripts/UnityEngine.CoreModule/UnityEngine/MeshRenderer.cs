namespace UnityEngine;

[NativeHeader("Runtime/Graphics/Mesh/MeshRenderer.h")]
[Token(Token = "0x20000DC")]
public class MeshRenderer : Renderer
{

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004CD")]
	public MeshRenderer() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	[Token(Token = "0x60004CC")]
	private void DontStripMeshRenderer() { }

}

