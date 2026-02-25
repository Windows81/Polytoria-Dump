namespace System.Text.RegularExpressions;

[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[Token(Token = "0x20000EF")]
internal struct RegexFCD
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003ED")]
	private readonly List<RegexFC> _fcStack; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40003EE")]
	private ValueListBuilder<Int32> _intStack; //Field offset: 0x8
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40003EF")]
	private bool _skipAllChildren; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x40003F0")]
	private bool _skipchild; //Field offset: 0x29
	[FieldOffset(Offset = "0x2A")]
	[Token(Token = "0x40003F1")]
	private bool _failed; //Field offset: 0x2A

	[Address(RVA = "0x1761380", Offset = "0x1760580", Length = "0xC6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600053D")]
	private RegexFCD(Span<Int32> intStack) { }

	[Address(RVA = "0x1760060", Offset = "0x175F260", Length = "0x60")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000541")]
	private static int AnchorFromType(int type) { }

	[Address(RVA = "0x17600E0", Offset = "0x175F2E0", Length = "0x15C")]
	[CalledBy(Type = typeof(RegexWriter), Member = "RegexCodeFromRegexTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexTree)}, ReturnType = typeof(RegexCode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RegexNode), Member = "ChildCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(RegexNode), Member = "Child", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RegexNode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000540")]
	public static int Anchors(RegexTree tree) { }

	[Address(RVA = "0x17602B0", Offset = "0x175F4B0", Length = "0x34C")]
	[CalledBy(Type = typeof(RegexFCD), Member = "RegexFCFromRegexTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexTree)}, ReturnType = typeof(RegexFC))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RegexFC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexFCD), Member = "PushFC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexFC)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181760723")]
	[Calls(Type = typeof(RegexFC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600054C")]
	private void CalculateFC(int NodeType, RegexNode node, int CurIndex) { }

	[Address(RVA = "0x1760870", Offset = "0x175FA70", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1812EC330")]
	[Token(Token = "0x6000549")]
	public void Dispose() { }

	[Address(RVA = "0x17608B0", Offset = "0x175FAB0", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000546")]
	private bool FCIsEmpty() { }

	[Address(RVA = "0x17608F0", Offset = "0x175FAF0", Length = "0x291")]
	[CalledBy(Type = typeof(RegexWriter), Member = "RegexCodeFromRegexTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexTree)}, ReturnType = typeof(RegexCode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1812EC330")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexFCD), Member = "RegexFCFromRegexTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexTree)}, ReturnType = typeof(RegexFC))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(RegexFC), Member = "GetFirstChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RegexPrefix), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600053E")]
	public static Nullable<RegexPrefix> FirstChars(RegexTree t) { }

	[Address(RVA = "0x1760B90", Offset = "0x175FD90", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000543")]
	private bool IntIsEmpty() { }

	[Address(RVA = "0x1760BD0", Offset = "0x175FDD0", Length = "0xAC")]
	[CalledBy(Type = typeof(RegexFCD), Member = "RegexFCFromRegexTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexTree)}, ReturnType = typeof(RegexFC))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000547")]
	private RegexFC PopFC() { }

	[Address(RVA = "0x1760C80", Offset = "0x175FE80", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000544")]
	private int PopInt() { }

	[Address(RVA = "0x1760CD0", Offset = "0x175FED0", Length = "0x230")]
	[CalledBy(Type = typeof(RegexWriter), Member = "RegexCodeFromRegexTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexTree)}, ReturnType = typeof(RegexCode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RegexNode), Member = "ChildCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(RegexNode), Member = "Child", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RegexNode))]
	[Calls(Type = typeof(string), Member = "PadRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RegexPrefix), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600053F")]
	public static RegexPrefix Prefix(RegexTree tree) { }

	[Address(RVA = "0x1760F40", Offset = "0x1760140", Length = "0xA8")]
	[CalledBy(Type = typeof(RegexFCD), Member = "CalculateFC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RegexNode), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000545")]
	private void PushFC(RegexFC fc) { }

	[Address(RVA = "0x1760FF0", Offset = "0x17601F0", Length = "0xAC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000542")]
	private void PushInt(int i) { }

	[Address(RVA = "0x17610A0", Offset = "0x17602A0", Length = "0x274")]
	[CalledBy(Type = typeof(RegexFCD), Member = "FirstChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexTree)}, ReturnType = typeof(System.Nullable`1<System.Text.RegularExpressions.RegexPrefix>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RegexFCD), Member = "CalculateFC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RegexNode), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(RegexFCD), Member = "PopFC", ReturnType = typeof(RegexFC))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600054A")]
	private RegexFC RegexFCFromRegexTree(RegexTree tree) { }

	[Address(RVA = "0x170EF10", Offset = "0x170E110", Length = "0x5")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600054B")]
	private void SkipChild() { }

	[Address(RVA = "0x1761320", Offset = "0x1760520", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000548")]
	private RegexFC TopFC() { }

}

