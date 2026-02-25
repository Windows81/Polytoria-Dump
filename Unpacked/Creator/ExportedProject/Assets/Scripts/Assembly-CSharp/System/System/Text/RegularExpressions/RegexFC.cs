namespace System.Text.RegularExpressions;

[Token(Token = "0x20000F0")]
internal sealed class RegexFC
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003F2")]
	private RegexCharClass _cc; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003F3")]
	public bool _nullable; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x19")]
	[Token(Token = "0x40003F4")]
	private bool <CaseInsensitive>k__BackingField; //Field offset: 0x19

	[Token(Token = "0x170000DF")]
	public private bool CaseInsensitive
	{
		[Address(RVA = "0x5610F0", Offset = "0x5602F0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000551")]
		 get { } //Length: 5
		[Address(RVA = "0x5611D0", Offset = "0x5603D0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000552")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x1769BD0", Offset = "0x1768DD0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RegexCharClass), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600054D")]
	public RegexFC(bool nullable) { }

	[Address(RVA = "0x1769AD0", Offset = "0x1768CD0", Length = "0xF9")]
	[CalledBy(Type = typeof(RegexFCD), Member = "CalculateFC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RegexNode), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RegexCharClass), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RegexCharClass), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600054E")]
	public RegexFC(char ch, bool not, bool nullable, bool caseInsensitive) { }

	[Address(RVA = "0x1769C50", Offset = "0x1768E50", Length = "0x94")]
	[CalledBy(Type = typeof(RegexFCD), Member = "CalculateFC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RegexNode), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RegexCharClass), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(RegexCharClass))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600054F")]
	public RegexFC(string charClass, bool nullable, bool caseInsensitive) { }

	[Address(RVA = "0x17699D0", Offset = "0x1768BD0", Length = "0xB6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RegexCharClass), Member = "get_CanMerge", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexCharClass), Member = "AddCharClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexCharClass)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000550")]
	public bool AddFC(RegexFC fc, bool concatenate) { }

	[Address(RVA = "0x5610F0", Offset = "0x5602F0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000551")]
	public bool get_CaseInsensitive() { }

	[Address(RVA = "0x1769A90", Offset = "0x1768C90", Length = "0x3A")]
	[CalledBy(Type = typeof(RegexFCD), Member = "FirstChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexTree)}, ReturnType = typeof(System.Nullable`1<System.Text.RegularExpressions.RegexPrefix>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RegexCharClass), Member = "AddLowercase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexCharClass), Member = "ToStringClass", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000553")]
	public string GetFirstChars(CultureInfo culture) { }

	[Address(RVA = "0x5611D0", Offset = "0x5603D0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000552")]
	private void set_CaseInsensitive(bool value) { }

}

