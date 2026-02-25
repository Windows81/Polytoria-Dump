namespace UnityEngine.UI;

[Token(Token = "0x200000B")]
public struct ColorBlock : IEquatable<ColorBlock>
{
	[Token(Token = "0x400002C")]
	public static ColorBlock defaultColorBlock; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[FormerlySerializedAs("normalColor")]
	[SerializeField]
	[Token(Token = "0x4000025")]
	private Color m_NormalColor; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[FormerlySerializedAs("highlightedColor")]
	[SerializeField]
	[Token(Token = "0x4000026")]
	private Color m_HighlightedColor; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("pressedColor")]
	[SerializeField]
	[Token(Token = "0x4000027")]
	private Color m_PressedColor; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("m_HighlightedColor")]
	[SerializeField]
	[Token(Token = "0x4000028")]
	private Color m_SelectedColor; //Field offset: 0x30
	[FieldOffset(Offset = "0x40")]
	[FormerlySerializedAs("disabledColor")]
	[SerializeField]
	[Token(Token = "0x4000029")]
	private Color m_DisabledColor; //Field offset: 0x40
	[FieldOffset(Offset = "0x50")]
	[Range(1, 5)]
	[SerializeField]
	[Token(Token = "0x400002A")]
	private float m_ColorMultiplier; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[FormerlySerializedAs("fadeDuration")]
	[SerializeField]
	[Token(Token = "0x400002B")]
	private float m_FadeDuration; //Field offset: 0x54

	[Token(Token = "0x17000010")]
	public float colorMultiplier
	{
		[Address(RVA = "0x3B43D0", Offset = "0x3B35D0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000041")]
		 get { } //Length: 6
		[Address(RVA = "0x1A793B0", Offset = "0x1A785B0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000042")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700000F")]
	public Color disabledColor
	{
		[Address(RVA = "0x3B21A0", Offset = "0x3B13A0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600003F")]
		 get { } //Length: 11
		[Address(RVA = "0x3B2220", Offset = "0x3B1420", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000040")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000011")]
	public float fadeDuration
	{
		[Address(RVA = "0x1813FD0", Offset = "0x18131D0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000043")]
		 get { } //Length: 6
		[Address(RVA = "0x18F05B0", Offset = "0x18EF7B0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000044")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700000C")]
	public Color highlightedColor
	{
		[Address(RVA = "0x3E81B0", Offset = "0x3E73B0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000039")]
		 get { } //Length: 11
		[Address(RVA = "0x2C1210", Offset = "0x2C0410", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600003A")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700000B")]
	public Color normalColor
	{
		[Address(RVA = "0x702130", Offset = "0x701330", Length = "0xA")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000037")]
		 get { } //Length: 10
		[Address(RVA = "0x90E890", Offset = "0x90DA90", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000038")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700000D")]
	public Color pressedColor
	{
		[Address(RVA = "0x5AAB20", Offset = "0x5A9D20", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600003B")]
		 get { } //Length: 11
		[Address(RVA = "0x5AAC00", Offset = "0x5A9E00", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600003C")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700000E")]
	public Color selectedColor
	{
		[Address(RVA = "0x3B2180", Offset = "0x3B1380", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600003D")]
		 get { } //Length: 11
		[Address(RVA = "0x3B2200", Offset = "0x3B1400", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600003E")]
		 set { } //Length: 8
	}

	[Address(RVA = "0x1A78F40", Offset = "0x1A78140", Length = "0x321")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000045")]
	private static ColorBlock() { }

	[Address(RVA = "0x1A78BB0", Offset = "0x1A77DB0", Length = "0x2F8")]
	[CalledBy(Type = typeof(ColorBlock), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ColorBlock), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorBlock), typeof(ColorBlock)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ColorBlock), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorBlock), typeof(ColorBlock)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000047")]
	public override bool Equals(ColorBlock other) { }

	[Address(RVA = "0x1A78AC0", Offset = "0x1A77CC0", Length = "0xEE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(ColorBlock), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorBlock)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000046")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x3B43D0", Offset = "0x3B35D0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000041")]
	public float get_colorMultiplier() { }

	[Address(RVA = "0x3B21A0", Offset = "0x3B13A0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600003F")]
	public Color get_disabledColor() { }

	[Address(RVA = "0x1813FD0", Offset = "0x18131D0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000043")]
	public float get_fadeDuration() { }

	[Address(RVA = "0x3E81B0", Offset = "0x3E73B0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000039")]
	public Color get_highlightedColor() { }

	[Address(RVA = "0x702130", Offset = "0x701330", Length = "0xA")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000037")]
	public Color get_normalColor() { }

	[Address(RVA = "0x5AAB20", Offset = "0x5A9D20", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600003B")]
	public Color get_pressedColor() { }

	[Address(RVA = "0x3B2180", Offset = "0x3B1380", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600003D")]
	public Color get_selectedColor() { }

	[Address(RVA = "0x1A78EB0", Offset = "0x1A780B0", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(ValueType), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x600004A")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1A79270", Offset = "0x1A78470", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ColorBlock), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorBlock)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000048")]
	public static bool op_Equality(ColorBlock point1, ColorBlock point2) { }

	[Address(RVA = "0x1A79310", Offset = "0x1A78510", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ColorBlock), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorBlock)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000049")]
	public static bool op_Inequality(ColorBlock point1, ColorBlock point2) { }

	[Address(RVA = "0x1A793B0", Offset = "0x1A785B0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000042")]
	public void set_colorMultiplier(float value) { }

	[Address(RVA = "0x3B2220", Offset = "0x3B1420", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000040")]
	public void set_disabledColor(Color value) { }

	[Address(RVA = "0x18F05B0", Offset = "0x18EF7B0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000044")]
	public void set_fadeDuration(float value) { }

	[Address(RVA = "0x2C1210", Offset = "0x2C0410", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600003A")]
	public void set_highlightedColor(Color value) { }

	[Address(RVA = "0x90E890", Offset = "0x90DA90", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000038")]
	public void set_normalColor(Color value) { }

	[Address(RVA = "0x5AAC00", Offset = "0x5A9E00", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600003C")]
	public void set_pressedColor(Color value) { }

	[Address(RVA = "0x3B2200", Offset = "0x3B1400", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600003E")]
	public void set_selectedColor(Color value) { }

}

