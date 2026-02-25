namespace System.Text.RegularExpressions;

[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[Token(Token = "0x20000FB")]
internal struct RegexWriter
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400044A")]
	private ValueListBuilder<Int32> _emitted; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400044B")]
	private ValueListBuilder<Int32> _intStack; //Field offset: 0x20
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400044C")]
	private readonly Dictionary<String, Int32> _stringHash; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400044D")]
	private readonly List<String> _stringTable; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400044E")]
	private Hashtable _caps; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400044F")]
	private int _trackCount; //Field offset: 0x58

	[Address(RVA = "0x1778B00", Offset = "0x1777D00", Length = "0x13C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000609")]
	private RegexWriter(Span<Int32> emittedSpan, Span<Int32> intStackSpan) { }

	[Address(RVA = "0x17774F0", Offset = "0x17766F0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1812EC330")]
	[Token(Token = "0x600060B")]
	public void Dispose() { }

	[Address(RVA = "0x1777FA0", Offset = "0x17771A0", Length = "0x56")]
	[CalledBy(Type = typeof(RegexWriter), Member = "EmitFragment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RegexNode), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RegexCode), Member = "OpcodeBacktracks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801AA870")]
	[Token(Token = "0x600060E")]
	private void Emit(int op) { }

	[Address(RVA = "0x1777F20", Offset = "0x1777120", Length = "0x74")]
	[CalledBy(Type = typeof(RegexWriter), Member = "EmitFragment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RegexNode), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RegexCode), Member = "OpcodeBacktracks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801AA870")]
	[Token(Token = "0x600060F")]
	private void Emit(int op, int opd1) { }

	[Address(RVA = "0x1778000", Offset = "0x1777200", Length = "0x92")]
	[CalledBy(Type = typeof(RegexWriter), Member = "EmitFragment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RegexNode), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RegexCode), Member = "OpcodeBacktracks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801AA870")]
	[Token(Token = "0x6000610")]
	private void Emit(int op, int opd1, int opd2) { }

	[Address(RVA = "0x1777540", Offset = "0x1776740", Length = "0x938")]
	[CalledBy(Type = typeof(RegexWriter), Member = "RegexCodeFromRegexTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexTree)}, ReturnType = typeof(RegexCode))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ValueListBuilder`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(RegexCode), Member = "OpcodeBacktracks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexWriter), Member = "PatchJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801AA870")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexWriter), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexWriter), Member = "MapCapnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RegexWriter), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexWriter), Member = "StringCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RegexWriter), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000613")]
	private void EmitFragment(int nodetype, RegexNode node, int curIndex) { }

	[Address(RVA = "0x17780A0", Offset = "0x17772A0", Length = "0x94")]
	[CalledBy(Type = typeof(RegexWriter), Member = "EmitFragment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RegexNode), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000612")]
	private int MapCapnum(int capnum) { }

	[Address(RVA = "0x1778140", Offset = "0x1777340", Length = "0x57")]
	[CalledBy(Type = typeof(RegexWriter), Member = "EmitFragment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RegexNode), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ValueListBuilder`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[Token(Token = "0x600060D")]
	private void PatchJump(int offset, int jumpDest) { }

	[Address(RVA = "0x17781A0", Offset = "0x17773A0", Length = "0x60E")]
	[CalledBy(Type = typeof(RegexWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexTree)}, ReturnType = typeof(RegexCode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RegexFCD), Member = "FirstChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexTree)}, ReturnType = typeof(System.Nullable`1<System.Text.RegularExpressions.RegexPrefix>))]
	[Calls(Type = typeof(ReadOnlySpan`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(RegexFCD), Member = "Anchors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexTree)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RegexBoyerMoore), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(CultureInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RegexFCD), Member = "Prefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexTree)}, ReturnType = typeof(RegexPrefix))]
	[Calls(Type = typeof(ValueListBuilder`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[Calls(Type = typeof(RegexCode), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(System.Collections.Generic.List`1<System.String>), typeof(int), typeof(Hashtable), typeof(int), typeof(RegexBoyerMoore), typeof(System.Nullable`1<System.Text.RegularExpressions.RegexPrefix>), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(RegexWriter), Member = "EmitFragment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RegexNode), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801AA870")]
	[Calls(Type = typeof(RegexCode), Member = "OpcodeBacktracks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600060C")]
	public RegexCode RegexCodeFromRegexTree(RegexTree tree) { }

	[Address(RVA = "0x17787B0", Offset = "0x17779B0", Length = "0xE5")]
	[CalledBy(Type = typeof(RegexWriter), Member = "EmitFragment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RegexNode), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000611")]
	private int StringCode(string str) { }

	[Address(RVA = "0x17788A0", Offset = "0x1777AA0", Length = "0x258")]
	[CalledBy(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexWriter), Member = "RegexCodeFromRegexTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexTree)}, ReturnType = typeof(RegexCode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1812EC330")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600060A")]
	public static RegexCode Write(RegexTree tree) { }

}

