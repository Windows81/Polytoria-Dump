namespace System.Globalization;

[ComVisible(True)]
[Token(Token = "0x200055D")]
public class TaiwanCalendar : Calendar
{
	[Token(Token = "0x40016AA")]
	internal static EraInfo[] taiwanEraInfo; //Field offset: 0x0
	[Token(Token = "0x40016AB")]
	internal static Calendar s_defaultInstance; //Field offset: 0x8
	[Token(Token = "0x40016AD")]
	internal static readonly DateTime calendarMinValue; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40016AC")]
	internal GregorianCalendarHelper helper; //Field offset: 0x20

	[Token(Token = "0x170005C6")]
	public virtual Int32[] Eras
	{
		[Address(RVA = "0x13F8FC0", Offset = "0x13F81C0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GregorianCalendarHelper), Member = "get_Eras", ReturnType = typeof(Int32[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600271C")]
		 get { } //Length: 29
	}

	[Token(Token = "0x170005C5")]
	internal virtual int ID
	{
		[Address(RVA = "0x2FFDE0", Offset = "0x2FEFE0", Length = "0x6")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002711")]
		internal get { } //Length: 6
	}

	[ComVisible(False)]
	[Token(Token = "0x170005C4")]
	public virtual DateTime MaxSupportedDateTime
	{
		[Address(RVA = "0x13FB120", Offset = "0x13FA320", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x600270F")]
		 get { } //Length: 79
	}

	[ComVisible(False)]
	[Token(Token = "0x170005C3")]
	public virtual DateTime MinSupportedDateTime
	{
		[Address(RVA = "0x13FB170", Offset = "0x13FA370", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x600270E")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170005C7")]
	public virtual int TwoDigitYearMax
	{
		[Address(RVA = "0x13F9080", Offset = "0x13F8280", Length = "0x6C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600271D")]
		 get { } //Length: 108
		[Address(RVA = "0x13FB1C0", Offset = "0x13FA3C0", Length = "0x133")]
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
		[Token(Token = "0x600271E")]
		 set { } //Length: 307
	}

	[Address(RVA = "0x13FADE0", Offset = "0x13F9FE0", Length = "0x1B0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002720")]
	private static TaiwanCalendar() { }

	[Address(RVA = "0x13FAFA0", Offset = "0x13FA1A0", Length = "0x172")]
	[CalledBy(Type = typeof(TaiwanCalendar), Member = "GetDefaultInstance", ReturnType = typeof(Calendar))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GregorianCalendarHelper), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Calendar), typeof(EraInfo[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(TypeInitializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002710")]
	public TaiwanCalendar() { }

	[Address(RVA = "0x13F8FC0", Offset = "0x13F81C0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GregorianCalendarHelper), Member = "get_Eras", ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600271C")]
	public virtual Int32[] get_Eras() { }

	[Address(RVA = "0x2FFDE0", Offset = "0x2FEFE0", Length = "0x6")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002711")]
	internal virtual int get_ID() { }

	[Address(RVA = "0x13FB120", Offset = "0x13FA320", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600270F")]
	public virtual DateTime get_MaxSupportedDateTime() { }

	[Address(RVA = "0x13FB170", Offset = "0x13FA370", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600270E")]
	public virtual DateTime get_MinSupportedDateTime() { }

	[Address(RVA = "0x13F9080", Offset = "0x13F8280", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600271D")]
	public virtual int get_TwoDigitYearMax() { }

	[Address(RVA = "0x13F83E0", Offset = "0x13F75E0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GregorianCalendarHelper), Member = "GetDayOfMonth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002714")]
	public virtual int GetDayOfMonth(DateTime time) { }

	[Address(RVA = "0x13F8400", Offset = "0x13F7600", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GregorianCalendarHelper), Member = "GetDayOfWeek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(DayOfWeek))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002715")]
	public virtual DayOfWeek GetDayOfWeek(DateTime time) { }

	[Address(RVA = "0x13F8420", Offset = "0x13F7620", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GregorianCalendarHelper), Member = "GetDaysInMonth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002712")]
	public virtual int GetDaysInMonth(int year, int month, int era) { }

	[Address(RVA = "0x13F8450", Offset = "0x13F7650", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GregorianCalendarHelper), Member = "GetDaysInYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002713")]
	public virtual int GetDaysInYear(int year, int era) { }

	[Address(RVA = "0x13FAB60", Offset = "0x13F9D60", Length = "0xED")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "Lex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DS), typeof(__DTString&), typeof(DateTimeToken&), typeof(DateTimeRawInfo&), typeof(DateTimeResult&), typeof(DateTimeFormatInfo&), typeof(DateTimeStyles)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "GetTaiwanCalendarDefaultInstance", ReturnType = typeof(Calendar))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetTaiwanCalendarDTFI", ReturnType = typeof(DateTimeFormatInfo))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TaiwanCalendar), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600270D")]
	internal static Calendar GetDefaultInstance() { }

	[Address(RVA = "0x13F8B40", Offset = "0x13F7D40", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GregorianCalendarHelper), Member = "GetEra", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002717")]
	public virtual int GetEra(DateTime time) { }

	[Address(RVA = "0x13F8B60", Offset = "0x13F7D60", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GregorianCalendarHelper), Member = "GetMonth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002718")]
	public virtual int GetMonth(DateTime time) { }

	[Address(RVA = "0x13F8B80", Offset = "0x13F7D80", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GregorianCalendarHelper), Member = "GetYearOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002716")]
	public virtual int GetMonthsInYear(int year, int era) { }

	[Address(RVA = "0x13F8BB0", Offset = "0x13F7DB0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GregorianCalendarHelper), Member = "GetYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002719")]
	public virtual int GetYear(DateTime time) { }

	[Address(RVA = "0x13F8BD0", Offset = "0x13F7DD0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GregorianCalendarHelper), Member = "IsLeapYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600271A")]
	public virtual bool IsLeapYear(int year, int era) { }

	[Address(RVA = "0x13FB1C0", Offset = "0x13FA3C0", Length = "0x133")]
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
	[Token(Token = "0x600271E")]
	public virtual void set_TwoDigitYearMax(int value) { }

	[Address(RVA = "0x13F8C20", Offset = "0x13F7E20", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GregorianCalendarHelper), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600271B")]
	public virtual DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	[Address(RVA = "0x13FAC50", Offset = "0x13F9E50", Length = "0x18D")]
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
	[Token(Token = "0x600271F")]
	public virtual int ToFourDigitYear(int year) { }

}

