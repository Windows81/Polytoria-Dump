namespace System;

[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[Token(Token = "0x2000171")]
internal struct ByReference
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000582")]
	private IntPtr _value; //Field offset: 0x0

	[Token(Token = "0x1700011B")]
	public T Value
	{
		[Address(RVA = "0x7F3A50", Offset = "0x7F2C50", Length = "0x39")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Intrinsic]
		[Token(Token = "0x6000D11")]
		 get { } //Length: 57
	}

	[Address(RVA = "0x9674E0", Offset = "0x9666E0", Length = "0x39")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Intrinsic]
	[Token(Token = "0x6000D10")]
	public ByReference`1(ref T value) { }

	[Address(RVA = "0x7F3A50", Offset = "0x7F2C50", Length = "0x39")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Intrinsic]
	[Token(Token = "0x6000D11")]
	public T get_Value() { }

}

