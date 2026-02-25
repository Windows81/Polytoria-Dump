namespace GLTFast.Schema;

[Token(Token = "0x2000086")]
public class AnimationChannelTarget
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400022F")]
	public int node; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Obsolete("Use GetPath for access.")]
	[Token(Token = "0x4000230")]
	public string path; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000231")]
	private Path m_Path; //Field offset: 0x20

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001C2")]
	public AnimationChannelTarget() { }

	[Address(RVA = "0x1073040", Offset = "0x1072240", Length = "0x93")]
	[CalledBy(Type = "GLTFast.GltfImportBase+<LoadAccessorData>d__140", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Enum), Member = "TryParse", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(Int32Enum&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60001C1")]
	public Path GetPath() { }

}

