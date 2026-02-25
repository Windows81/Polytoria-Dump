namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x2000021")]
internal class StallMarkerAnalytic : AnalyticsEventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000059")]
	public string Name; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400005A")]
	public bool HasProgressMarkup; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400005B")]
	public double Duration; //Field offset: 0x40

	[Address(RVA = "0x1CF62E0", Offset = "0x1CF54E0", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AnalyticsEventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SendEventOptions), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600003C")]
	public StallMarkerAnalytic() { }

	[Address(RVA = "0x1CF6250", Offset = "0x1CF5450", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AnalyticsEventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SendEventOptions), typeof(string)}, ReturnType = typeof(void))]
	[RequiredByNativeCode]
	[Token(Token = "0x600003D")]
	internal static StallMarkerAnalytic CreateStallMarkerAnalytic() { }

}

