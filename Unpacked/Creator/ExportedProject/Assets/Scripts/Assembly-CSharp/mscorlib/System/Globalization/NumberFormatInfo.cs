namespace System.Globalization;

[ComVisible(True)]
[Token(Token = "0x200055B")]
public sealed class NumberFormatInfo : ICloneable, IFormatProvider
{
	[Token(Token = "0x4001684")]
	private static NumberFormatInfo invariantInfo; //Field offset: 0x0
	[Token(Token = "0x40016A7")]
	private const NumberStyles InvalidNumberStyles = -1024; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001685")]
	internal Int32[] numberGroupSizes; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001686")]
	internal Int32[] currencyGroupSizes; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001687")]
	internal Int32[] percentGroupSizes; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001688")]
	internal string positiveSign; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001689")]
	internal string negativeSign; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400168A")]
	internal string numberDecimalSeparator; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400168B")]
	internal string numberGroupSeparator; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400168C")]
	internal string currencyGroupSeparator; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400168D")]
	internal string currencyDecimalSeparator; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400168E")]
	internal string currencySymbol; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400168F")]
	internal string ansiCurrencySymbol; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001690")]
	internal string nanSymbol; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001691")]
	internal string positiveInfinitySymbol; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001692")]
	internal string negativeInfinitySymbol; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001693")]
	internal string percentDecimalSeparator; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001694")]
	internal string percentGroupSeparator; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001695")]
	internal string percentSymbol; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4001696")]
	internal string perMilleSymbol; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[OptionalField(VersionAdded = 2)]
	[Token(Token = "0x4001697")]
	internal String[] nativeDigits; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[OptionalField(VersionAdded = 1)]
	[Token(Token = "0x4001698")]
	internal int m_dataItem; //Field offset: 0xA8
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x4001699")]
	internal int numberDecimalDigits; //Field offset: 0xAC
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400169A")]
	internal int currencyDecimalDigits; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x400169B")]
	internal int currencyPositivePattern; //Field offset: 0xB4
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400169C")]
	internal int currencyNegativePattern; //Field offset: 0xB8
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x400169D")]
	internal int numberNegativePattern; //Field offset: 0xBC
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400169E")]
	internal int percentPositivePattern; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x400169F")]
	internal int percentNegativePattern; //Field offset: 0xC4
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40016A0")]
	internal int percentDecimalDigits; //Field offset: 0xC8
	[FieldOffset(Offset = "0xCC")]
	[OptionalField(VersionAdded = 2)]
	[Token(Token = "0x40016A1")]
	internal int digitSubstitution; //Field offset: 0xCC
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40016A2")]
	internal bool isReadOnly; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD1")]
	[OptionalField(VersionAdded = 1)]
	[Token(Token = "0x40016A3")]
	internal bool m_useUserOverride; //Field offset: 0xD1
	[FieldOffset(Offset = "0xD2")]
	[OptionalField(VersionAdded = 2)]
	[Token(Token = "0x40016A4")]
	internal bool m_isInvariant; //Field offset: 0xD2
	[FieldOffset(Offset = "0xD3")]
	[OptionalField(VersionAdded = 1)]
	[Token(Token = "0x40016A5")]
	internal bool validForParseAsNumber; //Field offset: 0xD3
	[FieldOffset(Offset = "0xD4")]
	[OptionalField(VersionAdded = 1)]
	[Token(Token = "0x40016A6")]
	internal bool validForParseAsCurrency; //Field offset: 0xD4

	[Token(Token = "0x170005A5")]
	public int CurrencyDecimalDigits
	{
		[Address(RVA = "0x13F9F60", Offset = "0x13F9160", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60026E1")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170005A6")]
	public string CurrencyDecimalSeparator
	{
		[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		[Token(Token = "0x60026E2")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170005AB")]
	public string CurrencyGroupSeparator
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x60026E7")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170005A8")]
	public Int32[] CurrencyGroupSizes
	{
		[Address(RVA = "0x13F9F70", Offset = "0x13F9170", Length = "0x77")]
		[CalledBy(Type = "System.Globalization.FormatProvider+Number", Member = "FormatCurrency", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Text.ValueStringBuilder&", "NumberBuffer&", typeof(int), typeof(int), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60026E4")]
		 get { } //Length: 119
	}

	[Token(Token = "0x170005AF")]
	public int CurrencyNegativePattern
	{
		[Address(RVA = "0x13F9FF0", Offset = "0x13F91F0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60026EC")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170005B8")]
	public int CurrencyPositivePattern
	{
		[Address(RVA = "0x13FA000", Offset = "0x13F9200", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60026F5")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170005AC")]
	public string CurrencySymbol
	{
		[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60026E8")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170005AD")]
	public static NumberFormatInfo CurrentInfo
	{
		[Address(RVA = "0x13FA010", Offset = "0x13F9210", Length = "0xFE")]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[Calls(Type = typeof(Thread), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60026E9")]
		 get { } //Length: 254
	}

	[Token(Token = "0x170005A4")]
	public static NumberFormatInfo InvariantInfo
	{
		[Address(RVA = "0x13FA110", Offset = "0x13F9310", Length = "0x116")]
		[CallerCount(Count = 77)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NumberFormatInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60026DE")]
		 get { } //Length: 278
	}

	[Token(Token = "0x170005A7")]
	public bool IsReadOnly
	{
		[Address(RVA = "0x3D66D0", Offset = "0x3D58D0", Length = "0x8")]
		[CallerCount(Count = 42)]
		[DeduplicatedMethod]
		[Token(Token = "0x60026E3")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170005AE")]
	public string NaNSymbol
	{
		[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60026EA")]
		 get { } //Length: 5
		[Address(RVA = "0x13FA340", Offset = "0x13F9540", Length = "0xE9")]
		[CalledBy(Type = typeof(CultureData), Member = "GetNFIValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x60026EB")]
		 set { } //Length: 233
	}

	[Token(Token = "0x170005B3")]
	public string NegativeInfinitySymbol
	{
		[Address(RVA = "0x2DD190", Offset = "0x2DC390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60026F0")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170005B4")]
	public string NegativeSign
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x60026F1")]
		 get { } //Length: 95
	}

	[Token(Token = "0x170005B5")]
	public int NumberDecimalDigits
	{
		[Address(RVA = "0x50C460", Offset = "0x50B660", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60026F2")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170005B6")]
	public string NumberDecimalSeparator
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x60026F3")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170005B7")]
	public string NumberGroupSeparator
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60026F4")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170005A9")]
	public Int32[] NumberGroupSizes
	{
		[Address(RVA = "0x13FA230", Offset = "0x13F9430", Length = "0x77")]
		[CalledBy(Type = "System.Globalization.FormatProvider+Number", Member = "NumberToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Text.ValueStringBuilder&", "NumberBuffer&", typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Globalization.FormatProvider+Number", Member = "FormatNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Text.ValueStringBuilder&", "NumberBuffer&", typeof(int), typeof(int), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Globalization.FormatProvider+Number", Member = "NumberToStringFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Text.ValueStringBuilder&", "NumberBuffer&", "System.ReadOnlySpan`1<Char>", typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60026E5")]
		 get { } //Length: 119
	}

	[Token(Token = "0x170005B0")]
	public int NumberNegativePattern
	{
		[Address(RVA = "0x3D6660", Offset = "0x3D5860", Length = "0x7")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x60026ED")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170005BB")]
	public int PercentDecimalDigits
	{
		[Address(RVA = "0x13FA2B0", Offset = "0x13F94B0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60026F8")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170005BC")]
	public string PercentDecimalSeparator
	{
		[Address(RVA = "0x2DD220", Offset = "0x2DC420", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60026F9")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170005BD")]
	public string PercentGroupSeparator
	{
		[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60026FA")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170005AA")]
	public Int32[] PercentGroupSizes
	{
		[Address(RVA = "0x13FA2C0", Offset = "0x13F94C0", Length = "0x77")]
		[CalledBy(Type = "System.Globalization.FormatProvider+Number", Member = "FormatPercent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Text.ValueStringBuilder&", "NumberBuffer&", typeof(int), typeof(int), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60026E6")]
		 get { } //Length: 119
	}

	[Token(Token = "0x170005B2")]
	public int PercentNegativePattern
	{
		[Address(RVA = "0xE6C4F0", Offset = "0xE6B6F0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60026EF")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170005B1")]
	public int PercentPositivePattern
	{
		[Address(RVA = "0x3D6650", Offset = "0x3D5850", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60026EE")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170005BE")]
	public string PercentSymbol
	{
		[Address(RVA = "0x2DD200", Offset = "0x2DC400", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60026FB")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170005BF")]
	public string PerMilleSymbol
	{
		[Address(RVA = "0x2DD240", Offset = "0x2DC440", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60026FC")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170005B9")]
	public string PositiveInfinitySymbol
	{
		[Address(RVA = "0x3F5890", Offset = "0x3F4A90", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60026F6")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170005BA")]
	public string PositiveSign
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x60026F7")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x13F9980", Offset = "0x13F8B80", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NumberFormatInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData)}, ReturnType = typeof(void))]
	[Token(Token = "0x60026D8")]
	public NumberFormatInfo() { }

	[Address(RVA = "0x13F9990", Offset = "0x13F8B90", Length = "0x5C0")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_FullTimeSpanPositivePattern", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_FullTimeSpanNegativePattern", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(NumberFormatInfo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[CalledBy(Type = typeof(CultureInfo), Member = "get_NumberFormat", ReturnType = typeof(NumberFormatInfo))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureData), Member = "GetNFIValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureData), Member = "get_IsInvariantCulture", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60026DC")]
	internal NumberFormatInfo(CultureData cultureData) { }

	[Address(RVA = "0x13F9230", Offset = "0x13F8430", Length = "0x64")]
	[CalledBy(Type = typeof(CultureInfo), Member = "Clone", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(CultureInfo), Member = "ConstructInvariant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60026E0")]
	public override object Clone() { }

	[Address(RVA = "0x13F9F60", Offset = "0x13F9160", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60026E1")]
	public int get_CurrencyDecimalDigits() { }

	[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	[Token(Token = "0x60026E2")]
	public string get_CurrencyDecimalSeparator() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x60026E7")]
	public string get_CurrencyGroupSeparator() { }

	[Address(RVA = "0x13F9F70", Offset = "0x13F9170", Length = "0x77")]
	[CalledBy(Type = "System.Globalization.FormatProvider+Number", Member = "FormatCurrency", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Text.ValueStringBuilder&", "NumberBuffer&", typeof(int), typeof(int), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60026E4")]
	public Int32[] get_CurrencyGroupSizes() { }

	[Address(RVA = "0x13F9FF0", Offset = "0x13F91F0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60026EC")]
	public int get_CurrencyNegativePattern() { }

	[Address(RVA = "0x13FA000", Offset = "0x13F9200", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60026F5")]
	public int get_CurrencyPositivePattern() { }

	[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60026E8")]
	public string get_CurrencySymbol() { }

	[Address(RVA = "0x13FA010", Offset = "0x13F9210", Length = "0xFE")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(Thread), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60026E9")]
	public static NumberFormatInfo get_CurrentInfo() { }

	[Address(RVA = "0x13FA110", Offset = "0x13F9310", Length = "0x116")]
	[CallerCount(Count = 77)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NumberFormatInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60026DE")]
	public static NumberFormatInfo get_InvariantInfo() { }

	[Address(RVA = "0x3D66D0", Offset = "0x3D58D0", Length = "0x8")]
	[CallerCount(Count = 42)]
	[DeduplicatedMethod]
	[Token(Token = "0x60026E3")]
	public bool get_IsReadOnly() { }

	[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60026EA")]
	public string get_NaNSymbol() { }

	[Address(RVA = "0x2DD190", Offset = "0x2DC390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60026F0")]
	public string get_NegativeInfinitySymbol() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x60026F1")]
	public string get_NegativeSign() { }

	[Address(RVA = "0x50C460", Offset = "0x50B660", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60026F2")]
	public int get_NumberDecimalDigits() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x60026F3")]
	public string get_NumberDecimalSeparator() { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60026F4")]
	public string get_NumberGroupSeparator() { }

	[Address(RVA = "0x13FA230", Offset = "0x13F9430", Length = "0x77")]
	[CalledBy(Type = "System.Globalization.FormatProvider+Number", Member = "NumberToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Text.ValueStringBuilder&", "NumberBuffer&", typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Globalization.FormatProvider+Number", Member = "FormatNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Text.ValueStringBuilder&", "NumberBuffer&", typeof(int), typeof(int), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Globalization.FormatProvider+Number", Member = "NumberToStringFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Text.ValueStringBuilder&", "NumberBuffer&", "System.ReadOnlySpan`1<Char>", typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60026E5")]
	public Int32[] get_NumberGroupSizes() { }

	[Address(RVA = "0x3D6660", Offset = "0x3D5860", Length = "0x7")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x60026ED")]
	public int get_NumberNegativePattern() { }

	[Address(RVA = "0x13FA2B0", Offset = "0x13F94B0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60026F8")]
	public int get_PercentDecimalDigits() { }

	[Address(RVA = "0x2DD220", Offset = "0x2DC420", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60026F9")]
	public string get_PercentDecimalSeparator() { }

	[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60026FA")]
	public string get_PercentGroupSeparator() { }

	[Address(RVA = "0x13FA2C0", Offset = "0x13F94C0", Length = "0x77")]
	[CalledBy(Type = "System.Globalization.FormatProvider+Number", Member = "FormatPercent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Text.ValueStringBuilder&", "NumberBuffer&", typeof(int), typeof(int), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60026E6")]
	public Int32[] get_PercentGroupSizes() { }

	[Address(RVA = "0xE6C4F0", Offset = "0xE6B6F0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60026EF")]
	public int get_PercentNegativePattern() { }

	[Address(RVA = "0x3D6650", Offset = "0x3D5850", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60026EE")]
	public int get_PercentPositivePattern() { }

	[Address(RVA = "0x2DD200", Offset = "0x2DC400", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60026FB")]
	public string get_PercentSymbol() { }

	[Address(RVA = "0x2DD240", Offset = "0x2DC440", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60026FC")]
	public string get_PerMilleSymbol() { }

	[Address(RVA = "0x3F5890", Offset = "0x3F4A90", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60026F6")]
	public string get_PositiveInfinitySymbol() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x60026F7")]
	public string get_PositiveSign() { }

	[Address(RVA = "0x13F92A0", Offset = "0x13F84A0", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60026FD")]
	public override object GetFormat(Type formatType) { }

	[Address(RVA = "0x13F9320", Offset = "0x13F8520", Length = "0x2A0")]
	[CallerCount(Count = 54)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(Thread), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60026DF")]
	public static NumberFormatInfo GetInstance(IFormatProvider formatProvider) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[OnDeserialized]
	[Token(Token = "0x60026DB")]
	private void OnDeserialized(StreamingContext ctx) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[OnDeserializing]
	[Token(Token = "0x60026DA")]
	private void OnDeserializing(StreamingContext ctx) { }

	[Address(RVA = "0x13F95D0", Offset = "0x13F87D0", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[OnSerializing]
	[Token(Token = "0x60026D9")]
	private void OnSerializing(StreamingContext ctx) { }

	[Address(RVA = "0x13F9660", Offset = "0x13F8860", Length = "0xC4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60026FE")]
	public static NumberFormatInfo ReadOnly(NumberFormatInfo nfi) { }

	[Address(RVA = "0x13FA340", Offset = "0x13F9540", Length = "0xE9")]
	[CalledBy(Type = typeof(CultureData), Member = "GetNFIValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60026EB")]
	public void set_NaNSymbol(string value) { }

	[Address(RVA = "0x13F9730", Offset = "0x13F8930", Length = "0xDD")]
	[CalledBy(Type = typeof(double), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(double))]
	[CalledBy(Type = typeof(double), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Double&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(float), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(float), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Single&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Decimal), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = typeof(Decimal), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Decimal&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002700")]
	internal static void ValidateParseStyleFloatingPoint(NumberStyles style) { }

	[Address(RVA = "0x13F9810", Offset = "0x13F8A10", Length = "0xEB")]
	[CalledBy(Type = typeof(sbyte), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(SByte&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ulong), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(UInt64&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ulong), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(ulong))]
	[CalledBy(Type = typeof(ulong), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles)}, ReturnType = typeof(ulong))]
	[CalledBy(Type = typeof(uint), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(uint), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(ushort), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(UInt16&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ushort), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(ushort))]
	[CalledBy(Type = typeof(sbyte), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(sbyte))]
	[CalledBy(Type = typeof(long), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(long), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Int64&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(short), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Int16&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(short), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(short))]
	[CalledBy(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(byte), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Byte&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(byte), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60026FF")]
	internal static void ValidateParseStyleInteger(NumberStyles style) { }

	[Address(RVA = "0x13F9900", Offset = "0x13F8B00", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60026DD")]
	private void VerifyWritable() { }

}

