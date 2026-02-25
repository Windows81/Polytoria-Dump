namespace System;

[Token(Token = "0x20000A8")]
public sealed class Func : MulticastDelegate
{

	[Address(RVA = "0xC46A50", Offset = "0xC45C50", Length = "0xA6")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x60003D2")]
	public Func`3(object object, IntPtr method) { }

	[Address(RVA = "0x9B32F0", Offset = "0x9B24F0", Length = "0x45")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003D3")]
	public override TResult Invoke(T1 arg1, T2 arg2) { }

}

