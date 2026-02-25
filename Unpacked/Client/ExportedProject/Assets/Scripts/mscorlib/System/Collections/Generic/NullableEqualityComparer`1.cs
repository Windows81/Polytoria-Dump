namespace System.Collections.Generic;

[Token(Token = "0x2000600")]
internal class NullableEqualityComparer : EqualityComparer<Nullable`1<T>>
{

	[Address(RVA = "0xE2C2B0", Offset = "0xE2B4B0", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C19")]
	public NullableEqualityComparer`1() { }

	[Address(RVA = "0xE2B880", Offset = "0xE2AA80", Length = "0x47")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C13")]
	public virtual bool Equals(Nullable<T> x, Nullable<T> y) { }

	[Address(RVA = "0xE2B8D0", Offset = "0xE2AAD0", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C17")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xE2BA20", Offset = "0xE2AC20", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C14")]
	public virtual int GetHashCode(Nullable<T> obj) { }

	[Address(RVA = "0xAE1270", Offset = "0xAE0470", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C18")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0xE2BD80", Offset = "0xE2AF80", Length = "0xF9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C15")]
	internal virtual int IndexOf(Nullable<T>[] array, Nullable<T> value, int startIndex, int count) { }

	[Address(RVA = "0xE2BE80", Offset = "0xE2B080", Length = "0xF9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C16")]
	internal virtual int LastIndexOf(Nullable<T>[] array, Nullable<T> value, int startIndex, int count) { }

}

