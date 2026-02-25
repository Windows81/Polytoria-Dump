namespace UnityEngine.Android;

[NativeHeader("Modules/AndroidJNI/Public/AndroidApplication.bindings.h")]
[StaticAccessor("AndroidApplication", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000010")]
public static class AndroidApplication
{
	[Token(Token = "0x4000022")]
	private static SynchronizationContext m_MainThreadSynchronizationContext; //Field offset: 0x0
	[Token(Token = "0x4000023")]
	private static AndroidConfiguration m_CurrentConfiguration; //Field offset: 0x8
	[Token(Token = "0x4000024")]
	private static AndroidInsets m_CurrentAndroidInsets; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000025")]
	private static Action<AndroidConfiguration> onConfigurationChanged; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000026")]
	private static Action<AndroidInsets> onInsetsChanged; //Field offset: 0x20

	[Token(Token = "0x17000002")]
	internal static IntPtr UnityPlayerRaw
	{
		[Address(RVA = "0x1902860", Offset = "0x1901A60", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[ThreadSafe]
		[Token(Token = "0x6000101")]
		internal get { } //Length: 42
	}

	[Address(RVA = "0x19025A0", Offset = "0x19017A0", Length = "0xB9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SynchronizationContext), Member = "get_Current", ReturnType = typeof(SynchronizationContext))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[RequiredByNativeCode(GenerateProxy = True)]
	[Token(Token = "0x6000102")]
	private static void AcquireMainThreadSynchronizationContext() { }

	[Address(RVA = "0x1902660", Offset = "0x1901860", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode(GenerateProxy = True)]
	[Token(Token = "0x6000105")]
	private static void DispatchConfigurationChanged(bool notifySubscribers) { }

	[Address(RVA = "0x19026C0", Offset = "0x19018C0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode(GenerateProxy = True)]
	[Token(Token = "0x6000108")]
	private static void DispatchInsetsChanged() { }

	[Address(RVA = "0x1902860", Offset = "0x1901A60", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x6000101")]
	internal static IntPtr get_UnityPlayerRaw() { }

	[Address(RVA = "0x1902720", Offset = "0x1901920", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[RequiredByNativeCode(GenerateProxy = True)]
	[Token(Token = "0x6000104")]
	private static AndroidConfiguration GetCurrentConfiguration() { }

	[Address(RVA = "0x1902760", Offset = "0x1901960", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[RequiredByNativeCode(GenerateProxy = True)]
	[Token(Token = "0x6000107")]
	private static AndroidInsets GetCurrentInsets() { }

	[Address(RVA = "0x19027A0", Offset = "0x19019A0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[RequiredByNativeCode(GenerateProxy = True)]
	[Token(Token = "0x6000103")]
	private static void SetCurrentConfiguration(AndroidConfiguration config) { }

	[Address(RVA = "0x1902800", Offset = "0x1901A00", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[RequiredByNativeCode(GenerateProxy = True)]
	[Token(Token = "0x6000106")]
	private static void SetCurrentInsets(AndroidInsets insets) { }

}

