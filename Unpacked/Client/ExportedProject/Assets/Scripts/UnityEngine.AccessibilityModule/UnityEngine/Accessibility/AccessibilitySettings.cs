namespace UnityEngine.Accessibility;

[NativeHeader("Modules/Accessibility/Native/AccessibilitySettings.h")]
[Token(Token = "0x200000C")]
public static class AccessibilitySettings
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000042")]
	private static Action<Single> fontScaleChanged; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000043")]
	private static Action<Boolean> boldTextStatusChanged; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000044")]
	private static Action<Boolean> closedCaptioningStatusChanged; //Field offset: 0x10

	[Address(RVA = "0x18FE2D0", Offset = "0x18FD4D0", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AccessibilityManager), Member = "QueueNotification", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NotificationContext)}, ReturnType = typeof(void))]
	[RequiredByNativeCode]
	[Token(Token = "0x600004E")]
	private static void Internal_OnBoldTextStatusChanged(bool enabled) { }

	[Address(RVA = "0x18FE370", Offset = "0x18FD570", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AccessibilityManager), Member = "QueueNotification", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NotificationContext)}, ReturnType = typeof(void))]
	[RequiredByNativeCode]
	[Token(Token = "0x600004F")]
	private static void Internal_OnClosedCaptioningStatusChanged(bool enabled) { }

	[Address(RVA = "0x18FE410", Offset = "0x18FD610", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AccessibilityManager), Member = "QueueNotification", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NotificationContext)}, ReturnType = typeof(void))]
	[RequiredByNativeCode]
	[Token(Token = "0x600004D")]
	private static void Internal_OnFontScaleChanged(float newFontScale) { }

	[Address(RVA = "0x18FE4D0", Offset = "0x18FD6D0", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000051")]
	internal static void InvokeBoldTextStatusChanged(bool enabled) { }

	[Address(RVA = "0x18FE530", Offset = "0x18FD730", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000052")]
	internal static void InvokeClosedCaptionStatusChanged(bool enabled) { }

	[Address(RVA = "0x18FE590", Offset = "0x18FD790", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000050")]
	internal static void InvokeFontScaleChanged(float newFontScale) { }

}

