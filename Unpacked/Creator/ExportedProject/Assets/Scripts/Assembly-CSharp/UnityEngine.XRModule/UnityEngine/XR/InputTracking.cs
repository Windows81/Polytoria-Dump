namespace UnityEngine.XR;

[NativeConditional("ENABLE_VR")]
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputTrackingFacade.h")]
[RequiredByNativeCode]
[StaticAccessor("XRInputTrackingFacade::Get()", StaticAccessorType::Dot (0))]
[Token(Token = "0x2000002")]
public static class InputTracking
{
	[Token(Token = "0x2000003")]
	private enum TrackingStateEventType
	{
		NodeAdded = 0,
		NodeRemoved = 1,
		TrackingAcquired = 2,
		TrackingLost = 3,
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000001")]
	private static Action<XRNodeState> trackingAcquired; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000002")]
	private static Action<XRNodeState> trackingLost; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000003")]
	private static Action<XRNodeState> nodeAdded; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000004")]
	private static Action<XRNodeState> nodeRemoved; //Field offset: 0x18

	[Address(RVA = "0x1D018F0", Offset = "0x1D00AF0", Length = "0x1B4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002060")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000001")]
	private static void InvokeTrackingEvent(TrackingStateEventType eventType, XRNode nodeType, long uniqueID, bool tracked) { }

}

