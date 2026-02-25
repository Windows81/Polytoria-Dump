namespace UnityEngine;

[Token(Token = "0x20000E8")]
public struct RenderTextureDescriptor
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000312")]
	private int <width>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000313")]
	private int <height>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000314")]
	private int <msaaSamples>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000315")]
	private int <volumeDepth>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000316")]
	private int <mipCount>k__BackingField; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000317")]
	private GraphicsFormat _graphicsFormat; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000318")]
	private GraphicsFormat <stencilFormat>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000319")]
	private GraphicsFormat <depthStencilFormat>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400031A")]
	private TextureDimension <dimension>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400031B")]
	private ShadowSamplingMode <shadowSamplingMode>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400031C")]
	private VRTextureUsage <vrUsage>k__BackingField; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400031D")]
	private RenderTextureCreationFlags _flags; //Field offset: 0x2C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400031E")]
	private RenderTextureMemoryless <memoryless>k__BackingField; //Field offset: 0x30

	[Token(Token = "0x17000120")]
	public bool autoGenerateMips
	{
		[Address(RVA = "0x194BBA0", Offset = "0x194ADA0", Length = "0xA")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(RenderTextureDescriptor))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600069D")]
		 get { } //Length: 10
		[Address(RVA = "0x194BCE0", Offset = "0x194AEE0", Length = "0x19")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(int), "UnityEngine.Rendering.PostProcessing.MultiScaleVO+MipLevel", typeof(RenderTextureFormat), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "AllocArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(int), "UnityEngine.Rendering.PostProcessing.MultiScaleVO+MipLevel", typeof(RenderTextureFormat), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(RenderTextureDescriptor))]
		[CallerCount(Count = 3)]
		[Token(Token = "0x600069E")]
		 set { } //Length: 25
	}

	[Token(Token = "0x17000118")]
	public RenderTextureFormat colorFormat
	{
		[Address(RVA = "0x194BBB0", Offset = "0x194ADB0", Length = "0x69")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(RenderTextureDescriptor))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetRenderTextureFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(RenderTextureFormat))]
		[Token(Token = "0x6000685")]
		 get { } //Length: 105
		[Address(RVA = "0x194BD00", Offset = "0x194AF00", Length = "0x16A")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(int), "UnityEngine.Rendering.PostProcessing.MultiScaleVO+MipLevel", typeof(RenderTextureFormat), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "AllocArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(int), "UnityEngine.Rendering.PostProcessing.MultiScaleVO+MipLevel", typeof(RenderTextureFormat), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(RenderTextureDescriptor))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsSRGBFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(bool)}, ReturnType = typeof(GraphicsFormat))]
		[Calls(Type = typeof(SystemInfo), Member = "GetCompatibleFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(GraphicsFormatUsage)}, ReturnType = typeof(GraphicsFormat))]
		[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetDepthBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(RenderTexture), Member = "GetDepthStencilFormatLegacy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(GraphicsFormat))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000686")]
		 set { } //Length: 362
	}

	[Token(Token = "0x17000122")]
	internal bool createdFromScript
	{
		[Address(RVA = "0x194BE70", Offset = "0x194B070", Length = "0x19")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60006A1")]
		internal set { } //Length: 25
	}

	[Token(Token = "0x1700011A")]
	public int depthBufferBits
	{
		[Address(RVA = "0x194BC20", Offset = "0x194AE20", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetDepthBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(int))]
		[Token(Token = "0x6000689")]
		 get { } //Length: 75
		[Address(RVA = "0x194BE90", Offset = "0x194B090", Length = "0x25")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(int), "UnityEngine.Rendering.PostProcessing.MultiScaleVO+MipLevel", typeof(RenderTextureFormat), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "AllocArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(int), "UnityEngine.Rendering.PostProcessing.MultiScaleVO+MipLevel", typeof(RenderTextureFormat), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(RenderTexture), Member = "GetDepthStencilFormatLegacy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(GraphicsFormat))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600068A")]
		 set { } //Length: 37
	}

	[Token(Token = "0x17000117")]
	public GraphicsFormat depthStencilFormat
	{
		[Address(RVA = "0x3893F0", Offset = "0x3885F0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000683")]
		 get { } //Length: 4
		[Address(RVA = "0x389410", Offset = "0x388610", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000684")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700011B")]
	public TextureDimension dimension
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x600068B")]
		 get { } //Length: 4
		[Address(RVA = "0x331A20", Offset = "0x330C20", Length = "0x4")]
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600068C")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000121")]
	public bool enableRandomWrite
	{
		[Address(RVA = "0x194BC70", Offset = "0x194AE70", Length = "0xA")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(RenderTextureDescriptor))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600069F")]
		 get { } //Length: 10
		[Address(RVA = "0x194BEC0", Offset = "0x194B0C0", Length = "0x19")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(int), "UnityEngine.Rendering.PostProcessing.MultiScaleVO+MipLevel", typeof(RenderTextureFormat), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "AllocArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(int), "UnityEngine.Rendering.PostProcessing.MultiScaleVO+MipLevel", typeof(RenderTextureFormat), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(RenderTextureDescriptor))]
		[CallerCount(Count = 3)]
		[Token(Token = "0x60006A0")]
		 set { } //Length: 25
	}

	[Token(Token = "0x17000116")]
	public GraphicsFormat graphicsFormat
	{
		[Address(RVA = "0xB08210", Offset = "0xB07410", Length = "0x6")]
		[CallerCount(Count = 32)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000681")]
		 get { } //Length: 6
		[Address(RVA = "0x194BEE0", Offset = "0x194B0E0", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsSRGBFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
		[Token(Token = "0x6000682")]
		 set { } //Length: 106
	}

	[Token(Token = "0x17000112")]
	public int height
	{
		[Address(RVA = "0x3B87A0", Offset = "0x3B79A0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x600067A")]
		 get { } //Length: 4
		[Address(RVA = "0x3B8830", Offset = "0x3B7A30", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600067B")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700011E")]
	public RenderTextureMemoryless memoryless
	{
		[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000691")]
		 get { } //Length: 174
		[Address(RVA = "0x388900", Offset = "0x387B00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000692")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000115")]
	public int mipCount
	{
		[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000680")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000113")]
	public int msaaSamples
	{
		[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x600067C")]
		 get { } //Length: 4
		[Address(RVA = "0x3B9460", Offset = "0x3B8660", Length = "0x4")]
		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600067D")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700011C")]
	public ShadowSamplingMode shadowSamplingMode
	{
		[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x600068D")]
		 get { } //Length: 4
		[Address(RVA = "0x309520", Offset = "0x308720", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600068E")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000119")]
	public bool sRGB
	{
		[Address(RVA = "0x194BC80", Offset = "0x194AE80", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsSRGBFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
		[Token(Token = "0x6000687")]
		 get { } //Length: 75
		[Address(RVA = "0x194BF50", Offset = "0x194B150", Length = "0xDE")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(int), "UnityEngine.Rendering.PostProcessing.MultiScaleVO+MipLevel", typeof(RenderTextureFormat), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "AllocArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(int), "UnityEngine.Rendering.PostProcessing.MultiScaleVO+MipLevel", typeof(RenderTextureFormat), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(RenderTextureDescriptor))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(QualitySettings), Member = "get_activeColorSpace", ReturnType = typeof(ColorSpace))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetSRGBFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(GraphicsFormat))]
		[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetLinearFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(GraphicsFormat))]
		[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsSRGBFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
		[Token(Token = "0x6000688")]
		 set { } //Length: 222
	}

	[Token(Token = "0x17000123")]
	public bool useDynamicScale
	{
		[Address(RVA = "0x194C030", Offset = "0x194B230", Length = "0x1B")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(int), "UnityEngine.Rendering.PostProcessing.MultiScaleVO+MipLevel", typeof(RenderTextureFormat), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "AllocArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(int), "UnityEngine.Rendering.PostProcessing.MultiScaleVO+MipLevel", typeof(RenderTextureFormat), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(RenderTextureDescriptor))]
		[CallerCount(Count = 3)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60006A2")]
		 set { } //Length: 27
	}

	[Token(Token = "0x1700011F")]
	public bool useMipMap
	{
		[Address(RVA = "0x194BCD0", Offset = "0x194AED0", Length = "0xA")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(RenderTextureDescriptor))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600069B")]
		 get { } //Length: 10
		[Address(RVA = "0x194C050", Offset = "0x194B250", Length = "0x19")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(RenderTextureDescriptor))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x600069C")]
		 set { } //Length: 25
	}

	[Token(Token = "0x17000114")]
	public int volumeDepth
	{
		[Address(RVA = "0xAFA3A0", Offset = "0xAF95A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x600067E")]
		 get { } //Length: 4
		[Address(RVA = "0x143E130", Offset = "0x143D330", Length = "0x4")]
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600067F")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700011D")]
	public VRTextureUsage vrUsage
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x600068F")]
		 get { } //Length: 4
		[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
		[CallerCount(Count = 6)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000690")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000111")]
	public int width
	{
		[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
		[CallerCount(Count = 129)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000678")]
		 get { } //Length: 3
		[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000679")]
		 set { } //Length: 3
	}

	[Address(RVA = "0x194B9A0", Offset = "0x194ABA0", Length = "0x149")]
	[CalledBy(Type = typeof(RenderTextureDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTextureDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(RenderTexture), Member = "WarnAboutFallbackTo16BitsDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "GetDepthStencilFormatLegacy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsSRGBFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000697")]
	public RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits, int mipCount, RenderTextureReadWrite readWrite) { }

	[Address(RVA = "0x194BAF0", Offset = "0x194ACF0", Length = "0xA5")]
	[CalledBy(Type = typeof(RenderTextureDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTextureDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RenderTextureFormat)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(RenderTextureDescriptor))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(int), typeof(int), typeof(RenderTextureReadWrite)}, ReturnType = typeof(void))]
	[ExcludeFromDocs]
	[Token(Token = "0x6000695")]
	public RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits) { }

	[Address(RVA = "0x194B880", Offset = "0x194AA80", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(int), typeof(int), typeof(RenderTextureReadWrite)}, ReturnType = typeof(void))]
	[ExcludeFromDocs]
	[Token(Token = "0x6000696")]
	public RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits, int mipCount) { }

	[Address(RVA = "0x194B8B0", Offset = "0x194AAB0", Length = "0xC1")]
	[CalledBy(Type = typeof(RenderTextureDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsSRGBFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[ExcludeFromDocs]
	[Token(Token = "0x6000699")]
	public RenderTextureDescriptor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount) { }

	[Address(RVA = "0x194B7C0", Offset = "0x194A9C0", Length = "0x1F")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", Member = "Reset", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(int)}, ReturnType = typeof(void))]
	[ExcludeFromDocs]
	[Token(Token = "0x6000693")]
	public RenderTextureDescriptor(int width, int height) { }

	[Address(RVA = "0x194B7E0", Offset = "0x194A9E0", Length = "0x9D")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderTreeCompositor", Member = "ExecuteDrawOperation_PostOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderTreeCompositor+DrawOperation"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(GraphicsFormat), typeof(int)}, ReturnType = typeof(void))]
	[ExcludeFromDocs]
	[Token(Token = "0x6000698")]
	public RenderTextureDescriptor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat) { }

	[Address(RVA = "0x194B980", Offset = "0x194AB80", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(int)}, ReturnType = typeof(void))]
	[ExcludeFromDocs]
	[Token(Token = "0x6000694")]
	public RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat) { }

	[Address(RVA = "0x194BBA0", Offset = "0x194ADA0", Length = "0xA")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(RenderTextureDescriptor))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600069D")]
	public bool get_autoGenerateMips() { }

	[Address(RVA = "0x194BBB0", Offset = "0x194ADB0", Length = "0x69")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(RenderTextureDescriptor))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetRenderTextureFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(RenderTextureFormat))]
	[Token(Token = "0x6000685")]
	public RenderTextureFormat get_colorFormat() { }

	[Address(RVA = "0x194BC20", Offset = "0x194AE20", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetDepthBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000689")]
	public int get_depthBufferBits() { }

	[Address(RVA = "0x3893F0", Offset = "0x3885F0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6000683")]
	public GraphicsFormat get_depthStencilFormat() { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x600068B")]
	public TextureDimension get_dimension() { }

	[Address(RVA = "0x194BC70", Offset = "0x194AE70", Length = "0xA")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(RenderTextureDescriptor))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600069F")]
	public bool get_enableRandomWrite() { }

	[Address(RVA = "0xB08210", Offset = "0xB07410", Length = "0x6")]
	[CallerCount(Count = 32)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000681")]
	public GraphicsFormat get_graphicsFormat() { }

	[Address(RVA = "0x3B87A0", Offset = "0x3B79A0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x600067A")]
	public int get_height() { }

	[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6000691")]
	public RenderTextureMemoryless get_memoryless() { }

	[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x600067C")]
	public int get_msaaSamples() { }

	[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x600068D")]
	public ShadowSamplingMode get_shadowSamplingMode() { }

	[Address(RVA = "0x194BC80", Offset = "0x194AE80", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsSRGBFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000687")]
	public bool get_sRGB() { }

	[Address(RVA = "0x194BCD0", Offset = "0x194AED0", Length = "0xA")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(RenderTextureDescriptor))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600069B")]
	public bool get_useMipMap() { }

	[Address(RVA = "0xAFA3A0", Offset = "0xAF95A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x600067E")]
	public int get_volumeDepth() { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x600068F")]
	public VRTextureUsage get_vrUsage() { }

	[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
	[CallerCount(Count = 129)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6000678")]
	public int get_width() { }

	[Address(RVA = "0x194BCE0", Offset = "0x194AEE0", Length = "0x19")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(int), "UnityEngine.Rendering.PostProcessing.MultiScaleVO+MipLevel", typeof(RenderTextureFormat), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "AllocArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(int), "UnityEngine.Rendering.PostProcessing.MultiScaleVO+MipLevel", typeof(RenderTextureFormat), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(RenderTextureDescriptor))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x600069E")]
	public void set_autoGenerateMips(bool value) { }

	[Address(RVA = "0x194BD00", Offset = "0x194AF00", Length = "0x16A")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(int), "UnityEngine.Rendering.PostProcessing.MultiScaleVO+MipLevel", typeof(RenderTextureFormat), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "AllocArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(int), "UnityEngine.Rendering.PostProcessing.MultiScaleVO+MipLevel", typeof(RenderTextureFormat), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(RenderTextureDescriptor))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsSRGBFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(bool)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(SystemInfo), Member = "GetCompatibleFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(GraphicsFormatUsage)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetDepthBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderTexture), Member = "GetDepthStencilFormatLegacy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(GraphicsFormat))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000686")]
	public void set_colorFormat(RenderTextureFormat value) { }

	[Address(RVA = "0x194BE70", Offset = "0x194B070", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60006A1")]
	internal void set_createdFromScript(bool value) { }

	[Address(RVA = "0x194BE90", Offset = "0x194B090", Length = "0x25")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(int), "UnityEngine.Rendering.PostProcessing.MultiScaleVO+MipLevel", typeof(RenderTextureFormat), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "AllocArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(int), "UnityEngine.Rendering.PostProcessing.MultiScaleVO+MipLevel", typeof(RenderTextureFormat), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderTexture), Member = "GetDepthStencilFormatLegacy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(GraphicsFormat))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600068A")]
	public void set_depthBufferBits(int value) { }

	[Address(RVA = "0x389410", Offset = "0x388610", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000684")]
	public void set_depthStencilFormat(GraphicsFormat value) { }

	[Address(RVA = "0x331A20", Offset = "0x330C20", Length = "0x4")]
	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600068C")]
	public void set_dimension(TextureDimension value) { }

	[Address(RVA = "0x194BEC0", Offset = "0x194B0C0", Length = "0x19")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(int), "UnityEngine.Rendering.PostProcessing.MultiScaleVO+MipLevel", typeof(RenderTextureFormat), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "AllocArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(int), "UnityEngine.Rendering.PostProcessing.MultiScaleVO+MipLevel", typeof(RenderTextureFormat), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(RenderTextureDescriptor))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x60006A0")]
	public void set_enableRandomWrite(bool value) { }

	[Address(RVA = "0x194BEE0", Offset = "0x194B0E0", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsSRGBFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000682")]
	public void set_graphicsFormat(GraphicsFormat value) { }

	[Address(RVA = "0x3B8830", Offset = "0x3B7A30", Length = "0x4")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600067B")]
	public void set_height(int value) { }

	[Address(RVA = "0x388900", Offset = "0x387B00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000692")]
	public void set_memoryless(RenderTextureMemoryless value) { }

	[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000680")]
	public void set_mipCount(int value) { }

	[Address(RVA = "0x3B9460", Offset = "0x3B8660", Length = "0x4")]
	[CallerCount(Count = 4)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600067D")]
	public void set_msaaSamples(int value) { }

	[Address(RVA = "0x309520", Offset = "0x308720", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600068E")]
	public void set_shadowSamplingMode(ShadowSamplingMode value) { }

	[Address(RVA = "0x194BF50", Offset = "0x194B150", Length = "0xDE")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(int), "UnityEngine.Rendering.PostProcessing.MultiScaleVO+MipLevel", typeof(RenderTextureFormat), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "AllocArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(int), "UnityEngine.Rendering.PostProcessing.MultiScaleVO+MipLevel", typeof(RenderTextureFormat), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(RenderTextureDescriptor))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(QualitySettings), Member = "get_activeColorSpace", ReturnType = typeof(ColorSpace))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetSRGBFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetLinearFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsSRGBFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000688")]
	public void set_sRGB(bool value) { }

	[Address(RVA = "0x194C030", Offset = "0x194B230", Length = "0x1B")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(int), "UnityEngine.Rendering.PostProcessing.MultiScaleVO+MipLevel", typeof(RenderTextureFormat), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "AllocArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(int), "UnityEngine.Rendering.PostProcessing.MultiScaleVO+MipLevel", typeof(RenderTextureFormat), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(RenderTextureDescriptor))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006A2")]
	public void set_useDynamicScale(bool value) { }

	[Address(RVA = "0x194C050", Offset = "0x194B250", Length = "0x19")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(RenderTextureDescriptor))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x600069C")]
	public void set_useMipMap(bool value) { }

	[Address(RVA = "0x143E130", Offset = "0x143D330", Length = "0x4")]
	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600067F")]
	public void set_volumeDepth(int value) { }

	[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
	[CallerCount(Count = 6)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000690")]
	public void set_vrUsage(VRTextureUsage value) { }

	[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000679")]
	public void set_width(int value) { }

	[Address(RVA = "0x194B7A0", Offset = "0x194A9A0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600069A")]
	private void SetOrClearRenderTextureCreationFlag(bool value, RenderTextureCreationFlags flag) { }

}

