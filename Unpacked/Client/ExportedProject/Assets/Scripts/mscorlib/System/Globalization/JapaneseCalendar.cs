namespace System.Globalization;

[ComVisible(True)]
[Token(Token = "0x200055A")]
public class JapaneseCalendar : Calendar
{
	[Token(Token = "0x4001680")]
	internal static readonly DateTime calendarMinValue; //Field offset: 0x0
	[Token(Token = "0x4001681")]
	internal static EraInfo[] japaneseEraInfo; //Field offset: 0x8
	[Token(Token = "0x4001682")]
	internal static Calendar s_defaultInstance; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001683")]
	internal GregorianCalendarHelper helper; //Field offset: 0x20

	[Token(Token = "0x170005A2")]
	public virtual Int32[] Eras
	{
		[Address(RVA = "0x13F8FC0", Offset = "0x13F81C0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GregorianCalendarHelper), Member = "get_Eras", ReturnType = typeof(Int32[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60026D1")]
		 get { } //Length: 29
	}

	[Token(Token = "0x170005A1")]
	internal virtual int ID
	{
		[Address(RVA = "0x300CD0", Offset = "0x2FFED0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60026C5")]
		internal get { } //Length: 6
	}

	[ComVisible(False)]
	[Token(Token = "0x170005A0")]
	public virtual DateTime MaxSupportedDateTime
	{
		[Address(RVA = "0x13F8FE0", Offset = "0x13F81E0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60026C0")]
		 get { } //Length: 79
	}

	[ComVisible(False)]
	[Token(Token = "0x1700059F")]
	public virtual DateTime MinSupportedDateTime
	{
		[Address(RVA = "0x13F9030", Offset = "0x13F8230", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60026BF")]
		 get { } //Length: 78
	}

	[Token(Token = "0x170005A3")]
	public virtual int TwoDigitYearMax
	{
		[Address(RVA = "0x13F9080", Offset = "0x13F8280", Length = "0x6C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60026D5")]
		 get { } //Length: 108
		[Address(RVA = "0x13F90F0", Offset = "0x13F82F0", Length = "0x133")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Calendar), Member = "VerifyWritable", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
		[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x60026D6")]
		 set { } //Length: 307
	}

	[Address(RVA = "0x13F8DE0", Offset = "0x13F7FE0", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x60026D7")]
	private static JapaneseCalendar() { }

	[Address(RVA = "0x13F8E50", Offset = "0x13F8050", Length = "0x168")]
	[CalledBy(Type = typeof(JapaneseCalendar), Member = "GetDefaultInstance", ReturnType = typeof(Calendar))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GregorianCalendarHelper), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Calendar), typeof(EraInfo[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(JapaneseCalendar), Member = "GetEraInfo", ReturnType = typeof(EraInfo[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(TypeInitializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60026C4")]
	public JapaneseCalendar() { }

	[Address(RVA = "0x13F8200", Offset = "0x13F7400", Length = "0xEA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(JapaneseCalendar), Member = "GetEraInfo", ReturnType = typeof(EraInfo[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60026D3")]
	internal static String[] EnglishEraNames() { }

	[Address(RVA = "0x13F82F0", Offset = "0x13F74F0", Length = "0xEA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(JapaneseCalendar), Member = "GetEraInfo", ReturnType = typeof(EraInfo[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60026D2")]
	internal static String[] EraNames() { }

	[Address(RVA = "0x13F8FC0", Offset = "0x13F81C0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GregorianCalendarHelper), Member = "get_Eras", ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60026D1")]
	public virtual Int32[] get_Eras() { }

	[Address(RVA = "0x300CD0", Offset = "0x2FFED0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60026C5")]
	internal virtual int get_ID() { }

	[Address(RVA = "0x13F8FE0", Offset = "0x13F81E0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60026C0")]
	public virtual DateTime get_MaxSupportedDateTime() { }

	[Address(RVA = "0x13F9030", Offset = "0x13F8230", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60026BF")]
	public virtual DateTime get_MinSupportedDateTime() { }

	[Address(RVA = "0x13F9080", Offset = "0x13F8280", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60026D5")]
	public virtual int get_TwoDigitYearMax() { }

	[Address(RVA = "0x13F83E0", Offset = "0x13F75E0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GregorianCalendarHelper), Member = "GetDayOfMonth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60026C8")]
	public virtual int GetDayOfMonth(DateTime time) { }

	[Address(RVA = "0x13F8400", Offset = "0x13F7600", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GregorianCalendarHelper), Member = "GetDayOfWeek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(DayOfWeek))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60026C9")]
	public virtual DayOfWeek GetDayOfWeek(DateTime time) { }

	[Address(RVA = "0x13F8420", Offset = "0x13F7620", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GregorianCalendarHelper), Member = "GetDaysInMonth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60026C6")]
	public virtual int GetDaysInMonth(int year, int month, int era) { }

	[Address(RVA = "0x13F8450", Offset = "0x13F7650", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GregorianCalendarHelper), Member = "GetDaysInYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60026C7")]
	public virtual int GetDaysInYear(int year, int era) { }

	[Address(RVA = "0x13F8470", Offset = "0x13F7670", Length = "0xED")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "Lex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeToken&), typeof(DateTimeRawInfo&), typeof(DateTimeResult&), typeof(DateTimeFormatInfo&), typeof(DateTimeStyles)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetJapaneseCalendarDefaultInstance", ReturnType = typeof(Calendar))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetJapaneseCalendarDTFI", ReturnType = typeof(DateTimeFormatInfo))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(JapaneseCalendar), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60026C3")]
	internal static Calendar GetDefaultInstance() { }

	[Address(RVA = "0x13F8B40", Offset = "0x13F7D40", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GregorianCalendarHelper), Member = "GetEra", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60026CB")]
	public virtual int GetEra(DateTime time) { }

	[Address(RVA = "0x13F8560", Offset = "0x13F7760", Length = "0x5DA")]
	[CalledBy(Type = typeof(CalendarData), Member = "GetJapaneseEraNames", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(CalendarData), Member = "GetJapaneseEnglishEraNames", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(JapaneseCalendar), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JapaneseCalendar), Member = "EraNames", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(JapaneseCalendar), Member = "EnglishEraNames", ReturnType = typeof(String[]))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(EraInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Token(Token = "0x60026C1")]
	internal static EraInfo[] GetEraInfo() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x60026C2")]
	private static EraInfo[] GetErasFromRegistry() { }

	[Address(RVA = "0x13F8B60", Offset = "0x13F7D60", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GregorianCalendarHelper), Member = "GetMonth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60026CC")]
	public virtual int GetMonth(DateTime time) { }

	[Address(RVA = "0x13F8B80", Offset = "0x13F7D80", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GregorianCalendarHelper), Member = "GetYearOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60026CA")]
	public virtual int GetMonthsInYear(int year, int era) { }

	[Address(RVA = "0x13F8BB0", Offset = "0x13F7DB0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GregorianCalendarHelper), Member = "GetYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60026CD")]
	public virtual int GetYear(DateTime time) { }

	[Address(RVA = "0x13F8BD0", Offset = "0x13F7DD0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GregorianCalendarHelper), Member = "IsLeapYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60026CE")]
	public virtual bool IsLeapYear(int year, int era) { }

	[Address(RVA = "0x13F8BF0", Offset = "0x13F7DF0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GregorianCalendarHelper), Member = "GetYearOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026D4")]
	internal virtual bool IsValidYear(int year, int era) { }

	[Address(RVA = "0x13F90F0", Offset = "0x13F82F0", Length = "0x133")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Calendar), Member = "VerifyWritable", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60026D6")]
	public virtual void set_TwoDigitYearMax(int value) { }

	[Address(RVA = "0x13F8C20", Offset = "0x13F7E20", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GregorianCalendarHelper), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60026CF")]
	public virtual DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	[Address(RVA = "0x13F8C50", Offset = "0x13F7E50", Length = "0x18D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60026D0")]
	public virtual int ToFourDigitYear(int year) { }

}

