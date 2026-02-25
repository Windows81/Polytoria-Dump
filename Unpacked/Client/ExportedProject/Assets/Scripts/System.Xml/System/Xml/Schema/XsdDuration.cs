namespace System.Xml.Schema;

[Token(Token = "0x2000178")]
internal struct XsdDuration
{
	[Token(Token = "0x200017A")]
	internal enum DurationType
	{
		Duration = 0,
		YearMonthDuration = 1,
		DayTimeDuration = 2,
	}

	[Token(Token = "0x2000179")]
	private enum Parts
	{
		HasNone = 0,
		HasYears = 1,
		HasMonths = 2,
		HasDays = 4,
		HasHours = 8,
		HasMinutes = 16,
		HasSeconds = 32,
	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006C8")]
	private int years; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40006C9")]
	private int months; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40006CA")]
	private int days; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40006CB")]
	private int hours; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006CC")]
	private int minutes; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40006CD")]
	private int seconds; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006CE")]
	private uint nanoseconds; //Field offset: 0x18

	[Token(Token = "0x1700034C")]
	public int Days
	{
		[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D0D")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700034D")]
	public int Hours
	{
		[Address(RVA = "0xAFA3A0", Offset = "0xAF95A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D0E")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000349")]
	public bool IsNegative
	{
		[Address(RVA = "0x16EC490", Offset = "0x16EB690", Length = "0xB")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000D0A")]
		 get { } //Length: 11
	}

	[Token(Token = "0x1700034E")]
	public int Minutes
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D0F")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700034B")]
	public int Months
	{
		[Address(RVA = "0x3B87A0", Offset = "0x3B79A0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D0C")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000350")]
	public int Nanoseconds
	{
		[Address(RVA = "0x16EC4A0", Offset = "0x16EB6A0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000D11")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700034F")]
	public int Seconds
	{
		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D10")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700034A")]
	public int Years
	{
		[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
		[CallerCount(Count = 129)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D0B")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x16EC200", Offset = "0x16EB400", Length = "0x28F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D06")]
	public XsdDuration(bool isNegative, int years, int months, int days, int hours, int minutes, int seconds, int nanoseconds) { }

	[Address(RVA = "0x16EBED0", Offset = "0x16EB0D0", Length = "0xB")]
	[CalledBy(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000D07")]
	public XsdDuration(TimeSpan timeSpan) { }

	[Address(RVA = "0x16EBEE0", Offset = "0x16EB0E0", Length = "0x260")]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "DayTimeDurationToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "DurationToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "YearMonthDurationToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D08")]
	public XsdDuration(TimeSpan timeSpan, DurationType durationType) { }

	[Address(RVA = "0x16EC150", Offset = "0x16EB350", Length = "0xA7")]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToDayTimeDuration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToDuration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToYearMonthDuration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TimeSpan))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XsdDuration), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DurationType), typeof(XsdDuration&)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D09")]
	public XsdDuration(string s, DurationType durationType) { }

	[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D0D")]
	public int get_Days() { }

	[Address(RVA = "0xAFA3A0", Offset = "0xAF95A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D0E")]
	public int get_Hours() { }

	[Address(RVA = "0x16EC490", Offset = "0x16EB690", Length = "0xB")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D0A")]
	public bool get_IsNegative() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D0F")]
	public int get_Minutes() { }

	[Address(RVA = "0x3B87A0", Offset = "0x3B79A0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D0C")]
	public int get_Months() { }

	[Address(RVA = "0x16EC4A0", Offset = "0x16EB6A0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D11")]
	public int get_Nanoseconds() { }

	[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D10")]
	public int get_Seconds() { }

	[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
	[CallerCount(Count = 129)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D0B")]
	public int get_Years() { }

	[Address(RVA = "0x16EA750", Offset = "0x16E9950", Length = "0xA")]
	[CalledBy(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XsdDuration), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DurationType)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000D15")]
	public virtual string ToString() { }

	[Address(RVA = "0x16EA760", Offset = "0x16E9960", Length = "0x3E2")]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "DayTimeDurationToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "DurationToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "YearMonthDurationToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlMiscConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XsdDuration), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D16")]
	internal string ToString(DurationType durationType) { }

	[Address(RVA = "0x16EAB50", Offset = "0x16E9D50", Length = "0x46")]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToDayTimeDuration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToDuration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToYearMonthDuration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TimeSpan))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XsdDuration), Member = "TryToTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DurationType), typeof(TimeSpan&)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000D12")]
	public TimeSpan ToTimeSpan(DurationType durationType) { }

	[Address(RVA = "0x16EAD00", Offset = "0x16E9F00", Length = "0xB98")]
	[CalledBy(Type = typeof(Datatype_yearMonthDuration), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver), typeof(Object&)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(Datatype_dayTimeDuration), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver), typeof(Object&)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(XsdDuration), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DurationType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D18")]
	internal static Exception TryParse(string s, DurationType durationType, out XsdDuration result) { }

	[Address(RVA = "0x16EACF0", Offset = "0x16E9EF0", Length = "0xD")]
	[CalledBy(Type = typeof(XmlConvert), Member = "TryToTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan&)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000D17")]
	internal static Exception TryParse(string s, out XsdDuration result) { }

	[Address(RVA = "0x16EABA0", Offset = "0x16E9DA0", Length = "0x14E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D19")]
	private static string TryParseDigits(string s, ref int offset, bool eatDigits, out int result, out int numDigits) { }

	[Address(RVA = "0x16EB8A0", Offset = "0x16EAAA0", Length = "0xD")]
	[CalledBy(Type = typeof(XmlConvert), Member = "TryToTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan&)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000D13")]
	internal Exception TryToTimeSpan(out TimeSpan result) { }

	[Address(RVA = "0x16EB8B0", Offset = "0x16EAAB0", Length = "0x61C")]
	[CalledBy(Type = typeof(Datatype_yearMonthDuration), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver), typeof(Object&)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(Datatype_dayTimeDuration), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver), typeof(Object&)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(XsdDuration), Member = "ToTimeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DurationType)}, ReturnType = typeof(TimeSpan))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE5F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D14")]
	internal Exception TryToTimeSpan(DurationType durationType, out TimeSpan result) { }

}

