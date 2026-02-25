namespace System;

[Token(Token = "0x20001C7")]
internal class ByteMatcher
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000768")]
	private Hashtable map; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000769")]
	private Hashtable starts; //Field offset: 0x18

	[Address(RVA = "0x14F0370", Offset = "0x14EF570", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600101B")]
	public ByteMatcher() { }

	[Address(RVA = "0x14EFF30", Offset = "0x14EF130", Length = "0x10F")]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "InitKeys", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "AddStringMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TermInfoStrings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001017")]
	public void AddMapping(TermInfoStrings key, Byte[] val) { }

	[Address(RVA = "0x14F0040", Offset = "0x14EF240", Length = "0x2D5")]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "GetKeyFromBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600101A")]
	public TermInfoStrings Match(Char[] buffer, int offset, int length, out int used) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001018")]
	public void Sort() { }

	[Address(RVA = "0x14F0320", Offset = "0x14EF520", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001019")]
	public bool StartsWith(int c) { }

}

