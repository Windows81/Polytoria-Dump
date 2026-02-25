namespace System.Globalization;

[Token(Token = "0x2000546")]
internal static class TimeSpanFormat
{
	[Token(Token = "0x2000548")]
	public struct FormatLiterals
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40015F0")]
		internal string AppCompatLiteral; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40015F1")]
		internal int dd; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40015F2")]
		internal int hh; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40015F3")]
		internal int mm; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40015F4")]
		internal int ss; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40015F5")]
		internal int ff; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40015F6")]
		private String[] _literals; //Field offset: 0x20

		[Token(Token = "0x17000581")]
		internal string DayHourSep
		{
			[Address(RVA = "0x13F2B60", Offset = "0x13F1D60", Length = "0x27")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
			[DeduplicatedMethod]
			[Token(Token = "0x6002618")]
			internal get { } //Length: 39
		}

		[Token(Token = "0x17000585")]
		internal string End
		{
			[Address(RVA = "0x13F2B90", Offset = "0x13F1D90", Length = "0x27")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
			[Token(Token = "0x600261C")]
			internal get { } //Length: 39
		}

		[Token(Token = "0x17000582")]
		internal string HourMinuteSep
		{
			[Address(RVA = "0x13F2BC0", Offset = "0x13F1DC0", Length = "0x27")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
			[DeduplicatedMethod]
			[Token(Token = "0x6002619")]
			internal get { } //Length: 39
		}

		[Token(Token = "0x17000583")]
		internal string MinuteSecondSep
		{
			[Address(RVA = "0x13F2BF0", Offset = "0x13F1DF0", Length = "0x27")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
			[DeduplicatedMethod]
			[Token(Token = "0x600261A")]
			internal get { } //Length: 39
		}

		[Token(Token = "0x17000584")]
		internal string SecondFractionSep
		{
			[Address(RVA = "0x13F2C20", Offset = "0x13F1E20", Length = "0x27")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
			[DeduplicatedMethod]
			[Token(Token = "0x600261B")]
			internal get { } //Length: 39
		}

		[Token(Token = "0x17000580")]
		internal string Start
		{
			[Address(RVA = "0x13F2C50", Offset = "0x13F1E50", Length = "0x27")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
			[DeduplicatedMethod]
			[Token(Token = "0x6002617")]
			internal get { } //Length: 39
		}

		[Address(RVA = "0x13F2B60", Offset = "0x13F1D60", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002618")]
		internal string get_DayHourSep() { }

		[Address(RVA = "0x13F2B90", Offset = "0x13F1D90", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x600261C")]
		internal string get_End() { }

		[Address(RVA = "0x13F2BC0", Offset = "0x13F1DC0", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002619")]
		internal string get_HourMinuteSep() { }

		[Address(RVA = "0x13F2BF0", Offset = "0x13F1DF0", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x600261A")]
		internal string get_MinuteSecondSep() { }

		[Address(RVA = "0x13F2C20", Offset = "0x13F1E20", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x600261B")]
		internal string get_SecondFractionSep() { }

		[Address(RVA = "0x13F2C50", Offset = "0x13F1E50", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002617")]
		internal string get_Start() { }

		[Address(RVA = "0x13F2790", Offset = "0x13F1990", Length = "0x3CD")]
		[CalledBy(Type = typeof(TimeSpanFormat), Member = "FormatStandard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(bool), typeof(System.ReadOnlySpan`1<System.Char>), typeof(Pattern)}, ReturnType = typeof(StringBuilder))]
		[CalledBy(Type = "System.Globalization.TimeSpanParse+TimeSpanRawInfo", Member = "get_PositiveLocalized", ReturnType = typeof(FormatLiterals))]
		[CalledBy(Type = "System.Globalization.TimeSpanParse+TimeSpanRawInfo", Member = "get_NegativeLocalized", ReturnType = typeof(FormatLiterals))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(StringBuilderCache), Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(StringBuilderCache), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600261E")]
		internal void Init(ReadOnlySpan<Char> format, bool useInvariantFieldLengths) { }

		[Address(RVA = "0x13F2540", Offset = "0x13F1740", Length = "0x247")]
		[CalledBy(Type = typeof(TimeSpanFormat), Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x600261D")]
		internal static FormatLiterals InitInvariant(bool isNegative) { }

	}

	[Token(Token = "0x2000547")]
	public enum Pattern
	{
		None = 0,
		Minimum = 1,
		Full = 2,
	}

	[Token(Token = "0x40015EA")]
	internal static readonly FormatLiterals PositiveInvariantFormatLiterals; //Field offset: 0x0
	[Token(Token = "0x40015EB")]
	internal static readonly FormatLiterals NegativeInvariantFormatLiterals; //Field offset: 0x28

	[Address(RVA = "0x13FE3D0", Offset = "0x13FD5D0", Length = "0xBD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FormatLiterals), Member = "InitInvariant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(FormatLiterals))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002616")]
	private static TimeSpanFormat() { }

	[Address(RVA = "0x13FD0E0", Offset = "0x13FC2E0", Length = "0xEA")]
	[CalledBy(Type = typeof(TimeSpanFormat), Member = "FormatStandard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(bool), typeof(System.ReadOnlySpan`1<System.Char>), typeof(Pattern)}, ReturnType = typeof(StringBuilder))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002610")]
	private static void AppendNonNegativeInt32(StringBuilder sb, int n, int digits) { }

	[Address(RVA = "0x13FE1F0", Offset = "0x13FD3F0", Length = "0xCE")]
	[CalledBy(Type = typeof(TimeSpan), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TimeSpan), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpanFormat), Member = "FormatToBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilderCache), Member = "GetStringAndRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	[Token(Token = "0x6002611")]
	internal static string Format(TimeSpan value, string format, IFormatProvider formatProvider) { }

	[Address(RVA = "0x13FD1D0", Offset = "0x13FC3D0", Length = "0x7C9")]
	[CalledBy(Type = typeof(TimeSpanFormat), Member = "FormatToBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(TimeSpanFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TimeSpanParse), Member = "Pow10", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(StringBuilderCache), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(TimeSpanFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(DateTimeFormat), Member = "ParseQuoteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(StringBuilder)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeFormat), Member = "FormatDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(long), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(DateTimeFormat), Member = "ParseNextChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeFormat), Member = "FormatDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeFormat), Member = "ParseRepeatPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StringBuilderCache), Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002615")]
	private static StringBuilder FormatCustomized(TimeSpan value, ReadOnlySpan<Char> format, DateTimeFormatInfo dtfi, StringBuilder result) { }

	[Address(RVA = "0x13FD9A0", Offset = "0x13FCBA0", Length = "0x545")]
	[CalledBy(Type = typeof(TimeSpanFormat), Member = "FormatToBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(StringBuilder))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FormatLiterals), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(TimeSpanFormat), Member = "AppendNonNegativeInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StringBuilderCache), Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TimeSpanParse), Member = "Pow10", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(long))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002614")]
	private static StringBuilder FormatStandard(TimeSpan value, bool isInvariant, ReadOnlySpan<Char> format, Pattern pattern) { }

	[Address(RVA = "0x13FDEF0", Offset = "0x13FD0F0", Length = "0x2FD")]
	[CalledBy(Type = typeof(TimeSpanFormat), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TimeSpanFormat), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(DateTimeFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(TimeSpanFormat), Member = "FormatStandard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(bool), typeof(System.ReadOnlySpan`1<System.Char>), typeof(Pattern)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_FullTimeSpanPositivePattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TimeSpanFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_FullTimeSpanNegativePattern", ReturnType = typeof(string))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002613")]
	private static StringBuilder FormatToBuilder(TimeSpan value, ReadOnlySpan<Char> format, IFormatProvider formatProvider) { }

	[Address(RVA = "0x13FE2C0", Offset = "0x13FD4C0", Length = "0x100")]
	[CalledBy(Type = typeof(TimeSpan), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpanFormat), Member = "FormatToBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilderCache), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Span`1<System.Char>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6002612")]
	internal static bool TryFormat(TimeSpan value, Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format, IFormatProvider formatProvider) { }

}

