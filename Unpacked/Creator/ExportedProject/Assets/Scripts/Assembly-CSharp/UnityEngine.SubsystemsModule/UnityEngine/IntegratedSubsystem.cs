namespace UnityEngine;

[NativeHeader("Modules/Subsystems/Subsystem.h")]
[Token(Token = "0x2000002")]
[UsedByNativeCode]
public class IntegratedSubsystem
{
	[Token(Token = "0x2000003")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x7CE590", Offset = "0x7CD790", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000004")]
		public static IntPtr ConvertToNative(IntegratedSubsystem integratedSubsystem) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000001")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.XRModule"})]
	internal IntPtr m_Ptr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000002")]
	internal ISubsystemDescriptor m_SubsystemDescriptor; //Field offset: 0x18

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000002")]
	public IntegratedSubsystem() { }

	[Address(RVA = "0x1A19B00", Offset = "0x1A18D00", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000001")]
	internal void SetHandle(IntegratedSubsystem subsystem) { }

	[Address(RVA = "0x1A19AB0", Offset = "0x1A18CB0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000003")]
	private static void SetHandle_Injected(IntPtr _unity_self, IntegratedSubsystem subsystem) { }

}

