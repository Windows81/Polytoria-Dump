namespace System;

[Token(Token = "0x20000AC")]
public sealed class Func : MulticastDelegate
{

	[Address(RVA = "0xC49590", Offset = "0xC48790", Length = "0x110")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x60003DA")]
	public Func`7(object object, IntPtr method) { }

	[Address(RVA = "0x335B80", Offset = "0x334D80", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003DB")]
	public override TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }

}

