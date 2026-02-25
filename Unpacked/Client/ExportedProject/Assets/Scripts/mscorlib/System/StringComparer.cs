namespace System;

[Token(Token = "0x2000133")]
public abstract class StringComparer : IComparer, IEqualityComparer, IComparer<String>, IEqualityComparer<String>
{
	[Token(Token = "0x4000464")]
	private static readonly CultureAwareComparer s_invariantCulture; //Field offset: 0x0
	[Token(Token = "0x4000465")]
	private static readonly CultureAwareComparer s_invariantCultureIgnoreCase; //Field offset: 0x8
	[Token(Token = "0x4000466")]
	private static readonly OrdinalCaseSensitiveComparer s_ordinal; //Field offset: 0x10
	[Token(Token = "0x4000467")]
	private static readonly OrdinalIgnoreCaseComparer s_ordinalIgnoreCase; //Field offset: 0x18

	[Token(Token = "0x170000A6")]
	public static StringComparer InvariantCultureIgnoreCase
	{
		[Address(RVA = "0x14C2A20", Offset = "0x14C1C20", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60009E2")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170000A7")]
	public static StringComparer Ordinal
	{
		[Address(RVA = "0x14C2AC0", Offset = "0x14C1CC0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60009E3")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170000A8")]
	public static StringComparer OrdinalIgnoreCase
	{
		[Address(RVA = "0x14C2A70", Offset = "0x14C1C70", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60009E4")]
		 get { } //Length: 79
	}

	[Address(RVA = "0x14C2800", Offset = "0x14C1A00", Length = "0x213")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CultureAwareComparer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60009EC")]
	private static StringComparer() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009EB")]
	protected StringComparer() { }

	[Address(RVA = "0x14C2580", Offset = "0x14C1780", Length = "0x155")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60009E5")]
	public override int Compare(object x, object y) { }

	[Token(Token = "0x60009E8")]
	public abstract int Compare(string x, string y) { }

	[Address(RVA = "0x14C26E0", Offset = "0x14C18E0", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60009E6")]
	public override bool Equals(object x, object y) { }

	[Token(Token = "0x60009E9")]
	public abstract bool Equals(string x, string y) { }

	[Address(RVA = "0x14C2A20", Offset = "0x14C1C20", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60009E2")]
	public static StringComparer get_InvariantCultureIgnoreCase() { }

	[Address(RVA = "0x14C2AC0", Offset = "0x14C1CC0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60009E3")]
	public static StringComparer get_Ordinal() { }

	[Address(RVA = "0x14C2A70", Offset = "0x14C1C70", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60009E4")]
	public static StringComparer get_OrdinalIgnoreCase() { }

	[Address(RVA = "0x14C2750", Offset = "0x14C1950", Length = "0xA6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60009E7")]
	public override int GetHashCode(object obj) { }

	[Token(Token = "0x60009EA")]
	public abstract int GetHashCode(string obj) { }

}

