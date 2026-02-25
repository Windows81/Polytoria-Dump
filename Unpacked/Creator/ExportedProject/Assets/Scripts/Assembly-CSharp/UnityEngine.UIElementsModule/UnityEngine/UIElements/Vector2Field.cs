namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Token(Token = "0x20000A7")]
public class Vector2Field : BaseCompositeField<Vector2, FloatField, Single>
{
	[CompilerGenerated]
	[Token(Token = "0x20000AA")]
	private sealed class <>c
	{
		[Token(Token = "0x400038E")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400038F")]
		public static Func<Vector2, Single> <>9__0_0; //Field offset: 0x8
		[Token(Token = "0x4000390")]
		public static WriteDelegate<Vector2, FloatField, Single> <>9__0_1; //Field offset: 0x10
		[Token(Token = "0x4000391")]
		public static Func<Vector2, Single> <>9__0_2; //Field offset: 0x18
		[Token(Token = "0x4000392")]
		public static WriteDelegate<Vector2, FloatField, Single> <>9__0_3; //Field offset: 0x20

		[Address(RVA = "0x1BE4DA0", Offset = "0x1BE3FA0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60005D3")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005D4")]
		public <>c() { }

		[Address(RVA = "0x1BE49D0", Offset = "0x1BE3BD0", Length = "0xC")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60005D5")]
		internal float <DescribeFields>b__0_0(Vector2 r) { }

		[Address(RVA = "0x1A13390", Offset = "0x1A12590", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005D6")]
		internal void <DescribeFields>b__0_1(ref Vector2 r, float v) { }

		[Address(RVA = "0x1BE49E0", Offset = "0x1BE3BE0", Length = "0xC")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60005D7")]
		internal float <DescribeFields>b__0_2(Vector2 r) { }

		[Address(RVA = "0x19F5B20", Offset = "0x19F4D20", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005D8")]
		internal void <DescribeFields>b__0_3(ref Vector2 r, float v) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000A8")]
	internal class UxmlFactory : UxmlFactory<Vector2Field, UxmlTraits>
	{

		[Address(RVA = "0x1BE54C0", Offset = "0x1BE46C0", Length = "0x39")]
		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60005D0")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000A9")]
	internal class UxmlTraits : UxmlTraits<Vector2>
	{
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x400038C")]
		private UxmlFloatAttributeDescription m_XValue; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x400038D")]
		private UxmlFloatAttributeDescription m_YValue; //Field offset: 0xA0

		[Address(RVA = "0x1BE9B90", Offset = "0x1BE8D90", Length = "0xFF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UxmlFloatAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1+UxmlTraits<UnityEngine.Vector2>), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60005D2")]
		public UxmlTraits() { }

		[Address(RVA = "0x1BE7BC0", Offset = "0x1BE6DC0", Length = "0x1BE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x60005D1")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x4000389")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x400038A")]
	public static readonly string labelUssClassName; //Field offset: 0x8
	[Token(Token = "0x400038B")]
	public static readonly string inputUssClassName; //Field offset: 0x10

	[Address(RVA = "0x1BEA3E0", Offset = "0x1BE95E0", Length = "0x112")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x60005CF")]
	private static Vector2Field() { }

	[Address(RVA = "0x1BEA500", Offset = "0x1BE9700", Length = "0x116")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseCompositeField`3<UnityEngine.Vector2, System.Object, System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005CD")]
	public Vector2Field() { }

	[Address(RVA = "0x1BEA620", Offset = "0x1BE9820", Length = "0x123")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseCompositeField`3<UnityEngine.Vector2, System.Object, System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005CE")]
	public Vector2Field(string label) { }

	[Address(RVA = "0x1BE9F80", Offset = "0x1BE9180", Length = "0x456")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Func`2<UnityEngine.Vector2, System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(WriteDelegate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FieldDescription), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), "System.Func`2<TValueType, TFieldValue>", "UnityEngine.UIElements.BaseCompositeField`3<TValueType, TField, TFieldValue>+FieldDescription<TValueType, TField, TFieldValue>+WriteDelegate<TValueType, TField, TFieldValue>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60005CC")]
	internal virtual FieldDescription<Vector2, FloatField, Single>[] DescribeFields() { }

}

