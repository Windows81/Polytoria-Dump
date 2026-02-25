namespace System.Net;

[Token(Token = "0x2000212")]
internal class ReceiveState
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400081D")]
	internal ResponseDescription Resp; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400081E")]
	internal int ValidThrough; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400081F")]
	internal Byte[] Buffer; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000820")]
	internal CommandStream Connection; //Field offset: 0x28

	[Address(RVA = "0x17CB380", Offset = "0x17CA580", Length = "0x104")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000D48")]
	internal ReceiveState(CommandStream connection) { }

}

