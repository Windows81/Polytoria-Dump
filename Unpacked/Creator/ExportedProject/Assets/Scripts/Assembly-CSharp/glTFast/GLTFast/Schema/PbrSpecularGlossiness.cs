namespace GLTFast.Schema;

[Token(Token = "0x20000C5")]
public class PbrSpecularGlossiness
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002B6")]
	public Single[] diffuseFactor; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002B7")]
	public TextureInfo diffuseTexture; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002B8")]
	public Single[] specularFactor; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002B9")]
	public float glossinessFactor; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002BA")]
	public TextureInfo specularGlossinessTexture; //Field offset: 0x30

	[Token(Token = "0x17000063")]
	public Color DiffuseColor
	{
		[Address(RVA = "0x1078960", Offset = "0x1077B60", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000239")]
		 get { } //Length: 101
	}

	[Token(Token = "0x17000064")]
	public Color SpecularColor
	{
		[Address(RVA = "0x1078AE0", Offset = "0x1077CE0", Length = "0x57")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x600023A")]
		 get { } //Length: 87
	}

	[Address(RVA = "0x1078A10", Offset = "0x1077C10", Length = "0xC8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600023B")]
	public PbrSpecularGlossiness() { }

	[Address(RVA = "0x1078960", Offset = "0x1077B60", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000239")]
	public Color get_DiffuseColor() { }

	[Address(RVA = "0x1078AE0", Offset = "0x1077CE0", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600023A")]
	public Color get_SpecularColor() { }

}

