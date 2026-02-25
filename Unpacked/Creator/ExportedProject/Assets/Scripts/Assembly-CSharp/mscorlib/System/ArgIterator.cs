namespace System;

[Token(Token = "0x20001A0")]
public struct ArgIterator
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006E8")]
	private IntPtr sig; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40006E9")]
	private IntPtr args; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006EA")]
	private int next_arg; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40006EB")]
	private int num_args; //Field offset: 0x14

	[Address(RVA = "0x14EFEB0", Offset = "0x14EF0B0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000EFC")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
	[CallerCount(Count = 129)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EFD")]
	public virtual int GetHashCode() { }

}

