namespace System.Text.RegularExpressions;

[Token(Token = "0x20000E3")]
internal class MatchSparse : Match
{
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000369")]
	internal readonly Hashtable _caps; //Field offset: 0x78

	[Token(Token = "0x170000DB")]
	public virtual GroupCollection Groups
	{
		[Address(RVA = "0x17565A0", Offset = "0x17557A0", Length = "0x97")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60004D8")]
		 get { } //Length: 151
	}

	[Address(RVA = "0x17564F0", Offset = "0x17556F0", Length = "0xAF")]
	[CalledBy(Type = typeof(RegexRunner), Member = "InitMatch", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Match), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Regex), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60004D7")]
	internal MatchSparse(Regex regex, Hashtable caps, int capcount, string text, int begpos, int len, int startpos) { }

	[Address(RVA = "0x17565A0", Offset = "0x17557A0", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004D8")]
	public virtual GroupCollection get_Groups() { }

}

