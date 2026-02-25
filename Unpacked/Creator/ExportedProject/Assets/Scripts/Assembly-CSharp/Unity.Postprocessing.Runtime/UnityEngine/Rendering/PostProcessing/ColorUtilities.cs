namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x200007A")]
public static class ColorUtilities
{
	[Token(Token = "0x4000230")]
	private const float logC_cut = 0.011361; //Field offset: 0x0
	[Token(Token = "0x4000231")]
	private const float logC_a = 5.555556; //Field offset: 0x0
	[Token(Token = "0x4000232")]
	private const float logC_b = 0.047996; //Field offset: 0x0
	[Token(Token = "0x4000233")]
	private const float logC_c = 0.244161; //Field offset: 0x0
	[Token(Token = "0x4000234")]
	private const float logC_d = 0.386036; //Field offset: 0x0
	[Token(Token = "0x4000235")]
	private const float logC_e = 5.301883; //Field offset: 0x0
	[Token(Token = "0x4000236")]
	private const float logC_f = 0.092819; //Field offset: 0x0

	[Address(RVA = "0x183E560", Offset = "0x183D760", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60001C4")]
	public static Vector3 CIExyToLMS(float x, float y) { }

	[Address(RVA = "0x183E5F0", Offset = "0x183D7F0", Length = "0x6E")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderLDRPipeline2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x60001C8")]
	public static Vector3 ColorToGain(Vector4 color) { }

	[Address(RVA = "0x183E660", Offset = "0x183D860", Length = "0xB2")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderLDRPipeline2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x60001C7")]
	public static Vector3 ColorToInverseGamma(Vector4 color) { }

	[Address(RVA = "0x183E720", Offset = "0x183D920", Length = "0x66")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderLDRPipeline2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x60001C6")]
	public static Vector3 ColorToLift(Vector4 color) { }

	[Address(RVA = "0x183E790", Offset = "0x183D990", Length = "0x11F")]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderHDRPipeline2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = "RenderLDRPipeline2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x60001C5")]
	public static Vector3 ComputeColorBalance(float temperature, float tint) { }

	[Address(RVA = "0x183E8B0", Offset = "0x183DAB0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028F2B0")]
	[Token(Token = "0x60001CA")]
	public static float LinearToLogC(float x) { }

	[Address(RVA = "0x183E900", Offset = "0x183DB00", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180289930")]
	[Token(Token = "0x60001C9")]
	public static float LogCToLinear(float x) { }

	[Address(RVA = "0x183E960", Offset = "0x183DB60", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60001C3")]
	public static float StandardIlluminantY(float x) { }

	[Address(RVA = "0x183E990", Offset = "0x183DB90", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001CB")]
	public static uint ToHex(Color c) { }

	[Address(RVA = "0x183EA10", Offset = "0x183DC10", Length = "0x77")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001CC")]
	public static Color ToRGBA(uint hex) { }

}

