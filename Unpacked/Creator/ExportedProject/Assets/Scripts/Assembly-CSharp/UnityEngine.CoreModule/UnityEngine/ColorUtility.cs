namespace UnityEngine;

[NativeHeader("Runtime/Math/ColorUtility.h")]
[Token(Token = "0x20000F5")]
public class ColorUtility
{

	[Address(RVA = "0x19424F0", Offset = "0x19416F0", Length = "0x192")]
	[CalledBy(Type = typeof(ColorUtility), Member = "TryParseHtmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("TryParseHtmlColor", True)]
	[Token(Token = "0x6000705")]
	internal static bool DoTryParseHtmlColor(string htmlString, out Color32 color) { }

	[Address(RVA = "0x19424A0", Offset = "0x19416A0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000709")]
	private static bool DoTryParseHtmlColor_Injected(ref ManagedSpanWrapper htmlString, out Color32 color) { }

	[Address(RVA = "0x1942A30", Offset = "0x1941C30", Length = "0x1BA")]
	[CalledBy(Type = "Polytoria.UI.ChatWindow", Member = "PushChat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000707")]
	public static string ToHtmlStringRGB(Color color) { }

	[Address(RVA = "0x1942690", Offset = "0x1941890", Length = "0x391")]
	[CalledBy(Type = "namudev.PropertyGridColor", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "namudev.PropertyGridColor", Member = "OnValueChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "namudev.PropertyGridColor", Member = "OnEndEditHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemColor", Member = "OnValueChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemColor", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Token(Token = "0x6000708")]
	public static string ToHtmlStringRGBA(Color color) { }

	[Address(RVA = "0x1942BF0", Offset = "0x1941DF0", Length = "0x96")]
	[CalledBy(Type = "namudev.PropertyGridColor", Member = "OnValueChangeHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Lua.LuaColor3", Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Color))]
	[CalledBy(Type = "Polytoria.Datamodel.Player+<LoadMetadata>d__205", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemColor", Member = "OnHexInputValueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.AppearanceLoaderBase+<ProcessAppearance>d__57", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "XmlConvertColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"U8Xml.XmlNode"}, ReturnType = typeof(Color))]
	[CalledBy(Type = "UnityEngine.TextCore.RichTextTagParser", Member = "FindTags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Collections.Generic.List`1<ParseError>"}, ReturnType = "System.Collections.Generic.List`1<Tag>")]
	[CalledBy(Type = "HSVPicker.HexColorField", Member = "UpdateColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(ColorUtility), Member = "DoTryParseHtmlColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color32&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000706")]
	public static bool TryParseHtmlString(string htmlString, out Color color) { }

}

