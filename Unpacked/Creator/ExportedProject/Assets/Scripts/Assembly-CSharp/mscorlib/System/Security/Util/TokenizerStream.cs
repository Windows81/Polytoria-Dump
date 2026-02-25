namespace System.Security.Util;

[Token(Token = "0x20002D0")]
internal sealed class TokenizerStream
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C4B")]
	private int m_countTokens; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C4C")]
	private TokenizerShortBlock m_headTokens; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000C4D")]
	private TokenizerShortBlock m_lastTokens; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000C4E")]
	private TokenizerShortBlock m_currentTokens; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000C4F")]
	private int m_indexTokens; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000C50")]
	private TokenizerStringBlock m_headStrings; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000C51")]
	private TokenizerStringBlock m_currentStrings; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000C52")]
	private int m_indexStrings; //Field offset: 0x48

	[Address(RVA = "0x1333130", Offset = "0x1332330", Length = "0x15C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001738")]
	internal TokenizerStream() { }

	[Address(RVA = "0x1332C00", Offset = "0x1331E00", Length = "0x13C")]
	[CalledBy(Type = typeof(Tokenizer), Member = "GetTokens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenizerStream), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600173A")]
	internal void AddString(string str) { }

	[Address(RVA = "0x1332D40", Offset = "0x1331F40", Length = "0x130")]
	[CalledBy(Type = typeof(Tokenizer), Member = "GetTokens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenizerStream), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001739")]
	internal void AddToken(short token) { }

	[Address(RVA = "0x1332E80", Offset = "0x1332080", Length = "0x8C")]
	[CalledBy(Type = typeof(Parser), Member = "GetRequiredSizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenizerStream), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Parser), Member = "DetermineFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenizerStream)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Parser), Member = "ParseContents", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TokenizerStream), Member = "GetNextToken", ReturnType = typeof(short))]
	[CalledBy(Type = typeof(TokenizerStream), Member = "GoToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600173C")]
	internal short GetNextFullToken() { }

	[Address(RVA = "0x1332F10", Offset = "0x1332110", Length = "0x76")]
	[CalledBy(Type = typeof(Parser), Member = "GetRequiredSizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenizerStream), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Parser), Member = "DetermineFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenizerStream)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Parser), Member = "ParseContents", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TokenizerStream), Member = "ThrowAwayNextString", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TokenizerStream), Member = "GoToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600173E")]
	internal string GetNextString() { }

	[Address(RVA = "0x1332F90", Offset = "0x1332190", Length = "0x18")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TokenizerStream), Member = "GetNextFullToken", ReturnType = typeof(short))]
	[Token(Token = "0x600173D")]
	internal short GetNextToken() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001741")]
	internal int GetTokenCount() { }

	[Address(RVA = "0x1332FB0", Offset = "0x13321B0", Length = "0x7F")]
	[CalledBy(Type = typeof(Parser), Member = "ParseContents", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TokenizerStream), Member = "GetNextFullToken", ReturnType = typeof(short))]
	[Calls(Type = typeof(TokenizerStream), Member = "GetNextString", ReturnType = typeof(string))]
	[Token(Token = "0x6001742")]
	internal void GoToPosition(int position) { }

	[Address(RVA = "0x1333030", Offset = "0x1332230", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600173B")]
	internal void Reset() { }

	[Address(RVA = "0x1333090", Offset = "0x1332290", Length = "0x83")]
	[CalledBy(Type = typeof(Parser), Member = "GetRequiredSizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenizerStream), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001740")]
	internal void TagLastToken(short tag) { }

	[Address(RVA = "0x1333120", Offset = "0x1332320", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TokenizerStream), Member = "GetNextString", ReturnType = typeof(string))]
	[Token(Token = "0x600173F")]
	internal void ThrowAwayNextString() { }

}

