namespace System.Collections.Generic;

[Token(Token = "0x2000602")]
internal class ByteEqualityComparer : EqualityComparer<Byte>
{

	[Address(RVA = "0x143C140", Offset = "0x143B340", Length = "0x39")]
	[CalledBy(Type = typeof(EqualityComparer`1), Member = "CreateComparer", ReturnType = "System.Collections.Generic.EqualityComparer`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002C27")]
	public ByteEqualityComparer() { }

	[Address(RVA = "0x143BE00", Offset = "0x143B000", Length = "0x7")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002C21")]
	public virtual bool Equals(byte x, byte y) { }

	[Address(RVA = "0x143BE10", Offset = "0x143B010", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002C25")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xE44110", Offset = "0xE43310", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C22")]
	public virtual int GetHashCode(byte b) { }

	[Address(RVA = "0x143BE90", Offset = "0x143B090", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002C26")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x143BEE0", Offset = "0x143B0E0", Length = "0x1F3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "IndexOfByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(byte), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6002C23")]
	internal virtual int IndexOf(Byte[] array, byte value, int startIndex, int count) { }

	[Address(RVA = "0x143C0E0", Offset = "0x143B2E0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6002C24")]
	internal virtual int LastIndexOf(Byte[] array, byte value, int startIndex, int count) { }

}

