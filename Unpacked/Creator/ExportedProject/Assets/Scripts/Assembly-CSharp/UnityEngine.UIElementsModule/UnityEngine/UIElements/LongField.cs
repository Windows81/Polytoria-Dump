namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Token(Token = "0x20000FB")]
public class LongField : TextValueField<Int64>
{
	[Token(Token = "0x20000FE")]
	private class LongInput : TextValueInput<Int64>
	{

		[Token(Token = "0x1700013F")]
		protected virtual string allowedCharacters
		{
			[Address(RVA = "0x1C0C080", Offset = "0x1C0B280", Length = "0x4F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Token(Token = "0x60007CE")]
			 get { } //Length: 79
		}

		[Token(Token = "0x1700013E")]
		private LongField parentLongField
		{
			[Address(RVA = "0x1C0C0D0", Offset = "0x1C0B2D0", Length = "0x71")]
			[CalledBy(Type = typeof(LongInput), Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(long)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(LongInput), Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
			[CallerCount(Count = 3)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
			[Token(Token = "0x60007CC")]
			private get { } //Length: 113
		}

		[Address(RVA = "0x1C0BFF0", Offset = "0x1C0B1F0", Length = "0x8E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.TextValueField`1<Int64>+TextValueInput<Int64>", Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60007CD")]
		internal LongInput() { }

		[Address(RVA = "0x1C0BC70", Offset = "0x1C0AE70", Length = "0x231")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.NumericFieldDraggerUtility", Member = "CalculateIntDragSensitivity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(long))]
		[Calls(Type = "UnityEngine.NumericFieldDraggerUtility", Member = "Acceleration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(float))]
		[Calls(Type = typeof(TextInputBase), Member = "get_text", ReturnType = typeof(string))]
		[Calls(Type = "UnityEngine.NumericFieldDraggerUtility", Member = "NiceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float)}, ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F70")]
		[Calls(Type = typeof(LongInput), Member = "get_parentLongField", ReturnType = typeof(LongField))]
		[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<System.Int64>), Member = "get_isDelayed", ReturnType = typeof(bool))]
		[Calls(Type = typeof(TextInputBase), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60007CF")]
		public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, long startValue) { }

		[Address(RVA = "0x1C0BEB0", Offset = "0x1C0B0B0", Length = "0xA2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60007D0")]
		private long ClampMinMaxLongValue(long niceDelta, long value) { }

		[Address(RVA = "0x1C0C080", Offset = "0x1C0B280", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60007CE")]
		protected virtual string get_allowedCharacters() { }

		[Address(RVA = "0x1C0C0D0", Offset = "0x1C0B2D0", Length = "0x71")]
		[CalledBy(Type = typeof(LongInput), Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(DeltaSpeed), typeof(long)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LongInput), Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x60007CC")]
		private LongField get_parentLongField() { }

		[Address(RVA = "0x1C0BF60", Offset = "0x1C0B160", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LongInput), Member = "get_parentLongField", ReturnType = typeof(LongField))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60007D2")]
		protected virtual long StringToValue(string str) { }

		[Address(RVA = "0x1C0BFA0", Offset = "0x1C0B1A0", Length = "0x43")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(long), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Token(Token = "0x60007D1")]
		protected virtual string ValueToString(long v) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000FC")]
	internal class UxmlFactory : UxmlFactory<LongField, UxmlTraits>
	{

		[Address(RVA = "0x1C15870", Offset = "0x1C14A70", Length = "0x39")]
		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60007CA")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000FD")]
	internal class UxmlTraits : TextValueFieldTraits<Int64, UxmlLongAttributeDescription>
	{

		[Address(RVA = "0x1C16CE0", Offset = "0x1C15EE0", Length = "0xE4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UnityEngine.UIElements.TextValueFieldTraits`2<System.Int64, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(PooledObject`1), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.RadioButtonGroup+<get_choices>d__17", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60007CB")]
		public UxmlTraits() { }

	}

	[Token(Token = "0x40004CB")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x40004CC")]
	public static readonly string labelUssClassName; //Field offset: 0x8
	[Token(Token = "0x40004CD")]
	public static readonly string inputUssClassName; //Field offset: 0x10

	[Token(Token = "0x1700013D")]
	private LongInput longInput
	{
		[Address(RVA = "0x1C0BBF0", Offset = "0x1C0ADF0", Length = "0x7A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x60007C2")]
		private get { } //Length: 122
	}

	[Address(RVA = "0x1C0B6F0", Offset = "0x1C0A8F0", Length = "0x112")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x60007C9")]
	private static LongField() { }

	[Address(RVA = "0x1C0BA10", Offset = "0x1C0AC10", Length = "0x1DD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = "UnityEngine.UIElements.TextValueField`1<Int64>+TextValueInput<Int64>", Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UnityEngine.UIElements.TextValueField`1<System.Int64>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), "UnityEngine.UIElements.TextValueField`1<Int64>+TextValueInput<Int64>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(UnityEngine.UIElements.TextValueField`1<System.Int64>), Member = "AddLabelDragger", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007C5")]
	public LongField() { }

	[Address(RVA = "0x1C0B810", Offset = "0x1C0AA10", Length = "0x1F5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = "UnityEngine.UIElements.TextValueField`1<Int64>+TextValueInput<Int64>", Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UnityEngine.UIElements.TextValueField`1<System.Int64>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), "UnityEngine.UIElements.TextValueField`1<Int64>+TextValueInput<Int64>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(UnityEngine.UIElements.TextValueField`1<System.Int64>), Member = "AddLabelDragger", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007C6")]
	public LongField(string label, int maxLength = 1000) { }

	[Address(RVA = "0x1C0B420", Offset = "0x1C0A620", Length = "0xD7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007C8")]
	public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, long startValue) { }

	[Address(RVA = "0x1C0B500", Offset = "0x1C0A700", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(long), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int64&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60007C7")]
	internal virtual bool CanTryParse(string textString) { }

	[Address(RVA = "0x1C0BBF0", Offset = "0x1C0ADF0", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60007C2")]
	private LongInput get_longInput() { }

	[Address(RVA = "0x1C0B530", Offset = "0x1C0A730", Length = "0x115")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextInputBase), Member = "get_originalText", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "UnityEngine.UINumericFieldsUtils", Member = "TryConvertStringToLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Int64&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007C4")]
	protected virtual long StringToValue(string str) { }

	[Address(RVA = "0x1C0B650", Offset = "0x1C0A850", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextValueField`1), Member = "get_formatString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(long), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007C3")]
	protected virtual string ValueToString(long v) { }

}

