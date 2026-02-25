namespace System;

[Token(Token = "0x20000D3")]
public class EventArgs
{
	[Token(Token = "0x400031F")]
	public static readonly EventArgs Empty; //Field offset: 0x0

	[Address(RVA = "0x1499FC0", Offset = "0x14991C0", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600069E")]
	private static EventArgs() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600069D")]
	public EventArgs() { }

}

