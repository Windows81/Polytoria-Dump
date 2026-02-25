namespace UnityEngine.XR;

[NativeConditional("ENABLE_VR")]
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
[StaticAccessor("XRInputDevices::Get()", StaticAccessorType::Dot (0))]
[Token(Token = "0x200000E")]
[UsedByNativeCode]
public class InputDevices
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000040")]
	private static Action<InputDevice> deviceConnected; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000041")]
	private static Action<InputDevice> deviceDisconnected; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000042")]
	private static Action<InputDevice> deviceConfigChanged; //Field offset: 0x10

	[Address(RVA = "0x1D016B0", Offset = "0x1D008B0", Length = "0xC1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x600001E")]
	private static void InvokeConnectionEvent(ulong deviceId, ConnectionChangeType change) { }

}

