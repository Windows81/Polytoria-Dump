namespace System.Text;

[Token(Token = "0x20002A9")]
internal static class StringBuilderCache
{
	[ThreadStatic]
	[Token(Token = "0x4000BAE")]
	private static StringBuilder t_cachedInstance; //Field offset: 0x80000000

	[Address(RVA = "0x130DDD0", Offset = "0x130CFD0", Length = "0xDD")]
	[CallerCount(Count = 36)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60015BD")]
	public static StringBuilder Acquire(int capacity = 16) { }

	[Address(RVA = "0x130DEB0", Offset = "0x130D0B0", Length = "0x94")]
	[CallerCount(Count = 33)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60015BF")]
	public static string GetStringAndRelease(StringBuilder sb) { }

	[Address(RVA = "0x130DF50", Offset = "0x130D150", Length = "0x76")]
	[CalledBy(Type = typeof(Version), Member = "System.ISpanFormattable.TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetLocalizedNameByMuiNativeResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(TimeSpan)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Version), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Version), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FormatLiterals), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeSpanFormat), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeSpanFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = "System.Text.RegularExpressions.RegexReplacement", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Text.RegularExpressions.RegexNode", typeof(Hashtable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60015BE")]
	public static void Release(StringBuilder sb) { }

}

