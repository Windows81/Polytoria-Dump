namespace System.Text.RegularExpressions;

[Token(Token = "0x20000F7")]
internal sealed class RegexReplacement
{
	[Token(Token = "0x4000428")]
	private const int Specials = 4; //Field offset: 0x0
	[Token(Token = "0x4000429")]
	public const int LeftPortion = -1; //Field offset: 0x0
	[Token(Token = "0x400042A")]
	public const int RightPortion = -2; //Field offset: 0x0
	[Token(Token = "0x400042B")]
	public const int LastGroup = -3; //Field offset: 0x0
	[Token(Token = "0x400042C")]
	public const int WholeString = -4; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400042D")]
	private readonly List<String> _strings; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400042E")]
	private readonly List<Int32> _rules; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400042F")]
	private readonly string <Pattern>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x170000E6")]
	public string Pattern
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005E9")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1775E40", Offset = "0x1775040", Length = "0x45E")]
	[CalledBy(Type = typeof(RegexParser), Member = "ParseReplacement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Hashtable), typeof(int), typeof(Hashtable), typeof(RegexOptions)}, ReturnType = typeof(RegexReplacement))]
	[CalledBy(Type = typeof(RegexReplacement), Member = "GetOrCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.WeakReference`1<System.Text.RegularExpressions.RegexReplacement>), typeof(string), typeof(Hashtable), typeof(int), typeof(Hashtable), typeof(RegexOptions)}, ReturnType = typeof(RegexReplacement))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = "System.Text.StringBuilderCache", Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009740")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = "System.Text.StringBuilderCache", Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60005E7")]
	public RegexReplacement(string rep, RegexNode concat, Hashtable _caps) { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60005E9")]
	public string get_Pattern() { }

	[Address(RVA = "0x1775180", Offset = "0x1774380", Length = "0x233")]
	[CalledBy(Type = typeof(Regex), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Regex), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(RegexOptions), typeof(TimeSpan)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Regex), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Regex), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexReplacement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexNode), typeof(Hashtable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexParser), Member = "ScanReplacement", ReturnType = typeof(RegexNode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RegexParser), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WeakReference`1), Member = "SetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WeakReference`1), Member = "TryGetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60005E8")]
	public static RegexReplacement GetOrCreate(WeakReference<RegexReplacement> replRef, string replacement, Hashtable caps, int capsize, Hashtable capnames, RegexOptions roptions) { }

	[Address(RVA = "0x17753C0", Offset = "0x17745C0", Length = "0x6DB")]
	[CalledBy(Type = typeof(Regex), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Regex), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(RegexOptions), typeof(TimeSpan)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Regex), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Regex), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Capture), Member = "GetLeftSubstring", ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(Match), Member = "NextMatch", ReturnType = typeof(Match))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = "System.Text.StringBuilderCache", Member = "GetStringAndRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Match), Member = "LastGroupToStringImpl", ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Capture), Member = "GetRightSubstring", ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = "System.Text.StringBuilderCache", Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Group), Member = "get_Success", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Regex), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(Match))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.ReadOnlySpan`1<System.Char>), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60005EC")]
	public string Replace(Regex regex, string input, int count, int startat) { }

	[Address(RVA = "0x1775C80", Offset = "0x1774E80", Length = "0x1BC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Capture), Member = "GetLeftSubstring", ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
	[Calls(Type = typeof(Capture), Member = "GetRightSubstring", ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
	[Calls(Type = typeof(Match), Member = "LastGroupToStringImpl", ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005EA")]
	private void ReplacementImpl(StringBuilder sb, Match match) { }

	[Address(RVA = "0x1775AA0", Offset = "0x1774CA0", Length = "0x1DE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Capture), Member = "GetLeftSubstring", ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
	[Calls(Type = typeof(System.ReadOnlySpan`1<System.Char>), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Capture), Member = "GetRightSubstring", ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
	[Calls(Type = typeof(Match), Member = "LastGroupToStringImpl", ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005EB")]
	private void ReplacementImplRTL(List<String> al, Match match) { }

}

