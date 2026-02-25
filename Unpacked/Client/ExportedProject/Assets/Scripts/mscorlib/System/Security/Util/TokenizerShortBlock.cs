namespace System.Security.Util;

[Token(Token = "0x20002CE")]
internal sealed class TokenizerShortBlock
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C47")]
	internal Int16[] m_block; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C48")]
	internal TokenizerShortBlock m_next; //Field offset: 0x18

	[Address(RVA = "0x1332BA0", Offset = "0x1331DA0", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001736")]
	public TokenizerShortBlock() { }

}

