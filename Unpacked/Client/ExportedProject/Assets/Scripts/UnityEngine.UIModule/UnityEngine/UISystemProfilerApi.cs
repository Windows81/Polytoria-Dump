namespace UnityEngine;

[IgnoredByDeepProfiler]
[NativeHeader("Modules/UI/Canvas.h")]
[StaticAccessor("UI::SystemProfilerApi", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x200000A")]
public static class UISystemProfilerApi
{
	[Token(Token = "0x200000B")]
	internal enum SampleType
	{
		Layout = 0,
		Render = 1,
	}


	[Address(RVA = "0x1CB1720", Offset = "0x1CB0920", Length = "0x1A0")]
	[CalledBy(Type = "UnityEngine.UI.Scrollbar", Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Toggle", Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Slider", Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Slider", Member = "OnDidApplyAnimationProperties", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "DeactivateInputField", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "SendOnSubmit", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.MaskableGraphic", Member = "UpdateCull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "SendOnValueChanged", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Button", Member = "Press", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "SendOnEndEdit", ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600009D")]
	public static void AddMarker(string name, object obj) { }

	[Address(RVA = "0x1CB16D0", Offset = "0x1CB08D0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600009E")]
	private static void AddMarker_Injected(ref ManagedSpanWrapper name, IntPtr obj) { }

	[Address(RVA = "0x1CB18D0", Offset = "0x1CB0AD0", Length = "0x31")]
	[CalledBy(Type = "UnityEngine.UI.CanvasUpdateRegistry", Member = "PerformUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600009B")]
	public static void BeginSample(SampleType type) { }

	[Address(RVA = "0x1CB1910", Offset = "0x1CB0B10", Length = "0x31")]
	[CalledBy(Type = "UnityEngine.UI.CanvasUpdateRegistry", Member = "PerformUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600009C")]
	public static void EndSample(SampleType type) { }

}

