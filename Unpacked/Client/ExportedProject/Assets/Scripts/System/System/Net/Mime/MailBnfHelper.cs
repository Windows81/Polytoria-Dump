namespace System.Net.Mime;

[Token(Token = "0x2000306")]
internal static class MailBnfHelper
{
	[Token(Token = "0x4000E35")]
	internal static readonly Boolean[] Atext; //Field offset: 0x0
	[Token(Token = "0x4000E36")]
	internal static readonly Boolean[] Qtext; //Field offset: 0x8
	[Token(Token = "0x4000E37")]
	internal static readonly Boolean[] Dtext; //Field offset: 0x10
	[Token(Token = "0x4000E38")]
	internal static readonly Boolean[] Ftext; //Field offset: 0x18
	[Token(Token = "0x4000E39")]
	internal static readonly Boolean[] Ttext; //Field offset: 0x20
	[Token(Token = "0x4000E3A")]
	internal static readonly Boolean[] Ctext; //Field offset: 0x28
	[Token(Token = "0x4000E3B")]
	internal static readonly int Ascii7bitMaxValue; //Field offset: 0x30
	[Token(Token = "0x4000E3C")]
	internal static readonly char Quote; //Field offset: 0x34
	[Token(Token = "0x4000E3D")]
	internal static readonly char Space; //Field offset: 0x36
	[Token(Token = "0x4000E3E")]
	internal static readonly char Tab; //Field offset: 0x38
	[Token(Token = "0x4000E3F")]
	internal static readonly char CR; //Field offset: 0x3A
	[Token(Token = "0x4000E40")]
	internal static readonly char LF; //Field offset: 0x3C
	[Token(Token = "0x4000E41")]
	internal static readonly char StartComment; //Field offset: 0x3E
	[Token(Token = "0x4000E42")]
	internal static readonly char EndComment; //Field offset: 0x40
	[Token(Token = "0x4000E43")]
	internal static readonly char Backslash; //Field offset: 0x42
	[Token(Token = "0x4000E44")]
	internal static readonly char At; //Field offset: 0x44
	[Token(Token = "0x4000E45")]
	internal static readonly char EndAngleBracket; //Field offset: 0x46
	[Token(Token = "0x4000E46")]
	internal static readonly char StartAngleBracket; //Field offset: 0x48
	[Token(Token = "0x4000E47")]
	internal static readonly char StartSquareBracket; //Field offset: 0x4A
	[Token(Token = "0x4000E48")]
	internal static readonly char EndSquareBracket; //Field offset: 0x4C
	[Token(Token = "0x4000E49")]
	internal static readonly char Comma; //Field offset: 0x4E
	[Token(Token = "0x4000E4A")]
	internal static readonly char Dot; //Field offset: 0x50
	[Token(Token = "0x4000E4B")]
	private static readonly Char[] s_colonSeparator; //Field offset: 0x58
	[Token(Token = "0x4000E4C")]
	private static String[] s_months; //Field offset: 0x60

	[Address(RVA = "0x171AC60", Offset = "0x1719E60", Length = "0x9B7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MailBnfHelper), Member = "CreateCharactersAllowedInAtoms", ReturnType = typeof(Boolean[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60013AB")]
	private static MailBnfHelper() { }

	[Address(RVA = "0x171A540", Offset = "0x1719740", Length = "0x1AE")]
	[CalledBy(Type = typeof(MailBnfHelper), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60013A4")]
	private static Boolean[] CreateCharactersAllowedInAtoms() { }

	[Address(RVA = "0x171A6F0", Offset = "0x17198F0", Length = "0x105")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60013A9")]
	private static Boolean[] CreateCharactersAllowedInComments() { }

	[Address(RVA = "0x171A800", Offset = "0x1719A00", Length = "0xE5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60013A6")]
	private static Boolean[] CreateCharactersAllowedInDomainLiterals() { }

	[Address(RVA = "0x171A8F0", Offset = "0x1719AF0", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60013A7")]
	private static Boolean[] CreateCharactersAllowedInHeaderNames() { }

	[Address(RVA = "0x171A980", Offset = "0x1719B80", Length = "0xE5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60013A5")]
	private static Boolean[] CreateCharactersAllowedInQuotedStrings() { }

	[Address(RVA = "0x171AA70", Offset = "0x1719C70", Length = "0x114")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60013A8")]
	private static Boolean[] CreateCharactersAllowedInTokens() { }

	[Address(RVA = "0x171AB90", Offset = "0x1719D90", Length = "0xC3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013AA")]
	internal static bool IsAllowedWhiteSpace(char c) { }

}

