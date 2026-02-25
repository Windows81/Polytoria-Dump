namespace GLTFast.Schema;

[Token(Token = "0x20000D3")]
public abstract class TextureBase : NamedObject
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002EA")]
	public int sampler; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40002EB")]
	public int source; //Field offset: 0x1C

	[Token(Token = "0x17000086")]
	public abstract TextureExtensions Extensions
	{
		[Token(Token = "0x6000270")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x107A5D0", Offset = "0x10797D0", Length = "0xF")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000275")]
	protected TextureBase() { }

	[Address(RVA = "0x107A5F0", Offset = "0x10797F0", Length = "0x1AB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x6000272")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x107A7A0", Offset = "0x10799A0", Length = "0xEF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x6000273")]
	private bool Equals(Texture other) { }

	[Token(Token = "0x6000270")]
	public abstract TextureExtensions get_Extensions() { }

	[Address(RVA = "0x107A890", Offset = "0x1079A90", Length = "0xB0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HashCode), Member = "Combine", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "T3"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000274")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x107A950", Offset = "0x1079B50", Length = "0xA8")]
	[CalledBy(Type = "GLTFast.GltfImportBase+<LoadImages>d__105", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GltfImportBase), Member = "<LoadImages>g__SetImageGamma|105_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureInfoBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000271")]
	public int GetImageIndex() { }

}

