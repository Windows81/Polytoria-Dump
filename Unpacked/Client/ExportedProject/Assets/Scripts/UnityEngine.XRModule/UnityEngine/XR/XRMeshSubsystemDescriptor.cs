namespace UnityEngine.XR;

[NativeHeader("Modules/XR/XRPrefix.h")]
[NativeType(Header = "Modules/XR/Subsystems/Planes/XRMeshSubsystemDescriptor.h")]
[Token(Token = "0x200001D")]
[UsedByNativeCode]
public class XRMeshSubsystemDescriptor : IntegratedSubsystemDescriptor<XRMeshSubsystem>
{

	[Address(RVA = "0x1D02450", Offset = "0x1D01650", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000041")]
	public XRMeshSubsystemDescriptor() { }

}

