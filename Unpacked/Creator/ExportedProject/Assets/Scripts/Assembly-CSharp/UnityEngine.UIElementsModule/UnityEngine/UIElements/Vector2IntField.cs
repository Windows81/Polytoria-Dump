namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Token(Token = "0x20000B3")]
public class Vector2IntField : BaseCompositeField<Vector2Int, IntegerField, Int32>
{
	[CompilerGenerated]
	[Token(Token = "0x20000B6")]
	private sealed class <>c
	{
		[Token(Token = "0x40003B5")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40003B6")]
		public static Func<Vector2Int, Int32> <>9__0_0; //Field offset: 0x8
		[Token(Token = "0x40003B7")]
		public static WriteDelegate<Vector2Int, IntegerField, Int32> <>9__0_1; //Field offset: 0x10
		[Token(Token = "0x40003B8")]
		public static Func<Vector2Int, Int32> <>9__0_2; //Field offset: 0x18
		[Token(Token = "0x40003B9")]
		public static WriteDelegate<Vector2Int, IntegerField, Int32> <>9__0_3; //Field offset: 0x20

		[Address(RVA = "0x1BE4B00", Offset = "0x1BE3D00", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000600")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000601")]
		public <>c() { }

		[Address(RVA = "0x8D4220", Offset = "0x8D3420", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000602")]
		internal int <DescribeFields>b__0_0(Vector2Int r) { }

		[Address(RVA = "0x1A189C0", Offset = "0x1A17BC0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000603")]
		internal void <DescribeFields>b__0_1(ref Vector2Int r, int v) { }

		[Address(RVA = "0x1B2A4A0", Offset = "0x1B296A0", Length = "0x9")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000604")]
		internal int <DescribeFields>b__0_2(Vector2Int r) { }

		[Address(RVA = "0x1A18D00", Offset = "0x1A17F00", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000605")]
		internal void <DescribeFields>b__0_3(ref Vector2Int r, int v) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000B4")]
	internal class UxmlFactory : UxmlFactory<Vector2IntField, UxmlTraits>
	{

		[Address(RVA = "0x1BE5600", Offset = "0x1BE4800", Length = "0x39")]
		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60005FD")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000B5")]
	internal class UxmlTraits : UxmlTraits<Vector2Int>
	{
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x40003B3")]
		private UxmlIntAttributeDescription m_XValue; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x40003B4")]
		private UxmlIntAttributeDescription m_YValue; //Field offset: 0xA0

		[Address(RVA = "0x1BE8EE0", Offset = "0x1BE80E0", Length = "0xFF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UxmlIntAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1+UxmlTraits<UnityEngine.Vector2Int>), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60005FF")]
		public UxmlTraits() { }

		[Address(RVA = "0x1BE7330", Offset = "0x1BE6530", Length = "0x1B9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x60005FE")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x40003B0")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x40003B1")]
	public static readonly string labelUssClassName; //Field offset: 0x8
	[Token(Token = "0x40003B2")]
	public static readonly string inputUssClassName; //Field offset: 0x10

	[Address(RVA = "0x1BEABB0", Offset = "0x1BE9DB0", Length = "0x112")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x60005FC")]
	private static Vector2IntField() { }

	[Address(RVA = "0x1BEAE00", Offset = "0x1BEA000", Length = "0x116")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseCompositeField`3<UnityEngine.Vector2Int, System.Object, System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005FA")]
	public Vector2IntField() { }

	[Address(RVA = "0x1BEACD0", Offset = "0x1BE9ED0", Length = "0x123")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseCompositeField`3<UnityEngine.Vector2Int, System.Object, System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005FB")]
	public Vector2IntField(string label) { }

	[Address(RVA = "0x1BEA750", Offset = "0x1BE9950", Length = "0x456")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Func`2<UnityEngine.Vector2Int, System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(WriteDelegate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FieldDescription), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), "System.Func`2<TValueType, TFieldValue>", "UnityEngine.UIElements.BaseCompositeField`3<TValueType, TField, TFieldValue>+FieldDescription<TValueType, TField, TFieldValue>+WriteDelegate<TValueType, TField, TFieldValue>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60005F9")]
	internal virtual FieldDescription<Vector2Int, IntegerField, Int32>[] DescribeFields() { }

}

