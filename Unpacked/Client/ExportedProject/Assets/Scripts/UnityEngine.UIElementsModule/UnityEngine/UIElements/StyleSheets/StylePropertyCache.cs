namespace UnityEngine.UIElements.StyleSheets;

[Token(Token = "0x20005F6")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal static class StylePropertyCache
{
	[Token(Token = "0x40015CB")]
	internal static readonly Dictionary<String, String> s_PropertySyntaxCache; //Field offset: 0x0
	[Token(Token = "0x40015CC")]
	internal static readonly Dictionary<String, String> s_NonTerminalValues; //Field offset: 0x8

	[Address(RVA = "0x1BB2200", Offset = "0x1BB1400", Length = "0x13C8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002A1A")]
	private static StylePropertyCache() { }

	[Address(RVA = "0x1BB20E0", Offset = "0x1BB12E0", Length = "0x88")]
	[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseDataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002A19")]
	public static bool TryGetNonTerminalValue(string name, out string syntax) { }

	[Address(RVA = "0x1BB2170", Offset = "0x1BB1370", Length = "0x87")]
	[CalledBy(Type = typeof(StyleVariableResolver), Member = "ValidateResolvedValues", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleSyntaxParser), Member = "ParseProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSyntaxTokenizer)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002A18")]
	public static bool TryGetSyntax(string name, out string syntax) { }

}

