namespace System.Text.RegularExpressions;

[Token(Token = "0x20000E2")]
public class Match : Group
{
	[CompilerGenerated]
	[Token(Token = "0x4000368")]
	private static readonly Match <Empty>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400035F")]
	internal GroupCollection _groupcoll; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000360")]
	internal Regex _regex; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000361")]
	internal int _textbeg; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000362")]
	internal int _textpos; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000363")]
	internal int _textend; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000364")]
	internal int _textstart; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000365")]
	internal Int32[][] _matches; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000366")]
	internal Int32[] _matchcount; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000367")]
	internal bool _balancing; //Field offset: 0x70

	[Token(Token = "0x170000D9")]
	public static Match Empty
	{
		[Address(RVA = "0x17572A0", Offset = "0x17564A0", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x60004C8")]
		 get { } //Length: 78
	}

	[Token(Token = "0x170000DA")]
	public override GroupCollection Groups
	{
		[Address(RVA = "0x17572F0", Offset = "0x17564F0", Length = "0x8C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60004CA")]
		 get { } //Length: 140
	}

	[Address(RVA = "0x1757040", Offset = "0x1756240", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Match), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Regex), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60004D5")]
	private static Match() { }

	[Address(RVA = "0x17570E0", Offset = "0x17562E0", Length = "0x181")]
	[CalledBy(Type = typeof(Match), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MatchSparse), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Regex), typeof(Hashtable), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexRunner), Member = "InitMatch", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004C7")]
	internal Match(Regex regex, int capcount, string text, int begpos, int len, int startpos) { }

	[Address(RVA = "0x1757270", Offset = "0x1756470", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x60004D6")]
	internal Match() { }

	[Address(RVA = "0x1756640", Offset = "0x1755840", Length = "0x1F6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60004CE")]
	internal override void AddMatch(int cap, int start, int len) { }

	[Address(RVA = "0x1756840", Offset = "0x1755A40", Length = "0x141")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004CF")]
	internal override void BalanceMatch(int cap) { }

	[Address(RVA = "0x17572A0", Offset = "0x17564A0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x60004C8")]
	public static Match get_Empty() { }

	[Address(RVA = "0x17572F0", Offset = "0x17564F0", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004CA")]
	public override GroupCollection get_Groups() { }

	[Address(RVA = "0x1756990", Offset = "0x1755B90", Length = "0x193")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ExceptionArgument"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60004CC")]
	internal override ReadOnlySpan<Char> GroupToStringImpl(int groupnum) { }

	[Address(RVA = "0x1756B30", Offset = "0x1755D30", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60004D1")]
	internal override bool IsMatched(int cap) { }

	[Address(RVA = "0x1756BB0", Offset = "0x1755DB0", Length = "0x45")]
	[CalledBy(Type = typeof(RegexReplacement), Member = "ReplacementImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(Match)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexReplacement), Member = "ReplacementImplRTL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.String>), typeof(Match)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexReplacement), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Regex), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004CD")]
	internal ReadOnlySpan<Char> LastGroupToStringImpl() { }

	[Address(RVA = "0x1756C00", Offset = "0x1755E00", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60004D2")]
	internal override int MatchIndex(int cap) { }

	[Address(RVA = "0x1756C90", Offset = "0x1755E90", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60004D3")]
	internal override int MatchLength(int cap) { }

	[Address(RVA = "0x1756D20", Offset = "0x1755F20", Length = "0x4E")]
	[CalledBy(Type = typeof(RegexReplacement), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Regex), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Regex), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Match))]
	[Token(Token = "0x60004CB")]
	public Match NextMatch() { }

	[Address(RVA = "0x1756D70", Offset = "0x1755F70", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60004D0")]
	internal override void RemoveMatch(int cap) { }

	[Address(RVA = "0x1756DA0", Offset = "0x1755FA0", Length = "0xAB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60004C9")]
	internal override void Reset(Regex regex, string text, int textbeg, int textend, int textstart) { }

	[Address(RVA = "0x1756E50", Offset = "0x1756050", Length = "0x1EC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004D4")]
	internal override void Tidy(int textpos) { }

}

