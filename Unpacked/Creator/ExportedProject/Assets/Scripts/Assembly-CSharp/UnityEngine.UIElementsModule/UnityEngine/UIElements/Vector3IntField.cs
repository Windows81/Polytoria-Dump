namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Token(Token = "0x20000B7")]
public class Vector3IntField : BaseCompositeField<Vector3Int, IntegerField, Int32>
{
	[CompilerGenerated]
	[Token(Token = "0x20000BA")]
	private sealed class <>c
	{
		[Token(Token = "0x40003C0")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40003C1")]
		public static Func<Vector3Int, Int32> <>9__0_0; //Field offset: 0x8
		[Token(Token = "0x40003C2")]
		public static WriteDelegate<Vector3Int, IntegerField, Int32> <>9__0_1; //Field offset: 0x10
		[Token(Token = "0x40003C3")]
		public static Func<Vector3Int, Int32> <>9__0_2; //Field offset: 0x18
		[Token(Token = "0x40003C4")]
		public static WriteDelegate<Vector3Int, IntegerField, Int32> <>9__0_3; //Field offset: 0x20
		[Token(Token = "0x40003C5")]
		public static Func<Vector3Int, Int32> <>9__0_4; //Field offset: 0x28
		[Token(Token = "0x40003C6")]
		public static WriteDelegate<Vector3Int, IntegerField, Int32> <>9__0_5; //Field offset: 0x30

		[Address(RVA = "0x1BE4B70", Offset = "0x1BE3D70", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600060D")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600060E")]
		public <>c() { }

		[Address(RVA = "0x1A189A0", Offset = "0x1A17BA0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600060F")]
		internal int <DescribeFields>b__0_0(Vector3Int r) { }

		[Address(RVA = "0x1A189C0", Offset = "0x1A17BC0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000610")]
		internal void <DescribeFields>b__0_1(ref Vector3Int r, int v) { }

		[Address(RVA = "0x1A18CE0", Offset = "0x1A17EE0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000611")]
		internal int <DescribeFields>b__0_2(Vector3Int r) { }

		[Address(RVA = "0x1A18D00", Offset = "0x1A17F00", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000612")]
		internal void <DescribeFields>b__0_3(ref Vector3Int r, int v) { }

		[Address(RVA = "0x1A188A0", Offset = "0x1A17AA0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000613")]
		internal int <DescribeFields>b__0_4(Vector3Int r) { }

		[Address(RVA = "0x1A188B0", Offset = "0x1A17AB0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000614")]
		internal void <DescribeFields>b__0_5(ref Vector3Int r, int v) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000B8")]
	internal class UxmlFactory : UxmlFactory<Vector3IntField, UxmlTraits>
	{

		[Address(RVA = "0x1BE55C0", Offset = "0x1BE47C0", Length = "0x39")]
		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x600060A")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000B9")]
	internal class UxmlTraits : UxmlTraits<Vector3Int>
	{
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x40003BD")]
		private UxmlIntAttributeDescription m_XValue; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x40003BE")]
		private UxmlIntAttributeDescription m_YValue; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x40003BF")]
		private UxmlIntAttributeDescription m_ZValue; //Field offset: 0xA8

		[Address(RVA = "0x1BE9350", Offset = "0x1BE8550", Length = "0x157")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UxmlIntAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1+UxmlTraits<UnityEngine.Vector3Int>), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600060C")]
		public UxmlTraits() { }

		[Address(RVA = "0x1BE7F60", Offset = "0x1BE7160", Length = "0x224")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 4)]
		[Token(Token = "0x600060B")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x40003BA")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x40003BB")]
	public static readonly string labelUssClassName; //Field offset: 0x8
	[Token(Token = "0x40003BC")]
	public static readonly string inputUssClassName; //Field offset: 0x10

	[Address(RVA = "0x1BEBDE0", Offset = "0x1BEAFE0", Length = "0x112")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000609")]
	private static Vector3IntField() { }

	[Address(RVA = "0x1BEBF00", Offset = "0x1BEB100", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3IntField), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000607")]
	public Vector3IntField() { }

	[Address(RVA = "0x1BEBF10", Offset = "0x1BEB110", Length = "0x123")]
	[CalledBy(Type = typeof(BoundsIntField), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Vector3IntField), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseCompositeField`3<UnityEngine.Vector3Int, System.Object, System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000608")]
	public Vector3IntField(string label) { }

	[Address(RVA = "0x1BEB7B0", Offset = "0x1BEA9B0", Length = "0x626")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Func`2<UnityEngine.Vector3Int, System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(WriteDelegate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FieldDescription), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), "System.Func`2<TValueType, TFieldValue>", "UnityEngine.UIElements.BaseCompositeField`3<TValueType, TField, TFieldValue>+FieldDescription<TValueType, TField, TFieldValue>+WriteDelegate<TValueType, TField, TFieldValue>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000606")]
	internal virtual FieldDescription<Vector3Int, IntegerField, Int32>[] DescribeFields() { }

}

