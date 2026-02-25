namespace System.Globalization;

[Token(Token = "0x2000554")]
internal class CalendarData
{
	[Token(Token = "0x4001649")]
	internal const int MAX_CALENDARS = 23; //Field offset: 0x0
	[Token(Token = "0x400165D")]
	internal static CalendarData Invariant; //Field offset: 0x0
	[Token(Token = "0x400165E")]
	private static String[] HEBREW_MONTH_NAMES; //Field offset: 0x8
	[Token(Token = "0x400165F")]
	private static String[] HEBREW_LEAP_MONTH_NAMES; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400164A")]
	internal string sNativeName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400164B")]
	internal String[] saShortDates; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400164C")]
	internal String[] saYearMonths; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400164D")]
	internal String[] saLongDates; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400164E")]
	internal string sMonthDay; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400164F")]
	internal String[] saEraNames; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001650")]
	internal String[] saAbbrevEraNames; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001651")]
	internal String[] saAbbrevEnglishEraNames; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001652")]
	internal String[] saDayNames; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001653")]
	internal String[] saAbbrevDayNames; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001654")]
	internal String[] saSuperShortDayNames; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001655")]
	internal String[] saMonthNames; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001656")]
	internal String[] saAbbrevMonthNames; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001657")]
	internal String[] saMonthGenitiveNames; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001658")]
	internal String[] saAbbrevMonthGenitiveNames; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001659")]
	internal String[] saLeapYearMonthNames; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400165A")]
	internal int iTwoDigitYearMax; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x400165B")]
	internal int iCurrentEra; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400165C")]
	internal bool bUseUserOverrides; //Field offset: 0x98

	[Address(RVA = "0x13EE9F0", Offset = "0x13EDBF0", Length = "0x104B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002666")]
	private static CalendarData() { }

	[Address(RVA = "0x13F01D0", Offset = "0x13EF3D0", Length = "0x11")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002665")]
	private CalendarData() { }

	[Address(RVA = "0x13EFA40", Offset = "0x13EEC40", Length = "0x78D")]
	[CalledBy(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CalendarData))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180211070")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CalendarData), Member = "InitializeEraNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CalendarData), Member = "InitializeAbbreviatedEraNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CalendarData), Member = "GetJapaneseEnglishEraNames", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x6002667")]
	internal CalendarData(string localeName, int calendarId, bool bUseUserOverrides) { }

	[Address(RVA = "0x13EDAF0", Offset = "0x13ECCF0", Length = "0xAC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x600266D")]
	private static string CalendarIdToCultureName(int calendarId) { }

	[Address(RVA = "0x13F01F0", Offset = "0x13EF3F0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180211070")]
	[Token(Token = "0x6002670")]
	private bool fill_calendar_data(string localeName, int datetimeIndex) { }

	[Address(RVA = "0x13EDC80", Offset = "0x13ECE80", Length = "0x194")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CalendarData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600266C")]
	internal static CalendarData GetCalendarData(int calendarId) { }

	[Address(RVA = "0x13EDE70", Offset = "0x13ED070", Length = "0x1CF")]
	[CalledBy(Type = typeof(CalendarData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(JapaneseCalendar), Member = "GetEraInfo", ReturnType = typeof(EraInfo[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600266A")]
	private static String[] GetJapaneseEnglishEraNames() { }

	[Address(RVA = "0x13EE040", Offset = "0x13ED240", Length = "0x1CF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(JapaneseCalendar), Member = "GetEraInfo", ReturnType = typeof(EraInfo[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002669")]
	private static String[] GetJapaneseEraNames() { }

	[Address(RVA = "0x13EE210", Offset = "0x13ED410", Length = "0x13C")]
	[CalledBy(Type = typeof(CalendarData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x600266B")]
	private void InitializeAbbreviatedEraNames(string localeName, int calendarId) { }

	[Address(RVA = "0x13EE590", Offset = "0x13ED790", Length = "0xF4")]
	[CalledBy(Type = typeof(CalendarData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6002668")]
	private void InitializeEraNames(string localeName, int calendarId) { }

	[Address(RVA = "0x13F0200", Offset = "0x13EF400", Length = "0xEB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180211070")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600266F")]
	private static bool nativeGetCalendarData(CalendarData data, string localeName, int calendarId) { }

	[Address(RVA = "0x1108420", Offset = "0x1107620", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600266E")]
	public static int nativeGetTwoDigitYearMax(int calID) { }

}

