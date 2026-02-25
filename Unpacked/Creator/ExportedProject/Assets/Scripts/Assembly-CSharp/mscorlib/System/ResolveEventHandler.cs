namespace System;

[Token(Token = "0x200012B")]
public sealed class ResolveEventHandler : MulticastDelegate
{

	[Address(RVA = "0xC47E40", Offset = "0xC47040", Length = "0x125")]
	[CallerCount(Count = 45)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000972")]
	public ResolveEventHandler(object object, IntPtr method) { }

	[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000973")]
	public override Assembly Invoke(object sender, ResolveEventArgs args) { }

}

