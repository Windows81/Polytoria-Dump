namespace UnityEngine.Rendering;

[Token(Token = "0x20002BA")]
public struct RenderTargetIdentifier : IEquatable<RenderTargetIdentifier>
{
	[Token(Token = "0x40007B3")]
	public static readonly RenderTargetIdentifier Invalid; //Field offset: 0x0
	[Token(Token = "0x40007B4")]
	public const int AllDepthSlices = -1; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007B5")]
	private BuiltinRenderTextureType m_Type; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40007B6")]
	private int m_NameID; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40007B7")]
	private int m_InstanceID; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007B8")]
	private IntPtr m_BufferPointer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007B9")]
	private int m_MipLevel; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40007BA")]
	private CubemapFace m_CubeFace; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40007BB")]
	private int m_DepthSlice; //Field offset: 0x20

	[Address(RVA = "0x198BCD0", Offset = "0x198AED0", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000DA3")]
	private static RenderTargetIdentifier() { }

	[Address(RVA = "0x198BDA0", Offset = "0x198AFA0", Length = "0x20")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "BuildCommandBuffers", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000D96")]
	public RenderTargetIdentifier(BuiltinRenderTextureType type) { }

	[Address(RVA = "0x198BD20", Offset = "0x198AF20", Length = "0x20")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "PushDownsampleCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), "System.Nullable`1<RenderTargetIdentifier>", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000D97")]
	public RenderTargetIdentifier(int nameID) { }

	[Address(RVA = "0x198BD70", Offset = "0x198AF70", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000D98")]
	public RenderTargetIdentifier(RenderTargetIdentifier renderTargetIdentifier, int mipLevel, CubemapFace cubeFace = -1, int depthSlice = 0) { }

	[Address(RVA = "0x198BDC0", Offset = "0x198AFC0", Length = "0x10C")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ScreenSpaceReflectionsRenderer", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D99")]
	public RenderTargetIdentifier(Texture tex) { }

	[Address(RVA = "0x198BD40", Offset = "0x198AF40", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000D9A")]
	public RenderTargetIdentifier(RenderBuffer buf, int mipLevel = 0, CubemapFace cubeFace = -1, int depthSlice = 0) { }

	[Address(RVA = "0x198B8B0", Offset = "0x198AAB0", Length = "0x89")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000DA1")]
	public override bool Equals(RenderTargetIdentifier rhs) { }

	[Address(RVA = "0x198B780", Offset = "0x198A980", Length = "0x12B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000DA2")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x198B940", Offset = "0x198AB40", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000DA0")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x198BED0", Offset = "0x198B0D0", Length = "0x4F")]
	[CallerCount(Count = 34)]
	[Token(Token = "0x6000D9B")]
	public static RenderTargetIdentifier op_Implicit(BuiltinRenderTextureType type) { }

	[Address(RVA = "0x198BF20", Offset = "0x198B120", Length = "0x4F")]
	[CallerCount(Count = 85)]
	[Token(Token = "0x6000D9C")]
	public static RenderTargetIdentifier op_Implicit(int nameID) { }

	[Address(RVA = "0x198BF70", Offset = "0x198B170", Length = "0x14D")]
	[CallerCount(Count = 48)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D9D")]
	public static RenderTargetIdentifier op_Implicit(Texture tex) { }

	[Address(RVA = "0x198C0C0", Offset = "0x198B2C0", Length = "0x5A")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "BuildCommandBuffers", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000D9E")]
	public static RenderTargetIdentifier op_Implicit(RenderBuffer buf) { }

	[Address(RVA = "0x198B990", Offset = "0x198AB90", Length = "0x33C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D9F")]
	public virtual string ToString() { }

}

