namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Token(Token = "0x20000AF")]
public class Vector4Field : BaseCompositeField<Vector4, FloatField, Single>
{
	[CompilerGenerated]
	[Token(Token = "0x20000B2")]
	private sealed class <>c
	{
		[Token(Token = "0x40003A7")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40003A8")]
		public static Func<Vector4, Single> <>9__0_0; //Field offset: 0x8
		[Token(Token = "0x40003A9")]
		public static WriteDelegate<Vector4, FloatField, Single> <>9__0_1; //Field offset: 0x10
		[Token(Token = "0x40003AA")]
		public static Func<Vector4, Single> <>9__0_2; //Field offset: 0x18
		[Token(Token = "0x40003AB")]
		public static WriteDelegate<Vector4, FloatField, Single> <>9__0_3; //Field offset: 0x20
		[Token(Token = "0x40003AC")]
		public static Func<Vector4, Single> <>9__0_4; //Field offset: 0x28
		[Token(Token = "0x40003AD")]
		public static WriteDelegate<Vector4, FloatField, Single> <>9__0_5; //Field offset: 0x30
		[Token(Token = "0x40003AE")]
		public static Func<Vector4, Single> <>9__0_6; //Field offset: 0x38
		[Token(Token = "0x40003AF")]
		public static WriteDelegate<Vector4, FloatField, Single> <>9__0_7; //Field offset: 0x40

		[Address(RVA = "0x1BE4E10", Offset = "0x1BE4010", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60005EF")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005F0")]
		public <>c() { }

		[Address(RVA = "0x1A13380", Offset = "0x1A12580", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005F1")]
		internal float <DescribeFields>b__0_0(Vector4 r) { }

		[Address(RVA = "0x1A13390", Offset = "0x1A12590", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005F2")]
		internal void <DescribeFields>b__0_1(ref Vector4 r, float v) { }

		[Address(RVA = "0x19F5B10", Offset = "0x19F4D10", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005F3")]
		internal float <DescribeFields>b__0_2(Vector4 r) { }

		[Address(RVA = "0x19F5B20", Offset = "0x19F4D20", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005F4")]
		internal void <DescribeFields>b__0_3(ref Vector4 r, float v) { }

		[Address(RVA = "0x19F4E40", Offset = "0x19F4040", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005F5")]
		internal float <DescribeFields>b__0_4(Vector4 r) { }

		[Address(RVA = "0x19F4E50", Offset = "0x19F4050", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005F6")]
		internal void <DescribeFields>b__0_5(ref Vector4 r, float v) { }

		[Address(RVA = "0x19F4BC0", Offset = "0x19F3DC0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005F7")]
		internal float <DescribeFields>b__0_6(Vector4 r) { }

		[Address(RVA = "0x19F4BD0", Offset = "0x19F3DD0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005F8")]
		internal void <DescribeFields>b__0_7(ref Vector4 r, float v) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000B0")]
	internal class UxmlFactory : UxmlFactory<Vector4Field, UxmlTraits>
	{

		[Address(RVA = "0x1BE5300", Offset = "0x1BE4500", Length = "0x39")]
		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60005EC")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000B1")]
	internal class UxmlTraits : UxmlTraits<Vector4>
	{
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x40003A3")]
		private UxmlFloatAttributeDescription m_XValue; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x40003A4")]
		private UxmlFloatAttributeDescription m_YValue; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x40003A5")]
		private UxmlFloatAttributeDescription m_ZValue; //Field offset: 0xA8
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x40003A6")]
		private UxmlFloatAttributeDescription m_WValue; //Field offset: 0xB0

		[Address(RVA = "0x1BE83D0", Offset = "0x1BE75D0", Length = "0x1AF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UxmlFloatAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1+UxmlTraits<UnityEngine.Vector4>), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60005EE")]
		public UxmlTraits() { }

		[Address(RVA = "0x1BE5700", Offset = "0x1BE4900", Length = "0x2A4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 5)]
		[Token(Token = "0x60005ED")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x40003A0")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x40003A1")]
	public static readonly string labelUssClassName; //Field offset: 0x8
	[Token(Token = "0x40003A2")]
	public static readonly string inputUssClassName; //Field offset: 0x10

	[Address(RVA = "0x1BEC840", Offset = "0x1BEBA40", Length = "0x112")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x60005EB")]
	private static Vector4Field() { }

	[Address(RVA = "0x1BEC960", Offset = "0x1BEBB60", Length = "0x116")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseCompositeField`3<UnityEngine.Vector4, System.Object, System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005E9")]
	public Vector4Field() { }

	[Address(RVA = "0x1BECA80", Offset = "0x1BEBC80", Length = "0x123")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseCompositeField`3<UnityEngine.Vector4, System.Object, System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005EA")]
	public Vector4Field(string label) { }

	[Address(RVA = "0x1BEC040", Offset = "0x1BEB240", Length = "0x7FF")]
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
	[Token(Token = "0x60005E8")]
	internal virtual FieldDescription<Vector4, FloatField, Single>[] DescribeFields() { }

}

