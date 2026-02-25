namespace UnityEngine.UIElements;

[Token(Token = "0x2000401")]
public struct StyleList : IStyleValue<List`1<T>>, IEquatable<StyleList`1<T>>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D61")]
	private StyleKeyword m_Keyword; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D62")]
	private List<T> m_Value; //Field offset: 0x0

	[Token(Token = "0x1700087B")]
	public override StyleKeyword keyword
	{
		[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
		[CallerCount(Count = 230)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001EB1")]
		 get { } //Length: 5
		[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001EB2")]
		 set { } //Length: 3
	}

	[Token(Token = "0x1700087A")]
	public override List<T> value
	{
		[Address(RVA = "0xF6BA60", Offset = "0xF6AC60", Length = "0xD")]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleList`1<T>"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001EAF")]
		 get { } //Length: 13
		[Address(RVA = "0xF6BF60", Offset = "0xF6B160", Length = "0x22")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001EB0")]
		 set { } //Length: 34
	}

	[Address(RVA = "0xF6BA10", Offset = "0xF6AC10", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EB3")]
	public StyleList`1(StyleKeyword keyword) { }

	[Address(RVA = "0xF6BA00", Offset = "0xF6AC00", Length = "0x10")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "GetStyleList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = "UnityEngine.UIElements.StyleList`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EB4")]
	internal StyleList`1(List<T> v, StyleKeyword keyword) { }

	[Address(RVA = "0xF6AB40", Offset = "0xF69D40", Length = "0xE7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Enumerable), Member = "SequenceEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EasingFunction)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.EasingFunction>), typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.EasingFunction>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EB7")]
	public override bool Equals(StyleList<T> other) { }

	[Address(RVA = "0xF6A690", Offset = "0xF69890", Length = "0x107")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800B4750")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EB8")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
	[CallerCount(Count = 230)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EB1")]
	public override StyleKeyword get_keyword() { }

	[Address(RVA = "0xF6BA60", Offset = "0xF6AC60", Length = "0xD")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleList`1<T>"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EAF")]
	public override List<T> get_value() { }

	[Address(RVA = "0xF6B1D0", Offset = "0xF6A3D0", Length = "0x2B8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180027C30")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<UnityEngine.UIElements.EasingFunction>), Member = "CreateComparer", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<UnityEngine.UIElements.EasingFunction>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EB9")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0xF6BA70", Offset = "0xF6AC70", Length = "0xB2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Enumerable), Member = "SequenceEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EasingFunction)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.EasingFunction>), typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.EasingFunction>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EB5")]
	public static bool op_Equality(StyleList<T> lhs, StyleList<T> rhs) { }

	[Address(RVA = "0xF6BE20", Offset = "0xF6B020", Length = "0x7E")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "GetStyleList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = "UnityEngine.UIElements.StyleList`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EB6")]
	public static StyleList<T> op_Implicit(StyleKeyword keyword) { }

	[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EB2")]
	public override void set_keyword(StyleKeyword value) { }

	[Address(RVA = "0xF6BF60", Offset = "0xF6B160", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EB0")]
	public override void set_value(List<T> value) { }

	[Address(RVA = "0xF6B840", Offset = "0xF6AA40", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(StyleValueExtensions), Member = "DebugString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.IStyleValue`1<System.Object>)}, ReturnType = typeof(string))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EBA")]
	public virtual string ToString() { }

}

