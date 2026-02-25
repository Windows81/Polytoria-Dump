namespace System;

[Token(Token = "0x20000DD")]
internal static class DateTimeParse
{
	[CompilerGenerated]
	[Token(Token = "0x20000E2")]
	private sealed class <>c
	{
		[Token(Token = "0x400036C")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400036D")]
		public static Func<MatchNumberDelegate> <>9__98_0; //Field offset: 0x8

		[Address(RVA = "0x14B1F00", Offset = "0x14B1100", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000726")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000727")]
		public <>c() { }

		[Address(RVA = "0x14B1E10", Offset = "0x14B1010", Length = "0xE7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000728")]
		internal MatchNumberDelegate <DoStrictParse>b__98_0() { }

	}

	[Token(Token = "0x20000E1")]
	public enum DS
	{
		BEGIN = 0,
		N = 1,
		NN = 2,
		D_Nd = 3,
		D_NN = 4,
		D_NNd = 5,
		D_M = 6,
		D_MN = 7,
		D_NM = 8,
		D_MNd = 9,
		D_NDS = 10,
		D_Y = 11,
		D_YN = 12,
		D_YNd = 13,
		D_YM = 14,
		D_YMd = 15,
		D_S = 16,
		T_S = 17,
		T_Nt = 18,
		T_NNt = 19,
		ERROR = 20,
		DX_NN = 21,
		DX_NNN = 22,
		DX_MN = 23,
		DX_NM = 24,
		DX_MNN = 25,
		DX_DS = 26,
		DX_DSN = 27,
		DX_NDS = 28,
		DX_NNDS = 29,
		DX_YNN = 30,
		DX_YMN = 31,
		DX_YN = 32,
		DX_YM = 33,
		TX_N = 34,
		TX_NN = 35,
		TX_NNN = 36,
		TX_TS = 37,
		DX_NNY = 38,
	}

	[Token(Token = "0x20000DF")]
	public enum DTT
	{
		End = 0,
		NumEnd = 1,
		NumAmpm = 2,
		NumSpace = 3,
		NumDatesep = 4,
		NumTimesep = 5,
		MonthEnd = 6,
		MonthSpace = 7,
		MonthDatesep = 8,
		NumDatesuff = 9,
		NumTimesuff = 10,
		DayOfWeek = 11,
		YearSpace = 12,
		YearDateSep = 13,
		YearEnd = 14,
		TimeZone = 15,
		Era = 16,
		NumUTCTimeMark = 17,
		Unk = 18,
		NumLocalTimeMark = 19,
		Max = 20,
	}

	[Token(Token = "0x20000DE")]
	public sealed class MatchNumberDelegate : MulticastDelegate
	{

		[Address(RVA = "0x14A2690", Offset = "0x14A1890", Length = "0xB5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000724")]
		public MatchNumberDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000725")]
		public override bool Invoke(ref __DTString str, int digitLen, out int result) { }

	}

	[Token(Token = "0x20000E0")]
	public enum TM
	{
		NotSet = -1,
		AM = 0,
		PM = 1,
	}

	[Token(Token = "0x4000328")]
	internal static MatchNumberDelegate m_hebrewNumberParser; //Field offset: 0x0
	[Token(Token = "0x4000329")]
	private static DS[][] dateParsingStates; //Field offset: 0x8

	[Address(RVA = "0x1492F80", Offset = "0x1492180", Length = "0x6BC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000723")]
	private static DateTimeParse() { }

	[Address(RVA = "0x1487A80", Offset = "0x1486C80", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60006FA")]
	private static bool AdjustHour(ref int hour, TM timeMark) { }

	[Address(RVA = "0x1487AC0", Offset = "0x1486CC0", Length = "0xB0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_AMDesignator", ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_PMDesignator", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006F9")]
	private static void AdjustTimeMark(DateTimeFormatInfo dtfi, ref DateTimeRawInfo raw) { }

	[Address(RVA = "0x1487B80", Offset = "0x1486D80", Length = "0x2DF")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "DetermineTimeZoneAdjustments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "get_Local", ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(DateTimeKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600070B")]
	private static bool AdjustTimeZoneToLocal(ref DateTimeResult result, bool bTimeOnly) { }

	[Address(RVA = "0x1487E60", Offset = "0x1487060", Length = "0x121")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "DetermineTimeZoneAdjustments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "DateTimeOffsetTimeZonePostProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(DateTimeKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600070A")]
	private static bool AdjustTimeZoneToUniversal(ref DateTimeResult result) { }

	[Address(RVA = "0x1487F90", Offset = "0x1487190", Length = "0x231")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "DoStrictParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeStyles), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTimeResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeParse), Member = "GetDateTimeNow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(GregorianCalendar), Member = "GetDefaultInstance", ReturnType = typeof(Calendar))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x600071C")]
	private static bool CheckDefaultDateTime(ref DateTimeResult result, ref Calendar cal, DateTimeStyles styles) { }

	[Address(RVA = "0x14881D0", Offset = "0x14873D0", Length = "0x98")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(DateTimeResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x600071A")]
	private static bool CheckNewValue(ref int currentValue, int newValue, char patternChar, ref DateTimeResult result) { }

	[Address(RVA = "0x1488270", Offset = "0x1487470", Length = "0x28C")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "DetermineTimeZoneAdjustments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetLocalUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(DateTimeParse), Member = "AdjustTimeZoneToUniversal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(DateTimeKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000709")]
	private static bool DateTimeOffsetTimeZonePostProcessing(ref __DTString str, ref DateTimeResult result, DateTimeStyles styles) { }

	[Address(RVA = "0x1488500", Offset = "0x1487700", Length = "0x25F")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseISO8601", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeRawInfo&), typeof(__DTString&), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "DoStrictParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeStyles), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "SpecifyKind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTimeKind)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetLocalUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(DateTimeParse), Member = "AdjustTimeZoneToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeParse), Member = "AdjustTimeZoneToUniversal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeParse), Member = "DateTimeOffsetTimeZonePostProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000708")]
	private static bool DetermineTimeZoneAdjustments(ref __DTString str, ref DateTimeResult result, DateTimeStyles styles, bool bTimeOnly) { }

	[Address(RVA = "0x1488760", Offset = "0x1487960", Length = "0x90C")]
	[CalledBy(Type = typeof(DateTime), Member = "ParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTime), Member = "TryParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "TryParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "TryParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "TryParseExactMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(String[]), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(__DTString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(__DTString), Member = "GetNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_FormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeParse), Member = "CheckDefaultDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(Calendar&), typeof(DateTimeStyles)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18018FAF0")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "YearMonthAdjustment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(__DTString), Member = "RemoveLeadingInQuoteSpaces", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F70")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_HasYearMonthAdjustment", ReturnType = typeof(bool))]
	[Calls(Type = typeof(__DTString), Member = "SkipWhiteSpaces", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(__DTString), Member = "TrimTail", ReturnType = typeof(void))]
	[Calls(Type = typeof(LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "System.Func`1<T>"}, ReturnType = "T")]
	[Calls(Type = typeof(DateTime), Member = "AddTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeResult), Member = "SetBadFormatSpecifierFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ParsingInfo), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(__DTString), Member = "RemoveTrailingInQuoteSpaces", ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeParse), Member = "DetermineTimeZoneAdjustments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000721")]
	private static bool DoStrictParse(ReadOnlySpan<Char> s, ReadOnlySpan<Char> formatParam, DateTimeStyles styles, DateTimeFormatInfo dtfi, ref DateTimeResult result) { }

	[Address(RVA = "0x1489070", Offset = "0x1488270", Length = "0x63C")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "DoStrictParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeStyles), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_GeneralShortTimePattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_ShortDatePattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_YearMonthPattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_MonthDayPattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_RFC1123Pattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_LongTimePattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_FullDateTimePattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_GeneralLongTimePattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_LongDatePattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UniversalSortableDateTimePattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_ShortTimePattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_SortableDateTimePattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(DateTimeFormatInfo))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "set_Calendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Calendar)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "Clone", ReturnType = typeof(object))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GregorianCalendar), Member = "GetDefaultInstance", ReturnType = typeof(Calendar))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600071D")]
	private static string ExpandPredefinedFormat(ReadOnlySpan<Char> format, ref DateTimeFormatInfo dtfi, ref ParsingInfo parseInfo, ref DateTimeResult result) { }

	[Address(RVA = "0x1489720", Offset = "0x1488920", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTimeRawInfo), Member = "GetNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
	[Token(Token = "0x60006FE")]
	private static bool GetDateOfDSN(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	[Address(RVA = "0x1489760", Offset = "0x1488960", Length = "0x9A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTimeRawInfo), Member = "GetNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeParse), Member = "TryAdjustYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
	[Token(Token = "0x60006FF")]
	private static bool GetDateOfNDS(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	[Address(RVA = "0x1489800", Offset = "0x1488A00", Length = "0x24C")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_ShortDatePattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeParse), Member = "GetYearMonthDayOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeRawInfo), Member = "GetNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeParse), Member = "TryAdjustYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeParse), Member = "SetDateYMD", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000700")]
	private static bool GetDateOfNNDS(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	[Address(RVA = "0x1489A50", Offset = "0x1488C50", Length = "0x145")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDefaultYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "CheckDefaultDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(Calendar&), typeof(DateTimeStyles)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(DateTimeKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[Token(Token = "0x600071B")]
	private static DateTime GetDateTimeNow(ref DateTimeResult result, ref DateTimeStyles styles) { }

	[Address(RVA = "0x1489BA0", Offset = "0x1488DA0", Length = "0x50")]
	[CalledBy(Type = typeof(DateTime), Member = "ParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(TimeSpan&)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000722")]
	private static Exception GetDateTimeParseException(ref DateTimeResult result) { }

	[Address(RVA = "0x148A080", Offset = "0x1489280", Length = "0x239")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_YearMonthPattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeParse), Member = "GetDefaultYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeParse), Member = "SetDateYMD", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeParse), Member = "TryAdjustYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeRawInfo), Member = "GetNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeParse), Member = "GetMonthDayOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_MonthDayPattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTimeParse), Member = "GetYearMonthOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60006F0")]
	private static bool GetDayOfMN(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	[Address(RVA = "0x1489D90", Offset = "0x1488F90", Length = "0x2E4")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTimeRawInfo), Member = "GetNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_ShortDatePattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeParse), Member = "GetYearMonthDayOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeParse), Member = "TryAdjustYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180188830")]
	[Calls(Type = typeof(DateTimeResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006F3")]
	private static bool GetDayOfMNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	[Address(RVA = "0x148A2C0", Offset = "0x14894C0", Length = "0x239")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_YearMonthPattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeParse), Member = "GetDefaultYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeParse), Member = "SetDateYMD", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeParse), Member = "TryAdjustYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeRawInfo), Member = "GetNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeParse), Member = "GetMonthDayOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_MonthDayPattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTimeParse), Member = "GetYearMonthOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60006F2")]
	private static bool GetDayOfNM(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	[Address(RVA = "0x148A9B0", Offset = "0x1489BB0", Length = "0x175")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTimeRawInfo), Member = "GetNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeParse), Member = "GetDefaultYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_MonthDayPattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeParse), Member = "GetMonthDayOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeParse), Member = "SetDateYMD", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006EE")]
	private static bool GetDayOfNN(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	[Address(RVA = "0x148A500", Offset = "0x1489700", Length = "0x33A")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTimeRawInfo), Member = "GetNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_ShortDatePattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeParse), Member = "GetYearMonthDayOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeParse), Member = "TryAdjustYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeParse), Member = "SetDateYMD", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006EF")]
	private static bool GetDayOfNNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	[Address(RVA = "0x148A840", Offset = "0x1489A40", Length = "0x16C")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTimeRawInfo), Member = "GetNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_ShortDatePattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeParse), Member = "GetYearMonthDayOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeParse), Member = "SetDateYMD", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006F5")]
	private static bool GetDayOfNNY(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	[Address(RVA = "0x148ABF0", Offset = "0x1489DF0", Length = "0xA2")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeParse), Member = "SetDateYMD", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
	[Token(Token = "0x60006F8")]
	private static bool GetDayOfYM(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	[Address(RVA = "0x148AB30", Offset = "0x1489D30", Length = "0xB8")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTimeRawInfo), Member = "GetNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeParse), Member = "SetDateYMD", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
	[Token(Token = "0x60006F6")]
	private static bool GetDayOfYMN(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	[Address(RVA = "0x148ADF0", Offset = "0x1489FF0", Length = "0xAE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTimeRawInfo), Member = "GetNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeParse), Member = "SetDateYMD", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
	[Token(Token = "0x60006F7")]
	private static bool GetDayOfYN(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	[Address(RVA = "0x148ACA0", Offset = "0x1489EA0", Length = "0x142")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTimeRawInfo), Member = "GetNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_ShortDatePattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeParse), Member = "GetYearMonthDayOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeParse), Member = "SetDateYMD", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006F4")]
	private static bool GetDayOfYNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	[Address(RVA = "0x148AEA0", Offset = "0x148A0A0", Length = "0x95")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfNN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfMN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfNM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeParse), Member = "GetDateTimeNow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006ED")]
	private static void GetDefaultYear(ref DateTimeResult result, ref DateTimeStyles styles) { }

	[Address(RVA = "0x148AF40", Offset = "0x148A140", Length = "0x152")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_MonthDayPattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeParse), Member = "GetMonthDayOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeRawInfo), Member = "GetNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006F1")]
	private static bool GetHebrewDayOfNM(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	[Address(RVA = "0x148B0A0", Offset = "0x148A2A0", Length = "0xE7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(JapaneseCalendar), Member = "GetDefaultInstance", ReturnType = typeof(Calendar))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60006E2")]
	private static Calendar GetJapaneseCalendarDefaultInstance() { }

	[Address(RVA = "0x148B190", Offset = "0x148A390", Length = "0x181")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfNN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfMN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetHebrewDayOfNM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfNM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006E7")]
	private static bool GetMonthDayOrder(string pattern, DateTimeFormatInfo dtfi, out int order) { }

	[Address(RVA = "0x148B320", Offset = "0x148A520", Length = "0xE7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TaiwanCalendar), Member = "GetDefaultInstance", ReturnType = typeof(Calendar))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60006E3")]
	internal static Calendar GetTaiwanCalendarDefaultInstance() { }

	[Address(RVA = "0x148B4F0", Offset = "0x148A6F0", Length = "0x43")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTimeRawInfo), Member = "GetNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
	[Token(Token = "0x60006FB")]
	private static bool GetTimeOfN(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	[Address(RVA = "0x148B490", Offset = "0x148A690", Length = "0x5E")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTimeRawInfo), Member = "GetNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
	[Token(Token = "0x60006FC")]
	private static bool GetTimeOfNN(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	[Address(RVA = "0x148B410", Offset = "0x148A610", Length = "0x71")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTimeRawInfo), Member = "GetNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
	[Token(Token = "0x60006FD")]
	private static bool GetTimeOfNNN(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	[Address(RVA = "0x148B540", Offset = "0x148A740", Length = "0xA1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeParse), Member = "MatchWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(string)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60006DC")]
	private static bool GetTimeZoneName(ref __DTString str) { }

	[Address(RVA = "0x148B5F0", Offset = "0x148A7F0", Length = "0x225")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfNNN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfMNN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfYNN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfNNY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDateOfNNDS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006E5")]
	private static bool GetYearMonthDayOrder(string datePattern, DateTimeFormatInfo dtfi, out int order) { }

	[Address(RVA = "0x148B820", Offset = "0x148AA20", Length = "0x141")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfMN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfNM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006E6")]
	private static bool GetYearMonthOrder(string pattern, DateTimeFormatInfo dtfi, out int order) { }

	[Address(RVA = "0x148B970", Offset = "0x148AB70", Length = "0x170")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "Lex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeToken&), typeof(DateTimeRawInfo&), typeof(DateTimeResult&), typeof(DateTimeFormatInfo&), typeof(DateTimeStyles)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(__DTString), Member = "get_Length", ReturnType = typeof(int))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeParse), Member = "ParseTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(TimeSpan&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006E0")]
	private static bool HandleTimeZone(ref __DTString str, ref DateTimeResult result) { }

	[Address(RVA = "0x148BAF0", Offset = "0x148ACF0", Length = "0xD")]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60006DD")]
	internal static bool IsDigit(char ch) { }

	[Address(RVA = "0x148BB00", Offset = "0x148AD00", Length = "0x1054")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTimeParse), Member = "VerifyValidPunctuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetTaiwanCalendarDTFI", ReturnType = typeof(DateTimeFormatInfo))]
	[Calls(Type = typeof(TaiwanCalendar), Member = "GetDefaultInstance", ReturnType = typeof(Calendar))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetJapaneseCalendarDTFI", ReturnType = typeof(DateTimeFormatInfo))]
	[Calls(Type = typeof(JapaneseCalendar), Member = "GetDefaultInstance", ReturnType = typeof(Calendar))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1813CF360")]
	[Calls(Type = typeof(DateTimeResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(DateTimeParse), Member = "ParseTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(TimeSpan&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeRawInfo), Member = "AddNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(__DTString), Member = "GetSeparatorToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeFormatInfo), typeof(Int32&), typeof(Char&)}, ReturnType = typeof(TokenType))]
	[Calls(Type = typeof(DateTimeParse), Member = "HandleTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeParse), Member = "ParseFraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(Double&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(__DTString), Member = "get_Length", ReturnType = typeof(int))]
	[Calls(Type = typeof(__DTString), Member = "GetRegularToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenType&), typeof(Int32&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(char), Member = "IsLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006E1")]
	private static bool Lex(DS dps, ref __DTString str, ref DateTimeToken dtok, ref DateTimeRawInfo raw, ref DateTimeResult result, ref DateTimeFormatInfo dtfi, DateTimeStyles styles) { }

	[Address(RVA = "0x148CB90", Offset = "0x148BD90", Length = "0x152")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(__DTString), Member = "GetNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetAbbreviatedDayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DayOfWeek)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_HasSpacesInDayNames", ReturnType = typeof(bool))]
	[Calls(Type = typeof(__DTString), Member = "MatchSpecifiedWords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18147FD00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000715")]
	private static bool MatchAbbreviatedDayName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	[Address(RVA = "0x148CCF0", Offset = "0x148BEF0", Length = "0x1C8")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetLeapYearMonthNames", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_FormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18147FD00")]
	[Calls(Type = typeof(__DTString), Member = "MatchSpecifiedWords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_HasSpacesInMonthNames", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(__DTString), Member = "MatchLongestWords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(__DTString), Member = "GetNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetAbbreviatedMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000713")]
	private static bool MatchAbbreviatedMonthName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	[Address(RVA = "0x148CEC0", Offset = "0x148C0C0", Length = "0x143")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(__DTString), Member = "GetNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_AMDesignator", ReturnType = typeof(string))]
	[Calls(Type = typeof(__DTString), Member = "GetChar", ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_PMDesignator", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000719")]
	private static bool MatchAbbreviatedTimeMark(ref __DTString str, DateTimeFormatInfo dtfi, ref TM result) { }

	[Address(RVA = "0x148D010", Offset = "0x148C210", Length = "0x152")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(__DTString), Member = "GetNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetDayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DayOfWeek)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_HasSpacesInDayNames", ReturnType = typeof(bool))]
	[Calls(Type = typeof(__DTString), Member = "MatchSpecifiedWords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18147FD00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000716")]
	private static bool MatchDayName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	[Address(RVA = "0x148D170", Offset = "0x148C370", Length = "0x188")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(__DTString), Member = "GetNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetEraName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18147FD00")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetAbbreviatedEraName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000717")]
	private static bool MatchEraName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	[Address(RVA = "0x148D300", Offset = "0x148C500", Length = "0x100")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HebrewNumberParsingContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(__DTString), Member = "GetNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(__DTString), Member = "GetChar", ReturnType = typeof(char))]
	[Calls(Type = typeof(HebrewNumber), Member = "ParseByChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(HebrewNumberParsingContext&)}, ReturnType = typeof(HebrewNumberParsingState))]
	[Token(Token = "0x600070D")]
	internal static bool MatchHebrewDigits(ref __DTString str, int digitLen, out int number) { }

	[Address(RVA = "0x148D400", Offset = "0x148C600", Length = "0x214")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(__DTString), Member = "MatchLongestWords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_MonthGenitiveNames", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_FormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18147FD00")]
	[Calls(Type = typeof(__DTString), Member = "MatchSpecifiedWords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetLeapYearMonthNames", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(__DTString), Member = "GetNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_HasSpacesInMonthNames", ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000714")]
	private static bool MatchMonthName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	[Address(RVA = "0x148D620", Offset = "0x148C820", Length = "0x174")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_AMDesignator", ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_PMDesignator", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(__DTString), Member = "GetNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18147FD00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000718")]
	private static bool MatchTimeMark(ref __DTString str, DateTimeFormatInfo dtfi, ref TM result) { }

	[Address(RVA = "0x148D7A0", Offset = "0x148C9A0", Length = "0x1C1")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetTimeZoneName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CompareInfo), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(string), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(char), Member = "IsLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(__DTString), Member = "get_Length", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006DB")]
	private static bool MatchWord(ref __DTString str, string target) { }

	[Address(RVA = "0x14909E0", Offset = "0x148FBE0", Length = "0x11B")]
	[CalledBy(Type = typeof(DateTime), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTime), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTimeResult), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeParse), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(DateTimeParse), Member = "GetDateTimeParseException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000704")]
	internal static DateTime Parse(ReadOnlySpan<Char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles) { }

	[Address(RVA = "0x14908A0", Offset = "0x148FAA0", Length = "0x137")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTimeResult), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeParse), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(DateTimeParse), Member = "GetDateTimeParseException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000705")]
	internal static DateTime Parse(ReadOnlySpan<Char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out TimeSpan offset) { }

	[Address(RVA = "0x148D970", Offset = "0x148CB70", Length = "0x19B9")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "DoStrictParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeStyles), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(__DTString), Member = "MatchSpecifiedWords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeParse), Member = "MatchAbbreviatedMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeParse), Member = "MatchWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18147FC50")]
	[Calls(Type = typeof(__DTString), Member = "GetDigit", ReturnType = typeof(int))]
	[Calls(Type = typeof(TimeSpanParse), Member = "Pow10", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(DateTimeResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilderCache), Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_TimeSeparator", ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeParse), Member = "MatchMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilderCache), Member = "GetStringAndRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(__DTString), Member = "SkipWhiteSpaces", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilderCache), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetBadFormatSpecifierFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(__DTString), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_DateSeparator", ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetAbbreviatedDayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DayOfWeek)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetDayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DayOfWeek)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_HasSpacesInDayNames", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(__DTString), Member = "GetChar", ReturnType = typeof(char))]
	[Calls(Type = typeof(__DTString), Member = "GetRepeatCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_AMDesignator", ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_PMDesignator", ReturnType = typeof(string))]
	[Calls(Type = typeof(__DTString), Member = "GetNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18147FD00")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_HasForceTwoDigitYears", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeParse), Member = "ParseDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeParse), Member = "ParseDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeParse), Member = "CheckNewValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(char), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeParse), Member = "ParseTimeZoneOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(int), typeof(TimeSpan&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(__DTString), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeParse), Member = "MatchEraName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600071F")]
	private static bool ParseByFormat(ref __DTString str, ref __DTString format, ref ParsingInfo parseInfo, DateTimeFormatInfo dtfi, ref DateTimeResult result) { }

	[Address(RVA = "0x148F330", Offset = "0x148E530", Length = "0xE4")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseISO8601", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeRawInfo&), typeof(__DTString&), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseTimeZoneOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(int), typeof(TimeSpan&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18147FC50")]
	[Calls(Type = typeof(__DTString), Member = "GetDigit", ReturnType = typeof(int))]
	[Token(Token = "0x600070F")]
	internal static bool ParseDigits(ref __DTString str, int minDigitLen, int maxDigitLen, out int result) { }

	[Address(RVA = "0x148F420", Offset = "0x148E620", Length = "0x91")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeParse), Member = "ParseDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600070E")]
	internal static bool ParseDigits(ref __DTString str, int digitLen, out int result) { }

	[Address(RVA = "0x148F4C0", Offset = "0x148E6C0", Length = "0x1E9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTimeResult), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeParse), Member = "DoStrictParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeStyles), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetBadFormatSpecifierFailure", ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(DateTimeParse), Member = "GetDateTimeParseException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006D6")]
	internal static DateTime ParseExact(ReadOnlySpan<Char> s, ReadOnlySpan<Char> format, DateTimeFormatInfo dtfi, DateTimeStyles style) { }

	[Address(RVA = "0x148F820", Offset = "0x148EA20", Length = "0xEA")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "Lex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeToken&), typeof(DateTimeRawInfo&), typeof(DateTimeResult&), typeof(DateTimeFormatInfo&), typeof(DateTimeStyles)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseISO8601", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeRawInfo&), typeof(__DTString&), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(__DTString), Member = "GetNext", ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006DE")]
	private static bool ParseFraction(ref __DTString str, out double result) { }

	[Address(RVA = "0x148F6B0", Offset = "0x148E8B0", Length = "0x16B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18147FC50")]
	[Calls(Type = typeof(__DTString), Member = "GetDigit", ReturnType = typeof(int))]
	[Calls(Type = typeof(TimeSpanParse), Member = "Pow10", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(long))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000710")]
	private static bool ParseFractionExact(ref __DTString str, int maxDigitLen, ref double result) { }

	[Address(RVA = "0x148F910", Offset = "0x148EB10", Length = "0x6A9")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTimeParse), Member = "ParseFraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(Double&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "AddTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F70")]
	[Calls(Type = typeof(GregorianCalendar), Member = "GetDefaultInstance", ReturnType = typeof(Calendar))]
	[Calls(Type = typeof(DateTimeParse), Member = "VerifyValidPunctuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeParse), Member = "ParseTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(TimeSpan&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(__DTString), Member = "GetChar", ReturnType = typeof(char))]
	[Calls(Type = typeof(__DTString), Member = "GetNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(__DTString), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeParse), Member = "DetermineTimeZoneAdjustments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeParse), Member = "ParseDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(__DTString), Member = "SkipWhiteSpaces", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeRawInfo), Member = "GetNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DateTimeResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600070C")]
	private static bool ParseISO8601(ref DateTimeRawInfo raw, ref __DTString str, DateTimeStyles styles, ref DateTimeResult result) { }

	[Address(RVA = "0x148FFC0", Offset = "0x148F1C0", Length = "0xE6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(__DTString), Member = "GetNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600071E")]
	private static bool ParseJapaneseEraStart(ref __DTString str, DateTimeFormatInfo dtfi) { }

	[Address(RVA = "0x14900B0", Offset = "0x148F2B0", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(__DTString), Member = "GetNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(__DTString), Member = "GetChar", ReturnType = typeof(char))]
	[Token(Token = "0x6000711")]
	private static bool ParseSign(ref __DTString str, ref bool result) { }

	[Address(RVA = "0x14904F0", Offset = "0x148F6F0", Length = "0x3A3")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "HandleTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "Lex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeToken&), typeof(DateTimeRawInfo&), typeof(DateTimeResult&), typeof(DateTimeFormatInfo&), typeof(DateTimeStyles)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseISO8601", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeRawInfo&), typeof(__DTString&), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(__DTString), Member = "GetSubString", ReturnType = typeof(DTSubString))]
	[Calls(Type = typeof(DTSubString), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(__DTString), Member = "ConsumeSubString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DTSubString)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeSpan), Member = "Negate", ReturnType = typeof(TimeSpan))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006DF")]
	private static bool ParseTimeZone(ref __DTString str, ref TimeSpan result) { }

	[Address(RVA = "0x1490160", Offset = "0x148F360", Length = "0x388")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(__DTString), Member = "GetNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(__DTString), Member = "GetChar", ReturnType = typeof(char))]
	[Calls(Type = typeof(DateTimeParse), Member = "ParseDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(__DTString), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeSpan), Member = "Negate", ReturnType = typeof(TimeSpan))]
	[Token(Token = "0x6000712")]
	private static bool ParseTimeZoneOffset(ref __DTString str, int len, ref TimeSpan result) { }

	[Address(RVA = "0x1490B00", Offset = "0x148FD00", Length = "0xB9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000701")]
	private static bool ProcessDateTimeSuffix(ref DateTimeResult result, ref DateTimeRawInfo raw, ref DateTimeToken dtok) { }

	[Address(RVA = "0x1490BC0", Offset = "0x148FDC0", Length = "0x74")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000702")]
	internal static bool ProcessHebrewTerminalState(DS dps, ref __DTString str, ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	[Address(RVA = "0x1491110", Offset = "0x1490310", Length = "0x628")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "Lex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeToken&), typeof(DateTimeRawInfo&), typeof(DateTimeResult&), typeof(DateTimeFormatInfo&), typeof(DateTimeStyles)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTimeParse), Member = "GetDayOfNNN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeParse), Member = "GetTimeOfNN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeParse), Member = "GetTimeOfN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeParse), Member = "GetDayOfYM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeParse), Member = "GetDayOfYMN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeParse), Member = "GetYearMonthDayOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_ShortDatePattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeParse), Member = "GetDateOfNNDS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeParse), Member = "TryAdjustYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeParse), Member = "GetDayOfMNN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeParse), Member = "GetDayOfNM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DateTimeParse), Member = "GetTimeOfNNN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeParse), Member = "SetDateYMD", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeParse), Member = "GetMonthDayOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_MonthDayPattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeParse), Member = "GetDefaultYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeRawInfo), Member = "GetNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTimeParse), Member = "GetDayOfMN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeParse), Member = "GetDayOfNNY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000703")]
	internal static bool ProcessTerminalState(DS dps, ref __DTString str, ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	[Address(RVA = "0x1491780", Offset = "0x1490980", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeParse), Member = "SetDateYMD", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60006EB")]
	private static bool SetDateDMY(ref DateTimeResult result, int day, int month, int year) { }

	[Address(RVA = "0x1491800", Offset = "0x1490A00", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeParse), Member = "SetDateYMD", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60006EA")]
	private static bool SetDateMDY(ref DateTimeResult result, int month, int day, int year) { }

	[Address(RVA = "0x1491880", Offset = "0x1490A80", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60006EC")]
	private static bool SetDateYDM(ref DateTimeResult result, int year, int day, int month) { }

	[Address(RVA = "0x1491900", Offset = "0x1490B00", Length = "0x83")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfNNY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDateOfNNDS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfYM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfYN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfYMN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfYNN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfMN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfNNN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfNN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "SetDateDMY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "SetDateMDY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfNM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006E9")]
	private static bool SetDateYMD(ref DateTimeResult result, int year, int month, int day) { }

	[Address(RVA = "0x1491990", Offset = "0x1490B90", Length = "0x55")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfNNN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfMN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfNM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfMNN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDateOfNDS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDateOfNNDS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006E8")]
	private static bool TryAdjustYear(ref DateTimeResult result, int year, out int adjustedYear) { }

	[Address(RVA = "0x1492360", Offset = "0x1491560", Length = "0x12D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeResult), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeParse), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000706")]
	internal static bool TryParse(ReadOnlySpan<Char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out DateTime result) { }

	[Address(RVA = "0x1492490", Offset = "0x1491690", Length = "0x8EC")]
	[CalledBy(Type = typeof(DateTime), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(TimeSpan&)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DateTimeParse), Member = "ProcessHebrewTerminalState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_AMDesignator", ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_PMDesignator", ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
	[Calls(Type = typeof(__DTString), Member = "GetNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeParse), Member = "CheckDefaultDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(Calendar&), typeof(DateTimeStyles)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F70")]
	[Calls(Type = typeof(DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "AddTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTimeParse), Member = "ParseISO8601", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeRawInfo&), typeof(__DTString&), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_FormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
	[Calls(Type = typeof(__DTString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeParse), Member = "Lex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeToken&), typeof(DateTimeRawInfo&), typeof(DateTimeResult&), typeof(DateTimeFormatInfo&), typeof(DateTimeStyles)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DateTimeParse), Member = "DetermineTimeZoneAdjustments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_TimeSeparator", ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_DateSeparator", ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeRawInfo), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(__DTString), Member = "AtEnd", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000707")]
	internal static bool TryParse(ReadOnlySpan<Char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, ref DateTimeResult result) { }

	[Address(RVA = "0x1491F50", Offset = "0x1491150", Length = "0xF6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeParse), Member = "DoStrictParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeStyles), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetBadFormatSpecifierFailure", ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006D8")]
	internal static bool TryParseExact(ReadOnlySpan<Char> s, ReadOnlySpan<Char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, ref DateTimeResult result) { }

	[Address(RVA = "0x1492050", Offset = "0x1491250", Length = "0x200")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeResult), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeParse), Member = "DoStrictParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeStyles), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetBadFormatSpecifierFailure", ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006D7")]
	internal static bool TryParseExact(ReadOnlySpan<Char> s, ReadOnlySpan<Char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, out DateTime result) { }

	[Address(RVA = "0x1491B90", Offset = "0x1490D90", Length = "0x3B1")]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "TryParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(IFormatProvider), typeof(DateTimeStyles), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "TryParseExactMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(String[]), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTime&), typeof(TimeSpan&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTimeResult), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeParse), Member = "DoStrictParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeStyles), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetBadFormatSpecifierFailure", ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetBadDateTimeFailure", ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006DA")]
	internal static bool TryParseExactMultiple(ReadOnlySpan<Char> s, String[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style, ref DateTimeResult result) { }

	[Address(RVA = "0x14919F0", Offset = "0x1490BF0", Length = "0x195")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeResult), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeParse), Member = "TryParseExactMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(String[]), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60006D9")]
	internal static bool TryParseExactMultiple(ReadOnlySpan<Char> s, String[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style, out DateTime result, out TimeSpan offset) { }

	[Address(RVA = "0x1492250", Offset = "0x1491450", Length = "0x10A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000720")]
	internal static bool TryParseQuoteString(ReadOnlySpan<Char> format, int pos, StringBuilder result, out int returnValue) { }

	[Address(RVA = "0x1492D80", Offset = "0x1491F80", Length = "0x1F5")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "Lex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeToken&), typeof(DateTimeRawInfo&), typeof(DateTimeResult&), typeof(DateTimeFormatInfo&), typeof(DateTimeStyles)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseISO8601", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeRawInfo&), typeof(__DTString&), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(__DTString), Member = "get_Length", ReturnType = typeof(int))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(__DTString), Member = "GetNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006E4")]
	private static bool VerifyValidPunctuation(ref __DTString str) { }

}

