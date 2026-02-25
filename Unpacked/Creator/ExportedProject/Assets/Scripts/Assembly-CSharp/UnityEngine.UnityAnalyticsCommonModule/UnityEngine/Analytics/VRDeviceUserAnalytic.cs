namespace UnityEngine.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x2000009")]
public class VRDeviceUserAnalytic : VRDeviceAnalyticBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000008")]
	public int vr_user_presence; //Field offset: 0x30

	[Address(RVA = "0x1CF6AD0", Offset = "0x1CF5CD0", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AnalyticsEventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SendEventOptions), typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600000E")]
	public VRDeviceUserAnalytic() { }

	[Address(RVA = "0x1CF6C60", Offset = "0x1CF5E60", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AnalyticsEventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(SendEventOptions), typeof(string)}, ReturnType = typeof(void))]
	[RequiredByNativeCode]
	[Token(Token = "0x600000D")]
	internal static VRDeviceUserAnalytic CreateVRDeviceUserAnalytic() { }

}

