namespace System.Reflection;

[ComVisible(True)]
[Token(Token = "0x2000506")]
public class LocalVariableInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400145A")]
	internal Type type; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400145B")]
	internal bool is_pinned; //Field offset: 0x18
	[FieldOffset(Offset = "0x1A")]
	[Token(Token = "0x400145C")]
	internal ushort position; //Field offset: 0x1A

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002379")]
	protected LocalVariableInfo() { }

	[Address(RVA = "0x13E2E00", Offset = "0x13E2000", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x600237A")]
	public virtual string ToString() { }

}

