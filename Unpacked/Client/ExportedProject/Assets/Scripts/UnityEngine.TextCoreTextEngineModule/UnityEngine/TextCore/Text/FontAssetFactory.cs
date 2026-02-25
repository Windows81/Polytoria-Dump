namespace UnityEngine.TextCore.Text;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x2000030")]
internal class FontAssetFactory
{
	[Token(Token = "0x4000142")]
	private static readonly HashSet<FontAsset> visitedFontAssets; //Field offset: 0x0

	[Address(RVA = "0x1A243D0", Offset = "0x1A235D0", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600011F")]
	private static FontAssetFactory() { }

	[Address(RVA = "0x1A24090", Offset = "0x1A23290", Length = "0x1D2")]
	[CalledBy(Type = typeof(TextSettings), Member = "GetCachedFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(FontAsset))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(FontAsset))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAssetFactory), Member = "SetHideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600011C")]
	internal static FontAsset ConvertFontToFontAsset(Font font) { }

	[Address(RVA = "0x1A24270", Offset = "0x1A23470", Length = "0xB1")]
	[CalledBy(Type = typeof(FontAsset), Member = "CreateFontAssetFromFamilyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(FontAsset))]
	[CalledBy(Type = typeof(FontAssetFactory), Member = "ConvertFontToFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(FontAsset))]
	[CalledBy(Type = typeof(FontAssetFactory), Member = "SetupFontAssetSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600011E")]
	public static void SetHideFlags(FontAsset fontAsset) { }

	[Address(RVA = "0x1A24330", Offset = "0x1A23530", Length = "0x91")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAssetFactory), Member = "SetHideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600011D")]
	internal static void SetupFontAssetSettings(FontAsset fontAsset) { }

}

