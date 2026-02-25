namespace System;

[Token(Token = "0x20000A6")]
public sealed class Func : MulticastDelegate
{

	[Address(RVA = "0x2D8940", Offset = "0x2D7B40", Length = "0xA5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x60003CE")]
	public Func`1(object object, IntPtr method) { }

	[Address(RVA = "0x2D8900", Offset = "0x2D7B00", Length = "0x33")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003CF")]
	public override TResult Invoke() { }

}

