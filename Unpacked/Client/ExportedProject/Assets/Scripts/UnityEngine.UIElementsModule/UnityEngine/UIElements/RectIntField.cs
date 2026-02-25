namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Token(Token = "0x20000A3")]
public class RectIntField : BaseCompositeField<RectInt, IntegerField, Int32>
{
	[CompilerGenerated]
	[Token(Token = "0x20000A6")]
	private sealed class <>c
	{
		[Token(Token = "0x4000380")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000381")]
		public static Func<RectInt, Int32> <>9__0_0; //Field offset: 0x8
		[Token(Token = "0x4000382")]
		public static WriteDelegate<RectInt, IntegerField, Int32> <>9__0_1; //Field offset: 0x10
		[Token(Token = "0x4000383")]
		public static Func<RectInt, Int32> <>9__0_2; //Field offset: 0x18
		[Token(Token = "0x4000384")]
		public static WriteDelegate<RectInt, IntegerField, Int32> <>9__0_3; //Field offset: 0x20
		[Token(Token = "0x4000385")]
		public static Func<RectInt, Int32> <>9__0_4; //Field offset: 0x28
		[Token(Token = "0x4000386")]
		public static WriteDelegate<RectInt, IntegerField, Int32> <>9__0_5; //Field offset: 0x30
		[Token(Token = "0x4000387")]
		public static Func<RectInt, Int32> <>9__0_6; //Field offset: 0x38
		[Token(Token = "0x4000388")]
		public static WriteDelegate<RectInt, IntegerField, Int32> <>9__0_7; //Field offset: 0x40

		[Address(RVA = "0x1BE4D30", Offset = "0x1BE3F30", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60005C2")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005C3")]
		public <>c() { }

		[Address(RVA = "0x1A189A0", Offset = "0x1A17BA0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005C4")]
		internal int <DescribeFields>b__0_0(RectInt r) { }

		[Address(RVA = "0x1A189C0", Offset = "0x1A17BC0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005C5")]
		internal void <DescribeFields>b__0_1(ref RectInt r, int v) { }

		[Address(RVA = "0x1A18CE0", Offset = "0x1A17EE0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005C6")]
		internal int <DescribeFields>b__0_2(RectInt r) { }

		[Address(RVA = "0x1A18D00", Offset = "0x1A17F00", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005C7")]
		internal void <DescribeFields>b__0_3(ref RectInt r, int v) { }

		[Address(RVA = "0x1A188A0", Offset = "0x1A17AA0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005C8")]
		internal int <DescribeFields>b__0_4(RectInt r) { }

		[Address(RVA = "0x1A188B0", Offset = "0x1A17AB0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005C9")]
		internal void <DescribeFields>b__0_5(ref RectInt r, int v) { }

		[Address(RVA = "0x19F5ED0", Offset = "0x19F50D0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005CA")]
		internal int <DescribeFields>b__0_6(RectInt r) { }

		[Address(RVA = "0x19F5EF0", Offset = "0x19F50F0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005CB")]
		internal void <DescribeFields>b__0_7(ref RectInt r, int v) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000A4")]
	internal class UxmlFactory : UxmlFactory<RectIntField, UxmlTraits>
	{

		[Address(RVA = "0x1BE5480", Offset = "0x1BE4680", Length = "0x39")]
		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60005BF")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000A5")]
	internal class UxmlTraits : UxmlTraits<RectInt>
	{
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x400037C")]
		private UxmlIntAttributeDescription m_XValue; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x400037D")]
		private UxmlIntAttributeDescription m_YValue; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x400037E")]
		private UxmlIntAttributeDescription m_WValue; //Field offset: 0xA8
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x400037F")]
		private UxmlIntAttributeDescription m_HValue; //Field offset: 0xB0

		[Address(RVA = "0x1BE94B0", Offset = "0x1BE86B0", Length = "0x1AF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UxmlIntAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1+UxmlTraits<UnityEngine.RectInt>), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60005C1")]
		public UxmlTraits() { }

		[Address(RVA = "0x1BE61F0", Offset = "0x1BE53F0", Length = "0x274")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 5)]
		[Token(Token = "0x60005C0")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x4000379")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x400037A")]
	public static readonly string labelUssClassName; //Field offset: 0x8
	[Token(Token = "0x400037B")]
	public static readonly string inputUssClassName; //Field offset: 0x10

	[Address(RVA = "0x1BE3BC0", Offset = "0x1BE2DC0", Length = "0x112")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x60005BE")]
	private static RectIntField() { }

	[Address(RVA = "0x1BE3CE0", Offset = "0x1BE2EE0", Length = "0x133")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseCompositeField`3<UnityEngine.RectInt, System.Object, System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005BC")]
	public RectIntField() { }

	[Address(RVA = "0x1BE3E20", Offset = "0x1BE3020", Length = "0x140")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseCompositeField`3<UnityEngine.RectInt, System.Object, System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005BD")]
	public RectIntField(string label) { }

	[Address(RVA = "0x1BE33C0", Offset = "0x1BE25C0", Length = "0x7FF")]
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
	[Token(Token = "0x60005BB")]
	internal virtual FieldDescription<RectInt, IntegerField, Int32>[] DescribeFields() { }

}

