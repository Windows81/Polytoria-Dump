namespace System.Globalization;

[ComVisible(True)]
[Token(Token = "0x200055F")]
public class ThaiBuddhistCalendar : Calendar
{
	[Token(Token = "0x40016B7")]
	internal static EraInfo[] thaiBuddhistEraInfo; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40016B8")]
	internal GregorianCalendarHelper helper; //Field offset: 0x20

	[Token(Token = "0x170005CE")]
	public virtual Int32[] Eras
	{
		[Address(RVA = "0x13F8FC0", Offset = "0x13F81C0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GregorianCalendarHelper), Member = "get_Eras", ReturnType = typeof(Int32[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600274B")]
		 get { } //Length: 29
	}

	[Token(Token = "0x170005CD")]
	internal virtual int ID
	{
		[Address(RVA = "0x2FF230", Offset = "0x2FE430", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002740")]
		internal get { } //Length: 6
	}

	[ComVisible(False)]
	[Token(Token = "0x170005CC")]
	public virtual DateTime MaxSupportedDateTime
	{
		[Address(RVA = "0x13FCE90", Offset = "0x13FC090", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x600273E")]
		 get { } //Length: 79
	}

	[ComVisible(False)]
	[Token(Token = "0x170005CB")]
	public virtual DateTime MinSupportedDateTime
	{
		[Address(RVA = "0x13FCEE0", Offset = "0x13FC0E0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x600273D")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170005CF")]
	public virtual int TwoDigitYearMax
	{
		[Address(RVA = "0x13FCF30", Offset = "0x13FC130", Length = "0x6C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600274C")]
		 get { } //Length: 108
		[Address(RVA = "0x13FCFA0", Offset = "0x13FC1A0", Length = "0x133")]
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
		[Token(Token = "0x600274D")]
		 set { } //Length: 307
	}

	[Address(RVA = "0x13FCC60", Offset = "0x13FBE60", Length = "0x16E")]
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
	[Token(Token = "0x600274F")]
	private static ThaiBuddhistCalendar() { }

	[Address(RVA = "0x13FCDD0", Offset = "0x13FBFD0", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GregorianCalendarHelper), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Calendar), typeof(EraInfo[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600273F")]
	public ThaiBuddhistCalendar() { }

	[Address(RVA = "0x13F8FC0", Offset = "0x13F81C0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GregorianCalendarHelper), Member = "get_Eras", ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600274B")]
	public virtual Int32[] get_Eras() { }

	[Address(RVA = "0x2FF230", Offset = "0x2FE430", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002740")]
	internal virtual int get_ID() { }

	[Address(RVA = "0x13FCE90", Offset = "0x13FC090", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600273E")]
	public virtual DateTime get_MaxSupportedDateTime() { }

	[Address(RVA = "0x13FCEE0", Offset = "0x13FC0E0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600273D")]
	public virtual DateTime get_MinSupportedDateTime() { }

	[Address(RVA = "0x13FCF30", Offset = "0x13FC130", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600274C")]
	public virtual int get_TwoDigitYearMax() { }

	[Address(RVA = "0x13F83E0", Offset = "0x13F75E0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GregorianCalendarHelper), Member = "GetDayOfMonth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002743")]
	public virtual int GetDayOfMonth(DateTime time) { }

	[Address(RVA = "0x13F8400", Offset = "0x13F7600", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GregorianCalendarHelper), Member = "GetDayOfWeek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(DayOfWeek))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002744")]
	public virtual DayOfWeek GetDayOfWeek(DateTime time) { }

	[Address(RVA = "0x13F8420", Offset = "0x13F7620", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GregorianCalendarHelper), Member = "GetDaysInMonth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002741")]
	public virtual int GetDaysInMonth(int year, int month, int era) { }

	[Address(RVA = "0x13F8450", Offset = "0x13F7650", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GregorianCalendarHelper), Member = "GetDaysInYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002742")]
	public virtual int GetDaysInYear(int year, int era) { }

	[Address(RVA = "0x13F8B40", Offset = "0x13F7D40", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GregorianCalendarHelper), Member = "GetEra", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002746")]
	public virtual int GetEra(DateTime time) { }

	[Address(RVA = "0x13F8B60", Offset = "0x13F7D60", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GregorianCalendarHelper), Member = "GetMonth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002747")]
	public virtual int GetMonth(DateTime time) { }

	[Address(RVA = "0x13F8B80", Offset = "0x13F7D80", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GregorianCalendarHelper), Member = "GetYearOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002745")]
	public virtual int GetMonthsInYear(int year, int era) { }

	[Address(RVA = "0x13F8BB0", Offset = "0x13F7DB0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GregorianCalendarHelper), Member = "GetYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002748")]
	public virtual int GetYear(DateTime time) { }

	[Address(RVA = "0x13F8BD0", Offset = "0x13F7DD0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GregorianCalendarHelper), Member = "IsLeapYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002749")]
	public virtual bool IsLeapYear(int year, int era) { }

	[Address(RVA = "0x13FCFA0", Offset = "0x13FC1A0", Length = "0x133")]
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
	[Token(Token = "0x600274D")]
	public virtual void set_TwoDigitYearMax(int value) { }

	[Address(RVA = "0x13F8C20", Offset = "0x13F7E20", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GregorianCalendarHelper), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600274A")]
	public virtual DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	[Address(RVA = "0x13FCBA0", Offset = "0x13FBDA0", Length = "0xB0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GregorianCalendarHelper), Member = "ToFourDigitYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600274E")]
	public virtual int ToFourDigitYear(int year) { }

}

