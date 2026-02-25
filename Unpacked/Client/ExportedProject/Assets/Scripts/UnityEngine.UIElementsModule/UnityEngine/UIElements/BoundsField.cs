namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Token(Token = "0x2000091")]
public class BoundsField : BaseField<Bounds>
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000092")]
	internal class UxmlFactory : UxmlFactory<BoundsField, UxmlTraits>
	{

		[Address(RVA = "0x1BE5340", Offset = "0x1BE4540", Length = "0x39")]
		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6000584")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000093")]
	internal class UxmlTraits : UxmlTraits<Bounds>
	{
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4000348")]
		private UxmlFloatAttributeDescription m_CenterXValue; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4000349")]
		private UxmlFloatAttributeDescription m_CenterYValue; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x400034A")]
		private UxmlFloatAttributeDescription m_CenterZValue; //Field offset: 0xA8
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x400034B")]
		private UxmlFloatAttributeDescription m_ExtentsXValue; //Field offset: 0xB0
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x400034C")]
		private UxmlFloatAttributeDescription m_ExtentsYValue; //Field offset: 0xB8
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x400034D")]
		private UxmlFloatAttributeDescription m_ExtentsZValue; //Field offset: 0xC0

		[Address(RVA = "0x1BE9750", Offset = "0x1BE8950", Length = "0x25F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UxmlFloatAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1+UxmlTraits<UnityEngine.Bounds>), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000586")]
		public UxmlTraits() { }

		[Address(RVA = "0x1BE6470", Offset = "0x1BE5670", Length = "0x37E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 7)]
		[Token(Token = "0x6000585")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x4000341")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x4000342")]
	public static readonly string labelUssClassName; //Field offset: 0x8
	[Token(Token = "0x4000343")]
	public static readonly string inputUssClassName; //Field offset: 0x10
	[Token(Token = "0x4000344")]
	public static readonly string centerFieldUssClassName; //Field offset: 0x18
	[Token(Token = "0x4000345")]
	public static readonly string extentsFieldUssClassName; //Field offset: 0x20
	[FieldOffset(Offset = "0x370")]
	[Token(Token = "0x4000346")]
	private Vector3Field m_CenterField; //Field offset: 0x370
	[FieldOffset(Offset = "0x378")]
	[Token(Token = "0x4000347")]
	private Vector3Field m_ExtentsField; //Field offset: 0x378

	[Address(RVA = "0x1BD7740", Offset = "0x1BD6940", Length = "0x1C2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000581")]
	private static BoundsField() { }

	[Address(RVA = "0x1BD7D10", Offset = "0x1BD6F10", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BoundsField), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600057D")]
	public BoundsField() { }

	[Address(RVA = "0x1BD7910", Offset = "0x1BD6B10", Length = "0x3FB")]
	[CalledBy(Type = typeof(BoundsField), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(INotifyValueChangedExtensions), Member = "RegisterValueChangedCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.INotifyValueChanged`1<T>", "UnityEngine.UIElements.EventCallback`1<ChangeEvent`1<T>>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Vector3Field), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(Hierarchy), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Focusable), Member = "set_delegatesFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<UnityEngine.Bounds>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600057E")]
	public BoundsField(string label) { }

	[Address(RVA = "0x1BD7550", Offset = "0x1BD6750", Length = "0xA9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	[Token(Token = "0x6000582")]
	private void <.ctor>b__11_0(ChangeEvent<Vector3> e) { }

	[Address(RVA = "0x1BD7600", Offset = "0x1BD6800", Length = "0xB2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	[Token(Token = "0x6000583")]
	private void <.ctor>b__11_1(ChangeEvent<Vector3> e) { }

	[Address(RVA = "0x1BD7430", Offset = "0x1BD6630", Length = "0x111")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseField`1), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValueType"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600057F")]
	public virtual void SetValueWithoutNotify(Bounds newValue) { }

	[Address(RVA = "0x1BD76C0", Offset = "0x1BD68C0", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseField`1), Member = "set_showMixedValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000580")]
	protected virtual void UpdateMixedValueContent() { }

}

