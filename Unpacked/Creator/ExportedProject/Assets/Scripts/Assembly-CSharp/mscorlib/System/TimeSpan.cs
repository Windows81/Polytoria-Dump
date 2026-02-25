namespace System;

[IsReadOnly]
[Token(Token = "0x200013D")]
public struct TimeSpan : IComparable, IComparable<TimeSpan>, IEquatable<TimeSpan>, IFormattable, ISpanFormattable
{
	[Token(Token = "0x4000475")]
	public static readonly TimeSpan Zero; //Field offset: 0x0
	[Token(Token = "0x4000476")]
	public static readonly TimeSpan MaxValue; //Field offset: 0x8
	[Token(Token = "0x4000477")]
	public static readonly TimeSpan MinValue; //Field offset: 0x10
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000478")]
	internal readonly long _ticks; //Field offset: 0x0

	[Token(Token = "0x170000AA")]
	public int Days
	{
		[Address(RVA = "0x14C5320", Offset = "0x14C4520", Length = "0x13")]
		[CalledBy(Type = "Mirror.Utils", Member = "PrettySeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000A10")]
		 get { } //Length: 19
	}

	[Token(Token = "0x170000AB")]
	public int Hours
	{
		[Address(RVA = "0x14C5340", Offset = "0x14C4540", Length = "0x3F")]
		[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomizedTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(bool), typeof(StringBuilder)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomizedRoundripTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Polytoria.Controllers.UIController", Member = "UpdateTimer", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), "System.Xml.Schema.XsdDateTimeFlags"}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), "System.Xml.Schema.XsdDateTimeFlags"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.Utils", Member = "PrettySeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(string))]
		[CallerCount(Count = 11)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000A11")]
		 get { } //Length: 63
	}

	[Token(Token = "0x170000AC")]
	public int Milliseconds
	{
		[Address(RVA = "0x14C5380", Offset = "0x14C4580", Length = "0x47")]
		[CalledBy(Type = "Mirror.Utils", Member = "PrettySeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000A12")]
		 get { } //Length: 71
	}

	[Token(Token = "0x170000AD")]
	public int Minutes
	{
		[Address(RVA = "0x14C53D0", Offset = "0x14C45D0", Length = "0x47")]
		[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomizedTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(bool), typeof(StringBuilder)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomizedRoundripTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Polytoria.Controllers.UIController", Member = "UpdateTimer", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), "System.Xml.Schema.XsdDateTimeFlags"}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), "System.Xml.Schema.XsdDateTimeFlags"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.Utils", Member = "PrettySeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(string))]
		[CallerCount(Count = 10)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000A13")]
		 get { } //Length: 71
	}

	[Token(Token = "0x170000AE")]
	public int Seconds
	{
		[Address(RVA = "0x14C5420", Offset = "0x14C4620", Length = "0x4B")]
		[CalledBy(Type = "Polytoria.Controllers.UIController", Member = "UpdateTimer", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.Utils", Member = "PrettySeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(string))]
		[CallerCount(Count = 4)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000A14")]
		 get { } //Length: 75
	}

	[Token(Token = "0x170000A9")]
	public long Ticks
	{
		[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
		[CallerCount(Count = 140)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A0F")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170000AF")]
	public double TotalDays
	{
		[Address(RVA = "0x14C5470", Offset = "0x14C4670", Length = "0x11")]
		[CalledBy(Type = typeof(UmAlQuraCalendar), Member = "ConvertGregorianToHijri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000A15")]
		 get { } //Length: 17
	}

	[Token(Token = "0x170000B0")]
	public double TotalHours
	{
		[Address(RVA = "0x14C5490", Offset = "0x14C4690", Length = "0x11")]
		[CalledBy(Type = typeof(AdjustmentRule), Member = "ValidateAdjustmentRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(TimeSpan), typeof(TransitionTime), typeof(TransitionTime), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000A16")]
		 get { } //Length: 17
	}

	[Token(Token = "0x170000B1")]
	public double TotalMilliseconds
	{
		[Address(RVA = "0x14C54B0", Offset = "0x14C46B0", Length = "0x30")]
		[CalledBy(Type = typeof(CancellationTokenSource), Member = "CancelAfter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ThreadPool), Member = "RegisterWaitForSingleObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitHandle), typeof(WaitOrTimerCallback), typeof(object), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(RegisteredWaitHandle))]
		[CalledBy(Type = typeof(WaitHandle), Member = "WaitAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitHandle[]), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(RegisteredWaitHandle), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Timer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimerCallback), typeof(object), typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Timer), Member = "Change", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Text.RegularExpressions.RegexRunner", Member = "Scan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Text.RegularExpressions.Regex", typeof(string), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(TimeSpan)}, ReturnType = "System.Text.RegularExpressions.Match")]
		[CalledBy(Type = "System.Diagnostics.Stopwatch", Member = "get_ElapsedMilliseconds", ReturnType = typeof(long))]
		[CalledBy(Type = "System.Net.FtpWebRequest", Member = "GetResponse", ReturnType = "System.Net.WebResponse")]
		[CalledBy(Type = "System.Net.FtpWebRequest", Member = "SubmitRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Networking.PlayerConnection.PlayerConnection", Member = "BlockUntilRecvMsg", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid), typeof(int)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler", Member = "CreateWebRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Http.HttpRequestMessage"}, ReturnType = "System.Net.HttpWebRequest")]
		[CallerCount(Count = 16)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000A17")]
		 get { } //Length: 48
	}

	[Token(Token = "0x170000B2")]
	public double TotalMinutes
	{
		[Address(RVA = "0x14C54E0", Offset = "0x14C46E0", Length = "0x11")]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), "System.Xml.Schema.XsdDateTimeFlags"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000A18")]
		 get { } //Length: 17
	}

	[Token(Token = "0x170000B3")]
	public double TotalSeconds
	{
		[Address(RVA = "0x14C5500", Offset = "0x14C4700", Length = "0x11")]
		[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.OsTimeModule", Member = "GetUnixTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), "System.Nullable`1<DateTime>"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
		[CalledBy(Type = "Mirror.Transports.Encryption.ThreadedEncryptionKcpTransport", Member = "ThreadedServerLateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.Transports.Encryption.ThreadedEncryptionKcpTransport", Member = "ThreadedClientLateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.ThreadedTransport", Member = "ThreadTick", ReturnType = typeof(bool))]
		[CalledBy(Type = "Mirror.TimeSample", Member = "End", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.TimeSample", Member = "Begin", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.WorkerThread", Member = "StopBlocking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Net.Http.Headers.RetryConditionHeaderValue", Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = "System.IO.DefaultWatcher", Member = "UpdateDataAndDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IO.DefaultWatcherData", typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "System.IO.DefaultWatcher", Member = "StartDispatching", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CalledBy(Type = "System.ComponentModel.DateTimeConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CalledBy(Type = "Mono.Btls.MonoBtlsX509VerifyParam", Member = "SetTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.NetworkController+<StartClient>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "Polytoria.Datamodel.Services.ScriptService", Member = "Tick", ReturnType = typeof(float))]
		[CalledBy(Type = "System.Net.Http.Headers.RetryConditionHeaderValue", Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Net.Http.Headers.RetryConditionHeaderValue&"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Net.Http.Headers.CacheControlHeaderValue", Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = "System.Net.Http.Headers.RetryConditionHeaderValue", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(void))]
		[CallerCount(Count = 23)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000A19")]
		 get { } //Length: 17
	}

	[Address(RVA = "0x14C50F0", Offset = "0x14C42F0", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000A37")]
	private static TimeSpan() { }

	[Address(RVA = "0x14C5170", Offset = "0x14C4370", Length = "0xB6")]
	[CalledBy(Type = typeof(Timeout), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadPool), Member = "RegisterWaitForSingleObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitHandle), typeof(WaitOrTimerCallback), typeof(object), typeof(uint), typeof(bool), typeof(StackCrawlMark&), typeof(bool)}, ReturnType = typeof(RegisteredWaitHandle))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000A0E")]
	public TimeSpan(int days, int hours, int minutes, int seconds, int milliseconds) { }

	[Address(RVA = "0xC498F0", Offset = "0xC48AF0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A0C")]
	public TimeSpan(long ticks) { }

	[Address(RVA = "0x14C5230", Offset = "0x14C4430", Length = "0xE4")]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDateTime"}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDateTime"}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseTimeZoneOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(int), typeof(TimeSpan&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(TimeSpan&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "get_Offset", ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = "get_ClockDateTime", ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryCreateTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DYNAMIC_TIME_ZONE_INFORMATION)}, ReturnType = typeof(TimeZoneInfo))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "CreateAdjustmentRuleFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DYNAMIC_TIME_ZONE_INFORMATION&), typeof(DateTime), typeof(DateTime), typeof(int)}, ReturnType = typeof(AdjustmentRule))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZoneFromLocalRegistry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeZoneInfo&), typeof(Exception&)}, ReturnType = "System.TimeZoneInfo+TimeZoneInfoResult")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "CreateAdjustmentRuleFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(REG_TZI_FORMAT&), typeof(DateTime), typeof(DateTime), typeof(int)}, ReturnType = typeof(AdjustmentRule))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000A0D")]
	public TimeSpan(int hours, int minutes, int seconds) { }

	[Address(RVA = "0x14C47E0", Offset = "0x14C39E0", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A1A")]
	public TimeSpan Add(TimeSpan ts) { }

	[Address(RVA = "0x14C4970", Offset = "0x14C3B70", Length = "0x16")]
	[CalledBy(Type = "System.Xml.Schema.DurationFacetsChecker", Member = "CheckValueFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), "System.Xml.Schema.XmlSchemaDatatype"}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Xml.Schema.DurationFacetsChecker", Member = "MatchEnumeration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(ArrayList)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A1B")]
	public static int Compare(TimeSpan t1, TimeSpan t2) { }

	[Address(RVA = "0x14C4860", Offset = "0x14C3A60", Length = "0x16")]
	[CalledBy(Type = "System.TimeZoneInfo+<>c", Member = "<GetSystemTimeZonesWinRTFallback>b__49_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeZoneInfo), typeof(TimeZoneInfo)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.TimeZoneInfo+<>c", Member = "<GetSystemTimeZones>b__110_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeZoneInfo), typeof(TimeZoneInfo)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A1D")]
	public override int CompareTo(TimeSpan value) { }

	[Address(RVA = "0x14C4880", Offset = "0x14C3A80", Length = "0xE4")]
	[CalledBy(Type = "System.Xml.Schema.Datatype_duration", Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A1C")]
	public override int CompareTo(object value) { }

	[Address(RVA = "0x14A0AF0", Offset = "0x149FCF0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A20")]
	public override bool Equals(TimeSpan obj) { }

	[Address(RVA = "0x14C4990", Offset = "0x14C3B90", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A1F")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x14C4A20", Offset = "0x14C3C20", Length = "0x56")]
	[CalledBy(Type = typeof(ConfigHandler), Member = "ParseTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = "System.Net.ServicePointScheduler+<RunScheduler>d__32", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebConnection", Member = "StartOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.WebOperation", typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpan), Member = "Interval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int)}, ReturnType = typeof(TimeSpan))]
	[Token(Token = "0x6000A1E")]
	public static TimeSpan FromDays(double value) { }

	[Address(RVA = "0x14C4A80", Offset = "0x14C3C80", Length = "0x56")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConfigHandler), Member = "ParseTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TimeSpan))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpan), Member = "Interval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int)}, ReturnType = typeof(TimeSpan))]
	[Token(Token = "0x6000A22")]
	public static TimeSpan FromHours(double value) { }

	[Address(RVA = "0x14C4AE0", Offset = "0x14C3CE0", Length = "0x56")]
	[CalledBy(Type = typeof(ConfigHandler), Member = "ParseTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = "System.Text.RegularExpressions.Regex", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Text.RegularExpressions.RegexRunner", Member = "CheckTimeout", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Text.RegularExpressions.RegexRunner", Member = "DoCheckTimeout", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.ServicePoint", Member = "get_HasTimedOut", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.ServicePoint", Member = "get_HostEntry", ReturnType = "System.Net.IPHostEntry")]
	[CalledBy(Type = "System.Net.Http.HttpClientHandler", Member = "CreateDefaultHandler", ReturnType = "System.Net.Http.IMonoHttpClientHandler")]
	[CalledBy(Type = "System.Net.Http.HttpClientHandler", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler+<SendAsync>d__99", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpan), Member = "Interval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int)}, ReturnType = typeof(TimeSpan))]
	[Token(Token = "0x6000A24")]
	public static TimeSpan FromMilliseconds(double value) { }

	[Address(RVA = "0x14C4B40", Offset = "0x14C3D40", Length = "0x56")]
	[CalledBy(Type = typeof(ConfigHandler), Member = "ParseTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(LifetimeServices), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpan), Member = "Interval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int)}, ReturnType = typeof(TimeSpan))]
	[Token(Token = "0x6000A25")]
	public static TimeSpan FromMinutes(double value) { }

	[Address(RVA = "0x14C4BA0", Offset = "0x14C3DA0", Length = "0x56")]
	[CalledBy(Type = typeof(ConfigHandler), Member = "ParseTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(LifetimeServices), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.OsTimeModule", Member = "FromUnixTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.OsTimeModule", Member = "date", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.ScriptExecutionContext", "MoonSharp.Interpreter.CallbackArguments"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
	[CalledBy(Type = "Mirror.Utils", Member = "PrettySeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Net.Http.HttpClient", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Http.Headers.Lexer", Member = "TryGetTimeSpanValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Http.Headers.Token"}, ReturnType = "System.Nullable`1<TimeSpan>")]
	[CalledBy(Type = "System.Net.Http.Headers.Parser+TimeSpanSeconds", Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000A27")]
	public static TimeSpan FromSeconds(double value) { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A28")]
	public static TimeSpan FromTicks(long value) { }

	[Address(RVA = "0x14C5320", Offset = "0x14C4520", Length = "0x13")]
	[CalledBy(Type = "Mirror.Utils", Member = "PrettySeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A10")]
	public int get_Days() { }

	[Address(RVA = "0x14C5340", Offset = "0x14C4540", Length = "0x3F")]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomizedTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(bool), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomizedRoundripTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.UIController", Member = "UpdateTimer", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), "System.Xml.Schema.XsdDateTimeFlags"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), "System.Xml.Schema.XsdDateTimeFlags"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Utils", Member = "PrettySeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(string))]
	[CallerCount(Count = 11)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A11")]
	public int get_Hours() { }

	[Address(RVA = "0x14C5380", Offset = "0x14C4580", Length = "0x47")]
	[CalledBy(Type = "Mirror.Utils", Member = "PrettySeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A12")]
	public int get_Milliseconds() { }

	[Address(RVA = "0x14C53D0", Offset = "0x14C45D0", Length = "0x47")]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomizedTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(bool), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomizedRoundripTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.UIController", Member = "UpdateTimer", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), "System.Xml.Schema.XsdDateTimeFlags"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), "System.Xml.Schema.XsdDateTimeFlags"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Utils", Member = "PrettySeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(string))]
	[CallerCount(Count = 10)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A13")]
	public int get_Minutes() { }

	[Address(RVA = "0x14C5420", Offset = "0x14C4620", Length = "0x4B")]
	[CalledBy(Type = "Polytoria.Controllers.UIController", Member = "UpdateTimer", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Utils", Member = "PrettySeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A14")]
	public int get_Seconds() { }

	[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
	[CallerCount(Count = 140)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A0F")]
	public long get_Ticks() { }

	[Address(RVA = "0x14C5470", Offset = "0x14C4670", Length = "0x11")]
	[CalledBy(Type = typeof(UmAlQuraCalendar), Member = "ConvertGregorianToHijri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A15")]
	public double get_TotalDays() { }

	[Address(RVA = "0x14C5490", Offset = "0x14C4690", Length = "0x11")]
	[CalledBy(Type = typeof(AdjustmentRule), Member = "ValidateAdjustmentRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(TimeSpan), typeof(TransitionTime), typeof(TransitionTime), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A16")]
	public double get_TotalHours() { }

	[Address(RVA = "0x14C54B0", Offset = "0x14C46B0", Length = "0x30")]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "CancelAfter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadPool), Member = "RegisterWaitForSingleObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitHandle), typeof(WaitOrTimerCallback), typeof(object), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(RegisteredWaitHandle))]
	[CalledBy(Type = typeof(WaitHandle), Member = "WaitAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitHandle[]), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RegisteredWaitHandle), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Timer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimerCallback), typeof(object), typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Timer), Member = "Change", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Text.RegularExpressions.RegexRunner", Member = "Scan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Text.RegularExpressions.Regex", typeof(string), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(TimeSpan)}, ReturnType = "System.Text.RegularExpressions.Match")]
	[CalledBy(Type = "System.Diagnostics.Stopwatch", Member = "get_ElapsedMilliseconds", ReturnType = typeof(long))]
	[CalledBy(Type = "System.Net.FtpWebRequest", Member = "GetResponse", ReturnType = "System.Net.WebResponse")]
	[CalledBy(Type = "System.Net.FtpWebRequest", Member = "SubmitRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Networking.PlayerConnection.PlayerConnection", Member = "BlockUntilRecvMsg", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler", Member = "CreateWebRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Http.HttpRequestMessage"}, ReturnType = "System.Net.HttpWebRequest")]
	[CallerCount(Count = 16)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A17")]
	public double get_TotalMilliseconds() { }

	[Address(RVA = "0x14C54E0", Offset = "0x14C46E0", Length = "0x11")]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), "System.Xml.Schema.XsdDateTimeFlags"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A18")]
	public double get_TotalMinutes() { }

	[Address(RVA = "0x14C5500", Offset = "0x14C4700", Length = "0x11")]
	[CalledBy(Type = "System.Net.Http.Headers.RetryConditionHeaderValue", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Http.Headers.CacheControlHeaderValue", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Net.Http.Headers.RetryConditionHeaderValue", Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Net.Http.Headers.RetryConditionHeaderValue&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.ScriptService", Member = "Tick", ReturnType = typeof(float))]
	[CalledBy(Type = "Polytoria.Controllers.NetworkController+<StartClient>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsX509VerifyParam", Member = "SetTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.ComponentModel.DateTimeConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.IO.DefaultWatcher", Member = "StartDispatching", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Http.Headers.RetryConditionHeaderValue", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "Mirror.WorkerThread", Member = "StopBlocking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mirror.TimeSample", Member = "Begin", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.TimeSample", Member = "End", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.ThreadedTransport", Member = "ThreadTick", ReturnType = typeof(bool))]
	[CalledBy(Type = "Mirror.Transports.Encryption.ThreadedEncryptionKcpTransport", Member = "ThreadedClientLateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Transports.Encryption.ThreadedEncryptionKcpTransport", Member = "ThreadedServerLateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.OsTimeModule", Member = "GetUnixTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), "System.Nullable`1<DateTime>"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
	[CalledBy(Type = "System.IO.DefaultWatcher", Member = "UpdateDataAndDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IO.DefaultWatcherData", typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 23)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A19")]
	public double get_TotalSeconds() { }

	[Address(RVA = "0x14A0B60", Offset = "0x149FD60", Length = "0xA")]
	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A21")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x14C4C00", Offset = "0x14C3E00", Length = "0x10D")]
	[CalledBy(Type = typeof(TimeSpan), Member = "FromDays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeSpan), Member = "FromHours", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeSpan), Member = "FromMilliseconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeSpan), Member = "FromMinutes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(TimeSpan))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A23")]
	private static TimeSpan Interval(double value, int scale) { }

	[Address(RVA = "0x14C4D10", Offset = "0x14C3F10", Length = "0xA8")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertToFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomizedTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(bool), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomizedRoundripTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(TimeSpan&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "ParseTimeZoneOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(int), typeof(TimeSpan&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset), "System.Xml.Schema.XsdDateTimeFlags"}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000A26")]
	public TimeSpan Negate() { }

	[Address(RVA = "0x14C5520", Offset = "0x14C4720", Length = "0xB5")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetDateTimeNowUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions), "System.TimeZoneInfo+CachedData"}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions), "System.TimeZoneInfo+CachedData"}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertToFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetDaylightSavingsStartOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetDaylightSavingsEndOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(AdjustmentRule)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(TimeSpan), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>), typeof(Boolean&), typeof(TimeZoneInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(AdjustmentRule)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "IsValidAdjustmentRuleOffest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(AdjustmentRule)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A30")]
	public static TimeSpan op_Addition(TimeSpan t1, TimeSpan t2) { }

	[Address(RVA = "0x2D8A50", Offset = "0x2D7C50", Length = "0x7")]
	[CallerCount(Count = 1453)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A31")]
	public static bool op_Equality(TimeSpan t1, TimeSpan t2) { }

	[Address(RVA = "0x14C55F0", Offset = "0x14C47F0", Length = "0x7")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsAmbiguousTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "UtcOffsetOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Lease), Member = "UpdateState", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A35")]
	public static bool op_GreaterThan(TimeSpan t1, TimeSpan t2) { }

	[Address(RVA = "0x14C55E0", Offset = "0x14C47E0", Length = "0x7")]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomizedTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(bool), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomizedRoundripTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A36")]
	public static bool op_GreaterThanOrEqual(TimeSpan t1, TimeSpan t2) { }

	[Address(RVA = "0x38DBD0", Offset = "0x38CDD0", Length = "0x7")]
	[CallerCount(Count = 330)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A32")]
	public static bool op_Inequality(TimeSpan t1, TimeSpan t2) { }

	[Address(RVA = "0x14C5610", Offset = "0x14C4810", Length = "0x7")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsInvalidTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "UtcOffsetOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LeaseSink), Member = "RenewLease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Text.RegularExpressions.Regex", Member = "ValidateMatchTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A33")]
	public static bool op_LessThan(TimeSpan t1, TimeSpan t2) { }

	[Address(RVA = "0x14C5600", Offset = "0x14C4800", Length = "0x7")]
	[CalledBy(Type = "System.Text.RegularExpressions.Regex", Member = "ValidateMatchTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A34")]
	public static bool op_LessThanOrEqual(TimeSpan t1, TimeSpan t2) { }

	[Address(RVA = "0x14C5620", Offset = "0x14C4820", Length = "0xA5")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000A2F")]
	public static TimeSpan op_UnaryNegation(TimeSpan t) { }

	[Address(RVA = "0x14C4E50", Offset = "0x14C4050", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(TimeSpanParse), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000A2A")]
	public static TimeSpan Parse(string s) { }

	[Address(RVA = "0x14C4DC0", Offset = "0x14C3FC0", Length = "0x81")]
	[CalledBy(Type = "System.ComponentModel.TimeSpanConverter", Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(TimeSpanParse), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000A2B")]
	public static TimeSpan Parse(string input, IFormatProvider formatProvider) { }

	[Address(RVA = "0x14C4ED0", Offset = "0x14C40D0", Length = "0x97")]
	[CalledBy(Type = typeof(DateTime), Member = "TimeToTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(Calendar), Member = "TimeToTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(GregorianCalendarHelper), Member = "TimeToTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(GregorianCalendarHelper), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000A29")]
	internal static long TimeToTicks(int hour, int minute, int second) { }

	[Address(RVA = "0x14C4F70", Offset = "0x14C4170", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpanFormat), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000A2C")]
	public virtual string ToString() { }

	[Address(RVA = "0x14C4FD0", Offset = "0x14C41D0", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpanFormat), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000A2D")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

	[Address(RVA = "0x14C5040", Offset = "0x14C4240", Length = "0xA5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpanFormat), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000A2E")]
	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider formatProvider = null) { }

}

