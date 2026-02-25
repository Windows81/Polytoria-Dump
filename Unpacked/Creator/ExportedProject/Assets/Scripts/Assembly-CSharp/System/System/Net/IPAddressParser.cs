namespace System.Net;

[Token(Token = "0x200020B")]
internal class IPAddressParser
{

	[Address(RVA = "0x17C1510", Offset = "0x17C0710", Length = "0xAE")]
	[CalledBy(Type = typeof(IPAddressParser), Member = "IPv6AddressToStringHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt16[]), typeof(uint)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(IPAddressParser), Member = "AppendSections", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt16[]), typeof(int), typeof(int), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D19")]
	private static void AppendHex(ushort value, StringBuilder buffer) { }

	[Address(RVA = "0x17C15C0", Offset = "0x17C07C0", Length = "0x1DB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(IPv6AddressHelper), Member = "FindCompressionRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.UInt16>)}, ReturnType = typeof(System.ValueTuple`2<System.Int32, System.Int32>))]
	[Calls(Type = typeof(IPAddressParser), Member = "AppendHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D18")]
	private static void AppendSections(UInt16[] address, int fromInclusive, int toExclusive, StringBuilder buffer) { }

	[Address(RVA = "0x17C17A0", Offset = "0x17C09A0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D1A")]
	private static uint ExtractIPv4Address(UInt16[] address) { }

	[Address(RVA = "0x17C17F0", Offset = "0x17C09F0", Length = "0xB8")]
	[CalledBy(Type = typeof(IPAddressParser), Member = "IPv4AddressToStringHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Char*)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "DivRem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D15")]
	private static void FormatIPv4AddressNumber(int number, Char* addressString, ref int offset) { }

	[Address(RVA = "0x17C1B00", Offset = "0x17C0D00", Length = "0x5D")]
	[CalledBy(Type = typeof(IPAddress), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IPAddressParser), Member = "IPv4AddressToStringHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Char*)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000D10")]
	internal static string IPv4AddressToString(uint address) { }

	[Address(RVA = "0x17C1B60", Offset = "0x17C0D60", Length = "0x6A")]
	[CalledBy(Type = typeof(IPAddressParser), Member = "IPv6AddressToStringHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt16[]), typeof(uint)}, ReturnType = typeof(StringBuilder))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IPAddressParser), Member = "IPv4AddressToStringHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Char*)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D11")]
	internal static void IPv4AddressToString(uint address, StringBuilder destination) { }

	[Address(RVA = "0x17C18B0", Offset = "0x17C0AB0", Length = "0x243")]
	[CalledBy(Type = typeof(IPAddressParser), Member = "IPv4AddressToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(IPAddressParser), Member = "IPv4AddressToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(IPAddressParser), Member = "FormatIPv4AddressNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Char*), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "DivRem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D12")]
	private static int IPv4AddressToStringHelper(uint address, Char* addressString) { }

	[Address(RVA = "0x17C20A0", Offset = "0x17C12A0", Length = "0xDF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(IPv4AddressHelper), Member = "ParseNonCanonical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Int32&), typeof(bool)}, ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D16")]
	public static bool Ipv4StringToAddress(ReadOnlySpan<Char> ipSpan, out long address) { }

	[Address(RVA = "0x17C2080", Offset = "0x17C1280", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IPAddressParser), Member = "IPv6AddressToStringHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt16[]), typeof(uint)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = "System.Text.StringBuilderCache", Member = "GetStringAndRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000D13")]
	internal static string IPv6AddressToString(UInt16[] address, uint scopeId) { }

	[Address(RVA = "0x17C1BD0", Offset = "0x17C0DD0", Length = "0x4A4")]
	[CalledBy(Type = typeof(IPAddress), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(IPAddressParser), Member = "IPv6AddressToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt16[]), typeof(uint)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(IPv6AddressHelper), Member = "FindCompressionRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.UInt16>)}, ReturnType = typeof(System.ValueTuple`2<System.Int32, System.Int32>))]
	[Calls(Type = typeof(IPAddressParser), Member = "IPv4AddressToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(IPAddressParser), Member = "AppendHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(IPv6AddressHelper), Member = "ShouldHaveIpv4Embedded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.UInt16>)}, ReturnType = typeof(bool))]
	[Calls(Type = "System.Text.StringBuilderCache", Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000D14")]
	internal static StringBuilder IPv6AddressToStringHelper(UInt16[] address, uint scopeId) { }

	[Address(RVA = "0x17C2180", Offset = "0x17C1380", Length = "0x160")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(IPv6AddressHelper), Member = "IsValidStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(IPv6AddressHelper), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(UInt16*), typeof(int), typeof(String&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D17")]
	public static bool Ipv6StringToAddress(ReadOnlySpan<Char> ipSpan, UInt16* numbers, int numbersLength, out uint scope) { }

	[Address(RVA = "0x17C22F0", Offset = "0x17C14F0", Length = "0x3EF")]
	[CalledBy(Type = typeof(IPAddress), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IPAddress&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(IPAddress), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IPAddress))]
	[CallerCount(Count = 2)]
	[Calls(Type = "System.SpanHelpers", Member = "ClearWithoutReferences", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(IPv6AddressHelper), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(UInt16*), typeof(int), typeof(String&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IPv6AddressHelper), Member = "IsValidStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(IPv4AddressHelper), Member = "ParseNonCanonical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Int32&), typeof(bool)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(MemoryExtensions), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D0F")]
	internal static IPAddress Parse(ReadOnlySpan<Char> ipSpan, bool tryParse) { }

	[Address(RVA = "0x143B600", Offset = "0x143A800", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D1B")]
	private static ushort Reverse(ushort number) { }

}

