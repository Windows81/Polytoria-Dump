namespace System;

[Token(Token = "0x2000006")]
public sealed class Action2 : MulticastDelegate
{

	[Address(RVA = "0xA300B0", Offset = "0xA2F2B0", Length = "0x110")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x600000B")]
	public Action`12(object object, IntPtr method) { }

	[Address(RVA = "0x336620", Offset = "0x335820", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000C")]
	public override void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) { }

}

