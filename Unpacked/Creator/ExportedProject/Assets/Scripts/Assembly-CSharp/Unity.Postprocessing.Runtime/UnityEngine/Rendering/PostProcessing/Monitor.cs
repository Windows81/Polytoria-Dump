namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x200004C")]
public abstract class Monitor
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400014B")]
	private RenderTexture <output>k__BackingField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400014C")]
	internal bool requested; //Field offset: 0x18

	[Token(Token = "0x17000003")]
	public RenderTexture output
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A8")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A9")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B1")]
	protected Monitor() { }

	[Address(RVA = "0x18410E0", Offset = "0x18402E0", Length = "0x194")]
	[CalledBy(Type = typeof(HistogramMonitor), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightMeterMonitor), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VectorscopeMonitor), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WaveformMonitor), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RenderTexture), Member = "IsCreated", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Texture), Member = "set_wrapMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureWrapMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "set_filterMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FilterMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "set_anisoLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RenderTexture), Member = "set_useMipMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60000AD")]
	protected void CheckOutput(int width, int height) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A8")]
	public RenderTexture get_output() { }

	[Address(RVA = "0x1841280", Offset = "0x1840480", Length = "0xF9")]
	[CalledBy(Type = typeof(PostProcessDebugLayer), Member = "RenderMonitors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext), typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "ShouldGenerateLogHistogram", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000AA")]
	public bool IsRequestedAndSupported(PostProcessRenderContext context) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000AC")]
	internal override bool NeedsHalfRes() { }

	[Address(RVA = "0x1841380", Offset = "0x1840580", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000AF")]
	internal override void OnDisable() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000AE")]
	internal override void OnEnable() { }

	[Token(Token = "0x60000B0")]
	internal abstract void Render(PostProcessRenderContext context) { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A9")]
	protected void set_output(RenderTexture value) { }

	[Token(Token = "0x60000AB")]
	internal abstract bool ShaderResourcesAvailable(PostProcessRenderContext context) { }

}

