namespace GLTFast.Schema;

[Token(Token = "0x20000A5")]
public abstract class PbrMetallicRoughnessBase
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000275")]
	public Single[] baseColorFactor; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000276")]
	public float metallicFactor; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000277")]
	public float roughnessFactor; //Field offset: 0x1C

	[Token(Token = "0x17000056")]
	public Color BaseColor
	{
		[Address(RVA = "0x1078960", Offset = "0x1077B60", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000201")]
		 get { } //Length: 101
	}

	[Token(Token = "0x17000057")]
	public abstract TextureInfoBase BaseColorTexture
	{
		[Token(Token = "0x6000202")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000058")]
	public abstract TextureInfoBase MetallicRoughnessTexture
	{
		[Token(Token = "0x6000203")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x10788D0", Offset = "0x1077AD0", Length = "0x8D")]
	[CalledBy(Type = typeof(PbrMetallicRoughnessBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000204")]
	protected PbrMetallicRoughnessBase() { }

	[Address(RVA = "0x1078960", Offset = "0x1077B60", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000201")]
	public Color get_BaseColor() { }

	[Token(Token = "0x6000202")]
	public abstract TextureInfoBase get_BaseColorTexture() { }

	[Token(Token = "0x6000203")]
	public abstract TextureInfoBase get_MetallicRoughnessTexture() { }

}

