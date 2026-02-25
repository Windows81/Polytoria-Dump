namespace UnityEngine.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x2000008")]
public class VRDeviceMirrorAnalytic : VRDeviceAnalyticBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000007")]
	public bool vr_device_mirror_mode; //Field offset: 0x30

	[Address(RVA = "0x1CF6AD0", Offset = "0x1CF5CD0", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AnalyticsEventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SendEventOptions), typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600000C")]
	public VRDeviceMirrorAnalytic() { }

	[Address(RVA = "0x1CF6BD0", Offset = "0x1CF5DD0", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AnalyticsEventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SendEventOptions), typeof(string)}, ReturnType = typeof(void))]
	[RequiredByNativeCode]
	[Token(Token = "0x600000B")]
	internal static VRDeviceMirrorAnalytic CreateVRDeviceMirrorAnalytic() { }

}

