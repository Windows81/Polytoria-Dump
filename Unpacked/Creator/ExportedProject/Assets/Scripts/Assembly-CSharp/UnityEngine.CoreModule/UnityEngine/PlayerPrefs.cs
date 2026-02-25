namespace UnityEngine;

[NativeHeader("Runtime/Utilities/PlayerPrefs.h")]
[Token(Token = "0x200010B")]
public class PlayerPrefs
{

	[Address(RVA = "0x196AAA0", Offset = "0x1969CA0", Length = "0x19C")]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600087E")]
	public static float GetFloat(string key, float defaultValue) { }

	[Address(RVA = "0x196AA50", Offset = "0x1969C50", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000885")]
	private static float GetFloat_Injected(ref ManagedSpanWrapper key, float defaultValue) { }

	[Address(RVA = "0x196AC80", Offset = "0x1969E80", Length = "0x18A")]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "ReloadControls", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "ReloadMiscControls", ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600087C")]
	public static int GetInt(string key, int defaultValue) { }

	[Address(RVA = "0x196AC40", Offset = "0x1969E40", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000884")]
	private static int GetInt_Injected(ref ManagedSpanWrapper key, int defaultValue) { }

	[Address(RVA = "0x196AE70", Offset = "0x196A070", Length = "0x2DC")]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "get_LastBrowsedFolder", ReturnType = typeof(string))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "GetInitialPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Mirror.Authenticators.DeviceAuthenticator", Member = "OnClientAuthenticate", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18195A090")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000880")]
	public static string GetString(string key, string defaultValue) { }

	[Address(RVA = "0x196AE10", Offset = "0x196A010", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000886")]
	private static void GetString_Injected(ref ManagedSpanWrapper key, ref ManagedSpanWrapper defaultValue, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x196B150", Offset = "0x196A350", Length = "0x67")]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "SetMouseSensitivity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "SetShadowDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "SetMasterVolume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(PlayerPrefs), Member = "TrySetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(PlayerPrefsException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600087D")]
	public static void SetFloat(string key, float value) { }

	[Address(RVA = "0x196B1C0", Offset = "0x196A3C0", Length = "0x67")]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "SetTextureQuality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "SetDebugLogLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "SetUISize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "SetFullscreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "SetQualityLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "SetPixelLightCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "SetShadowResolution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "SetVSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "SetAntiAliasing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "SetAnisotropicFiltering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "SetPostProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(PlayerPrefsException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerPrefs), Member = "TrySetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600087B")]
	public static void SetInt(string key, int value) { }

	[Address(RVA = "0x196B230", Offset = "0x196A430", Length = "0x67")]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "set_LastBrowsedFolder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "OnOperationSuccessful", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.String[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "OnOperationCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Authenticators.DeviceAuthenticator", Member = "OnClientAuthenticate", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerPrefs), Member = "TrySetSetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(PlayerPrefsException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600087F")]
	public static void SetString(string key, string value) { }

	[Address(RVA = "0x196B2F0", Offset = "0x196A4F0", Length = "0x196")]
	[CalledBy(Type = typeof(PlayerPrefs), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod("SetFloat")]
	[Token(Token = "0x6000879")]
	private static bool TrySetFloat(string key, float value) { }

	[Address(RVA = "0x196B2A0", Offset = "0x196A4A0", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000882")]
	private static bool TrySetFloat_Injected(ref ManagedSpanWrapper key, float value) { }

	[Address(RVA = "0x196B4D0", Offset = "0x196A6D0", Length = "0x190")]
	[CalledBy(Type = typeof(PlayerPrefs), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod("SetInt")]
	[Token(Token = "0x6000878")]
	private static bool TrySetInt(string key, int value) { }

	[Address(RVA = "0x196B490", Offset = "0x196A690", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000881")]
	private static bool TrySetInt_Injected(ref ManagedSpanWrapper key, int value) { }

	[Address(RVA = "0x196B6C0", Offset = "0x196A8C0", Length = "0x284")]
	[CalledBy(Type = typeof(PlayerPrefs), Member = "SetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod("SetString")]
	[Token(Token = "0x600087A")]
	private static bool TrySetSetString(string key, string value) { }

	[Address(RVA = "0x196B670", Offset = "0x196A870", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000883")]
	private static bool TrySetSetString_Injected(ref ManagedSpanWrapper key, ref ManagedSpanWrapper value) { }

}

