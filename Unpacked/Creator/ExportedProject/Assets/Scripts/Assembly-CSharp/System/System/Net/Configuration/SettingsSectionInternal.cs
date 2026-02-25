namespace System.Net.Configuration;

[Token(Token = "0x20002D5")]
internal sealed class SettingsSectionInternal
{
	[Token(Token = "0x4000C71")]
	private static readonly SettingsSectionInternal instance; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C72")]
	internal readonly bool HttpListenerUnescapeRequestUrl; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000C73")]
	internal readonly IPProtectionLevel IPProtectionLevel; //Field offset: 0x14

	[Token(Token = "0x170003D9")]
	internal bool Ipv6Enabled
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001215")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x170003D8")]
	internal static SettingsSectionInternal Section
	{
		[Address(RVA = "0x17038B0", Offset = "0x1702AB0", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6001214")]
		internal get { } //Length: 78
	}

	[Address(RVA = "0x1703810", Offset = "0x1702A10", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001217")]
	private static SettingsSectionInternal() { }

	[Address(RVA = "0x1703890", Offset = "0x1702A90", Length = "0x12")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001216")]
	public SettingsSectionInternal() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001215")]
	internal bool get_Ipv6Enabled() { }

	[Address(RVA = "0x17038B0", Offset = "0x1702AB0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6001214")]
	internal static SettingsSectionInternal get_Section() { }

}

