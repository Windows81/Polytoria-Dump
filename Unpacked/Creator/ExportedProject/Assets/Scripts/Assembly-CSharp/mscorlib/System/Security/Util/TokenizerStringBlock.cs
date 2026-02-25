namespace System.Security.Util;

[Token(Token = "0x20002CF")]
internal sealed class TokenizerStringBlock
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C49")]
	internal String[] m_block; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C4A")]
	internal TokenizerStringBlock m_next; //Field offset: 0x18

	[Address(RVA = "0x1333290", Offset = "0x1332490", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001737")]
	public TokenizerStringBlock() { }

}

