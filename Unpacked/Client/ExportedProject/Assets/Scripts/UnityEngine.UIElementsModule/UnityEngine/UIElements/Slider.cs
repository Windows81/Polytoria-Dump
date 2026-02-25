namespace UnityEngine.UIElements;

[Token(Token = "0x2000144")]
public class Slider : BaseSlider<Single>
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000145")]
	internal class UxmlFactory : UxmlFactory<Slider, UxmlTraits>
	{

		[Address(RVA = "0x1C2C550", Offset = "0x1C2B750", Length = "0x39")]
		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60009FD")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000146")]
	internal class UxmlTraits : UxmlTraits<Single, UxmlFloatAttributeDescription>
	{
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4000671")]
		private UxmlFloatAttributeDescription m_LowValue; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4000672")]
		private UxmlFloatAttributeDescription m_HighValue; //Field offset: 0xA8
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4000673")]
		private UxmlFloatAttributeDescription m_PageSize; //Field offset: 0xB0
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x4000674")]
		private UxmlBoolAttributeDescription m_ShowInputField; //Field offset: 0xB8
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x4000675")]
		private UxmlEnumAttributeDescription<SliderDirection> m_Direction; //Field offset: 0xC0
		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x4000676")]
		private UxmlBoolAttributeDescription m_Inverted; //Field offset: 0xC8

		[Address(RVA = "0x1C2F8F0", Offset = "0x1C2EAF0", Length = "0x2CD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UxmlFloatAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UxmlBoolAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlEnumAttributeDescription`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityEngine.UIElements.BaseSlider`1+UxmlTraits`1<System.Single, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60009FF")]
		public UxmlTraits() { }

		[Address(RVA = "0x1C2CFB0", Offset = "0x1C2C1B0", Length = "0x371")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UnityEngine.UIElements.BaseSlider`1<System.Single>), Member = "set_lowValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityEngine.UIElements.BaseSlider`1<System.Single>), Member = "set_highValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseSlider`1), Member = "set_direction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SliderDirection)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityEngine.UIElements.BaseSlider`1<System.Single>), Member = "set_inverted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseFieldTraits`2), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 8)]
		[Token(Token = "0x60009FE")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x400066E")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x400066F")]
	public static readonly string labelUssClassName; //Field offset: 0x8
	[Token(Token = "0x4000670")]
	public static readonly string inputUssClassName; //Field offset: 0x10

	[Address(RVA = "0x1C27B70", Offset = "0x1C26D70", Length = "0x112")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x60009FC")]
	private static Slider() { }

	[Address(RVA = "0x1C27DF0", Offset = "0x1C26FF0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Slider), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float), typeof(SliderDirection), typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x60009F3")]
	public Slider() { }

	[Address(RVA = "0x1C27E20", Offset = "0x1C27020", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Slider), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float), typeof(SliderDirection), typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x60009F4")]
	public Slider(float start, float end, SliderDirection direction = 0, float pageSize = 0) { }

	[Address(RVA = "0x1C27C90", Offset = "0x1C26E90", Length = "0x15C")]
	[CalledBy(Type = "UnityEngine.UIElements.Scroller+ScrollerSlider", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(SliderDirection), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scroller), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(System.Action`1<System.Single>), typeof(SliderDirection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(SliderDirection), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseSlider`1<System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float), typeof(SliderDirection), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009F5")]
	public Slider(string label, float start = 0, float end = 10, SliderDirection direction = 0, float pageSize = 0) { }

	[Address(RVA = "0x1C273A0", Offset = "0x1C265A0", Length = "0x133")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseSlider`1<System.Single>), Member = "get_highValue", ReturnType = typeof(float))]
	[Calls(Type = "UnityEngine.NumericFieldDraggerUtility", Member = "CalculateFloatDragSensitivity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[Calls(Type = "UnityEngine.NumericFieldDraggerUtility", Member = "Acceleration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(float))]
	[Calls(Type = "UnityEngine.NumericFieldDraggerUtility", Member = "NiceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60009F6")]
	public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, float startValue) { }

	[Address(RVA = "0x1C274E0", Offset = "0x1C266E0", Length = "0x23E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseSlider`1<System.Single>), Member = "get_highValue", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BaseSlider`1), Member = "GetClosestPowerOfTen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(BaseSlider`1), Member = "RoundToMultipleOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60009FB")]
	internal virtual void ComputeValueFromKey(SliderKey<Single> sliderKey, bool isShift) { }

	[Address(RVA = "0x1C27720", Offset = "0x1C26920", Length = "0xC8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "UnityEngine.UINumericFieldsUtils", Member = "TryConvertStringToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Single&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60009FA")]
	internal virtual float ParseStringToValue(string previousValue, string newValue) { }

	[Address(RVA = "0x1C277F0", Offset = "0x1C269F0", Length = "0x212")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseSlider`1<System.Single>), Member = "get_highValue", ReturnType = typeof(float))]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028F2B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
	[Calls(Type = typeof(Math), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int), typeof(MidpointRounding)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60009F7")]
	internal virtual float SliderLerpUnclamped(float a, float b, float interpolant) { }

	[Address(RVA = "0x1C27A10", Offset = "0x1C26C10", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60009F8")]
	internal virtual float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue) { }

	[Address(RVA = "0x1C27AD0", Offset = "0x1C26CD0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseSlider`1<System.Single>), Member = "get_highValue", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60009F9")]
	internal virtual float SliderRange() { }

}

