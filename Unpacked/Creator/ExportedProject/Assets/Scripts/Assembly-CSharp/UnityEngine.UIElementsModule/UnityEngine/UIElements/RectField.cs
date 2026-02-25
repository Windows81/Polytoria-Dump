namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Token(Token = "0x200009F")]
public class RectField : BaseCompositeField<Rect, FloatField, Single>
{
	[CompilerGenerated]
	[Token(Token = "0x20000A2")]
	private sealed class <>c
	{
		[Token(Token = "0x4000370")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000371")]
		public static Func<Rect, Single> <>9__0_0; //Field offset: 0x8
		[Token(Token = "0x4000372")]
		public static WriteDelegate<Rect, FloatField, Single> <>9__0_1; //Field offset: 0x10
		[Token(Token = "0x4000373")]
		public static Func<Rect, Single> <>9__0_2; //Field offset: 0x18
		[Token(Token = "0x4000374")]
		public static WriteDelegate<Rect, FloatField, Single> <>9__0_3; //Field offset: 0x20
		[Token(Token = "0x4000375")]
		public static Func<Rect, Single> <>9__0_4; //Field offset: 0x28
		[Token(Token = "0x4000376")]
		public static WriteDelegate<Rect, FloatField, Single> <>9__0_5; //Field offset: 0x30
		[Token(Token = "0x4000377")]
		public static Func<Rect, Single> <>9__0_6; //Field offset: 0x38
		[Token(Token = "0x4000378")]
		public static WriteDelegate<Rect, FloatField, Single> <>9__0_7; //Field offset: 0x40

		[Address(RVA = "0x1BE4A90", Offset = "0x1BE3C90", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60005B1")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005B2")]
		public <>c() { }

		[Address(RVA = "0x1A189B0", Offset = "0x1A17BB0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005B3")]
		internal float <DescribeFields>b__0_0(Rect r) { }

		[Address(RVA = "0x1A13390", Offset = "0x1A12590", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005B4")]
		internal void <DescribeFields>b__0_1(ref Rect r, float v) { }

		[Address(RVA = "0x1A18CF0", Offset = "0x1A17EF0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005B5")]
		internal float <DescribeFields>b__0_2(Rect r) { }

		[Address(RVA = "0x19F5B20", Offset = "0x19F4D20", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005B6")]
		internal void <DescribeFields>b__0_3(ref Rect r, float v) { }

		[Address(RVA = "0x1A18890", Offset = "0x1A17A90", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005B7")]
		internal float <DescribeFields>b__0_4(Rect r) { }

		[Address(RVA = "0x19F4E50", Offset = "0x19F4050", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005B8")]
		internal void <DescribeFields>b__0_5(ref Rect r, float v) { }

		[Address(RVA = "0x19F5EE0", Offset = "0x19F50E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005B9")]
		internal float <DescribeFields>b__0_6(Rect r) { }

		[Address(RVA = "0x19F4BD0", Offset = "0x19F3DD0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005BA")]
		internal void <DescribeFields>b__0_7(ref Rect r, float v) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000A0")]
	internal class UxmlFactory : UxmlFactory<RectField, UxmlTraits>
	{

		[Address(RVA = "0x1BE5500", Offset = "0x1BE4700", Length = "0x39")]
		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60005AE")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000A1")]
	internal class UxmlTraits : UxmlTraits<Rect>
	{
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x400036C")]
		private UxmlFloatAttributeDescription m_XValue; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x400036D")]
		private UxmlFloatAttributeDescription m_YValue; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x400036E")]
		private UxmlFloatAttributeDescription m_WValue; //Field offset: 0xA8
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x400036F")]
		private UxmlFloatAttributeDescription m_HValue; //Field offset: 0xB0

		[Address(RVA = "0x1BE9C90", Offset = "0x1BE8E90", Length = "0x1AF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UxmlFloatAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1+UxmlTraits<UnityEngine.Rect>), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60005B0")]
		public UxmlTraits() { }

		[Address(RVA = "0x1BE6ED0", Offset = "0x1BE60D0", Length = "0x2A4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 5)]
		[Token(Token = "0x60005AF")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x4000369")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x400036A")]
	public static readonly string labelUssClassName; //Field offset: 0x8
	[Token(Token = "0x400036B")]
	public static readonly string inputUssClassName; //Field offset: 0x10

	[Address(RVA = "0x1BE3010", Offset = "0x1BE2210", Length = "0x112")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x60005AD")]
	private static RectField() { }

	[Address(RVA = "0x1BE3130", Offset = "0x1BE2330", Length = "0x133")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BaseCompositeField`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005AB")]
	public RectField() { }

	[Address(RVA = "0x1BE3270", Offset = "0x1BE2470", Length = "0x140")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BaseCompositeField`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005AC")]
	public RectField(string label) { }

	[Address(RVA = "0x1BE2810", Offset = "0x1BE1A10", Length = "0x7FF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(WriteDelegate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FieldDescription), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), "System.Func`2<TValueType, TFieldValue>", "UnityEngine.UIElements.BaseCompositeField`3<TValueType, TField, TFieldValue>+FieldDescription<TValueType, TField, TFieldValue>+WriteDelegate<TValueType, TField, TFieldValue>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60005AA")]
	internal virtual FieldDescription<Rect, FloatField, Single>[] DescribeFields() { }

}

