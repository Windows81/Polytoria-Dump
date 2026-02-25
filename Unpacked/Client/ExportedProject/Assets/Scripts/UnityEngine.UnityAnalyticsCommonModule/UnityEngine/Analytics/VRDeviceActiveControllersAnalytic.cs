namespace UnityEngine.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x200000A")]
public class VRDeviceActiveControllersAnalytic : VRDeviceAnalyticBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000009")]
	public String[] vr_active_controllers; //Field offset: 0x30

	[Address(RVA = "0x1CF6AD0", Offset = "0x1CF5CD0", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AnalyticsEventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SendEventOptions), typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000010")]
	public VRDeviceActiveControllersAnalytic() { }

	[Address(RVA = "0x1CF6A40", Offset = "0x1CF5C40", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AnalyticsEventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SendEventOptions), typeof(string)}, ReturnType = typeof(void))]
	[RequiredByNativeCode]
	[Token(Token = "0x600000F")]
	internal static VRDeviceActiveControllersAnalytic CreateVRDeviceActiveControllersAnalytic() { }

}

