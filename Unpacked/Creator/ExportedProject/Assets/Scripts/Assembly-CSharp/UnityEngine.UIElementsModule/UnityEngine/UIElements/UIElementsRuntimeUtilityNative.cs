namespace UnityEngine.UIElements;

[NativeHeader("Modules/UIElements/Core/Native/UIElementsRuntimeUtilityNative.h")]
[Token(Token = "0x20002A0")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"Unity.UIElements"})]
internal static class UIElementsRuntimeUtilityNative
{
	[Token(Token = "0x4000A74")]
	private static Action UpdatePanelsCallback; //Field offset: 0x0
	[Token(Token = "0x4000A75")]
	private static Action<Boolean> RepaintPanelsCallback; //Field offset: 0x8
	[Token(Token = "0x4000A76")]
	private static Action RenderOffscreenPanelsCallback; //Field offset: 0x10

	[Address(RVA = "0x1C8F370", Offset = "0x1C8E570", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001218")]
	private static void RegisterRenderingCallbacks() { }

	[Address(RVA = "0x1C8F3A0", Offset = "0x1C8E5A0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6001214")]
	public static void RenderOffscreenPanels() { }

	[Address(RVA = "0x1C8F3F0", Offset = "0x1C8E5F0", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6001213")]
	public static void RepaintPanels(bool onlyOffscreen) { }

	[Address(RVA = "0x1C8F450", Offset = "0x1C8E650", Length = "0xB0")]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "RegisterCachedPanelInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "EnableRenderingAndInputCallbacks", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001216")]
	public static void SetRenderingCallbacks(Action<Boolean> repaintPanels, Action renderOffscreenPanels) { }

	[Address(RVA = "0x1C8F500", Offset = "0x1C8E700", Length = "0x51")]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001215")]
	public static void SetUpdateCallback(Action callback) { }

	[Address(RVA = "0x1C8F560", Offset = "0x1C8E760", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001219")]
	private static void UnregisterRenderingCallbacks() { }

	[Address(RVA = "0x1C8F590", Offset = "0x1C8E790", Length = "0xA4")]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "RemoveCachedPanelInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "DisableRenderingAndInputCallbacks", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001217")]
	public static void UnsetRenderingCallbacks() { }

	[Address(RVA = "0x1C8F640", Offset = "0x1C8E840", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6001212")]
	public static void UpdatePanels() { }

	[Address(RVA = "0x1C8F690", Offset = "0x1C8E890", Length = "0x2A")]
	[CalledBy(Type = typeof(Focusable), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600121A")]
	public static void VisualElementCreation() { }

}

