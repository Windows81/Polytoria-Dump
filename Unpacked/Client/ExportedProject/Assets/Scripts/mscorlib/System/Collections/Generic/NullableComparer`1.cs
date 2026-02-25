namespace System.Collections.Generic;

[Token(Token = "0x20005FC")]
internal class NullableComparer : Comparer<Nullable`1<T>>
{

	[Address(RVA = "0xE2B650", Offset = "0xE2A850", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BFE")]
	public NullableComparer`1() { }

	[Address(RVA = "0xE2B3F0", Offset = "0xE2A5F0", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BFB")]
	public virtual int Compare(Nullable<T> x, Nullable<T> y) { }

	[Address(RVA = "0xAE0F40", Offset = "0xAE0140", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BFC")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xAE1270", Offset = "0xAE0470", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BFD")]
	public virtual int GetHashCode() { }

}

