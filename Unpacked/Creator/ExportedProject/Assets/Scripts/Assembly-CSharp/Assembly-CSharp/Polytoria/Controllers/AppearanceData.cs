namespace Polytoria.Controllers;

[Token(Token = "0x20003F4")]
public class AppearanceData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001093")]
	public Color headColor; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001094")]
	public Color torsoColor; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001095")]
	public Color leftArmColor; //Field offset: 0x30
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001096")]
	public Color rightArmColor; //Field offset: 0x40
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001097")]
	public Color leftLegColor; //Field offset: 0x50
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001098")]
	public Color rightLegColor; //Field offset: 0x60
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001099")]
	public String[] hatUrls; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400109A")]
	public int faceID; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x400109B")]
	public int shirtID; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400109C")]
	public int pantsID; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x400109D")]
	public int torsoID; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400109E")]
	public string torsoUrl; //Field offset: 0x88

	[Address(RVA = "0x4B7160", Offset = "0x4B6360", Length = "0x96")]
	[CalledBy(Type = typeof(AppearanceLoaderBase), Member = "ClearAppearance", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002A9C")]
	public AppearanceData() { }

	[Address(RVA = "0x4B6D40", Offset = "0x4B5F40", Length = "0x416")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002A9A")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2D8E50", Offset = "0x2D8050", Length = "0x7")]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A9B")]
	public virtual int GetHashCode() { }

}

