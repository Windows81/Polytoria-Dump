namespace UnityEngine.UIElements;

[HelpURL("UIE-text-setting-asset")]
[Token(Token = "0x200047B")]
public class PanelTextSettings : TextSettings
{
	[Token(Token = "0x4000EF7")]
	private static PanelTextSettings s_DefaultPanelTextSettings; //Field offset: 0x0

	[Token(Token = "0x170008E0")]
	internal static PanelTextSettings defaultPanelTextSettings
	{
		[Address(RVA = "0x1B26F60", Offset = "0x1B26160", Length = "0xD7")]
		[CalledBy(Type = typeof(TextUtilities), Member = "GetFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(FontAsset))]
		[CalledBy(Type = typeof(TextUtilities), Member = "GetTextSettingsFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(TextSettings))]
		[CalledBy(Type = typeof(UITKTextJobSystem), Member = "GenerateTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6002182")]
		internal get { } //Length: 215
	}

	[Address(RVA = "0x19C2C60", Offset = "0x19C1E60", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextSettings), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002184")]
	public PanelTextSettings() { }

	[Address(RVA = "0x1B26F60", Offset = "0x1B26160", Length = "0xD7")]
	[CalledBy(Type = typeof(TextUtilities), Member = "GetFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(FontAsset))]
	[CalledBy(Type = typeof(TextUtilities), Member = "GetTextSettingsFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(TextSettings))]
	[CalledBy(Type = typeof(UITKTextJobSystem), Member = "GenerateTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002182")]
	internal static PanelTextSettings get_defaultPanelTextSettings() { }

	[Address(RVA = "0x1B26EB0", Offset = "0x1B260B0", Length = "0xAF")]
	[CalledBy(Type = typeof(UITKTextJobSystem), Member = "PrepareTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002183")]
	internal static void InitializeDefaultPanelTextSettingsIfNull() { }

}

