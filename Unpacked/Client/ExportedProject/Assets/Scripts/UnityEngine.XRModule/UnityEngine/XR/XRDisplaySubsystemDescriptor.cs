namespace UnityEngine.XR;

[NativeType(Header = "Modules/XR/Subsystems/Display/XRDisplaySubsystemDescriptor.h")]
[Token(Token = "0x2000013")]
[UsedByNativeCode]
public class XRDisplaySubsystemDescriptor : IntegratedSubsystemDescriptor<XRDisplaySubsystem>
{

	[Address(RVA = "0x1D021F0", Offset = "0x1D013F0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000021")]
	public XRDisplaySubsystemDescriptor() { }

}

