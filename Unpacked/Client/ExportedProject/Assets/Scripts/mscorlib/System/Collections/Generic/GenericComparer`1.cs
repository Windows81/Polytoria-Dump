namespace System.Collections.Generic;

[Token(Token = "0x20005FB")]
internal class GenericComparer : Comparer<T>
{

	[Address(RVA = "0xC4A990", Offset = "0xC49B90", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BFA")]
	public GenericComparer`1() { }

	[Address(RVA = "0xC4A450", Offset = "0xC49650", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValueTuple`1), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ValueTuple`1<T1>"}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BF7")]
	public virtual int Compare(T x, T y) { }

	[Address(RVA = "0xC4A910", Offset = "0xC49B10", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BF8")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xAE1270", Offset = "0xAE0470", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BF9")]
	public virtual int GetHashCode() { }

}

