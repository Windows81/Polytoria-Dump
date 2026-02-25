namespace UnityEngine.UIElements;

[Token(Token = "0x2000147")]
public class SliderInt : BaseSlider<Int32>
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000148")]
	internal class UxmlFactory : UxmlFactory<SliderInt, UxmlTraits>
	{

		[Address(RVA = "0x1C2C510", Offset = "0x1C2B710", Length = "0x39")]
		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6000A0C")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000149")]
	internal class UxmlTraits : UxmlTraits<Int32, UxmlIntAttributeDescription>
	{
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x400067A")]
		private UxmlIntAttributeDescription m_LowValue; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x400067B")]
		private UxmlIntAttributeDescription m_HighValue; //Field offset: 0xA8
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x400067C")]
		private UxmlIntAttributeDescription m_PageSize; //Field offset: 0xB0
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x400067D")]
		private UxmlBoolAttributeDescription m_ShowInputField; //Field offset: 0xB8
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x400067E")]
		private UxmlEnumAttributeDescription<SliderDirection> m_Direction; //Field offset: 0xC0
		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x400067F")]
		private UxmlBoolAttributeDescription m_Inverted; //Field offset: 0xC8

		[Address(RVA = "0x1C2FF10", Offset = "0x1C2F110", Length = "0x2CD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UxmlIntAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UxmlBoolAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlEnumAttributeDescription`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlTraits`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000A0E")]
		public UxmlTraits() { }

		[Address(RVA = "0x1C2C790", Offset = "0x1C2B990", Length = "0x373")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(BaseSlider`1), Member = "set_lowValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValueType"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseSlider`1), Member = "set_highValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValueType"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseSlider`1), Member = "set_direction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SliderDirection)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseSlider`1), Member = "set_inverted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseFieldTraits`2), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 8)]
		[Token(Token = "0x6000A0D")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x4000677")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x4000678")]
	public static readonly string labelUssClassName; //Field offset: 0x8
	[Token(Token = "0x4000679")]
	public static readonly string inputUssClassName; //Field offset: 0x10

	[Token(Token = "0x170001B6")]
	public virtual float pageSize
	{
		[Address(RVA = "0x1C272D0", Offset = "0x1C264D0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(BaseSlider`1), Member = "get_pageSize", ReturnType = typeof(float))]
		[Token(Token = "0x6000A02")]
		 get { } //Length: 57
		[Address(RVA = "0x1C27310", Offset = "0x1C26510", Length = "0x8E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F70")]
		[Calls(Type = typeof(BaseSlider`1), Member = "set_pageSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000A03")]
		 set { } //Length: 142
	}

	[Address(RVA = "0x1C26F20", Offset = "0x1C26120", Length = "0x112")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000A0B")]
	private static SliderInt() { }

	[Address(RVA = "0x1C27040", Offset = "0x1C26240", Length = "0x12F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BaseSlider`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "TValueType", "TValueType", typeof(SliderDirection), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000A00")]
	public SliderInt() { }

	[Address(RVA = "0x1C27170", Offset = "0x1C26370", Length = "0x156")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BaseSlider`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "TValueType", "TValueType", typeof(SliderDirection), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000A01")]
	public SliderInt(string label, int start = 0, int end = 10, SliderDirection direction = 0, float pageSize = 0) { }

	[Address(RVA = "0x1C26670", Offset = "0x1C25870", Length = "0x15A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseSlider`1), Member = "get_lowValue", ReturnType = "TValueType")]
	[Calls(Type = typeof(BaseSlider`1), Member = "get_highValue", ReturnType = "TValueType")]
	[Calls(Type = "UnityEngine.NumericFieldDraggerUtility", Member = "CalculateIntDragSensitivity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long), typeof(long)}, ReturnType = typeof(long))]
	[Calls(Type = "UnityEngine.NumericFieldDraggerUtility", Member = "Acceleration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(float))]
	[Calls(Type = "UnityEngine.NumericFieldDraggerUtility", Member = "NiceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F70")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A04")]
	public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, int startValue) { }

	[Address(RVA = "0x1C267D0", Offset = "0x1C259D0", Length = "0x310")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
	[Calls(Type = typeof(BaseSlider`1), Member = "get_lowValue", ReturnType = "TValueType")]
	[Calls(Type = typeof(BaseSlider`1), Member = "get_highValue", ReturnType = "TValueType")]
	[Calls(Type = typeof(BaseSlider`1), Member = "get_inverted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseSlider`1), Member = "get_direction", ReturnType = typeof(SliderDirection))]
	[Calls(Type = typeof(BaseSlider`1), Member = "ComputeValueAndDirectionFromClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A09")]
	internal virtual void ComputeValueAndDirectionFromClick(float sliderLength, float dragElementLength, float dragElementPos, float dragElementLastPos) { }

	[Address(RVA = "0x1C26AF0", Offset = "0x1C25CF0", Length = "0x236")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseSlider`1), Member = "get_lowValue", ReturnType = "TValueType")]
	[Calls(Type = typeof(BaseSlider`1), Member = "get_highValue", ReturnType = "TValueType")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BaseSlider`1), Member = "GetClosestPowerOfTen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(BaseSlider`1), Member = "RoundToMultipleOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC070")]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A0A")]
	internal virtual void ComputeValueFromKey(SliderKey<Int32> sliderKey, bool isShift) { }

	[Address(RVA = "0x1C272D0", Offset = "0x1C264D0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseSlider`1), Member = "get_pageSize", ReturnType = typeof(float))]
	[Token(Token = "0x6000A02")]
	public virtual float get_pageSize() { }

	[Address(RVA = "0x1C26D30", Offset = "0x1C25F30", Length = "0xA4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "UnityEngine.UINumericFieldsUtils", Member = "TryConvertStringToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Int32&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A08")]
	internal virtual int ParseStringToValue(string previousValue, string newValue) { }

	[Address(RVA = "0x1C27310", Offset = "0x1C26510", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F70")]
	[Calls(Type = typeof(BaseSlider`1), Member = "set_pageSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A03")]
	public virtual void set_pageSize(float value) { }

	[Address(RVA = "0x1C26DE0", Offset = "0x1C25FE0", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F70")]
	[Token(Token = "0x6000A05")]
	internal virtual int SliderLerpUnclamped(int a, int b, float interpolant) { }

	[Address(RVA = "0x1C26E50", Offset = "0x1C26050", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000A06")]
	internal virtual float SliderNormalizeValue(int currentValue, int lowerValue, int higherValue) { }

	[Address(RVA = "0x1C26E90", Offset = "0x1C26090", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseSlider`1), Member = "get_highValue", ReturnType = "TValueType")]
	[Calls(Type = typeof(BaseSlider`1), Member = "get_lowValue", ReturnType = "TValueType")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000A07")]
	internal virtual int SliderRange() { }

}

