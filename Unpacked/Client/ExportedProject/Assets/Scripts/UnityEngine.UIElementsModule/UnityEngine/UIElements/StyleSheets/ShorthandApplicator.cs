namespace UnityEngine.UIElements.StyleSheets;

[Token(Token = "0x20005F5")]
[VisibleToOtherModules]
internal static class ShorthandApplicator
{
	[Token(Token = "0x40015C7")]
	private static List<TimeValue> s_TransitionDelayList; //Field offset: 0x0
	[Token(Token = "0x40015C8")]
	private static List<TimeValue> s_TransitionDurationList; //Field offset: 0x8
	[Token(Token = "0x40015C9")]
	private static List<StylePropertyName> s_TransitionPropertyList; //Field offset: 0x10
	[Token(Token = "0x40015CA")]
	private static List<EasingFunction> s_TransitionTimingFunctionList; //Field offset: 0x18

	[Address(RVA = "0x1BB1F40", Offset = "0x1BB1140", Length = "0x192")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6002A16")]
	private static ShorthandApplicator() { }

	[Address(RVA = "0x1BB1F30", Offset = "0x1BB1130", Length = "0xB")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6002A17")]
	internal static void <CompileBackgroundPosition>g__SwapKeyword|16_0(ref BackgroundPositionKeyword a, ref BackgroundPositionKeyword b) { }

	[Address(RVA = "0x1BAF470", Offset = "0x1BAE670", Length = "0xC4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ShorthandApplicator), Member = "CompileBackgroundPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(BackgroundPosition&), typeof(BackgroundPosition&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.VisualData>), Member = "Write", ReturnType = typeof(VisualData&))]
	[Token(Token = "0x6002A03")]
	public static void ApplyBackgroundPosition(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	[Address(RVA = "0x1BAF540", Offset = "0x1BAE740", Length = "0x220")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.VisualData>), Member = "Write", ReturnType = typeof(VisualData&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002A04")]
	public static void ApplyBorderColor(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	[Address(RVA = "0x1BAF770", Offset = "0x1BAE970", Length = "0x1D8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ShorthandApplicator), Member = "CompileBoxArea", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(Length&), typeof(Length&), typeof(Length&), typeof(Length&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Length), Member = "IsAuto", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Length), Member = "IsNone", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Length), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Length))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.VisualData>), Member = "Write", ReturnType = typeof(VisualData&))]
	[Token(Token = "0x6002A05")]
	public static void ApplyBorderRadius(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	[Address(RVA = "0x1BAF950", Offset = "0x1BAEB50", Length = "0x237")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Length), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Length))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Length))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.LayoutData>), Member = "Write", ReturnType = typeof(LayoutData&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002A06")]
	public static void ApplyBorderWidth(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	[Address(RVA = "0x1BAFB90", Offset = "0x1BAED90", Length = "0xE0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ShorthandApplicator), Member = "CompileFlexShorthand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(Single&), typeof(Single&), typeof(Length&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.LayoutData>), Member = "Write", ReturnType = typeof(LayoutData&))]
	[Token(Token = "0x6002A07")]
	public static void ApplyFlex(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	[Address(RVA = "0x1BAFC70", Offset = "0x1BAEE70", Length = "0x1E2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Length), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Length))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Length))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.LayoutData>), Member = "Write", ReturnType = typeof(LayoutData&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002A08")]
	public static void ApplyMargin(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	[Address(RVA = "0x1BAFE60", Offset = "0x1BAF060", Length = "0x1EE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Length), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Length))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Length))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.LayoutData>), Member = "Write", ReturnType = typeof(LayoutData&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002A09")]
	public static void ApplyPadding(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	[Address(RVA = "0x1BB0050", Offset = "0x1BAF250", Length = "0x145")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ShorthandApplicator), Member = "CompileTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(List`1<TimeValue>&), typeof(List`1<TimeValue>&), typeof(List`1<StylePropertyName>&), typeof(List`1<EasingFunction>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.TransitionData>), Member = "Write", ReturnType = typeof(TransitionData&))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "CopyFrom", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeValue)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "CopyFrom", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyName)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StylePropertyName>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StylePropertyName>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "CopyFrom", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>", "System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Token(Token = "0x6002A0A")]
	public static void ApplyTransition(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	[Address(RVA = "0x1BB01A0", Offset = "0x1BAF3A0", Length = "0x16A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleEnumType), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BackgroundPropertyHelper), Member = "ConvertScaleModeToBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleMode)}, ReturnType = typeof(BackgroundSize))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleDataRef`1<UnityEngine.UIElements.VisualData>), Member = "Write", ReturnType = typeof(VisualData&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6002A0B")]
	public static void ApplyUnityBackgroundScaleMode(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	[Address(RVA = "0x1BB0310", Offset = "0x1BAF510", Length = "0x115")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StylePropertyReader), Member = "GetValueType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StyleValueType))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Write", ReturnType = "T&")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002A0C")]
	public static void ApplyUnityTextOutline(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	[Address(RVA = "0x1BB0430", Offset = "0x1BAF630", Length = "0x6A6")]
	[CalledBy(Type = typeof(ShorthandApplicator), Member = "ApplyBackgroundPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StylePropertyReader), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StylePropertyValue))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleEnumType), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Length))]
	[Calls(Type = typeof(BackgroundPosition), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundPositionKeyword)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StyleSheet), Member = "ReadDimension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(Dimension))]
	[Calls(Type = typeof(Dimension), Member = "ToLength", ReturnType = typeof(Length))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 24)]
	[Token(Token = "0x6002A0F")]
	private static void CompileBackgroundPosition(StylePropertyReader reader, out BackgroundPosition backgroundPositionX, out BackgroundPosition backgroundPositionY) { }

	[Address(RVA = "0x1BB0AE0", Offset = "0x1BAFCE0", Length = "0x13A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ShorthandApplicator), Member = "CompileBoxArea", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(Length&), typeof(Length&), typeof(Length&), typeof(Length&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Length), Member = "IsAuto", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Length), Member = "IsNone", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Length), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Length))]
	[Token(Token = "0x6002A0E")]
	private static void CompileBorderRadius(StylePropertyReader reader, out Length top, out Length right, out Length bottom, out Length left) { }

	[Address(RVA = "0x1BB0FB0", Offset = "0x1BB01B0", Length = "0x168")]
	[CalledBy(Type = typeof(ShorthandApplicator), Member = "ApplyBorderRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShorthandApplicator), Member = "CompileBorderRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(Length&), typeof(Length&), typeof(Length&), typeof(Length&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Length), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Length))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Length))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002A11")]
	private static void CompileBoxArea(StylePropertyReader reader, out Length top, out Length right, out Length bottom, out Length left) { }

	[Address(RVA = "0x1BB0DD0", Offset = "0x1BAFFD0", Length = "0x1D6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Length), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Length))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Length))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002A12")]
	private static void CompileBoxArea(StylePropertyReader reader, out float top, out float right, out float bottom, out float left) { }

	[Address(RVA = "0x1BB0C20", Offset = "0x1BAFE20", Length = "0x1A5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002A13")]
	private static void CompileBoxArea(StylePropertyReader reader, out Color top, out Color right, out Color bottom, out Color left) { }

	[Address(RVA = "0x1BB1120", Offset = "0x1BB0320", Length = "0x1F7")]
	[CalledBy(Type = typeof(ShorthandApplicator), Member = "ApplyFlex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Length), Member = "Auto", ReturnType = typeof(Length))]
	[Calls(Type = typeof(StylePropertyReader), Member = "IsValueType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StyleValueType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StylePropertyReader), Member = "IsKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StyleValueKeyword)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Length), Member = "Percent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Length))]
	[Calls(Type = typeof(StylePropertyReader), Member = "GetValueType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StyleValueType))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Length))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002A0D")]
	private static bool CompileFlexShorthand(StylePropertyReader reader, out float grow, out float shrink, out Length basis) { }

	[Address(RVA = "0x1BB1320", Offset = "0x1BB0520", Length = "0xB0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StylePropertyReader), Member = "GetValueType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StyleValueType))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002A14")]
	private static void CompileTextOutline(StylePropertyReader reader, out Color outlineColor, out float outlineWidth) { }

	[Address(RVA = "0x1BB13E0", Offset = "0x1BB05E0", Length = "0xA87")]
	[CalledBy(Type = typeof(ShorthandApplicator), Member = "ApplyTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StylePropertyReader), Member = "GetValueType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StyleValueType))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadTimeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TimeValue))]
	[Calls(Type = typeof(StylePropertyReader), Member = "IsKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StyleValueKeyword)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StylePropertyName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StylePropertyUtil), Member = "TryGetEnumIntValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleEnumType), typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(StyleDataRef`1), Member = "Read", ReturnType = "T&")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002A15")]
	private static void CompileTransition(StylePropertyReader reader, out List<TimeValue>& outDelay, out List<TimeValue>& outDuration, out List<StylePropertyName>& outProperty, out List<EasingFunction>& outTimingFunction) { }

	[Address(RVA = "0x1BB1E70", Offset = "0x1BB1070", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StylePropertyReader), Member = "ReadEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleEnumType), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BackgroundPropertyHelper), Member = "ConvertScaleModeToBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleMode)}, ReturnType = typeof(BackgroundSize))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6002A10")]
	public static void CompileUnityBackgroundScaleMode(StylePropertyReader reader, out BackgroundPosition backgroundPositionX, out BackgroundPosition backgroundPositionY, out BackgroundRepeat backgroundRepeat, out BackgroundSize backgroundSize) { }

}

