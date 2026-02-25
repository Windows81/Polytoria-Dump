namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Token(Token = "0x20000AB")]
public class Vector3Field : BaseCompositeField<Vector3, FloatField, Single>
{
	[CompilerGenerated]
	[Token(Token = "0x20000AE")]
	private sealed class <>c
	{
		[Token(Token = "0x4000399")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400039A")]
		public static Func<Vector3, Single> <>9__0_0; //Field offset: 0x8
		[Token(Token = "0x400039B")]
		public static WriteDelegate<Vector3, FloatField, Single> <>9__0_1; //Field offset: 0x10
		[Token(Token = "0x400039C")]
		public static Func<Vector3, Single> <>9__0_2; //Field offset: 0x18
		[Token(Token = "0x400039D")]
		public static WriteDelegate<Vector3, FloatField, Single> <>9__0_3; //Field offset: 0x20
		[Token(Token = "0x400039E")]
		public static Func<Vector3, Single> <>9__0_4; //Field offset: 0x28
		[Token(Token = "0x400039F")]
		public static WriteDelegate<Vector3, FloatField, Single> <>9__0_5; //Field offset: 0x30

		[Address(RVA = "0x1BE4BE0", Offset = "0x1BE3DE0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60005E0")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005E1")]
		public <>c() { }

		[Address(RVA = "0x1A13380", Offset = "0x1A12580", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005E2")]
		internal float <DescribeFields>b__0_0(Vector3 r) { }

		[Address(RVA = "0x1A13390", Offset = "0x1A12590", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005E3")]
		internal void <DescribeFields>b__0_1(ref Vector3 r, float v) { }

		[Address(RVA = "0x19F5B10", Offset = "0x19F4D10", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005E4")]
		internal float <DescribeFields>b__0_2(Vector3 r) { }

		[Address(RVA = "0x19F5B20", Offset = "0x19F4D20", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005E5")]
		internal void <DescribeFields>b__0_3(ref Vector3 r, float v) { }

		[Address(RVA = "0x19F4E40", Offset = "0x19F4040", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005E6")]
		internal float <DescribeFields>b__0_4(Vector3 r) { }

		[Address(RVA = "0x19F4E50", Offset = "0x19F4050", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005E7")]
		internal void <DescribeFields>b__0_5(ref Vector3 r, float v) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000AC")]
	internal class UxmlFactory : UxmlFactory<Vector3Field, UxmlTraits>
	{

		[Address(RVA = "0x1BE52C0", Offset = "0x1BE44C0", Length = "0x39")]
		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60005DD")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000AD")]
	internal class UxmlTraits : UxmlTraits<Vector3>
	{
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4000396")]
		private UxmlFloatAttributeDescription m_XValue; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4000397")]
		private UxmlFloatAttributeDescription m_YValue; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4000398")]
		private UxmlFloatAttributeDescription m_ZValue; //Field offset: 0xA8

		[Address(RVA = "0x1BE8960", Offset = "0x1BE7B60", Length = "0x157")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UxmlFloatAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1+UxmlTraits<UnityEngine.Vector3>), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60005DF")]
		public UxmlTraits() { }

		[Address(RVA = "0x1BE8190", Offset = "0x1BE7390", Length = "0x233")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 4)]
		[Token(Token = "0x60005DE")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x4000393")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x4000394")]
	public static readonly string labelUssClassName; //Field offset: 0x8
	[Token(Token = "0x4000395")]
	public static readonly string inputUssClassName; //Field offset: 0x10

	[Address(RVA = "0x1BEB550", Offset = "0x1BEA750", Length = "0x112")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x60005DC")]
	private static Vector3Field() { }

	[Address(RVA = "0x1BEB7A0", Offset = "0x1BEA9A0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3Field), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60005DA")]
	public Vector3Field() { }

	[Address(RVA = "0x1BEB670", Offset = "0x1BEA870", Length = "0x123")]
	[CalledBy(Type = typeof(BoundsField), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Vector3Field), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseCompositeField`3<UnityEngine.Vector3, System.Object, System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005DB")]
	public Vector3Field(string label) { }

	[Address(RVA = "0x1BEAF20", Offset = "0x1BEA120", Length = "0x626")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Func`2<UnityEngine.Vector3, System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(WriteDelegate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FieldDescription), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), "System.Func`2<TValueType, TFieldValue>", "UnityEngine.UIElements.BaseCompositeField`3<TValueType, TField, TFieldValue>+FieldDescription<TValueType, TField, TFieldValue>+WriteDelegate<TValueType, TField, TFieldValue>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60005D9")]
	internal virtual FieldDescription<Vector3, FloatField, Single>[] DescribeFields() { }

}

