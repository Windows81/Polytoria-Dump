namespace System;

[Token(Token = "0x20000A7")]
public sealed class Func : MulticastDelegate
{

	[Address(RVA = "0xC44C90", Offset = "0xC43E90", Length = "0xA6")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x60003D0")]
	public Func`2(object object, IntPtr method) { }

	[Address(RVA = "0x80BFC0", Offset = "0x80B1C0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003D1")]
	public override TResult Invoke(T arg) { }

}

