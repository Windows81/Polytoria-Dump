namespace System.Xml.Schema;

[Token(Token = "0x2000174")]
internal struct XsdDateTime
{
	[Token(Token = "0x2000175")]
	private enum DateTimeTypeCode
	{
		DateTime = 0,
		Time = 1,
		Date = 2,
		GYearMonth = 3,
		GYear = 4,
		GMonthDay = 5,
		GDay = 6,
		GMonth = 7,
		XdrDateTime = 8,
	}

	[Token(Token = "0x2000177")]
	private struct Parser
	{
		[Token(Token = "0x40006C7")]
		private static Int32[] Power10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006BA")]
		public DateTimeTypeCode typeCode; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40006BB")]
		public int year; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40006BC")]
		public int month; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40006BD")]
		public int day; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40006BE")]
		public int hour; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40006BF")]
		public int minute; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40006C0")]
		public int second; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40006C1")]
		public int fraction; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40006C2")]
		public XsdDateTimeKind kind; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40006C3")]
		public int zoneHour; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40006C4")]
		public int zoneMinute; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40006C5")]
		private string text; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40006C6")]
		private int length; //Field offset: 0x38

		[Address(RVA = "0x16E4020", Offset = "0x16E3220", Length = "0x8C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000D05")]
		private static Parser() { }

		[Address(RVA = "0x16E2FD0", Offset = "0x16E21D0", Length = "0x104A")]
		[CalledBy(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdDateTime), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags), typeof(XsdDateTime&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Parser), Member = "Parse4Dig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Parser), Member = "ParseTimeAndZoneAndWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Parser), Member = "ParseZoneAndWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Parser), Member = "ParseTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Parser), Member = "ParseDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(DateTime), Member = "DaysInMonth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
		[Token(Token = "0x6000CFB")]
		public bool Parse(string text, XsdDateTimeFlags kinds) { }

		[Address(RVA = "0x16E23D0", Offset = "0x16E15D0", Length = "0x8A")]
		[CalledBy(Type = typeof(Parser), Member = "ParseDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Parser), Member = "ParseTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Parser), Member = "ParseZoneAndWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000D02")]
		private bool Parse2Dig(int start, ref int num) { }

		[Address(RVA = "0x16E2460", Offset = "0x16E1660", Length = "0xEE")]
		[CalledBy(Type = typeof(Parser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Parser), Member = "ParseDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000D01")]
		private bool Parse4Dig(int start, ref int num) { }

		[Address(RVA = "0x16E2550", Offset = "0x16E1750", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000D03")]
		private bool ParseChar(int start, char ch) { }

		[Address(RVA = "0x16E2590", Offset = "0x16E1790", Length = "0x2B5")]
		[CalledBy(Type = typeof(Parser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Parser), Member = "Parse4Dig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(Parser), Member = "Parse2Dig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DateTime), Member = "DaysInMonth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000CFC")]
		private bool ParseDate(int start) { }

		[Address(RVA = "0x16E2950", Offset = "0x16E1B50", Length = "0x3DD")]
		[CalledBy(Type = typeof(Parser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Parser), Member = "ParseTimeAndZoneAndWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Parser), Member = "ParseTimeAndWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Parser), Member = "Parse2Dig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000CFF")]
		private bool ParseTime(ref int start) { }

		[Address(RVA = "0x16E2850", Offset = "0x16E1A50", Length = "0x6E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Parser), Member = "ParseTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(bool))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000CFE")]
		private bool ParseTimeAndWhitespace(int start) { }

		[Address(RVA = "0x16E28C0", Offset = "0x16E1AC0", Length = "0x88")]
		[CalledBy(Type = typeof(Parser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Parser), Member = "ParseTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Parser), Member = "ParseZoneAndWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000CFD")]
		private bool ParseTimeAndZoneAndWhitespace(int start) { }

		[Address(RVA = "0x16E2D30", Offset = "0x16E1F30", Length = "0x290")]
		[CalledBy(Type = typeof(Parser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Parser), Member = "ParseTimeAndZoneAndWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Parser), Member = "Parse2Dig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000D00")]
		private bool ParseZoneAndWhitespace(int start) { }

		[Address(RVA = "0x572A40", Offset = "0x571C40", Length = "0x6")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D04")]
		private static bool Test(XsdDateTimeFlags left, XsdDateTimeFlags right) { }

	}

	[Token(Token = "0x2000176")]
	private enum XsdDateTimeKind
	{
		Unspecified = 0,
		Zulu = 1,
		LocalWestOfZulu = 2,
		LocalEastOfZulu = 3,
	}

	[Token(Token = "0x4000694")]
	private static readonly int Lzyyyy; //Field offset: 0x0
	[Token(Token = "0x4000695")]
	private static readonly int Lzyyyy_; //Field offset: 0x4
	[Token(Token = "0x4000696")]
	private static readonly int Lzyyyy_MM; //Field offset: 0x8
	[Token(Token = "0x4000697")]
	private static readonly int Lzyyyy_MM_; //Field offset: 0xC
	[Token(Token = "0x4000698")]
	private static readonly int Lzyyyy_MM_dd; //Field offset: 0x10
	[Token(Token = "0x4000699")]
	private static readonly int Lzyyyy_MM_ddT; //Field offset: 0x14
	[Token(Token = "0x400069A")]
	private static readonly int LzHH; //Field offset: 0x18
	[Token(Token = "0x400069B")]
	private static readonly int LzHH_; //Field offset: 0x1C
	[Token(Token = "0x400069C")]
	private static readonly int LzHH_mm; //Field offset: 0x20
	[Token(Token = "0x400069D")]
	private static readonly int LzHH_mm_; //Field offset: 0x24
	[Token(Token = "0x400069E")]
	private static readonly int LzHH_mm_ss; //Field offset: 0x28
	[Token(Token = "0x400069F")]
	private static readonly int Lz_; //Field offset: 0x2C
	[Token(Token = "0x40006A0")]
	private static readonly int Lz_zz; //Field offset: 0x30
	[Token(Token = "0x40006A1")]
	private static readonly int Lz_zz_; //Field offset: 0x34
	[Token(Token = "0x40006A2")]
	private static readonly int Lz_zz_zz; //Field offset: 0x38
	[Token(Token = "0x40006A3")]
	private static readonly int Lz__; //Field offset: 0x3C
	[Token(Token = "0x40006A4")]
	private static readonly int Lz__mm; //Field offset: 0x40
	[Token(Token = "0x40006A5")]
	private static readonly int Lz__mm_; //Field offset: 0x44
	[Token(Token = "0x40006A6")]
	private static readonly int Lz__mm__; //Field offset: 0x48
	[Token(Token = "0x40006A7")]
	private static readonly int Lz__mm_dd; //Field offset: 0x4C
	[Token(Token = "0x40006A8")]
	private static readonly int Lz___; //Field offset: 0x50
	[Token(Token = "0x40006A9")]
	private static readonly int Lz___dd; //Field offset: 0x54
	[Token(Token = "0x40006AA")]
	private static readonly XmlTypeCode[] typeCodes; //Field offset: 0x58
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000692")]
	private DateTime dt; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000693")]
	private uint extra; //Field offset: 0x8

	[Token(Token = "0x17000342")]
	public int Day
	{
		[Address(RVA = "0x16E99D0", Offset = "0x16E8BD0", Length = "0x49")]
		[CalledBy(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DateTime), Member = "get_Day", ReturnType = typeof(int))]
		[Token(Token = "0x6000CEB")]
		 get { } //Length: 73
	}

	[Token(Token = "0x17000346")]
	public int Fraction
	{
		[Address(RVA = "0x16E9A20", Offset = "0x16E8C20", Length = "0x105")]
		[CalledBy(Type = typeof(XsdDateTime), Member = "PrintTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
		[Calls(Type = typeof(DateTime), Member = "get_Month", ReturnType = typeof(int))]
		[Calls(Type = typeof(DateTime), Member = "get_Day", ReturnType = typeof(int))]
		[Calls(Type = typeof(DateTime), Member = "get_Hour", ReturnType = typeof(int))]
		[Calls(Type = typeof(DateTime), Member = "get_Minute", ReturnType = typeof(int))]
		[Calls(Type = typeof(DateTime), Member = "get_Second", ReturnType = typeof(int))]
		[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000CEF")]
		 get { } //Length: 261
	}

	[Token(Token = "0x17000343")]
	public int Hour
	{
		[Address(RVA = "0x16E9B30", Offset = "0x16E8D30", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DateTime), Member = "get_Hour", ReturnType = typeof(int))]
		[Token(Token = "0x6000CEC")]
		 get { } //Length: 73
	}

	[Token(Token = "0x1700033F")]
	private XsdDateTimeKind InternalKind
	{
		[Address(RVA = "0x1425DA0", Offset = "0x1424FA0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CE8")]
		private get { } //Length: 5
	}

	[Token(Token = "0x1700033E")]
	private DateTimeTypeCode InternalTypeCode
	{
		[Address(RVA = "0x16E9B80", Offset = "0x16E8D80", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000CE7")]
		private get { } //Length: 5
	}

	[Token(Token = "0x17000344")]
	public int Minute
	{
		[Address(RVA = "0x16E9B90", Offset = "0x16E8D90", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DateTime), Member = "get_Minute", ReturnType = typeof(int))]
		[Token(Token = "0x6000CED")]
		 get { } //Length: 73
	}

	[Token(Token = "0x17000341")]
	public int Month
	{
		[Address(RVA = "0x16E9BE0", Offset = "0x16E8DE0", Length = "0x49")]
		[CalledBy(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DateTime), Member = "get_Month", ReturnType = typeof(int))]
		[Token(Token = "0x6000CEA")]
		 get { } //Length: 73
	}

	[Token(Token = "0x17000345")]
	public int Second
	{
		[Address(RVA = "0x16E9C30", Offset = "0x16E8E30", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DateTime), Member = "get_Second", ReturnType = typeof(int))]
		[Token(Token = "0x6000CEE")]
		 get { } //Length: 73
	}

	[Token(Token = "0x17000340")]
	public int Year
	{
		[Address(RVA = "0x16E9C80", Offset = "0x16E8E80", Length = "0x49")]
		[CalledBy(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
		[Token(Token = "0x6000CE9")]
		 get { } //Length: 73
	}

	[Token(Token = "0x17000347")]
	public int ZoneHour
	{
		[Address(RVA = "0x1425DB0", Offset = "0x1424FB0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CF0")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000348")]
	public int ZoneMinute
	{
		[Address(RVA = "0xCE3A00", Offset = "0xCE2C00", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CF1")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x16E8EA0", Offset = "0x16E80A0", Length = "0x4BC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CFA")]
	private static XsdDateTime() { }

	[Address(RVA = "0x16E9360", Offset = "0x16E8560", Length = "0x185")]
	[CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "TimeOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "GYearMonthOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "GMonthDayOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "GYearOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "GDayOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "DateTimeOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "DateOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "GMonthOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Bits), Member = "LeastPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TimeSpan), Member = "get_TotalMinutes", ReturnType = typeof(double))]
	[Calls(Type = typeof(TimeSpan), Member = "Negate", ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Offset", ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeSpan), Member = "get_Minutes", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TimeSpan), Member = "get_Hours", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_DateTime", ReturnType = typeof(DateTime))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000CE6")]
	public XsdDateTime(DateTimeOffset dateTimeOffset, XsdDateTimeFlags kinds) { }

	[Address(RVA = "0x16E9960", Offset = "0x16E8B60", Length = "0x6A")]
	[CalledBy(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000CE5")]
	public XsdDateTime(DateTimeOffset dateTimeOffset) { }

	[Address(RVA = "0x16E97B0", Offset = "0x16E89B0", Length = "0x1A2")]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "TimeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(XmlDateTimeSerializationMode)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "DateToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "DateTimeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "GDayToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "GMonthToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "GMonthDayToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "GYearToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "GYearMonthToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlDateTimeConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(TimeSpan), Member = "get_Hours", ReturnType = typeof(int))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "get_Local", ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TimeSpan), Member = "get_Minutes", ReturnType = typeof(int))]
	[Calls(Type = typeof(Bits), Member = "LeastPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000CE4")]
	public XsdDateTime(DateTime dateTime, XsdDateTimeFlags kinds) { }

	[Address(RVA = "0x16E94F0", Offset = "0x16E86F0", Length = "0x223")]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(XsdDateTime), Member = "InitiateXsdDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Parser)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Parser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000CE0")]
	public XsdDateTime(string text, XsdDateTimeFlags kinds) { }

	[Address(RVA = "0x16E9720", Offset = "0x16E8920", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XsdDateTime), Member = "InitiateXsdDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Parser)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000CE1")]
	private XsdDateTime(Parser parser) { }

	[Address(RVA = "0x16E99D0", Offset = "0x16E8BD0", Length = "0x49")]
	[CalledBy(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "get_Day", ReturnType = typeof(int))]
	[Token(Token = "0x6000CEB")]
	public int get_Day() { }

	[Address(RVA = "0x16E9A20", Offset = "0x16E8C20", Length = "0x105")]
	[CalledBy(Type = typeof(XsdDateTime), Member = "PrintTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Month", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Day", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Hour", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Minute", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Second", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000CEF")]
	public int get_Fraction() { }

	[Address(RVA = "0x16E9B30", Offset = "0x16E8D30", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "get_Hour", ReturnType = typeof(int))]
	[Token(Token = "0x6000CEC")]
	public int get_Hour() { }

	[Address(RVA = "0x1425DA0", Offset = "0x1424FA0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CE8")]
	private XsdDateTimeKind get_InternalKind() { }

	[Address(RVA = "0x16E9B80", Offset = "0x16E8D80", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000CE7")]
	private DateTimeTypeCode get_InternalTypeCode() { }

	[Address(RVA = "0x16E9B90", Offset = "0x16E8D90", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "get_Minute", ReturnType = typeof(int))]
	[Token(Token = "0x6000CED")]
	public int get_Minute() { }

	[Address(RVA = "0x16E9BE0", Offset = "0x16E8DE0", Length = "0x49")]
	[CalledBy(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "get_Month", ReturnType = typeof(int))]
	[Token(Token = "0x6000CEA")]
	public int get_Month() { }

	[Address(RVA = "0x16E9C30", Offset = "0x16E8E30", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "get_Second", ReturnType = typeof(int))]
	[Token(Token = "0x6000CEE")]
	public int get_Second() { }

	[Address(RVA = "0x16E9C80", Offset = "0x16E8E80", Length = "0x49")]
	[CalledBy(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Token(Token = "0x6000CE9")]
	public int get_Year() { }

	[Address(RVA = "0x1425DB0", Offset = "0x1424FB0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CF0")]
	public int get_ZoneHour() { }

	[Address(RVA = "0xCE3A00", Offset = "0xCE2C00", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CF1")]
	public int get_ZoneMinute() { }

	[Address(RVA = "0x16E7AD0", Offset = "0x16E6CD0", Length = "0x122")]
	[CalledBy(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdDateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Parser)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdDateTime), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags), typeof(XsdDateTime&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "AddTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTime))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000CE2")]
	private void InitiateXsdDateTime(Parser parser) { }

	[Address(RVA = "0x16E7C00", Offset = "0x16E6E00", Length = "0xA1")]
	[CalledBy(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000CF8")]
	private void IntToCharArray(Char[] text, int start, int value, int digits) { }

	[Address(RVA = "0x16E9CD0", Offset = "0x16E8ED0", Length = "0x656")]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToGYearMonth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(Datatype_dateTimeBase), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver), typeof(Object&)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToGDay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToGMonth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToGMonthDay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToGYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "UntypedAtomicToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "get_Local", ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(DateTimeKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DateTime), Member = "get_Day", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Month", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000CF2")]
	public static DateTime op_Implicit(XsdDateTime xdt) { }

	[Address(RVA = "0x16EA330", Offset = "0x16E9530", Length = "0x414")]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToDateOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToGDayOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToGMonthOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToGMonthDayOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToGYearOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToGYearMonthOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "UntypedAtomicToDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTimeOffset))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "get_Local", ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DateTime), Member = "get_Month", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "get_Day", ReturnType = typeof(int))]
	[Token(Token = "0x6000CF3")]
	public static DateTimeOffset op_Implicit(XsdDateTime xdt) { }

	[Address(RVA = "0x16E7CB0", Offset = "0x16E6EB0", Length = "0x305")]
	[CalledBy(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Month", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Day", ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000CF5")]
	private void PrintDate(StringBuilder sb) { }

	[Address(RVA = "0x16E7FC0", Offset = "0x16E71C0", Length = "0x422")]
	[CalledBy(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(DateTime), Member = "get_Hour", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Minute", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Second", ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(XsdDateTime), Member = "get_Fraction", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000CF6")]
	private void PrintTime(StringBuilder sb) { }

	[Address(RVA = "0x16E83F0", Offset = "0x16E75F0", Length = "0x33A")]
	[CalledBy(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000CF7")]
	private void PrintZone(StringBuilder sb) { }

	[Address(RVA = "0x16E8730", Offset = "0x16E7930", Length = "0x7B")]
	[CalledBy(Type = typeof(XsdDateTime), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000CF9")]
	private void ShortToCharArray(Char[] text, int start, int value) { }

	[Address(RVA = "0x16E87B0", Offset = "0x16E79B0", Length = "0x564")]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(XsdDateTime), Member = "PrintZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(XsdDateTime), Member = "ShortToCharArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "get_Month", ReturnType = typeof(int))]
	[Calls(Type = typeof(XsdDateTime), Member = "IntToCharArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XsdDateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(XsdDateTime), Member = "PrintTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(XsdDateTime), Member = "PrintDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XsdDateTime), Member = "get_Day", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000CF4")]
	public virtual string ToString() { }

	[Address(RVA = "0x16E8D40", Offset = "0x16E7F40", Length = "0x15F")]
	[CalledBy(Type = typeof(Datatype_dateTimeBase), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver), typeof(Object&)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Parser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XsdDateTimeFlags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XsdDateTime), Member = "InitiateXsdDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Parser)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000CE3")]
	internal static bool TryParse(string text, XsdDateTimeFlags kinds, out XsdDateTime result) { }

}

