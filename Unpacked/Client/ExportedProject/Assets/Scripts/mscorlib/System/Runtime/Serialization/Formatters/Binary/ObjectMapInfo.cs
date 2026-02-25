namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000415")]
internal sealed class ObjectMapInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40010A0")]
	internal int objectId; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40010A1")]
	private int numMembers; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40010A2")]
	private String[] memberNames; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40010A3")]
	private Type[] memberTypes; //Field offset: 0x20

	[Address(RVA = "0x139ED10", Offset = "0x139DF10", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001E7F")]
	internal ObjectMapInfo(int objectId, int numMembers, String[] memberNames, Type[] memberTypes) { }

	[Address(RVA = "0x139ED80", Offset = "0x139DF80", Length = "0x121")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001E80")]
	internal bool isCompatible(int numMembers, String[] memberNames, Type[] memberTypes) { }

}

