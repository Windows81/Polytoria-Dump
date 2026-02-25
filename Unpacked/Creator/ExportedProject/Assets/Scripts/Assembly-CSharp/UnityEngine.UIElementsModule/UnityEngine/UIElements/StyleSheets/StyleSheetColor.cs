namespace UnityEngine.UIElements.StyleSheets;

[Token(Token = "0x2000608")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal static class StyleSheetColor
{
	[Token(Token = "0x400167F")]
	private static Dictionary<String, Color32> s_NameToColor; //Field offset: 0x0

	[Address(RVA = "0x1BC8050", Offset = "0x1BC7250", Length = "0x1ADF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.Color32>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Color32)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002A81")]
	private static StyleSheetColor() { }

	[Address(RVA = "0x1BC7F20", Offset = "0x1BC7120", Length = "0x20")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6002A80")]
	private static Color32 HexToColor32(uint color) { }

	[Address(RVA = "0x1BC7F40", Offset = "0x1BC7140", Length = "0x103")]
	[CalledBy(Type = typeof(StyleSheet), Member = "ReadColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(Color))]
	[CalledBy(Type = typeof(StyleSheet), Member = "TryReadColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle), typeof(Color&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002A7F")]
	public static bool TryGetColor(string name, out Color color) { }

}

