namespace UnityEngine.UIElements;

[Token(Token = "0x20003F3")]
public struct StyleBackground : IStyleValue<Background>, IEquatable<StyleBackground>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D44")]
	private Background m_Value; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000D45")]
	private StyleKeyword m_Keyword; //Field offset: 0x20

	[Token(Token = "0x17000862")]
	public override StyleKeyword keyword
	{
		[Address(RVA = "0xFE9830", Offset = "0xFE8A30", Length = "0x6")]
		[CallerCount(Count = 20)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DF6")]
		 get { } //Length: 6
		[Address(RVA = "0x331A20", Offset = "0x330C20", Length = "0x4")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DF7")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000861")]
	public override Background value
	{
		[Address(RVA = "0x1B162E0", Offset = "0x1B154E0", Length = "0x29")]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleBackground)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleBackgroundProperty+<>c", Member = "<.ctor>b__0_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackground&)}, ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleBackgroundProperty+<>c", Member = "<.ctor>b__0_4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackground&)}, ReturnType = typeof(Sprite))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleBackgroundProperty+<>c", Member = "<.ctor>b__0_5", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackground&)}, ReturnType = typeof(RenderTexture))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleBackgroundProperty+<>c", Member = "<.ctor>b__0_6", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackground&)}, ReturnType = typeof(VectorImage))]
		[CallerCount(Count = 16)]
		[Token(Token = "0x6001DF4")]
		 get { } //Length: 41
		[Address(RVA = "0x1B16420", Offset = "0x1B15620", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001DF5")]
		 set { } //Length: 43
	}

	[Address(RVA = "0x1B160F0", Offset = "0x1B152F0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Background), Member = "FromTexture2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(Background))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001DFC")]
	internal StyleBackground(Texture2D v, StyleKeyword keyword) { }

	[Address(RVA = "0x1B16180", Offset = "0x1B15380", Length = "0x3A")]
	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleBackgroundProperty+<>c", Member = "<.ctor>b__0_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D&)}, ReturnType = typeof(StyleBackground))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Background), Member = "FromTexture2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(Background))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001DF8")]
	public StyleBackground(Texture2D v) { }

	[Address(RVA = "0x1B162A0", Offset = "0x1B154A0", Length = "0x3A")]
	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleBackgroundProperty+<>c", Member = "<.ctor>b__0_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite&)}, ReturnType = typeof(StyleBackground))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Background), Member = "FromSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Background))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001DF9")]
	public StyleBackground(Sprite v) { }

	[Address(RVA = "0x1B16140", Offset = "0x1B15340", Length = "0x3A")]
	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleBackgroundProperty+<>c", Member = "<.ctor>b__0_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VectorImage&)}, ReturnType = typeof(StyleBackground))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Background), Member = "FromVectorImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VectorImage)}, ReturnType = typeof(Background))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001DFA")]
	public StyleBackground(VectorImage v) { }

	[Address(RVA = "0x1B16210", Offset = "0x1B15410", Length = "0x14")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001DFB")]
	public StyleBackground(StyleKeyword keyword) { }

	[Address(RVA = "0x1B16280", Offset = "0x1B15480", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001DFF")]
	internal StyleBackground(Background v, StyleKeyword keyword) { }

	[Address(RVA = "0x1B161C0", Offset = "0x1B153C0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Background), Member = "FromSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Background))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001DFD")]
	internal StyleBackground(Sprite v, StyleKeyword keyword) { }

	[Address(RVA = "0x1B16230", Offset = "0x1B15430", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Background), Member = "FromVectorImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VectorImage)}, ReturnType = typeof(Background))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001DFE")]
	internal StyleBackground(VectorImage v, StyleKeyword keyword) { }

	[Address(RVA = "0x1B15F20", Offset = "0x1B15120", Length = "0x122")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(Background), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background), typeof(Background)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6001E03")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1B15E70", Offset = "0x1B15070", Length = "0xA1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Background), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background), typeof(Background)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001E02")]
	public override bool Equals(StyleBackground other) { }

	[Address(RVA = "0xFE9830", Offset = "0xFE8A30", Length = "0x6")]
	[CallerCount(Count = 20)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DF6")]
	public override StyleKeyword get_keyword() { }

	[Address(RVA = "0x1B162E0", Offset = "0x1B154E0", Length = "0x29")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleBackground)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleBackgroundProperty+<>c", Member = "<.ctor>b__0_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackground&)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleBackgroundProperty+<>c", Member = "<.ctor>b__0_4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackground&)}, ReturnType = typeof(Sprite))]
	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleBackgroundProperty+<>c", Member = "<.ctor>b__0_5", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackground&)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleBackgroundProperty+<>c", Member = "<.ctor>b__0_6", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackground&)}, ReturnType = typeof(VectorImage))]
	[CallerCount(Count = 16)]
	[Token(Token = "0x6001DF4")]
	public override Background get_value() { }

	[Address(RVA = "0x1B16050", Offset = "0x1B15250", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Background), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x6001E04")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1B16310", Offset = "0x1B15510", Length = "0xA1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Background), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background), typeof(Background)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001E00")]
	public static bool op_Equality(StyleBackground lhs, StyleBackground rhs) { }

	[Address(RVA = "0x1B163C0", Offset = "0x1B155C0", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001E01")]
	public static StyleBackground op_Implicit(StyleKeyword keyword) { }

	[Address(RVA = "0x331A20", Offset = "0x330C20", Length = "0x4")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DF7")]
	public override void set_keyword(StyleKeyword value) { }

	[Address(RVA = "0x1B16420", Offset = "0x1B15620", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001DF5")]
	public override void set_value(Background value) { }

	[Address(RVA = "0x1B16070", Offset = "0x1B15270", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(StyleValueExtensions), Member = "DebugString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IStyleValue`1<T>"}, ReturnType = typeof(string))]
	[Token(Token = "0x6001E05")]
	public virtual string ToString() { }

}

