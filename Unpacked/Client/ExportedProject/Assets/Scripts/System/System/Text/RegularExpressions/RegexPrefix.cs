namespace System.Text.RegularExpressions;

[IsReadOnly]
[Token(Token = "0x20000F6")]
internal struct RegexPrefix
{
	[CompilerGenerated]
	[Token(Token = "0x4000426")]
	private static readonly RegexPrefix <Empty>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000425")]
	private readonly bool <CaseInsensitive>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000427")]
	private readonly string <Prefix>k__BackingField; //Field offset: 0x8

	[Token(Token = "0x170000E3")]
	internal bool CaseInsensitive
	{
		[Address(RVA = "0x3B87B0", Offset = "0x3B79B0", Length = "0x4")]
		[CallerCount(Count = 29)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005E3")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x170000E4")]
	internal static RegexPrefix Empty
	{
		[Address(RVA = "0x1775120", Offset = "0x1774320", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x60005E4")]
		internal get { } //Length: 90
	}

	[Token(Token = "0x170000E5")]
	internal string Prefix
	{
		[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60005E5")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x1775060", Offset = "0x1774260", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60005E6")]
	private static RegexPrefix() { }

	[Address(RVA = "0x17750F0", Offset = "0x17742F0", Length = "0x2C")]
	[CalledBy(Type = typeof(RegexFCD), Member = "FirstChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexTree)}, ReturnType = typeof(System.Nullable`1<System.Text.RegularExpressions.RegexPrefix>))]
	[CalledBy(Type = typeof(RegexFCD), Member = "Prefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexTree)}, ReturnType = typeof(RegexPrefix))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60005E2")]
	internal RegexPrefix(string prefix, bool ci) { }

	[Address(RVA = "0x3B87B0", Offset = "0x3B79B0", Length = "0x4")]
	[CallerCount(Count = 29)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60005E3")]
	internal bool get_CaseInsensitive() { }

	[Address(RVA = "0x1775120", Offset = "0x1774320", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x60005E4")]
	internal static RegexPrefix get_Empty() { }

	[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60005E5")]
	internal string get_Prefix() { }

}

