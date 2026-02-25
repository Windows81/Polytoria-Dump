namespace System;

[Token(Token = "0x20000A2")]
public sealed class Action : MulticastDelegate
{

	[Address(RVA = "0xA341E0", Offset = "0xA333E0", Length = "0x110")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x60003C6")]
	public Action`5(object object, IntPtr method) { }

	[Address(RVA = "0x335810", Offset = "0x334A10", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003C7")]
	public override void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }

}

