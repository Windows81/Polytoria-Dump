namespace UnityEngine.UIElements;

[Token(Token = "0x2000405")]
public struct StyleTransformOrigin : IStyleValue<TransformOrigin>, IEquatable<StyleTransformOrigin>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D69")]
	private TransformOrigin m_Value; //Field offset: 0x0
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000D6A")]
	private StyleKeyword m_Keyword; //Field offset: 0x14

	[Token(Token = "0x17000883")]
	public override StyleKeyword keyword
	{
		[Address(RVA = "0xB08210", Offset = "0xB07410", Length = "0x6")]
		[CallerCount(Count = 32)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001EE5")]
		 get { } //Length: 6
		[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001EE6")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000882")]
	public override TransformOrigin value
	{
		[Address(RVA = "0x1B19E60", Offset = "0x1B19060", Length = "0x113")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleTransformOrigin), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyInlineStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_transformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTransformOrigin)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTransformOrigin)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTransformOrigin)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001EE3")]
		 get { } //Length: 275
		[Address(RVA = "0x1B15E50", Offset = "0x1B15050", Length = "0x14")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001EE4")]
		 set { } //Length: 20
	}

	[Address(RVA = "0x1B15E50", Offset = "0x1B15050", Length = "0x14")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EE7")]
	public StyleTransformOrigin(TransformOrigin v) { }

	[Address(RVA = "0x1B15D40", Offset = "0x1B14F40", Length = "0xF")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EE8")]
	public StyleTransformOrigin(StyleKeyword keyword) { }

	[Address(RVA = "0x1B15D20", Offset = "0x1B14F20", Length = "0x11")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EE9")]
	internal StyleTransformOrigin(TransformOrigin v, StyleKeyword keyword) { }

	[Address(RVA = "0x1B19C40", Offset = "0x1B18E40", Length = "0xE6")]
	[CalledBy(Type = typeof(StyleTransformOrigin), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001EED")]
	public override bool Equals(StyleTransformOrigin other) { }

	[Address(RVA = "0x1B19D30", Offset = "0x1B18F30", Length = "0x9B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(StyleTransformOrigin), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTransformOrigin)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6001EEE")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xB08210", Offset = "0xB07410", Length = "0x6")]
	[CallerCount(Count = 32)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EE5")]
	public override StyleKeyword get_keyword() { }

	[Address(RVA = "0x1B19E60", Offset = "0x1B19060", Length = "0x113")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleTransformOrigin), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyInlineStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_transformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTransformOrigin)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTransformOrigin)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTransformOrigin)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001EE3")]
	public override TransformOrigin get_value() { }

	[Address(RVA = "0x1B19DD0", Offset = "0x1B18FD0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001EEF")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1B19F80", Offset = "0x1B19180", Length = "0xE6")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001EEA")]
	public static bool op_Equality(StyleTransformOrigin lhs, StyleTransformOrigin rhs) { }

	[Address(RVA = "0x1B15E20", Offset = "0x1B15020", Length = "0x27")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EEB")]
	public static StyleTransformOrigin op_Implicit(StyleKeyword keyword) { }

	[Address(RVA = "0x1B1A070", Offset = "0x1B19270", Length = "0x2B")]
	[CalledBy(Type = typeof(UIDocument), Member = "SetTransform", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6001EEC")]
	public static StyleTransformOrigin op_Implicit(TransformOrigin v) { }

	[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EE6")]
	public override void set_keyword(StyleKeyword value) { }

	[Address(RVA = "0x1B15E50", Offset = "0x1B15050", Length = "0x14")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EE4")]
	public override void set_value(TransformOrigin value) { }

	[Address(RVA = "0x1B19DF0", Offset = "0x1B18FF0", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(StyleValueExtensions), Member = "DebugString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IStyleValue`1<T>"}, ReturnType = typeof(string))]
	[Token(Token = "0x6001EF0")]
	public virtual string ToString() { }

}

