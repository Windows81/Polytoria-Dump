namespace System;

[IsReadOnly]
[Token(Token = "0x20000CB")]
public struct DateTime : IComparable, IFormattable, IConvertible, IComparable<DateTime>, IEquatable<DateTime>, ISerializable, ISpanFormattable
{
	[Token(Token = "0x40002DE")]
	private const long TicksPerMillisecond = 10000; //Field offset: 0x0
	[Token(Token = "0x400030B")]
	private const string DateDataField = "dateData"; //Field offset: 0x0
	[Token(Token = "0x40002F6")]
	private const double OADateMinAsDouble = -657435; //Field offset: 0x0
	[Token(Token = "0x40002F7")]
	private const double OADateMaxAsDouble = 2958466; //Field offset: 0x0
	[Token(Token = "0x40002F8")]
	private const int DatePartYear = 0; //Field offset: 0x0
	[Token(Token = "0x40002F9")]
	private const int DatePartDayOfYear = 1; //Field offset: 0x0
	[Token(Token = "0x40002FA")]
	private const int DatePartMonth = 2; //Field offset: 0x0
	[Token(Token = "0x40002FB")]
	private const int DatePartDay = 3; //Field offset: 0x0
	[Token(Token = "0x40002FC")]
	private static readonly Int32[] s_daysToMonth365; //Field offset: 0x0
	[Token(Token = "0x40002F4")]
	private const long DoubleDateOffset = 599264352000000000; //Field offset: 0x0
	[Token(Token = "0x4000301")]
	private const ulong TicksMask = 4611686018427387903; //Field offset: 0x0
	[Token(Token = "0x4000303")]
	private const ulong LocalMask = 9223372036854775808; //Field offset: 0x0
	[Token(Token = "0x4000304")]
	private const long TicksCeiling = 4611686018427387904; //Field offset: 0x0
	[Token(Token = "0x4000305")]
	private const ulong KindUnspecified = 0; //Field offset: 0x0
	[Token(Token = "0x4000306")]
	private const ulong KindUtc = 4611686018427387904; //Field offset: 0x0
	[Token(Token = "0x4000307")]
	private const ulong KindLocal = 9223372036854775808; //Field offset: 0x0
	[Token(Token = "0x4000308")]
	private const ulong KindLocalAmbiguousDst = 13835058055282163712; //Field offset: 0x0
	[Token(Token = "0x4000309")]
	private const int KindShift = 62; //Field offset: 0x0
	[Token(Token = "0x400030A")]
	private const string TicksField = "ticks"; //Field offset: 0x0
	[Token(Token = "0x4000302")]
	private const ulong FlagsMask = 13835058055282163712; //Field offset: 0x0
	[Token(Token = "0x40002F3")]
	private const long FileTimeOffset = 504911232000000000; //Field offset: 0x0
	[Token(Token = "0x40002F5")]
	private const long OADateMinAsTicks = 31241376000000000; //Field offset: 0x0
	[Token(Token = "0x40002F1")]
	private const long MaxMillis = 315537897600000; //Field offset: 0x0
	[Token(Token = "0x40002E1")]
	private const long TicksPerHour = 36000000000; //Field offset: 0x0
	[Token(Token = "0x40002E2")]
	private const long TicksPerDay = 864000000000; //Field offset: 0x0
	[Token(Token = "0x40002E3")]
	private const int MillisPerSecond = 1000; //Field offset: 0x0
	[Token(Token = "0x40002E4")]
	private const int MillisPerMinute = 60000; //Field offset: 0x0
	[Token(Token = "0x40002E5")]
	private const int MillisPerHour = 3600000; //Field offset: 0x0
	[Token(Token = "0x40002E6")]
	private const int MillisPerDay = 86400000; //Field offset: 0x0
	[Token(Token = "0x40002E7")]
	private const int DaysPerYear = 365; //Field offset: 0x0
	[Token(Token = "0x40002E8")]
	private const int DaysPer4Years = 1461; //Field offset: 0x0
	[Token(Token = "0x40002F2")]
	internal const long UnixEpochTicks = 621355968000000000; //Field offset: 0x0
	[Token(Token = "0x40002E0")]
	private const long TicksPerMinute = 600000000; //Field offset: 0x0
	[Token(Token = "0x40002DF")]
	private const long TicksPerSecond = 10000000; //Field offset: 0x0
	[Token(Token = "0x40002E9")]
	private const int DaysPer100Years = 36524; //Field offset: 0x0
	[Token(Token = "0x40002EA")]
	private const int DaysPer400Years = 146097; //Field offset: 0x0
	[Token(Token = "0x40002EB")]
	private const int DaysTo1601 = 584388; //Field offset: 0x0
	[Token(Token = "0x40002EC")]
	private const int DaysTo1899 = 693593; //Field offset: 0x0
	[Token(Token = "0x40002ED")]
	internal const int DaysTo1970 = 719162; //Field offset: 0x0
	[Token(Token = "0x40002EE")]
	private const int DaysTo10000 = 3652059; //Field offset: 0x0
	[Token(Token = "0x40002EF")]
	internal const long MinTicks = 0; //Field offset: 0x0
	[Token(Token = "0x40002F0")]
	internal const long MaxTicks = 3155378975999999999; //Field offset: 0x0
	[Token(Token = "0x40002FD")]
	private static readonly Int32[] s_daysToMonth366; //Field offset: 0x8
	[Token(Token = "0x40002FE")]
	public static readonly DateTime MinValue; //Field offset: 0x10
	[Token(Token = "0x40002FF")]
	public static readonly DateTime MaxValue; //Field offset: 0x18
	[Token(Token = "0x4000300")]
	public static readonly DateTime UnixEpoch; //Field offset: 0x20
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400030C")]
	private readonly ulong _dateData; //Field offset: 0x0

	[Token(Token = "0x17000065")]
	public DateTime Date
	{
		[Address(RVA = "0x1497F30", Offset = "0x1497130", Length = "0x78")]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryCreateAdjustmentRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(REG_TZI_FORMAT&), typeof(AdjustmentRule[]&), typeof(Exception&), typeof(int)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryCreateTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DYNAMIC_TIME_ZONE_INFORMATION)}, ReturnType = typeof(TimeZoneInfo))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetAdjustmentRuleForTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(bool), typeof(Nullable`1<Int32>&)}, ReturnType = typeof(AdjustmentRule))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000601")]
		 get { } //Length: 120
	}

	[Token(Token = "0x17000066")]
	public int Day
	{
		[Address(RVA = "0x1498090", Offset = "0x1497290", Length = "0x4F")]
		[CalledBy(Type = typeof(X509Certificate), Member = "FormatDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(UmAlQuraCalendar), Member = "ConvertHijriToGregorian", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UmAlQuraCalendar), Member = "GetAbsoluteDateUmAlQura", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
		[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.OsTimeModule", Member = "date", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.ScriptExecutionContext", "MoonSharp.Interpreter.CallbackArguments"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Day", ReturnType = typeof(int))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Fraction", ReturnType = typeof(int))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDateTime"}, ReturnType = typeof(DateTime))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDateTime"}, ReturnType = typeof(DateTimeOffset))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "PrintDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DateTime), Member = "GetDatePart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Token(Token = "0x6000604")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000067")]
	public DayOfWeek DayOfWeek
	{
		[Address(RVA = "0x1497FB0", Offset = "0x14971B0", Length = "0x86")]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "TransitionTimeToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransitionTime)}, ReturnType = typeof(DateTime))]
		[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.OsTimeModule", Member = "date", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.ScriptExecutionContext", "MoonSharp.Interpreter.CallbackArguments"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
		[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.OsTimeModule", Member = "StrFTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTime)}, ReturnType = typeof(string))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000605")]
		 get { } //Length: 134
	}

	[Token(Token = "0x17000068")]
	public int DayOfYear
	{
		[Address(RVA = "0x1498040", Offset = "0x1497240", Length = "0x4F")]
		[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.OsTimeModule", Member = "date", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.ScriptExecutionContext", "MoonSharp.Interpreter.CallbackArguments"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
		[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.OsTimeModule", Member = "StrFTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTime)}, ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DateTime), Member = "GetDatePart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Token(Token = "0x6000606")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000069")]
	public int Hour
	{
		[Address(RVA = "0x14980E0", Offset = "0x14972E0", Length = "0x8B")]
		[CalledBy(Type = typeof(AdjustmentRule), Member = "IsStartDateMarkerForBeginningOfYear", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(AdjustmentRule), Member = "IsEndDateMarkerForEndOfYear", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "TransitionTimeToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransitionTime)}, ReturnType = typeof(DateTime))]
		[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
		[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.OsTimeModule", Member = "date", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.ScriptExecutionContext", "MoonSharp.Interpreter.CallbackArguments"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Hour", ReturnType = typeof(int))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Fraction", ReturnType = typeof(int))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "PrintTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000608")]
		 get { } //Length: 139
	}

	[Token(Token = "0x17000064")]
	private ulong InternalKind
	{
		[Address(RVA = "0x1498170", Offset = "0x1497370", Length = "0x11")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60005E6")]
		private get { } //Length: 17
	}

	[Token(Token = "0x17000063")]
	internal long InternalTicks
	{
		[Address(RVA = "0x1498190", Offset = "0x1497390", Length = "0x11")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60005E5")]
		internal get { } //Length: 17
	}

	[Token(Token = "0x1700006A")]
	public DateTimeKind Kind
	{
		[Address(RVA = "0x14981B0", Offset = "0x14973B0", Length = "0x6E")]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "CompareAdjustmentRuleToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AdjustmentRule), typeof(AdjustmentRule), typeof(DateTime), typeof(DateTime), typeof(bool)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(AdjustmentRule), Member = "ValidateAdjustmentRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(TimeSpan), typeof(TransitionTime), typeof(TransitionTime), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TransitionTime), Member = "ValidateTransitionTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(int), typeof(int), typeof(DayOfWeek)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions), "System.TimeZoneInfo+CachedData"}, ReturnType = typeof(TimeSpan))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "IsDaylightSavingTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions), "System.TimeZoneInfo+CachedData"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions), "System.TimeZoneInfo+CachedData"}, ReturnType = typeof(DateTime))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertTimeToUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(DateTime))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), "System.Xml.Schema.XsdDateTimeFlags"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTime&), typeof(DateTimeFormatInfo&), typeof(TimeSpan&)}, ReturnType = typeof(string))]
		[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), "System.Xml.XmlDateTimeSerializationMode"}, ReturnType = typeof(string))]
		[CalledBy(Type = "System.Xml.XmlConvert", Member = "SwitchToLocalTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(DateTime))]
		[CalledBy(Type = "System.Xml.XmlConvert", Member = "SwitchToUtcTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(DateTime))]
		[CalledBy(Type = "System.Xml.Schema.Datatype_dateTimeBase", Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(int))]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600060A")]
		 get { } //Length: 110
	}

	[Token(Token = "0x1700006B")]
	public int Millisecond
	{
		[Address(RVA = "0x1498220", Offset = "0x1497420", Length = "0x8C")]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "TransitionTimeToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransitionTime)}, ReturnType = typeof(DateTime))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600060B")]
		 get { } //Length: 140
	}

	[Token(Token = "0x1700006C")]
	public int Minute
	{
		[Address(RVA = "0x14982B0", Offset = "0x14974B0", Length = "0x8C")]
		[CalledBy(Type = "Polytoria.Datamodel.Services.AchievementService", Member = "UseRequest", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(AdjustmentRule), Member = "IsStartDateMarkerForBeginningOfYear", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(AdjustmentRule), Member = "IsEndDateMarkerForEndOfYear", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "TransitionTimeToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransitionTime)}, ReturnType = typeof(DateTime))]
		[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
		[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "PrintTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Services.DataStoreService", Member = "UseReadRequest", ReturnType = typeof(bool))]
		[CalledBy(Type = "Polytoria.Datamodel.Services.DataStoreService", Member = "UseWriteRequest", ReturnType = typeof(bool))]
		[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.OsTimeModule", Member = "date", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.ScriptExecutionContext", "MoonSharp.Interpreter.CallbackArguments"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Minute", ReturnType = typeof(int))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Fraction", ReturnType = typeof(int))]
		[CallerCount(Count = 18)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600060C")]
		 get { } //Length: 140
	}

	[Token(Token = "0x1700006D")]
	public int Month
	{
		[Address(RVA = "0x1498340", Offset = "0x1497540", Length = "0x4F")]
		[CalledBy(Type = typeof(X509Certificate), Member = "FormatDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(UmAlQuraCalendar), Member = "ConvertHijriToGregorian", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UmAlQuraCalendar), Member = "GetAbsoluteDateUmAlQura", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
		[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.OsTimeModule", Member = "date", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.ScriptExecutionContext", "MoonSharp.Interpreter.CallbackArguments"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Month", ReturnType = typeof(int))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Fraction", ReturnType = typeof(int))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDateTime"}, ReturnType = typeof(DateTime))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDateTime"}, ReturnType = typeof(DateTimeOffset))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "PrintDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DateTime), Member = "GetDatePart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Token(Token = "0x600060D")]
		 get { } //Length: 79
	}

	[Token(Token = "0x1700006E")]
	public static DateTime Now
	{
		[Address(RVA = "0x1498390", Offset = "0x1497590", Length = "0x17D")]
		[CallerCount(Count = 42)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214030")]
		[Calls(Type = typeof(TimeZoneInfo), Member = "GetDateTimeNowUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
		[Token(Token = "0x600060E")]
		 get { } //Length: 381
	}

	[Token(Token = "0x1700006F")]
	public int Second
	{
		[Address(RVA = "0x1498510", Offset = "0x1497710", Length = "0x8C")]
		[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(AdjustmentRule), Member = "IsStartDateMarkerForBeginningOfYear", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(AdjustmentRule), Member = "IsEndDateMarkerForEndOfYear", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "TransitionTimeToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransitionTime)}, ReturnType = typeof(DateTime))]
		[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
		[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "PrintTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "OwnsItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "MoonSharp.Interpreter.DynValue"}, ReturnType = typeof(void))]
		[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.OsTimeModule", Member = "date", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.ScriptExecutionContext", "MoonSharp.Interpreter.CallbackArguments"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Second", ReturnType = typeof(int))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Fraction", ReturnType = typeof(int))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600060F")]
		 get { } //Length: 140
	}

	[Token(Token = "0x17000070")]
	public long Ticks
	{
		[Address(RVA = "0x14985A0", Offset = "0x14977A0", Length = "0x50")]
		[CallerCount(Count = 69)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000610")]
		 get { } //Length: 80
	}

	[Token(Token = "0x17000071")]
	public TimeSpan TimeOfDay
	{
		[Address(RVA = "0x14985F0", Offset = "0x14977F0", Length = "0x62")]
		[CalledBy(Type = typeof(AdjustmentRule), Member = "ValidateAdjustmentRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(TimeSpan), typeof(TransitionTime), typeof(TransitionTime), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.ComponentModel.DateTimeConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000611")]
		 get { } //Length: 98
	}

	[Token(Token = "0x17000073")]
	public static DateTime UtcNow
	{
		[Address(RVA = "0x1498660", Offset = "0x1497860", Length = "0x59")]
		[CallerCount(Count = 43)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214030")]
		[Token(Token = "0x600063E")]
		 get { } //Length: 89
	}

	[Token(Token = "0x17000072")]
	public int Year
	{
		[Address(RVA = "0x14986C0", Offset = "0x14978C0", Length = "0x4C")]
		[CallerCount(Count = 47)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DateTime), Member = "GetDatePart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Token(Token = "0x6000612")]
		 get { } //Length: 76
	}

	[Address(RVA = "0x1497260", Offset = "0x1496460", Length = "0x139")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000641")]
	private static DateTime() { }

	[Address(RVA = "0x1497440", Offset = "0x1496640", Length = "0x2F3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Convert), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SerializationInfoEnumerator), Member = "get_Value", ReturnType = typeof(object))]
	[Calls(Type = typeof(SerializationInfoEnumerator), Member = "get_Name", ReturnType = typeof(string))]
	[Calls(Type = typeof(SerializationInfoEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetEnumerator", ReturnType = typeof(SerializationInfoEnumerator))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60005E4")]
	private DateTime(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x14977D0", Offset = "0x14969D0", Length = "0x27A")]
	[CalledBy(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(Calendar), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005E3")]
	public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar) { }

	[Address(RVA = "0x1497B70", Offset = "0x1496D70", Length = "0x1B6")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TransitionTimeFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(REG_TZI_FORMAT&), typeof(TransitionTime&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TransitionTimeFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DYNAMIC_TIME_ZONE_INFORMATION), typeof(TransitionTime&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TransitionTimeToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransitionTime)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GregorianCalendar), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(UmAlQuraCalendar), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.FtpControlStream", Member = "GetLastModifiedFrom213Response", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "TimeToTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTime), Member = "DateToTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Token(Token = "0x60005E2")]
	public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond) { }

	[Address(RVA = "0x1497D30", Offset = "0x1496F30", Length = "0x10C")]
	[CalledBy(Type = "Mono.Btls.MonoBtlsX509VerifyParam", Member = "SetTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.BouncyCastle.Utilities.Date.DateTimeUtilities", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.OsTimeModule", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.SystemClock", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "DateToTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTime), Member = "TimeToTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60005E1")]
	public DateTime(int year, int month, int day, int hour, int minute, int second, DateTimeKind kind) { }

	[Address(RVA = "0x1497740", Offset = "0x1496940", Length = "0x89")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertToFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertUtcToTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(TimeZoneInfo), typeof(Boolean&)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(Convert), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(CADMessageBase), Member = "UnmarshalArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ArrayList)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ResourceReader), Member = "_LoadObjectV1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(GregorianCalendarHelper), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(HijriCalendar), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(UmAlQuraCalendar), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(UmAlQuraCalendar), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60005DB")]
	public DateTime(long ticks) { }

	[Address(RVA = "0x1497AF0", Offset = "0x1496CF0", Length = "0x79")]
	[CalledBy(Type = typeof(TaiwanCalendar), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDateTime"}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "Polytoria.Controllers.NetworkController+<StartClient>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.ScriptService", Member = "Tick", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(UmAlQuraCalendar), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateMapping), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThaiBuddhistCalendar), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDateTime"}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(JapaneseCalendar), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EraInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EraInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(TimeSpan), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>), typeof(Boolean&), typeof(TimeZoneInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryCreateTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DYNAMIC_TIME_ZONE_INFORMATION)}, ReturnType = typeof(TimeZoneInfo))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryCreateAdjustmentRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(REG_TZI_FORMAT&), typeof(AdjustmentRule[]&), typeof(Exception&), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(HijriCalendar), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 30)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTime), Member = "DateToTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60005DF")]
	public DateTime(int year, int month, int day) { }

	[Address(RVA = "0x1497A50", Offset = "0x1496C50", Length = "0x98")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions), "System.TimeZoneInfo+CachedData"}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60005DE")]
	internal DateTime(long ticks, DateTimeKind kind, bool isAmbiguousDst) { }

	[Address(RVA = "0x1497E40", Offset = "0x1497040", Length = "0xEC")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60005DD")]
	public DateTime(long ticks, DateTimeKind kind) { }

	[Address(RVA = "0xC498F0", Offset = "0xC48AF0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005DC")]
	private DateTime(ulong dateData) { }

	[Address(RVA = "0x14973A0", Offset = "0x14965A0", Length = "0x94")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(TimeSpan), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>), typeof(Boolean&), typeof(TimeZoneInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.OsTimeModule", Member = "ParseTimeTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.Table"}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "InitiateXsdDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDateTime+Parser"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Fraction", ReturnType = typeof(int))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "DateToTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTime), Member = "TimeToTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[Token(Token = "0x60005E0")]
	public DateTime(int year, int month, int day, int hour, int minute, int second) { }

	[Address(RVA = "0x1493D10", Offset = "0x1492F10", Length = "0x110")]
	[CalledBy(Type = typeof(DateTime), Member = "AddDays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTime), Member = "AddMilliseconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTime), Member = "AddMinutes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTime), Member = "AddSeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "AddTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60005E8")]
	private DateTime Add(double value, int scale) { }

	[Address(RVA = "0x1493E30", Offset = "0x1493030", Length = "0x59")]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDateTime"}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDateTime"}, ReturnType = typeof(DateTimeOffset))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "AddTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTime))]
	[Token(Token = "0x60005E7")]
	public DateTime Add(TimeSpan value) { }

	[Address(RVA = "0x1493640", Offset = "0x1492840", Length = "0x60")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TransitionTimeToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransitionTime)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(UmAlQuraCalendar), Member = "ConvertHijriToGregorian", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UmAlQuraCalendar), Member = "GetAbsoluteDateUmAlQura", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int)}, ReturnType = typeof(DateTime))]
	[Token(Token = "0x60005E9")]
	public DateTime AddDays(double value) { }

	[Address(RVA = "0x14936A0", Offset = "0x14928A0", Length = "0x60")]
	[CalledBy(Type = typeof(AdjustmentRule), Member = "get_HasDaylightSaving", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "CreateAdjustmentRuleFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(REG_TZI_FORMAT&), typeof(DateTime), typeof(DateTime), typeof(int)}, ReturnType = typeof(AdjustmentRule))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "CreateAdjustmentRuleFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DYNAMIC_TIME_ZONE_INFORMATION&), typeof(DateTime), typeof(DateTime), typeof(int)}, ReturnType = typeof(AdjustmentRule))]
	[CalledBy(Type = "UnityEngine.GUI", Member = "ScrollerRepeatButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "UnityEngine.Rect", "UnityEngine.GUIStyle"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.SliderHandler", Member = "OnMouseDown", ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.SliderHandler", Member = "OnRepaint", ReturnType = typeof(float))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int)}, ReturnType = typeof(DateTime))]
	[Token(Token = "0x60005EA")]
	public DateTime AddMilliseconds(double value) { }

	[Address(RVA = "0x1493700", Offset = "0x1492900", Length = "0x60")]
	[CalledBy(Type = "PurchasesService", Member = "CleanupExpiredPurchases", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int)}, ReturnType = typeof(DateTime))]
	[Token(Token = "0x60005EB")]
	public DateTime AddMinutes(double value) { }

	[Address(RVA = "0x1493760", Offset = "0x1492960", Length = "0x360")]
	[CalledBy(Type = typeof(DateTime), Member = "AddYears", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "GetDatePart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "IsLeapYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "DateToTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60005EC")]
	public DateTime AddMonths(int months) { }

	[Address(RVA = "0x1493AD0", Offset = "0x1492CD0", Length = "0x60")]
	[CalledBy(Type = "System.Net.CookieParser", Member = "Get", ReturnType = "System.Net.Cookie")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int)}, ReturnType = typeof(DateTime))]
	[Token(Token = "0x60005ED")]
	public DateTime AddSeconds(double value) { }

	[Address(RVA = "0x1493B30", Offset = "0x1492D30", Length = "0x109")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "DoStrictParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeStyles), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(TimeSpan), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>), typeof(Boolean&), typeof(TimeZoneInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTime), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTime), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseISO8601", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeRawInfo&), typeof(__DTString&), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "InitiateXsdDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDateTime+Parser"}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60005EE")]
	public DateTime AddTicks(long value) { }

	[Address(RVA = "0x1493C40", Offset = "0x1492E40", Length = "0xC2")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(TimeSpan), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>), typeof(Boolean&), typeof(TimeZoneInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "CheckIsDst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(DateTime), typeof(bool), typeof(AdjustmentRule)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsAmbiguousTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsInvalidTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "AddMonths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60005EF")]
	public DateTime AddYears(int value) { }

	[Address(RVA = "0x1493FE0", Offset = "0x14931E0", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60005F0")]
	public static int Compare(DateTime t1, DateTime t2) { }

	[Address(RVA = "0x1493F80", Offset = "0x1493180", Length = "0x5C")]
	[CalledBy(Type = typeof(UmAlQuraCalendar), Member = "ConvertGregorianToHijri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.BouncyCastle.Utilities.Date.DateTimeUtilities", Member = "DateTimeToUnixMs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(long))]
	[CalledBy(Type = "Mirror.BouncyCastle.Utilities.Date.DateTimeUtilities", Member = "CurrentUnixMs", ReturnType = typeof(long))]
	[CalledBy(Type = "System.Xml.Schema.Datatype_dateTimeBase", Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60005F2")]
	public override int CompareTo(DateTime value) { }

	[Address(RVA = "0x1493E90", Offset = "0x1493090", Length = "0xEC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60005F1")]
	public override int CompareTo(object value) { }

	[Address(RVA = "0x1494060", Offset = "0x1493260", Length = "0x1C4")]
	[CalledBy(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(DateTimeKind)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTime), Member = "AddMonths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTime), Member = "TryCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(DateTime), Member = "IsLeapYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60005F3")]
	private static long DateToTicks(int year, int month, int day) { }

	[Address(RVA = "0x1494230", Offset = "0x1493430", Length = "0x137")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TransitionTimeToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransitionTime)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime+Parser", Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Xml.Schema.XsdDateTimeFlags"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime+Parser", Member = "ParseDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "IsLeapYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005F5")]
	public static int DaysInMonth(int year, int month) { }

	[Address(RVA = "0x1494370", Offset = "0x1493570", Length = "0x139")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60005F6")]
	internal static long DoubleDateToTicks(double value) { }

	[Address(RVA = "0x14944B0", Offset = "0x14936B0", Length = "0xB6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60005F7")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x1494570", Offset = "0x1493770", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60005F8")]
	public override bool Equals(DateTime value) { }

	[Address(RVA = "0x1494670", Offset = "0x1493870", Length = "0x2CE")]
	[CalledBy(Type = typeof(ResourceReader), Member = "_LoadObjectV2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ResourceTypeCode&)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(DateTimeKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "get_Local", ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetLocalUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60005F9")]
	public static DateTime FromBinary(long dateData) { }

	[Address(RVA = "0x14945D0", Offset = "0x14937D0", Length = "0x99")]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadDateTime", ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60005FA")]
	internal static DateTime FromBinaryRaw(long dateData) { }

	[Address(RVA = "0x1494A00", Offset = "0x1493C00", Length = "0x126")]
	[CalledBy(Type = "UnityEngine.Windows.Speech.PhraseRecognizer", Member = "InvokePhraseRecognizedEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), "UnityEngine.Windows.Speech.ConfidenceLevel", "UnityEngine.Windows.Speech.SemanticMeaning[]", typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(DateTimeKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "ToLocalTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60005FB")]
	public static DateTime FromFileTime(long fileTime) { }

	[Address(RVA = "0x1494940", Offset = "0x1493B40", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(DateTimeKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60005FC")]
	public static DateTime FromFileTimeUtc(long fileTime) { }

	[Address(RVA = "0x1494B30", Offset = "0x1493D30", Length = "0x19C")]
	[CalledBy(Type = "Mirror.NetworkReaderExtensions", Member = "ReadDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkReader"}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "Mirror.NetworkReaderExtensions", Member = "ReadDateTimeNullable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkReader"}, ReturnType = "System.Nullable`1<DateTime>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(DateTimeKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60005FD")]
	public static DateTime FromOADate(double d) { }

	[Address(RVA = "0x1497F30", Offset = "0x1497130", Length = "0x78")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryCreateAdjustmentRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(REG_TZI_FORMAT&), typeof(AdjustmentRule[]&), typeof(Exception&), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryCreateTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DYNAMIC_TIME_ZONE_INFORMATION)}, ReturnType = typeof(TimeZoneInfo))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetAdjustmentRuleForTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(bool), typeof(Nullable`1<Int32>&)}, ReturnType = typeof(AdjustmentRule))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000601")]
	public DateTime get_Date() { }

	[Address(RVA = "0x1498090", Offset = "0x1497290", Length = "0x4F")]
	[CalledBy(Type = typeof(X509Certificate), Member = "FormatDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(UmAlQuraCalendar), Member = "ConvertHijriToGregorian", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UmAlQuraCalendar), Member = "GetAbsoluteDateUmAlQura", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.OsTimeModule", Member = "date", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.ScriptExecutionContext", "MoonSharp.Interpreter.CallbackArguments"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Day", ReturnType = typeof(int))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Fraction", ReturnType = typeof(int))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDateTime"}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDateTime"}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "PrintDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "GetDatePart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000604")]
	public int get_Day() { }

	[Address(RVA = "0x1497FB0", Offset = "0x14971B0", Length = "0x86")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TransitionTimeToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransitionTime)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.OsTimeModule", Member = "date", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.ScriptExecutionContext", "MoonSharp.Interpreter.CallbackArguments"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.OsTimeModule", Member = "StrFTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTime)}, ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000605")]
	public DayOfWeek get_DayOfWeek() { }

	[Address(RVA = "0x1498040", Offset = "0x1497240", Length = "0x4F")]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.OsTimeModule", Member = "date", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.ScriptExecutionContext", "MoonSharp.Interpreter.CallbackArguments"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.OsTimeModule", Member = "StrFTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTime)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "GetDatePart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000606")]
	public int get_DayOfYear() { }

	[Address(RVA = "0x14980E0", Offset = "0x14972E0", Length = "0x8B")]
	[CalledBy(Type = typeof(AdjustmentRule), Member = "IsStartDateMarkerForBeginningOfYear", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AdjustmentRule), Member = "IsEndDateMarkerForEndOfYear", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TransitionTimeToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransitionTime)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.OsTimeModule", Member = "date", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.ScriptExecutionContext", "MoonSharp.Interpreter.CallbackArguments"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Hour", ReturnType = typeof(int))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Fraction", ReturnType = typeof(int))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "PrintTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000608")]
	public int get_Hour() { }

	[Address(RVA = "0x1498170", Offset = "0x1497370", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60005E6")]
	private ulong get_InternalKind() { }

	[Address(RVA = "0x1498190", Offset = "0x1497390", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60005E5")]
	internal long get_InternalTicks() { }

	[Address(RVA = "0x14981B0", Offset = "0x14973B0", Length = "0x6E")]
	[CalledBy(Type = "System.Xml.Schema.Datatype_dateTimeBase", Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "SwitchToUtcTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "SwitchToLocalTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), "System.Xml.XmlDateTimeSerializationMode"}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTime&), typeof(DateTimeFormatInfo&), typeof(TimeSpan&)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), "System.Xml.Schema.XsdDateTimeFlags"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions), "System.TimeZoneInfo+CachedData"}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "IsDaylightSavingTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions), "System.TimeZoneInfo+CachedData"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions), "System.TimeZoneInfo+CachedData"}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TransitionTime), Member = "ValidateTransitionTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(int), typeof(int), typeof(DayOfWeek)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AdjustmentRule), Member = "ValidateAdjustmentRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(TimeSpan), typeof(TransitionTime), typeof(TransitionTime), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "CompareAdjustmentRuleToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AdjustmentRule), typeof(AdjustmentRule), typeof(DateTime), typeof(DateTime), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertTimeToUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600060A")]
	public DateTimeKind get_Kind() { }

	[Address(RVA = "0x1498220", Offset = "0x1497420", Length = "0x8C")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TransitionTimeToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransitionTime)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600060B")]
	public int get_Millisecond() { }

	[Address(RVA = "0x14982B0", Offset = "0x14974B0", Length = "0x8C")]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Fraction", ReturnType = typeof(int))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Minute", ReturnType = typeof(int))]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.OsTimeModule", Member = "date", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.ScriptExecutionContext", "MoonSharp.Interpreter.CallbackArguments"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
	[CalledBy(Type = "Polytoria.Datamodel.Services.DataStoreService", Member = "UseWriteRequest", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "PrintTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.DataStoreService", Member = "UseReadRequest", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TransitionTimeToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransitionTime)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(AdjustmentRule), Member = "IsEndDateMarkerForEndOfYear", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AdjustmentRule), Member = "IsStartDateMarkerForBeginningOfYear", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.AchievementService", Member = "UseRequest", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600060C")]
	public int get_Minute() { }

	[Address(RVA = "0x1498340", Offset = "0x1497540", Length = "0x4F")]
	[CalledBy(Type = typeof(X509Certificate), Member = "FormatDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(UmAlQuraCalendar), Member = "ConvertHijriToGregorian", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UmAlQuraCalendar), Member = "GetAbsoluteDateUmAlQura", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.OsTimeModule", Member = "date", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.ScriptExecutionContext", "MoonSharp.Interpreter.CallbackArguments"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Month", ReturnType = typeof(int))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Fraction", ReturnType = typeof(int))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDateTime"}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDateTime"}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "PrintDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "GetDatePart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x600060D")]
	public int get_Month() { }

	[Address(RVA = "0x1498390", Offset = "0x1497590", Length = "0x17D")]
	[CallerCount(Count = 42)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214030")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetDateTimeNowUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
	[Token(Token = "0x600060E")]
	public static DateTime get_Now() { }

	[Address(RVA = "0x1498510", Offset = "0x1497710", Length = "0x8C")]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Fraction", ReturnType = typeof(int))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "get_Second", ReturnType = typeof(int))]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.OsTimeModule", Member = "date", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.ScriptExecutionContext", "MoonSharp.Interpreter.CallbackArguments"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "PrintTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "OwnsItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "MoonSharp.Interpreter.DynValue"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TransitionTimeToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransitionTime)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(AdjustmentRule), Member = "IsEndDateMarkerForEndOfYear", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AdjustmentRule), Member = "IsStartDateMarkerForBeginningOfYear", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600060F")]
	public int get_Second() { }

	[Address(RVA = "0x14985A0", Offset = "0x14977A0", Length = "0x50")]
	[CallerCount(Count = 69)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000610")]
	public long get_Ticks() { }

	[Address(RVA = "0x14985F0", Offset = "0x14977F0", Length = "0x62")]
	[CalledBy(Type = typeof(AdjustmentRule), Member = "ValidateAdjustmentRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(TimeSpan), typeof(TransitionTime), typeof(TransitionTime), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.ComponentModel.DateTimeConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000611")]
	public TimeSpan get_TimeOfDay() { }

	[Address(RVA = "0x1498660", Offset = "0x1497860", Length = "0x59")]
	[CallerCount(Count = 43)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214030")]
	[Token(Token = "0x600063E")]
	public static DateTime get_UtcNow() { }

	[Address(RVA = "0x14986C0", Offset = "0x14978C0", Length = "0x4C")]
	[CallerCount(Count = 47)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "GetDatePart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000612")]
	public int get_Year() { }

	[Address(RVA = "0x1494EC0", Offset = "0x14940C0", Length = "0x1E9")]
	[CalledBy(Type = typeof(TransitionTime), Member = "ValidateTransitionTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(int), typeof(int), typeof(DayOfWeek)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTime), Member = "AddMonths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000603")]
	internal void GetDatePart(out int year, out int month, out int day) { }

	[Address(RVA = "0x1494CD0", Offset = "0x1493ED0", Length = "0x1EB")]
	[CalledBy(Type = typeof(DateTime), Member = "get_Day", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DateTime), Member = "get_DayOfYear", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DateTime), Member = "get_Month", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "get_Day", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "get_Month", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "get_Year", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000602")]
	private int GetDatePart(int part) { }

	[Address(RVA = "0x14950B0", Offset = "0x14942B0", Length = "0x59")]
	[CalledBy(Type = typeof(AdjustmentRule), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000607")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1495110", Offset = "0x1494310", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214030")]
	[Token(Token = "0x600063F")]
	internal static long GetSystemTimeAsFileTime() { }

	[Address(RVA = "0x7C8170", Offset = "0x7C7370", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600062D")]
	public override TypeCode GetTypeCode() { }

	[Address(RVA = "0x1495120", Offset = "0x1494320", Length = "0x56")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000609")]
	internal bool IsAmbiguousDaylightSavingTime() { }

	[Address(RVA = "0x1495180", Offset = "0x1494380", Length = "0xDF")]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.OsTimeModule", Member = "date", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.ScriptExecutionContext", "MoonSharp.Interpreter.CallbackArguments"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "get_Local", ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "IsDaylightSavingTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005FF")]
	public bool IsDaylightSavingTime() { }

	[Address(RVA = "0x1495260", Offset = "0x1494460", Length = "0xDE")]
	[CalledBy(Type = typeof(DateTime), Member = "AddMonths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTime), Member = "DateToTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(DateTime), Member = "DaysInMonth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DateTime), Member = "TryCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000613")]
	public static bool IsLeapYear(int year) { }

	[Address(RVA = "0x1498710", Offset = "0x1497910", Length = "0x106")]
	[CalledBy(Type = "System.Net.ServicePoint", Member = "get_HasTimedOut", ReturnType = typeof(bool))]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.OsTimeModule", Member = "date", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.ScriptExecutionContext", "MoonSharp.Interpreter.CallbackArguments"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.OsTimeModule", Member = "FromUnixTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Net.WebConnection", Member = "StartOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.WebOperation", typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.ServicePointScheduler+<RunScheduler>d__32", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.ServicePoint", Member = "get_HostEntry", ReturnType = "System.Net.IPHostEntry")]
	[CalledBy(Type = typeof(Lease), Member = "ProcessSponsorResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Lease), Member = "Renew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(ServerIdentity), Member = "StartTrackingLifetime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILease)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsInvalidTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsAmbiguousTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetAdjustmentRuleForTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(bool), typeof(Nullable`1<Int32>&)}, ReturnType = typeof(AdjustmentRule))]
	[CalledBy(Type = typeof(Lease), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000624")]
	public static DateTime op_Addition(DateTime d, TimeSpan t) { }

	[Address(RVA = "0x1498820", Offset = "0x1497A20", Length = "0x5F")]
	[CalledBy(Type = typeof(AdjustmentRule), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AdjustmentRule)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TransitionTime), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransitionTime)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "HasSameRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeZoneInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(X509Certificate), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(X509Certificate), Member = "GetNotAfter", ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(X509Certificate), Member = "GetNotBefore", ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.ComponentModel.DateTimeConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Net.CookieContainer", Member = "AgeCookies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000627")]
	public static bool op_Equality(DateTime d1, DateTime d2) { }

	[Address(RVA = "0x14988F0", Offset = "0x1497AF0", Length = "0x62")]
	[CalledBy(Type = typeof(Lease), Member = "ProcessSponsorResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AdjustmentRule), Member = "ValidateAdjustmentRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(TimeSpan), typeof(TransitionTime), typeof(TransitionTime), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "CheckIsDst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(DateTime), typeof(bool), typeof(AdjustmentRule)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "System.IComparable.CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Lease), Member = "Renew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = "Mono.Security.X509.X509Chain", Member = "IsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Security.X509.X509Certificate"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection", Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509FindType", typeof(object), typeof(bool)}, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.ServicePointScheduler+ConnectionGroup", Member = "FindIdleConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.WebOperation"}, ReturnType = "System.Net.WebConnection")]
	[CalledBy(Type = "Mono.Security.X509.X509Certificate", Member = "get_IsCurrent", ReturnType = typeof(bool))]
	[CalledBy(Type = "Mono.Security.X509.X509Certificate", Member = "WasCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600062B")]
	public static bool op_GreaterThan(DateTime t1, DateTime t2) { }

	[Address(RVA = "0x1498880", Offset = "0x1497A80", Length = "0x62")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "CompareAdjustmentRuleToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AdjustmentRule), typeof(AdjustmentRule), typeof(DateTime), typeof(DateTime), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(TimeSpan), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>), typeof(Boolean&), typeof(TimeZoneInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "CheckIsDst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(DateTime), typeof(bool), typeof(AdjustmentRule)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsAmbiguousTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsInvalidTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection", Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509FindType", typeof(object), typeof(bool)}, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
	[CalledBy(Type = "UnityEngine.GUI", Member = "ScrollerRepeatButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "UnityEngine.Rect", "UnityEngine.GUIStyle"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600062C")]
	public static bool op_GreaterThanOrEqual(DateTime t1, DateTime t2) { }

	[Address(RVA = "0x1498960", Offset = "0x1497B60", Length = "0x5F")]
	[CalledBy(Type = typeof(AdjustmentRule), Member = "get_HasDaylightSaving", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AdjustmentRule), Member = "ValidateAdjustmentRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(TimeSpan), typeof(TransitionTime), typeof(TransitionTime), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.DefaultWatcher", Member = "StartDispatching", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.DefaultWatcher", Member = "UpdateDataAndDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IO.DefaultWatcherData", typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.IO.DefaultWatcher", Member = "IterateAndModifyFilesData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IO.DefaultWatcherData", typeof(string), typeof(bool), "System.String[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Cookie", Member = "get_Expired", ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000628")]
	public static bool op_Inequality(DateTime d1, DateTime d2) { }

	[Address(RVA = "0x1498A30", Offset = "0x1497C30", Length = "0x62")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection", Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509FindType", typeof(object), typeof(bool)}, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
	[CalledBy(Type = "System.Net.DigestClient", Member = "CheckExpired", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.CookieContainer", Member = "AgeCookies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "CheckRevocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509Certificate2", "System.Security.Cryptography.X509Certificates.X509Certificate2", typeof(bool)}, ReturnType = "System.Security.Cryptography.X509Certificates.X509ChainStatusFlags")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.SliderHandler", Member = "OnRepaint", ReturnType = typeof(float))]
	[CalledBy(Type = "PurchasesService", Member = "CleanupExpiredPurchases", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "System.IComparable.CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsInvalidTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsAmbiguousTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "CheckIsDst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(DateTime), typeof(bool), typeof(AdjustmentRule)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(TimeSpan), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>), typeof(Boolean&), typeof(TimeZoneInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.ServicePoint", Member = "get_HasTimedOut", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.ServicePoint", Member = "get_HostEntry", ReturnType = "System.Net.IPHostEntry")]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000629")]
	public static bool op_LessThan(DateTime t1, DateTime t2) { }

	[Address(RVA = "0x14989C0", Offset = "0x1497BC0", Length = "0x62")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "CompareAdjustmentRuleToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AdjustmentRule), typeof(AdjustmentRule), typeof(DateTime), typeof(DateTime), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "CheckIsDst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(DateTime), typeof(bool), typeof(AdjustmentRule)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "ValidateTimeZoneInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(AdjustmentRule[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection", Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509FindType", typeof(object), typeof(bool)}, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "CheckRevocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509Certificate2", "System.Security.Cryptography.X509Certificates.X509Certificate2", typeof(bool)}, ReturnType = "System.Security.Cryptography.X509Certificates.X509ChainStatusFlags")]
	[CalledBy(Type = "System.Net.Cookie", Member = "get_Expired", ReturnType = typeof(bool))]
	[CalledBy(Type = "Mono.Security.X509.X509Certificate", Member = "get_IsCurrent", ReturnType = typeof(bool))]
	[CalledBy(Type = "Mono.Security.X509.X509Certificate", Member = "WasCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mono.Security.X509.X509Chain", Member = "IsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Security.X509.X509Certificate"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600062A")]
	public static bool op_LessThanOrEqual(DateTime t1, DateTime t2) { }

	[Address(RVA = "0x1498BA0", Offset = "0x1497DA0", Length = "0x62")]
	[CalledBy(Type = "System.Net.FtpWebRequest", Member = "GetResponse", ReturnType = "System.Net.WebResponse")]
	[CalledBy(Type = "UnityEngine.Networking.PlayerConnection.PlayerConnection", Member = "BlockUntilRecvMsg", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.OsTimeModule", Member = "GetUnixTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), "System.Nullable`1<DateTime>"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
	[CalledBy(Type = "MoonSharp.Interpreter.Debugging.DebuggerAction", Member = "get_Age", ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = "System.Net.DigestClient", Member = "CheckExpired", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.FtpWebRequest", Member = "SubmitRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.DefaultWatcher", Member = "UpdateDataAndDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IO.DefaultWatcherData", typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.IO.DefaultWatcher", Member = "StartDispatching", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.UIController", Member = "UpdateTimer", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.ScriptService", Member = "Tick", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(Lease), Member = "ProcessSponsorResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Lease), Member = "UpdateState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Lease), Member = "Renew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(Lease), Member = "get_CurrentLeaseTime", ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDateTime"}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDateTime"}, ReturnType = typeof(DateTimeOffset))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000626")]
	public static TimeSpan op_Subtraction(DateTime d1, DateTime d2) { }

	[Address(RVA = "0x1498AA0", Offset = "0x1497CA0", Length = "0xFF")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(TimeSpan), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>), typeof(Boolean&), typeof(TimeZoneInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsAmbiguousTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsInvalidTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTime&), typeof(DateTimeFormatInfo&), typeof(TimeSpan&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000625")]
	public static DateTime op_Subtraction(DateTime d, TimeSpan t) { }

	[Address(RVA = "0x1495660", Offset = "0x1494860", Length = "0xE8")]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "SetPublishModalSelectedGame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SimpleJSON.JSONNode"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(DateTimeFormatInfo))]
	[Calls(Type = typeof(DateTimeParse), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles)}, ReturnType = typeof(DateTime))]
	[Token(Token = "0x6000614")]
	public static DateTime Parse(string s) { }

	[Address(RVA = "0x1495750", Offset = "0x1494950", Length = "0xF7")]
	[CalledBy(Type = typeof(Convert), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.ComponentModel.DateTimeConverter", Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(DateTimeFormatInfo))]
	[Calls(Type = typeof(DateTimeParse), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles)}, ReturnType = typeof(DateTime))]
	[Token(Token = "0x6000615")]
	public static DateTime Parse(string s, IFormatProvider provider) { }

	[Address(RVA = "0x1495340", Offset = "0x1494540", Length = "0x319")]
	[CalledBy(Type = "Mirror.BouncyCastle.Asn1.Asn1GeneralizedTime", Member = "ParseLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "Mirror.BouncyCastle.Asn1.Asn1GeneralizedTime", Member = "ParseTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "Mirror.BouncyCastle.Asn1.Asn1GeneralizedTime", Member = "ParseUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "Mono.Security.ASN1Convert", Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Security.ASN1"}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "ValidateStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeStyles), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(DateTimeResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetBadFormatSpecifierFailure", ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeParse), Member = "DoStrictParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeStyles), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeResult), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeParse), Member = "GetDateTimeParseException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(DateTimeFormatInfo))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000616")]
	public static DateTime ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style) { }

	[Address(RVA = "0x1495850", Offset = "0x1494A50", Length = "0x76")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "DetermineTimeZoneAdjustments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(DateTimeKind)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000600")]
	public static DateTime SpecifyKind(DateTime value, DateTimeKind kind) { }

	[Address(RVA = "0x14958D0", Offset = "0x1494AD0", Length = "0x62")]
	[CalledBy(Type = typeof(UmAlQuraCalendar), Member = "ConvertGregorianToHijri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.NetworkController+<StartClient>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsX509VerifyParam", Member = "SetTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000617")]
	public TimeSpan Subtract(DateTime value) { }

	[Address(RVA = "0x1495940", Offset = "0x1494B40", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600062E")]
	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	[Address(RVA = "0x14959D0", Offset = "0x1494BD0", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000631")]
	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	[Address(RVA = "0x1495A60", Offset = "0x1494C60", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600062F")]
	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
	[CallerCount(Count = 140)]
	[DeduplicatedMethod]
	[Token(Token = "0x600063B")]
	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	[Address(RVA = "0x1495AF0", Offset = "0x1494CF0", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600063A")]
	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	[Address(RVA = "0x1495B80", Offset = "0x1494D80", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000639")]
	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	[Address(RVA = "0x1495C10", Offset = "0x1494E10", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000632")]
	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	[Address(RVA = "0x1495CA0", Offset = "0x1494EA0", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000634")]
	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	[Address(RVA = "0x1495D30", Offset = "0x1494F30", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000636")]
	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	[Address(RVA = "0x1495DC0", Offset = "0x1494FC0", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000630")]
	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	[Address(RVA = "0x1495E50", Offset = "0x1495050", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000638")]
	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	[Address(RVA = "0x1495EE0", Offset = "0x14950E0", Length = "0x92")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "DefaultToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConvertible), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[Token(Token = "0x600063C")]
	private override object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	[Address(RVA = "0x1495F80", Offset = "0x1495180", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000633")]
	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	[Address(RVA = "0x1496010", Offset = "0x1495210", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000635")]
	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	[Address(RVA = "0x14960A0", Offset = "0x14952A0", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000637")]
	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	[Address(RVA = "0x1496130", Offset = "0x1495330", Length = "0xE7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60005FE")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1496220", Offset = "0x1495420", Length = "0x112")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000618")]
	private static double TicksToOADate(long value) { }

	[Address(RVA = "0x1496340", Offset = "0x1495540", Length = "0xBE")]
	[CalledBy(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(DateTimeKind)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTime), Member = "TryCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpan), Member = "TimeToTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60005F4")]
	private static long TimeToTicks(int hour, int minute, int second) { }

	[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
	[CallerCount(Count = 140)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000640")]
	internal long ToBinaryRaw() { }

	[Address(RVA = "0x1496680", Offset = "0x1495880", Length = "0x4C")]
	[CalledBy(Type = typeof(FileSystemInfo), Member = "get_LastWriteTime", ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplUnix", Member = "get_NotAfter", ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplUnix", Member = "get_NotBefore", ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Net.FtpControlStream", Member = "GetLastModifiedFrom213Response", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Net.Cookie", Member = "get_Expired", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), "System.Xml.XmlDateTimeSerializationMode"}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "SwitchToLocalTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDateTime"}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "ToLocalTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DateTime))]
	[Token(Token = "0x600061A")]
	public DateTime ToLocalTime() { }

	[Address(RVA = "0x1496400", Offset = "0x1495600", Length = "0x277")]
	[CalledBy(Type = typeof(DateTime), Member = "FromFileTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "get_LocalDateTime", ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "FromFileTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTimeOffset))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "get_Local", ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600061B")]
	internal DateTime ToLocalTime(bool throwOnOverflow) { }

	[Address(RVA = "0x14966D0", Offset = "0x14958D0", Length = "0x14B")]
	[CalledBy(Type = "Mirror.NetworkWriterExtensions", Member = "WriteDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkWriter", typeof(DateTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkWriterExtensions", Member = "WriteDateTimeNullable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkWriter", "System.Nullable`1<DateTime>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000619")]
	public double ToOADate() { }

	[Address(RVA = "0x1496890", Offset = "0x1495A90", Length = "0x9B")]
	[CalledBy(Type = typeof(X509Certificate), Member = "GetExpirationDateString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeFormat), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(string), typeof(IFormatProvider), typeof(TimeSpan)}, ReturnType = typeof(string))]
	[Token(Token = "0x600061C")]
	public virtual string ToString() { }

	[Address(RVA = "0x1496990", Offset = "0x1495B90", Length = "0x5F")]
	[CalledBy(Type = "PurchasesService+<DoProcessPurchase>d__18", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.ScreenshotController+<DoScreenshot>d__24", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.UIController", Member = "DebugLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<AutoSaveLoop>d__85", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "SetPublishModalSelectedGame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SimpleJSON.JSONNode"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "FileSave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "DoSaveFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeFormat), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Token(Token = "0x600061D")]
	public string ToString(string format) { }

	[Address(RVA = "0x1496930", Offset = "0x1495B30", Length = "0x5E")]
	[CalledBy(Type = typeof(X509Certificate), Member = "FormatDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.ComponentModel.DateTimeConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeFormat), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Token(Token = "0x600061E")]
	public override string ToString(IFormatProvider provider) { }

	[Address(RVA = "0x1496820", Offset = "0x1495A20", Length = "0x6C")]
	[CalledBy(Type = "System.ComponentModel.DateTimeConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "Mirror.BouncyCastle.Asn1.Asn1GeneralizedTime", Member = "GetContents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mirror.BouncyCastle.Asn1.Asn1GeneralizedTime", Member = "ToStringCanonical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Mirror.BouncyCastle.Asn1.Asn1UtcTime", Member = "GetContents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mirror.BouncyCastle.Asn1.Asn1UtcTime", Member = "ToStringCanonical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.OsTimeModule", Member = "StrFTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTime)}, ReturnType = typeof(string))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeFormat), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Token(Token = "0x600061F")]
	public override string ToString(string format, IFormatProvider provider) { }

	[Address(RVA = "0x14969F0", Offset = "0x1495BF0", Length = "0x52")]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTime&), typeof(DateTimeFormatInfo&), typeof(TimeSpan&)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Mirror.BouncyCastle.Utilities.Date.DateTimeUtilities", Member = "DateTimeToUnixMs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(long))]
	[CalledBy(Type = "Mirror.BouncyCastle.Utilities.Date.DateTimeUtilities", Member = "CurrentUnixMs", ReturnType = typeof(long))]
	[CalledBy(Type = "Mirror.BouncyCastle.Asn1.Asn1GeneralizedTime", Member = "GetContents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mirror.BouncyCastle.Asn1.Asn1GeneralizedTime", Member = "ToStringCanonical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), "System.Xml.XmlDateTimeSerializationMode"}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "SwitchToUtcTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Xml.Schema.Datatype_dateTimeBase", Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "ConvertTimeToUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(DateTime))]
	[Token(Token = "0x6000621")]
	public DateTime ToUniversalTime() { }

	[Address(RVA = "0x1496A50", Offset = "0x1495C50", Length = "0x1FE")]
	[CalledBy(Type = typeof(GregorianCalendar), Member = "TryToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "IsLeapYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "DateToTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTime), Member = "TimeToTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(DateTimeKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600063D")]
	internal static bool TryCreate(int year, int month, int day, int hour, int minute, int second, int millisecond, out DateTime result) { }

	[Address(RVA = "0x1496C50", Offset = "0x1495E50", Length = "0xEF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeFormat), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(TimeSpan)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000620")]
	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider provider = null) { }

	[Address(RVA = "0x1497040", Offset = "0x1496240", Length = "0x219")]
	[CalledBy(Type = "System.Net.CookieParser", Member = "Get", ReturnType = "System.Net.Cookie")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "ValidateStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeStyles), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(DateTimeFormatInfo))]
	[Calls(Type = typeof(DateTimeResult), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeParse), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000622")]
	public static bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result) { }

	[Address(RVA = "0x1496D40", Offset = "0x1495F40", Length = "0x2F7")]
	[CalledBy(Type = "System.Security.Cryptography.DerSequenceReader", Member = "ReadTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.DerSequenceReader+DerTag", typeof(string)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "ValidateStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeStyles), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(DateTimeFormatInfo))]
	[Calls(Type = typeof(DateTimeResult), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeParse), Member = "DoStrictParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeStyles), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetBadFormatSpecifierFailure", ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000623")]
	public static bool TryParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style, out DateTime result) { }

}

