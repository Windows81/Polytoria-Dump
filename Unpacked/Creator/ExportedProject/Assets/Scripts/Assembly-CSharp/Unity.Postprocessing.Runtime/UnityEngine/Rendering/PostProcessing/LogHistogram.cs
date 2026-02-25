namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000080")]
internal sealed class LogHistogram
{
	[Token(Token = "0x400024C")]
	public const int rangeMin = -9; //Field offset: 0x0
	[Token(Token = "0x400024D")]
	public const int rangeMax = 9; //Field offset: 0x0
	[Token(Token = "0x400024E")]
	private const int k_Bins = 128; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400024F")]
	private ComputeBuffer <data>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000032")]
	public private ComputeBuffer data
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001E7")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001E8")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001EC")]
	public LogHistogram() { }

	[Address(RVA = "0x1840540", Offset = "0x183F740", Length = "0x47A")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext), typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CommandBuffer), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802891B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ComputeShader), Member = "GetKernelThreadGroupSizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UInt32&), typeof(UInt32&), typeof(UInt32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeBufferParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(string), typeof(ComputeBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeShader), Member = "FindKernel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(string), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CommandBuffer), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(string), typeof(Vector4)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001E9")]
	public void Generate(PostProcessRenderContext context) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001E7")]
	public ComputeBuffer get_data() { }

	[Address(RVA = "0x18409C0", Offset = "0x183FBC0", Length = "0x45")]
	[CalledBy(Type = typeof(AutoExposureRenderer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001EA")]
	public Vector4 GetHistogramScaleOffsetRes(PostProcessRenderContext context) { }

	[Address(RVA = "0x1840A10", Offset = "0x183FC10", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001EB")]
	public void Release() { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001E8")]
	private void set_data(ComputeBuffer value) { }

}

