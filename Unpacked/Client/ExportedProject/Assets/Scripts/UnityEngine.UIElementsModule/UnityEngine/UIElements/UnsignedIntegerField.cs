namespace UnityEngine.UIElements;

[Token(Token = "0x200016C")]
public class UnsignedIntegerField : TextValueField<UInt32>
{
	[Token(Token = "0x200016F")]
	private class UnsignedIntegerInput : TextValueInput<UInt32>
	{

		[Token(Token = "0x170001F2")]
		protected virtual string allowedCharacters
		{
			[Address(RVA = "0x1C45ED0", Offset = "0x1C450D0", Length = "0x4F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Token(Token = "0x6000B20")]
			 get { } //Length: 79
		}

		[Token(Token = "0x170001F1")]
		private UnsignedIntegerField parentUnsignedIntegerField
		{
			[Address(RVA = "0x1C45F20", Offset = "0x1C45120", Length = "0x71")]
			[CalledBy(Type = typeof(UnsignedIntegerInput), Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(uint)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(UnsignedIntegerInput), Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(uint))]
			[CallerCount(Count = 3)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
			[Token(Token = "0x6000B1E")]
			private get { } //Length: 113
		}

		[Address(RVA = "0x1C45E40", Offset = "0x1C45040", Length = "0x8E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.TextValueField`1<UInt32>+TextValueInput<UInt32>", Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000B1F")]
		internal UnsignedIntegerInput() { }

		[Address(RVA = "0x1C45BF0", Offset = "0x1C44DF0", Length = "0x1BF")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.NumericFieldDraggerUtility", Member = "NiceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float)}, ReturnType = typeof(float))]
		[Calls(Type = typeof(TextInputBase), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.NumericFieldDraggerUtility", Member = "CalculateIntDragSensitivity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(long))]
		[Calls(Type = "UnityEngine.NumericFieldDraggerUtility", Member = "Acceleration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(float))]
		[Calls(Type = typeof(TextInputBase), Member = "get_text", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F70")]
		[Calls(Type = typeof(UnsignedIntegerInput), Member = "get_parentUnsignedIntegerField", ReturnType = typeof(UnsignedIntegerField))]
		[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<System.UInt32>), Member = "get_isDelayed", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Mathf), Member = "ClampToUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(uint))]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000B21")]
		public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, uint startValue) { }

		[Address(RVA = "0x1C45ED0", Offset = "0x1C450D0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000B20")]
		protected virtual string get_allowedCharacters() { }

		[Address(RVA = "0x1C45F20", Offset = "0x1C45120", Length = "0x71")]
		[CalledBy(Type = typeof(UnsignedIntegerInput), Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(uint)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnsignedIntegerInput), Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(uint))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x6000B1E")]
		private UnsignedIntegerField get_parentUnsignedIntegerField() { }

		[Address(RVA = "0x1C45DB0", Offset = "0x1C44FB0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsignedIntegerInput), Member = "get_parentUnsignedIntegerField", ReturnType = typeof(UnsignedIntegerField))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000B23")]
		protected virtual uint StringToValue(string str) { }

		[Address(RVA = "0x1C45DF0", Offset = "0x1C44FF0", Length = "0x42")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(uint), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Token(Token = "0x6000B22")]
		protected virtual string ValueToString(uint v) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200016D")]
	internal class UxmlFactory : UxmlFactory<UnsignedIntegerField, UxmlTraits>
	{

		[Address(RVA = "0x1C46DF0", Offset = "0x1C45FF0", Length = "0x39")]
		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6000B1C")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200016E")]
	internal class UxmlTraits : TextValueFieldTraits<UInt32, UxmlUnsignedIntAttributeDescription>
	{

		[Address(RVA = "0x1C47890", Offset = "0x1C46A90", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UnityEngine.UIElements.TextValueFieldTraits`2<System.UInt32, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6000B1D")]
		public UxmlTraits() { }

	}

	[Token(Token = "0x400073A")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x400073B")]
	public static readonly string labelUssClassName; //Field offset: 0x8
	[Token(Token = "0x400073C")]
	public static readonly string inputUssClassName; //Field offset: 0x10

	[Token(Token = "0x170001F0")]
	private UnsignedIntegerInput integerInput
	{
		[Address(RVA = "0x1C45B70", Offset = "0x1C44D70", Length = "0x7A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x6000B14")]
		private get { } //Length: 122
	}

	[Address(RVA = "0x1C45670", Offset = "0x1C44870", Length = "0x112")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000B1B")]
	private static UnsignedIntegerField() { }

	[Address(RVA = "0x1C45990", Offset = "0x1C44B90", Length = "0x1DD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = "UnityEngine.UIElements.TextValueField`1<UInt32>+TextValueInput<UInt32>", Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UnityEngine.UIElements.TextValueField`1<System.UInt32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), "UnityEngine.UIElements.TextValueField`1<UInt32>+TextValueInput<UInt32>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(UnityEngine.UIElements.TextValueField`1<System.UInt32>), Member = "AddLabelDragger", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B17")]
	public UnsignedIntegerField() { }

	[Address(RVA = "0x1C45790", Offset = "0x1C44990", Length = "0x1F5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = "UnityEngine.UIElements.TextValueField`1<UInt32>+TextValueInput<UInt32>", Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UnityEngine.UIElements.TextValueField`1<System.UInt32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), "UnityEngine.UIElements.TextValueField`1<UInt32>+TextValueInput<UInt32>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(UnityEngine.UIElements.TextValueField`1<System.UInt32>), Member = "AddLabelDragger", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B18")]
	public UnsignedIntegerField(string label, int maxLength = 1000) { }

	[Address(RVA = "0x1C453A0", Offset = "0x1C445A0", Length = "0xD7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000B1A")]
	public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, uint startValue) { }

	[Address(RVA = "0x1C45480", Offset = "0x1C44680", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uint), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000B19")]
	internal virtual bool CanTryParse(string textString) { }

	[Address(RVA = "0x1C45B70", Offset = "0x1C44D70", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000B14")]
	private UnsignedIntegerInput get_integerInput() { }

	[Address(RVA = "0x1C454B0", Offset = "0x1C446B0", Length = "0x113")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextInputBase), Member = "get_originalText", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "UnityEngine.UINumericFieldsUtils", Member = "TryConvertStringToUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(UInt32&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000B16")]
	protected virtual uint StringToValue(string str) { }

	[Address(RVA = "0x1C455D0", Offset = "0x1C447D0", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextValueField`1), Member = "get_formatString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(uint), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000B15")]
	protected virtual string ValueToString(uint v) { }

}

