namespace GLTFast;

[Token(Token = "0x200004E")]
public static class RenderPipelineUtils
{
	[Token(Token = "0x4000195")]
	private static RenderPipeline s_RenderPipeline; //Field offset: 0x0

	[Token(Token = "0x1700002A")]
	public static RenderPipeline RenderPipeline
	{
		[Address(RVA = "0x1078E90", Offset = "0x1078090", Length = "0x4E")]
		[CalledBy(Type = typeof(MaterialGenerator), Member = "GetDefaultMaterialGenerator", ReturnType = typeof(IMaterialGenerator))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000147")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000148")]
	private static RenderPipeline DetectRenderPipeline() { }

	[Address(RVA = "0x1078E90", Offset = "0x1078090", Length = "0x4E")]
	[CalledBy(Type = typeof(MaterialGenerator), Member = "GetDefaultMaterialGenerator", ReturnType = typeof(IMaterialGenerator))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000147")]
	public static RenderPipeline get_RenderPipeline() { }

}

