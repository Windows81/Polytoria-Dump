namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000040")]
public abstract class TextElement
{
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000194")]
	protected TextElementType m_ElementType; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[Token(Token = "0x4000195")]
	internal uint m_Unicode; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000196")]
	internal TextAsset m_TextAsset; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000197")]
	internal Glyph m_Glyph; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000198")]
	internal uint m_GlyphIndex; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x4000199")]
	internal float m_Scale; //Field offset: 0x2C

	[Token(Token = "0x17000052")]
	public TextElementType elementType
	{
		[Address(RVA = "0x19A8C80", Offset = "0x19A7E80", Length = "0x7")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001A4")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000055")]
	public Glyph glyph
	{
		[Address(RVA = "0x19865C0", Offset = "0x19857C0", Length = "0x7")]
		[CallerCount(Count = 69)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001A9")]
		 get { } //Length: 7
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60001AA")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000056")]
	public uint glyphIndex
	{
		[Address(RVA = "0xFE9850", Offset = "0xFE8A50", Length = "0x96C")]
		[CallerCount(Count = 33)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_custom_attrs_free")]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "System.Threading.ThreadLocal`1+IdManager", Member = "GetId", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED940")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_method_get_class")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x60001AB")]
		 get { } //Length: 2412
		[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001AC")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000057")]
	public float scale
	{
		[Address(RVA = "0x19DC160", Offset = "0x19DB360", Length = "0x8")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001AD")]
		 get { } //Length: 8
		[Address(RVA = "0x1888A50", Offset = "0x1887C50", Length = "0x6")]
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001AE")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000054")]
	public TextAsset textAsset
	{
		[Address(RVA = "0xB081E0", Offset = "0xB073E0", Length = "0x7")]
		[CallerCount(Count = 73)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001A7")]
		 get { } //Length: 7
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60001A8")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000053")]
	public uint unicode
	{
		[Address(RVA = "0xB08210", Offset = "0xB07410", Length = "0x6")]
		[CallerCount(Count = 32)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001A5")]
		 get { } //Length: 6
		[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001A6")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001AF")]
	protected TextElement() { }

	[Address(RVA = "0x19A8C80", Offset = "0x19A7E80", Length = "0x7")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001A4")]
	public TextElementType get_elementType() { }

	[Address(RVA = "0x19865C0", Offset = "0x19857C0", Length = "0x7")]
	[CallerCount(Count = 69)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001A9")]
	public Glyph get_glyph() { }

	[Address(RVA = "0xFE9850", Offset = "0xFE8A50", Length = "0x96C")]
	[CallerCount(Count = 33)]
	[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED940")]
	[Calls(Type = "System.Threading.ThreadLocal`1+IdManager", Member = "GetId", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_custom_attrs_free")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_method_get_class")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60001AB")]
	public uint get_glyphIndex() { }

	[Address(RVA = "0x19DC160", Offset = "0x19DB360", Length = "0x8")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001AD")]
	public float get_scale() { }

	[Address(RVA = "0xB081E0", Offset = "0xB073E0", Length = "0x7")]
	[CallerCount(Count = 73)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001A7")]
	public TextAsset get_textAsset() { }

	[Address(RVA = "0xB08210", Offset = "0xB07410", Length = "0x6")]
	[CallerCount(Count = 32)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001A5")]
	public uint get_unicode() { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60001AA")]
	public void set_glyph(Glyph value) { }

	[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001AC")]
	public void set_glyphIndex(uint value) { }

	[Address(RVA = "0x1888A50", Offset = "0x1887C50", Length = "0x6")]
	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001AE")]
	public void set_scale(float value) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60001A8")]
	public void set_textAsset(TextAsset value) { }

	[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001A6")]
	public void set_unicode(uint value) { }

}

