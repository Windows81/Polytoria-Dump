namespace System.Globalization;

[Token(Token = "0x2000536")]
public sealed class DateTimeFormatInfo : IFormatProvider, ICloneable
{
	[Token(Token = "0x2000537")]
	public class TokenHashValue
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001570")]
		internal string tokenString; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001571")]
		internal TokenType tokenType; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4001572")]
		internal int tokenValue; //Field offset: 0x1C

		[Address(RVA = "0x1405D00", Offset = "0x1404F00", Length = "0x52")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60025F8")]
		internal TokenHashValue(string tokenString, TokenType tokenType, int tokenValue) { }

	}

	[Token(Token = "0x400151E")]
	private static DateTimeFormatInfo s_invariantInfo; //Field offset: 0x0
	[Token(Token = "0x400155D")]
	internal const string KoreanYearSuff = "년"; //Field offset: 0x0
	[Token(Token = "0x400155C")]
	internal const string CJKDaySuff = "日"; //Field offset: 0x0
	[Token(Token = "0x400155B")]
	internal const string CJKMonthSuff = "月"; //Field offset: 0x0
	[Token(Token = "0x400155A")]
	internal const string CJKYearSuff = "年"; //Field offset: 0x0
	[Token(Token = "0x4001559")]
	internal const string IgnorableComma = ","; //Field offset: 0x0
	[Token(Token = "0x4001558")]
	internal const string IgnorablePeriod = "."; //Field offset: 0x0
	[Token(Token = "0x400155E")]
	internal const string KoreanMonthSuff = "월"; //Field offset: 0x0
	[Token(Token = "0x4001557")]
	private const string invariantTimeSeparator = ":"; //Field offset: 0x0
	[Token(Token = "0x4001555")]
	private const string dateSeparatorOrTimeZoneOffset = "-"; //Field offset: 0x0
	[Token(Token = "0x4001554")]
	private const int SECOND_PRIME = 197; //Field offset: 0x0
	[Token(Token = "0x4001553")]
	private const int TOKEN_HASH_SIZE = 199; //Field offset: 0x0
	[Token(Token = "0x4001551")]
	internal const DateTimeStyles InvalidDateTimeStyles = -256; //Field offset: 0x0
	[Token(Token = "0x400154E")]
	internal const string RoundtripDateTimeUnfixed = "yyyy'-'MM'-'ddTHH':'mm':'ss zzz"; //Field offset: 0x0
	[Token(Token = "0x400154D")]
	internal const string RoundtripFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK"; //Field offset: 0x0
	[Token(Token = "0x4001556")]
	private const string invariantDateSeparator = "/"; //Field offset: 0x0
	[Token(Token = "0x4001549")]
	private const int DEFAULT_ALL_DATETIMES_SIZE = 132; //Field offset: 0x0
	[Token(Token = "0x400155F")]
	internal const string KoreanDaySuff = "일"; //Field offset: 0x0
	[Token(Token = "0x400152E")]
	private const string universalSortableDateTimePattern = "yyyy'-'MM'-'dd HH':'mm':'ss'Z'"; //Field offset: 0x0
	[Token(Token = "0x400156D")]
	internal const string EnglishLangName = "en"; //Field offset: 0x0
	[Token(Token = "0x400156C")]
	internal const string JapaneseLangName = "ja"; //Field offset: 0x0
	[Token(Token = "0x400156B")]
	internal const string KoreanLangName = "ko"; //Field offset: 0x0
	[Token(Token = "0x400156A")]
	internal const string ZuluName = "Z"; //Field offset: 0x0
	[Token(Token = "0x4001569")]
	internal const string GMTName = "GMT"; //Field offset: 0x0
	[Token(Token = "0x4001568")]
	internal const string LocalTimeMark = "T"; //Field offset: 0x0
	[Token(Token = "0x4001560")]
	internal const string KoreanHourSuff = "시"; //Field offset: 0x0
	[Token(Token = "0x4001567")]
	internal const string JapaneseEraStart = "元"; //Field offset: 0x0
	[Token(Token = "0x4001565")]
	internal const string CJKMinuteSuff = "分"; //Field offset: 0x0
	[Token(Token = "0x4001564")]
	internal const string ChineseHourSuff = "时"; //Field offset: 0x0
	[Token(Token = "0x4001563")]
	internal const string CJKHourSuff = "時"; //Field offset: 0x0
	[Token(Token = "0x4001562")]
	internal const string KoreanSecondSuff = "초"; //Field offset: 0x0
	[Token(Token = "0x4001561")]
	internal const string KoreanMinuteSuff = "분"; //Field offset: 0x0
	[Token(Token = "0x400152C")]
	private const string rfc1123Pattern = "ddd, dd MMM yyyy HH':'mm':'ss 'GMT'"; //Field offset: 0x0
	[Token(Token = "0x400152D")]
	private const string sortableDateTimePattern = "yyyy'-'MM'-'dd'T'HH':'mm':'ss"; //Field offset: 0x0
	[Token(Token = "0x4001566")]
	internal const string CJKSecondSuff = "秒"; //Field offset: 0x0
	[Token(Token = "0x400154C")]
	private static readonly Char[] s_monthSpaces; //Field offset: 0x8
	[Token(Token = "0x400156E")]
	private static DateTimeFormatInfo s_jajpDTFI; //Field offset: 0x10
	[Token(Token = "0x400156F")]
	private static DateTimeFormatInfo s_zhtwDTFI; //Field offset: 0x18
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400151F")]
	private CultureData _cultureData; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001520")]
	private string _name; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001521")]
	private string _langName; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001522")]
	private CompareInfo _compareInfo; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001523")]
	private CultureInfo _cultureInfo; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001524")]
	private string amDesignator; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001525")]
	private string pmDesignator; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001526")]
	private string dateSeparator; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001527")]
	private string generalShortTimePattern; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001528")]
	private string generalLongTimePattern; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001529")]
	private string timeSeparator; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400152A")]
	private string monthDayPattern; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400152B")]
	private string dateTimeOffsetPattern; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400152F")]
	private Calendar calendar; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001530")]
	private int firstDayOfWeek; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4001531")]
	private int calendarWeekRule; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001532")]
	private string fullDateTimePattern; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001533")]
	private String[] abbreviatedDayNames; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4001534")]
	private String[] m_superShortDayNames; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4001535")]
	private String[] dayNames; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4001536")]
	private String[] abbreviatedMonthNames; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4001537")]
	private String[] monthNames; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4001538")]
	private String[] genitiveMonthNames; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4001539")]
	private String[] m_genitiveAbbreviatedMonthNames; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x400153A")]
	private String[] leapYearMonthNames; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x400153B")]
	private string longDatePattern; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x400153C")]
	private string shortDatePattern; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x400153D")]
	private string yearMonthPattern; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x400153E")]
	private string longTimePattern; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x400153F")]
	private string shortTimePattern; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4001540")]
	private String[] allYearMonthPatterns; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4001541")]
	private String[] allShortDatePatterns; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4001542")]
	private String[] allLongDatePatterns; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4001543")]
	private String[] allShortTimePatterns; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4001544")]
	private String[] allLongTimePatterns; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4001545")]
	private String[] m_eraNames; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4001546")]
	private String[] m_abbrevEraNames; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4001547")]
	private String[] m_abbrevEnglishEraNames; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4001548")]
	private CalendarId[] optionalCalendars; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x400154A")]
	internal bool _isReadOnly; //Field offset: 0x140
	[FieldOffset(Offset = "0x144")]
	[Token(Token = "0x400154B")]
	private DateTimeFormatFlags formatFlags; //Field offset: 0x144
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x400154F")]
	private string _fullTimeSpanPositivePattern; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4001550")]
	private string _fullTimeSpanNegativePattern; //Field offset: 0x150
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x4001552")]
	private TokenHashValue[] _dtfiTokenHash; //Field offset: 0x158

	[Token(Token = "0x17000567")]
	public String[] AbbreviatedDayNames
	{
		[Address(RVA = "0x13DEDE0", Offset = "0x13DDFE0", Length = "0x8C")]
		[CalledBy(Type = typeof(DateTimeFormat), Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetAbbreviatedDayOfWeekNamesCore", ReturnType = typeof(String[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60025C4")]
		 get { } //Length: 140
	}

	[Token(Token = "0x17000556")]
	internal String[] AbbreviatedEnglishEraNames
	{
		[Address(RVA = "0x13DEE70", Offset = "0x13DE070", Length = "0x76")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CultureData), Member = "AbbreviatedEnglishEraNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60025B3")]
		internal get { } //Length: 118
	}

	[Token(Token = "0x17000555")]
	internal String[] AbbreviatedEraNames
	{
		[Address(RVA = "0x13DEEF0", Offset = "0x13DE0F0", Length = "0x76")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CultureData), Member = "AbbrevEraNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60025B1")]
		internal get { } //Length: 118
	}

	[Token(Token = "0x17000569")]
	public String[] AbbreviatedMonthNames
	{
		[Address(RVA = "0x13DEF70", Offset = "0x13DE170", Length = "0x8C")]
		[CalledBy(Type = typeof(DateTimeFormat), Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetAbbreviatedMonthNamesCore", ReturnType = typeof(String[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60025C6")]
		 get { } //Length: 140
	}

	[Token(Token = "0x17000570")]
	private String[] AllLongDatePatterns
	{
		[Address(RVA = "0x13DF000", Offset = "0x13DE200", Length = "0xAB")]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAllDateTimePatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(String[]))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedLongDatePatterns", ReturnType = typeof(String[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetMergedPatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(string)}, ReturnType = typeof(String[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60025D7")]
		private get { } //Length: 171
	}

	[Token(Token = "0x17000571")]
	private String[] AllLongTimePatterns
	{
		[Address(RVA = "0x13DF0B0", Offset = "0x13DE2B0", Length = "0xA0")]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAllDateTimePatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(String[]))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_LongTimePattern", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetMergedPatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(string)}, ReturnType = typeof(String[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60025D8")]
		private get { } //Length: 160
	}

	[Token(Token = "0x1700056E")]
	private String[] AllShortDatePatterns
	{
		[Address(RVA = "0x13DF160", Offset = "0x13DE360", Length = "0xAB")]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAllDateTimePatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(String[]))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedShortDatePatterns", ReturnType = typeof(String[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetMergedPatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(string)}, ReturnType = typeof(String[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60025D5")]
		private get { } //Length: 171
	}

	[Token(Token = "0x1700056F")]
	private String[] AllShortTimePatterns
	{
		[Address(RVA = "0x13DF210", Offset = "0x13DE410", Length = "0xA0")]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAllDateTimePatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(String[]))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_ShortTimePattern", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetMergedPatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(string)}, ReturnType = typeof(String[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60025D6")]
		private get { } //Length: 160
	}

	[Token(Token = "0x1700056D")]
	private String[] AllYearMonthPatterns
	{
		[Address(RVA = "0x13DF2C0", Offset = "0x13DE4C0", Length = "0xAB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedYearMonthPatterns", ReturnType = typeof(String[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetMergedPatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(string)}, ReturnType = typeof(String[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60025D4")]
		private get { } //Length: 171
	}

	[Token(Token = "0x17000551")]
	public string AMDesignator
	{
		[Address(RVA = "0x13DEDA0", Offset = "0x13DDFA0", Length = "0x39")]
		[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "AdjustTimeMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeFormatInfo), typeof(DateTimeRawInfo&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "MatchTimeMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(TM&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "MatchAbbreviatedTimeMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(TM&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60025AB")]
		 get { } //Length: 57
	}

	[Token(Token = "0x17000552")]
	public Calendar Calendar
	{
		[Address(RVA = "0x2DD190", Offset = "0x2DC390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60025AC")]
		 get { } //Length: 5
		[Address(RVA = "0x13E0ED0", Offset = "0x13E00D0", Length = "0x6D9")]
		[CalledBy(Type = typeof(DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTime&), typeof(DateTimeFormatInfo&), typeof(TimeSpan&)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData), typeof(Calendar)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetJapaneseCalendarDTFI", ReturnType = typeof(DateTimeFormatInfo))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetTaiwanCalendarDTFI", ReturnType = typeof(DateTimeFormatInfo))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(Boolean&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CultureData), Member = "DateSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CultureData), Member = "ShortDates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
		[Calls(Type = typeof(CultureData), Member = "LongDates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CultureData), Member = "GetCalendarIds", ReturnType = typeof(CalendarId[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CultureData), Member = "YearMonths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60025AD")]
		 set { } //Length: 1753
	}

	[Token(Token = "0x1700057B")]
	internal CompareInfo CompareInfo
	{
		[Address(RVA = "0x13DF370", Offset = "0x13DE570", Length = "0x12A")]
		[CalledBy(Type = typeof(__DTString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(__DTString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CultureData), Member = "get_SCOMPAREINFO", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60025E2")]
		internal get { } //Length: 298
	}

	[Token(Token = "0x1700054D")]
	private CultureInfo Culture
	{
		[Address(RVA = "0x13DF4E0", Offset = "0x13DE6E0", Length = "0x99")]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "Tokenize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenType), typeof(TokenType&), typeof(Int32&), typeof(__DTString&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InsertAtCurrentHashNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(string), typeof(char), typeof(TokenType), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InsertHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(string), typeof(TokenType), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CompareStringIgnoreCaseOptimized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002599")]
		private get { } //Length: 153
	}

	[Token(Token = "0x1700054C")]
	private string CultureName
	{
		[Address(RVA = "0x13DF4A0", Offset = "0x13DE6A0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002598")]
		private get { } //Length: 57
	}

	[Token(Token = "0x17000550")]
	public static DateTimeFormatInfo CurrentInfo
	{
		[Address(RVA = "0x13DF580", Offset = "0x13DE780", Length = "0x101")]
		[CalledBy(Type = typeof(DateTime), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(DateTimeFormatInfo))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60025A7")]
		 get { } //Length: 257
	}

	[Token(Token = "0x17000557")]
	public string DateSeparator
	{
		[Address(RVA = "0x13DF690", Offset = "0x13DE890", Length = "0x6A")]
		[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(TokenHashValue[]))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(Boolean&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CultureData), Member = "DateSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60025B4")]
		 get { } //Length: 106
	}

	[Token(Token = "0x17000563")]
	internal string DateTimeOffsetPattern
	{
		[Address(RVA = "0x13DF700", Offset = "0x13DE900", Length = "0x258")]
		[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatStringBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan)}, ReturnType = typeof(StringBuilder))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedShortDatePatterns", ReturnType = typeof(String[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_LongTimePattern", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60025C0")]
		internal get { } //Length: 600
	}

	[Token(Token = "0x17000568")]
	public String[] DayNames
	{
		[Address(RVA = "0x13DF960", Offset = "0x13DEB60", Length = "0x8C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetDayOfWeekNamesCore", ReturnType = typeof(String[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60025C5")]
		 get { } //Length: 140
	}

	[Token(Token = "0x17000554")]
	internal String[] EraNames
	{
		[Address(RVA = "0x13DF9F0", Offset = "0x13DEBF0", Length = "0x76")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CultureData), Member = "EraNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60025AF")]
		internal get { } //Length: 118
	}

	[Token(Token = "0x1700057C")]
	internal DateTimeFormatFlags FormatFlags
	{
		[Address(RVA = "0x13DFA70", Offset = "0x13DEC70", Length = "0x17")]
		[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "MatchAbbreviatedMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "MatchMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "DoStrictParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeStyles), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(__DTString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(__DTString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
		[Token(Token = "0x60025E4")]
		internal get { } //Length: 23
	}

	[Token(Token = "0x17000558")]
	public string FullDateTimePattern
	{
		[Address(RVA = "0x13DFA90", Offset = "0x13DEC90", Length = "0xC3")]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedLongDatePatterns", ReturnType = typeof(String[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_LongTimePattern", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60025B5")]
		 get { } //Length: 195
	}

	[Token(Token = "0x1700057A")]
	internal string FullTimeSpanNegativePattern
	{
		[Address(RVA = "0x13DFB60", Offset = "0x13DED60", Length = "0x140")]
		[CalledBy(Type = typeof(TimeSpanFormat), Member = "FormatToBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(StringBuilder))]
		[CalledBy(Type = "System.Globalization.TimeSpanParse+TimeSpanRawInfo", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeFormatInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(IFormatProvider), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CultureData), Member = "GetCultureData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(CultureData))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NumberFormatInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60025E1")]
		internal get { } //Length: 320
	}

	[Token(Token = "0x17000579")]
	internal string FullTimeSpanPositivePattern
	{
		[Address(RVA = "0x13DFCB0", Offset = "0x13DEEB0", Length = "0xEA")]
		[CalledBy(Type = typeof(TimeSpanFormat), Member = "FormatToBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(StringBuilder))]
		[CalledBy(Type = "System.Globalization.TimeSpanParse+TimeSpanRawInfo", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeFormatInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(IFormatProvider), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CultureData), Member = "GetCultureData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(CultureData))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NumberFormatInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60025E0")]
		internal get { } //Length: 234
	}

	[Token(Token = "0x17000562")]
	internal string GeneralLongTimePattern
	{
		[Address(RVA = "0x13DFDA0", Offset = "0x13DEFA0", Length = "0xB7")]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedShortDatePatterns", ReturnType = typeof(String[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_LongTimePattern", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60025BF")]
		internal get { } //Length: 183
	}

	[Token(Token = "0x17000561")]
	internal string GeneralShortTimePattern
	{
		[Address(RVA = "0x13DFE60", Offset = "0x13DF060", Length = "0xB7")]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedShortDatePatterns", ReturnType = typeof(String[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_ShortTimePattern", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60025BE")]
		internal get { } //Length: 183
	}

	[Token(Token = "0x1700057D")]
	internal bool HasForceTwoDigitYears
	{
		[Address(RVA = "0x13DFF20", Offset = "0x13DF120", Length = "0x36")]
		[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60025E6")]
		internal get { } //Length: 54
	}

	[Token(Token = "0x1700056C")]
	internal bool HasSpacesInDayNames
	{
		[Address(RVA = "0x13DFF60", Offset = "0x13DF160", Length = "0x2E")]
		[CalledBy(Type = typeof(DateTimeParse), Member = "MatchAbbreviatedDayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "MatchDayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60025C9")]
		internal get { } //Length: 46
	}

	[Token(Token = "0x1700056B")]
	internal bool HasSpacesInMonthNames
	{
		[Address(RVA = "0x13DFF90", Offset = "0x13DF190", Length = "0x2E")]
		[CalledBy(Type = typeof(DateTimeParse), Member = "MatchAbbreviatedMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "MatchMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60025C8")]
		internal get { } //Length: 46
	}

	[Token(Token = "0x1700057E")]
	internal bool HasYearMonthAdjustment
	{
		[Address(RVA = "0x13DFFC0", Offset = "0x13DF1C0", Length = "0x2E")]
		[CalledBy(Type = typeof(DateTimeParse), Member = "DoStrictParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeStyles), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60025E7")]
		internal get { } //Length: 46
	}

	[Token(Token = "0x1700054F")]
	public static DateTimeFormatInfo InvariantInfo
	{
		[Address(RVA = "0x13DFFF0", Offset = "0x13DF1F0", Length = "0x10C")]
		[CalledBy(Type = "Mirror.BouncyCastle.Asn1.Asn1UtcTime", Member = "GetContents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "System.Byte[]")]
		[CalledBy(Type = "System.Net.Http.Headers.Lexer", Member = "TryGetDateValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Mirror.BouncyCastle.Asn1.Asn1UtcTime", Member = "ToStringCanonical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
		[CalledBy(Type = "Mirror.BouncyCastle.Asn1.Asn1UtcTime", Member = "FromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(DateTime))]
		[CalledBy(Type = "Mirror.BouncyCastle.Asn1.Asn1GeneralizedTime", Member = "ToStringCanonical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
		[CalledBy(Type = "Mirror.BouncyCastle.Asn1.Asn1GeneralizedTime", Member = "ParseUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(DateTime))]
		[CalledBy(Type = "Mirror.BouncyCastle.Asn1.Asn1GeneralizedTime", Member = "ParseTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(DateTime))]
		[CalledBy(Type = "Mirror.BouncyCastle.Asn1.Asn1GeneralizedTime", Member = "GetContents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "System.Byte[]")]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(TokenHashValue[]))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatStringBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan)}, ReturnType = typeof(StringBuilder))]
		[CalledBy(Type = typeof(DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTime&), typeof(DateTimeFormatInfo&), typeof(TimeSpan&)}, ReturnType = typeof(string))]
		[CalledBy(Type = "Mirror.BouncyCastle.Asn1.Asn1GeneralizedTime", Member = "ParseLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(DateTime))]
		[CallerCount(Count = 21)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60025A6")]
		 get { } //Length: 268
	}

	[Token(Token = "0x17000577")]
	public bool IsReadOnly
	{
		[Address(RVA = "0x13E0100", Offset = "0x13DF300", Length = "0x8D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60025DE")]
		 get { } //Length: 141
	}

	[Token(Token = "0x1700054E")]
	private string LanguageName
	{
		[Address(RVA = "0x13E0190", Offset = "0x13DF390", Length = "0x39")]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(Boolean&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600259A")]
		private get { } //Length: 57
	}

	[Token(Token = "0x17000559")]
	public string LongDatePattern
	{
		[Address(RVA = "0x13E01D0", Offset = "0x13DF3D0", Length = "0x54")]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedLongDatePatterns", ReturnType = typeof(String[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60025B6")]
		 get { } //Length: 84
	}

	[Token(Token = "0x1700055A")]
	public string LongTimePattern
	{
		[Address(RVA = "0x13E0230", Offset = "0x13DF430", Length = "0x84")]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_FullDateTimePattern", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_GeneralLongTimePattern", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_DateTimeOffsetPattern", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AllLongTimePatterns", ReturnType = typeof(String[]))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60025B7")]
		 get { } //Length: 132
	}

	[Token(Token = "0x1700055B")]
	public string MonthDayPattern
	{
		[Address(RVA = "0x13E02C0", Offset = "0x13DF4C0", Length = "0x6A")]
		[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfNN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfMN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "GetHebrewDayOfNM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfNM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeFormatInfoScanner), Member = "GetDateWordsOfDTFI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeFormatInfo)}, ReturnType = typeof(String[]))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(CultureData), Member = "MonthDay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60025B8")]
		 get { } //Length: 106
	}

	[Token(Token = "0x17000578")]
	public String[] MonthGenitiveNames
	{
		[Address(RVA = "0x13E0330", Offset = "0x13DF530", Length = "0xCC")]
		[CalledBy(Type = typeof(DateTimeParse), Member = "MatchMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CultureData), Member = "GenitiveMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60025DF")]
		 get { } //Length: 204
	}

	[Token(Token = "0x1700056A")]
	public String[] MonthNames
	{
		[Address(RVA = "0x13E0400", Offset = "0x13DF600", Length = "0x8C")]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetMonthNamesCore", ReturnType = typeof(String[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60025C7")]
		 get { } //Length: 140
	}

	[Token(Token = "0x17000553")]
	private CalendarId[] OptionalCalendars
	{
		[Address(RVA = "0x13E0490", Offset = "0x13DF690", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CultureData), Member = "GetCalendarIds", ReturnType = typeof(CalendarId[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60025AE")]
		private get { } //Length: 75
	}

	[Token(Token = "0x1700055C")]
	public string PMDesignator
	{
		[Address(RVA = "0x13E04E0", Offset = "0x13DF6E0", Length = "0x39")]
		[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "AdjustTimeMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeFormatInfo), typeof(DateTimeRawInfo&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "MatchTimeMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(TM&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "MatchAbbreviatedTimeMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(TM&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60025B9")]
		 get { } //Length: 57
	}

	[Token(Token = "0x1700055D")]
	public string RFC1123Pattern
	{
		[Address(RVA = "0x13E0520", Offset = "0x13DF720", Length = "0x2C")]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60025BA")]
		 get { } //Length: 44
	}

	[Token(Token = "0x1700055E")]
	public string ShortDatePattern
	{
		[Address(RVA = "0x13E0550", Offset = "0x13DF750", Length = "0x54")]
		[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfNNN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfMNN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfYNN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfNNY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "GetDateOfNNDS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
		[CalledBy(Type = "System.ComponentModel.DateTimeConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedShortDatePatterns", ReturnType = typeof(String[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60025BB")]
		 get { } //Length: 84
	}

	[Token(Token = "0x1700055F")]
	public string ShortTimePattern
	{
		[Address(RVA = "0x13E05B0", Offset = "0x13DF7B0", Length = "0x84")]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_GeneralShortTimePattern", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AllShortTimePatterns", ReturnType = typeof(String[]))]
		[CalledBy(Type = "System.ComponentModel.DateTimeConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60025BC")]
		 get { } //Length: 132
	}

	[Token(Token = "0x17000560")]
	public string SortableDateTimePattern
	{
		[Address(RVA = "0x13E0640", Offset = "0x13DF840", Length = "0x2C")]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60025BD")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000564")]
	public string TimeSeparator
	{
		[Address(RVA = "0x13E0670", Offset = "0x13DF870", Length = "0x39")]
		[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(TokenHashValue[]))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60025C1")]
		 get { } //Length: 57
	}

	[Token(Token = "0x17000574")]
	private String[] UnclonedLongDatePatterns
	{
		[Address(RVA = "0x13E06B0", Offset = "0x13DF8B0", Length = "0x76")]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_FullDateTimePattern", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_LongDatePattern", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AllLongDatePatterns", ReturnType = typeof(String[]))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CultureData), Member = "LongDates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60025DB")]
		private get { } //Length: 118
	}

	[Token(Token = "0x17000576")]
	private String[] UnclonedLongTimePatterns
	{
		[Address(RVA = "0x13E0730", Offset = "0x13DF930", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60025DD")]
		private get { } //Length: 75
	}

	[Token(Token = "0x17000573")]
	private String[] UnclonedShortDatePatterns
	{
		[Address(RVA = "0x13E0780", Offset = "0x13DF980", Length = "0x76")]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_ShortDatePattern", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_GeneralShortTimePattern", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_GeneralLongTimePattern", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_DateTimeOffsetPattern", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AllShortDatePatterns", ReturnType = typeof(String[]))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CultureData), Member = "ShortDates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60025DA")]
		private get { } //Length: 118
	}

	[Token(Token = "0x17000575")]
	private String[] UnclonedShortTimePatterns
	{
		[Address(RVA = "0x13E0800", Offset = "0x13DFA00", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60025DC")]
		private get { } //Length: 75
	}

	[Token(Token = "0x17000572")]
	private String[] UnclonedYearMonthPatterns
	{
		[Address(RVA = "0x13E0850", Offset = "0x13DFA50", Length = "0x76")]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_YearMonthPattern", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAllDateTimePatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(String[]))]
		[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AllYearMonthPatterns", ReturnType = typeof(String[]))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CultureData), Member = "YearMonths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60025D9")]
		private get { } //Length: 118
	}

	[Token(Token = "0x17000565")]
	public string UniversalSortableDateTimePattern
	{
		[Address(RVA = "0x13E08D0", Offset = "0x13DFAD0", Length = "0x2C")]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60025C2")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000566")]
	public string YearMonthPattern
	{
		[Address(RVA = "0x13E0900", Offset = "0x13DFB00", Length = "0x54")]
		[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfMN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfNM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedYearMonthPatterns", ReturnType = typeof(String[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60025C3")]
		 get { } //Length: 84
	}

	[Address(RVA = "0x13DEA00", Offset = "0x13DDC00", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60025F7")]
	private static DateTimeFormatInfo() { }

	[Address(RVA = "0x13DEAA0", Offset = "0x13DDCA0", Length = "0x281")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(DateTimeFormatInfo))]
	[CalledBy(Type = typeof(CultureInfo), Member = "get_DateTimeFormat", ReturnType = typeof(DateTimeFormatInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(GregorianCalendar), Member = "GetDefaultInstance", ReturnType = typeof(Calendar))]
	[Calls(Type = typeof(CultureData), Member = "DateSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureData), Member = "LongDates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CultureData), Member = "ShortDates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CultureData), Member = "YearMonths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60025A3")]
	public DateTimeFormatInfo() { }

	[Address(RVA = "0x13DED30", Offset = "0x13DDF30", Length = "0x61")]
	[CalledBy(Type = typeof(CultureInfo), Member = "get_DateTimeFormat", ReturnType = typeof(DateTimeFormatInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "set_Calendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Calendar)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60025A4")]
	internal DateTimeFormatInfo(CultureData cultureData, Calendar cal) { }

	[Address(RVA = "0x13D9C40", Offset = "0x13D8E40", Length = "0xCD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "InsertHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(string), typeof(TokenType), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetAbbreviatedMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60025EF")]
	private void AddMonthNames(TokenHashValue[] temp, string monthPostfix) { }

	[Address(RVA = "0x13D9D10", Offset = "0x13D8F10", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60025EB")]
	private void ClearTokenHashTable() { }

	[Address(RVA = "0x13D9D50", Offset = "0x13D8F50", Length = "0x142")]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTime&), typeof(DateTimeFormatInfo&), typeof(TimeSpan&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(CultureInfo), Member = "Clone", ReturnType = typeof(object))]
	[CalledBy(Type = "System.Security.Cryptography.DerSequenceReader+<>c", Member = "<ReadTime>b__51_0", ReturnType = typeof(DateTimeFormatInfo))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60025AA")]
	public override object Clone() { }

	[Address(RVA = "0x13D9EA0", Offset = "0x13D90A0", Length = "0x117")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_Culture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60025F6")]
	private bool CompareStringIgnoreCaseOptimized(string string1, int offset1, int length1, string string2, int offset2, int length2) { }

	[Address(RVA = "0x13D9FC0", Offset = "0x13D91C0", Length = "0xC45")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "Tokenize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenType), typeof(TokenType&), typeof(Int32&), typeof(__DTString&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetDayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DayOfWeek)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetAbbreviatedDayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DayOfWeek)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetEraName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetAbbreviatedEraName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(DateTimeFormatInfo))]
	[Calls(Type = typeof(CultureData), Member = "AbbreviatedEnglishEraNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(MonthNameStyles), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CultureData), Member = "GenitiveMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetAbbreviatedMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_DateSeparator", ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_TimeSeparator", ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "InsertHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(string), typeof(TokenType), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60025EC")]
	internal TokenHashValue[] CreateTokenHashTable() { }

	[Address(RVA = "0x13DEDE0", Offset = "0x13DDFE0", Length = "0x8C")]
	[CalledBy(Type = typeof(DateTimeFormat), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetAbbreviatedDayOfWeekNamesCore", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60025C4")]
	public String[] get_AbbreviatedDayNames() { }

	[Address(RVA = "0x13DEE70", Offset = "0x13DE070", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureData), Member = "AbbreviatedEnglishEraNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60025B3")]
	internal String[] get_AbbreviatedEnglishEraNames() { }

	[Address(RVA = "0x13DEEF0", Offset = "0x13DE0F0", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureData), Member = "AbbrevEraNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60025B1")]
	internal String[] get_AbbreviatedEraNames() { }

	[Address(RVA = "0x13DEF70", Offset = "0x13DE170", Length = "0x8C")]
	[CalledBy(Type = typeof(DateTimeFormat), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetAbbreviatedMonthNamesCore", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60025C6")]
	public String[] get_AbbreviatedMonthNames() { }

	[Address(RVA = "0x13DF000", Offset = "0x13DE200", Length = "0xAB")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAllDateTimePatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(String[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedLongDatePatterns", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetMergedPatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(string)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60025D7")]
	private String[] get_AllLongDatePatterns() { }

	[Address(RVA = "0x13DF0B0", Offset = "0x13DE2B0", Length = "0xA0")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAllDateTimePatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(String[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_LongTimePattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetMergedPatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(string)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60025D8")]
	private String[] get_AllLongTimePatterns() { }

	[Address(RVA = "0x13DF160", Offset = "0x13DE360", Length = "0xAB")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAllDateTimePatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(String[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedShortDatePatterns", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetMergedPatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(string)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60025D5")]
	private String[] get_AllShortDatePatterns() { }

	[Address(RVA = "0x13DF210", Offset = "0x13DE410", Length = "0xA0")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAllDateTimePatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(String[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_ShortTimePattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetMergedPatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(string)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60025D6")]
	private String[] get_AllShortTimePatterns() { }

	[Address(RVA = "0x13DF2C0", Offset = "0x13DE4C0", Length = "0xAB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedYearMonthPatterns", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetMergedPatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(string)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60025D4")]
	private String[] get_AllYearMonthPatterns() { }

	[Address(RVA = "0x13DEDA0", Offset = "0x13DDFA0", Length = "0x39")]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "AdjustTimeMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeFormatInfo), typeof(DateTimeRawInfo&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchTimeMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(TM&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchAbbreviatedTimeMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(TM&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60025AB")]
	public string get_AMDesignator() { }

	[Address(RVA = "0x2DD190", Offset = "0x2DC390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60025AC")]
	public Calendar get_Calendar() { }

	[Address(RVA = "0x13DF370", Offset = "0x13DE570", Length = "0x12A")]
	[CalledBy(Type = typeof(__DTString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__DTString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CultureData), Member = "get_SCOMPAREINFO", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60025E2")]
	internal CompareInfo get_CompareInfo() { }

	[Address(RVA = "0x13DF4E0", Offset = "0x13DE6E0", Length = "0x99")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "Tokenize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenType), typeof(TokenType&), typeof(Int32&), typeof(__DTString&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InsertAtCurrentHashNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(string), typeof(char), typeof(TokenType), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InsertHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(string), typeof(TokenType), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CompareStringIgnoreCaseOptimized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002599")]
	private CultureInfo get_Culture() { }

	[Address(RVA = "0x13DF4A0", Offset = "0x13DE6A0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002598")]
	private string get_CultureName() { }

	[Address(RVA = "0x13DF580", Offset = "0x13DE780", Length = "0x101")]
	[CalledBy(Type = typeof(DateTime), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(DateTimeFormatInfo))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60025A7")]
	public static DateTimeFormatInfo get_CurrentInfo() { }

	[Address(RVA = "0x13DF690", Offset = "0x13DE890", Length = "0x6A")]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(TokenHashValue[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CultureData), Member = "DateSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60025B4")]
	public string get_DateSeparator() { }

	[Address(RVA = "0x13DF700", Offset = "0x13DE900", Length = "0x258")]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatStringBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan)}, ReturnType = typeof(StringBuilder))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedShortDatePatterns", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_LongTimePattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60025C0")]
	internal string get_DateTimeOffsetPattern() { }

	[Address(RVA = "0x13DF960", Offset = "0x13DEB60", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetDayOfWeekNamesCore", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60025C5")]
	public String[] get_DayNames() { }

	[Address(RVA = "0x13DF9F0", Offset = "0x13DEBF0", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureData), Member = "EraNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60025AF")]
	internal String[] get_EraNames() { }

	[Address(RVA = "0x13DFA70", Offset = "0x13DEC70", Length = "0x17")]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchAbbreviatedMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "DoStrictParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeStyles), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(__DTString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__DTString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
	[Token(Token = "0x60025E4")]
	internal DateTimeFormatFlags get_FormatFlags() { }

	[Address(RVA = "0x13DFA90", Offset = "0x13DEC90", Length = "0xC3")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedLongDatePatterns", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_LongTimePattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60025B5")]
	public string get_FullDateTimePattern() { }

	[Address(RVA = "0x13DFB60", Offset = "0x13DED60", Length = "0x140")]
	[CalledBy(Type = typeof(TimeSpanFormat), Member = "FormatToBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = "System.Globalization.TimeSpanParse+TimeSpanRawInfo", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeFormatInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(IFormatProvider), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CultureData), Member = "GetCultureData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(CultureData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NumberFormatInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60025E1")]
	internal string get_FullTimeSpanNegativePattern() { }

	[Address(RVA = "0x13DFCB0", Offset = "0x13DEEB0", Length = "0xEA")]
	[CalledBy(Type = typeof(TimeSpanFormat), Member = "FormatToBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = "System.Globalization.TimeSpanParse+TimeSpanRawInfo", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeFormatInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(IFormatProvider), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CultureData), Member = "GetCultureData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(CultureData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NumberFormatInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60025E0")]
	internal string get_FullTimeSpanPositivePattern() { }

	[Address(RVA = "0x13DFDA0", Offset = "0x13DEFA0", Length = "0xB7")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedShortDatePatterns", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_LongTimePattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60025BF")]
	internal string get_GeneralLongTimePattern() { }

	[Address(RVA = "0x13DFE60", Offset = "0x13DF060", Length = "0xB7")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedShortDatePatterns", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_ShortTimePattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60025BE")]
	internal string get_GeneralShortTimePattern() { }

	[Address(RVA = "0x13DFF20", Offset = "0x13DF120", Length = "0x36")]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60025E6")]
	internal bool get_HasForceTwoDigitYears() { }

	[Address(RVA = "0x13DFF60", Offset = "0x13DF160", Length = "0x2E")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchAbbreviatedDayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchDayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60025C9")]
	internal bool get_HasSpacesInDayNames() { }

	[Address(RVA = "0x13DFF90", Offset = "0x13DF190", Length = "0x2E")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchAbbreviatedMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60025C8")]
	internal bool get_HasSpacesInMonthNames() { }

	[Address(RVA = "0x13DFFC0", Offset = "0x13DF1C0", Length = "0x2E")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "DoStrictParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeStyles), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60025E7")]
	internal bool get_HasYearMonthAdjustment() { }

	[Address(RVA = "0x13DFFF0", Offset = "0x13DF1F0", Length = "0x10C")]
	[CalledBy(Type = "Mirror.BouncyCastle.Asn1.Asn1GeneralizedTime", Member = "ParseLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTime&), typeof(DateTimeFormatInfo&), typeof(TimeSpan&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(TokenHashValue[]))]
	[CalledBy(Type = "Mirror.BouncyCastle.Asn1.Asn1GeneralizedTime", Member = "GetContents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mirror.BouncyCastle.Asn1.Asn1GeneralizedTime", Member = "ParseTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatStringBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = "Mirror.BouncyCastle.Asn1.Asn1GeneralizedTime", Member = "ToStringCanonical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Mirror.BouncyCastle.Asn1.Asn1UtcTime", Member = "FromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "Mirror.BouncyCastle.Asn1.Asn1UtcTime", Member = "ToStringCanonical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Net.Http.Headers.Lexer", Member = "TryGetDateValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mirror.BouncyCastle.Asn1.Asn1UtcTime", Member = "GetContents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mirror.BouncyCastle.Asn1.Asn1GeneralizedTime", Member = "ParseUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60025A6")]
	public static DateTimeFormatInfo get_InvariantInfo() { }

	[Address(RVA = "0x13E0100", Offset = "0x13DF300", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60025DE")]
	public bool get_IsReadOnly() { }

	[Address(RVA = "0x13E0190", Offset = "0x13DF390", Length = "0x39")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600259A")]
	private string get_LanguageName() { }

	[Address(RVA = "0x13E01D0", Offset = "0x13DF3D0", Length = "0x54")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedLongDatePatterns", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60025B6")]
	public string get_LongDatePattern() { }

	[Address(RVA = "0x13E0230", Offset = "0x13DF430", Length = "0x84")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_FullDateTimePattern", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_GeneralLongTimePattern", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_DateTimeOffsetPattern", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AllLongTimePatterns", ReturnType = typeof(String[]))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60025B7")]
	public string get_LongTimePattern() { }

	[Address(RVA = "0x13E02C0", Offset = "0x13DF4C0", Length = "0x6A")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfNN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfMN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetHebrewDayOfNM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfNM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfoScanner), Member = "GetDateWordsOfDTFI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeFormatInfo)}, ReturnType = typeof(String[]))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CultureData), Member = "MonthDay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60025B8")]
	public string get_MonthDayPattern() { }

	[Address(RVA = "0x13E0330", Offset = "0x13DF530", Length = "0xCC")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CultureData), Member = "GenitiveMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60025DF")]
	public String[] get_MonthGenitiveNames() { }

	[Address(RVA = "0x13E0400", Offset = "0x13DF600", Length = "0x8C")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetMonthNamesCore", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60025C7")]
	public String[] get_MonthNames() { }

	[Address(RVA = "0x13E0490", Offset = "0x13DF690", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureData), Member = "GetCalendarIds", ReturnType = typeof(CalendarId[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60025AE")]
	private CalendarId[] get_OptionalCalendars() { }

	[Address(RVA = "0x13E04E0", Offset = "0x13DF6E0", Length = "0x39")]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "AdjustTimeMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeFormatInfo), typeof(DateTimeRawInfo&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchTimeMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(TM&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchAbbreviatedTimeMark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(TM&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60025B9")]
	public string get_PMDesignator() { }

	[Address(RVA = "0x13E0520", Offset = "0x13DF720", Length = "0x2C")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60025BA")]
	public string get_RFC1123Pattern() { }

	[Address(RVA = "0x13E0550", Offset = "0x13DF750", Length = "0x54")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfNNN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfMNN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfYNN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfNNY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDateOfNNDS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ProcessTerminalState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.ComponentModel.DateTimeConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedShortDatePatterns", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60025BB")]
	public string get_ShortDatePattern() { }

	[Address(RVA = "0x13E05B0", Offset = "0x13DF7B0", Length = "0x84")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_GeneralShortTimePattern", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AllShortTimePatterns", ReturnType = typeof(String[]))]
	[CalledBy(Type = "System.ComponentModel.DateTimeConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60025BC")]
	public string get_ShortTimePattern() { }

	[Address(RVA = "0x13E0640", Offset = "0x13DF840", Length = "0x2C")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60025BD")]
	public string get_SortableDateTimePattern() { }

	[Address(RVA = "0x13E0670", Offset = "0x13DF870", Length = "0x39")]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(TokenHashValue[]))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60025C1")]
	public string get_TimeSeparator() { }

	[Address(RVA = "0x13E06B0", Offset = "0x13DF8B0", Length = "0x76")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_FullDateTimePattern", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_LongDatePattern", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AllLongDatePatterns", ReturnType = typeof(String[]))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CultureData), Member = "LongDates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60025DB")]
	private String[] get_UnclonedLongDatePatterns() { }

	[Address(RVA = "0x13E0730", Offset = "0x13DF930", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60025DD")]
	private String[] get_UnclonedLongTimePatterns() { }

	[Address(RVA = "0x13E0780", Offset = "0x13DF980", Length = "0x76")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_ShortDatePattern", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_GeneralShortTimePattern", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_GeneralLongTimePattern", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_DateTimeOffsetPattern", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AllShortDatePatterns", ReturnType = typeof(String[]))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CultureData), Member = "ShortDates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60025DA")]
	private String[] get_UnclonedShortDatePatterns() { }

	[Address(RVA = "0x13E0800", Offset = "0x13DFA00", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60025DC")]
	private String[] get_UnclonedShortTimePatterns() { }

	[Address(RVA = "0x13E0850", Offset = "0x13DFA50", Length = "0x76")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_YearMonthPattern", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAllDateTimePatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AllYearMonthPatterns", ReturnType = typeof(String[]))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CultureData), Member = "YearMonths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60025D9")]
	private String[] get_UnclonedYearMonthPatterns() { }

	[Address(RVA = "0x13E08D0", Offset = "0x13DFAD0", Length = "0x2C")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60025C2")]
	public string get_UniversalSortableDateTimePattern() { }

	[Address(RVA = "0x13E0900", Offset = "0x13DFB00", Length = "0x54")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfMN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetDayOfNM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(DateTimeStyles&), typeof(DateTimeRawInfo&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedYearMonthPatterns", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60025C3")]
	public string get_YearMonthPattern() { }

	[Address(RVA = "0x13DAC10", Offset = "0x13D9E10", Length = "0x10A")]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatDayOfWeek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(DateTimeFormatInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchAbbreviatedDayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(TokenHashValue[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetAbbreviatedDayOfWeekNamesCore", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Token(Token = "0x60025CD")]
	public string GetAbbreviatedDayName(DayOfWeek dayofweek) { }

	[Address(RVA = "0x13DAD20", Offset = "0x13D9F20", Length = "0x166")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchEraName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(TokenHashValue[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CultureData), Member = "AbbrevEraNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetEraName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60025B2")]
	public string GetAbbreviatedEraName(int era) { }

	[Address(RVA = "0x13DAE90", Offset = "0x13DA090", Length = "0x101")]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatMonth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(DateTimeFormatInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatHebrewMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(int), typeof(DateTimeFormatInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchAbbreviatedMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(TokenHashValue[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "AddMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetAbbreviatedMonthNamesCore", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Token(Token = "0x60025D1")]
	public string GetAbbreviatedMonthName(int month) { }

	[Address(RVA = "0x13DAFA0", Offset = "0x13DA1A0", Length = "0x484")]
	[CalledBy(Type = typeof(DateTimeFormatInfoScanner), Member = "GetDateWordsOfDTFI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeFormatInfo)}, ReturnType = typeof(String[]))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_AllLongTimePatterns", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CultureData), Member = "MonthDay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetMergedPatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(string)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedYearMonthPatterns", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_AllLongDatePatterns", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetCombinedPatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(String[]), typeof(string)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_AllShortDatePatterns", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_AllShortTimePatterns", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60025CF")]
	public String[] GetAllDateTimePatterns(char format) { }

	[Address(RVA = "0x13DB480", Offset = "0x13DA680", Length = "0x172")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAllDateTimePatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(String[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60025CE")]
	private static String[] GetCombinedPatterns(String[] patterns1, String[] patterns2, string connectString) { }

	[Address(RVA = "0x13DB600", Offset = "0x13DA800", Length = "0x10A")]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatDayOfWeek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(DateTimeFormatInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchDayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseByFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(__DTString&), typeof(ParsingInfo&), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(TokenHashValue[]))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetDayOfWeekNamesCore", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x60025D0")]
	public string GetDayName(DayOfWeek dayofweek) { }

	[Address(RVA = "0x13DB710", Offset = "0x13DA910", Length = "0x13C")]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchEraName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAbbreviatedEraName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(TokenHashValue[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CultureData), Member = "EraNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60025B0")]
	public string GetEraName(int era) { }

	[Address(RVA = "0x13DB850", Offset = "0x13DAA50", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60025A9")]
	public override object GetFormat(Type formatType) { }

	[Address(RVA = "0x13DB8D0", Offset = "0x13DAAD0", Length = "0x1C5")]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(TimeSpan)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), "System.Globalization.TimeSpanParse+TimeSpanStandardStyles", typeof(IFormatProvider), typeof(TimeSpanResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeSpanFormat), Member = "FormatToBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "TryParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(IFormatProvider), typeof(DateTimeStyles), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(string), typeof(IFormatProvider), typeof(TimeSpan)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTime), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTime), Member = "ParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTime), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTime), Member = "TryParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(DateTimeFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60025A8")]
	public static DateTimeFormatInfo GetInstance(IFormatProvider provider) { }

	[Address(RVA = "0x13DBAA0", Offset = "0x13DACA0", Length = "0x1AF")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "Lex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeToken&), typeof(DateTimeRawInfo&), typeof(DateTimeResult&), typeof(DateTimeFormatInfo&), typeof(DateTimeStyles)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JapaneseCalendar), Member = "GetDefaultInstance", ReturnType = typeof(Calendar))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "set_Calendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Calendar)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60025E9")]
	internal static DateTimeFormatInfo GetJapaneseCalendarDTFI() { }

	[Address(RVA = "0x13DBC50", Offset = "0x13DAE50", Length = "0x1C4")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAllDateTimePatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AllYearMonthPatterns", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AllShortDatePatterns", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AllShortTimePatterns", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AllLongDatePatterns", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AllLongTimePatterns", ReturnType = typeof(String[]))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60025D3")]
	private static String[] GetMergedPatterns(String[] patterns, string defaultPattern) { }

	[Address(RVA = "0x13DBE20", Offset = "0x13DB020", Length = "0x101")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "AddMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatMonth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(DateTimeFormatInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatHebrewMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(int), typeof(DateTimeFormatInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchAbbreviatedMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(TokenHashValue[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetMonthNamesCore", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Token(Token = "0x60025D2")]
	public string GetMonthName(int month) { }

	[Address(RVA = "0x13DBF30", Offset = "0x13DB130", Length = "0x1AF")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "Lex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeToken&), typeof(DateTimeRawInfo&), typeof(DateTimeResult&), typeof(DateTimeFormatInfo&), typeof(DateTimeStyles)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TaiwanCalendar), Member = "GetDefaultInstance", ReturnType = typeof(Calendar))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "set_Calendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Calendar)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60025EA")]
	internal static DateTimeFormatInfo GetTaiwanCalendarDTFI() { }

	[Address(RVA = "0x13DC0E0", Offset = "0x13DB2E0", Length = "0x35D")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_HasSpacesInMonthNames", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_HasSpacesInDayNames", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_FormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_HasYearMonthAdjustment", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "YearMonthAdjustment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(TokenHashValue[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "Tokenize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenType), typeof(TokenType&), typeof(Int32&), typeof(__DTString&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetAbbreviatedDayOfWeekNamesCore", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DateTimeFormatInfoScanner), Member = "GetFormatFlagUseHebrewCalendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(FORMATFLAGS))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetDayOfWeekNamesCore", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DateTimeFormatInfoScanner), Member = "GetFormatFlagUseSpaceInDayNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(String[])}, ReturnType = typeof(FORMATFLAGS))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CultureData), Member = "GenitiveMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DateTimeFormatInfoScanner), Member = "GetFormatFlagGenitiveMonth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(String[]), typeof(String[]), typeof(String[])}, ReturnType = typeof(FORMATFLAGS))]
	[Calls(Type = typeof(CultureData), Member = "AbbreviatedGenitiveMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_AbbreviatedMonthNames", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_MonthNames", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DateTimeFormatInfoScanner), Member = "GetFormatFlagUseSpaceInMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(String[]), typeof(String[]), typeof(String[])}, ReturnType = typeof(FORMATFLAGS))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x60025E5")]
	private DateTimeFormatFlags InitializeFormatFlags() { }

	[Address(RVA = "0x13DC440", Offset = "0x13DB640", Length = "0x1B4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CultureData), Member = "DateSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureData), Member = "LongDates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CultureData), Member = "ShortDates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CultureData), Member = "YearMonths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60025A5")]
	private void InitializeOverridableProperties(CultureData cultureData, int calendarId) { }

	[Address(RVA = "0x13DC600", Offset = "0x13DB800", Length = "0x257")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InsertHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(string), typeof(TokenType), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_Culture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60025F4")]
	private void InsertAtCurrentHashNode(TokenHashValue[] hashTable, string str, char ch, TokenType tokenType, int tokenValue, int pos, int hashcode, int hashProbe) { }

	[Address(RVA = "0x13DC860", Offset = "0x13DBA60", Length = "0x425")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(TokenHashValue[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "AddMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 58)]
	[Calls(Type = typeof(string), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "InsertAtCurrentHashNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(string), typeof(char), typeof(TokenType), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_Culture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60025F5")]
	private void InsertHash(TokenHashValue[] hashTable, string str, TokenType tokenType, int tokenValue) { }

	[Address(RVA = "0x13E09D0", Offset = "0x13DFBD0", Length = "0x14")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetAbbreviatedDayOfWeekNamesCore", ReturnType = typeof(String[]))]
	[Token(Token = "0x600259B")]
	private String[] internalGetAbbreviatedDayOfWeekNames() { }

	[Address(RVA = "0x13E0960", Offset = "0x13DFB60", Length = "0x6C")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "internalGetAbbreviatedDayOfWeekNames", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AbbreviatedDayNames", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAbbreviatedDayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DayOfWeek)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CultureData), Member = "AbbreviatedDayNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600259C")]
	private String[] internalGetAbbreviatedDayOfWeekNamesCore() { }

	[Address(RVA = "0x13E0A60", Offset = "0x13DFC60", Length = "0x14")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetAbbreviatedMonthNamesCore", ReturnType = typeof(String[]))]
	[Token(Token = "0x600259F")]
	private String[] internalGetAbbreviatedMonthNames() { }

	[Address(RVA = "0x13E09F0", Offset = "0x13DFBF0", Length = "0x6C")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "internalGetAbbreviatedMonthNames", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AbbreviatedMonthNames", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "internalGetMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(MonthNameStyles), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAbbreviatedMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CultureData), Member = "AbbreviatedMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60025A0")]
	private String[] internalGetAbbreviatedMonthNamesCore() { }

	[Address(RVA = "0x13E0AF0", Offset = "0x13DFCF0", Length = "0x14")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetDayOfWeekNamesCore", ReturnType = typeof(String[]))]
	[Token(Token = "0x600259D")]
	private String[] internalGetDayOfWeekNames() { }

	[Address(RVA = "0x13E0A80", Offset = "0x13DFC80", Length = "0x6C")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "internalGetDayOfWeekNames", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_DayNames", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetDayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DayOfWeek)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CultureData), Member = "DayNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600259E")]
	private String[] internalGetDayOfWeekNamesCore() { }

	[Address(RVA = "0x13E0B10", Offset = "0x13DFD10", Length = "0xE6")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "internalGetMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(MonthNameStyles), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureData), Member = "GenitiveMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CultureData), Member = "AbbreviatedGenitiveMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60025CB")]
	private String[] internalGetGenitiveMonthNames(bool abbreviated) { }

	[Address(RVA = "0x13E0C00", Offset = "0x13DFE00", Length = "0x76")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchAbbreviatedMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CultureData), Member = "LeapYearMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60025CC")]
	internal String[] internalGetLeapYearMonthNames() { }

	[Address(RVA = "0x13E0C80", Offset = "0x13DFE80", Length = "0x1B0")]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatHebrewMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(int), typeof(DateTimeFormatInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(TokenHashValue[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetMonthNamesCore", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetAbbreviatedMonthNamesCore", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CultureData), Member = "LeapYearMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetGenitiveMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60025CA")]
	internal string internalGetMonthName(int month, MonthNameStyles style, bool abbreviated) { }

	[Address(RVA = "0x13E0EB0", Offset = "0x13E00B0", Length = "0x14")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetMonthNamesCore", ReturnType = typeof(String[]))]
	[Token(Token = "0x60025A1")]
	private String[] internalGetMonthNames() { }

	[Address(RVA = "0x13E0E40", Offset = "0x13E0040", Length = "0x6C")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "internalGetMonthNames", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_MonthNames", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "internalGetMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(MonthNameStyles), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CultureData), Member = "MonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60025A2")]
	private String[] internalGetMonthNamesCore() { }

	[Address(RVA = "0x13DCC90", Offset = "0x13DBE90", Length = "0x110")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60025F2")]
	private bool IsAllowedJapaneseTokenFollowedByNonSpaceLetter(string tokenString, char nextCh) { }

	[Address(RVA = "0x13DCDB0", Offset = "0x13DBFB0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60025F1")]
	private static bool IsHebrewChar(char ch) { }

	[Address(RVA = "0x13DCDD0", Offset = "0x13DBFD0", Length = "0x121")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60025EE")]
	private static bool IsJapaneseCalendar(Calendar calendar) { }

	[Address(RVA = "0x13DCF00", Offset = "0x13DC100", Length = "0xF2B")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(TokenHashValue[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_LanguageName", ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TaiwanCalendar), Member = "GetDefaultInstance", ReturnType = typeof(Calendar))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "set_Calendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Calendar)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetEraName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetAbbreviatedDayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DayOfWeek)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(JapaneseCalendar), Member = "GetDefaultInstance", ReturnType = typeof(Calendar))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetAbbreviatedEraName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureData), Member = "AbbreviatedEnglishEraNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "InsertHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(string), typeof(TokenType), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DateTimeFormatInfoScanner), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetAbbreviatedMonthName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_DateSeparator", ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfoScanner), Member = "GetDateWordsOfDTFI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeFormatInfo)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x60025ED")]
	private void PopulateSpecialTokenHashTable(TokenHashValue[] temp, ref bool useDateSepAsIgnorableSymbol) { }

	[Address(RVA = "0x13E0ED0", Offset = "0x13E00D0", Length = "0x6D9")]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTime&), typeof(DateTimeFormatInfo&), typeof(TimeSpan&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo&), typeof(ParsingInfo&), typeof(DateTimeResult&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData), typeof(Calendar)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetJapaneseCalendarDTFI", ReturnType = typeof(DateTimeFormatInfo))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetTaiwanCalendarDTFI", ReturnType = typeof(DateTimeFormatInfo))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureData), Member = "YearMonths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureData), Member = "GetCalendarIds", ReturnType = typeof(CalendarId[]))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureData), Member = "LongDates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CultureData), Member = "ShortDates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CultureData), Member = "DateSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60025AD")]
	public void set_Calendar(Calendar value) { }

	[Address(RVA = "0x13DDE30", Offset = "0x13DD030", Length = "0x7F1")]
	[CalledBy(Type = typeof(__DTString), Member = "GetRegularToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenType&), typeof(Int32&), typeof(DateTimeFormatInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__DTString), Member = "GetSeparatorToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeFormatInfo), typeof(Int32&), typeof(Char&)}, ReturnType = typeof(TokenType))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(HebrewNumber), Member = "ParseByChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(HebrewNumberParsingContext&)}, ReturnType = typeof(HebrewNumberParsingState))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
	[Calls(Type = typeof(CompareInfo), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(string), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(TokenHashValue[]))]
	[Calls(Type = typeof(__DTString), Member = "get_Length", ReturnType = typeof(int))]
	[Calls(Type = typeof(__DTString), Member = "Advance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HebrewNumberParsingContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(__DTString), Member = "MatchSpecifiedWords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HebrewNumber), Member = "IsDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_Culture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(char), Member = "IsLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60025F3")]
	internal bool Tokenize(TokenType TokenMask, out TokenType tokenType, out int tokenValue, ref __DTString str) { }

	[Address(RVA = "0x13DE630", Offset = "0x13DD830", Length = "0x151")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HebrewNumber), Member = "IsDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HebrewNumberParsingContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HebrewNumber), Member = "ParseByChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(HebrewNumberParsingContext&)}, ReturnType = typeof(HebrewNumberParsingState))]
	[Calls(Type = typeof(__DTString), Member = "Advance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60025F0")]
	private static bool TryParseHebrewNumber(ref __DTString str, out bool badFormat, out int number) { }

	[Address(RVA = "0x13DE790", Offset = "0x13DD990", Length = "0x125")]
	[CalledBy(Type = typeof(DateTime), Member = "ParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTime), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTime), Member = "TryParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60025E3")]
	internal static void ValidateStyles(DateTimeStyles style, string parameterName) { }

	[Address(RVA = "0x13DE8C0", Offset = "0x13DDAC0", Length = "0x13A")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "DoStrictParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeStyles), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x60025E8")]
	internal bool YearMonthAdjustment(ref int year, ref int month, bool parsedMonthName) { }

}

