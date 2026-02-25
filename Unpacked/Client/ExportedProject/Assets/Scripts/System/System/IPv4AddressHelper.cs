namespace System;

[Token(Token = "0x20000B3")]
internal static class IPv4AddressHelper
{

	[Address(RVA = "0x1733D60", Offset = "0x1732F60", Length = "0x187")]
	[CalledBy(Type = typeof(IPv6AddressHelper), Member = "IsValidStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(IPv6AddressHelper), Member = "InternalIsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Int32&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(ushort), typeof(ParsingError&), typeof(Flags&), typeof(UriParser), typeof(String&)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(IPv4AddressHelper), Member = "ParseNonCanonical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Int32&), typeof(bool)}, ReturnType = typeof(long))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000365")]
	internal static bool IsValid(Char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile, bool unknownScheme) { }

	[Address(RVA = "0x1733C20", Offset = "0x1732E20", Length = "0x13C")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000367")]
	internal static bool IsValidCanonical(Char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile) { }

	[Address(RVA = "0x17345B0", Offset = "0x17337B0", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(IPv4AddressHelper), Member = "ParseNonCanonical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Int32&), typeof(bool)}, ReturnType = typeof(long))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600036A")]
	private static bool Parse(string name, Byte* numbers, int start, int end) { }

	[Address(RVA = "0x17341B0", Offset = "0x17333B0", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000366")]
	private static bool ParseCanonical(ReadOnlySpan<Char> name, Byte* numbers, int start, int end) { }

	[Address(RVA = "0x1733EF0", Offset = "0x17330F0", Length = "0x2B0")]
	[CalledBy(Type = typeof(Uri), Member = "CreateHostStringHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(ushort), typeof(Flags&), typeof(String&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(IPv4AddressHelper), Member = "ParseNonCanonical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Int32&), typeof(bool)}, ReturnType = typeof(long))]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(byte), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Span`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000369")]
	internal static string ParseCanonicalName(string str, int start, int end, ref bool isLoopback) { }

	[Address(RVA = "0x1734240", Offset = "0x1733440", Length = "0xC7")]
	[CalledBy(Type = typeof(IPv6AddressHelper), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(UInt16*), typeof(int), typeof(String&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000364")]
	internal static int ParseHostNumber(ReadOnlySpan<Char> str, int start, int end) { }

	[Address(RVA = "0x1734310", Offset = "0x1733510", Length = "0x299")]
	[CalledBy(Type = typeof(IPv4AddressHelper), Member = "IsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Int32&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(IPv4AddressHelper), Member = "ParseCanonicalName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Boolean&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(IPv4AddressHelper), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte*), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(IPAddressParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool)}, ReturnType = typeof(IPAddress))]
	[CalledBy(Type = typeof(IPAddressParser), Member = "Ipv4StringToAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(Int64&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000368")]
	internal static long ParseNonCanonical(Char* name, int start, ref int end, bool notImplicitFile) { }

}

