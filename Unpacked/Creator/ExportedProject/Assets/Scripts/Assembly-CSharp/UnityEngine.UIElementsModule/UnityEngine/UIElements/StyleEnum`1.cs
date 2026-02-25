namespace UnityEngine.UIElements;

[Token(Token = "0x20003FB")]
public struct StyleEnum : IStyleValue<T>, IEquatable<StyleEnum`1<T>>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D55")]
	private T m_Value; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D56")]
	private StyleKeyword m_Keyword; //Field offset: 0x0

	[Token(Token = "0x1700086F")]
	public override StyleKeyword keyword
	{
		[Address(RVA = "0xF698A0", Offset = "0xF68AA0", Length = "0x6")]
		[CallerCount(Count = 54)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001E59")]
		 get { } //Length: 6
		[Address(RVA = "0x3B8830", Offset = "0x3B7A30", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001E5A")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700086E")]
	public override T value
	{
		[Address(RVA = "0xF69A80", Offset = "0xF68C80", Length = "0xC")]
		[CallerCount(Count = 25)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001E57")]
		 get { } //Length: 12
		[Address(RVA = "0xF6A340", Offset = "0xF69540", Length = "0xA")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001E58")]
		 set { } //Length: 10
	}

	[Address(RVA = "0xF696D0", Offset = "0xF688D0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E5B")]
	public StyleEnum`1(T v) { }

	[Address(RVA = "0xF69690", Offset = "0xF68890", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E5C")]
	public StyleEnum`1(StyleKeyword keyword) { }

	[Address(RVA = "0xF69840", Offset = "0xF68A40", Length = "0x7")]
	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E5D")]
	internal StyleEnum`1(T v, StyleKeyword keyword) { }

	[Address(RVA = "0xF68DC0", Offset = "0xF67FC0", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E62")]
	public override bool Equals(StyleEnum<T> other) { }

	[Address(RVA = "0xF68E40", Offset = "0xF68040", Length = "0x100")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800B4700")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E63")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xF698A0", Offset = "0xF68AA0", Length = "0x6")]
	[CallerCount(Count = 54)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E59")]
	public override StyleKeyword get_keyword() { }

	[Address(RVA = "0xF69A80", Offset = "0xF68C80", Length = "0xC")]
	[CallerCount(Count = 25)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E57")]
	public override T get_value() { }

	[Address(RVA = "0xF69280", Offset = "0xF68480", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E64")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0xF69D40", Offset = "0xF68F40", Length = "0x4E")]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "CycleItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Fill", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "ApplyScrollViewUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "VisibleItemPredicate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "Refresh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E5E")]
	public static bool op_Equality(StyleEnum<T> lhs, StyleEnum<T> rhs) { }

	[Address(RVA = "0xF69D90", Offset = "0xF68F90", Length = "0x51")]
	[CalledBy(Type = typeof(UIDocument), Member = "SetupRootClassList", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "ClearManualLayout", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E60")]
	public static StyleEnum<T> op_Implicit(StyleKeyword keyword) { }

	[Address(RVA = "0xF6A0B0", Offset = "0xF692B0", Length = "0x51")]
	[CallerCount(Count = 54)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E61")]
	public static StyleEnum<T> op_Implicit(T v) { }

	[Address(RVA = "0xF6A110", Offset = "0xF69310", Length = "0x76")]
	[CalledBy(Type = typeof(ScrollView), Member = "UpdateScrollers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E5F")]
	public static bool op_Inequality(StyleEnum<T> lhs, StyleEnum<T> rhs) { }

	[Address(RVA = "0x3B8830", Offset = "0x3B7A30", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E5A")]
	public override void set_keyword(StyleKeyword value) { }

	[Address(RVA = "0xF6A340", Offset = "0xF69540", Length = "0xA")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E58")]
	public override void set_value(T value) { }

	[Address(RVA = "0xF693D0", Offset = "0xF685D0", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(StyleValueExtensions), Member = "DebugString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IStyleValue`1<T>"}, ReturnType = typeof(string))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E65")]
	public virtual string ToString() { }

}

