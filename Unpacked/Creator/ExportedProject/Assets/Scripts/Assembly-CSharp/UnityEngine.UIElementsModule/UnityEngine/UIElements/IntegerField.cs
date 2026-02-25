namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Token(Token = "0x20000F1")]
public class IntegerField : TextValueField<Int32>
{
	[Token(Token = "0x20000F4")]
	private class IntegerInput : TextValueInput<Int32>
	{

		[Token(Token = "0x17000137")]
		protected virtual string allowedCharacters
		{
			[Address(RVA = "0x1C09390", Offset = "0x1C08590", Length = "0x4F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Token(Token = "0x60007A7")]
			 get { } //Length: 79
		}

		[Token(Token = "0x17000136")]
		private IntegerField parentIntegerField
		{
			[Address(RVA = "0x1C093E0", Offset = "0x1C085E0", Length = "0x71")]
			[CalledBy(Type = typeof(IntegerInput), Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(int)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(IntegerInput), Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
			[CallerCount(Count = 3)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
			[Token(Token = "0x60007A5")]
			private get { } //Length: 113
		}

		[Address(RVA = "0x1C09300", Offset = "0x1C08500", Length = "0x8E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.TextValueField`1<Int32>+TextValueInput<Int32>", Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60007A6")]
		internal IntegerInput() { }

		[Address(RVA = "0x1C090A0", Offset = "0x1C082A0", Length = "0x1C0")]
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
		[Calls(Type = typeof(IntegerInput), Member = "get_parentIntegerField", ReturnType = typeof(IntegerField))]
		[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<System.Int32>), Member = "get_isDelayed", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Mathf), Member = "ClampToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60007A8")]
		public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, int startValue) { }

		[Address(RVA = "0x1C09390", Offset = "0x1C08590", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60007A7")]
		protected virtual string get_allowedCharacters() { }

		[Address(RVA = "0x1C093E0", Offset = "0x1C085E0", Length = "0x71")]
		[CalledBy(Type = typeof(IntegerInput), Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(IntegerInput), Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x60007A5")]
		private IntegerField get_parentIntegerField() { }

		[Address(RVA = "0x1C09270", Offset = "0x1C08470", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(IntegerInput), Member = "get_parentIntegerField", ReturnType = typeof(IntegerField))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60007AA")]
		protected virtual int StringToValue(string str) { }

		[Address(RVA = "0x1C092B0", Offset = "0x1C084B0", Length = "0x42")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Token(Token = "0x60007A9")]
		protected virtual string ValueToString(int v) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000F2")]
	internal class UxmlFactory : UxmlFactory<IntegerField, UxmlTraits>
	{

		[Address(RVA = "0x1C158B0", Offset = "0x1C14AB0", Length = "0x39")]
		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60007A3")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000F3")]
	internal class UxmlTraits : TextValueFieldTraits<Int32, UxmlIntAttributeDescription>
	{

		[Address(RVA = "0x1C16B70", Offset = "0x1C15D70", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UnityEngine.UIElements.TextValueFieldTraits`2<System.Int32, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60007A4")]
		public UxmlTraits() { }

	}

	[Token(Token = "0x40004BB")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x40004BC")]
	public static readonly string labelUssClassName; //Field offset: 0x8
	[Token(Token = "0x40004BD")]
	public static readonly string inputUssClassName; //Field offset: 0x10

	[Token(Token = "0x17000135")]
	private IntegerInput integerInput
	{
		[Address(RVA = "0x1C09020", Offset = "0x1C08220", Length = "0x7A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x600079B")]
		private get { } //Length: 122
	}

	[Address(RVA = "0x1C08B20", Offset = "0x1C07D20", Length = "0x112")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x60007A2")]
	private static IntegerField() { }

	[Address(RVA = "0x1C08E40", Offset = "0x1C08040", Length = "0x1DD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = "UnityEngine.UIElements.TextValueField`1<Int32>+TextValueInput<Int32>", Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UnityEngine.UIElements.TextValueField`1<System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), "UnityEngine.UIElements.TextValueField`1<Int32>+TextValueInput<Int32>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(UnityEngine.UIElements.TextValueField`1<System.Int32>), Member = "AddLabelDragger", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600079E")]
	public IntegerField() { }

	[Address(RVA = "0x1C08C40", Offset = "0x1C07E40", Length = "0x1F5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = "UnityEngine.UIElements.TextValueField`1<Int32>+TextValueInput<Int32>", Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UnityEngine.UIElements.TextValueField`1<System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), "UnityEngine.UIElements.TextValueField`1<Int32>+TextValueInput<Int32>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(UnityEngine.UIElements.TextValueField`1<System.Int32>), Member = "AddLabelDragger", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600079F")]
	public IntegerField(string label, int maxLength = 1000) { }

	[Address(RVA = "0x1C08850", Offset = "0x1C07A50", Length = "0xD7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007A1")]
	public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, int startValue) { }

	[Address(RVA = "0x1C08930", Offset = "0x1C07B30", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60007A0")]
	internal virtual bool CanTryParse(string textString) { }

	[Address(RVA = "0x1C09020", Offset = "0x1C08220", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x600079B")]
	private IntegerInput get_integerInput() { }

	[Address(RVA = "0x1C08960", Offset = "0x1C07B60", Length = "0x113")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextInputBase), Member = "get_originalText", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "UnityEngine.UINumericFieldsUtils", Member = "TryConvertStringToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Int32&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600079D")]
	protected virtual int StringToValue(string str) { }

	[Address(RVA = "0x1C08A80", Offset = "0x1C07C80", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextValueField`1), Member = "get_formatString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600079C")]
	protected virtual string ValueToString(int v) { }

}

