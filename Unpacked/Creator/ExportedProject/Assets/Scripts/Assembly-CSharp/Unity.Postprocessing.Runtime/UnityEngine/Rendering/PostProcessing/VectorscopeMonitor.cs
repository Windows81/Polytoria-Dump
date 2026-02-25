namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x200004D")]
public sealed class VectorscopeMonitor : Monitor
{
	[Token(Token = "0x4000150")]
	private const int k_ThreadGroupSizeX = 16; //Field offset: 0x0
	[Token(Token = "0x4000151")]
	private const int k_ThreadGroupSizeY = 16; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400014D")]
	public int size; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400014E")]
	public float exposure; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400014F")]
	private ComputeBuffer m_Data; //Field offset: 0x28

	[Address(RVA = "0x1856EF0", Offset = "0x18560F0", Length = "0x15")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000B6")]
	public VectorscopeMonitor() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B3")]
	internal virtual bool NeedsHalfRes() { }

	[Address(RVA = "0x18566C0", Offset = "0x18558C0", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B2")]
	internal virtual void OnDisable() { }

	[Address(RVA = "0x1856740", Offset = "0x1855940", Length = "0x735")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ComputeShader), Member = "FindKernel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinRenderTextureType)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(PropertySheet))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(string), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802891B0")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(string), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeBufferParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(string), typeof(ComputeBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CommandBuffer), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ComputeBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ComputeBuffer), Member = "get_count", ReturnType = typeof(int))]
	[Calls(Type = typeof(Monitor), Member = "CheckOutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CommandBuffer), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(QualitySettings), Member = "get_activeColorSpace", ReturnType = typeof(ColorSpace))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(PropertySheet), typeof(int), typeof(RenderBufferLoadAction), typeof(System.Nullable`1<UnityEngine.Rect>), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000B5")]
	internal virtual void Render(PostProcessRenderContext context) { }

	[Address(RVA = "0x1856E80", Offset = "0x1856080", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000B4")]
	internal virtual bool ShaderResourcesAvailable(PostProcessRenderContext context) { }

}

