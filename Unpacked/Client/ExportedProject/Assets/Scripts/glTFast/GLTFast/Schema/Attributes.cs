namespace GLTFast.Schema;

[Token(Token = "0x20000B6")]
public class Attributes
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000292")]
	public int POSITION; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000293")]
	public int NORMAL; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000294")]
	public int TANGENT; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000295")]
	public int TEXCOORD_0; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000296")]
	public int TEXCOORD_1; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000297")]
	public int TEXCOORD_2; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000298")]
	public int TEXCOORD_3; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000299")]
	public int TEXCOORD_4; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400029A")]
	public int TEXCOORD_5; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400029B")]
	public int TEXCOORD_6; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400029C")]
	public int TEXCOORD_7; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400029D")]
	public int TEXCOORD_8; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400029E")]
	public int COLOR_0; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400029F")]
	public int JOINTS_0; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40002A0")]
	public int WEIGHTS_0; //Field offset: 0x48

	[Address(RVA = "0x10733E0", Offset = "0x10725E0", Length = "0x46")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000221")]
	public Attributes() { }

	[Address(RVA = "0x1073200", Offset = "0x1072400", Length = "0x13E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600021F")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1073340", Offset = "0x1072540", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x6000220")]
	public virtual int GetHashCode() { }

}

