namespace System.Globalization;

[ComVisible(True)]
[Token(Token = "0x2000553")]
public abstract class Calendar : ICloneable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001646")]
	internal int m_currentEraValue; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[OptionalField(VersionAdded = 2)]
	[Token(Token = "0x4001647")]
	private bool m_isReadOnly; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001648")]
	internal int twoDigitYearMax; //Field offset: 0x18

	[Token(Token = "0x1700058E")]
	internal override int BaseCalendarID
	{
		[Address(RVA = "0x13F0A50", Offset = "0x13EFC50", Length = "0x14")]
		[CallerCount(Count = 25)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600264A")]
		internal get { } //Length: 20
	}

	[Token(Token = "0x1700058F")]
	internal override int CurrentEraValue
	{
		[Address(RVA = "0x13F0A70", Offset = "0x13EFC70", Length = "0x208")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CalendarData))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600264E")]
		internal get { } //Length: 520
	}

	[Token(Token = "0x17000590")]
	public abstract Int32[] Eras
	{
		[Token(Token = "0x6002654")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700058D")]
	internal override int ID
	{
		[Address(RVA = "0x1108420", Offset = "0x1107620", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002649")]
		internal get { } //Length: 6
	}

	[ComVisible(False)]
	[Token(Token = "0x1700058C")]
	public override DateTime MaxSupportedDateTime
	{
		[Address(RVA = "0x13F0CD0", Offset = "0x13EFED0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6002647")]
		 get { } //Length: 79
	}

	[ComVisible(False)]
	[Token(Token = "0x1700058B")]
	public override DateTime MinSupportedDateTime
	{
		[Address(RVA = "0x13F0D20", Offset = "0x13EFF20", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6002646")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000591")]
	public override int TwoDigitYearMax
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002660")]
		 get { } //Length: 4
		[Address(RVA = "0x13F0D70", Offset = "0x13EFF70", Length = "0x24")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Calendar), Member = "VerifyWritable", ReturnType = typeof(void))]
		[Token(Token = "0x6002661")]
		 set { } //Length: 36
	}

	[Address(RVA = "0x13F0A30", Offset = "0x13EFC30", Length = "0x15")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002648")]
	protected Calendar() { }

	[Address(RVA = "0x13F02F0", Offset = "0x13EF4F0", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ComVisible(False)]
	[Token(Token = "0x600264B")]
	public override object Clone() { }

	[Address(RVA = "0x13F0A50", Offset = "0x13EFC50", Length = "0x14")]
	[CallerCount(Count = 25)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600264A")]
	internal override int get_BaseCalendarID() { }

	[Address(RVA = "0x13F0A70", Offset = "0x13EFC70", Length = "0x208")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CultureData), Member = "GetCalendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CalendarData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600264E")]
	internal override int get_CurrentEraValue() { }

	[Token(Token = "0x6002654")]
	public abstract Int32[] get_Eras() { }

	[Address(RVA = "0x1108420", Offset = "0x1107620", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002649")]
	internal override int get_ID() { }

	[Address(RVA = "0x13F0CD0", Offset = "0x13EFED0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6002647")]
	public override DateTime get_MaxSupportedDateTime() { }

	[Address(RVA = "0x13F0D20", Offset = "0x13EFF20", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6002646")]
	public override DateTime get_MinSupportedDateTime() { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002660")]
	public override int get_TwoDigitYearMax() { }

	[Token(Token = "0x600264F")]
	public abstract int GetDayOfMonth(DateTime time) { }

	[Token(Token = "0x6002650")]
	public abstract DayOfWeek GetDayOfWeek(DateTime time) { }

	[Token(Token = "0x6002651")]
	public abstract int GetDaysInMonth(int year, int month, int era) { }

	[Token(Token = "0x6002652")]
	public abstract int GetDaysInYear(int year, int era) { }

	[Token(Token = "0x6002653")]
	public abstract int GetEra(DateTime time) { }

	[Token(Token = "0x6002655")]
	public abstract int GetMonth(DateTime time) { }

	[Token(Token = "0x6002656")]
	public abstract int GetMonthsInYear(int year, int era) { }

	[Address(RVA = "0x13F0370", Offset = "0x13EF570", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6002664")]
	internal static int GetSystemTwoDigitYearSetting(int CalID, int defaultYearValue) { }

	[Token(Token = "0x6002657")]
	public abstract int GetYear(DateTime time) { }

	[Address(RVA = "0x13F03C0", Offset = "0x13EF5C0", Length = "0x17")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002658")]
	public override bool IsLeapYear(int year) { }

	[Token(Token = "0x6002659")]
	public abstract bool IsLeapYear(int year, int era) { }

	[Address(RVA = "0x13F03E0", Offset = "0x13EF5E0", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600265F")]
	internal override bool IsValidDay(int year, int month, int day, int era) { }

	[Address(RVA = "0x13F0470", Offset = "0x13EF670", Length = "0x77")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600265E")]
	internal override bool IsValidMonth(int year, int month, int era) { }

	[Address(RVA = "0x13F04F0", Offset = "0x13EF6F0", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600265D")]
	internal override bool IsValidYear(int year, int era) { }

	[Address(RVA = "0x13F0D70", Offset = "0x13EFF70", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Calendar), Member = "VerifyWritable", ReturnType = typeof(void))]
	[Token(Token = "0x6002661")]
	public override void set_TwoDigitYearMax(int value) { }

	[Address(RVA = "0x59B020", Offset = "0x59A220", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600264D")]
	internal void SetReadOnlyState(bool readOnly) { }

	[Address(RVA = "0x13F0580", Offset = "0x13EF780", Length = "0x1BE")]
	[CalledBy(Type = typeof(HijriCalendar), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(UmAlQuraCalendar), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpan), Member = "TimeToTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002663")]
	internal static long TimeToTicks(int hour, int minute, int second, int millisecond) { }

	[Address(RVA = "0x13F0740", Offset = "0x13EF940", Length = "0x56")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600265A")]
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond) { }

	[Token(Token = "0x600265B")]
	public abstract DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	[Address(RVA = "0x13F07A0", Offset = "0x13EF9A0", Length = "0x10E")]
	[CalledBy(Type = typeof(GregorianCalendar), Member = "ToFourDigitYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(HijriCalendar), Member = "ToFourDigitYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UmAlQuraCalendar), Member = "ToFourDigitYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002662")]
	public override int ToFourDigitYear(int year) { }

	[Address(RVA = "0x13F08B0", Offset = "0x13EFAB0", Length = "0xF7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600265C")]
	internal override bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result) { }

	[Address(RVA = "0x13F09B0", Offset = "0x13EFBB0", Length = "0x78")]
	[CalledBy(Type = typeof(Calendar), Member = "set_TwoDigitYearMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GregorianCalendar), Member = "set_TwoDigitYearMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HijriCalendar), Member = "set_TwoDigitYearMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JapaneseCalendar), Member = "set_TwoDigitYearMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaiwanCalendar), Member = "set_TwoDigitYearMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThaiBuddhistCalendar), Member = "set_TwoDigitYearMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UmAlQuraCalendar), Member = "set_TwoDigitYearMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600264C")]
	internal void VerifyWritable() { }

}

