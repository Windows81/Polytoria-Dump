namespace System;

[Token(Token = "0x20000CE")]
internal class DomainNameHelper
{

	[Address(RVA = "0x174E9D0", Offset = "0x174DBD0", Length = "0x25C")]
	[CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelperHandleDnsIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(int), typeof(int), typeof(bool), typeof(bool), typeof(UriParser), typeof(string), typeof(Flags&), typeof(Boolean&), typeof(String&), typeof(ParsingError&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DomainNameHelper), Member = "IdnEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(Boolean&), typeof(String&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IdnMapping), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(IdnMapping), Member = "GetUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600043F")]
	internal static string IdnEquivalent(Char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn) { }

	[Address(RVA = "0x174EC30", Offset = "0x174DE30", Length = "0x17D")]
	[CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelperHandleAnyHostIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(bool), typeof(bool), typeof(UriParser), typeof(Flags&), typeof(String&), typeof(ParsingError&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DomainNameHelper), Member = "IdnEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(IdnMapping), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Uri), Member = "StripBidiControlCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(IdnMapping), Member = "GetAscii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000440")]
	internal static string IdnEquivalent(Char* hostname, int start, int end, ref bool allAscii, ref string bidiStrippedHost) { }

	[Address(RVA = "0x174EDB0", Offset = "0x174DFB0", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000445")]
	private static bool IsASCIILetterOrDigit(char character, ref bool notCanonical) { }

	[Address(RVA = "0x174EDE0", Offset = "0x174DFE0", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000441")]
	private static bool IsIdnAce(string input, int index) { }

	[Address(RVA = "0x174EE60", Offset = "0x174E060", Length = "0x30")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000442")]
	private static bool IsIdnAce(Char* input, int index) { }

	[Address(RVA = "0x174F0A0", Offset = "0x174E2A0", Length = "0x161")]
	[CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(ushort), typeof(ParsingError&), typeof(Flags&), typeof(UriParser), typeof(String&)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600043D")]
	internal static bool IsValid(Char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile) { }

	[Address(RVA = "0x174EE90", Offset = "0x174E090", Length = "0x1CF")]
	[CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(ushort), typeof(ParsingError&), typeof(Flags&), typeof(UriParser), typeof(String&)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600043E")]
	internal static bool IsValidByIri(Char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile) { }

	[Address(RVA = "0x174F060", Offset = "0x174E260", Length = "0x35")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000446")]
	private static bool IsValidDomainLabelCharacter(char character, ref bool notCanonical) { }

	[Address(RVA = "0x174F210", Offset = "0x174E410", Length = "0x17D")]
	[CalledBy(Type = typeof(Uri), Member = "CreateHostStringHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(ushort), typeof(Flags&), typeof(String&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600043C")]
	internal static string ParseCanonicalName(string str, int start, int end, ref bool loopback) { }

	[Address(RVA = "0x174F390", Offset = "0x174E590", Length = "0xA6")]
	[CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelperHandleDnsIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(int), typeof(int), typeof(bool), typeof(bool), typeof(UriParser), typeof(string), typeof(Flags&), typeof(Boolean&), typeof(String&), typeof(ParsingError&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IdnMapping), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(IdnMapping), Member = "GetUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DomainNameHelper), Member = "UnicodeEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000443")]
	internal static string UnicodeEquivalent(string idnHost, Char* hostname, int start, int end) { }

	[Address(RVA = "0x174F440", Offset = "0x174E640", Length = "0x462")]
	[CalledBy(Type = typeof(Uri), Member = "ReCreateParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(ushort), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(ushort), typeof(ParsingError&), typeof(Flags&), typeof(UriParser), typeof(String&)}, ReturnType = typeof(ushort))]
	[CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelperHandleAnyHostIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(bool), typeof(bool), typeof(UriParser), typeof(Flags&), typeof(String&), typeof(ParsingError&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DomainNameHelper), Member = "UnicodeEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(IdnMapping), Member = "GetUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(IdnMapping), Member = "GetAscii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(IdnMapping), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "StripBidiControlCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000444")]
	internal static string UnicodeEquivalent(Char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn) { }

}

