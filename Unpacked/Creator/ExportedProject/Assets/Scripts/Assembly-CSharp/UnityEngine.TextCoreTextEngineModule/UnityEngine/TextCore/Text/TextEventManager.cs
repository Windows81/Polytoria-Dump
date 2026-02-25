namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000043")]
public static class TextEventManager
{
	[Token(Token = "0x40001C7")]
	public static readonly FastAction<Boolean, Material> MATERIAL_PROPERTY_EVENT; //Field offset: 0x0
	[Token(Token = "0x40001C8")]
	public static readonly FastAction<Boolean, Object> FONT_PROPERTY_EVENT; //Field offset: 0x8
	[Token(Token = "0x40001C9")]
	public static readonly FastAction<Boolean, Object> SPRITE_ASSET_PROPERTY_EVENT; //Field offset: 0x10
	[Token(Token = "0x40001CA")]
	public static readonly FastAction<Boolean, Object> TEXTMESHPRO_PROPERTY_EVENT; //Field offset: 0x18
	[Token(Token = "0x40001CB")]
	public static readonly FastAction<GameObject, Material, Material> DRAG_AND_DROP_MATERIAL_EVENT; //Field offset: 0x20
	[Token(Token = "0x40001CC")]
	public static readonly FastAction<Boolean> TEXT_STYLE_PROPERTY_EVENT; //Field offset: 0x28
	[Token(Token = "0x40001CD")]
	public static readonly FastAction<Object> COLOR_GRADIENT_PROPERTY_EVENT; //Field offset: 0x30
	[Token(Token = "0x40001CE")]
	public static readonly FastAction TMP_SETTINGS_PROPERTY_EVENT; //Field offset: 0x38
	[Token(Token = "0x40001CF")]
	public static readonly FastAction RESOURCE_LOAD_EVENT; //Field offset: 0x40
	[Token(Token = "0x40001D0")]
	public static readonly FastAction<Boolean, Object> TEXTMESHPRO_UGUI_PROPERTY_EVENT; //Field offset: 0x48
	[Token(Token = "0x40001D1")]
	public static readonly FastAction OnPreRenderObject_Event; //Field offset: 0x50
	[Token(Token = "0x40001D2")]
	public static readonly FastAction<Object> TEXT_CHANGED_EVENT; //Field offset: 0x58

	[Address(RVA = "0x1A5E800", Offset = "0x1A5DA00", Length = "0x413")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(FastAction`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(FastAction), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60001B2")]
	private static TextEventManager() { }

	[Address(RVA = "0x1A5E770", Offset = "0x1A5D970", Length = "0x89")]
	[CalledBy(Type = typeof(FontAsset), Member = "ClearFontAssetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FastAction`2), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"A", "B"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001B1")]
	public static void ON_FONT_PROPERTY_CHANGED(bool isChanged, object font) { }

}

