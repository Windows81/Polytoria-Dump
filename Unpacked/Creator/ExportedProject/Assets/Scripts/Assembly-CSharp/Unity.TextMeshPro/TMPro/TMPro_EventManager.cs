namespace TMPro;

[Token(Token = "0x200001C")]
public static class TMPro_EventManager
{
	[Token(Token = "0x40000A5")]
	public static readonly FastAction<Object, Compute_DT_EventArgs> COMPUTE_DT_EVENT; //Field offset: 0x0
	[Token(Token = "0x40000A6")]
	public static readonly FastAction<Boolean, Material> MATERIAL_PROPERTY_EVENT; //Field offset: 0x8
	[Token(Token = "0x40000A7")]
	public static readonly FastAction<Boolean, Object> FONT_PROPERTY_EVENT; //Field offset: 0x10
	[Token(Token = "0x40000A8")]
	public static readonly FastAction<Boolean, Object> SPRITE_ASSET_PROPERTY_EVENT; //Field offset: 0x18
	[Token(Token = "0x40000A9")]
	public static readonly FastAction<Boolean, Object> TEXTMESHPRO_PROPERTY_EVENT; //Field offset: 0x20
	[Token(Token = "0x40000AA")]
	public static readonly FastAction<GameObject, Material, Material> DRAG_AND_DROP_MATERIAL_EVENT; //Field offset: 0x28
	[Token(Token = "0x40000AB")]
	public static readonly FastAction<Boolean> TEXT_STYLE_PROPERTY_EVENT; //Field offset: 0x30
	[Token(Token = "0x40000AC")]
	public static readonly FastAction<Object> COLOR_GRADIENT_PROPERTY_EVENT; //Field offset: 0x38
	[Token(Token = "0x40000AD")]
	public static readonly FastAction TMP_SETTINGS_PROPERTY_EVENT; //Field offset: 0x40
	[Token(Token = "0x40000AE")]
	public static readonly FastAction RESOURCE_LOAD_EVENT; //Field offset: 0x48
	[Token(Token = "0x40000AF")]
	public static readonly FastAction<Boolean, Object> TEXTMESHPRO_UGUI_PROPERTY_EVENT; //Field offset: 0x50
	[Token(Token = "0x40000B0")]
	public static readonly FastAction<Object> TEXT_CHANGED_EVENT; //Field offset: 0x58

	[Address(RVA = "0x189E840", Offset = "0x189DA40", Length = "0x430")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(FastAction`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(FastAction`3), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(FastAction`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(FastAction), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000123")]
	private static TMPro_EventManager() { }

	[Address(RVA = "0x189E200", Offset = "0x189D400", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMPro.FastAction`1<System.Object>), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600011D")]
	public static void ON_COLOR_GRADIENT_PROPERTY_CHANGED(object obj) { }

	[Address(RVA = "0x189E280", Offset = "0x189D480", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMPro.FastAction`2<System.Object, System.Object>), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000122")]
	public static void ON_COMPUTE_DT_EVENT(object Sender, Compute_DT_EventArgs e) { }

	[Address(RVA = "0x189E310", Offset = "0x189D510", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FastAction`3), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"A", "B", "C"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600011B")]
	public static void ON_DRAG_AND_DROP_MATERIAL_CHANGED(GameObject sender, Material currentMaterial, Material newMaterial) { }

	[Address(RVA = "0x189E3B0", Offset = "0x189D5B0", Length = "0x89")]
	[CalledBy(Type = typeof(TMP_ResourceManager), Member = "RebuildFontAssetCache", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FastAction`2), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"A", "B"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000118")]
	public static void ON_FONT_PROPERTY_CHANGED(bool isChanged, object obj) { }

	[Address(RVA = "0x189E440", Offset = "0x189D640", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FastAction`2), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"A", "B"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000117")]
	public static void ON_MATERIAL_PROPERTY_CHANGED(bool isChanged, Material mat) { }

	[Address(RVA = "0x189E4D0", Offset = "0x189D6D0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FastAction), Member = "Call", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000120")]
	public static void ON_RESOURCES_LOADED() { }

	[Address(RVA = "0x189E530", Offset = "0x189D730", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FastAction`2), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"A", "B"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000119")]
	public static void ON_SPRITE_ASSET_PROPERTY_CHANGED(bool isChanged, object obj) { }

	[Address(RVA = "0x189E6E0", Offset = "0x189D8E0", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMPro.FastAction`1<System.Object>), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600011E")]
	public static void ON_TEXT_CHANGED(object obj) { }

	[Address(RVA = "0x189E760", Offset = "0x189D960", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FastAction`1), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"A"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600011C")]
	public static void ON_TEXT_STYLE_PROPERTY_CHANGED(bool isChanged) { }

	[Address(RVA = "0x189E5C0", Offset = "0x189D7C0", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FastAction`2), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"A", "B"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600011A")]
	public static void ON_TEXTMESHPRO_PROPERTY_CHANGED(bool isChanged, object obj) { }

	[Address(RVA = "0x189E650", Offset = "0x189D850", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FastAction`2), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"A", "B"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000121")]
	public static void ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED(bool isChanged, object obj) { }

	[Address(RVA = "0x189E7E0", Offset = "0x189D9E0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FastAction), Member = "Call", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600011F")]
	public static void ON_TMP_SETTINGS_CHANGED() { }

}

