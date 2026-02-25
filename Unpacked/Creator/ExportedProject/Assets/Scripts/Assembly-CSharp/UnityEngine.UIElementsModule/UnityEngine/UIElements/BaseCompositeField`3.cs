namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Token(Token = "0x2000071")]
public abstract class BaseCompositeField : BaseField<TValueType>
{
	[CompilerGenerated]
	[Token(Token = "0x2000074")]
	private sealed class <>c__DisplayClass18_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400022C")]
		public FieldDescription<TValueType, TField, TFieldValue> desc; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400022D")]
		public TField field; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400022E")]
		public BaseCompositeField<TValueType, TField, TFieldValue> <>4__this; //Field offset: 0x0

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600041F")]
		public <>c__DisplayClass18_0() { }

		[Address(RVA = "0x7FDB90", Offset = "0x7FCD90", Length = "0xDA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseField`1), Member = "ValidatedValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValueType"}, ReturnType = "TValueType")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000420")]
		internal TFieldValue <.ctor>b__0(TFieldValue newValue) { }

		[Address(RVA = "0x7FE6E0", Offset = "0x7FD8E0", Length = "0x20E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(TextInputBaseField`1), Member = "get_text", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000421")]
		internal void <.ctor>b__1(ChangeEvent<TFieldValue> e) { }

	}

	[Token(Token = "0x2000072")]
	public struct FieldDescription
	{
		[Token(Token = "0x2000073")]
		internal sealed class WriteDelegate : MulticastDelegate
		{

			[Address(RVA = "0x961220", Offset = "0x960420", Length = "0xB5")]
			[CalledBy(Type = typeof(RectField), Member = "DescribeFields", ReturnType = typeof(FieldDescription<Rect, FloatField, Single>[]))]
			[CalledBy(Type = typeof(RectIntField), Member = "DescribeFields", ReturnType = typeof(FieldDescription<RectInt, IntegerField, Int32>[]))]
			[CalledBy(Type = typeof(Vector2Field), Member = "DescribeFields", ReturnType = typeof(FieldDescription<Vector2, FloatField, Single>[]))]
			[CalledBy(Type = typeof(Vector3Field), Member = "DescribeFields", ReturnType = typeof(FieldDescription<Vector3, FloatField, Single>[]))]
			[CalledBy(Type = typeof(Vector4Field), Member = "DescribeFields", ReturnType = typeof(FieldDescription<Vector4, FloatField, Single>[]))]
			[CalledBy(Type = typeof(Vector2IntField), Member = "DescribeFields", ReturnType = typeof(FieldDescription<Vector2Int, IntegerField, Int32>[]))]
			[CalledBy(Type = typeof(Vector3IntField), Member = "DescribeFields", ReturnType = typeof(FieldDescription<Vector3Int, IntegerField, Int32>[]))]
			[CallerCount(Count = 13)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x600041D")]
			public WriteDelegate(object object, IntPtr method) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600041E")]
			public override void Invoke(ref TValueType val, TFieldValue fieldValue) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000228")]
		internal readonly string name; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000229")]
		internal readonly string ussName; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400022A")]
		internal readonly Func<TValueType, TFieldValue> read; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400022B")]
		internal readonly WriteDelegate<TValueType, TField, TFieldValue> write; //Field offset: 0x0

		[Address(RVA = "0xC34420", Offset = "0xC33620", Length = "0x61")]
		[CalledBy(Type = typeof(RectField), Member = "DescribeFields", ReturnType = typeof(FieldDescription<Rect, FloatField, Single>[]))]
		[CalledBy(Type = typeof(RectIntField), Member = "DescribeFields", ReturnType = typeof(FieldDescription<RectInt, IntegerField, Int32>[]))]
		[CalledBy(Type = typeof(Vector2Field), Member = "DescribeFields", ReturnType = typeof(FieldDescription<Vector2, FloatField, Single>[]))]
		[CalledBy(Type = typeof(Vector3Field), Member = "DescribeFields", ReturnType = typeof(FieldDescription<Vector3, FloatField, Single>[]))]
		[CalledBy(Type = typeof(Vector4Field), Member = "DescribeFields", ReturnType = typeof(FieldDescription<Vector4, FloatField, Single>[]))]
		[CalledBy(Type = typeof(Vector2IntField), Member = "DescribeFields", ReturnType = typeof(FieldDescription<Vector2Int, IntegerField, Int32>[]))]
		[CalledBy(Type = typeof(Vector3IntField), Member = "DescribeFields", ReturnType = typeof(FieldDescription<Vector3Int, IntegerField, Int32>[]))]
		[CallerCount(Count = 22)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600041C")]
		public FieldDescription(string name, string ussName, Func<TValueType, TFieldValue> read, WriteDelegate<TValueType, TField, TFieldValue> write) { }

	}

	[Token(Token = "0x400021F")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x4000220")]
	public static readonly string labelUssClassName; //Field offset: 0x0
	[Token(Token = "0x4000221")]
	public static readonly string inputUssClassName; //Field offset: 0x0
	[Token(Token = "0x4000222")]
	public static readonly string spacerUssClassName; //Field offset: 0x0
	[Token(Token = "0x4000223")]
	public static readonly string multilineVariantUssClassName; //Field offset: 0x0
	[Token(Token = "0x4000224")]
	public static readonly string fieldGroupUssClassName; //Field offset: 0x0
	[Token(Token = "0x4000225")]
	public static readonly string fieldUssClassName; //Field offset: 0x0
	[Token(Token = "0x4000226")]
	public static readonly string firstFieldVariantUssClassName; //Field offset: 0x0
	[Token(Token = "0x4000227")]
	public static readonly string twoLinesVariantUssClassName; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400021C")]
	private List<TField> m_Fields; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400021D")]
	private bool m_ShouldUpdateDisplay; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400021E")]
	private bool m_ForceUpdateDisplay; //Field offset: 0x0

	[Address(RVA = "0xF3B590", Offset = "0xF3A790", Length = "0x785")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[DeduplicatedMethod]
	[Token(Token = "0x600041B")]
	private static BaseCompositeField`3() { }

	[Address(RVA = "0xF41FE0", Offset = "0xF411E0", Length = "0x9A9")]
	[CalledBy(Type = typeof(RectField), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RectField), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(INotifyValueChangedExtensions), Member = "RegisterValueChangedCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.INotifyValueChanged`1<T>", "UnityEngine.UIElements.EventCallback`1<ChangeEvent`1<T>>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseField`1), Member = "add_onValidateValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TValueType, TValueType>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "set_label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F6C70")]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(Focusable), Member = "set_delegatesFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<UnityEngine.Rect>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F6FF0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000416")]
	protected BaseCompositeField`3(string label, int fieldsByLine) { }

	[Token(Token = "0x6000415")]
	internal abstract FieldDescription<TValueType, TField, TFieldValue>[] DescribeFields() { }

	[Address(RVA = "0xF37800", Offset = "0xF36A00", Length = "0xE6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_visible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000414")]
	private VisualElement GetSpacer() { }

	[Address(RVA = "0xF37930", Offset = "0xF36B30", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<UnityEngine.Rect>), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000419")]
	internal virtual void OnViewDataReady() { }

	[Address(RVA = "0xF389E0", Offset = "0xF37BE0", Length = "0x21A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<UnityEngine.Rect>), Member = "CreateComparer", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<UnityEngine.Rect>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BaseField`1), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValueType"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F6FF0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000418")]
	public virtual void SetValueWithoutNotify(TValueType newValue) { }

	[Address(RVA = "0xF38E90", Offset = "0xF38090", Length = "0x14B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000417")]
	private void UpdateDisplay() { }

	[Address(RVA = "0xF399B0", Offset = "0xF38BB0", Length = "0x149")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseField`1), Member = "set_showMixedValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600041A")]
	protected virtual void UpdateMixedValueContent() { }

}

