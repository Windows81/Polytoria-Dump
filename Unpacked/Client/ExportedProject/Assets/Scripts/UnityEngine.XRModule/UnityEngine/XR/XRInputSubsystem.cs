namespace UnityEngine.XR;

[NativeConditional("ENABLE_XR")]
[NativeType(Header = "Modules/XR/Subsystems/Input/XRInputSubsystem.h")]
[Token(Token = "0x2000014")]
[UsedByNativeCode]
public class XRInputSubsystem : IntegratedSubsystem<XRInputSubsystemDescriptor>
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400005D")]
	private Action<XRInputSubsystem> trackingOriginUpdated; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400005E")]
	private Action<XRInputSubsystem> boundaryChanged; //Field offset: 0x28

	[Address(RVA = "0x1D02410", Offset = "0x1D01610", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000024")]
	public XRInputSubsystem() { }

	[Address(RVA = "0x1D022B0", Offset = "0x1D014B0", Length = "0xA9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SubsystemManager), Member = "GetIntegratedSubsystemByPtr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(IntegratedSubsystem))]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode(GenerateProxy = True)]
	[Token(Token = "0x6000023")]
	private static void InvokeBoundaryChangedEvent(IntPtr internalPtr) { }

	[Address(RVA = "0x1D02360", Offset = "0x1D01560", Length = "0xA9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SubsystemManager), Member = "GetIntegratedSubsystemByPtr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(IntegratedSubsystem))]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode(GenerateProxy = True)]
	[Token(Token = "0x6000022")]
	private static void InvokeTrackingOriginUpdatedEvent(IntPtr internalPtr) { }

}

