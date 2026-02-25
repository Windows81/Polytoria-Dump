namespace System;

[Token(Token = "0x20000A5")]
public sealed class Action : MulticastDelegate
{

	[Address(RVA = "0xA34790", Offset = "0xA33990", Length = "0xA6")]
	[CalledBy(Type = "UnityEngine.ObjectDispatcher", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x60003CC")]
	public Action`8(object object, IntPtr method) { }

	[Address(RVA = "0x335D50", Offset = "0x334F50", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003CD")]
	public override void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) { }

}

