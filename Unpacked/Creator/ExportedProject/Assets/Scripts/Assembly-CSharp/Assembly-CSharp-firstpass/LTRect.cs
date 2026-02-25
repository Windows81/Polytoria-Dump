//Type is in global namespace

[Token(Token = "0x2000018")]
public class LTRect
{
	[Token(Token = "0x40000E9")]
	public static bool colorTouched; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000D5")]
	public Rect _rect; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000D6")]
	public float alpha; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40000D7")]
	public float rotation; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000D8")]
	public Vector2 pivot; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000D9")]
	public Vector2 margin; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000DA")]
	public Rect relativeRect; //Field offset: 0x38
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40000DB")]
	public bool rotateEnabled; //Field offset: 0x48
	[FieldOffset(Offset = "0x49")]
	[HideInInspector]
	[Token(Token = "0x40000DC")]
	public bool rotateFinished; //Field offset: 0x49
	[FieldOffset(Offset = "0x4A")]
	[Token(Token = "0x40000DD")]
	public bool alphaEnabled; //Field offset: 0x4A
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40000DE")]
	public string labelStr; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40000DF")]
	public Element_Type type; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40000E0")]
	public GUIStyle style; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40000E1")]
	public bool useColor; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40000E2")]
	public Color color; //Field offset: 0x6C
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x40000E3")]
	public bool fontScaleToFit; //Field offset: 0x7C
	[FieldOffset(Offset = "0x7D")]
	[Token(Token = "0x40000E4")]
	public bool useSimpleScale; //Field offset: 0x7D
	[FieldOffset(Offset = "0x7E")]
	[Token(Token = "0x40000E5")]
	public bool sizeByHeight; //Field offset: 0x7E
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40000E6")]
	public Texture texture; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40000E7")]
	private int _id; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[HideInInspector]
	[Token(Token = "0x40000E8")]
	public int counter; //Field offset: 0x8C

	[Token(Token = "0x1700000C")]
	public bool hasInitiliazed
	{
		[Address(RVA = "0x2C0AF0", Offset = "0x2BFCF0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000152")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000011")]
	public float height
	{
		[Address(RVA = "0x2C0B00", Offset = "0x2BFD00", Length = "0x8")]
		[CallerCount(Count = 66)]
		[DeduplicatedMethod]
		[Token(Token = "0x600015D")]
		 get { } //Length: 8
		[Address(RVA = "0x2C1200", Offset = "0x2C0400", Length = "0x6")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600015E")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700000D")]
	public int id
	{
		[Address(RVA = "0x2C0B10", Offset = "0x2BFD10", Length = "0x10")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000153")]
		 get { } //Length: 16
	}

	[Token(Token = "0x17000012")]
	public Rect rect
	{
		[Address(RVA = "0x2C0B20", Offset = "0x2BFD20", Length = "0x24F")]
		[CalledBy(Type = typeof(LTGUI), Member = "update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LTDescr), Member = "<setGUIMove>b__121_0", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LTDescr), Member = "<setGUIMove>b__121_1", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LTDescr), Member = "<setGUIScale>b__123_0", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LTDescr), Member = "<setGUIScale>b__123_1", ReturnType = typeof(void))]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(GUI), Member = "get_color", ReturnType = typeof(Color))]
		[Calls(Type = typeof(GUI), Member = "set_color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUIUtility), Member = "RotateAroundPivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector2)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUIStyle), Member = "set_fontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600015F")]
		 get { } //Length: 591
		[Address(RVA = "0x2C1210", Offset = "0x2C0410", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000160")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000010")]
	public float width
	{
		[Address(RVA = "0x2C0D70", Offset = "0x2BFF70", Length = "0x8")]
		[CallerCount(Count = 61)]
		[DeduplicatedMethod]
		[Token(Token = "0x600015B")]
		 get { } //Length: 8
		[Address(RVA = "0x2C1220", Offset = "0x2C0420", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600015C")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700000E")]
	public float x
	{
		[Address(RVA = "0x2C0D80", Offset = "0x2BFF80", Length = "0x8")]
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000157")]
		 get { } //Length: 8
		[Address(RVA = "0x2C1230", Offset = "0x2C0430", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000158")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700000F")]
	public float y
	{
		[Address(RVA = "0x2C0D90", Offset = "0x2BFF90", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000159")]
		 get { } //Length: 8
		[Address(RVA = "0x2C1240", Offset = "0x2C0440", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600015A")]
		 set { } //Length: 6
	}

	[Address(RVA = "0x2C08A0", Offset = "0x2BFAA0", Length = "0xA8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600014D")]
	public LTRect() { }

	[Address(RVA = "0x2C07F0", Offset = "0x2BF9F0", Length = "0xA7")]
	[CalledBy(Type = typeof(LTDescr), Member = "setRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(LTDescr))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600014E")]
	public LTRect(Rect rect) { }

	[Address(RVA = "0x2C0740", Offset = "0x2BF940", Length = "0xAA")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600014F")]
	public LTRect(float x, float y, float width, float height) { }

	[Address(RVA = "0x2C0950", Offset = "0x2BFB50", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000150")]
	public LTRect(float x, float y, float width, float height, float alpha) { }

	[Address(RVA = "0x2C0A10", Offset = "0x2BFC10", Length = "0xD6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LTRect), Member = "resetForRotation", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000151")]
	public LTRect(float x, float y, float width, float height, float alpha, float rotation) { }

	[Address(RVA = "0x2C0AF0", Offset = "0x2BFCF0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000152")]
	public bool get_hasInitiliazed() { }

	[Address(RVA = "0x2C0B00", Offset = "0x2BFD00", Length = "0x8")]
	[CallerCount(Count = 66)]
	[DeduplicatedMethod]
	[Token(Token = "0x600015D")]
	public float get_height() { }

	[Address(RVA = "0x2C0B10", Offset = "0x2BFD10", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000153")]
	public int get_id() { }

	[Address(RVA = "0x2C0B20", Offset = "0x2BFD20", Length = "0x24F")]
	[CalledBy(Type = typeof(LTGUI), Member = "update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LTDescr), Member = "<setGUIMove>b__121_0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LTDescr), Member = "<setGUIMove>b__121_1", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LTDescr), Member = "<setGUIScale>b__123_0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LTDescr), Member = "<setGUIScale>b__123_1", ReturnType = typeof(void))]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GUI), Member = "get_color", ReturnType = typeof(Color))]
	[Calls(Type = typeof(GUI), Member = "set_color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIUtility), Member = "RotateAroundPivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIStyle), Member = "set_fontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600015F")]
	public Rect get_rect() { }

	[Address(RVA = "0x2C0D70", Offset = "0x2BFF70", Length = "0x8")]
	[CallerCount(Count = 61)]
	[DeduplicatedMethod]
	[Token(Token = "0x600015B")]
	public float get_width() { }

	[Address(RVA = "0x2C0D80", Offset = "0x2BFF80", Length = "0x8")]
	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000157")]
	public float get_x() { }

	[Address(RVA = "0x2C0D90", Offset = "0x2BFF90", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000159")]
	public float get_y() { }

	[Address(RVA = "0x2C1080", Offset = "0x2C0280", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000155")]
	public void reset() { }

	[Address(RVA = "0x2C0DA0", Offset = "0x2BFFA0", Length = "0x2D6")]
	[CalledBy(Type = typeof(LTRect), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LTDescr), Member = "<setGUIRotate>b__125_0", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GUI), Member = "get_matrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Token(Token = "0x6000156")]
	public void resetForRotation() { }

	[Address(RVA = "0x2C1200", Offset = "0x2C0400", Length = "0x6")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600015E")]
	public void set_height(float value) { }

	[Address(RVA = "0x2C1210", Offset = "0x2C0410", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000160")]
	public void set_rect(Rect value) { }

	[Address(RVA = "0x2C1220", Offset = "0x2C0420", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600015C")]
	public void set_width(float value) { }

	[Address(RVA = "0x2C1230", Offset = "0x2C0430", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000158")]
	public void set_x(float value) { }

	[Address(RVA = "0x2C1240", Offset = "0x2C0440", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600015A")]
	public void set_y(float value) { }

	[Address(RVA = "0x2C10F0", Offset = "0x2C02F0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000164")]
	public LTRect setAlpha(float alpha) { }

	[Address(RVA = "0x2C1100", Offset = "0x2C0300", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000163")]
	public LTRect setColor(Color color) { }

	[Address(RVA = "0x2C1110", Offset = "0x2C0310", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000162")]
	public LTRect setFontScaleToFit(bool fontScaleToFit) { }

	[Address(RVA = "0x2C1120", Offset = "0x2C0320", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000154")]
	public void setId(int id, int counter) { }

	[Address(RVA = "0x2C1130", Offset = "0x2C0330", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000165")]
	public LTRect setLabel(string str) { }

	[Address(RVA = "0x2C1150", Offset = "0x2C0350", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000168")]
	public LTRect setSizeByHeight(bool sizeByHeight) { }

	[Address(RVA = "0x2C1160", Offset = "0x2C0360", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000161")]
	public LTRect setStyle(GUIStyle style) { }

	[Address(RVA = "0x2C11F0", Offset = "0x2C03F0", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000166")]
	public LTRect setUseSimpleScale(bool useSimpleScale, Rect relativeRect) { }

	[Address(RVA = "0x2C1180", Offset = "0x2C0380", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[Token(Token = "0x6000167")]
	public LTRect setUseSimpleScale(bool useSimpleScale) { }

	[Address(RVA = "0x2C0570", Offset = "0x2BF770", Length = "0x1C6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000169")]
	public virtual string ToString() { }

}

