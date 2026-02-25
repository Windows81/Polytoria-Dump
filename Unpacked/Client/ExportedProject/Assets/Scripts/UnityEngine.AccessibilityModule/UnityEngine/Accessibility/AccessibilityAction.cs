namespace UnityEngine.Accessibility;

[NativeHeader("Modules/Accessibility/Native/AccessibilityAction.h")]
[RequiredByNativeCode]
[Token(Token = "0x2000002")]
internal sealed class AccessibilityAction : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000001")]
	private IntPtr m_Ptr; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000002")]
	private Func<Boolean> <activated>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x17000001")]
	public Func<Boolean> activated
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000004")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x18FB0A0", Offset = "0x18FA2A0", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000001")]
	public override void Dispose() { }

	[Address(RVA = "0x18FB050", Offset = "0x18FA250", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000002")]
	private void Dispose(bool disposing) { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000004")]
	public Func<Boolean> get_activated() { }

	[Address(RVA = "0x18FB130", Offset = "0x18FA330", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000003")]
	private static void Internal_Destroy(IntPtr ptr) { }

	[Address(RVA = "0x18FB170", Offset = "0x18FA370", Length = "0x36")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[RequiredByNativeCode]
	[Token(Token = "0x6000005")]
	private bool Internal_InvokeActivated() { }

}

