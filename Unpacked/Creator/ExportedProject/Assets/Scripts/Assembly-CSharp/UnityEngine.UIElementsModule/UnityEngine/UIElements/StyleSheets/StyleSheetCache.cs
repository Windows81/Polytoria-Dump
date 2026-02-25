namespace UnityEngine.UIElements.StyleSheets;

[Token(Token = "0x2000605")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal static class StyleSheetCache
{
	[Token(Token = "0x2000606")]
	private struct SheetHandleKey
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400167D")]
		public readonly int sheetInstanceID; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400167E")]
		public readonly int index; //Field offset: 0x4

		[Address(RVA = "0x1BC0680", Offset = "0x1BBF880", Length = "0x37")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002A7B")]
		public SheetHandleKey(StyleSheet sheet, int index) { }

	}

	[Token(Token = "0x2000607")]
	private class SheetHandleKeyComparer : IEqualityComparer<SheetHandleKey>
	{

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A7E")]
		public SheetHandleKeyComparer() { }

		[Address(RVA = "0x1BC0630", Offset = "0x1BBF830", Length = "0x17")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002A7C")]
		public override bool Equals(SheetHandleKey x, SheetHandleKey y) { }

		[Address(RVA = "0x1BC0650", Offset = "0x1BBF850", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6002A7D")]
		public override int GetHashCode(SheetHandleKey key) { }

	}

	[Token(Token = "0x400167B")]
	private static SheetHandleKeyComparer s_Comparer; //Field offset: 0x0
	[Token(Token = "0x400167C")]
	private static Dictionary<SheetHandleKey, StylePropertyId[]> s_RulePropertyIdsCache; //Field offset: 0x8

	[Address(RVA = "0x1BC7E20", Offset = "0x1BC7020", Length = "0xF2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.StyleSheets.StyleSheetCache+SheetHandleKey, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEqualityComparer`1<UnityEngine.UIElements.StyleSheets.StyleSheetCache+SheetHandleKey>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002A7A")]
	private static StyleSheetCache() { }

	[Address(RVA = "0x1BC7A70", Offset = "0x1BC6C70", Length = "0xEC")]
	[CalledBy(Type = typeof(StyleSheetCache), Member = "GetPropertyIds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(int)}, ReturnType = typeof(StylePropertyId[]))]
	[CalledBy(Type = typeof(StyleSheetCache), Member = "GetPropertyIds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRule)}, ReturnType = typeof(StylePropertyId[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002A79")]
	private static StylePropertyId GetPropertyId(StyleRule rule, int index) { }

	[Address(RVA = "0x1BC7B60", Offset = "0x1BC6D60", Length = "0x1DE")]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "SetContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleComplexSelector), typeof(StyleVariableContext), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.StyleSheets.StyleSheetCache+SheetHandleKey, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SheetHandleKey), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(StyleSheetCache), Member = "GetPropertyId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRule), typeof(int)}, ReturnType = typeof(StylePropertyId))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.StyleSheets.StyleSheetCache+SheetHandleKey, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SheetHandleKey), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002A77")]
	internal static StylePropertyId[] GetPropertyIds(StyleSheet sheet, int ruleIndex) { }

	[Address(RVA = "0x1BC7D40", Offset = "0x1BC6F40", Length = "0xD2")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleRule)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StyleSheetCache), Member = "GetPropertyId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRule), typeof(int)}, ReturnType = typeof(StylePropertyId))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002A78")]
	internal static StylePropertyId[] GetPropertyIds(StyleRule rule) { }

}

