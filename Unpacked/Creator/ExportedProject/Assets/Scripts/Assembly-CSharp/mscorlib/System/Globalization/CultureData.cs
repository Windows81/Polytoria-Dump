namespace System.Globalization;

[Token(Token = "0x2000564")]
internal class CultureData
{
	[Token(Token = "0x2000565")]
	public struct NumberFormatEntryManaged
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40016D7")]
		internal int currency_decimal_digits; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40016D8")]
		internal int currency_decimal_separator; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40016D9")]
		internal int currency_group_separator; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40016DA")]
		internal int currency_group_sizes0; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40016DB")]
		internal int currency_group_sizes1; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40016DC")]
		internal int currency_negative_pattern; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40016DD")]
		internal int currency_positive_pattern; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40016DE")]
		internal int currency_symbol; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40016DF")]
		internal int nan_symbol; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40016E0")]
		internal int negative_infinity_symbol; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40016E1")]
		internal int negative_sign; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x40016E2")]
		internal int number_decimal_digits; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40016E3")]
		internal int number_decimal_separator; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x40016E4")]
		internal int number_group_separator; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40016E5")]
		internal int number_group_sizes0; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x40016E6")]
		internal int number_group_sizes1; //Field offset: 0x3C
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40016E7")]
		internal int number_negative_pattern; //Field offset: 0x40
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x40016E8")]
		internal int per_mille_symbol; //Field offset: 0x44
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40016E9")]
		internal int percent_negative_pattern; //Field offset: 0x48
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x40016EA")]
		internal int percent_positive_pattern; //Field offset: 0x4C
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40016EB")]
		internal int percent_symbol; //Field offset: 0x50
		[FieldOffset(Offset = "0x54")]
		[Token(Token = "0x40016EC")]
		internal int positive_infinity_symbol; //Field offset: 0x54
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40016ED")]
		internal int positive_sign; //Field offset: 0x58

	}

	[Token(Token = "0x40016D6")]
	private static CultureData s_Invariant; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40016C2")]
	private string sAM1159; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40016C3")]
	private string sPM2359; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40016C4")]
	private string sTimeSeparator; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40016C5")]
	private String[] saLongTimes; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40016C6")]
	private String[] saShortTimes; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40016C7")]
	private int iFirstDayOfWeek; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40016C8")]
	private int iFirstWeekOfYear; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40016C9")]
	private Int32[] waCalendars; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40016CA")]
	private CalendarData[] calendars; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40016CB")]
	private string sISO639Language; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40016CC")]
	private readonly string sRealName; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40016CD")]
	private bool bUseOverrides; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40016CE")]
	private int calendarId; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40016CF")]
	private int numberIndex; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40016D0")]
	private int iDefaultAnsiCodePage; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40016D1")]
	private int iDefaultOemCodePage; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x40016D2")]
	private int iDefaultMacCodePage; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40016D3")]
	private int iDefaultEbcdicCodePage; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x40016D4")]
	private bool isRightToLeft; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40016D5")]
	private string sListSeparator; //Field offset: 0x80

	[Token(Token = "0x170005E1")]
	internal Int32[] CalendarIds
	{
		[Address(RVA = "0x1427A30", Offset = "0x1426C30", Length = "0x1AC")]
		[CalledBy(Type = typeof(CultureData), Member = "GetCalendarIds", ReturnType = typeof(CalendarId[]))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x600278D")]
		internal get { } //Length: 428
	}

	[Token(Token = "0x170005E3")]
	internal string CultureName
	{
		[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002790")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170005DC")]
	internal int IFIRSTDAYOFWEEK
	{
		[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002788")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x170005DD")]
	internal int IFIRSTWEEKOFYEAR
	{
		[Address(RVA = "0x3DCA70", Offset = "0x3DBC70", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002789")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x170005D8")]
	public static CultureData Invariant
	{
		[Address(RVA = "0x1427BE0", Offset = "0x1426DE0", Length = "0x3FB")]
		[CalledBy(Type = typeof(TextInfo), Member = "get_Invariant", ReturnType = typeof(TextInfo))]
		[CalledBy(Type = typeof(CultureData), Member = "GetCultureData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(int), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(string)}, ReturnType = typeof(CultureData))]
		[CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CultureInfo), Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002780")]
		 get { } //Length: 1019
	}

	[Token(Token = "0x170005E2")]
	internal bool IsInvariantCulture
	{
		[Address(RVA = "0x1427FE0", Offset = "0x14271E0", Length = "0xB")]
		[CalledBy(Type = typeof(NumberFormatInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextInfo), Member = "ToUpperInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
		[CalledBy(Type = typeof(TextInfo), Member = "ToLowerInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Token(Token = "0x600278F")]
		internal get { } //Length: 11
	}

	[Token(Token = "0x170005D9")]
	internal String[] LongTimes
	{
		[Address(RVA = "0xF5D840", Offset = "0xF5CA40", Length = "0x18")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002785")]
		internal get { } //Length: 24
	}

	[Token(Token = "0x170005DE")]
	internal string SAM1159
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x600278A")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170005E4")]
	internal string SCOMPAREINFO
	{
		[Address(RVA = "0x1427FF0", Offset = "0x14271F0", Length = "0x2C")]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_CompareInfo", ReturnType = typeof(CompareInfo))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6002791")]
		internal get { } //Length: 44
	}

	[Token(Token = "0x170005DA")]
	internal String[] ShortTimes
	{
		[Address(RVA = "0x1428020", Offset = "0x1427220", Length = "0x18")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002786")]
		internal get { } //Length: 24
	}

	[Token(Token = "0x170005DB")]
	internal string SISO639LANGNAME
	{
		[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002787")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170005DF")]
	internal string SPM2359
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x600278B")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170005E5")]
	internal string STEXTINFO
	{
		[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002792")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170005E0")]
	internal string TimeSeparator
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x600278C")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170005E6")]
	internal bool UseUserOverride
	{
		[Address(RVA = "0x3D01E0", Offset = "0x3CF3E0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002793")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x1427920", Offset = "0x1426B20", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600277F")]
	private CultureData(string name) { }

	[Address(RVA = "0x14266E0", Offset = "0x14258E0", Length = "0x1F")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AbbreviatedEraNames", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAbbreviatedEraName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CalendarData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002795")]
	internal String[] AbbrevEraNames(int calendarId) { }

	[Address(RVA = "0x1426700", Offset = "0x1425900", Length = "0x1F")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "internalGetAbbreviatedDayOfWeekNamesCore", ReturnType = typeof(String[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CalendarData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600279B")]
	internal String[] AbbreviatedDayNames(int calendarId) { }

	[Address(RVA = "0x1426720", Offset = "0x1425920", Length = "0x1F")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AbbreviatedEnglishEraNames", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(TokenHashValue[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CalendarData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002796")]
	internal String[] AbbreviatedEnglishEraNames(int calendarId) { }

	[Address(RVA = "0x1426740", Offset = "0x1425940", Length = "0x22")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "internalGetGenitiveMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CalendarData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600279F")]
	internal String[] AbbreviatedGenitiveMonthNames(int calendarId) { }

	[Address(RVA = "0x1426770", Offset = "0x1425970", Length = "0x1F")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "internalGetAbbreviatedMonthNamesCore", ReturnType = typeof(String[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CalendarData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600279E")]
	internal String[] AbbreviatedMonthNames(int calendarId) { }

	[Address(RVA = "0x1427960", Offset = "0x1426B60", Length = "0xA7")]
	[CalledBy(Type = typeof(CultureData), Member = "GetNFIValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60027AB")]
	private Int32[] create_group_sizes_array(int gs0, int gs1) { }

	[Address(RVA = "0x1426790", Offset = "0x1425990", Length = "0xCA")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeOverridableProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "set_Calendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Calendar)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_DateSeparator", ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CalendarData))]
	[Calls(Type = typeof(CultureData), Member = "GetSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60027A2")]
	internal string DateSeparator(int calendarId) { }

	[Address(RVA = "0x1426860", Offset = "0x1425A60", Length = "0x1F")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "internalGetDayOfWeekNamesCore", ReturnType = typeof(String[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CalendarData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600279A")]
	internal String[] DayNames(int calendarId) { }

	[Address(RVA = "0x1426880", Offset = "0x1425A80", Length = "0x1F")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_EraNames", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetEraName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CalendarData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002794")]
	internal String[] EraNames(int calendarId) { }

	[Address(RVA = "0x1427A10", Offset = "0x1426C10", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180211820")]
	[Token(Token = "0x6002783")]
	private void fill_culture_data(int datetimeIndex) { }

	[Address(RVA = "0x1427A20", Offset = "0x1426C20", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180211920")]
	[Token(Token = "0x60027AD")]
	private static Byte* fill_number_data(int index, ref NumberFormatEntryManaged nfe) { }

	[Address(RVA = "0x14268A0", Offset = "0x1425AA0", Length = "0x1F")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "internalGetGenitiveMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_MonthGenitiveNames", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(TokenHashValue[]))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CalendarData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600279D")]
	internal String[] GenitiveMonthNames(int calendarId) { }

	[Address(RVA = "0x1427A30", Offset = "0x1426C30", Length = "0x1AC")]
	[CalledBy(Type = typeof(CultureData), Member = "GetCalendarIds", ReturnType = typeof(CalendarId[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600278D")]
	internal Int32[] get_CalendarIds() { }

	[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002790")]
	internal string get_CultureName() { }

	[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002788")]
	internal int get_IFIRSTDAYOFWEEK() { }

	[Address(RVA = "0x3DCA70", Offset = "0x3DBC70", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002789")]
	internal int get_IFIRSTWEEKOFYEAR() { }

	[Address(RVA = "0x1427BE0", Offset = "0x1426DE0", Length = "0x3FB")]
	[CalledBy(Type = typeof(TextInfo), Member = "get_Invariant", ReturnType = typeof(TextInfo))]
	[CalledBy(Type = typeof(CultureData), Member = "GetCultureData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(int), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(string)}, ReturnType = typeof(CultureData))]
	[CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CultureInfo), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002780")]
	public static CultureData get_Invariant() { }

	[Address(RVA = "0x1427FE0", Offset = "0x14271E0", Length = "0xB")]
	[CalledBy(Type = typeof(NumberFormatInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInfo), Member = "ToUpperInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[CalledBy(Type = typeof(TextInfo), Member = "ToLowerInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600278F")]
	internal bool get_IsInvariantCulture() { }

	[Address(RVA = "0xF5D840", Offset = "0xF5CA40", Length = "0x18")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002785")]
	internal String[] get_LongTimes() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x600278A")]
	internal string get_SAM1159() { }

	[Address(RVA = "0x1427FF0", Offset = "0x14271F0", Length = "0x2C")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_CompareInfo", ReturnType = typeof(CompareInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6002791")]
	internal string get_SCOMPAREINFO() { }

	[Address(RVA = "0x1428020", Offset = "0x1427220", Length = "0x18")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002786")]
	internal String[] get_ShortTimes() { }

	[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002787")]
	internal string get_SISO639LANGNAME() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x600278B")]
	internal string get_SPM2359() { }

	[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002792")]
	internal string get_STEXTINFO() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x600278C")]
	internal string get_TimeSeparator() { }

	[Address(RVA = "0x3D01E0", Offset = "0x3CF3E0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002793")]
	internal bool get_UseUserOverride() { }

	[Address(RVA = "0x1426B60", Offset = "0x1425D60", Length = "0x13F")]
	[CalledBy(Type = typeof(CultureData), Member = "AbbreviatedMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(CultureData), Member = "DateSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(CultureData), Member = "MonthDay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(CultureData), Member = "LeapYearMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(CultureData), Member = "AbbreviatedGenitiveMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(CultureData), Member = "GenitiveMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(CultureData), Member = "MonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(CultureData), Member = "DayNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(CultureData), Member = "AbbreviatedDayNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(CultureData), Member = "LongDates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(CultureData), Member = "ShortDates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(CultureData), Member = "AbbreviatedEnglishEraNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(CultureData), Member = "AbbrevEraNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(CultureData), Member = "EraNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(CalendarData), Member = "GetCalendarData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CalendarData))]
	[CalledBy(Type = typeof(Calendar), Member = "get_CurrentEraValue", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(CultureData), Member = "YearMonths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CalendarData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Token(Token = "0x6002784")]
	public CalendarData GetCalendar(int calendarId) { }

	[Address(RVA = "0x14268C0", Offset = "0x1425AC0", Length = "0x296")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "set_Calendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Calendar)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_OptionalCalendars", ReturnType = typeof(CalendarId[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CultureData), Member = "get_CalendarIds", ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600278E")]
	internal CalendarId[] GetCalendarIds() { }

	[Address(RVA = "0x1426CA0", Offset = "0x1425EA0", Length = "0x111")]
	[CalledBy(Type = typeof(CultureInfo), Member = "GetCultures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureTypes)}, ReturnType = typeof(CultureInfo[]))]
	[CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CultureInfo), Member = "CreateSpecificCulture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CultureInfo))]
	[CalledBy(Type = typeof(CultureInfo), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180211820")]
	[Calls(Type = typeof(CultureData), Member = "get_Invariant", ReturnType = typeof(CultureData))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002782")]
	public static CultureData GetCultureData(string cultureName, bool useUserOverride, int datetimeIndex, int calendarId, int numberIndex, string iso2lang, int ansiCodePage, int oemCodePage, int macCodePage, int ebcdicCodePage, bool rightToLeft, string listSeparator) { }

	[Address(RVA = "0x1426DC0", Offset = "0x1425FC0", Length = "0x7F")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_FullTimeSpanPositivePattern", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_FullTimeSpanNegativePattern", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002781")]
	public static CultureData GetCultureData(string cultureName, bool useUserOverride) { }

	[Address(RVA = "0x1426E40", Offset = "0x1426040", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CultureData), Member = "GetSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x60027A3")]
	private static string GetDateSeparator(string format) { }

	[Address(RVA = "0x1426E80", Offset = "0x1426080", Length = "0x55A")]
	[CalledBy(Type = typeof(NumberFormatInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180211920")]
	[Calls(Type = typeof(CultureData), Member = "create_group_sizes_array", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Encoding), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "set_NaNSymbol", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60027AC")]
	internal void GetNFIValues(NumberFormatInfo nfi) { }

	[Address(RVA = "0x14273E0", Offset = "0x14265E0", Length = "0x1DE")]
	[CalledBy(Type = typeof(CultureData), Member = "DateSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(CultureData), Member = "GetDateSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CultureData), Member = "UnescapeNlsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60027A4")]
	private static string GetSeparator(string format, string timeParts) { }

	[Address(RVA = "0x1428040", Offset = "0x1427240", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Encoding), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027AA")]
	private static string idx2string(Byte* data, int idx) { }

	[Address(RVA = "0x14275C0", Offset = "0x14267C0", Length = "0xEC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60027A5")]
	private static int IndexOfTimePart(string format, int startIndex, string timeParts) { }

	[Address(RVA = "0x14276B0", Offset = "0x14268B0", Length = "0x22")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "internalGetMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(MonthNameStyles), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "internalGetLeapYearMonthNames", ReturnType = typeof(String[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CalendarData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027A0")]
	internal String[] LeapYearMonthNames(int calendarId) { }

	[Address(RVA = "0x14276E0", Offset = "0x14268E0", Length = "0x1F")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeOverridableProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "set_Calendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Calendar)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedLongDatePatterns", ReturnType = typeof(String[]))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CalendarData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002798")]
	internal String[] LongDates(int calendarId) { }

	[Address(RVA = "0x1427700", Offset = "0x1426900", Length = "0x1F")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_MonthDayPattern", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAllDateTimePatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(String[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CalendarData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027A1")]
	internal string MonthDay(int calendarId) { }

	[Address(RVA = "0x1427720", Offset = "0x1426920", Length = "0x1F")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "internalGetMonthNamesCore", ReturnType = typeof(String[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CalendarData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600279C")]
	internal String[] MonthNames(int calendarId) { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x60027A8")]
	internal static string ReescapeWin32String(string str) { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x60027A7")]
	internal static String[] ReescapeWin32Strings(String[] array) { }

	[Address(RVA = "0x1427740", Offset = "0x1426940", Length = "0x1F")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeOverridableProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "set_Calendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Calendar)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedShortDatePatterns", ReturnType = typeof(String[]))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CalendarData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002797")]
	internal String[] ShortDates(int calendarId) { }

	[Address(RVA = "0x14280A0", Offset = "0x14272A0", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60027A9")]
	private static int strlen(Byte* s) { }

	[Address(RVA = "0x1427760", Offset = "0x1426960", Length = "0x197")]
	[CalledBy(Type = typeof(CultureData), Member = "GetSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60027A6")]
	private static string UnescapeNlsString(string str, int start, int end) { }

	[Address(RVA = "0x1427900", Offset = "0x1426B00", Length = "0x1F")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeOverridableProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "set_Calendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Calendar)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedYearMonthPatterns", ReturnType = typeof(String[]))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CalendarData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002799")]
	internal String[] YearMonths(int calendarId) { }

}

