namespace UnityEngine;

[Token(Token = "0x200002A")]
internal class RuntimeTextSettings : TextSettings
{
	[Token(Token = "0x4000104")]
	private static RuntimeTextSettings s_DefaultTextSettings; //Field offset: 0x0
	[Token(Token = "0x4000105")]
	private static List<FontAsset> s_FallbackOSFontAssetIMGUIInternal; //Field offset: 0x8

	[Token(Token = "0x17000086")]
	internal static RuntimeTextSettings defaultTextSettings
	{
		[Address(RVA = "0x19C2C70", Offset = "0x19C1E70", Length = "0xBB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600026F")]
		internal get { } //Length: 187
	}

	[Address(RVA = "0x19C2C60", Offset = "0x19C1E60", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextSettings), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000272")]
	public RuntimeTextSettings() { }

	[Address(RVA = "0x19C2C70", Offset = "0x19C1E70", Length = "0xBB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600026F")]
	internal static RuntimeTextSettings get_defaultTextSettings() { }

	[Address(RVA = "0x19C2BC0", Offset = "0x19C1DC0", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000270")]
	internal virtual List<FontAsset> GetStaticFallbackOSFontAsset() { }

	[Address(RVA = "0x19C2C00", Offset = "0x19C1E00", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000271")]
	internal virtual void SetStaticFallbackOSFontAsset(List<FontAsset> fontAssets) { }

}

