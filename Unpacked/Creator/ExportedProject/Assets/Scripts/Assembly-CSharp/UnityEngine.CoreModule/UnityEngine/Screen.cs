namespace UnityEngine;

[NativeHeader("Runtime/Graphics/WindowLayout.h")]
[NativeHeader("Runtime/Graphics/ScreenManager.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[StaticAccessor("GetScreenManager()", StaticAccessorType::Dot (0))]
[Token(Token = "0x20000A5")]
public sealed class Screen
{

	[Token(Token = "0x17000099")]
	public static float dpi
	{
		[Address(RVA = "0x193E3F0", Offset = "0x193D5F0", Length = "0x2A")]
		[CalledBy(Type = "UnityEngine.UIElements.PanelSettings", Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelSettings", Member = "UpdateScreenDPI", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelSettings", Member = "ApplyPanelSettings", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleConstantPhysicalSize", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[NativeName("GetDPI")]
		[Token(Token = "0x6000362")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700009A")]
	public static bool fullScreen
	{
		[Address(RVA = "0x193E450", Offset = "0x193D650", Length = "0x2A")]
		[CalledBy(Type = "UnityEngine.UI.MultipleDisplayUtilities", Member = "RelativeMouseAtScaled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(Vector3))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[NativeName("IsFullscreen")]
		[Token(Token = "0x6000363")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700009B")]
	public static FullScreenMode fullScreenMode
	{
		[Address(RVA = "0x193E420", Offset = "0x193D620", Length = "0x2A")]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "ReloadGraphicsControls", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[NativeName("GetFullscreenMode")]
		[Token(Token = "0x6000364")]
		 get { } //Length: 42
		[Address(RVA = "0x193E4E0", Offset = "0x193D6E0", Length = "0x31")]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "SetFullscreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[NativeName("RequestSetFullscreenModeFromScript")]
		[Token(Token = "0x6000365")]
		 set { } //Length: 49
	}

	[Token(Token = "0x17000098")]
	public static int height
	{
		[Address(RVA = "0x193E480", Offset = "0x193D680", Length = "0x2A")]
		[CallerCount(Count = 39)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[NativeMethod(Name = "GetHeight", IsThreadSafe = True)]
		[Token(Token = "0x6000361")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000097")]
	public static int width
	{
		[Address(RVA = "0x193E4B0", Offset = "0x193D6B0", Length = "0x2A")]
		[CallerCount(Count = 28)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[NativeMethod(Name = "GetWidth", IsThreadSafe = True)]
		[Token(Token = "0x6000360")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x193E3F0", Offset = "0x193D5F0", Length = "0x2A")]
	[CalledBy(Type = "UnityEngine.UIElements.PanelSettings", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelSettings", Member = "UpdateScreenDPI", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelSettings", Member = "ApplyPanelSettings", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleConstantPhysicalSize", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("GetDPI")]
	[Token(Token = "0x6000362")]
	public static float get_dpi() { }

	[Address(RVA = "0x193E450", Offset = "0x193D650", Length = "0x2A")]
	[CalledBy(Type = "UnityEngine.UI.MultipleDisplayUtilities", Member = "RelativeMouseAtScaled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("IsFullscreen")]
	[Token(Token = "0x6000363")]
	public static bool get_fullScreen() { }

	[Address(RVA = "0x193E420", Offset = "0x193D620", Length = "0x2A")]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "ReloadGraphicsControls", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("GetFullscreenMode")]
	[Token(Token = "0x6000364")]
	public static FullScreenMode get_fullScreenMode() { }

	[Address(RVA = "0x193E480", Offset = "0x193D680", Length = "0x2A")]
	[CallerCount(Count = 39)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(Name = "GetHeight", IsThreadSafe = True)]
	[Token(Token = "0x6000361")]
	public static int get_height() { }

	[Address(RVA = "0x193E4B0", Offset = "0x193D6B0", Length = "0x2A")]
	[CallerCount(Count = 28)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(Name = "GetWidth", IsThreadSafe = True)]
	[Token(Token = "0x6000360")]
	public static int get_width() { }

	[Address(RVA = "0x193E4E0", Offset = "0x193D6E0", Length = "0x31")]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "SetFullscreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("RequestSetFullscreenModeFromScript")]
	[Token(Token = "0x6000365")]
	public static void set_fullScreenMode(FullScreenMode value) { }

	[Address(RVA = "0x193E290", Offset = "0x193D490", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("RequestResolution")]
	[Token(Token = "0x6000366")]
	public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, RefreshRate preferredRefreshRate) { }

	[Address(RVA = "0x193E370", Offset = "0x193D570", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("SetResolution(int, int, bool, int) is obsolete. Use SetResolution(int, int, FullScreenMode, RefreshRate) instead.")]
	[Token(Token = "0x6000367")]
	public static void SetResolution(int width, int height, bool fullscreen, int preferredRefreshRate) { }

	[Address(RVA = "0x193E2F0", Offset = "0x193D4F0", Length = "0x78")]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "SetFullscreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000368")]
	public static void SetResolution(int width, int height, bool fullscreen) { }

	[Address(RVA = "0x193E230", Offset = "0x193D430", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000369")]
	private static void SetResolution_Injected(int width, int height, FullScreenMode fullscreenMode, in RefreshRate preferredRefreshRate) { }

}

