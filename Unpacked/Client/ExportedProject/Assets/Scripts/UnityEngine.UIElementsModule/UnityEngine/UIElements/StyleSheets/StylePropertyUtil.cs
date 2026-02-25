namespace UnityEngine.UIElements.StyleSheets;

[Token(Token = "0x20005F9")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal static class StylePropertyUtil
{
	[Token(Token = "0x400164C")]
	internal static readonly Dictionary<String, StylePropertyId> s_NameToId; //Field offset: 0x0
	[Token(Token = "0x400164D")]
	internal static readonly Dictionary<StylePropertyId, String> s_IdToName; //Field offset: 0x8
	[Token(Token = "0x400164E")]
	internal static readonly Dictionary<String, String> s_UssNameToCSharpName; //Field offset: 0x10
	[Token(Token = "0x400164F")]
	internal static readonly Dictionary<String, String> s_CSharpNameToUssName; //Field offset: 0x18
	[Token(Token = "0x4001650")]
	internal static readonly HashSet<StylePropertyId> s_AnimatableProperties; //Field offset: 0x20
	[Token(Token = "0x4001651")]
	internal static readonly Dictionary<StylePropertyId, UsageHints> s_AnimatableWithUsageHintProperties; //Field offset: 0x28

	[Address(RVA = "0x1BB49E0", Offset = "0x1BB3BE0", Length = "0x3C83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32Enum>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "System.Int32Enum"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32Enum>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Int32Enum>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", "System.Int32Enum"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 86)]
	[Token(Token = "0x6002A1E")]
	private static StylePropertyUtil() { }

	[Address(RVA = "0x1BB35D0", Offset = "0x1BB27D0", Length = "0x77")]
	[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "ComputeTransitionPropertyData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.ComputedTransitionProperty>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002A1D")]
	public static bool IsAnimatable(StylePropertyId id) { }

	[Address(RVA = "0x1BB3650", Offset = "0x1BB2850", Length = "0x134")]
	[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "HasTransitionProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "GetTransitionProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(StylePropertyId), typeof(ComputedTransitionProperty&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002A1C")]
	public static bool IsMatchingShorthand(StylePropertyId shorthand, StylePropertyId id) { }

	[Address(RVA = "0x1BB37B0", Offset = "0x1BB29B0", Length = "0x498")]
	[CalledBy(Type = typeof(Image), Member = "ReadCustomProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomStyle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShorthandApplicator), Member = "CompileTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(List`1<TimeValue>&), typeof(List`1<TimeValue>&), typeof(List`1<StylePropertyName>&), typeof(List`1<EasingFunction>&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleEnumType), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadBackgroundRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BackgroundRepeat))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadListEasingFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.EasingFunction>), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "TryReadEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleEnumType), typeof(StylePropertyValue), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleEnumType), typeof(StylePropertyValue)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadBackgroundRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StylePropertyValue), typeof(StylePropertyValue)}, ReturnType = typeof(BackgroundRepeat))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6002A1B")]
	public static bool TryGetEnumIntValue(StyleEnumType enumType, string value, out int intValue) { }

}

