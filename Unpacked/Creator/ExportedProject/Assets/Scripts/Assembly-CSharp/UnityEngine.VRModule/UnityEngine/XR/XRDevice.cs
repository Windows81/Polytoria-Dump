namespace UnityEngine.XR;

[NativeConditional("ENABLE_VR")]
[Token(Token = "0x2000002")]
public static class XRDevice
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000001")]
	private static Action<String> deviceLoaded; //Field offset: 0x0

	[Address(RVA = "0x1D01140", Offset = "0x1D00340", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000001")]
	private static void InvokeDeviceLoaded(string loadedDeviceName) { }

}

