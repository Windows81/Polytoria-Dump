namespace System;

[IsReadOnly]
[Token(Token = "0x20000CD")]
public struct DateTimeOffset : IComparable, IFormattable, IComparable<DateTimeOffset>, IEquatable<DateTimeOffset>, ISerializable, IDeserializationCallback, ISpanFormattable
{
	[Token(Token = "0x4000311")]
	public static readonly DateTimeOffset MinValue; //Field offset: 0x0
	[Token(Token = "0x4000312")]
	public static readonly DateTimeOffset MaxValue; //Field offset: 0x10
	[Token(Token = "0x4000313")]
	public static readonly DateTimeOffset UnixEpoch; //Field offset: 0x20
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000314")]
	private readonly DateTime _dateTime; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000315")]
	private readonly short _offsetMinutes; //Field offset: 0x8

	[Token(Token = "0x17000078")]
	private DateTime ClockDateTime
	{
		[Address(RVA = "0x1486E20", Offset = "0x1486020", Length = "0x1C8")]
		[CalledBy(Type = typeof(DateTimeOffset), Member = "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DateTimeOffset), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeOffset), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeOffset), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeOffset), Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DateTimeOffset), Member = "get_Year", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(DateTimeOffset), Member = "get_TimeOfDay", ReturnType = typeof(TimeSpan))]
		[CalledBy(Type = typeof(DateTimeOffset), Member = "get_Ticks", ReturnType = typeof(long))]
		[CalledBy(Type = typeof(DateTimeOffset), Member = "get_Month", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(DateTimeOffset), Member = "get_Minute", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(DateTimeOffset), Member = "get_Millisecond", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(DateTimeOffset), Member = "get_Hour", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(DateTimeOffset), Member = "get_Day", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(DateTimeOffset), Member = "get_DateTime", ReturnType = typeof(DateTime))]
		[CalledBy(Type = typeof(DateTimeOffset), Member = "get_Second", ReturnType = typeof(int))]
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(DateTimeKind)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Token(Token = "0x600064C")]
		private get { } //Length: 456
	}

	[Token(Token = "0x17000075")]
	public DateTime DateTime
	{
		[Address(RVA = "0x1486FF0", Offset = "0x14861F0", Length = "0x49")]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), "System.Xml.Schema.XsdDateTimeFlags"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
		[Token(Token = "0x6000649")]
		 get { } //Length: 73
	}

	[Token(Token = "0x17000079")]
	public int Day
	{
		[Address(RVA = "0x1487040", Offset = "0x1486240", Length = "0xB3")]
		[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(DateTime), Member = "GetDatePart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Token(Token = "0x600064D")]
		 get { } //Length: 179
	}

	[Token(Token = "0x1700007A")]
	public int Hour
	{
		[Address(RVA = "0x1487100", Offset = "0x1486300", Length = "0xE7")]
		[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600064E")]
		 get { } //Length: 231
	}

	[Token(Token = "0x17000077")]
	public DateTime LocalDateTime
	{
		[Address(RVA = "0x14871F0", Offset = "0x14863F0", Length = "0xB0")]
		[CalledBy(Type = typeof(File), Member = "GetCreationTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
		[CalledBy(Type = typeof(File), Member = "GetLastWriteTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
		[CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "DateTimeOffsetToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(DateTime))]
		[CalledBy(Type = "System.Xml.Schema.XmlDateTimeConverter", Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(DateTime))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(DateTime), Member = "ToLocalTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DateTime))]
		[Token(Token = "0x600064B")]
		 get { } //Length: 176
	}

	[Token(Token = "0x1700007B")]
	public int Millisecond
	{
		[Address(RVA = "0x14872A0", Offset = "0x14864A0", Length = "0xE8")]
		[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600064F")]
		 get { } //Length: 232
	}

	[Token(Token = "0x1700007C")]
	public int Minute
	{
		[Address(RVA = "0x1487390", Offset = "0x1486590", Length = "0xE8")]
		[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000650")]
		 get { } //Length: 232
	}

	[Token(Token = "0x1700007D")]
	public int Month
	{
		[Address(RVA = "0x1487480", Offset = "0x1486680", Length = "0xB3")]
		[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(DateTime), Member = "GetDatePart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Token(Token = "0x6000651")]
		 get { } //Length: 179
	}

	[Token(Token = "0x17000074")]
	public static DateTimeOffset Now
	{
		[Address(RVA = "0x1487540", Offset = "0x1486740", Length = "0x5E")]
		[CalledBy(Type = "Polytoria.Datamodel.Player+<CheckOwnsItemFromAPI>d__206", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "Polytoria.Datamodel.Services.HttpService", Member = "RateLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.DynValue"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Polytoria.Controllers.NetworkController+<PlaySolo>d__9", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "Polytoria.Controllers.NetworkController+<StartClient>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "ClearWorkspace", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "DoLoadMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.String[]"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "DoSaveFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000648")]
		 get { } //Length: 94
	}

	[Token(Token = "0x1700007E")]
	public TimeSpan Offset
	{
		[Address(RVA = "0x14875A0", Offset = "0x14867A0", Length = "0x2E")]
		[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), "System.Xml.Schema.XsdDateTimeFlags"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000652")]
		 get { } //Length: 46
	}

	[Token(Token = "0x1700007F")]
	public int Second
	{
		[Address(RVA = "0x14875D0", Offset = "0x14867D0", Length = "0xE8")]
		[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000653")]
		 get { } //Length: 232
	}

	[Token(Token = "0x17000080")]
	public long Ticks
	{
		[Address(RVA = "0x14876C0", Offset = "0x14868C0", Length = "0xAC")]
		[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
		[Token(Token = "0x6000654")]
		 get { } //Length: 172
	}

	[Token(Token = "0x17000081")]
	public TimeSpan TimeOfDay
	{
		[Address(RVA = "0x1487770", Offset = "0x1486970", Length = "0xBE")]
		[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000655")]
		 get { } //Length: 190
	}

	[Token(Token = "0x17000076")]
	public DateTime UtcDateTime
	{
		[Address(RVA = "0x1487830", Offset = "0x1486A30", Length = "0xA2")]
		[CalledBy(Type = typeof(DateTimeOffset), Member = "get_LocalDateTime", ReturnType = typeof(DateTime))]
		[CalledBy(Type = typeof(DateTimeOffset), Member = "System.IComparable.CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(DateTimeOffset), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(DateTimeOffset), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeOffset), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeOffset), Member = "GetHashCode", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(DateTimeOffset), Member = "ToUnixTimeSeconds", ReturnType = typeof(long))]
		[CalledBy(Type = typeof(DateTimeOffset), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), typeof(DateTimeOffset)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FileSystemInfo), Member = "get_LastWriteTime", ReturnType = typeof(DateTime))]
		[CalledBy(Type = typeof(FileSystemInfo), Member = "get_LastWriteTimeUtc", ReturnType = typeof(DateTime))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(DateTimeKind)}, ReturnType = typeof(void))]
		[Token(Token = "0x600064A")]
		 get { } //Length: 162
	}

	[Token(Token = "0x17000082")]
	public int Year
	{
		[Address(RVA = "0x14878E0", Offset = "0x1486AE0", Length = "0xB0")]
		[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(DateTime), Member = "GetDatePart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Token(Token = "0x6000656")]
		 get { } //Length: 176
	}

	[Address(RVA = "0x1486390", Offset = "0x1485590", Length = "0x116")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[Token(Token = "0x600066D")]
	private static DateTimeOffset() { }

	[Address(RVA = "0x14864B0", Offset = "0x14856B0", Length = "0x18B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600065E")]
	private DateTimeOffset(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1486B00", Offset = "0x1485D00", Length = "0xEB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeOffset), Member = "ValidateOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(short))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(Calendar)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeOffset), Member = "ValidateDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[Token(Token = "0x6000647")]
	public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar, TimeSpan offset) { }

	[Address(RVA = "0x1486D40", Offset = "0x1485F40", Length = "0xDE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeOffset), Member = "ValidateOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(short))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeOffset), Member = "ValidateDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[Token(Token = "0x6000646")]
	public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, TimeSpan offset) { }

	[Address(RVA = "0x1486900", Offset = "0x1485B00", Length = "0x102")]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "TryParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(IFormatProvider), typeof(DateTimeStyles), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeOffset), Member = "ValidateOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(short))]
	[Calls(Type = typeof(DateTimeOffset), Member = "ValidateDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000642")]
	public DateTimeOffset(long ticks, TimeSpan offset) { }

	[Address(RVA = "0x1486640", Offset = "0x1485840", Length = "0x2B6")]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDateTime"}, ReturnType = typeof(DateTimeOffset))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetLocalUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(DateTimeOffset), Member = "ValidateOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(short))]
	[Calls(Type = typeof(DateTimeOffset), Member = "ValidateDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000644")]
	public DateTimeOffset(DateTime dateTime, TimeSpan offset) { }

	[Address(RVA = "0x1486BF0", Offset = "0x1485DF0", Length = "0x141")]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "get_Now", ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "FromFileTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = "System.Xml.Schema.XmlDateTimeConverter", Member = "ToDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(DateTimeOffset))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetLocalUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(DateTimeOffset), Member = "ValidateOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(short))]
	[Calls(Type = typeof(DateTimeOffset), Member = "ValidateDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[Token(Token = "0x6000643")]
	public DateTimeOffset(DateTime dateTime) { }

	[Address(RVA = "0x1486A10", Offset = "0x1485C10", Length = "0xE5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeOffset), Member = "ValidateOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(short))]
	[Calls(Type = typeof(DateTime), Member = "DateToTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTime), Member = "TimeToTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTimeOffset), Member = "ValidateDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[Token(Token = "0x6000645")]
	public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, TimeSpan offset) { }

	[Address(RVA = "0x1484BE0", Offset = "0x1483DE0", Length = "0x143")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(DateTime))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000658")]
	public override int CompareTo(DateTimeOffset other) { }

	[Address(RVA = "0x1484D30", Offset = "0x1483F30", Length = "0x19E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(DateTimeKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000659")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1484ED0", Offset = "0x14840D0", Length = "0xCB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(DateTime))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600065A")]
	public override bool Equals(DateTimeOffset other) { }

	[Address(RVA = "0x1484FA0", Offset = "0x14841A0", Length = "0x174")]
	[CalledBy(Type = typeof(FILE_TIME), Member = "ToDateTimeOffset", ReturnType = typeof(DateTimeOffset))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(DateTimeKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "ToLocalTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600065B")]
	public static DateTimeOffset FromFileTime(long fileTime) { }

	[Address(RVA = "0x1486E20", Offset = "0x1486020", Length = "0x1C8")]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "get_Second", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "get_DateTime", ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "get_Day", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "get_Millisecond", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "get_Minute", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "get_Month", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "get_Ticks", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "get_Hour", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "get_Year", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "get_TimeOfDay", ReturnType = typeof(TimeSpan))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(DateTimeKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600064C")]
	private DateTime get_ClockDateTime() { }

	[Address(RVA = "0x1486FF0", Offset = "0x14861F0", Length = "0x49")]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), "System.Xml.Schema.XsdDateTimeFlags"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
	[Token(Token = "0x6000649")]
	public DateTime get_DateTime() { }

	[Address(RVA = "0x1487040", Offset = "0x1486240", Length = "0xB3")]
	[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "GetDatePart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x600064D")]
	public int get_Day() { }

	[Address(RVA = "0x1487100", Offset = "0x1486300", Length = "0xE7")]
	[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600064E")]
	public int get_Hour() { }

	[Address(RVA = "0x14871F0", Offset = "0x14863F0", Length = "0xB0")]
	[CalledBy(Type = typeof(File), Member = "GetCreationTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(File), Member = "GetLastWriteTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "DateTimeOffsetToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Xml.Schema.XmlDateTimeConverter", Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "ToLocalTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DateTime))]
	[Token(Token = "0x600064B")]
	public DateTime get_LocalDateTime() { }

	[Address(RVA = "0x14872A0", Offset = "0x14864A0", Length = "0xE8")]
	[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600064F")]
	public int get_Millisecond() { }

	[Address(RVA = "0x1487390", Offset = "0x1486590", Length = "0xE8")]
	[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000650")]
	public int get_Minute() { }

	[Address(RVA = "0x1487480", Offset = "0x1486680", Length = "0xB3")]
	[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "GetDatePart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000651")]
	public int get_Month() { }

	[Address(RVA = "0x1487540", Offset = "0x1486740", Length = "0x5E")]
	[CalledBy(Type = "Polytoria.Datamodel.Player+<CheckOwnsItemFromAPI>d__206", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.HttpService", Member = "RateLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.DynValue"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.NetworkController+<PlaySolo>d__9", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.NetworkController+<StartClient>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "ClearWorkspace", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "DoLoadMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.String[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "DoSaveFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000648")]
	public static DateTimeOffset get_Now() { }

	[Address(RVA = "0x14875A0", Offset = "0x14867A0", Length = "0x2E")]
	[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), "System.Xml.Schema.XsdDateTimeFlags"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000652")]
	public TimeSpan get_Offset() { }

	[Address(RVA = "0x14875D0", Offset = "0x14867D0", Length = "0xE8")]
	[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000653")]
	public int get_Second() { }

	[Address(RVA = "0x14876C0", Offset = "0x14868C0", Length = "0xAC")]
	[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
	[Token(Token = "0x6000654")]
	public long get_Ticks() { }

	[Address(RVA = "0x1487770", Offset = "0x1486970", Length = "0xBE")]
	[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000655")]
	public TimeSpan get_TimeOfDay() { }

	[Address(RVA = "0x1487830", Offset = "0x1486A30", Length = "0xA2")]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "get_LocalDateTime", ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "System.IComparable.CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "ToUnixTimeSeconds", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), typeof(DateTimeOffset)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FileSystemInfo), Member = "get_LastWriteTime", ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(FileSystemInfo), Member = "get_LastWriteTimeUtc", ReturnType = typeof(DateTime))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(DateTimeKind)}, ReturnType = typeof(void))]
	[Token(Token = "0x600064A")]
	public DateTime get_UtcDateTime() { }

	[Address(RVA = "0x14878E0", Offset = "0x1486AE0", Length = "0xB0")]
	[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "GetDatePart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000656")]
	public int get_Year() { }

	[Address(RVA = "0x1485120", Offset = "0x1484320", Length = "0xB5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(DateTime))]
	[Token(Token = "0x600065F")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1487990", Offset = "0x1486B90", Length = "0xCB")]
	[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Net.Http.Headers.RangeConditionHeaderValue", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.Http.Headers.RetryConditionHeaderValue", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.Http.Headers.WarningHeaderValue", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(DateTime))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600066C")]
	public static bool op_Equality(DateTimeOffset left, DateTimeOffset right) { }

	[Address(RVA = "0x1487A60", Offset = "0x1486C60", Length = "0x20")]
	[CalledBy(Type = "System.Xml.Schema.XmlDateTimeConverter", Member = "ToDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(DateTimeOffset))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[Token(Token = "0x600066B")]
	public static DateTimeOffset op_Implicit(DateTime dateTime) { }

	[Address(RVA = "0x1485490", Offset = "0x1484690", Length = "0x8F")]
	[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeOffset), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles)}, ReturnType = typeof(DateTimeOffset))]
	[Token(Token = "0x6000660")]
	public static DateTimeOffset Parse(string input, IFormatProvider formatProvider) { }

	[Address(RVA = "0x14851E0", Offset = "0x14843E0", Length = "0x2A9")]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(DateTimeOffset))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeParse), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeResult), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(DateTimeParse), Member = "GetDateTimeParseException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeOffset), Member = "ValidateStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeStyles), typeof(string)}, ReturnType = typeof(DateTimeStyles))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(DateTimeFormatInfo))]
	[Token(Token = "0x6000661")]
	public static DateTimeOffset Parse(string input, IFormatProvider formatProvider, DateTimeStyles styles) { }

	[Address(RVA = "0x1485520", Offset = "0x1484720", Length = "0x163")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000657")]
	private override int System.IComparable.CompareTo(object obj) { }

	[Address(RVA = "0x1485690", Offset = "0x1484890", Length = "0x116")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeOffset), Member = "ValidateOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(short))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTimeOffset), Member = "ValidateDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600065C")]
	private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	[Address(RVA = "0x14857B0", Offset = "0x14849B0", Length = "0xBB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTime)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(short)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600065D")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1485950", Offset = "0x1484B50", Length = "0xB8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeFormat), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(string), typeof(IFormatProvider), typeof(TimeSpan)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000663")]
	public virtual string ToString() { }

	[Address(RVA = "0x1485A10", Offset = "0x1484C10", Length = "0xC5")]
	[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeFormat), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(string), typeof(IFormatProvider), typeof(TimeSpan)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000664")]
	public string ToString(IFormatProvider formatProvider) { }

	[Address(RVA = "0x1485870", Offset = "0x1484A70", Length = "0xD3")]
	[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Net.Http.Headers.Parser+DateTime+<>c", Member = "<.cctor>b__2_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Net.Http.Headers.RangeConditionHeaderValue", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Net.Http.Headers.RetryConditionHeaderValue", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Net.Http.Headers.WarningHeaderValue", Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeFormat), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(string), typeof(IFormatProvider), typeof(TimeSpan)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000665")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

	[Address(RVA = "0x1485AE0", Offset = "0x1484CE0", Length = "0xCD")]
	[CalledBy(Type = "Polytoria.Datamodel.Player+<CheckOwnsItemFromAPI>d__206", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.HttpService", Member = "RateLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.DynValue"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.NetworkController+<PlaySolo>d__9", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.NetworkController+<StartClient>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "ClearWorkspace", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "DoLoadMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.String[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "DoSaveFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(DateTime))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000662")]
	public long ToUnixTimeSeconds() { }

	[Address(RVA = "0x1485BB0", Offset = "0x1484DB0", Length = "0x107")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeFormat), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(TimeSpan)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000666")]
	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider formatProvider = null) { }

	[Address(RVA = "0x1485CC0", Offset = "0x1484EC0", Length = "0x2E2")]
	[CalledBy(Type = "System.Net.Http.Headers.Lexer", Member = "TryGetDateValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeOffset), Member = "ValidateStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeStyles), typeof(string)}, ReturnType = typeof(DateTimeStyles))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(DateTimeFormatInfo))]
	[Calls(Type = typeof(DateTimeResult), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeParse), Member = "TryParseExactMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(String[]), typeof(DateTimeFormatInfo), typeof(DateTimeStyles), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000667")]
	public static bool TryParseExact(string input, String[] formats, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result) { }

	[Address(RVA = "0x1485FB0", Offset = "0x14851B0", Length = "0x138")]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(Calendar), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(DateTimeKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000669")]
	private static DateTime ValidateDate(DateTime dateTime, TimeSpan offset) { }

	[Address(RVA = "0x14860F0", Offset = "0x14852F0", Length = "0x179")]
	[CalledBy(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(Calendar), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000668")]
	private static short ValidateOffset(TimeSpan offset) { }

	[Address(RVA = "0x1486270", Offset = "0x1485470", Length = "0x11D")]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "TryParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(IFormatProvider), typeof(DateTimeStyles), typeof(DateTimeOffset&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600066A")]
	private static DateTimeStyles ValidateStyles(DateTimeStyles style, string parameterName) { }

}

