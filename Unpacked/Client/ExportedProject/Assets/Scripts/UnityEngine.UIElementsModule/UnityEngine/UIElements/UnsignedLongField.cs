namespace UnityEngine.UIElements;

[Token(Token = "0x2000170")]
public class UnsignedLongField : TextValueField<UInt64>
{
	[Token(Token = "0x2000173")]
	private class UnsignedLongInput : TextValueInput<UInt64>
	{

		[Token(Token = "0x170001F5")]
		protected virtual string allowedCharacters
		{
			[Address(RVA = "0x1C46BE0", Offset = "0x1C45DE0", Length = "0x4F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Token(Token = "0x6000B30")]
			 get { } //Length: 79
		}

		[Token(Token = "0x170001F4")]
		private UnsignedLongField parentUnsignedLongField
		{
			[Address(RVA = "0x1C46C30", Offset = "0x1C45E30", Length = "0x71")]
			[CalledBy(Type = typeof(UnsignedLongInput), Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(ulong)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(UnsignedLongInput), Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ulong))]
			[CallerCount(Count = 3)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
			[Token(Token = "0x6000B2E")]
			private get { } //Length: 113
		}

		[Address(RVA = "0x1C46B50", Offset = "0x1C45D50", Length = "0x8E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.TextValueField`1<UInt64>+TextValueInput<UInt64>", Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000B2F")]
		internal UnsignedLongInput() { }

		[Address(RVA = "0x1C467F0", Offset = "0x1C459F0", Length = "0x228")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.NumericFieldDraggerUtility", Member = "CalculateIntDragSensitivity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(ulong))]
		[Calls(Type = "UnityEngine.NumericFieldDraggerUtility", Member = "Acceleration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(float))]
		[Calls(Type = typeof(TextInputBase), Member = "get_text", ReturnType = typeof(string))]
		[Calls(Type = "UnityEngine.NumericFieldDraggerUtility", Member = "NiceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float)}, ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F70")]
		[Calls(Type = typeof(UnsignedLongInput), Member = "get_parentUnsignedLongField", ReturnType = typeof(UnsignedLongField))]
		[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<System.UInt64>), Member = "get_isDelayed", ReturnType = typeof(bool))]
		[Calls(Type = typeof(TextInputBase), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000B31")]
		public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, ulong startValue) { }

		[Address(RVA = "0x1C46A20", Offset = "0x1C45C20", Length = "0x94")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000B32")]
		private ulong ClampToMinMaxULongValue(long niceDelta, ulong value) { }

		[Address(RVA = "0x1C46BE0", Offset = "0x1C45DE0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000B30")]
		protected virtual string get_allowedCharacters() { }

		[Address(RVA = "0x1C46C30", Offset = "0x1C45E30", Length = "0x71")]
		[CalledBy(Type = typeof(UnsignedLongInput), Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(ulong)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnsignedLongInput), Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ulong))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x6000B2E")]
		private UnsignedLongField get_parentUnsignedLongField() { }

		[Address(RVA = "0x1C46AC0", Offset = "0x1C45CC0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsignedLongInput), Member = "get_parentUnsignedLongField", ReturnType = typeof(UnsignedLongField))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000B34")]
		protected virtual ulong StringToValue(string str) { }

		[Address(RVA = "0x1C46B00", Offset = "0x1C45D00", Length = "0x43")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ulong), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Token(Token = "0x6000B33")]
		protected virtual string ValueToString(ulong v) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000171")]
	internal class UxmlFactory : UxmlFactory<UnsignedLongField, UxmlTraits>
	{

		[Address(RVA = "0x1C46D70", Offset = "0x1C45F70", Length = "0x39")]
		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6000B2C")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000172")]
	internal class UxmlTraits : TextValueFieldTraits<UInt64, UxmlUnsignedLongAttributeDescription>
	{

		[Address(RVA = "0x1C478D0", Offset = "0x1C46AD0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UnityEngine.UIElements.TextValueFieldTraits`2<System.UInt64, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6000B2D")]
		public UxmlTraits() { }

	}

	[Token(Token = "0x400073D")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x400073E")]
	public static readonly string labelUssClassName; //Field offset: 0x8
	[Token(Token = "0x400073F")]
	public static readonly string inputUssClassName; //Field offset: 0x10

	[Token(Token = "0x170001F3")]
	private UnsignedLongInput unsignedLongInput
	{
		[Address(RVA = "0x1C46770", Offset = "0x1C45970", Length = "0x7A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x6000B24")]
		private get { } //Length: 122
	}

	[Address(RVA = "0x1C46270", Offset = "0x1C45470", Length = "0x112")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000B2B")]
	private static UnsignedLongField() { }

	[Address(RVA = "0x1C46590", Offset = "0x1C45790", Length = "0x1DD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = "UnityEngine.UIElements.TextValueField`1<UInt64>+TextValueInput<UInt64>", Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UnityEngine.UIElements.TextValueField`1<System.UInt64>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), "UnityEngine.UIElements.TextValueField`1<UInt64>+TextValueInput<UInt64>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(UnityEngine.UIElements.TextValueField`1<System.UInt64>), Member = "AddLabelDragger", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B27")]
	public UnsignedLongField() { }

	[Address(RVA = "0x1C46390", Offset = "0x1C45590", Length = "0x1F5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = "UnityEngine.UIElements.TextValueField`1<UInt64>+TextValueInput<UInt64>", Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UnityEngine.UIElements.TextValueField`1<System.UInt64>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), "UnityEngine.UIElements.TextValueField`1<UInt64>+TextValueInput<UInt64>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(UnityEngine.UIElements.TextValueField`1<System.UInt64>), Member = "AddLabelDragger", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B28")]
	public UnsignedLongField(string label, int maxLength = 1000) { }

	[Address(RVA = "0x1C45FA0", Offset = "0x1C451A0", Length = "0xD7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000B2A")]
	public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, ulong startValue) { }

	[Address(RVA = "0x1C46080", Offset = "0x1C45280", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ulong), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt64&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000B29")]
	internal virtual bool CanTryParse(string textString) { }

	[Address(RVA = "0x1C46770", Offset = "0x1C45970", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000B24")]
	private UnsignedLongInput get_unsignedLongInput() { }

	[Address(RVA = "0x1C460B0", Offset = "0x1C452B0", Length = "0x115")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextInputBase), Member = "get_originalText", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "UnityEngine.UINumericFieldsUtils", Member = "TryConvertStringToULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(UInt64&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000B26")]
	protected virtual ulong StringToValue(string str) { }

	[Address(RVA = "0x1C461D0", Offset = "0x1C453D0", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextValueField`1), Member = "get_formatString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(ulong), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000B25")]
	protected virtual string ValueToString(ulong v) { }

}

