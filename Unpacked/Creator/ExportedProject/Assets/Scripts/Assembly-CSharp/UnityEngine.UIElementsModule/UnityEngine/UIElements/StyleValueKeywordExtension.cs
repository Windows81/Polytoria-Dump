namespace UnityEngine.UIElements;

[Extension]
[Token(Token = "0x2000468")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal static class StyleValueKeywordExtension
{

	[Address(RVA = "0x1B2D770", Offset = "0x1B2C970", Length = "0x98")]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleEnumType), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadBackgroundRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BackgroundRepeat))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "TryReadEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleEnumType), typeof(StylePropertyValue), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleEnumType), typeof(StylePropertyValue)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadBackgroundRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StylePropertyValue), typeof(StylePropertyValue)}, ReturnType = typeof(BackgroundRepeat))]
	[CalledBy(Type = typeof(StyleSheetExtensions), Member = "ReadAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleValueHandle)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(StylePropertyValueMatcher), Member = "MatchKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsInvalidInstructions]
	[Extension]
	[Token(Token = "0x60020FF")]
	public static string ToUssString(StyleValueKeyword svk) { }

}

