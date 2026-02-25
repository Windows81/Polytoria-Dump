namespace System;

[Token(Token = "0x20000B4")]
internal static class IPv6AddressHelper
{

	[Address(RVA = "0x1734640", Offset = "0x1733840", Length = "0xCC")]
	[CalledBy(Type = typeof(IPAddressParser), Member = "IPv6AddressToStringHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt16[]), typeof(uint)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(IPAddressParser), Member = "AppendSections", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt16[]), typeof(int), typeof(int), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600036B")]
	internal static ValueTuple<Int32, Int32> FindCompressionRange(ReadOnlySpan<UInt16> numbers) { }

	[Address(RVA = "0x1734710", Offset = "0x1733910", Length = "0x2B7")]
	[CalledBy(Type = typeof(IPv6AddressHelper), Member = "IsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Uri), Member = "IsHexDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(IPv4AddressHelper), Member = "IsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Int32&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000371")]
	private static bool InternalIsValid(Char* name, int start, ref int end, bool validateStrictAddress) { }

	[Address(RVA = "0x17349D0", Offset = "0x1733BD0", Length = "0xD9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000370")]
	private static bool IsLoopback(ReadOnlySpan<UInt16> numbers) { }

	[Address(RVA = "0x1734E10", Offset = "0x1734010", Length = "0x1A")]
	[CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(ushort), typeof(ParsingError&), typeof(Flags&), typeof(UriParser), typeof(String&)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IPv6AddressHelper), Member = "InternalIsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Int32&), typeof(bool)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000372")]
	internal static bool IsValid(Char* name, int start, ref int end) { }

	[Address(RVA = "0x1734AB0", Offset = "0x1733CB0", Length = "0x35C")]
	[CalledBy(Type = typeof(IPAddressParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool)}, ReturnType = typeof(IPAddress))]
	[CalledBy(Type = typeof(IPAddressParser), Member = "Ipv6StringToAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(UInt16*), typeof(int), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Uri), Member = "IsHexDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(IPv4AddressHelper), Member = "IsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Int32&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600036D")]
	internal static bool IsValidStrict(Char* name, int start, ref int end) { }

	[Address(RVA = "0x1735690", Offset = "0x1734890", Length = "0x480")]
	[CalledBy(Type = typeof(IPv6AddressHelper), Member = "ParseCanonicalName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(Boolean&), typeof(String&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(IPAddressParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool)}, ReturnType = typeof(IPAddress))]
	[CalledBy(Type = typeof(IPAddressParser), Member = "Ipv6StringToAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(UInt16*), typeof(int), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18018B7B0")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(IPv4AddressHelper), Member = "ParseHostNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Uri), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600036E")]
	internal static void Parse(ReadOnlySpan<Char> address, UInt16* numbers, int start, ref string scopeId) { }

	[Address(RVA = "0x1734E30", Offset = "0x1734030", Length = "0x85B")]
	[CalledBy(Type = typeof(Uri), Member = "CreateHostStringHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(ushort), typeof(Flags&), typeof(String&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(IPv6AddressHelper), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(UInt16*), typeof(int), typeof(String&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Span`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(ushort), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(int), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600036F")]
	internal static string ParseCanonicalName(string str, int start, ref bool isLoopback, ref string scopeId) { }

	[Address(RVA = "0x1735B20", Offset = "0x1734D20", Length = "0xD3")]
	[CalledBy(Type = typeof(IPAddressParser), Member = "IPv6AddressToStringHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt16[]), typeof(uint)}, ReturnType = typeof(StringBuilder))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600036C")]
	internal static bool ShouldHaveIpv4Embedded(ReadOnlySpan<UInt16> numbers) { }

}

