namespace TMPro;

[Token(Token = "0x2000058")]
public static class TMP_FontUtilities
{
	[Token(Token = "0x4000263")]
	private static List<Int32> k_searchedFontAssets; //Field offset: 0x0

	[Address(RVA = "0x18A2910", Offset = "0x18A1B10", Length = "0xFE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TMP_FontUtilities), Member = "SearchForCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset), typeof(uint), typeof(TMP_Character&)}, ReturnType = typeof(TMP_FontAsset))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002BC")]
	public static TMP_FontAsset SearchForCharacter(TMP_FontAsset font, uint unicode, out TMP_Character character) { }

	[Address(RVA = "0x18A2820", Offset = "0x18A1A20", Length = "0xED")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TMP_FontUtilities), Member = "SearchForCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset), typeof(uint), typeof(TMP_Character&)}, ReturnType = typeof(TMP_FontAsset))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002BD")]
	public static TMP_FontAsset SearchForCharacter(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character) { }

	[Address(RVA = "0x18A2470", Offset = "0x18A1670", Length = "0x2B1")]
	[CalledBy(Type = typeof(TMP_FontUtilities), Member = "SearchForCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset), typeof(uint), typeof(TMP_Character&)}, ReturnType = typeof(TMP_FontAsset))]
	[CalledBy(Type = typeof(TMP_FontUtilities), Member = "SearchForCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<TMPro.TMP_FontAsset>), typeof(uint), typeof(TMP_Character&)}, ReturnType = typeof(TMP_FontAsset))]
	[CalledBy(Type = typeof(TMP_FontUtilities), Member = "SearchForCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset), typeof(uint), typeof(TMP_Character&)}, ReturnType = typeof(TMP_FontAsset))]
	[CalledBy(Type = typeof(TMP_FontUtilities), Member = "SearchForCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<TMPro.TMP_FontAsset>), typeof(uint), typeof(TMP_Character&)}, ReturnType = typeof(TMP_FontAsset))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009740")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_FontAsset), Member = "get_characterLookupTable", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, TMPro.TMP_Character>))]
	[Calls(Type = typeof(TMP_FontUtilities), Member = "SearchForCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset), typeof(uint), typeof(TMP_Character&)}, ReturnType = typeof(TMP_FontAsset))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002BE")]
	private static TMP_FontAsset SearchForCharacterInternal(TMP_FontAsset font, uint unicode, out TMP_Character character) { }

	[Address(RVA = "0x18A2730", Offset = "0x18A1930", Length = "0xE6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TMP_FontUtilities), Member = "SearchForCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset), typeof(uint), typeof(TMP_Character&)}, ReturnType = typeof(TMP_FontAsset))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002BF")]
	private static TMP_FontAsset SearchForCharacterInternal(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character) { }

}

