namespace Unity.Jobs;

[Token(Token = "0x2000004")]
public class EarlyInitHelpers
{
	[Token(Token = "0x2000005")]
	internal sealed class EarlyInitFunction : MulticastDelegate
	{

		[Address(RVA = "0x2D8810", Offset = "0x2D7A10", Length = "0xA5")]
		[CallerCount(Count = 285)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000006")]
		public EarlyInitFunction(object object, IntPtr method) { }

		[Address(RVA = "0x2BC000", Offset = "0x2BB200", Length = "0x16A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180288CC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802891B0")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000007")]
		public override void Invoke() { }

	}

	[Token(Token = "0x4000001")]
	private static List<EarlyInitFunction> s_PendingDelegates; //Field offset: 0x0

	[Address(RVA = "0x1820610", Offset = "0x181F810", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EarlyInitHelpers), Member = "FlushEarlyInits", ReturnType = typeof(void))]
	[Token(Token = "0x6000003")]
	private static EarlyInitHelpers() { }

	[Address(RVA = "0x1820430", Offset = "0x181F630", Length = "0x16A")]
	[CalledBy(Type = typeof(EarlyInitHelpers), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000004")]
	public static void FlushEarlyInits() { }

	[Address(RVA = "0x18205A0", Offset = "0x181F7A0", Length = "0x63")]
	[CalledBy(Type = "__JobReflectionRegistrationOutput__1854482118041315048", Member = "CreateJobReflectionData", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__JobReflectionRegistrationOutput__1652832624114795843), Member = "CreateJobReflectionData", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000005")]
	public static void JobReflectionDataCreationFailed(Exception ex) { }

}

