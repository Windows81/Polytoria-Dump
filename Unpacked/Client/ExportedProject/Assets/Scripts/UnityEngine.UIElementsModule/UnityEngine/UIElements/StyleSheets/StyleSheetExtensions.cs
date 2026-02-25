namespace UnityEngine.UIElements.StyleSheets;

[Extension]
[Token(Token = "0x2000609")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal static class StyleSheetExtensions
{

	[Address(RVA = "0x1BC9B30", Offset = "0x1BC8D30", Length = "0x350")]
	[CalledBy(Type = typeof(CustomStyleAccess), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.CustomStyleProperty`1<System.String>), typeof(String&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(StylePropertyValueMatcher), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.StylePropertyValue>)}, ReturnType = typeof(MatchResult))]
	[CalledBy(Type = typeof(StylePropertyValueMatcher), Member = "MatchColor", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyValueMatcher), Member = "MatchCustomIdent", ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(StyleSheet), Member = "ReadAssetReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(Object))]
	[Calls(Type = typeof(StyleSheet), Member = "ReadEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StyleSheet), Member = "ReadVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StyleSheet), Member = "ReadString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Dimension), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(StyleSheet), Member = "ReadScalableImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(ScalableImage))]
	[Calls(Type = typeof(ScalableImage), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(StyleSheet), Member = "ReadResourcePath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(StyleSheet), Member = "ReadFunctionName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180E29EF0")]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StyleSheet), Member = "ReadDimension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(Dimension))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StyleSheet), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(StyleValueKeywordExtension), Member = "ToUssString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueKeyword)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(StyleSheet), Member = "ReadColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[Extension]
	[Token(Token = "0x6002A82")]
	public static string ReadAsString(StyleSheet sheet, StyleValueHandle handle) { }

}

