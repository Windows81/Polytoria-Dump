namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
[Token(Token = "0x2000028")]
internal sealed class Dithering
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000AB")]
	private int m_NoiseTextureIndex; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000AC")]
	private Random m_Random; //Field offset: 0x18

	[Address(RVA = "0x18324C0", Offset = "0x18316C0", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Random), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000049")]
	public Dithering() { }

	[Address(RVA = "0x1832270", Offset = "0x1831470", Length = "0x241")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderBuiltins", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext), typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderFinalPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000048")]
	internal void Render(PostProcessRenderContext context) { }

}

