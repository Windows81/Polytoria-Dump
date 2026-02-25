namespace UnityEngine.XR;

[NativeConditional("ENABLE_XR")]
[NativeHeader("Modules/XR/XRPrefix.h")]
[NativeType(Header = "Modules/XR/Subsystems/Input/XRInputSubsystemDescriptor.h")]
[Token(Token = "0x2000015")]
[UsedByNativeCode]
public class XRInputSubsystemDescriptor : IntegratedSubsystemDescriptor<XRInputSubsystem>
{

	[Address(RVA = "0x1D02270", Offset = "0x1D01470", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000025")]
	public XRInputSubsystemDescriptor() { }

}

