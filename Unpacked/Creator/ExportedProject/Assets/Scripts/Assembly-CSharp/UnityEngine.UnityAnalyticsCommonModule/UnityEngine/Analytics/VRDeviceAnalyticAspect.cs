namespace UnityEngine.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x2000007")]
public class VRDeviceAnalyticAspect : VRDeviceAnalyticBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000006")]
	public float vr_aspect_ratio; //Field offset: 0x30

	[Address(RVA = "0x1CF6AD0", Offset = "0x1CF5CD0", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AnalyticsEventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SendEventOptions), typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600000A")]
	public VRDeviceAnalyticAspect() { }

	[Address(RVA = "0x1CF6B40", Offset = "0x1CF5D40", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AnalyticsEventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SendEventOptions), typeof(string)}, ReturnType = typeof(void))]
	[RequiredByNativeCode]
	[Token(Token = "0x6000009")]
	internal static VRDeviceAnalyticAspect CreateVRDeviceAnalyticAspect() { }

}

