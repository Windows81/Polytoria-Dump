namespace GLTFast.Schema;

[Token(Token = "0x20000B8")]
public class MorphTarget
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002A2")]
	public int POSITION; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40002A3")]
	public int NORMAL; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002A4")]
	public int TANGENT; //Field offset: 0x18

	[Address(RVA = "0x1073430", Offset = "0x1072630", Length = "0x16")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000225")]
	public MorphTarget() { }

	[Address(RVA = "0x1077CE0", Offset = "0x1076EE0", Length = "0xEE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000223")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1077DD0", Offset = "0x1076FD0", Length = "0x54")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000224")]
	public virtual int GetHashCode() { }

}

