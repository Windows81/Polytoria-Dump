namespace GLTFast.Schema;

[Token(Token = "0x2000087")]
public class AnimationSampler
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000232")]
	public int input; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Obsolete("Use GetInterpolationType for access.")]
	[Token(Token = "0x4000233")]
	public string interpolation; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000234")]
	private InterpolationType m_Interpolation; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000235")]
	public int output; //Field offset: 0x24

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001C4")]
	public AnimationSampler() { }

	[Address(RVA = "0x1073120", Offset = "0x1072320", Length = "0x93")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Enum), Member = "TryParse", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(Int32Enum&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60001C3")]
	public InterpolationType GetInterpolationType() { }

}

