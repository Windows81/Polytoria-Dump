namespace System;

[Token(Token = "0x2000094")]
[TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
public sealed class TimeZoneInfo : IEquatable<TimeZoneInfo>, ISerializable, IDeserializationCallback
{
	[CompilerGenerated]
	[Token(Token = "0x200009B")]
	private sealed class <>c
	{
		[Token(Token = "0x400029F")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40002A0")]
		public static Comparison<TimeZoneInfo> <>9__49_0; //Field offset: 0x8
		[Token(Token = "0x40002A1")]
		public static Comparison<TimeZoneInfo> <>9__110_0; //Field offset: 0x10

		[Address(RVA = "0x1426250", Offset = "0x1425450", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60003B7")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003B8")]
		public <>c() { }

		[Address(RVA = "0x1426180", Offset = "0x1425380", Length = "0xCE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(RegistryKey), Member = "OpenSubKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(RegistryKey))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Token(Token = "0x60003BB")]
		internal bool <.cctor>b__157_0() { }

		[Address(RVA = "0x1425DF0", Offset = "0x1424FF0", Length = "0xBF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TimeSpan), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60003BA")]
		internal int <GetSystemTimeZones>b__110_0(TimeZoneInfo x, TimeZoneInfo y) { }

		[Address(RVA = "0x1425EB0", Offset = "0x14250B0", Length = "0xBF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TimeSpan), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60003B9")]
		internal int <GetSystemTimeZonesWinRTFallback>b__49_0(TimeZoneInfo x, TimeZoneInfo y) { }

	}

	[Token(Token = "0x2000099")]
	internal sealed class AdjustmentRule : IEquatable<AdjustmentRule>, ISerializable, IDeserializationCallback
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000292")]
		private readonly DateTime _dateStart; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000293")]
		private readonly DateTime _dateEnd; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000294")]
		private readonly TimeSpan _daylightDelta; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000295")]
		private readonly TransitionTime _daylightTransitionStart; //Field offset: 0x28
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000296")]
		private readonly TransitionTime _daylightTransitionEnd; //Field offset: 0x40
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000297")]
		private readonly TimeSpan _baseUtcOffsetDelta; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000298")]
		private readonly bool _noDaylightTransitions; //Field offset: 0x60

		[Token(Token = "0x17000048")]
		internal TimeSpan BaseUtcOffsetDelta
		{
			[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000398")]
			internal get { } //Length: 5
		}

		[Token(Token = "0x17000044")]
		public DateTime DateEnd
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000394")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000043")]
		public DateTime DateStart
		{
			[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
			[CallerCount(Count = 50)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000393")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000045")]
		public TimeSpan DaylightDelta
		{
			[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
			[CallerCount(Count = 11)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000395")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000047")]
		public TransitionTime DaylightTransitionEnd
		{
			[Address(RVA = "0x1408D70", Offset = "0x1407F70", Length = "0x15")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x6000397")]
			 get { } //Length: 21
		}

		[Token(Token = "0x17000046")]
		public TransitionTime DaylightTransitionStart
		{
			[Address(RVA = "0xCEBA90", Offset = "0xCEAC90", Length = "0x15")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000396")]
			 get { } //Length: 21
		}

		[Token(Token = "0x1700004A")]
		internal bool HasDaylightSaving
		{
			[Address(RVA = "0x1408D90", Offset = "0x1407F90", Length = "0x1DB")]
			[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(AdjustmentRule)}, ReturnType = typeof(TimeSpan))]
			[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetDateTimeNowUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
			[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions), "System.TimeZoneInfo+CachedData"}, ReturnType = typeof(TimeSpan))]
			[CalledBy(Type = typeof(TimeZoneInfo), Member = "IsDaylightSavingTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions), "System.TimeZoneInfo+CachedData"}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions), "System.TimeZoneInfo+CachedData"}, ReturnType = typeof(DateTime))]
			[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(TimeSpan))]
			[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
			[CalledBy(Type = typeof(TimeZoneInfo), Member = "IsValidAdjustmentRuleOffest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(AdjustmentRule)}, ReturnType = typeof(bool))]
			[CallerCount(Count = 8)]
			[Calls(Type = typeof(DateTime), Member = "AddMilliseconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DateTime))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(TransitionTime), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransitionTime)}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(DateTime), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x600039A")]
			internal get { } //Length: 475
		}

		[Token(Token = "0x17000049")]
		internal bool NoDaylightTransitions
		{
			[Address(RVA = "0x3D01E0", Offset = "0x3CF3E0", Length = "0x5")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000399")]
			internal get { } //Length: 5
		}

		[Address(RVA = "0x1408D40", Offset = "0x1407F40", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
		[Token(Token = "0x60003A5")]
		internal AdjustmentRule() { }

		[Address(RVA = "0x1408C30", Offset = "0x1407E30", Length = "0x108")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AdjustmentRule), Member = "ValidateAdjustmentRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(TimeSpan), typeof(TransitionTime), typeof(TransitionTime), typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600039D")]
		private AdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd, TimeSpan baseUtcOffsetDelta, bool noDaylightTransitions) { }

		[Address(RVA = "0x1408830", Offset = "0x1407A30", Length = "0x3F2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(SerializationInfo), Member = "GetValueNoThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60003A4")]
		private AdjustmentRule(SerializationInfo info, StreamingContext context) { }

		[Address(RVA = "0x1407930", Offset = "0x1406B30", Length = "0x136")]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "CreateAdjustmentRuleFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(REG_TZI_FORMAT&), typeof(DateTime), typeof(DateTime), typeof(int)}, ReturnType = typeof(AdjustmentRule))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "CreateAdjustmentRuleFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DYNAMIC_TIME_ZONE_INFORMATION&), typeof(DateTime), typeof(DateTime), typeof(int)}, ReturnType = typeof(AdjustmentRule))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(AdjustmentRule), Member = "ValidateAdjustmentRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(TimeSpan), typeof(TransitionTime), typeof(TransitionTime), typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600039E")]
		internal static AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd, TimeSpan baseUtcOffsetDelta, bool noDaylightTransitions) { }

		[Address(RVA = "0x1407A70", Offset = "0x1406C70", Length = "0x176")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DateTime), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TransitionTime), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransitionTime)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x600039B")]
		public override bool Equals(AdjustmentRule other) { }

		[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000398")]
		internal TimeSpan get_BaseUtcOffsetDelta() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000394")]
		public DateTime get_DateEnd() { }

		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000393")]
		public DateTime get_DateStart() { }

		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000395")]
		public TimeSpan get_DaylightDelta() { }

		[Address(RVA = "0x1408D70", Offset = "0x1407F70", Length = "0x15")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000397")]
		public TransitionTime get_DaylightTransitionEnd() { }

		[Address(RVA = "0xCEBA90", Offset = "0xCEAC90", Length = "0x15")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000396")]
		public TransitionTime get_DaylightTransitionStart() { }

		[Address(RVA = "0x1408D90", Offset = "0x1407F90", Length = "0x1DB")]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(TimeSpan))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions), "System.TimeZoneInfo+CachedData"}, ReturnType = typeof(DateTime))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "IsValidAdjustmentRuleOffest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(AdjustmentRule)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions), "System.TimeZoneInfo+CachedData"}, ReturnType = typeof(TimeSpan))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetDateTimeNowUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(AdjustmentRule)}, ReturnType = typeof(TimeSpan))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "IsDaylightSavingTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions), "System.TimeZoneInfo+CachedData"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(DateTime), Member = "AddMilliseconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TransitionTime), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransitionTime)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DateTime), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600039A")]
		internal bool get_HasDaylightSaving() { }

		[Address(RVA = "0x3D01E0", Offset = "0x3CF3E0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000399")]
		internal bool get_NoDaylightTransitions() { }

		[Address(RVA = "0x1407BF0", Offset = "0x1406DF0", Length = "0x4A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DateTime), Member = "GetHashCode", ReturnType = typeof(int))]
		[Token(Token = "0x600039C")]
		public virtual int GetHashCode() { }

		[Address(RVA = "0x1407C40", Offset = "0x1406E40", Length = "0x13F")]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(TimeSpan), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>), typeof(Boolean&), typeof(TimeZoneInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsAmbiguousTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsInvalidTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DateTime), Member = "get_Hour", ReturnType = typeof(int))]
		[Calls(Type = typeof(DateTime), Member = "get_Minute", ReturnType = typeof(int))]
		[Calls(Type = typeof(DateTime), Member = "get_Second", ReturnType = typeof(int))]
		[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60003A0")]
		internal bool IsEndDateMarkerForEndOfYear() { }

		[Address(RVA = "0x1407D80", Offset = "0x1406F80", Length = "0x13F")]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(TimeSpan), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>), typeof(Boolean&), typeof(TimeZoneInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsAmbiguousTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsInvalidTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DateTime), Member = "get_Hour", ReturnType = typeof(int))]
		[Calls(Type = typeof(DateTime), Member = "get_Minute", ReturnType = typeof(int))]
		[Calls(Type = typeof(DateTime), Member = "get_Second", ReturnType = typeof(int))]
		[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600039F")]
		internal bool IsStartDateMarkerForBeginningOfYear() { }

		[Address(RVA = "0x1407EC0", Offset = "0x14070C0", Length = "0xD1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AdjustmentRule), Member = "ValidateAdjustmentRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(TimeSpan), typeof(TransitionTime), typeof(TransitionTime), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60003A2")]
		private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

		[Address(RVA = "0x1407FA0", Offset = "0x14071A0", Length = "0x1FD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTime)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60003A3")]
		private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

		[Address(RVA = "0x14081A0", Offset = "0x14073A0", Length = "0x68D")]
		[CalledBy(Type = typeof(AdjustmentRule), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(TimeSpan), typeof(TransitionTime), typeof(TransitionTime), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AdjustmentRule), Member = "CreateAdjustmentRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(TimeSpan), typeof(TransitionTime), typeof(TransitionTime), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(AdjustmentRule))]
		[CalledBy(Type = typeof(AdjustmentRule), Member = "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(TransitionTime), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransitionTime)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(DateTime), Member = "get_TimeOfDay", ReturnType = typeof(TimeSpan))]
		[Calls(Type = typeof(DateTime), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TimeSpan), Member = "get_TotalHours", ReturnType = typeof(double))]
		[Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(DateTime), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60003A1")]
		private static void ValidateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd, bool noDaylightTransitions) { }

	}

	[Token(Token = "0x2000095")]
	private sealed class CachedData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000282")]
		private OffsetAndRule _oneYearLocalFromUtc; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000283")]
		private TimeZoneInfo _localTimeZone; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000284")]
		public Dictionary<String, TimeZoneInfo> _systemTimeZones; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000285")]
		public ReadOnlyCollection<TimeZoneInfo> _readOnlySystemTimeZones; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000286")]
		public bool _allSystemTimeZonesRead; //Field offset: 0x30

		[Token(Token = "0x17000042")]
		public TimeZoneInfo Local
		{
			[Address(RVA = "0x140E140", Offset = "0x140D340", Length = "0x3D")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
			[Calls(Type = typeof(CachedData), Member = "CreateLocal", ReturnType = typeof(TimeZoneInfo))]
			[Token(Token = "0x600038F")]
			 get { } //Length: 61
		}

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000391")]
		public CachedData() { }

		[Address(RVA = "0x140DC40", Offset = "0x140CE40", Length = "0x19F")]
		[CalledBy(Type = typeof(CachedData), Member = "get_Local", ReturnType = typeof(TimeZoneInfo))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetLocalUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(TimeSpan))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(TimeSpan))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "IsDaylightSavingTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertTimeToUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(DateTime))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "get_Local", ReturnType = typeof(TimeZoneInfo))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(TimeZoneInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(string), typeof(string), typeof(string), typeof(AdjustmentRule[]), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(TimeZoneInfo), Member = "GetLocalTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedData)}, ReturnType = typeof(TimeZoneInfo))]
		[Token(Token = "0x600038E")]
		private TimeZoneInfo CreateLocal() { }

		[Address(RVA = "0x140E140", Offset = "0x140D340", Length = "0x3D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CachedData), Member = "CreateLocal", ReturnType = typeof(TimeZoneInfo))]
		[Token(Token = "0x600038F")]
		public TimeZoneInfo get_Local() { }

		[Address(RVA = "0x140DDE0", Offset = "0x140CFE0", Length = "0x89")]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(TimeSpan))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "IsDaylightSavingTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(DateTime))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Token(Token = "0x6000390")]
		public DateTimeKind GetCorrespondingKind(TimeZoneInfo timeZone) { }

		[Address(RVA = "0x140DE70", Offset = "0x140D070", Length = "0xFE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
		[Calls(Type = typeof(Kernel32), Member = "GetTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&)}, ReturnType = typeof(uint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TimeZoneInfo), Member = "CreateCustomTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(string), typeof(string)}, ReturnType = typeof(TimeZoneInfo))]
		[Calls(Type = typeof(TimeZoneInfo), Member = "GetLocalTimeZoneFromWin32Data", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(bool)}, ReturnType = typeof(TimeZoneInfo))]
		[Token(Token = "0x600038C")]
		private static TimeZoneInfo GetCurrentOneYearLocal() { }

		[Address(RVA = "0x140DF70", Offset = "0x140D170", Length = "0x1CB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
		[Calls(Type = typeof(Kernel32), Member = "GetTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&)}, ReturnType = typeof(uint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TimeZoneInfo), Member = "CreateCustomTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(string), typeof(string)}, ReturnType = typeof(TimeZoneInfo))]
		[Calls(Type = typeof(TimeZoneInfo), Member = "GetLocalTimeZoneFromWin32Data", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(bool)}, ReturnType = typeof(TimeZoneInfo))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600038D")]
		public OffsetAndRule GetOneYearLocalFromUtc(int year) { }

	}

	[Token(Token = "0x2000097")]
	public struct DYNAMIC_TIME_ZONE_INFORMATION
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400028A")]
		internal TIME_ZONE_INFORMATION TZI; //Field offset: 0x0
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x400028B")]
		internal string TimeZoneKeyName; //Field offset: 0xB0
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x400028C")]
		internal byte DynamicDaylightTimeDisabled; //Field offset: 0xB8

	}

	[Token(Token = "0x2000096")]
	private sealed class OffsetAndRule
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000287")]
		public readonly int Year; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000288")]
		public readonly TimeSpan Offset; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000289")]
		public readonly AdjustmentRule Rule; //Field offset: 0x20

		[Address(RVA = "0x1418DA0", Offset = "0x1417FA0", Length = "0x51")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000392")]
		public OffsetAndRule(int year, TimeSpan offset, AdjustmentRule rule) { }

	}

	[Token(Token = "0x2000098")]
	private enum TimeZoneInfoResult
	{
		Success = 0,
		TimeZoneNotFoundException = 1,
		InvalidTimeZoneException = 2,
		SecurityException = 3,
	}

	[IsReadOnly]
	[Token(Token = "0x200009A")]
	internal struct TransitionTime : IEquatable<TransitionTime>, ISerializable, IDeserializationCallback
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000299")]
		private readonly DateTime _timeOfDay; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400029A")]
		private readonly byte _month; //Field offset: 0x8
		[FieldOffset(Offset = "0x9")]
		[Token(Token = "0x400029B")]
		private readonly byte _week; //Field offset: 0x9
		[FieldOffset(Offset = "0xA")]
		[Token(Token = "0x400029C")]
		private readonly byte _day; //Field offset: 0xA
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x400029D")]
		private readonly DayOfWeek _dayOfWeek; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400029E")]
		private readonly bool _isFixedDateRule; //Field offset: 0x10

		[Token(Token = "0x1700004E")]
		public int Day
		{
			[Address(RVA = "0x1425DA0", Offset = "0x1424FA0", Length = "0x5")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x60003A9")]
			 get { } //Length: 5
		}

		[Token(Token = "0x1700004F")]
		public DayOfWeek DayOfWeek
		{
			[Address(RVA = "0xAFA3A0", Offset = "0xAF95A0", Length = "0x4")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x60003AA")]
			 get { } //Length: 4
		}

		[Token(Token = "0x17000050")]
		public bool IsFixedDateRule
		{
			[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x60003AB")]
			 get { } //Length: 5
		}

		[Token(Token = "0x1700004C")]
		public int Month
		{
			[Address(RVA = "0xCE3A00", Offset = "0xCE2C00", Length = "0x5")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x60003A7")]
			 get { } //Length: 5
		}

		[Token(Token = "0x1700004B")]
		public DateTime TimeOfDay
		{
			[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
			[CallerCount(Count = 140)]
			[DeduplicatedMethod]
			[Token(Token = "0x60003A6")]
			 get { } //Length: 4
		}

		[Token(Token = "0x1700004D")]
		public int Week
		{
			[Address(RVA = "0x1425DB0", Offset = "0x1424FB0", Length = "0x5")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x60003A8")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x1425A50", Offset = "0x1424C50", Length = "0x349")]
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
		[Token(Token = "0x60003B6")]
		private TransitionTime(SerializationInfo info, StreamingContext context) { }

		[Address(RVA = "0x14259C0", Offset = "0x1424BC0", Length = "0x81")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TransitionTime), Member = "ValidateTransitionTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(int), typeof(int), typeof(DayOfWeek)}, ReturnType = typeof(void))]
		[Token(Token = "0x60003B0")]
		private TransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek, bool isFixedDateRule) { }

		[Address(RVA = "0x1425180", Offset = "0x1424380", Length = "0x7C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TransitionTime), Member = "ValidateTransitionTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(int), typeof(int), typeof(DayOfWeek)}, ReturnType = typeof(void))]
		[Token(Token = "0x60003B1")]
		public static TransitionTime CreateFixedDateRule(DateTime timeOfDay, int month, int day) { }

		[Address(RVA = "0x1425200", Offset = "0x1424400", Length = "0x89")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TransitionTime), Member = "ValidateTransitionTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(int), typeof(int), typeof(DayOfWeek)}, ReturnType = typeof(void))]
		[Token(Token = "0x60003B2")]
		public static TransitionTime CreateFloatingDateRule(DateTime timeOfDay, int month, int week, DayOfWeek dayOfWeek) { }

		[Address(RVA = "0x1425290", Offset = "0x1424490", Length = "0x9B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(TransitionTime), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransitionTime)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x60003AC")]
		public virtual bool Equals(object obj) { }

		[Address(RVA = "0x1425330", Offset = "0x1424530", Length = "0xF6")]
		[CalledBy(Type = typeof(AdjustmentRule), Member = "get_HasDaylightSaving", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(AdjustmentRule), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AdjustmentRule)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(AdjustmentRule), Member = "ValidateAdjustmentRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(TimeSpan), typeof(TransitionTime), typeof(TransitionTime), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TransitionTime), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TransitionTime), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransitionTime), typeof(TransitionTime)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "CreateAdjustmentRuleFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(REG_TZI_FORMAT&), typeof(DateTime), typeof(DateTime), typeof(int)}, ReturnType = typeof(AdjustmentRule))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "CreateAdjustmentRuleFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DYNAMIC_TIME_ZONE_INFORMATION&), typeof(DateTime), typeof(DateTime), typeof(int)}, ReturnType = typeof(AdjustmentRule))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "HasSameRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeZoneInfo)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DateTime), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60003AE")]
		public override bool Equals(TransitionTime other) { }

		[Address(RVA = "0x1425DA0", Offset = "0x1424FA0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003A9")]
		public int get_Day() { }

		[Address(RVA = "0xAFA3A0", Offset = "0xAF95A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003AA")]
		public DayOfWeek get_DayOfWeek() { }

		[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003AB")]
		public bool get_IsFixedDateRule() { }

		[Address(RVA = "0xCE3A00", Offset = "0xCE2C00", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003A7")]
		public int get_Month() { }

		[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
		[CallerCount(Count = 140)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003A6")]
		public DateTime get_TimeOfDay() { }

		[Address(RVA = "0x1425DB0", Offset = "0x1424FB0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003A8")]
		public int get_Week() { }

		[Address(RVA = "0x1425430", Offset = "0x1424630", Length = "0xE")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60003AF")]
		public virtual int GetHashCode() { }

		[Address(RVA = "0x1425DC0", Offset = "0x1424FC0", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TransitionTime), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransitionTime)}, ReturnType = typeof(bool))]
		[Token(Token = "0x60003AD")]
		public static bool op_Inequality(TransitionTime t1, TransitionTime t2) { }

		[Address(RVA = "0x1425440", Offset = "0x1424640", Length = "0x96")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TransitionTime), Member = "ValidateTransitionTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(int), typeof(int), typeof(DayOfWeek)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60003B4")]
		private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

		[Address(RVA = "0x14254E0", Offset = "0x14246E0", Length = "0x16E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DateTime)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(byte)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60003B5")]
		private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

		[Address(RVA = "0x1425650", Offset = "0x1424850", Length = "0x369")]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "TransitionTimeFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DYNAMIC_TIME_ZONE_INFORMATION), typeof(TransitionTime&), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TransitionTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(int), typeof(int), typeof(DayOfWeek), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TransitionTime), Member = "CreateFixedDateRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(int)}, ReturnType = typeof(TransitionTime))]
		[CalledBy(Type = typeof(TransitionTime), Member = "CreateFloatingDateRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(int), typeof(DayOfWeek)}, ReturnType = typeof(TransitionTime))]
		[CalledBy(Type = typeof(TransitionTime), Member = "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "CreateAdjustmentRuleFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(REG_TZI_FORMAT&), typeof(DateTime), typeof(DateTime), typeof(int)}, ReturnType = typeof(AdjustmentRule))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "TransitionTimeFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(REG_TZI_FORMAT&), typeof(TransitionTime&), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "CreateAdjustmentRuleFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DYNAMIC_TIME_ZONE_INFORMATION&), typeof(DateTime), typeof(DateTime), typeof(int)}, ReturnType = typeof(AdjustmentRule))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		[Calls(Type = typeof(DateTime), Member = "GetDatePart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60003B3")]
		private static void ValidateTransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek) { }

	}

	[Token(Token = "0x4000274")]
	private static Lazy<Boolean> lazyHaveRegistry; //Field offset: 0x0
	[Token(Token = "0x400027C")]
	private static readonly TimeZoneInfo s_utcTimeZone; //Field offset: 0x8
	[Token(Token = "0x400027D")]
	private static CachedData s_cachedData; //Field offset: 0x10
	[Token(Token = "0x400027E")]
	private static readonly DateTime s_maxDateOnly; //Field offset: 0x18
	[Token(Token = "0x400027F")]
	private static readonly DateTime s_minDateOnly; //Field offset: 0x20
	[Token(Token = "0x4000280")]
	private static readonly TimeSpan MaxOffset; //Field offset: 0x28
	[Token(Token = "0x4000281")]
	private static readonly TimeSpan MinOffset; //Field offset: 0x30
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000275")]
	private readonly string _id; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000276")]
	private readonly string _displayName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000277")]
	private readonly string _standardDisplayName; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000278")]
	private readonly string _daylightDisplayName; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000279")]
	private readonly TimeSpan _baseUtcOffset; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400027A")]
	private readonly bool _supportsDaylightSavingTime; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400027B")]
	private readonly AdjustmentRule[] _adjustmentRules; //Field offset: 0x40

	[Token(Token = "0x1700003F")]
	public TimeSpan BaseUtcOffset
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000357")]
		 get { } //Length: 95
	}

	[Token(Token = "0x1700003E")]
	public string DisplayName
	{
		[Address(RVA = "0x1420320", Offset = "0x141F520", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000356")]
		 get { } //Length: 27
	}

	[Token(Token = "0x1700003C")]
	private static bool HaveRegistry
	{
		[Address(RVA = "0x1425030", Offset = "0x1424230", Length = "0x6F")]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "PopulateAllSystemTimeZones", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetLocalTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedData)}, ReturnType = typeof(TimeZoneInfo))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZoneFromLocalMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeZoneInfo&), typeof(Exception&)}, ReturnType = typeof(TimeZoneInfoResult))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetSystemTimeZones", ReturnType = typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.TimeZoneInfo>))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZoneFromLocalMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(TimeZoneInfo&), typeof(Exception&), typeof(CachedData)}, ReturnType = typeof(TimeZoneInfoResult))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Lazy`1), Member = "get_Value", ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600034A")]
		private get { } //Length: 111
	}

	[Token(Token = "0x1700003D")]
	public string Id
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000355")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000040")]
	public static TimeZoneInfo Local
	{
		[Address(RVA = "0x14250A0", Offset = "0x14242A0", Length = "0x84")]
		[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.OsTimeModule", Member = "date", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.ScriptExecutionContext", "MoonSharp.Interpreter.CallbackArguments"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetDateTimeNowUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetSystemTimeZonesWinRTFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DateTime), Member = "FromBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTime))]
		[CalledBy(Type = typeof(DateTime), Member = "IsDaylightSavingTime", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTime), Member = "ToLocalTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DateTime))]
		[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DateTimeParse), Member = "AdjustTimeZoneToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), "System.Xml.Schema.XsdDateTimeFlags"}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDateTime"}, ReturnType = typeof(DateTime))]
		[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDateTime"}, ReturnType = typeof(DateTimeOffset))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CachedData), Member = "CreateLocal", ReturnType = typeof(TimeZoneInfo))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000368")]
		 get { } //Length: 132
	}

	[Token(Token = "0x17000041")]
	public static TimeZoneInfo Utc
	{
		[Address(RVA = "0x1425130", Offset = "0x1424330", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x600036A")]
		 get { } //Length: 79
	}

	[Address(RVA = "0x1424390", Offset = "0x1423590", Length = "0x29A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Lazy`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "CreateCustomTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(string), typeof(string)}, ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeSpan), Member = "FromHours", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeSpan), Member = "op_UnaryNegation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(TimeSpan))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600038A")]
	private static TimeZoneInfo() { }

	[Address(RVA = "0x1424AF0", Offset = "0x1423CF0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x600038B")]
	internal TimeZoneInfo() { }

	[Address(RVA = "0x1424C40", Offset = "0x1423E40", Length = "0x3E6")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetLocalTimeZoneFromWin32Data", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(bool)}, ReturnType = typeof(TimeZoneInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(REG_TZI_FORMAT), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "ValidateTimeZoneInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(AdjustmentRule[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "CreateAdjustmentRuleFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(REG_TZI_FORMAT&), typeof(DateTime), typeof(DateTime), typeof(int)}, ReturnType = typeof(AdjustmentRule))]
	[Calls(Type = typeof(DateTime), Member = "get_Date", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TIME_ZONE_INFORMATION), Member = "GetDaylightName", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TIME_ZONE_INFORMATION), Member = "GetStandardName", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000339")]
	private TimeZoneInfo(in TIME_ZONE_INFORMATION zone, bool dstDisabled) { }

	[Address(RVA = "0x1424630", Offset = "0x1423830", Length = "0x4BA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600036F")]
	private TimeZoneInfo(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1424B20", Offset = "0x1423D20", Length = "0x113")]
	[CalledBy(Type = typeof(CachedData), Member = "CreateLocal", ReturnType = typeof(TimeZoneInfo))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZoneFromLocalRegistry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeZoneInfo&), typeof(Exception&)}, ReturnType = typeof(TimeZoneInfoResult))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryCreateTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DYNAMIC_TIME_ZONE_INFORMATION)}, ReturnType = typeof(TimeZoneInfo))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "CreateCustomTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(string), typeof(string)}, ReturnType = typeof(TimeZoneInfo))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(TimeZoneInfo&), typeof(Exception&), typeof(CachedData), typeof(bool)}, ReturnType = typeof(TimeZoneInfoResult))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZoneFromLocalMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(TimeZoneInfo&), typeof(Exception&), typeof(CachedData)}, ReturnType = typeof(TimeZoneInfoResult))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "ValidateTimeZoneInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(AdjustmentRule[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600036B")]
	private TimeZoneInfo(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime) { }

	[Address(RVA = "0x1418E00", Offset = "0x1418000", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SYSTEMTIME), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SYSTEMTIME&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600033A")]
	private static bool CheckDaylightSavingTimeNotSupported(in TIME_ZONE_INFORMATION timeZone) { }

	[Address(RVA = "0x1418E30", Offset = "0x1418030", Length = "0x291")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(TimeSpan), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>), typeof(Boolean&), typeof(TimeZoneInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "AddYears", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_GreaterThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_LessThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600037C")]
	private static bool CheckIsDst(DateTime startTime, DateTime time, DateTime endTime, bool ignoreYearAdjustment, AdjustmentRule rule) { }

	[Address(RVA = "0x14190D0", Offset = "0x14182D0", Length = "0x1DF")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetAdjustmentRuleForTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(bool), typeof(Nullable`1<Int32>&)}, ReturnType = typeof(AdjustmentRule))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
	[Calls(Type = typeof(DateTime), Member = "op_GreaterThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "ConvertToFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_LessThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000372")]
	private int CompareAdjustmentRuleToDateTime(AdjustmentRule rule, AdjustmentRule previousRule, DateTime dateTime, DateTime dateOnly, bool dateTimeisUtc) { }

	[Address(RVA = "0x14192B0", Offset = "0x14184B0", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "ConvertToFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(DateTime))]
	[Token(Token = "0x6000374")]
	private DateTime ConvertFromUtc(DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta) { }

	[Address(RVA = "0x1419510", Offset = "0x1418710", Length = "0x541")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "IsDaylightSavingTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertTimeFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertTimeToUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AdjustmentRule), Member = "get_HasDaylightSaving", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "ConvertUtcToTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(TimeZoneInfo), typeof(Boolean&)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(DateTimeKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(DateTimeKind), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetDaylightTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(DaylightTimeStruct))]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeSpan), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetAdjustmentRuleForTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(bool), typeof(Nullable`1<Int32>&)}, ReturnType = typeof(AdjustmentRule))]
	[Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CachedData), Member = "GetCorrespondingKind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeZoneInfo)}, ReturnType = typeof(DateTimeKind))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetIsInvalidTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000360")]
	private static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone, TimeZoneInfoOptions flags, CachedData cachedData) { }

	[Address(RVA = "0x1419470", Offset = "0x1418670", Length = "0x9A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "ConvertTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(DateTime))]
	[Token(Token = "0x600035F")]
	internal static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone, TimeZoneInfoOptions flags) { }

	[Address(RVA = "0x14192D0", Offset = "0x14184D0", Length = "0x84")]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.OsTimeModule", Member = "date", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.ScriptExecutionContext", "MoonSharp.Interpreter.CallbackArguments"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "ConvertTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(DateTime))]
	[Token(Token = "0x6000361")]
	public static DateTime ConvertTimeFromUtc(DateTime dateTime, TimeZoneInfo destinationTimeZone) { }

	[Address(RVA = "0x1419360", Offset = "0x1418560", Length = "0x10F")]
	[CalledBy(Type = typeof(DateTime), Member = "ToUniversalTime", ReturnType = typeof(DateTime))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CachedData), Member = "CreateLocal", ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "ConvertTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000362")]
	internal static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfoOptions flags) { }

	[Address(RVA = "0x1419A60", Offset = "0x1418C60", Length = "0x1BD")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "CompareAdjustmentRuleToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AdjustmentRule), typeof(AdjustmentRule), typeof(DateTime), typeof(DateTime), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertToUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetDaylightTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(DaylightTimeStruct))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpan), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeSpan), Member = "Negate", ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000375")]
	private DateTime ConvertToFromUtc(DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta, bool convertToUtc) { }

	[Address(RVA = "0x1419C20", Offset = "0x1418E20", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "ConvertToFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(DateTime))]
	[Token(Token = "0x6000373")]
	private DateTime ConvertToUtc(DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta) { }

	[Address(RVA = "0x1419C40", Offset = "0x1418E40", Length = "0x25F")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
	[Token(Token = "0x6000376")]
	private static DateTime ConvertUtcToTimeZone(long ticks, TimeZoneInfo destinationTimeZone, out bool isAmbiguousLocalDst) { }

	[Address(RVA = "0x141A450", Offset = "0x1419650", Length = "0x361")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryCreateAdjustmentRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(REG_TZI_FORMAT&), typeof(AdjustmentRule[]&), typeof(Exception&), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "TransitionTimeFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(REG_TZI_FORMAT&), typeof(TransitionTime&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TransitionTime), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransitionTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AdjustmentRule), Member = "CreateAdjustmentRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(TimeSpan), typeof(TransitionTime), typeof(TransitionTime), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(AdjustmentRule))]
	[Calls(Type = typeof(TransitionTime), Member = "ValidateTransitionTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(int), typeof(int), typeof(DayOfWeek)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "AddMilliseconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DateTime))]
	[Token(Token = "0x600033B")]
	private static AdjustmentRule CreateAdjustmentRuleFromTimeZoneInformation(in REG_TZI_FORMAT timeZoneInformation, DateTime startDate, DateTime endDate, int defaultBaseUtcOffset) { }

	[Address(RVA = "0x1419EA0", Offset = "0x14190A0", Length = "0x5A9")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryCreateTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DYNAMIC_TIME_ZONE_INFORMATION)}, ReturnType = typeof(TimeZoneInfo))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "TransitionTimeFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DYNAMIC_TIME_ZONE_INFORMATION), typeof(TransitionTime&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TransitionTime), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransitionTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AdjustmentRule), Member = "CreateAdjustmentRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(TimeSpan), typeof(TransitionTime), typeof(TransitionTime), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(AdjustmentRule))]
	[Calls(Type = typeof(TransitionTime), Member = "ValidateTransitionTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(int), typeof(int), typeof(DayOfWeek)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "AddMilliseconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DateTime))]
	[Token(Token = "0x600034F")]
	internal static AdjustmentRule CreateAdjustmentRuleFromTimeZoneInformation(ref DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, DateTime startDate, DateTime endDate, int defaultBaseUtcOffset) { }

	[Address(RVA = "0x141A7C0", Offset = "0x14199C0", Length = "0x9A")]
	[CalledBy(Type = typeof(CachedData), Member = "GetCurrentOneYearLocal", ReturnType = typeof(TimeZoneInfo))]
	[CalledBy(Type = typeof(CachedData), Member = "GetOneYearLocalFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(OffsetAndRule))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetLocalTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedData)}, ReturnType = typeof(TimeZoneInfo))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetLocalTimeZoneFromWin32Data", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(bool)}, ReturnType = typeof(TimeZoneInfo))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetDateTimeNowUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(TimeZoneInfo&), typeof(Exception&), typeof(CachedData), typeof(bool)}, ReturnType = typeof(TimeZoneInfoResult))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZoneFromLocalMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(TimeZoneInfo&), typeof(Exception&), typeof(CachedData)}, ReturnType = typeof(TimeZoneInfoResult))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TimeZoneInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(string), typeof(string), typeof(string), typeof(AdjustmentRule[]), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x600036C")]
	public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName) { }

	[Address(RVA = "0x141A860", Offset = "0x1419A60", Length = "0x160")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18018DDF0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600034B")]
	internal static uint EnumDynamicTimeZoneInformation(uint dwIndex, out DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation) { }

	[Address(RVA = "0x141AA20", Offset = "0x1419C20", Length = "0x94")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "HasSameRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeZoneInfo)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000364")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x141A9C0", Offset = "0x1419BC0", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "HasSameRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeZoneInfo)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000363")]
	public override bool Equals(TimeZoneInfo other) { }

	[Address(RVA = "0x141AAC0", Offset = "0x1419CC0", Length = "0x1B3")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetLocalTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedData)}, ReturnType = typeof(TimeZoneInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RegistryKey), Member = "OpenSubKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(RegistryKey))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "TryCompareTimeZoneInformationToRegistry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(string), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600033C")]
	private static string FindIdFromTimeZoneInformation(in TIME_ZONE_INFORMATION timeZone, out bool dstDisabled) { }

	[Address(RVA = "0x141AC80", Offset = "0x1419E80", Length = "0x28E")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZoneFromLocalMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeZoneInfo&), typeof(Exception&)}, ReturnType = typeof(TimeZoneInfoResult))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZoneFromLocalMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(TimeZoneInfo&), typeof(Exception&), typeof(CachedData)}, ReturnType = typeof(TimeZoneInfoResult))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800026B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetSystemTimeZones", ReturnType = typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.TimeZoneInfo>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(TimeZoneNotFoundException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000353")]
	internal static TimeZoneInfo FindSystemTimeZoneByIdWinRTFallback(string id) { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000357")]
	public TimeSpan get_BaseUtcOffset() { }

	[Address(RVA = "0x1420320", Offset = "0x141F520", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000356")]
	public string get_DisplayName() { }

	[Address(RVA = "0x1425030", Offset = "0x1424230", Length = "0x6F")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "PopulateAllSystemTimeZones", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetLocalTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedData)}, ReturnType = typeof(TimeZoneInfo))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZoneFromLocalMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeZoneInfo&), typeof(Exception&)}, ReturnType = typeof(TimeZoneInfoResult))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetSystemTimeZones", ReturnType = typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.TimeZoneInfo>))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZoneFromLocalMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(TimeZoneInfo&), typeof(Exception&), typeof(CachedData)}, ReturnType = typeof(TimeZoneInfoResult))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Lazy`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600034A")]
	private static bool get_HaveRegistry() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000355")]
	public string get_Id() { }

	[Address(RVA = "0x14250A0", Offset = "0x14242A0", Length = "0x84")]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDateTime"}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDateTime"}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "AdjustTimeZoneToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTime), Member = "ToLocalTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), "System.Xml.Schema.XsdDateTimeFlags"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTime), Member = "FromBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetSystemTimeZonesWinRTFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetDateTimeNowUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.OsTimeModule", Member = "date", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.ScriptExecutionContext", "MoonSharp.Interpreter.CallbackArguments"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
	[CalledBy(Type = typeof(DateTime), Member = "IsDaylightSavingTime", ReturnType = typeof(bool))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CachedData), Member = "CreateLocal", ReturnType = typeof(TimeZoneInfo))]
	[Token(Token = "0x6000368")]
	public static TimeZoneInfo get_Local() { }

	[Address(RVA = "0x1425130", Offset = "0x1424330", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600036A")]
	public static TimeZoneInfo get_Utc() { }

	[Address(RVA = "0x141AF10", Offset = "0x141A110", Length = "0x21B")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "IsDaylightSavingTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetAdjustmentRuleForTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(Nullable`1<Int32>&)}, ReturnType = typeof(AdjustmentRule))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(TimeSpan), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>), typeof(Boolean&), typeof(TimeZoneInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(TimeSpan))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "CompareAdjustmentRuleToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AdjustmentRule), typeof(AdjustmentRule), typeof(DateTime), typeof(DateTime), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Date", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DateTime), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[Token(Token = "0x6000371")]
	private AdjustmentRule GetAdjustmentRuleForTime(DateTime dateTime, bool dateTimeisUtc, out Nullable<Int32>& ruleIndex) { }

	[Address(RVA = "0x141B130", Offset = "0x141A330", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetAdjustmentRuleForTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(bool), typeof(Nullable`1<Int32>&)}, ReturnType = typeof(AdjustmentRule))]
	[Token(Token = "0x6000370")]
	private AdjustmentRule GetAdjustmentRuleForTime(DateTime dateTime, out Nullable<Int32>& ruleIndex) { }

	[Address(RVA = "0x141B150", Offset = "0x141A350", Length = "0x398")]
	[CalledBy(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "CreateCustomTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(string), typeof(string)}, ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "get_Local", ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(AdjustmentRule), Member = "get_HasDaylightSaving", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpan), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetLocalTimeZoneFromWin32Data", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(bool)}, ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(Kernel32), Member = "GetTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(TimeSpan), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>), typeof(Boolean&), typeof(TimeZoneInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600033F")]
	internal static TimeSpan GetDateTimeNowUtcOffsetFromUtc(DateTime time, out bool isAmbiguousLocalDst) { }

	[Address(RVA = "0x141B4F0", Offset = "0x141A6F0", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpan), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600037A")]
	private TimeSpan GetDaylightSavingsEndOffsetFromUtc(TimeSpan baseUtcOffset, AdjustmentRule rule) { }

	[Address(RVA = "0x141B580", Offset = "0x141A780", Length = "0xD7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpan), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetPreviousAdjustmentRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(AdjustmentRule))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000379")]
	private TimeSpan GetDaylightSavingsStartOffsetFromUtc(TimeSpan baseUtcOffset, AdjustmentRule rule, Nullable<Int32> ruleIndex) { }

	[Address(RVA = "0x141B660", Offset = "0x141A860", Length = "0x17E")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "IsDaylightSavingTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(TimeSpan), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>), typeof(Boolean&), typeof(TimeZoneInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(TimeSpan))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "TransitionTimeToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransitionTime)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetPreviousAdjustmentRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(AdjustmentRule))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "ConvertToFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000377")]
	private DaylightTimeStruct GetDaylightTime(int year, AdjustmentRule rule, Nullable<Int32> ruleIndex) { }

	[Address(RVA = "0x141B960", Offset = "0x141AB60", Length = "0x153")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18018DDF0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600034C")]
	internal static uint GetDynamicTimeZoneInformation(out DYNAMIC_TIME_ZONE_INFORMATION pTimeZoneInformation) { }

	[Address(RVA = "0x141B7E0", Offset = "0x141A9E0", Length = "0x17F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18018DD30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18018DDF0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600034D")]
	internal static uint GetDynamicTimeZoneInformationEffectiveYears(ref DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation, out uint FirstYear, out uint LastYear) { }

	[Address(RVA = "0x141BAC0", Offset = "0x141ACC0", Length = "0xA4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000365")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x141BB70", Offset = "0x141AD70", Length = "0x367")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpan), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AdjustmentRule), Member = "IsStartDateMarkerForBeginningOfYear", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(AdjustmentRule), Member = "IsEndDateMarkerForEndOfYear", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_GreaterThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "AddYears", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DateTime))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600037D")]
	private static bool GetIsAmbiguousTime(DateTime time, AdjustmentRule rule, DaylightTimeStruct daylightTime) { }

	[Address(RVA = "0x141C7A0", Offset = "0x141B9A0", Length = "0x48C")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "IsDaylightSavingTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(TimeSpan))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TimeSpan), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "CheckIsDst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(DateTime), typeof(bool), typeof(AdjustmentRule)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "AddTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(TimeSpan), Member = "op_UnaryNegation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(AdjustmentRule), Member = "IsEndDateMarkerForEndOfYear", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "IsAmbiguousDaylightSavingTime", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AdjustmentRule), Member = "IsStartDateMarkerForBeginningOfYear", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetIsAmbiguousTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Token(Token = "0x6000378")]
	private static bool GetIsDaylightSavings(DateTime time, AdjustmentRule rule, DaylightTimeStruct daylightTime, TimeZoneInfoOptions flags) { }

	[Address(RVA = "0x141BEE0", Offset = "0x141B0E0", Length = "0x8B7")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetDateTimeNowUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_GreaterThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "CheckIsDst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime), typeof(DateTime), typeof(bool), typeof(AdjustmentRule)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "AddTicks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(AdjustmentRule), Member = "IsEndDateMarkerForEndOfYear", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetAdjustmentRuleForTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(bool), typeof(Nullable`1<Int32>&)}, ReturnType = typeof(AdjustmentRule))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DateTime), Member = "AddYears", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(AdjustmentRule), Member = "IsStartDateMarkerForBeginningOfYear", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpan), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetPreviousAdjustmentRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(AdjustmentRule))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetDaylightTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(DaylightTimeStruct))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x600037B")]
	private static bool GetIsDaylightSavingsFromUtc(DateTime time, int year, TimeSpan utc, AdjustmentRule rule, Nullable<Int32> ruleIndex, out bool isAmbiguousLocalDst, TimeZoneInfo zone) { }

	[Address(RVA = "0x141CC30", Offset = "0x141BE30", Length = "0x36F")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpan), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AdjustmentRule), Member = "IsStartDateMarkerForBeginningOfYear", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(AdjustmentRule), Member = "IsEndDateMarkerForEndOfYear", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_GreaterThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "AddYears", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DateTime))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600037E")]
	private static bool GetIsInvalidTime(DateTime time, AdjustmentRule rule, DaylightTimeStruct daylightTime) { }

	[Address(RVA = "0x141D860", Offset = "0x141CA60", Length = "0x3BE")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZoneFromLocalRegistry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeZoneInfo&), typeof(Exception&)}, ReturnType = typeof(TimeZoneInfoResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RegistryKey), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(RegistryValueOptions)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "TryGetLocalizedNameByMuiNativeResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000347")]
	private static void GetLocalizedNamesByRegistryKey(RegistryKey key, out string displayName, out string standardName, out string daylightName) { }

	[Address(RVA = "0x141D470", Offset = "0x141C670", Length = "0x32A")]
	[CalledBy(Type = typeof(CachedData), Member = "CreateLocal", ReturnType = typeof(TimeZoneInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "CreateCustomTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(string), typeof(string)}, ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetLocalTimeZoneFromWin32Data", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(bool)}, ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "FindIdFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(Boolean&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TIME_ZONE_INFORMATION), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_DYNAMIC_ZONE_INFORMATION&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(TimeZoneInfo&), typeof(Exception&), typeof(CachedData), typeof(bool)}, ReturnType = typeof(TimeZoneInfoResult))]
	[Calls(Type = typeof(TIME_DYNAMIC_ZONE_INFORMATION), Member = "GetTimeZoneKeyName", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetLocalTimeZoneInfoWinRTFallback", ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "get_HaveRegistry", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Kernel32), Member = "GetDynamicTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_DYNAMIC_ZONE_INFORMATION&)}, ReturnType = typeof(uint))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600033D")]
	private static TimeZoneInfo GetLocalTimeZone(CachedData cachedData) { }

	[Address(RVA = "0x141CFA0", Offset = "0x141C1A0", Length = "0x11F")]
	[CalledBy(Type = typeof(CachedData), Member = "GetCurrentOneYearLocal", ReturnType = typeof(TimeZoneInfo))]
	[CalledBy(Type = typeof(CachedData), Member = "GetOneYearLocalFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(OffsetAndRule))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetLocalTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedData)}, ReturnType = typeof(TimeZoneInfo))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetDateTimeNowUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TimeZoneInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "CreateCustomTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(string), typeof(string)}, ReturnType = typeof(TimeZoneInfo))]
	[Token(Token = "0x600033E")]
	private static TimeZoneInfo GetLocalTimeZoneFromWin32Data(in TIME_ZONE_INFORMATION timeZoneInformation, bool dstDisabled) { }

	[Address(RVA = "0x141D0C0", Offset = "0x141C2C0", Length = "0x3A1")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetLocalTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedData)}, ReturnType = typeof(TimeZoneInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18018DDF0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "TryCreateTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DYNAMIC_TIME_ZONE_INFORMATION)}, ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1814078E0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000352")]
	internal static TimeZoneInfo GetLocalTimeZoneInfoWinRTFallback() { }

	[Address(RVA = "0x141D7A0", Offset = "0x141C9A0", Length = "0xB8")]
	[CalledBy(Type = typeof(DateTime), Member = "FromBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomizedTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(bool), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomizedRoundripTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "DetermineTimeZoneAdjustments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "DateTimeOffsetTimeZonePostProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(DateTimeResult&), typeof(DateTimeStyles)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CachedData), Member = "CreateLocal", ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600035A")]
	internal static TimeSpan GetLocalUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags) { }

	[Address(RVA = "0x141DC20", Offset = "0x141CE20", Length = "0x10A")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetDaylightTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(DaylightTimeStruct))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetDaylightSavingsStartOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(TimeSpan), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>), typeof(Boolean&), typeof(TimeZoneInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000358")]
	private AdjustmentRule GetPreviousAdjustmentRule(AdjustmentRule rule, Nullable<Int32> ruleIndex) { }

	[Address(RVA = "0x141E4B0", Offset = "0x141D6B0", Length = "0x364")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "FindSystemTimeZoneByIdWinRTFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TimeZoneInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "PopulateAllSystemTimeZonesFromRegistry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Comparison`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetSystemTimeZonesWinRTFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "get_HaveRegistry", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000366")]
	public static ReadOnlyCollection<TimeZoneInfo> GetSystemTimeZones() { }

	[Address(RVA = "0x141DD30", Offset = "0x141CF30", Length = "0x77F")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "PopulateAllSystemTimeZones", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetSystemTimeZones", ReturnType = typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.TimeZoneInfo>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1810AA5E0")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Comparison`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "TryCreateTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DYNAMIC_TIME_ZONE_INFORMATION)}, ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18018DDF0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "get_Local", ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000354")]
	private static void GetSystemTimeZonesWinRTFallback(CachedData cachedData) { }

	[Address(RVA = "0x141E820", Offset = "0x141DA20", Length = "0x182")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryCreateTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DYNAMIC_TIME_ZONE_INFORMATION)}, ReturnType = typeof(TimeZoneInfo))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18018DD30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18018DDF0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600034E")]
	internal static bool GetTimeZoneInformationForYear(ushort wYear, ref DYNAMIC_TIME_ZONE_INFORMATION pdtzi, out TIME_ZONE_INFORMATION ptzi) { }

	[Address(RVA = "0x141EF70", Offset = "0x141E170", Length = "0x3D4")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetLocalUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(TimeSpan))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(CachedData), Member = "CreateLocal", ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetDaylightTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(DaylightTimeStruct))]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(AdjustmentRule), Member = "get_HasDaylightSaving", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetAdjustmentRuleForTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(bool), typeof(Nullable`1<Int32>&)}, ReturnType = typeof(AdjustmentRule))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "ConvertTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(CachedData), Member = "GetCorrespondingKind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeZoneInfo)}, ReturnType = typeof(DateTimeKind))]
	[Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TimeSpan), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(TimeSpan))]
	[Token(Token = "0x600035C")]
	private TimeSpan GetUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags, CachedData cachedData) { }

	[Address(RVA = "0x141EE10", Offset = "0x141E010", Length = "0x86")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "AdjustTimeZoneToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(TimeSpan))]
	[Token(Token = "0x600035B")]
	internal TimeSpan GetUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags) { }

	[Address(RVA = "0x141F560", Offset = "0x141E760", Length = "0x7C")]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "TryFormatO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), "System.Xml.Schema.XsdDateTimeFlags"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDateTime"}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XsdDateTime"}, ReturnType = typeof(DateTimeOffset))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(TimeSpan))]
	[Token(Token = "0x6000359")]
	public TimeSpan GetUtcOffset(DateTime dateTime) { }

	[Address(RVA = "0x141F350", Offset = "0x141E550", Length = "0x203")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetAdjustmentRuleForTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(bool), typeof(Nullable`1<Int32>&)}, ReturnType = typeof(AdjustmentRule))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpan), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(AdjustmentRule), Member = "get_HasDaylightSaving", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetDaylightTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(DaylightTimeStruct))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600037F")]
	private static TimeSpan GetUtcOffset(DateTime time, TimeZoneInfo zone, TimeZoneInfoOptions flags) { }

	[Address(RVA = "0x141EEA0", Offset = "0x141E0A0", Length = "0xCE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpan), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(AdjustmentRule), Member = "get_HasDaylightSaving", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000388")]
	private static TimeSpan GetUtcOffset(TimeSpan baseUtcOffset, AdjustmentRule adjustmentRule) { }

	[Address(RVA = "0x141EA30", Offset = "0x141DC30", Length = "0xA5")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(TimeSpan))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
	[Token(Token = "0x6000380")]
	private static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone) { }

	[Address(RVA = "0x141E9B0", Offset = "0x141DBB0", Length = "0x7A")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "ConvertUtcToTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(TimeZoneInfo), typeof(Boolean&)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
	[Token(Token = "0x6000381")]
	private static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, out bool isDaylightSavings) { }

	[Address(RVA = "0x141EAE0", Offset = "0x141DCE0", Length = "0x325")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "IsDaylightSavingTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(DateTime), Member = "FromBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTime), Member = "ToLocalTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "AdjustTimeZoneToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeResult&), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AdjustmentRule), Member = "get_HasDaylightSaving", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpan), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DateTime), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(TimeSpan), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>), typeof(Boolean&), typeof(TimeZoneInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetAdjustmentRuleForTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(bool), typeof(Nullable`1<Int32>&)}, ReturnType = typeof(AdjustmentRule))]
	[Token(Token = "0x6000382")]
	internal static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, out bool isDaylightSavings, out bool isAmbiguousLocalDst) { }

	[Address(RVA = "0x141F5E0", Offset = "0x141E7E0", Length = "0x318")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeZoneInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTime), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TransitionTime), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransitionTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000367")]
	public bool HasSameRules(TimeZoneInfo other) { }

	[Address(RVA = "0x141F900", Offset = "0x141EB00", Length = "0x86")]
	[CalledBy(Type = typeof(DateTime), Member = "IsDaylightSavingTime", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "IsDaylightSavingTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600035D")]
	internal bool IsDaylightSavingTime(DateTime dateTime, TimeZoneInfoOptions flags) { }

	[Address(RVA = "0x141F990", Offset = "0x141EB90", Length = "0x2D9")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "IsDaylightSavingTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetDaylightTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(DaylightTimeStruct))]
	[Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
	[Calls(Type = typeof(AdjustmentRule), Member = "get_HasDaylightSaving", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetAdjustmentRuleForTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(bool), typeof(Nullable`1<Int32>&)}, ReturnType = typeof(AdjustmentRule))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "ConvertTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeZoneInfo), typeof(TimeZoneInfo), typeof(TimeZoneInfoOptions), typeof(CachedData)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(CachedData), Member = "CreateLocal", ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetIsDaylightSavings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(AdjustmentRule), typeof(DaylightTimeStruct), typeof(TimeZoneInfoOptions)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CachedData), Member = "GetCorrespondingKind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeZoneInfo)}, ReturnType = typeof(DateTimeKind))]
	[Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Token(Token = "0x600035E")]
	private bool IsDaylightSavingTime(DateTime dateTime, TimeZoneInfoOptions flags, CachedData cachedData) { }

	[Address(RVA = "0x141FC70", Offset = "0x141EE70", Length = "0x10C")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "ValidateTimeZoneInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(AdjustmentRule[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpan), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(AdjustmentRule), Member = "get_HasDaylightSaving", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "UtcOffsetOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000389")]
	private static bool IsValidAdjustmentRuleOffest(TimeSpan baseUtcOffset, AdjustmentRule adjustmentRule) { }

	[Address(RVA = "0x141FF30", Offset = "0x141F130", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "get_HaveRegistry", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetSystemTimeZonesWinRTFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "PopulateAllSystemTimeZonesFromRegistry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedData)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000337")]
	private static void PopulateAllSystemTimeZones(CachedData cachedData) { }

	[Address(RVA = "0x141FD80", Offset = "0x141EF80", Length = "0x1A9")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "PopulateAllSystemTimeZones", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetSystemTimeZones", ReturnType = typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.TimeZoneInfo>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RegistryKey), Member = "OpenSubKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(RegistryKey))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(TimeZoneInfo&), typeof(Exception&), typeof(CachedData), typeof(bool)}, ReturnType = typeof(TimeZoneInfoResult))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000338")]
	private static void PopulateAllSystemTimeZonesFromRegistry(CachedData cachedData) { }

	[Address(RVA = "0x141FFC0", Offset = "0x141F1C0", Length = "0x1B8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "ValidateTimeZoneInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(AdjustmentRule[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x600036D")]
	private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	[Address(RVA = "0x1420180", Offset = "0x141F380", Length = "0x190")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600036E")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1420320", Offset = "0x141F520", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000369")]
	public virtual string ToString() { }

	[Address(RVA = "0x14211E0", Offset = "0x14203E0", Length = "0x1E4")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "CreateAdjustmentRuleFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(REG_TZI_FORMAT&), typeof(DateTime), typeof(DateTime), typeof(int)}, ReturnType = typeof(AdjustmentRule))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TransitionTime), Member = "ValidateTransitionTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(int), typeof(int), typeof(DayOfWeek)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000340")]
	private static bool TransitionTimeFromTimeZoneInformation(in REG_TZI_FORMAT timeZoneInformation, out TransitionTime transitionTime, bool readStartDate) { }

	[Address(RVA = "0x1420340", Offset = "0x141F540", Length = "0xE96")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "CreateAdjustmentRuleFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DYNAMIC_TIME_ZONE_INFORMATION&), typeof(DateTime), typeof(DateTime), typeof(int)}, ReturnType = typeof(AdjustmentRule))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TransitionTime), Member = "ValidateTransitionTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(int), typeof(int), typeof(int), typeof(DayOfWeek)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000350")]
	private static bool TransitionTimeFromTimeZoneInformation(DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, out TransitionTime transitionTime, bool readStartDate) { }

	[Address(RVA = "0x14213D0", Offset = "0x14205D0", Length = "0x2CE")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetDaylightTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AdjustmentRule), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(DaylightTimeStruct))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "DaysInMonth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Hour", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Minute", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Second", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = "get_Millisecond", ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "get_DayOfWeek", ReturnType = typeof(DayOfWeek))]
	[Calls(Type = typeof(DateTime), Member = "AddDays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DateTime))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000383")]
	internal static DateTime TransitionTimeToDateTime(int year, TransitionTime transitionTime) { }

	[Address(RVA = "0x14216A0", Offset = "0x14208A0", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SYSTEMTIME), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SYSTEMTIME&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000343")]
	private static bool TryCompareStandardDate(in TIME_ZONE_INFORMATION timeZone, in REG_TZI_FORMAT registryTimeZoneInfo) { }

	[Address(RVA = "0x14216E0", Offset = "0x14208E0", Length = "0x47E")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "FindIdFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(Boolean&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RegistryKey), Member = "OpenSubKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(RegistryKey))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TIME_ZONE_INFORMATION), Member = "GetStandardName", ReturnType = typeof(string))]
	[Calls(Type = typeof(SYSTEMTIME), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SYSTEMTIME&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RegistryKey), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(RegistryValueOptions)}, ReturnType = typeof(object))]
	[Token(Token = "0x6000344")]
	private static bool TryCompareTimeZoneInformationToRegistry(in TIME_ZONE_INFORMATION timeZone, string id, out bool dstDisabled) { }

	[Address(RVA = "0x1421B60", Offset = "0x1420D60", Length = "0xA23")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZoneFromLocalRegistry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeZoneInfo&), typeof(Exception&)}, ReturnType = typeof(TimeZoneInfoResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZoneEntryFromRegistry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegistryKey), typeof(string), typeof(REG_TZI_FORMAT&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "CreateAdjustmentRuleFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(REG_TZI_FORMAT&), typeof(DateTime), typeof(DateTime), typeof(int)}, ReturnType = typeof(AdjustmentRule))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "get_Date", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(RegistryKey), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(RegistryValueOptions)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(RegistryKey), Member = "OpenSubKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(RegistryKey))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Token(Token = "0x6000341")]
	private static bool TryCreateAdjustmentRules(string id, in REG_TZI_FORMAT defaultTimeZoneInformation, out AdjustmentRule[] rules, out Exception e, int defaultBaseUtcOffset) { }

	[Address(RVA = "0x1422590", Offset = "0x1421790", Length = "0x95A")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetLocalTimeZoneInfoWinRTFallback", ReturnType = typeof(TimeZoneInfo))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetSystemTimeZonesWinRTFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetTimeZoneInformationForYear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(DYNAMIC_TIME_ZONE_INFORMATION&), typeof(TIME_ZONE_INFORMATION&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(TimeZoneInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(string), typeof(string), typeof(string), typeof(AdjustmentRule[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TIME_ZONE_INFORMATION), Member = "GetDaylightName", ReturnType = typeof(string))]
	[Calls(Type = typeof(TIME_ZONE_INFORMATION), Member = "GetStandardName", ReturnType = typeof(string))]
	[Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "CreateAdjustmentRuleFromTimeZoneInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DYNAMIC_TIME_ZONE_INFORMATION&), typeof(DateTime), typeof(DateTime), typeof(int)}, ReturnType = typeof(AdjustmentRule))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "get_Date", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18018DDF0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18018DD30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000351")]
	internal static TimeZoneInfo TryCreateTimeZone(DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation) { }

	[Address(RVA = "0x1422EF0", Offset = "0x14220F0", Length = "0x26B")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetLocalizedNamesByRegistryKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegistryKey), typeof(String&), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StringBuilderCache), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "TryGetLocalizedNameByNativeResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilderCache), Member = "GetStringAndRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Kernel32), Member = "GetFileMUIPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(string), typeof(StringBuilder), typeof(Int32&), typeof(StringBuilder), typeof(Int32&), typeof(Int64&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilderCache), Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "TrimStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Environment), Member = "get_SystemDirectory", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000345")]
	private static string TryGetLocalizedNameByMuiNativeResource(string resource) { }

	[Address(RVA = "0x1423160", Offset = "0x1422360", Length = "0x142")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetLocalizedNameByMuiNativeResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Kernel32), Member = "LoadLibraryEx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IntPtr), typeof(int)}, ReturnType = typeof(SafeLibraryHandle))]
	[Calls(Type = typeof(StringBuilderCache), Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(User32), Member = "LoadString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeLibraryHandle), typeof(int), typeof(StringBuilder), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilderCache), Member = "GetStringAndRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000346")]
	private static string TryGetLocalizedNameByNativeResource(string filePath, int resource) { }

	[Address(RVA = "0x1423C90", Offset = "0x1422E90", Length = "0x205")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "PopulateAllSystemTimeZonesFromRegistry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "GetLocalTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedData)}, ReturnType = typeof(TimeZoneInfo))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "CreateCustomTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(string), typeof(string)}, ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TimeZoneInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(string), typeof(string), typeof(string), typeof(AdjustmentRule[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZoneFromLocalMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(TimeZoneInfo&), typeof(Exception&), typeof(CachedData)}, ReturnType = typeof(TimeZoneInfoResult))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000384")]
	private static TimeZoneInfoResult TryGetTimeZone(string id, bool dstDisabled, out TimeZoneInfo value, out Exception e, CachedData cachedData, bool alwaysFallbackToLocalMachine = false) { }

	[Address(RVA = "0x14232B0", Offset = "0x14224B0", Length = "0xD6")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryCreateAdjustmentRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(REG_TZI_FORMAT&), typeof(AdjustmentRule[]&), typeof(Exception&), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RegistryKey), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(RegistryValueOptions)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000342")]
	private static bool TryGetTimeZoneEntryFromRegistry(RegistryKey key, string name, out REG_TZI_FORMAT dtzi) { }

	[Address(RVA = "0x1423390", Offset = "0x1422590", Length = "0x372")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(TimeZoneInfo&), typeof(Exception&), typeof(CachedData), typeof(bool)}, ReturnType = typeof(TimeZoneInfoResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "FindSystemTimeZoneByIdWinRTFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZoneFromLocalRegistry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeZoneInfo&), typeof(Exception&)}, ReturnType = typeof(TimeZoneInfoResult))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "CreateCustomTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(string), typeof(string)}, ReturnType = typeof(TimeZoneInfo))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TimeZoneInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(string), typeof(string), typeof(string), typeof(AdjustmentRule[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "get_HaveRegistry", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Token(Token = "0x6000385")]
	private static TimeZoneInfoResult TryGetTimeZoneFromLocalMachine(string id, bool dstDisabled, out TimeZoneInfo value, out Exception e, CachedData cachedData) { }

	[Address(RVA = "0x1423710", Offset = "0x1422910", Length = "0xD9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "get_HaveRegistry", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "FindSystemTimeZoneByIdWinRTFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TimeZoneInfo))]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000348")]
	private static TimeZoneInfoResult TryGetTimeZoneFromLocalMachine(string id, out TimeZoneInfo value, out Exception e) { }

	[Address(RVA = "0x14237F0", Offset = "0x14229F0", Length = "0x497")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetTimeZoneFromLocalMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(TimeZoneInfo&), typeof(Exception&), typeof(CachedData)}, ReturnType = typeof(TimeZoneInfoResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RegistryKey), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(RegistryValueOptions)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(TimeZoneInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(string), typeof(string), typeof(string), typeof(AdjustmentRule[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "GetLocalizedNamesByRegistryKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegistryKey), typeof(String&), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "TryCreateAdjustmentRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(REG_TZI_FORMAT&), typeof(AdjustmentRule[]&), typeof(Exception&), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(RegistryKey), Member = "OpenSubKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(RegistryKey))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Token(Token = "0x6000349")]
	private static TimeZoneInfoResult TryGetTimeZoneFromLocalRegistry(string id, out TimeZoneInfo value, out Exception e) { }

	[Address(RVA = "0x1423EA0", Offset = "0x14230A0", Length = "0xEA")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "ValidateTimeZoneInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(AdjustmentRule[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "IsValidAdjustmentRuleOffest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(AdjustmentRule)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpan), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpan), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000387")]
	internal static bool UtcOffsetOutOfRange(TimeSpan offset) { }

	[Address(RVA = "0x1423F90", Offset = "0x1423190", Length = "0x3F6")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TIME_ZONE_INFORMATION&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(string), typeof(string), typeof(string), typeof(AdjustmentRule[]), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "IsValidAdjustmentRuleOffest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(AdjustmentRule)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(InvalidTimeZoneException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "op_LessThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TimeZoneInfo), Member = "UtcOffsetOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000386")]
	private static void ValidateTimeZoneInfo(string id, TimeSpan baseUtcOffset, AdjustmentRule[] adjustmentRules, out bool adjustmentRulesSupportDst) { }

}

