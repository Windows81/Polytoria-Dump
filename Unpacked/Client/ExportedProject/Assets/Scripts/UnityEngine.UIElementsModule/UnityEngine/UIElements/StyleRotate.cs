namespace UnityEngine.UIElements;

[Token(Token = "0x2000402")]
public struct StyleRotate : IStyleValue<Rotate>, IEquatable<StyleRotate>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D63")]
	private Rotate m_Value; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000D64")]
	private StyleKeyword m_Keyword; //Field offset: 0x18

	[Token(Token = "0x1700087D")]
	public override StyleKeyword keyword
	{
		[Address(RVA = "0x8520C0", Offset = "0x8512C0", Length = "0x6")]
		[CallerCount(Count = 44)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001EBD")]
		 get { } //Length: 6
		[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001EBE")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700087C")]
	public override Rotate value
	{
		[Address(RVA = "0x1B19200", Offset = "0x1B18400", Length = "0x12D")]
		[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleRotate), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyInlineStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_rotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Rotate), Member = "None", ReturnType = typeof(Rotate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001EBB")]
		 get { } //Length: 301
		[Address(RVA = "0x1B191C0", Offset = "0x1B183C0", Length = "0x18")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001EBC")]
		 set { } //Length: 24
	}

	[Address(RVA = "0x1B191C0", Offset = "0x1B183C0", Length = "0x18")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EBF")]
	public StyleRotate(Rotate v) { }

	[Address(RVA = "0x1B19190", Offset = "0x1B18390", Length = "0x24")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EC0")]
	public StyleRotate(StyleKeyword keyword) { }

	[Address(RVA = "0x1B191E0", Offset = "0x1B183E0", Length = "0x15")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EC1")]
	internal StyleRotate(Rotate v, StyleKeyword keyword) { }

	[Address(RVA = "0x1B19060", Offset = "0x1B18260", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Rotate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rotate), typeof(Rotate)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001EC5")]
	public override bool Equals(StyleRotate other) { }

	[Address(RVA = "0x1B18F60", Offset = "0x1B18160", Length = "0xF5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(Rotate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rotate), typeof(Rotate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6001EC6")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x8520C0", Offset = "0x8512C0", Length = "0x6")]
	[CallerCount(Count = 44)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EBD")]
	public override StyleKeyword get_keyword() { }

	[Address(RVA = "0x1B19200", Offset = "0x1B18400", Length = "0x12D")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleRotate), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyInlineStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_rotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Rotate), Member = "None", ReturnType = typeof(Rotate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001EBB")]
	public override Rotate get_value() { }

	[Address(RVA = "0x1B190F0", Offset = "0x1B182F0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Rotate), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x6001EC7")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1B19330", Offset = "0x1B18530", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Rotate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rotate), typeof(Rotate)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001EC2")]
	public static bool op_Equality(StyleRotate lhs, StyleRotate rhs) { }

	[Address(RVA = "0x1B193F0", Offset = "0x1B185F0", Length = "0x27")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EC3")]
	public static StyleRotate op_Implicit(StyleKeyword keyword) { }

	[Address(RVA = "0x1B193C0", Offset = "0x1B185C0", Length = "0x21")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EC4")]
	public static StyleRotate op_Implicit(Rotate v) { }

	[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EBE")]
	public override void set_keyword(StyleKeyword value) { }

	[Address(RVA = "0x1B191C0", Offset = "0x1B183C0", Length = "0x18")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EBC")]
	public override void set_value(Rotate value) { }

	[Address(RVA = "0x1B19110", Offset = "0x1B18310", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(StyleValueExtensions), Member = "DebugString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IStyleValue`1<T>"}, ReturnType = typeof(string))]
	[Token(Token = "0x6001EC8")]
	public virtual string ToString() { }

}

