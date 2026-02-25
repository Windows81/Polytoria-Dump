namespace System;

[Token(Token = "0x200009F")]
public sealed class Action : MulticastDelegate
{

	[Address(RVA = "0xA32BC0", Offset = "0xA31DC0", Length = "0xA6")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x60003C0")]
	public Action`2(object object, IntPtr method) { }

	[Address(RVA = "0xA30A70", Offset = "0xA2FC70", Length = "0x24")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003C1")]
	public override void Invoke(T1 arg1, T2 arg2) { }

}

