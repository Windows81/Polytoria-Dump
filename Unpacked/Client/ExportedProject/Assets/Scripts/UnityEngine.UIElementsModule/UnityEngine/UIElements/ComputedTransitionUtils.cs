namespace UnityEngine.UIElements;

[Extension]
[Token(Token = "0x20002EC")]
internal static class ComputedTransitionUtils
{
	[CompilerGenerated]
	[Token(Token = "0x20002ED")]
	private sealed class <>c
	{
		[Token(Token = "0x4000BC6")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000BC7")]
		public static Func<Single, Single> <>9__12_0; //Field offset: 0x8
		[Token(Token = "0x4000BC8")]
		public static Func<Single, Single> <>9__12_1; //Field offset: 0x10
		[Token(Token = "0x4000BC9")]
		public static Func<Single, Single> <>9__12_2; //Field offset: 0x18
		[Token(Token = "0x4000BCA")]
		public static Func<Single, Single> <>9__12_3; //Field offset: 0x20
		[Token(Token = "0x4000BCB")]
		public static Func<Single, Single> <>9__12_4; //Field offset: 0x28
		[Token(Token = "0x4000BCC")]
		public static Func<Single, Single> <>9__12_5; //Field offset: 0x30
		[Token(Token = "0x4000BCD")]
		public static Func<Single, Single> <>9__12_6; //Field offset: 0x38
		[Token(Token = "0x4000BCE")]
		public static Func<Single, Single> <>9__12_7; //Field offset: 0x40
		[Token(Token = "0x4000BCF")]
		public static Func<Single, Single> <>9__12_8; //Field offset: 0x48
		[Token(Token = "0x4000BD0")]
		public static Func<Single, Single> <>9__12_9; //Field offset: 0x50
		[Token(Token = "0x4000BD1")]
		public static Func<Single, Single> <>9__12_10; //Field offset: 0x58
		[Token(Token = "0x4000BD2")]
		public static Func<Single, Single> <>9__12_11; //Field offset: 0x60
		[Token(Token = "0x4000BD3")]
		public static Func<Single, Single> <>9__12_12; //Field offset: 0x68
		[Token(Token = "0x4000BD4")]
		public static Func<Single, Single> <>9__12_13; //Field offset: 0x70
		[Token(Token = "0x4000BD5")]
		public static Func<Single, Single> <>9__12_14; //Field offset: 0x78
		[Token(Token = "0x4000BD6")]
		public static Func<Single, Single> <>9__12_15; //Field offset: 0x80
		[Token(Token = "0x4000BD7")]
		public static Func<Single, Single> <>9__12_16; //Field offset: 0x88
		[Token(Token = "0x4000BD8")]
		public static Func<Single, Single> <>9__12_17; //Field offset: 0x90
		[Token(Token = "0x4000BD9")]
		public static Func<Single, Single> <>9__12_18; //Field offset: 0x98
		[Token(Token = "0x4000BDA")]
		public static Func<Single, Single> <>9__12_19; //Field offset: 0xA0
		[Token(Token = "0x4000BDB")]
		public static Func<Single, Single> <>9__12_20; //Field offset: 0xA8
		[Token(Token = "0x4000BDC")]
		public static Func<Single, Single> <>9__12_21; //Field offset: 0xB0
		[Token(Token = "0x4000BDD")]
		public static Func<Single, Single> <>9__12_22; //Field offset: 0xB8

		[Address(RVA = "0x1AEC280", Offset = "0x1AEB480", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60014E2")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60014E3")]
		public <>c() { }

		[Address(RVA = "0x1AEC080", Offset = "0x1AEB280", Length = "0x24")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60014E4")]
		internal float <ConvertTransitionFunction>b__12_0(float t) { }

		[Address(RVA = "0x1AEC150", Offset = "0x1AEB350", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Easing), Member = "InQuad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
		[Token(Token = "0x60014E5")]
		internal float <ConvertTransitionFunction>b__12_1(float t) { }

		[Address(RVA = "0x1AEC0B0", Offset = "0x1AEB2B0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Easing), Member = "InOutCubic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
		[Token(Token = "0x60014EE")]
		internal float <ConvertTransitionFunction>b__12_10(float t) { }

		[Address(RVA = "0x1AEC0C0", Offset = "0x1AEB2C0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Easing), Member = "InCirc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
		[Token(Token = "0x60014EF")]
		internal float <ConvertTransitionFunction>b__12_11(float t) { }

		[Address(RVA = "0x1AEC0D0", Offset = "0x1AEB2D0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Easing), Member = "OutCirc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
		[Token(Token = "0x60014F0")]
		internal float <ConvertTransitionFunction>b__12_12(float t) { }

		[Address(RVA = "0x1AEC0E0", Offset = "0x1AEB2E0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Easing), Member = "InOutCirc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
		[Token(Token = "0x60014F1")]
		internal float <ConvertTransitionFunction>b__12_13(float t) { }

		[Address(RVA = "0x1AEC0F0", Offset = "0x1AEB2F0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Easing), Member = "InElastic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
		[Token(Token = "0x60014F2")]
		internal float <ConvertTransitionFunction>b__12_14(float t) { }

		[Address(RVA = "0x1AEC100", Offset = "0x1AEB300", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Easing), Member = "OutElastic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
		[Token(Token = "0x60014F3")]
		internal float <ConvertTransitionFunction>b__12_15(float t) { }

		[Address(RVA = "0x1AEC110", Offset = "0x1AEB310", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Easing), Member = "InOutElastic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
		[Token(Token = "0x60014F4")]
		internal float <ConvertTransitionFunction>b__12_16(float t) { }

		[Address(RVA = "0x1AEC120", Offset = "0x1AEB320", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Easing), Member = "InBack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
		[Token(Token = "0x60014F5")]
		internal float <ConvertTransitionFunction>b__12_17(float t) { }

		[Address(RVA = "0x1AEC130", Offset = "0x1AEB330", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Easing), Member = "OutBack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
		[Token(Token = "0x60014F6")]
		internal float <ConvertTransitionFunction>b__12_18(float t) { }

		[Address(RVA = "0x1AEC140", Offset = "0x1AEB340", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Easing), Member = "InOutBack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
		[Token(Token = "0x60014F7")]
		internal float <ConvertTransitionFunction>b__12_19(float t) { }

		[Address(RVA = "0x1AEC190", Offset = "0x1AEB390", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Easing), Member = "OutQuad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
		[Token(Token = "0x60014E6")]
		internal float <ConvertTransitionFunction>b__12_2(float t) { }

		[Address(RVA = "0x1AEC160", Offset = "0x1AEB360", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Easing), Member = "InBounce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
		[Token(Token = "0x60014F8")]
		internal float <ConvertTransitionFunction>b__12_20(float t) { }

		[Address(RVA = "0x1AEC170", Offset = "0x1AEB370", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Easing), Member = "OutBounce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
		[Token(Token = "0x60014F9")]
		internal float <ConvertTransitionFunction>b__12_21(float t) { }

		[Address(RVA = "0x1AEC180", Offset = "0x1AEB380", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Easing), Member = "InOutBounce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
		[Token(Token = "0x60014FA")]
		internal float <ConvertTransitionFunction>b__12_22(float t) { }

		[Address(RVA = "0x1AEC1A0", Offset = "0x1AEB3A0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Easing), Member = "InOutQuad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
		[Token(Token = "0x60014E7")]
		internal float <ConvertTransitionFunction>b__12_3(float t) { }

		[Address(RVA = "0x1AEC1B0", Offset = "0x1AEB3B0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60014E8")]
		internal float <ConvertTransitionFunction>b__12_4(float t) { }

		[Address(RVA = "0x1AEC1C0", Offset = "0x1AEB3C0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Easing), Member = "InSine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
		[Token(Token = "0x60014E9")]
		internal float <ConvertTransitionFunction>b__12_5(float t) { }

		[Address(RVA = "0x1AEC1D0", Offset = "0x1AEB3D0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Easing), Member = "OutSine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
		[Token(Token = "0x60014EA")]
		internal float <ConvertTransitionFunction>b__12_6(float t) { }

		[Address(RVA = "0x1AEC1E0", Offset = "0x1AEB3E0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Easing), Member = "InOutSine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
		[Token(Token = "0x60014EB")]
		internal float <ConvertTransitionFunction>b__12_7(float t) { }

		[Address(RVA = "0x1AEC1F0", Offset = "0x1AEB3F0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Easing), Member = "InCubic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
		[Token(Token = "0x60014EC")]
		internal float <ConvertTransitionFunction>b__12_8(float t) { }

		[Address(RVA = "0x1AEC200", Offset = "0x1AEB400", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Easing), Member = "OutCubic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
		[Token(Token = "0x60014ED")]
		internal float <ConvertTransitionFunction>b__12_9(float t) { }

	}

	[Token(Token = "0x4000BC5")]
	private static List<ComputedTransitionProperty> s_ComputedTransitionsBuffer; //Field offset: 0x0

	[Address(RVA = "0x1AD8820", Offset = "0x1AD7A20", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60014E1")]
	private static ComputedTransitionUtils() { }

	[Address(RVA = "0x1AD6560", Offset = "0x1AD5760", Length = "0x30B")]
	[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "UpdateComputedTransitions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "GetOrComputeTransitionPropertyData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(ComputedTransitionProperty[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ComputedStyle), Member = "get_transitionTimingFunction", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.EasingFunction>))]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "GetWrappingTransitionData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>", typeof(int), "T"}, ReturnType = "T")]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "ConvertTransitionTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeValue)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "GetWrappingTransitionData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeValue)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue>), typeof(int), typeof(TimeValue)}, ReturnType = typeof(TimeValue))]
	[Calls(Type = typeof(StylePropertyUtil), Member = "IsAnimatable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(ComputedStyle), Member = "get_transitionDelay", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue>))]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "ConvertTransitionFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EasingMode)}, ReturnType = typeof(System.Func`2<System.Single, System.Single>))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_transitionDuration", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue>))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_transitionProperty", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StylePropertyName>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800CF0A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60014DD")]
	private static void ComputeTransitionPropertyData(ref ComputedStyle computedStyle, List<ComputedTransitionProperty> outData) { }

	[Address(RVA = "0x1AD6870", Offset = "0x1AD5A70", Length = "0x160")]
	[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "ComputeTransitionPropertyData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.ComputedTransitionProperty>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60014E0")]
	private static Func<Single, Single> ConvertTransitionFunction(EasingMode mode) { }

	[Address(RVA = "0x1AD7880", Offset = "0x1AD6A80", Length = "0x112")]
	[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "ComputeTransitionPropertyData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.ComputedTransitionProperty>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180288CC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802891B0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60014DF")]
	private static int ConvertTransitionTime(TimeValue time) { }

	[Address(RVA = "0x1AD79A0", Offset = "0x1AD6BA0", Length = "0x1B5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "GetTransitionHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(StyleCache), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ComputedTransitionProperty[]&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "ComputeTransitionPropertyData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.ComputedTransitionProperty>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(List`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleCache), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ComputedTransitionProperty[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60014D8")]
	private static ComputedTransitionProperty[] GetOrComputeTransitionPropertyData(ref ComputedStyle computedStyle) { }

	[Address(RVA = "0x1AD7B60", Offset = "0x1AD6D60", Length = "0x469")]
	[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "UpdateComputedTransitions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "GetOrComputeTransitionPropertyData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(ComputedTransitionProperty[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ComputedStyle), Member = "get_transitionDelay", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_transitionDuration", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue>))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_transitionProperty", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StylePropertyName>))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_transitionTimingFunction", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.EasingFunction>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Token(Token = "0x60014D9")]
	private static int GetTransitionHashCode(ref ComputedStyle cs) { }

	[Address(RVA = "0x1AD7FD0", Offset = "0x1AD71D0", Length = "0x132")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundSize)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextShadow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTransformOrigin)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTranslate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleScale)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(StylePropertyUtil), Member = "IsMatchingShorthand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Extension]
	[Token(Token = "0x60014D7")]
	internal static bool GetTransitionProperty(ref ComputedStyle computedStyle, StylePropertyId id, out ComputedTransitionProperty result) { }

	[Address(RVA = "0x689AB0", Offset = "0x688CB0", Length = "0x6D")]
	[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "ComputeTransitionPropertyData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.ComputedTransitionProperty>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60014DE")]
	private static T GetWrappingTransitionData(List<T> list, int i, T defaultValue) { }

	[Address(RVA = "0x1AD8110", Offset = "0x1AD7310", Length = "0xD3")]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "CancelAnimationsWithNoTransitionProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StylePropertyUtil), Member = "IsMatchingShorthand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StylePropertyId)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Extension]
	[Token(Token = "0x60014D6")]
	internal static bool HasTransitionProperty(ref ComputedStyle computedStyle, StylePropertyId id) { }

	[Address(RVA = "0x1AD8310", Offset = "0x1AD7510", Length = "0x1FB")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ComputedStyle), Member = "get_transitionProperty", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StylePropertyName>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(StylePropertyName), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyName), typeof(StylePropertyName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_transitionDuration", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue>))]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "SameTransitionProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_transitionDelay", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue>))]
	[Token(Token = "0x60014DA")]
	internal static bool SameTransitionProperty(ref ComputedStyle x, ref ComputedStyle y) { }

	[Address(RVA = "0x1AD81F0", Offset = "0x1AD73F0", Length = "0x11E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(StylePropertyName), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyName), typeof(StylePropertyName)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60014DB")]
	private static bool SameTransitionProperty(List<StylePropertyName> a, List<StylePropertyName> b) { }

	[Address(RVA = "0x1AD8510", Offset = "0x1AD7710", Length = "0xFA")]
	[CalledBy(Type = typeof(ComputedTransitionUtils), Member = "SameTransitionProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60014DC")]
	private static bool SameTransitionProperty(List<TimeValue> a, List<TimeValue> b) { }

	[Address(RVA = "0x1AD8610", Offset = "0x1AD7810", Length = "0x204")]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeStyleUpdater), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyFromComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundSize)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTranslate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTransformOrigin)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextShadow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleScale)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(StyleCache), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ComputedTransitionProperty[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "ComputeTransitionPropertyData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.ComputedTransitionProperty>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ComputedTransitionUtils), Member = "GetTransitionHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(StyleCache), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ComputedTransitionProperty[]&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60014D5")]
	internal static void UpdateComputedTransitions(ref ComputedStyle computedStyle) { }

}

