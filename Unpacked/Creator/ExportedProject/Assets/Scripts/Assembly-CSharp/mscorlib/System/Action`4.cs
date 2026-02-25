namespace System;

[Token(Token = "0x20000A1")]
public sealed class Action : MulticastDelegate
{

	[Address(RVA = "0xA34130", Offset = "0xA33330", Length = "0xA6")]
	[CalledBy(Type = "Polytoria.Controllers.AppearanceLoaderBase", Member = "OnStartClient", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x60003C4")]
	public Action`4(object object, IntPtr method) { }

	[Address(RVA = "0x335660", Offset = "0x334860", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003C5")]
	public override void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }

}

