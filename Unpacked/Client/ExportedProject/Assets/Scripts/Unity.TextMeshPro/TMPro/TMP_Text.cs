namespace TMPro;

[Token(Token = "0x20000A1")]
public abstract class TMP_Text : MaskableGraphic
{
	[CompilerGenerated]
	[Token(Token = "0x20000A8")]
	private sealed class <>c
	{
		[Token(Token = "0x4000630")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000631")]
		public static Action<TMP_TextInfo> <>9__645_0; //Field offset: 0x8

		[Address(RVA = "0x18F3480", Offset = "0x18F2680", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000675")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000676")]
		public <>c() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000677")]
		internal void <.ctor>b__645_0(TMP_TextInfo <p0>) { }

	}

	[Token(Token = "0x20000A3")]
	internal struct CharacterSubstitution
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400061F")]
		public int index; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000620")]
		public uint unicode; //Field offset: 0x4

		[Address(RVA = "0x3AFE70", Offset = "0x3AF070", Length = "0x7")]
		[CallerCount(Count = 47)]
		[DeduplicatedMethod]
		[Token(Token = "0x600066B")]
		public CharacterSubstitution(int index, uint unicode) { }

	}

	[Token(Token = "0x20000A2")]
	internal sealed class MissingCharacterEventCallback : MulticastDelegate
	{

		[Address(RVA = "0x18DE260", Offset = "0x18DD460", Length = "0xA6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000667")]
		public MissingCharacterEventCallback(object object, IntPtr method) { }

		[Address(RVA = "0x18DE1C0", Offset = "0x18DD3C0", Length = "0x95")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[Token(Token = "0x6000669")]
		public override IAsyncResult BeginInvoke(int unicode, int stringIndex, string text, TMP_FontAsset fontAsset, TMP_Text textComponent, AsyncCallback callback, object object) { }

		[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[DeduplicatedMethod]
		[Token(Token = "0x600066A")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x335810", Offset = "0x334A10", Length = "0x14")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000668")]
		public override void Invoke(int unicode, int stringIndex, string text, TMP_FontAsset fontAsset, TMP_Text textComponent) { }

	}

	[Token(Token = "0x20000A6")]
	internal struct SpecialCharacter
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400062A")]
		public TMP_Character character; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400062B")]
		public TMP_FontAsset fontAsset; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400062C")]
		public Material material; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400062D")]
		public int materialIndex; //Field offset: 0x18

		[Address(RVA = "0x18E1A00", Offset = "0x18E0C00", Length = "0x15A")]
		[CalledBy(Type = typeof(TMP_Text), Member = "GetEllipsisSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "GetUnderlineSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600066C")]
		public SpecialCharacter(TMP_Character character, int materialIndex) { }

	}

	[DefaultMember("Item")]
	[Token(Token = "0x20000A7")]
	private struct TextBackingContainer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400062E")]
		private UInt32[] m_Array; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400062F")]
		private int m_Index; //Field offset: 0x8

		[Token(Token = "0x17000189")]
		public int Capacity
		{
			[Address(RVA = "0xA3B280", Offset = "0xA3A480", Length = "0x19")]
			[CallerCount(Count = 23)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x600066E")]
			 get { } //Length: 25
		}

		[Token(Token = "0x1700018A")]
		public int Count
		{
			[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
			[CallerCount(Count = 5)]
			[DeduplicatedMethod]
			[Token(Token = "0x600066F")]
			 get { } //Length: 4
			[Address(RVA = "0x3B9460", Offset = "0x3B8660", Length = "0x4")]
			[CallerCount(Count = 4)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000670")]
			 set { } //Length: 4
		}

		[Token(Token = "0x1700018B")]
		public uint Item
		{
			[Address(RVA = "0x18F1FD0", Offset = "0x18F11D0", Length = "0x2A")]
			[CallerCount(Count = 45)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000671")]
			 get { } //Length: 42
			[Address(RVA = "0x18F2000", Offset = "0x18F1200", Length = "0x5B")]
			[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(TMP_Text), Member = "GetPreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Vector2))]
			[CalledBy(Type = typeof(TMP_Text), Member = "AddIntegerToInternalTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int), typeof(Int32&)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(TMP_Text), Member = "AddFloatToInternalTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(TMP_Text), Member = "SetCharArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(TMP_Text), Member = "SetTextInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(TMP_Text), Member = "ParseInputText", ReturnType = typeof(void))]
			[CalledBy(Type = typeof(TMP_Text), Member = "GetPreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(Vector2))]
			[CallerCount(Count = 34)]
			[Calls(Type = typeof(TextBackingContainer), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Token(Token = "0x6000672")]
			 set { } //Length: 91
		}

		[Token(Token = "0x17000188")]
		public UInt32[] Text
		{
			[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
			[CallerCount(Count = 140)]
			[DeduplicatedMethod]
			[Token(Token = "0x600066D")]
			 get { } //Length: 4
		}

		[Address(RVA = "0x18F1F70", Offset = "0x18F1170", Length = "0x59")]
		[CalledBy(Type = typeof(TMP_Text), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000673")]
		public TextBackingContainer(int size) { }

		[Address(RVA = "0xA3B280", Offset = "0xA3A480", Length = "0x19")]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600066E")]
		public int get_Capacity() { }

		[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x600066F")]
		public int get_Count() { }

		[Address(RVA = "0x18F1FD0", Offset = "0x18F11D0", Length = "0x2A")]
		[CallerCount(Count = 45)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000671")]
		public uint get_Item(int index) { }

		[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
		[CallerCount(Count = 140)]
		[DeduplicatedMethod]
		[Token(Token = "0x600066D")]
		public UInt32[] get_Text() { }

		[Address(RVA = "0x18F1F00", Offset = "0x18F1100", Length = "0x68")]
		[CalledBy(Type = typeof(TMP_Text), Member = "SetTextInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextBackingContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "ParseInputText", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "SetCharArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "GetPreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(TMP_Text), Member = "GetPreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000674")]
		public void Resize(int size) { }

		[Address(RVA = "0x3B9460", Offset = "0x3B8660", Length = "0x4")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000670")]
		public void set_Count(int value) { }

		[Address(RVA = "0x18F2000", Offset = "0x18F1200", Length = "0x5B")]
		[CalledBy(Type = typeof(TMP_Text), Member = "GetPreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(TMP_Text), Member = "ParseInputText", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "SetTextInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "SetCharArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "AddFloatToInternalTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "AddIntegerToInternalTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int), typeof(Int32&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "GetPreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 34)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(TextBackingContainer), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000672")]
		public void set_Item(int index, uint value) { }

	}

	[Token(Token = "0x20000A4")]
	public enum TextInputSources
	{
		TextInputBox = 0,
		SetText = 1,
		SetTextArray = 2,
		TextString = 3,
	}

	[DebuggerDisplay("Unicode ({unicode})  '{(char)unicode}'")]
	[Token(Token = "0x20000A5")]
	public struct TextProcessingElement
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000626")]
		public TextProcessingElementType elementType; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000627")]
		public uint unicode; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000628")]
		public int stringIndex; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000629")]
		public int length; //Field offset: 0xC

	}

	[Token(Token = "0x400053A")]
	protected static MaterialReference[] m_materialReferences; //Field offset: 0x0
	[Token(Token = "0x400053B")]
	protected static Dictionary<Int32, Int32> m_materialReferenceIndexLookup; //Field offset: 0x8
	[Token(Token = "0x400053C")]
	protected static TMP_TextProcessingStack<MaterialReference> m_materialReferenceStack; //Field offset: 0x10
	[Token(Token = "0x4000544")]
	protected static Color32 s_colorWhite; //Field offset: 0x68
	[CompilerGenerated]
	[Token(Token = "0x40005B7")]
	private static Func<Int32, String, TMP_FontAsset> OnFontAssetRequest; //Field offset: 0x70
	[CompilerGenerated]
	[Token(Token = "0x40005B8")]
	private static Func<Int32, String, TMP_SpriteAsset> OnSpriteAssetRequest; //Field offset: 0x78
	[CompilerGenerated]
	[Token(Token = "0x40005B9")]
	private static MissingCharacterEventCallback OnMissingCharacter; //Field offset: 0x80
	[Token(Token = "0x40005D0")]
	private static Char[] m_htmlTag; //Field offset: 0x88
	[Token(Token = "0x40005D1")]
	private static RichTextTagAttribute[] m_xmlAttribute; //Field offset: 0x90
	[Token(Token = "0x40005D2")]
	private static Single[] m_attributeParameterValues; //Field offset: 0x98
	[Token(Token = "0x40005DE")]
	internal static WordWrapState m_SavedWordWrapState; //Field offset: 0xA0
	[Token(Token = "0x40005DF")]
	internal static WordWrapState m_SavedLineState; //Field offset: 0x458
	[Token(Token = "0x40005E0")]
	internal static WordWrapState m_SavedEllipsisState; //Field offset: 0x810
	[Token(Token = "0x40005E1")]
	internal static WordWrapState m_SavedLastValidState; //Field offset: 0xBC8
	[Token(Token = "0x40005E2")]
	internal static WordWrapState m_SavedSoftLineBreakState; //Field offset: 0xF80
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	[TextArea(5, 10)]
	[Token(Token = "0x4000531")]
	protected string m_text; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000532")]
	private bool m_IsTextBackingStringDirty; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	[Token(Token = "0x4000533")]
	protected ITextPreprocessor m_TextPreprocessor; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	[Token(Token = "0x4000534")]
	protected bool m_isRightToLeft; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	[Token(Token = "0x4000535")]
	protected TMP_FontAsset m_fontAsset; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000536")]
	protected TMP_FontAsset m_currentFontAsset; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000537")]
	protected bool m_isSDFShader; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	[Token(Token = "0x4000538")]
	protected Material m_sharedMaterial; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000539")]
	protected Material m_currentMaterial; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x400053D")]
	protected int m_currentMaterialIndex; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	[Token(Token = "0x400053E")]
	protected Material[] m_fontSharedMaterials; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[SerializeField]
	[Token(Token = "0x400053F")]
	protected Material m_fontMaterial; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	[Token(Token = "0x4000540")]
	protected Material[] m_fontMaterials; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4000541")]
	protected bool m_isMaterialDirty; //Field offset: 0x148
	[FieldOffset(Offset = "0x14C")]
	[SerializeField]
	[Token(Token = "0x4000542")]
	protected Color32 m_fontColor32; //Field offset: 0x14C
	[FieldOffset(Offset = "0x150")]
	[SerializeField]
	[Token(Token = "0x4000543")]
	protected Color m_fontColor; //Field offset: 0x150
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x4000545")]
	protected Color32 m_underlineColor; //Field offset: 0x160
	[FieldOffset(Offset = "0x164")]
	[Token(Token = "0x4000546")]
	protected Color32 m_strikethroughColor; //Field offset: 0x164
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x4000547")]
	internal HighlightState m_HighlightState; //Field offset: 0x168
	[FieldOffset(Offset = "0x17C")]
	[Token(Token = "0x4000548")]
	internal bool m_ConvertToLinearSpace; //Field offset: 0x17C
	[FieldOffset(Offset = "0x17D")]
	[SerializeField]
	[Token(Token = "0x4000549")]
	protected bool m_enableVertexGradient; //Field offset: 0x17D
	[FieldOffset(Offset = "0x180")]
	[SerializeField]
	[Token(Token = "0x400054A")]
	protected ColorMode m_colorMode; //Field offset: 0x180
	[FieldOffset(Offset = "0x184")]
	[SerializeField]
	[Token(Token = "0x400054B")]
	protected VertexGradient m_fontColorGradient; //Field offset: 0x184
	[FieldOffset(Offset = "0x1C8")]
	[SerializeField]
	[Token(Token = "0x400054C")]
	protected TMP_ColorGradient m_fontColorGradientPreset; //Field offset: 0x1C8
	[FieldOffset(Offset = "0x1D0")]
	[SerializeField]
	[Token(Token = "0x400054D")]
	protected TMP_SpriteAsset m_spriteAsset; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x1D8")]
	[SerializeField]
	[Token(Token = "0x400054E")]
	protected bool m_tintAllSprites; //Field offset: 0x1D8
	[FieldOffset(Offset = "0x1D9")]
	[Token(Token = "0x400054F")]
	protected bool m_tintSprite; //Field offset: 0x1D9
	[FieldOffset(Offset = "0x1DC")]
	[Token(Token = "0x4000550")]
	protected Color32 m_spriteColor; //Field offset: 0x1DC
	[FieldOffset(Offset = "0x1E0")]
	[SerializeField]
	[Token(Token = "0x4000551")]
	protected TMP_StyleSheet m_StyleSheet; //Field offset: 0x1E0
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x4000552")]
	internal TMP_Style m_TextStyle; //Field offset: 0x1E8
	[FieldOffset(Offset = "0x1F0")]
	[SerializeField]
	[Token(Token = "0x4000553")]
	protected int m_TextStyleHashCode; //Field offset: 0x1F0
	[FieldOffset(Offset = "0x1F4")]
	[SerializeField]
	[Token(Token = "0x4000554")]
	protected bool m_overrideHtmlColors; //Field offset: 0x1F4
	[FieldOffset(Offset = "0x1F8")]
	[SerializeField]
	[Token(Token = "0x4000555")]
	protected Color32 m_faceColor; //Field offset: 0x1F8
	[FieldOffset(Offset = "0x1FC")]
	[Token(Token = "0x4000556")]
	protected Color32 m_outlineColor; //Field offset: 0x1FC
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x4000557")]
	protected float m_outlineWidth; //Field offset: 0x200
	[FieldOffset(Offset = "0x204")]
	[Token(Token = "0x4000558")]
	protected Vector3 m_currentEnvMapRotation; //Field offset: 0x204
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x4000559")]
	protected bool m_hasEnvMapProperty; //Field offset: 0x210
	[FieldOffset(Offset = "0x214")]
	[SerializeField]
	[Token(Token = "0x400055A")]
	protected float m_fontSize; //Field offset: 0x214
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x400055B")]
	protected float m_currentFontSize; //Field offset: 0x218
	[FieldOffset(Offset = "0x21C")]
	[SerializeField]
	[Token(Token = "0x400055C")]
	protected float m_fontSizeBase; //Field offset: 0x21C
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x400055D")]
	protected TMP_TextProcessingStack<Single> m_sizeStack; //Field offset: 0x220
	[FieldOffset(Offset = "0x240")]
	[SerializeField]
	[Token(Token = "0x400055E")]
	protected FontWeight m_fontWeight; //Field offset: 0x240
	[FieldOffset(Offset = "0x244")]
	[Token(Token = "0x400055F")]
	protected FontWeight m_FontWeightInternal; //Field offset: 0x244
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000560")]
	protected TMP_TextProcessingStack<FontWeight> m_FontWeightStack; //Field offset: 0x248
	[FieldOffset(Offset = "0x268")]
	[SerializeField]
	[Token(Token = "0x4000561")]
	protected bool m_enableAutoSizing; //Field offset: 0x268
	[FieldOffset(Offset = "0x26C")]
	[Token(Token = "0x4000562")]
	protected float m_maxFontSize; //Field offset: 0x26C
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x4000563")]
	protected float m_minFontSize; //Field offset: 0x270
	[FieldOffset(Offset = "0x274")]
	[Token(Token = "0x4000564")]
	protected int m_AutoSizeIterationCount; //Field offset: 0x274
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4000565")]
	protected int m_AutoSizeMaxIterationCount; //Field offset: 0x278
	[FieldOffset(Offset = "0x27C")]
	[Token(Token = "0x4000566")]
	protected bool m_IsAutoSizePointSizeSet; //Field offset: 0x27C
	[FieldOffset(Offset = "0x280")]
	[SerializeField]
	[Token(Token = "0x4000567")]
	protected float m_fontSizeMin; //Field offset: 0x280
	[FieldOffset(Offset = "0x284")]
	[SerializeField]
	[Token(Token = "0x4000568")]
	protected float m_fontSizeMax; //Field offset: 0x284
	[FieldOffset(Offset = "0x288")]
	[SerializeField]
	[Token(Token = "0x4000569")]
	protected FontStyles m_fontStyle; //Field offset: 0x288
	[FieldOffset(Offset = "0x28C")]
	[Token(Token = "0x400056A")]
	protected FontStyles m_FontStyleInternal; //Field offset: 0x28C
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x400056B")]
	protected TMP_FontStyleStack m_fontStyleStack; //Field offset: 0x290
	[FieldOffset(Offset = "0x29A")]
	[Token(Token = "0x400056C")]
	protected bool m_isUsingBold; //Field offset: 0x29A
	[FieldOffset(Offset = "0x29C")]
	[SerializeField]
	[Token(Token = "0x400056D")]
	protected HorizontalAlignmentOptions m_HorizontalAlignment; //Field offset: 0x29C
	[FieldOffset(Offset = "0x2A0")]
	[SerializeField]
	[Token(Token = "0x400056E")]
	protected VerticalAlignmentOptions m_VerticalAlignment; //Field offset: 0x2A0
	[FieldOffset(Offset = "0x2A4")]
	[FormerlySerializedAs("m_lineJustification")]
	[SerializeField]
	[Token(Token = "0x400056F")]
	protected TextAlignmentOptions m_textAlignment; //Field offset: 0x2A4
	[FieldOffset(Offset = "0x2A8")]
	[Token(Token = "0x4000570")]
	protected HorizontalAlignmentOptions m_lineJustification; //Field offset: 0x2A8
	[FieldOffset(Offset = "0x2B0")]
	[Token(Token = "0x4000571")]
	protected TMP_TextProcessingStack<HorizontalAlignmentOptions> m_lineJustificationStack; //Field offset: 0x2B0
	[FieldOffset(Offset = "0x2D0")]
	[Token(Token = "0x4000572")]
	protected Vector3[] m_textContainerLocalCorners; //Field offset: 0x2D0
	[FieldOffset(Offset = "0x2D8")]
	[SerializeField]
	[Token(Token = "0x4000573")]
	protected float m_characterSpacing; //Field offset: 0x2D8
	[FieldOffset(Offset = "0x2DC")]
	[Token(Token = "0x4000574")]
	protected float m_cSpacing; //Field offset: 0x2DC
	[FieldOffset(Offset = "0x2E0")]
	[Token(Token = "0x4000575")]
	protected float m_monoSpacing; //Field offset: 0x2E0
	[FieldOffset(Offset = "0x2E4")]
	[Token(Token = "0x4000576")]
	protected bool m_duoSpace; //Field offset: 0x2E4
	[FieldOffset(Offset = "0x2E8")]
	[SerializeField]
	[Token(Token = "0x4000577")]
	protected float m_wordSpacing; //Field offset: 0x2E8
	[FieldOffset(Offset = "0x2EC")]
	[SerializeField]
	[Token(Token = "0x4000578")]
	protected float m_lineSpacing; //Field offset: 0x2EC
	[FieldOffset(Offset = "0x2F0")]
	[Token(Token = "0x4000579")]
	protected float m_lineSpacingDelta; //Field offset: 0x2F0
	[FieldOffset(Offset = "0x2F4")]
	[Token(Token = "0x400057A")]
	protected float m_lineHeight; //Field offset: 0x2F4
	[FieldOffset(Offset = "0x2F8")]
	[Token(Token = "0x400057B")]
	protected bool m_IsDrivenLineSpacing; //Field offset: 0x2F8
	[FieldOffset(Offset = "0x2FC")]
	[SerializeField]
	[Token(Token = "0x400057C")]
	protected float m_lineSpacingMax; //Field offset: 0x2FC
	[FieldOffset(Offset = "0x300")]
	[SerializeField]
	[Token(Token = "0x400057D")]
	protected float m_paragraphSpacing; //Field offset: 0x300
	[FieldOffset(Offset = "0x304")]
	[SerializeField]
	[Token(Token = "0x400057E")]
	protected float m_charWidthMaxAdj; //Field offset: 0x304
	[FieldOffset(Offset = "0x308")]
	[Token(Token = "0x400057F")]
	protected float m_charWidthAdjDelta; //Field offset: 0x308
	[FieldOffset(Offset = "0x30C")]
	[FormerlySerializedAs("m_enableWordWrapping")]
	[SerializeField]
	[Token(Token = "0x4000580")]
	protected TextWrappingModes m_TextWrappingMode; //Field offset: 0x30C
	[FieldOffset(Offset = "0x310")]
	[Token(Token = "0x4000581")]
	protected bool m_isCharacterWrappingEnabled; //Field offset: 0x310
	[FieldOffset(Offset = "0x311")]
	[Token(Token = "0x4000582")]
	protected bool m_isNonBreakingSpace; //Field offset: 0x311
	[FieldOffset(Offset = "0x312")]
	[Token(Token = "0x4000583")]
	protected bool m_isIgnoringAlignment; //Field offset: 0x312
	[FieldOffset(Offset = "0x314")]
	[SerializeField]
	[Token(Token = "0x4000584")]
	protected float m_wordWrappingRatios; //Field offset: 0x314
	[FieldOffset(Offset = "0x318")]
	[SerializeField]
	[Token(Token = "0x4000585")]
	protected TextOverflowModes m_overflowMode; //Field offset: 0x318
	[FieldOffset(Offset = "0x31C")]
	[Token(Token = "0x4000586")]
	protected int m_firstOverflowCharacterIndex; //Field offset: 0x31C
	[FieldOffset(Offset = "0x320")]
	[SerializeField]
	[Token(Token = "0x4000587")]
	protected TMP_Text m_linkedTextComponent; //Field offset: 0x320
	[FieldOffset(Offset = "0x328")]
	[SerializeField]
	[Token(Token = "0x4000588")]
	internal TMP_Text parentLinkedComponent; //Field offset: 0x328
	[FieldOffset(Offset = "0x330")]
	[Token(Token = "0x4000589")]
	protected bool m_isTextTruncated; //Field offset: 0x330
	[FieldOffset(Offset = "0x331")]
	[SerializeField]
	[Token(Token = "0x400058A")]
	protected bool m_enableKerning; //Field offset: 0x331
	[FieldOffset(Offset = "0x334")]
	[Token(Token = "0x400058B")]
	protected int m_LastBaseGlyphIndex; //Field offset: 0x334
	[Token(Token = "0x40005E3")]
	internal static TMP_TextProcessingStack<WordWrapState> m_EllipsisInsertionCandidateStack; //Field offset: 0x1338
	[FieldOffset(Offset = "0x338")]
	[SerializeField]
	[Token(Token = "0x400058C")]
	protected List<OTL_FeatureTag> m_ActiveFontFeatures; //Field offset: 0x338
	[FieldOffset(Offset = "0x340")]
	[SerializeField]
	[Token(Token = "0x400058D")]
	protected bool m_enableExtraPadding; //Field offset: 0x340
	[FieldOffset(Offset = "0x341")]
	[SerializeField]
	[Token(Token = "0x400058E")]
	protected bool checkPaddingRequired; //Field offset: 0x341
	[FieldOffset(Offset = "0x342")]
	[SerializeField]
	[Token(Token = "0x400058F")]
	protected bool m_isRichText; //Field offset: 0x342
	[FieldOffset(Offset = "0x343")]
	[SerializeField]
	[Token(Token = "0x4000590")]
	private bool m_EmojiFallbackSupport; //Field offset: 0x343
	[FieldOffset(Offset = "0x344")]
	[SerializeField]
	[Token(Token = "0x4000591")]
	protected bool m_parseCtrlCharacters; //Field offset: 0x344
	[FieldOffset(Offset = "0x345")]
	[Token(Token = "0x4000592")]
	protected bool m_isOverlay; //Field offset: 0x345
	[FieldOffset(Offset = "0x346")]
	[SerializeField]
	[Token(Token = "0x4000593")]
	protected bool m_isOrthographic; //Field offset: 0x346
	[FieldOffset(Offset = "0x347")]
	[SerializeField]
	[Token(Token = "0x4000594")]
	protected bool m_isCullingEnabled; //Field offset: 0x347
	[FieldOffset(Offset = "0x348")]
	[Token(Token = "0x4000595")]
	protected bool m_isMaskingEnabled; //Field offset: 0x348
	[FieldOffset(Offset = "0x349")]
	[Token(Token = "0x4000596")]
	protected bool isMaskUpdateRequired; //Field offset: 0x349
	[FieldOffset(Offset = "0x34A")]
	[Token(Token = "0x4000597")]
	protected bool m_ignoreCulling; //Field offset: 0x34A
	[FieldOffset(Offset = "0x34C")]
	[SerializeField]
	[Token(Token = "0x4000598")]
	protected TextureMappingOptions m_horizontalMapping; //Field offset: 0x34C
	[FieldOffset(Offset = "0x350")]
	[SerializeField]
	[Token(Token = "0x4000599")]
	protected TextureMappingOptions m_verticalMapping; //Field offset: 0x350
	[FieldOffset(Offset = "0x354")]
	[SerializeField]
	[Token(Token = "0x400059A")]
	protected float m_uvLineOffset; //Field offset: 0x354
	[FieldOffset(Offset = "0x358")]
	[Token(Token = "0x400059B")]
	protected TextRenderFlags m_renderMode; //Field offset: 0x358
	[FieldOffset(Offset = "0x35C")]
	[SerializeField]
	[Token(Token = "0x400059C")]
	protected VertexSortingOrder m_geometrySortingOrder; //Field offset: 0x35C
	[FieldOffset(Offset = "0x360")]
	[SerializeField]
	[Token(Token = "0x400059D")]
	protected bool m_IsTextObjectScaleStatic; //Field offset: 0x360
	[FieldOffset(Offset = "0x361")]
	[SerializeField]
	[Token(Token = "0x400059E")]
	protected bool m_VertexBufferAutoSizeReduction; //Field offset: 0x361
	[FieldOffset(Offset = "0x364")]
	[Token(Token = "0x400059F")]
	protected int m_firstVisibleCharacter; //Field offset: 0x364
	[FieldOffset(Offset = "0x368")]
	[Token(Token = "0x40005A0")]
	protected int m_maxVisibleCharacters; //Field offset: 0x368
	[FieldOffset(Offset = "0x36C")]
	[Token(Token = "0x40005A1")]
	protected int m_maxVisibleWords; //Field offset: 0x36C
	[FieldOffset(Offset = "0x370")]
	[Token(Token = "0x40005A2")]
	protected int m_maxVisibleLines; //Field offset: 0x370
	[FieldOffset(Offset = "0x374")]
	[SerializeField]
	[Token(Token = "0x40005A3")]
	protected bool m_useMaxVisibleDescender; //Field offset: 0x374
	[FieldOffset(Offset = "0x378")]
	[SerializeField]
	[Token(Token = "0x40005A4")]
	protected int m_pageToDisplay; //Field offset: 0x378
	[FieldOffset(Offset = "0x37C")]
	[Token(Token = "0x40005A5")]
	protected bool m_isNewPage; //Field offset: 0x37C
	[FieldOffset(Offset = "0x380")]
	[SerializeField]
	[Token(Token = "0x40005A6")]
	protected Vector4 m_margin; //Field offset: 0x380
	[FieldOffset(Offset = "0x390")]
	[Token(Token = "0x40005A7")]
	protected float m_marginLeft; //Field offset: 0x390
	[FieldOffset(Offset = "0x394")]
	[Token(Token = "0x40005A8")]
	protected float m_marginRight; //Field offset: 0x394
	[FieldOffset(Offset = "0x398")]
	[Token(Token = "0x40005A9")]
	protected float m_marginWidth; //Field offset: 0x398
	[FieldOffset(Offset = "0x39C")]
	[Token(Token = "0x40005AA")]
	protected float m_marginHeight; //Field offset: 0x39C
	[FieldOffset(Offset = "0x3A0")]
	[Token(Token = "0x40005AB")]
	protected float m_width; //Field offset: 0x3A0
	[FieldOffset(Offset = "0x3A8")]
	[Token(Token = "0x40005AC")]
	protected TMP_TextInfo m_textInfo; //Field offset: 0x3A8
	[FieldOffset(Offset = "0x3B0")]
	[Token(Token = "0x40005AD")]
	protected bool m_havePropertiesChanged; //Field offset: 0x3B0
	[FieldOffset(Offset = "0x3B1")]
	[SerializeField]
	[Token(Token = "0x40005AE")]
	protected bool m_isUsingLegacyAnimationComponent; //Field offset: 0x3B1
	[FieldOffset(Offset = "0x3B8")]
	[Token(Token = "0x40005AF")]
	protected Transform m_transform; //Field offset: 0x3B8
	[FieldOffset(Offset = "0x3C0")]
	[Token(Token = "0x40005B0")]
	protected RectTransform m_rectTransform; //Field offset: 0x3C0
	[FieldOffset(Offset = "0x3C8")]
	[Token(Token = "0x40005B1")]
	protected Vector2 m_PreviousRectTransformSize; //Field offset: 0x3C8
	[FieldOffset(Offset = "0x3D0")]
	[Token(Token = "0x40005B2")]
	protected Vector2 m_PreviousPivotPosition; //Field offset: 0x3D0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x3D8")]
	[Token(Token = "0x40005B3")]
	private bool <autoSizeTextContainer>k__BackingField; //Field offset: 0x3D8
	[FieldOffset(Offset = "0x3D9")]
	[Token(Token = "0x40005B4")]
	protected bool m_autoSizeTextContainer; //Field offset: 0x3D9
	[FieldOffset(Offset = "0x3E0")]
	[Token(Token = "0x40005B5")]
	protected Mesh m_mesh; //Field offset: 0x3E0
	[FieldOffset(Offset = "0x3E8")]
	[SerializeField]
	[Token(Token = "0x40005B6")]
	protected bool m_isVolumetricText; //Field offset: 0x3E8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x3F0")]
	[Token(Token = "0x40005BA")]
	private Action<TMP_TextInfo> OnPreRenderText; //Field offset: 0x3F0
	[FieldOffset(Offset = "0x3F8")]
	[Token(Token = "0x40005BB")]
	protected TMP_SpriteAnimator m_spriteAnimator; //Field offset: 0x3F8
	[FieldOffset(Offset = "0x400")]
	[Token(Token = "0x40005BC")]
	protected float m_flexibleHeight; //Field offset: 0x400
	[FieldOffset(Offset = "0x404")]
	[Token(Token = "0x40005BD")]
	protected float m_flexibleWidth; //Field offset: 0x404
	[FieldOffset(Offset = "0x408")]
	[Token(Token = "0x40005BE")]
	protected float m_minWidth; //Field offset: 0x408
	[FieldOffset(Offset = "0x40C")]
	[Token(Token = "0x40005BF")]
	protected float m_minHeight; //Field offset: 0x40C
	[FieldOffset(Offset = "0x410")]
	[Token(Token = "0x40005C0")]
	protected float m_maxWidth; //Field offset: 0x410
	[FieldOffset(Offset = "0x414")]
	[Token(Token = "0x40005C1")]
	protected float m_maxHeight; //Field offset: 0x414
	[FieldOffset(Offset = "0x418")]
	[Token(Token = "0x40005C2")]
	protected LayoutElement m_LayoutElement; //Field offset: 0x418
	[FieldOffset(Offset = "0x420")]
	[Token(Token = "0x40005C3")]
	protected float m_preferredWidth; //Field offset: 0x420
	[FieldOffset(Offset = "0x424")]
	[Token(Token = "0x40005C4")]
	protected float m_RenderedWidth; //Field offset: 0x424
	[FieldOffset(Offset = "0x428")]
	[Token(Token = "0x40005C5")]
	protected bool m_isPreferredWidthDirty; //Field offset: 0x428
	[FieldOffset(Offset = "0x42C")]
	[Token(Token = "0x40005C6")]
	protected float m_preferredHeight; //Field offset: 0x42C
	[FieldOffset(Offset = "0x430")]
	[Token(Token = "0x40005C7")]
	protected float m_RenderedHeight; //Field offset: 0x430
	[FieldOffset(Offset = "0x434")]
	[Token(Token = "0x40005C8")]
	protected bool m_isPreferredHeightDirty; //Field offset: 0x434
	[FieldOffset(Offset = "0x435")]
	[Token(Token = "0x40005C9")]
	protected bool m_isCalculatingPreferredValues; //Field offset: 0x435
	[FieldOffset(Offset = "0x438")]
	[Token(Token = "0x40005CA")]
	protected int m_layoutPriority; //Field offset: 0x438
	[FieldOffset(Offset = "0x43C")]
	[Token(Token = "0x40005CB")]
	protected bool m_isLayoutDirty; //Field offset: 0x43C
	[FieldOffset(Offset = "0x43D")]
	[Token(Token = "0x40005CC")]
	protected bool m_isAwake; //Field offset: 0x43D
	[FieldOffset(Offset = "0x43E")]
	[Token(Token = "0x40005CD")]
	internal bool m_isWaitingOnResourceLoad; //Field offset: 0x43E
	[FieldOffset(Offset = "0x440")]
	[Token(Token = "0x40005CE")]
	internal TextInputSources m_inputSource; //Field offset: 0x440
	[FieldOffset(Offset = "0x444")]
	[Token(Token = "0x40005CF")]
	protected float m_fontScaleMultiplier; //Field offset: 0x444
	[FieldOffset(Offset = "0x448")]
	[Token(Token = "0x40005D3")]
	protected float tag_LineIndent; //Field offset: 0x448
	[FieldOffset(Offset = "0x44C")]
	[Token(Token = "0x40005D4")]
	protected float tag_Indent; //Field offset: 0x44C
	[FieldOffset(Offset = "0x450")]
	[Token(Token = "0x40005D5")]
	protected TMP_TextProcessingStack<Single> m_indentStack; //Field offset: 0x450
	[FieldOffset(Offset = "0x470")]
	[Token(Token = "0x40005D6")]
	protected bool tag_NoParsing; //Field offset: 0x470
	[FieldOffset(Offset = "0x471")]
	[Token(Token = "0x40005D7")]
	protected bool m_isTextLayoutPhase; //Field offset: 0x471
	[FieldOffset(Offset = "0x474")]
	[Token(Token = "0x40005D8")]
	protected Quaternion m_FXRotation; //Field offset: 0x474
	[FieldOffset(Offset = "0x484")]
	[Token(Token = "0x40005D9")]
	protected Vector3 m_FXScale; //Field offset: 0x484
	[FieldOffset(Offset = "0x490")]
	[Token(Token = "0x40005DA")]
	internal TextProcessingElement[] m_TextProcessingArray; //Field offset: 0x490
	[FieldOffset(Offset = "0x498")]
	[Token(Token = "0x40005DB")]
	internal int m_InternalTextProcessingArraySize; //Field offset: 0x498
	[FieldOffset(Offset = "0x4A0")]
	[Token(Token = "0x40005DC")]
	private TMP_CharacterInfo[] m_internalCharacterInfo; //Field offset: 0x4A0
	[FieldOffset(Offset = "0x4A8")]
	[Token(Token = "0x40005DD")]
	protected int m_totalCharacterCount; //Field offset: 0x4A8
	[FieldOffset(Offset = "0x4AC")]
	[Token(Token = "0x40005E4")]
	protected int m_characterCount; //Field offset: 0x4AC
	[FieldOffset(Offset = "0x4B0")]
	[Token(Token = "0x40005E5")]
	protected int m_firstCharacterOfLine; //Field offset: 0x4B0
	[FieldOffset(Offset = "0x4B4")]
	[Token(Token = "0x40005E6")]
	protected int m_firstVisibleCharacterOfLine; //Field offset: 0x4B4
	[FieldOffset(Offset = "0x4B8")]
	[Token(Token = "0x40005E7")]
	protected int m_lastCharacterOfLine; //Field offset: 0x4B8
	[FieldOffset(Offset = "0x4BC")]
	[Token(Token = "0x40005E8")]
	protected int m_lastVisibleCharacterOfLine; //Field offset: 0x4BC
	[FieldOffset(Offset = "0x4C0")]
	[Token(Token = "0x40005E9")]
	protected int m_lineNumber; //Field offset: 0x4C0
	[FieldOffset(Offset = "0x4C4")]
	[Token(Token = "0x40005EA")]
	protected int m_lineVisibleCharacterCount; //Field offset: 0x4C4
	[FieldOffset(Offset = "0x4C8")]
	[Token(Token = "0x40005EB")]
	protected int m_lineVisibleSpaceCount; //Field offset: 0x4C8
	[FieldOffset(Offset = "0x4CC")]
	[Token(Token = "0x40005EC")]
	protected int m_pageNumber; //Field offset: 0x4CC
	[FieldOffset(Offset = "0x4D0")]
	[Token(Token = "0x40005ED")]
	protected float m_PageAscender; //Field offset: 0x4D0
	[FieldOffset(Offset = "0x4D4")]
	[Token(Token = "0x40005EE")]
	protected float m_maxTextAscender; //Field offset: 0x4D4
	[FieldOffset(Offset = "0x4D8")]
	[Token(Token = "0x40005EF")]
	protected float m_maxCapHeight; //Field offset: 0x4D8
	[FieldOffset(Offset = "0x4DC")]
	[Token(Token = "0x40005F0")]
	protected float m_ElementAscender; //Field offset: 0x4DC
	[FieldOffset(Offset = "0x4E0")]
	[Token(Token = "0x40005F1")]
	protected float m_ElementDescender; //Field offset: 0x4E0
	[FieldOffset(Offset = "0x4E4")]
	[Token(Token = "0x40005F2")]
	protected float m_maxLineAscender; //Field offset: 0x4E4
	[FieldOffset(Offset = "0x4E8")]
	[Token(Token = "0x40005F3")]
	protected float m_maxLineDescender; //Field offset: 0x4E8
	[FieldOffset(Offset = "0x4EC")]
	[Token(Token = "0x40005F4")]
	protected float m_startOfLineAscender; //Field offset: 0x4EC
	[FieldOffset(Offset = "0x4F0")]
	[Token(Token = "0x40005F5")]
	protected float m_startOfLineDescender; //Field offset: 0x4F0
	[FieldOffset(Offset = "0x4F4")]
	[Token(Token = "0x40005F6")]
	protected float m_lineOffset; //Field offset: 0x4F4
	[FieldOffset(Offset = "0x4F8")]
	[Token(Token = "0x40005F7")]
	protected Extents m_meshExtents; //Field offset: 0x4F8
	[FieldOffset(Offset = "0x508")]
	[Token(Token = "0x40005F8")]
	protected Color32 m_htmlColor; //Field offset: 0x508
	[FieldOffset(Offset = "0x510")]
	[Token(Token = "0x40005F9")]
	protected TMP_TextProcessingStack<Color32> m_colorStack; //Field offset: 0x510
	[FieldOffset(Offset = "0x530")]
	[Token(Token = "0x40005FA")]
	protected TMP_TextProcessingStack<Color32> m_underlineColorStack; //Field offset: 0x530
	[FieldOffset(Offset = "0x550")]
	[Token(Token = "0x40005FB")]
	protected TMP_TextProcessingStack<Color32> m_strikethroughColorStack; //Field offset: 0x550
	[FieldOffset(Offset = "0x570")]
	[Token(Token = "0x40005FC")]
	protected TMP_TextProcessingStack<HighlightState> m_HighlightStateStack; //Field offset: 0x570
	[FieldOffset(Offset = "0x5A0")]
	[Token(Token = "0x40005FD")]
	protected TMP_ColorGradient m_colorGradientPreset; //Field offset: 0x5A0
	[FieldOffset(Offset = "0x5A8")]
	[Token(Token = "0x40005FE")]
	protected TMP_TextProcessingStack<TMP_ColorGradient> m_colorGradientStack; //Field offset: 0x5A8
	[FieldOffset(Offset = "0x5D0")]
	[Token(Token = "0x40005FF")]
	protected bool m_colorGradientPresetIsTinted; //Field offset: 0x5D0
	[FieldOffset(Offset = "0x5D4")]
	[Token(Token = "0x4000600")]
	protected float m_tabSpacing; //Field offset: 0x5D4
	[FieldOffset(Offset = "0x5D8")]
	[Token(Token = "0x4000601")]
	protected float m_spacing; //Field offset: 0x5D8
	[FieldOffset(Offset = "0x5E0")]
	[Token(Token = "0x4000602")]
	protected TMP_TextProcessingStack<Int32>[] m_TextStyleStacks; //Field offset: 0x5E0
	[FieldOffset(Offset = "0x5E8")]
	[Token(Token = "0x4000603")]
	protected int m_TextStyleStackDepth; //Field offset: 0x5E8
	[FieldOffset(Offset = "0x5F0")]
	[Token(Token = "0x4000604")]
	protected TMP_TextProcessingStack<Int32> m_ItalicAngleStack; //Field offset: 0x5F0
	[FieldOffset(Offset = "0x610")]
	[Token(Token = "0x4000605")]
	protected int m_ItalicAngle; //Field offset: 0x610
	[FieldOffset(Offset = "0x618")]
	[Token(Token = "0x4000606")]
	protected TMP_TextProcessingStack<Int32> m_actionStack; //Field offset: 0x618
	[FieldOffset(Offset = "0x638")]
	[Token(Token = "0x4000607")]
	protected float m_padding; //Field offset: 0x638
	[FieldOffset(Offset = "0x63C")]
	[Token(Token = "0x4000608")]
	protected float m_baselineOffset; //Field offset: 0x63C
	[FieldOffset(Offset = "0x640")]
	[Token(Token = "0x4000609")]
	protected TMP_TextProcessingStack<Single> m_baselineOffsetStack; //Field offset: 0x640
	[FieldOffset(Offset = "0x660")]
	[Token(Token = "0x400060A")]
	protected float m_xAdvance; //Field offset: 0x660
	[FieldOffset(Offset = "0x664")]
	[Token(Token = "0x400060B")]
	protected TMP_TextElementType m_textElementType; //Field offset: 0x664
	[FieldOffset(Offset = "0x668")]
	[Token(Token = "0x400060C")]
	protected TMP_TextElement m_cached_TextElement; //Field offset: 0x668
	[FieldOffset(Offset = "0x670")]
	[Token(Token = "0x400060D")]
	protected SpecialCharacter m_Ellipsis; //Field offset: 0x670
	[FieldOffset(Offset = "0x690")]
	[Token(Token = "0x400060E")]
	protected SpecialCharacter m_Underline; //Field offset: 0x690
	[FieldOffset(Offset = "0x6B0")]
	[Token(Token = "0x400060F")]
	protected TMP_SpriteAsset m_defaultSpriteAsset; //Field offset: 0x6B0
	[FieldOffset(Offset = "0x6B8")]
	[Token(Token = "0x4000610")]
	protected TMP_SpriteAsset m_currentSpriteAsset; //Field offset: 0x6B8
	[FieldOffset(Offset = "0x6C0")]
	[Token(Token = "0x4000611")]
	protected int m_spriteCount; //Field offset: 0x6C0
	[FieldOffset(Offset = "0x6C4")]
	[Token(Token = "0x4000612")]
	protected int m_spriteIndex; //Field offset: 0x6C4
	[FieldOffset(Offset = "0x6C8")]
	[Token(Token = "0x4000613")]
	protected int m_spriteAnimationID; //Field offset: 0x6C8
	[FieldOffset(Offset = "0x6CC")]
	[Token(Token = "0x4000616")]
	protected bool m_ignoreActiveState; //Field offset: 0x6CC
	[FieldOffset(Offset = "0x6D0")]
	[Token(Token = "0x4000617")]
	private TextBackingContainer m_TextBackingArray; //Field offset: 0x6D0
	[FieldOffset(Offset = "0x6E0")]
	[Token(Token = "0x4000618")]
	private readonly Decimal[] k_Power; //Field offset: 0x6E0
	[Token(Token = "0x4000614")]
	private static ProfilerMarker k_ParseTextMarker; //Field offset: 0x1710
	[Token(Token = "0x4000615")]
	private static ProfilerMarker k_InsertNewLineMarker; //Field offset: 0x1718
	[Token(Token = "0x4000619")]
	protected static Vector2 k_LargePositiveVector2; //Field offset: 0x1720
	[Token(Token = "0x400061A")]
	protected static Vector2 k_LargeNegativeVector2; //Field offset: 0x1728
	[Token(Token = "0x400061B")]
	protected static float k_LargePositiveFloat; //Field offset: 0x1730
	[Token(Token = "0x400061C")]
	protected static float k_LargeNegativeFloat; //Field offset: 0x1734
	[Token(Token = "0x400061D")]
	protected static int k_LargePositiveInt; //Field offset: 0x1738
	[Token(Token = "0x400061E")]
	protected static int k_LargeNegativeInt; //Field offset: 0x173C

	[Token(Token = "0x14000003")]
	public static event Func<Int32, String, TMP_FontAsset> OnFontAssetRequest
	{
		[Address(RVA = "0x18CDF20", Offset = "0x18CD120", Length = "0x105")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60005C6")]
		 add { } //Length: 261
		[Address(RVA = "0x18CF250", Offset = "0x18CE450", Length = "0x105")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60005C7")]
		 remove { } //Length: 261
	}

	[Token(Token = "0x14000005")]
	public static event MissingCharacterEventCallback OnMissingCharacter
	{
		[Address(RVA = "0x18CE030", Offset = "0x18CD230", Length = "0xF2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60005CA")]
		 add { } //Length: 242
		[Address(RVA = "0x18CF360", Offset = "0x18CE560", Length = "0xF2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60005CB")]
		 remove { } //Length: 242
	}

	[Token(Token = "0x14000006")]
	public override event Action<TMP_TextInfo> OnPreRenderText
	{
		[Address(RVA = "0x18CE130", Offset = "0x18CD330", Length = "0xBA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60005CC")]
		 add { } //Length: 186
		[Address(RVA = "0x18CF460", Offset = "0x18CE660", Length = "0xBA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60005CD")]
		 remove { } //Length: 186
	}

	[Token(Token = "0x14000004")]
	public static event Func<Int32, String, TMP_SpriteAsset> OnSpriteAssetRequest
	{
		[Address(RVA = "0x18CE1F0", Offset = "0x18CD3F0", Length = "0x105")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60005C8")]
		 add { } //Length: 261
		[Address(RVA = "0x18CF520", Offset = "0x18CE720", Length = "0x105")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60005C9")]
		 remove { } //Length: 261
	}

	[Token(Token = "0x1700014A")]
	public TextAlignmentOptions alignment
	{
		[Address(RVA = "0x18CE300", Offset = "0x18CD500", Length = "0xD")]
		[CalledBy(Type = "Polytoria.Datamodel.UITextInput", Member = "set_JustifyText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.TextJustify"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x600056D")]
		 get { } //Length: 13
		[Address(RVA = "0x18CF630", Offset = "0x18CE830", Length = "0x41")]
		[CalledBy(Type = "Polytoria.Datamodel.UILabel", Member = "set_JustifyText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.TextJustify"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.UITextInput", Member = "set_JustifyText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.TextJustify"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 6)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600056E")]
		 set { } //Length: 65
	}

	[Token(Token = "0x17000134")]
	public float alpha
	{
		[Address(RVA = "0x18CE310", Offset = "0x18CD510", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000543")]
		 get { } //Length: 9
		[Address(RVA = "0x18CF680", Offset = "0x18CE880", Length = "0x33")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000544")]
		 set { } //Length: 51
	}

	[Token(Token = "0x17000176")]
	public override bool autoSizeTextContainer
	{
		[Address(RVA = "0x18CE320", Offset = "0x18CD520", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x60005BF")]
		 get { } //Length: 8
		[Address(RVA = "0x18CF6C0", Offset = "0x18CE8C0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x60005C0")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000179")]
	public Bounds bounds
	{
		[Address(RVA = "0x18CE330", Offset = "0x18CD530", Length = "0xC7")]
		[CalledBy(Type = typeof(TMP_InputField), Member = "AdjustTextPositionRelativeToViewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60005C4")]
		 get { } //Length: 199
	}

	[Token(Token = "0x1700014B")]
	public float characterSpacing
	{
		[Address(RVA = "0x18CE400", Offset = "0x18CD600", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600056F")]
		 get { } //Length: 9
		[Address(RVA = "0x18CF6D0", Offset = "0x18CE8D0", Length = "0x5C")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000570")]
		 set { } //Length: 92
	}

	[Token(Token = "0x17000150")]
	public float characterWidthAdjustment
	{
		[Address(RVA = "0x18CE410", Offset = "0x18CD610", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000579")]
		 get { } //Length: 9
		[Address(RVA = "0x18CF730", Offset = "0x18CE930", Length = "0x5C")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600057A")]
		 set { } //Length: 92
	}

	[Token(Token = "0x17000133")]
	public virtual Color color
	{
		[Address(RVA = "0x18CE450", Offset = "0x18CD650", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000541")]
		 get { } //Length: 14
		[Address(RVA = "0x18CF820", Offset = "0x18CEA20", Length = "0x90")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000542")]
		 set { } //Length: 144
	}

	[Token(Token = "0x17000136")]
	public VertexGradient colorGradient
	{
		[Address(RVA = "0x18CE420", Offset = "0x18CD620", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000547")]
		 get { } //Length: 47
		[Address(RVA = "0x18CF7D0", Offset = "0x18CE9D0", Length = "0x46")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000548")]
		 set { } //Length: 70
	}

	[Token(Token = "0x17000137")]
	public TMP_ColorGradient colorGradientPreset
	{
		[Address(RVA = "0x18B19C0", Offset = "0x18B0BC0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000549")]
		 get { } //Length: 8
		[Address(RVA = "0x18CF790", Offset = "0x18CE990", Length = "0x3F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600054A")]
		 set { } //Length: 63
	}

	[Token(Token = "0x1700015D")]
	public bool emojiFallbackSupport
	{
		[Address(RVA = "0x18CE460", Offset = "0x18CD660", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000590")]
		 get { } //Length: 8
		[Address(RVA = "0x18CF8B0", Offset = "0x18CEAB0", Length = "0x53")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000591")]
		 set { } //Length: 83
	}

	[Token(Token = "0x17000143")]
	public bool enableAutoSizing
	{
		[Address(RVA = "0x49B6F0", Offset = "0x49A8F0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000560")]
		 get { } //Length: 8
		[Address(RVA = "0x18CF910", Offset = "0x18CEB10", Length = "0x4C")]
		[CalledBy(Type = "Polytoria.Datamodel.UILabel", Member = "set_AutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.UITextInput", Member = "set_AutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000561")]
		 set { } //Length: 76
	}

	[Token(Token = "0x17000161")]
	public bool enableCulling
	{
		[Address(RVA = "0x18CE470", Offset = "0x18CD670", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000598")]
		 get { } //Length: 8
		[Address(RVA = "0x18CF960", Offset = "0x18CEB60", Length = "0x37")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000599")]
		 set { } //Length: 55
	}

	[Obsolete("The \"enableKerning\" property has been deprecated. Use the \"fontFeatures\" property to control what features are enabled on the text component.")]
	[Token(Token = "0x17000159")]
	public bool enableKerning
	{
		[Address(RVA = "0x18CE480", Offset = "0x18CD680", Length = "0x4C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32Enum>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32Enum"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000588")]
		 get { } //Length: 76
		[Address(RVA = "0x18CF9A0", Offset = "0x18CEBA0", Length = "0x14D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32Enum>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32Enum"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32Enum>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32Enum"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000589")]
		 set { } //Length: 333
	}

	[Token(Token = "0x17000135")]
	public bool enableVertexGradient
	{
		[Address(RVA = "0x18CE4D0", Offset = "0x18CD6D0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000545")]
		 get { } //Length: 8
		[Address(RVA = "0x18CFAF0", Offset = "0x18CECF0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000546")]
		 set { } //Length: 42
	}

	[Obsolete("The enabledWordWrapping property is now obsolete. Please use the textWrappingMode property instead.")]
	[Token(Token = "0x17000152")]
	public bool enableWordWrapping
	{
		[Address(RVA = "0x18CE4E0", Offset = "0x18CD6E0", Length = "0x17")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600057D")]
		 get { } //Length: 23
		[Address(RVA = "0x18CFB20", Offset = "0x18CED20", Length = "0x56")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600057E")]
		 set { } //Length: 86
	}

	[Token(Token = "0x1700015B")]
	public bool extraPadding
	{
		[Address(RVA = "0x18CE500", Offset = "0x18CD700", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600058C")]
		 get { } //Length: 8
		[Address(RVA = "0x18CFB80", Offset = "0x18CED80", Length = "0x53")]
		[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600058D")]
		 set { } //Length: 83
	}

	[Token(Token = "0x1700013D")]
	public Color32 faceColor
	{
		[Address(RVA = "0x18CE510", Offset = "0x18CD710", Length = "0xE3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Material), Member = "GetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Color))]
		[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000555")]
		 get { } //Length: 227
		[Address(RVA = "0x18CFBE0", Offset = "0x18CEDE0", Length = "0x7D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMPro_ExtensionMethods), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32), typeof(Color32)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x6000556")]
		 set { } //Length: 125
	}

	[Token(Token = "0x17000156")]
	public int firstOverflowCharacterIndex
	{
		[Address(RVA = "0x18CE600", Offset = "0x18CD800", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000584")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700016A")]
	public int firstVisibleCharacter
	{
		[Address(RVA = "0x18CE610", Offset = "0x18CD810", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60005AA")]
		 get { } //Length: 7
		[Address(RVA = "0x18CFC60", Offset = "0x18CEE60", Length = "0x2A")]
		[CalledBy(Type = typeof(TextMeshPro), Member = "GenerateTextMesh", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextMeshProUGUI), Member = "GenerateTextMesh", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60005AB")]
		 set { } //Length: 42
	}

	[Token(Token = "0x1700017C")]
	public override float flexibleHeight
	{
		[Address(RVA = "0x18CE620", Offset = "0x18CD820", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60005CF")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700017D")]
	public override float flexibleWidth
	{
		[Address(RVA = "0x18CE630", Offset = "0x18CD830", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60005D0")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700012E")]
	public TMP_FontAsset font
	{
		[Address(RVA = "0x3F58D0", Offset = "0x3F4AD0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000537")]
		 get { } //Length: 8
		[Address(RVA = "0x18D0110", Offset = "0x18CF310", Length = "0xCE")]
		[CalledBy(Type = typeof(TMP_InputField), Member = "set_fontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "SetGlobalFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x6000538")]
		 set { } //Length: 206
	}

	[Token(Token = "0x1700015A")]
	public List<OTL_FeatureTag> fontFeatures
	{
		[Address(RVA = "0x18CE640", Offset = "0x18CD840", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600058A")]
		 get { } //Length: 8
		[Address(RVA = "0x18CFC90", Offset = "0x18CEE90", Length = "0x59")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600058B")]
		 set { } //Length: 89
	}

	[Token(Token = "0x17000131")]
	public Material fontMaterial
	{
		[Address(RVA = "0x18CE650", Offset = "0x18CD850", Length = "0x1B")]
		[CalledBy(Type = "Polytoria.Datamodel.UILabel", Member = "UpdateOutline", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.UILabel", Member = "OnDestroy", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextMeshPro), Member = "GetMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material[])}, ReturnType = typeof(Material[]))]
		[CalledBy(Type = typeof(TextMeshProUGUI), Member = "GetMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material[])}, ReturnType = typeof(Material[]))]
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600053D")]
		 get { } //Length: 27
		[Address(RVA = "0x18CFCF0", Offset = "0x18CEEF0", Length = "0x10A")]
		[CalledBy(Type = "Polytoria.Datamodel.UILabel", Member = "UpdateOutline", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x600053E")]
		 set { } //Length: 266
	}

	[Token(Token = "0x17000132")]
	public override Material[] fontMaterials
	{
		[Address(RVA = "0x18CE670", Offset = "0x18CD870", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600053F")]
		 get { } //Length: 27
		[Address(RVA = "0x18CFE00", Offset = "0x18CF000", Length = "0x55")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000540")]
		 set { } //Length: 85
	}

	[Token(Token = "0x1700012F")]
	public override Material fontSharedMaterial
	{
		[Address(RVA = "0x3F5860", Offset = "0x3F4A60", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000539")]
		 get { } //Length: 8
		[Address(RVA = "0x18CFE60", Offset = "0x18CF060", Length = "0xBB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x600053A")]
		 set { } //Length: 187
	}

	[Token(Token = "0x17000130")]
	public override Material[] fontSharedMaterials
	{
		[Address(RVA = "0x18CE690", Offset = "0x18CD890", Length = "0x14")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600053B")]
		 get { } //Length: 20
		[Address(RVA = "0x18CFE00", Offset = "0x18CF000", Length = "0x55")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600053C")]
		 set { } //Length: 85
	}

	[Token(Token = "0x17000140")]
	public float fontSize
	{
		[Address(RVA = "0x468B80", Offset = "0x467D80", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600055B")]
		 get { } //Length: 9
		[Address(RVA = "0x18CFFE0", Offset = "0x18CF1E0", Length = "0x6D")]
		[CalledBy(Type = "Polytoria.Datamodel.Text3D", Member = "set_FontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.UILabel", Member = "set_FontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.UITextInput", Member = "set_FontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_DefaultControls), Member = "SetDefaultTextValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "set_pointSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "SetGlobalPointSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 14)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600055C")]
		 set { } //Length: 109
	}

	[Token(Token = "0x17000145")]
	public float fontSizeMax
	{
		[Address(RVA = "0x44B4A0", Offset = "0x44A6A0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000564")]
		 get { } //Length: 9
		[Address(RVA = "0x18CFF20", Offset = "0x18CF120", Length = "0x55")]
		[CalledBy(Type = "Polytoria.Datamodel.UILabel", Member = "set_MaxFontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.UITextInput", Member = "set_MaxFontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000565")]
		 set { } //Length: 85
	}

	[Token(Token = "0x17000144")]
	public float fontSizeMin
	{
		[Address(RVA = "0x18CE6B0", Offset = "0x18CD8B0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000562")]
		 get { } //Length: 9
		[Address(RVA = "0x18CFF80", Offset = "0x18CF180", Length = "0x55")]
		[CalledBy(Type = "Polytoria.Datamodel.UILabel", Member = "set_MaxFontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.UITextInput", Member = "set_MaxFontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000563")]
		 set { } //Length: 85
	}

	[Token(Token = "0x17000146")]
	public FontStyles fontStyle
	{
		[Address(RVA = "0x44B5F0", Offset = "0x44A7F0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000566")]
		 get { } //Length: 7
		[Address(RVA = "0x18D0050", Offset = "0x18CF250", Length = "0x53")]
		[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000567")]
		 set { } //Length: 83
	}

	[Token(Token = "0x17000141")]
	public FontWeight fontWeight
	{
		[Address(RVA = "0x478480", Offset = "0x477680", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600055D")]
		 get { } //Length: 7
		[Address(RVA = "0x18D00B0", Offset = "0x18CF2B0", Length = "0x53")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600055E")]
		 set { } //Length: 83
	}

	[Token(Token = "0x17000167")]
	public VertexSortingOrder geometrySortingOrder
	{
		[Address(RVA = "0x18CE6C0", Offset = "0x18CD8C0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60005A4")]
		 get { } //Length: 7
		[Address(RVA = "0x18D01E0", Offset = "0x18CF3E0", Length = "0x21")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60005A5")]
		 set { } //Length: 33
	}

	[Token(Token = "0x17000172")]
	public bool havePropertiesChanged
	{
		[Address(RVA = "0x18CE6D0", Offset = "0x18CD8D0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60005B9")]
		 get { } //Length: 8
		[Address(RVA = "0x18D0210", Offset = "0x18CF410", Length = "0x23")]
		[CalledBy(Type = typeof(TMP_SubMesh), Member = "OnDestroy", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_SubMeshUI), Member = "OnDestroy", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60005BA")]
		 set { } //Length: 35
	}

	[Token(Token = "0x17000148")]
	public HorizontalAlignmentOptions horizontalAlignment
	{
		[Address(RVA = "0x154CF20", Offset = "0x154C120", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000569")]
		 get { } //Length: 7
		[Address(RVA = "0x18D0240", Offset = "0x18CF440", Length = "0x2A")]
		[CalledBy(Type = "Polytoria.Datamodel.Text3D", Member = "set_HorizontalAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HorizontalAlignmentOptions)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600056A")]
		 set { } //Length: 42
	}

	[Token(Token = "0x17000163")]
	public TextureMappingOptions horizontalMapping
	{
		[Address(RVA = "0x18CE6E0", Offset = "0x18CD8E0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600059C")]
		 get { } //Length: 7
		[Address(RVA = "0x18D0270", Offset = "0x18CF470", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600059D")]
		 set { } //Length: 42
	}

	[Token(Token = "0x17000162")]
	public bool ignoreVisibility
	{
		[Address(RVA = "0x18CE6F0", Offset = "0x18CD8F0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600059A")]
		 get { } //Length: 8
		[Address(RVA = "0x18D02A0", Offset = "0x18CF4A0", Length = "0x16")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600059B")]
		 set { } //Length: 22
	}

	[Token(Token = "0x17000160")]
	public bool isOrthographic
	{
		[Address(RVA = "0x18CE700", Offset = "0x18CD900", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000596")]
		 get { } //Length: 8
		[Address(RVA = "0x18D02C0", Offset = "0x18CF4C0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000597")]
		 set { } //Length: 42
	}

	[Token(Token = "0x1700015F")]
	public bool isOverlay
	{
		[Address(RVA = "0x18CE710", Offset = "0x18CD910", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000594")]
		 get { } //Length: 8
		[Address(RVA = "0x18D02F0", Offset = "0x18CF4F0", Length = "0x53")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000595")]
		 set { } //Length: 83
	}

	[Token(Token = "0x1700012D")]
	public bool isRightToLeftText
	{
		[Address(RVA = "0x1656470", Offset = "0x1655670", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000535")]
		 get { } //Length: 8
		[Address(RVA = "0x18D0350", Offset = "0x18CF550", Length = "0x53")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000536")]
		 set { } //Length: 83
	}

	[Token(Token = "0x17000168")]
	public bool isTextObjectScaleStatic
	{
		[Address(RVA = "0x18CE720", Offset = "0x18CD920", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60005A6")]
		 get { } //Length: 8
		[Address(RVA = "0x18D03B0", Offset = "0x18CF5B0", Length = "0x96")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_UpdateManager), Member = "RegisterTextObjectForUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TMP_UpdateManager), Member = "UnRegisterTextObjectForUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
		[Token(Token = "0x60005A7")]
		 set { } //Length: 150
	}

	[Token(Token = "0x17000155")]
	public bool isTextOverflowing
	{
		[Address(RVA = "0x18CE730", Offset = "0x18CD930", Length = "0xB")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000583")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000158")]
	public bool isTextTruncated
	{
		[Address(RVA = "0x834D10", Offset = "0x833F10", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000587")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000147")]
	public bool isUsingBold
	{
		[Address(RVA = "0x18CE740", Offset = "0x18CD940", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000568")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000173")]
	public bool isUsingLegacyAnimationComponent
	{
		[Address(RVA = "0x18CE750", Offset = "0x18CD950", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60005BB")]
		 get { } //Length: 8
		[Address(RVA = "0x18D0450", Offset = "0x18CF650", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60005BC")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000178")]
	public bool isVolumetricText
	{
		[Address(RVA = "0x18CE760", Offset = "0x18CD960", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60005C2")]
		 get { } //Length: 8
		[Address(RVA = "0x18D0460", Offset = "0x18CF660", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_TextInfo), Member = "ResetVertexLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60005C3")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000182")]
	protected LayoutElement layoutElement
	{
		[Address(RVA = "0x18CE770", Offset = "0x18CD970", Length = "0x99")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60005D5")]
		 get { } //Length: 153
	}

	[Token(Token = "0x17000187")]
	public override int layoutPriority
	{
		[Address(RVA = "0x18CE810", Offset = "0x18CDA10", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60005DA")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700014D")]
	public float lineSpacing
	{
		[Address(RVA = "0x18CE830", Offset = "0x18CDA30", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000573")]
		 get { } //Length: 9
		[Address(RVA = "0x18D0530", Offset = "0x18CF730", Length = "0x5C")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000574")]
		 set { } //Length: 92
	}

	[Token(Token = "0x1700014E")]
	public float lineSpacingAdjustment
	{
		[Address(RVA = "0x18CE820", Offset = "0x18CDA20", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000575")]
		 get { } //Length: 9
		[Address(RVA = "0x18D04D0", Offset = "0x18CF6D0", Length = "0x5C")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000576")]
		 set { } //Length: 92
	}

	[Token(Token = "0x17000157")]
	public TMP_Text linkedTextComponent
	{
		[Address(RVA = "0x833AA0", Offset = "0x832CA0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000585")]
		 get { } //Length: 8
		[Address(RVA = "0x18D0590", Offset = "0x18CF790", Length = "0x114")]
		[CalledBy(Type = typeof(TMP_Text), Member = "ReleaseLinkedTextComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TMP_Text), Member = "IsSelfOrLinkedAncestor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TMP_Text), Member = "ReleaseLinkedTextComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000586")]
		 set { } //Length: 276
	}

	[Token(Token = "0x17000165")]
	public float mappingUvLineOffset
	{
		[Address(RVA = "0x18CE840", Offset = "0x18CDA40", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60005A0")]
		 get { } //Length: 9
		[Address(RVA = "0x18D06B0", Offset = "0x18CF8B0", Length = "0x33")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60005A1")]
		 set { } //Length: 51
	}

	[Token(Token = "0x17000170")]
	public override Vector4 margin
	{
		[Address(RVA = "0x18CE850", Offset = "0x18CDA50", Length = "0xE")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60005B6")]
		 get { } //Length: 14
		[Address(RVA = "0x18D06F0", Offset = "0x18CF8F0", Length = "0xB9")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60005B7")]
		 set { } //Length: 185
	}

	[Token(Token = "0x17000181")]
	public float maxHeight
	{
		[Address(RVA = "0x18CE860", Offset = "0x18CDA60", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60005D4")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700016B")]
	public int maxVisibleCharacters
	{
		[Address(RVA = "0x18CE870", Offset = "0x18CDA70", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60005AC")]
		 get { } //Length: 7
		[Address(RVA = "0x18D07B0", Offset = "0x18CF9B0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60005AD")]
		 set { } //Length: 42
	}

	[Token(Token = "0x1700016D")]
	public int maxVisibleLines
	{
		[Address(RVA = "0x18CE880", Offset = "0x18CDA80", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60005B0")]
		 get { } //Length: 7
		[Address(RVA = "0x18D07E0", Offset = "0x18CF9E0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60005B1")]
		 set { } //Length: 42
	}

	[Token(Token = "0x1700016C")]
	public int maxVisibleWords
	{
		[Address(RVA = "0x18CE890", Offset = "0x18CDA90", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60005AE")]
		 get { } //Length: 7
		[Address(RVA = "0x18D0810", Offset = "0x18CFA10", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60005AF")]
		 set { } //Length: 42
	}

	[Token(Token = "0x17000180")]
	public float maxWidth
	{
		[Address(RVA = "0x18CE8A0", Offset = "0x18CDAA0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60005D3")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000177")]
	public override Mesh mesh
	{
		[Address(RVA = "0x187F4E0", Offset = "0x187E6E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005C1")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700017F")]
	public override float minHeight
	{
		[Address(RVA = "0x18CE8B0", Offset = "0x18CDAB0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60005D2")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700017E")]
	public override float minWidth
	{
		[Address(RVA = "0x18CE8C0", Offset = "0x18CDAC0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60005D1")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700013E")]
	public Color32 outlineColor
	{
		[Address(RVA = "0x18CE8D0", Offset = "0x18CDAD0", Length = "0xE3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Material), Member = "GetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Color))]
		[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000557")]
		 get { } //Length: 227
		[Address(RVA = "0x18D0840", Offset = "0x18CFA40", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMPro_ExtensionMethods), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32), typeof(Color32)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000558")]
		 set { } //Length: 103
	}

	[Token(Token = "0x1700013F")]
	public float outlineWidth
	{
		[Address(RVA = "0x18CE9C0", Offset = "0x18CDBC0", Length = "0xCD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000559")]
		 get { } //Length: 205
		[Address(RVA = "0x18D08B0", Offset = "0x18CFAB0", Length = "0x63")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600055A")]
		 set { } //Length: 99
	}

	[Token(Token = "0x17000154")]
	public TextOverflowModes overflowMode
	{
		[Address(RVA = "0x833A80", Offset = "0x832C80", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000581")]
		 get { } //Length: 7
		[Address(RVA = "0x18D0920", Offset = "0x18CFB20", Length = "0x53")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000582")]
		 set { } //Length: 83
	}

	[Token(Token = "0x1700013C")]
	public bool overrideColorTags
	{
		[Address(RVA = "0x18CEA90", Offset = "0x18CDC90", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000553")]
		 get { } //Length: 8
		[Address(RVA = "0x18D0980", Offset = "0x18CFB80", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000554")]
		 set { } //Length: 42
	}

	[Token(Token = "0x1700016F")]
	public int pageToDisplay
	{
		[Address(RVA = "0x18CEAA0", Offset = "0x18CDCA0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60005B4")]
		 get { } //Length: 7
		[Address(RVA = "0x18D09B0", Offset = "0x18CFBB0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60005B5")]
		 set { } //Length: 42
	}

	[Token(Token = "0x1700014F")]
	public float paragraphSpacing
	{
		[Address(RVA = "0x406CD0", Offset = "0x405ED0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000577")]
		 get { } //Length: 9
		[Address(RVA = "0x18D09E0", Offset = "0x18CFBE0", Length = "0x5C")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000578")]
		 set { } //Length: 92
	}

	[Token(Token = "0x1700015E")]
	public bool parseCtrlCharacters
	{
		[Address(RVA = "0x18CEAB0", Offset = "0x18CDCB0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000592")]
		 get { } //Length: 8
		[Address(RVA = "0x18D0A40", Offset = "0x18CFC40", Length = "0x53")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000593")]
		 set { } //Length: 83
	}

	[Token(Token = "0x17000142")]
	public float pixelsPerUnit
	{
		[Address(RVA = "0x18CEAC0", Offset = "0x18CDCC0", Length = "0x1F1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Canvas), Member = "get_scaleFactor", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x600055F")]
		 get { } //Length: 497
	}

	[Token(Token = "0x17000184")]
	public override float preferredHeight
	{
		[Address(RVA = "0x18CECC0", Offset = "0x18CDEC0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_Text), Member = "GetPreferredHeight", ReturnType = typeof(float))]
		[Token(Token = "0x60005D7")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000183")]
	public override float preferredWidth
	{
		[Address(RVA = "0x18CECE0", Offset = "0x18CDEE0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_Text), Member = "GetPreferredWidth", ReturnType = typeof(float))]
		[Token(Token = "0x60005D6")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000175")]
	public RectTransform rectTransform
	{
		[Address(RVA = "0x18CED00", Offset = "0x18CDF00", Length = "0x99")]
		[CallerCount(Count = 51)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60005BE")]
		 get { } //Length: 153
	}

	[Token(Token = "0x17000186")]
	public override float renderedHeight
	{
		[Address(RVA = "0x18BD100", Offset = "0x18BC300", Length = "0x22")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_Text), Member = "GetTextBounds", ReturnType = typeof(Bounds))]
		[DeduplicatedMethod]
		[Token(Token = "0x60005D9")]
		 get { } //Length: 34
	}

	[Token(Token = "0x17000185")]
	public override float renderedWidth
	{
		[Address(RVA = "0x18BD1E0", Offset = "0x18BC3E0", Length = "0x26")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_Text), Member = "GetTextBounds", ReturnType = typeof(Bounds))]
		[DeduplicatedMethod]
		[Token(Token = "0x60005D8")]
		 get { } //Length: 38
	}

	[Token(Token = "0x17000166")]
	public TextRenderFlags renderMode
	{
		[Address(RVA = "0x18CEDA0", Offset = "0x18CDFA0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60005A2")]
		 get { } //Length: 7
		[Address(RVA = "0x18D0AA0", Offset = "0x18CFCA0", Length = "0x16")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60005A3")]
		 set { } //Length: 22
	}

	[Token(Token = "0x1700015C")]
	public bool richText
	{
		[Address(RVA = "0x18CEDB0", Offset = "0x18CDFB0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600058E")]
		 get { } //Length: 8
		[Address(RVA = "0x18D0AC0", Offset = "0x18CFCC0", Length = "0x53")]
		[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "set_richText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "SetTextComponentRichTextMode", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600058F")]
		 set { } //Length: 83
	}

	[Token(Token = "0x1700017B")]
	protected TMP_SpriteAnimator spriteAnimator
	{
		[Address(RVA = "0x18CEDC0", Offset = "0x18CDFC0", Length = "0x10F")]
		[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60005CE")]
		 get { } //Length: 271
	}

	[Token(Token = "0x17000138")]
	public TMP_SpriteAsset spriteAsset
	{
		[Address(RVA = "0x18B1A00", Offset = "0x18B0C00", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600054B")]
		 get { } //Length: 8
		[Address(RVA = "0x18D0B20", Offset = "0x18CFD20", Length = "0x55")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600054C")]
		 set { } //Length: 85
	}

	[Token(Token = "0x1700013A")]
	public TMP_StyleSheet styleSheet
	{
		[Address(RVA = "0x1551D80", Offset = "0x1550F80", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600054F")]
		 get { } //Length: 8
		[Address(RVA = "0x18D0B80", Offset = "0x18CFD80", Length = "0x55")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000550")]
		 set { } //Length: 85
	}

	[Token(Token = "0x1700012B")]
	public override string text
	{
		[Address(RVA = "0x18CF040", Offset = "0x18CE240", Length = "0xF3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x6000531")]
		 get { } //Length: 243
		[Address(RVA = "0x18D0CB0", Offset = "0x18CFEB0", Length = "0xB0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000532")]
		 set { } //Length: 176
	}

	[Token(Token = "0x1700017A")]
	public Bounds textBounds
	{
		[Address(RVA = "0x18CEED0", Offset = "0x18CE0D0", Length = "0x5A")]
		[CalledBy(Type = typeof(TMP_InputField), Member = "MovePageUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "MovePageDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(TMP_Text), Member = "GetTextBounds", ReturnType = typeof(Bounds))]
		[Token(Token = "0x60005C5")]
		 get { } //Length: 90
	}

	[Token(Token = "0x17000171")]
	public TMP_TextInfo textInfo
	{
		[Address(RVA = "0x18CEF30", Offset = "0x18CE130", Length = "0x79")]
		[CallerCount(Count = 170)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(TMP_TextInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60005B8")]
		 get { } //Length: 121
	}

	[Token(Token = "0x1700012C")]
	public ITextPreprocessor textPreprocessor
	{
		[Address(RVA = "0x3CBD70", Offset = "0x3CAF70", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000533")]
		 get { } //Length: 8
		[Address(RVA = "0x3CBD80", Offset = "0x3CAF80", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000534")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700013B")]
	public TMP_Style textStyle
	{
		[Address(RVA = "0x18CEFB0", Offset = "0x18CE1B0", Length = "0x7B")]
		[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextProcessingArray", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(TMP_Text), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TMP_Style))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(TMP_Style), Member = "get_NormalStyle", ReturnType = typeof(TMP_Style))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000551")]
		 get { } //Length: 123
		[Address(RVA = "0x18D0BE0", Offset = "0x18CFDE0", Length = "0x6F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000552")]
		 set { } //Length: 111
	}

	[Token(Token = "0x17000151")]
	public TextWrappingModes textWrappingMode
	{
		[Address(RVA = "0x18CF030", Offset = "0x18CE230", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600057B")]
		 get { } //Length: 7
		[Address(RVA = "0x18D0C50", Offset = "0x18CFE50", Length = "0x53")]
		[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "EnforceContentType", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "SetTextComponentWrapMode", ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600057C")]
		 set { } //Length: 83
	}

	[Token(Token = "0x17000139")]
	public bool tintAllSprites
	{
		[Address(RVA = "0x18CF140", Offset = "0x18CE340", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600054D")]
		 get { } //Length: 8
		[Address(RVA = "0x18D0D60", Offset = "0x18CFF60", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600054E")]
		 set { } //Length: 42
	}

	[Token(Token = "0x17000174")]
	public Transform transform
	{
		[Address(RVA = "0x18CF150", Offset = "0x18CE350", Length = "0x99")]
		[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.UIController+<LoadThumbnail>d__134", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextMeshProUGUI), Member = "GetModifiedMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(Material))]
		[CalledBy(Type = typeof(TextMeshProUGUI), Member = "OnPreRenderCanvas", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Dropdown), Member = "SetupTemplate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_InputField), Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_SubMeshUI), Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextMeshProUGUI), typeof(MaterialReference)}, ReturnType = typeof(TMP_SubMeshUI))]
		[CalledBy(Type = typeof(TMP_TextUtilities), Member = "FindIntersectingLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text), typeof(Vector3), typeof(Camera)}, ReturnType = typeof(int))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60005BD")]
		 get { } //Length: 153
	}

	[Token(Token = "0x1700016E")]
	public bool useMaxVisibleDescender
	{
		[Address(RVA = "0x18CF1F0", Offset = "0x18CE3F0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60005B2")]
		 get { } //Length: 8
		[Address(RVA = "0x18D0D90", Offset = "0x18CFF90", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60005B3")]
		 set { } //Length: 42
	}

	[Token(Token = "0x17000169")]
	public bool vertexBufferAutoSizeReduction
	{
		[Address(RVA = "0x18CF200", Offset = "0x18CE400", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60005A8")]
		 get { } //Length: 8
		[Address(RVA = "0x18D0DC0", Offset = "0x18CFFC0", Length = "0x21")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60005A9")]
		 set { } //Length: 33
	}

	[Token(Token = "0x17000149")]
	public VerticalAlignmentOptions verticalAlignment
	{
		[Address(RVA = "0x18CF210", Offset = "0x18CE410", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600056B")]
		 get { } //Length: 7
		[Address(RVA = "0x18D0DF0", Offset = "0x18CFFF0", Length = "0x2A")]
		[CalledBy(Type = "Polytoria.Datamodel.Text3D", Member = "set_VerticalAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VerticalAlignmentOptions)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.UILabel", Member = "set_VerticalAlign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.TextVerticalAlign"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.UITextInput", Member = "set_VerticalAlign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.TextVerticalAlign"}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600056C")]
		 set { } //Length: 42
	}

	[Token(Token = "0x17000164")]
	public TextureMappingOptions verticalMapping
	{
		[Address(RVA = "0x18CF220", Offset = "0x18CE420", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600059E")]
		 get { } //Length: 7
		[Address(RVA = "0x18D0E20", Offset = "0x18D0020", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600059F")]
		 set { } //Length: 42
	}

	[Token(Token = "0x1700014C")]
	public float wordSpacing
	{
		[Address(RVA = "0x18CF230", Offset = "0x18CE430", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000571")]
		 get { } //Length: 9
		[Address(RVA = "0x18D0E50", Offset = "0x18D0050", Length = "0x5C")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000572")]
		 set { } //Length: 92
	}

	[Token(Token = "0x17000153")]
	public float wordWrappingRatios
	{
		[Address(RVA = "0x18CF240", Offset = "0x18CE440", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600057F")]
		 get { } //Length: 9
		[Address(RVA = "0x18D0EB0", Offset = "0x18D00B0", Length = "0x5C")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000580")]
		 set { } //Length: 92
	}

	[Address(RVA = "0x18CCB90", Offset = "0x18CBD90", Length = "0x5FC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(TMPro.TMP_TextProcessingStack`1<TMPro.WordWrapState>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000666")]
	private static TMP_Text() { }

	[Address(RVA = "0x18CD190", Offset = "0x18CC390", Length = "0xD8A")]
	[CalledBy(Type = typeof(TextMeshPro), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(bool), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextBackingContainer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(VertexGradient), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaskableGraphic), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 15)]
	[Token(Token = "0x6000665")]
	protected TMP_Text() { }

	[Address(RVA = "0x18CDF20", Offset = "0x18CD120", Length = "0x105")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60005C6")]
	public static void add_OnFontAssetRequest(Func<Int32, String, TMP_FontAsset> value) { }

	[Address(RVA = "0x18CE030", Offset = "0x18CD230", Length = "0xF2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60005CA")]
	public static void add_OnMissingCharacter(MissingCharacterEventCallback value) { }

	[Address(RVA = "0x18CE130", Offset = "0x18CD330", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60005CC")]
	public override void add_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[Address(RVA = "0x18CE1F0", Offset = "0x18CD3F0", Length = "0x105")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60005C8")]
	public static void add_OnSpriteAssetRequest(Func<Int32, String, TMP_SpriteAsset> value) { }

	[Address(RVA = "0x18B3C80", Offset = "0x18B2E80", Length = "0x494")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Decimal), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Decimal), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Decimal), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Decimal), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028F9E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Decimal), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Decimal), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextBackingContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Decimal), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Decimal), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600061F")]
	private void AddFloatToInternalTextBackingArray(float value, int padding, int precision, ref int writeIndex) { }

	[Address(RVA = "0x18B4120", Offset = "0x18B3320", Length = "0x159")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028F9E0")]
	[Calls(Type = typeof(TextBackingContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000620")]
	private void AddIntegerToInternalTextBackingArray(double number, int padding, ref int writeIndex) { }

	[Address(RVA = "0x18B4280", Offset = "0x18B3480", Length = "0x446")]
	[CalledBy(Type = typeof(TMP_Text), Member = "InsertNewLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Boolean&), typeof(Single&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000637")]
	protected void AdjustLineOffset(int startIndex, int endIndex, float offset) { }

	[Address(RVA = "0x18B46D0", Offset = "0x18B38D0", Length = "0x3759")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GlyphAdjustmentRecord), Member = "get_glyphValueRecord", ReturnType = typeof(GlyphValueRecord))]
	[Calls(Type = typeof(GlyphValueRecord), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphValueRecord), typeof(GlyphValueRecord)}, ReturnType = typeof(GlyphValueRecord))]
	[Calls(Type = typeof(TMP_TextParsingUtilities), Member = "IsBaseGlyph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "RestoreWordWrappingState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WordWrapState&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_Text), Member = "SaveWordWrappingState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WordWrapState&), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Math), Member = "Approximately", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FaceInfo), Member = "get_tabWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180289280")]
	[Calls(Type = typeof(TMP_TextParsingUtilities), Member = "IsHangul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_useModernHangulLineBreakingRules", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_TextParsingUtilities), Member = "IsCJK", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_linebreakingRules", ReturnType = typeof(LineBreakingTable))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.UInt32>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B0E70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(GlyphPairAdjustmentRecord), Member = "get_firstAdjustmentRecord", ReturnType = typeof(GlyphAdjustmentRecord))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GlyphPairAdjustmentRecord&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "get_characterLookupTable", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, TMPro.TMP_Character>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MaterialReference), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TMP_FontAsset), typeof(TMP_SpriteAsset), typeof(Material), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(FaceInfo), Member = "get_ascentLine", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(char), Member = "IsLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "IsUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "ToUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 54)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000632")]
	protected override Vector2 CalculatePreferredValues(ref float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, TextWrappingModes textWrapMode) { }

	[Address(RVA = "0x18B7E30", Offset = "0x18B7030", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000663")]
	private void ClearMarkupTagAttributes() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600064F")]
	public override void ClearMesh(bool uploadGeometry) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600064E")]
	public override void ClearMesh() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600063A")]
	public override void ComputeMarginSize() { }

	[Address(RVA = "0x18B80C0", Offset = "0x18B72C0", Length = "0x23")]
	[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(TMP_Text), Member = "ConvertToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(float))]
	[Token(Token = "0x6000661")]
	protected float ConvertToFloat(Char[] chars, int startIndex, int length) { }

	[Address(RVA = "0x18B7F10", Offset = "0x18B7110", Length = "0x1AB")]
	[CalledBy(Type = typeof(TMP_Text), Member = "ConvertToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000662")]
	protected float ConvertToFloat(Char[] chars, int startIndex, int length, out int lastIndex) { }

	[Address(RVA = "0x18B80F0", Offset = "0x18B72F0", Length = "0xB1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60005E2")]
	protected override Material CreateMaterialInstance(Material source) { }

	[Address(RVA = "0x18B81B0", Offset = "0x18B73B0", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graphic), Member = "CrossFadeAlpha", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005F6")]
	public virtual void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	[Address(RVA = "0x18B8220", Offset = "0x18B7420", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graphic), Member = "CrossFadeColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005F5")]
	public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600064D")]
	protected override void DestroySubMeshObjects() { }

	[Address(RVA = "0x18B82C0", Offset = "0x18B74C0", Length = "0xAC")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000653")]
	protected void DoMissingGlyphCallback(int unicode, int stringIndex, TMP_FontAsset fontAsset) { }

	[Address(RVA = "0x18B8370", Offset = "0x18B7570", Length = "0x647")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_Text), Member = "GetUnderlineSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_warningsDisabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_MeshInfo), Member = "ResizeMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x6000644")]
	protected override void DrawTextHighlight(Vector3 start, Vector3 end, ref int index, Color32 highlightColor) { }

	[Address(RVA = "0x18B89C0", Offset = "0x18B7BC0", Length = "0x10C8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_Text), Member = "GetUnderlineSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_MeshInfo), Member = "ResizeMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_warningsDisabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 15)]
	[Token(Token = "0x6000643")]
	protected override void DrawUnderlineMesh(Vector3 start, Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor) { }

	[Address(RVA = "0x18B9A90", Offset = "0x18B8C90", Length = "0xE02")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_MeshInfo), Member = "ResizeMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000641")]
	protected override void FillCharacterVertexBuffers(int i, bool isVolumetric) { }

	[Address(RVA = "0x18BA8A0", Offset = "0x18B9AA0", Length = "0x95C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_MeshInfo), Member = "ResizeMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMPro_ExtensionMethods), Member = "GammaToLinear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000640")]
	protected override void FillCharacterVertexBuffers(int i) { }

	[Address(RVA = "0x18BB200", Offset = "0x18BA400", Length = "0x95C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_MeshInfo), Member = "ResizeMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMPro_ExtensionMethods), Member = "GammaToLinear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000642")]
	protected override void FillSpriteVertexBuffers(int i) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005EF")]
	public override void ForceMeshUpdate(bool ignoreActiveState = false, bool forceTextReparsing = false) { }

	[Address(RVA = "0x18CE300", Offset = "0x18CD500", Length = "0xD")]
	[CalledBy(Type = "Polytoria.Datamodel.UITextInput", Member = "set_JustifyText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.TextJustify"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x600056D")]
	public TextAlignmentOptions get_alignment() { }

	[Address(RVA = "0x18CE310", Offset = "0x18CD510", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000543")]
	public float get_alpha() { }

	[Address(RVA = "0x18CE320", Offset = "0x18CD520", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x60005BF")]
	public override bool get_autoSizeTextContainer() { }

	[Address(RVA = "0x18CE330", Offset = "0x18CD530", Length = "0xC7")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "AdjustTextPositionRelativeToViewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005C4")]
	public Bounds get_bounds() { }

	[Address(RVA = "0x18CE400", Offset = "0x18CD600", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600056F")]
	public float get_characterSpacing() { }

	[Address(RVA = "0x18CE410", Offset = "0x18CD610", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000579")]
	public float get_characterWidthAdjustment() { }

	[Address(RVA = "0x18CE450", Offset = "0x18CD650", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000541")]
	public virtual Color get_color() { }

	[Address(RVA = "0x18CE420", Offset = "0x18CD620", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000547")]
	public VertexGradient get_colorGradient() { }

	[Address(RVA = "0x18B19C0", Offset = "0x18B0BC0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000549")]
	public TMP_ColorGradient get_colorGradientPreset() { }

	[Address(RVA = "0x18CE460", Offset = "0x18CD660", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000590")]
	public bool get_emojiFallbackSupport() { }

	[Address(RVA = "0x49B6F0", Offset = "0x49A8F0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000560")]
	public bool get_enableAutoSizing() { }

	[Address(RVA = "0x18CE470", Offset = "0x18CD670", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000598")]
	public bool get_enableCulling() { }

	[Address(RVA = "0x18CE480", Offset = "0x18CD680", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32Enum>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000588")]
	public bool get_enableKerning() { }

	[Address(RVA = "0x18CE4D0", Offset = "0x18CD6D0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000545")]
	public bool get_enableVertexGradient() { }

	[Address(RVA = "0x18CE4E0", Offset = "0x18CD6E0", Length = "0x17")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600057D")]
	public bool get_enableWordWrapping() { }

	[Address(RVA = "0x18CE500", Offset = "0x18CD700", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600058C")]
	public bool get_extraPadding() { }

	[Address(RVA = "0x18CE510", Offset = "0x18CD710", Length = "0xE3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "GetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000555")]
	public Color32 get_faceColor() { }

	[Address(RVA = "0x18CE600", Offset = "0x18CD800", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000584")]
	public int get_firstOverflowCharacterIndex() { }

	[Address(RVA = "0x18CE610", Offset = "0x18CD810", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60005AA")]
	public int get_firstVisibleCharacter() { }

	[Address(RVA = "0x18CE620", Offset = "0x18CD820", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60005CF")]
	public override float get_flexibleHeight() { }

	[Address(RVA = "0x18CE630", Offset = "0x18CD830", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60005D0")]
	public override float get_flexibleWidth() { }

	[Address(RVA = "0x3F58D0", Offset = "0x3F4AD0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000537")]
	public TMP_FontAsset get_font() { }

	[Address(RVA = "0x18CE640", Offset = "0x18CD840", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600058A")]
	public List<OTL_FeatureTag> get_fontFeatures() { }

	[Address(RVA = "0x18CE650", Offset = "0x18CD850", Length = "0x1B")]
	[CalledBy(Type = "Polytoria.Datamodel.UILabel", Member = "UpdateOutline", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.UILabel", Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "GetMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material[])}, ReturnType = typeof(Material[]))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "GetMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material[])}, ReturnType = typeof(Material[]))]
	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600053D")]
	public Material get_fontMaterial() { }

	[Address(RVA = "0x18CE670", Offset = "0x18CD870", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600053F")]
	public override Material[] get_fontMaterials() { }

	[Address(RVA = "0x3F5860", Offset = "0x3F4A60", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000539")]
	public override Material get_fontSharedMaterial() { }

	[Address(RVA = "0x18CE690", Offset = "0x18CD890", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600053B")]
	public override Material[] get_fontSharedMaterials() { }

	[Address(RVA = "0x468B80", Offset = "0x467D80", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600055B")]
	public float get_fontSize() { }

	[Address(RVA = "0x44B4A0", Offset = "0x44A6A0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000564")]
	public float get_fontSizeMax() { }

	[Address(RVA = "0x18CE6B0", Offset = "0x18CD8B0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000562")]
	public float get_fontSizeMin() { }

	[Address(RVA = "0x44B5F0", Offset = "0x44A7F0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000566")]
	public FontStyles get_fontStyle() { }

	[Address(RVA = "0x478480", Offset = "0x477680", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600055D")]
	public FontWeight get_fontWeight() { }

	[Address(RVA = "0x18CE6C0", Offset = "0x18CD8C0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60005A4")]
	public VertexSortingOrder get_geometrySortingOrder() { }

	[Address(RVA = "0x18CE6D0", Offset = "0x18CD8D0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60005B9")]
	public bool get_havePropertiesChanged() { }

	[Address(RVA = "0x154CF20", Offset = "0x154C120", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000569")]
	public HorizontalAlignmentOptions get_horizontalAlignment() { }

	[Address(RVA = "0x18CE6E0", Offset = "0x18CD8E0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600059C")]
	public TextureMappingOptions get_horizontalMapping() { }

	[Address(RVA = "0x18CE6F0", Offset = "0x18CD8F0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600059A")]
	public bool get_ignoreVisibility() { }

	[Address(RVA = "0x18CE700", Offset = "0x18CD900", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000596")]
	public bool get_isOrthographic() { }

	[Address(RVA = "0x18CE710", Offset = "0x18CD910", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000594")]
	public bool get_isOverlay() { }

	[Address(RVA = "0x1656470", Offset = "0x1655670", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000535")]
	public bool get_isRightToLeftText() { }

	[Address(RVA = "0x18CE720", Offset = "0x18CD920", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60005A6")]
	public bool get_isTextObjectScaleStatic() { }

	[Address(RVA = "0x18CE730", Offset = "0x18CD930", Length = "0xB")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000583")]
	public bool get_isTextOverflowing() { }

	[Address(RVA = "0x834D10", Offset = "0x833F10", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000587")]
	public bool get_isTextTruncated() { }

	[Address(RVA = "0x18CE740", Offset = "0x18CD940", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000568")]
	public bool get_isUsingBold() { }

	[Address(RVA = "0x18CE750", Offset = "0x18CD950", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60005BB")]
	public bool get_isUsingLegacyAnimationComponent() { }

	[Address(RVA = "0x18CE760", Offset = "0x18CD960", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60005C2")]
	public bool get_isVolumetricText() { }

	[Address(RVA = "0x18CE770", Offset = "0x18CD970", Length = "0x99")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60005D5")]
	protected LayoutElement get_layoutElement() { }

	[Address(RVA = "0x18CE810", Offset = "0x18CDA10", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60005DA")]
	public override int get_layoutPriority() { }

	[Address(RVA = "0x18CE830", Offset = "0x18CDA30", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000573")]
	public float get_lineSpacing() { }

	[Address(RVA = "0x18CE820", Offset = "0x18CDA20", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000575")]
	public float get_lineSpacingAdjustment() { }

	[Address(RVA = "0x833AA0", Offset = "0x832CA0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000585")]
	public TMP_Text get_linkedTextComponent() { }

	[Address(RVA = "0x18CE840", Offset = "0x18CDA40", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60005A0")]
	public float get_mappingUvLineOffset() { }

	[Address(RVA = "0x18CE850", Offset = "0x18CDA50", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60005B6")]
	public override Vector4 get_margin() { }

	[Address(RVA = "0x18CE860", Offset = "0x18CDA60", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60005D4")]
	public float get_maxHeight() { }

	[Address(RVA = "0x18CE870", Offset = "0x18CDA70", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60005AC")]
	public int get_maxVisibleCharacters() { }

	[Address(RVA = "0x18CE880", Offset = "0x18CDA80", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60005B0")]
	public int get_maxVisibleLines() { }

	[Address(RVA = "0x18CE890", Offset = "0x18CDA90", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60005AE")]
	public int get_maxVisibleWords() { }

	[Address(RVA = "0x18CE8A0", Offset = "0x18CDAA0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60005D3")]
	public float get_maxWidth() { }

	[Address(RVA = "0x187F4E0", Offset = "0x187E6E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005C1")]
	public override Mesh get_mesh() { }

	[Address(RVA = "0x18CE8B0", Offset = "0x18CDAB0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60005D2")]
	public override float get_minHeight() { }

	[Address(RVA = "0x18CE8C0", Offset = "0x18CDAC0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60005D1")]
	public override float get_minWidth() { }

	[Address(RVA = "0x18CE8D0", Offset = "0x18CDAD0", Length = "0xE3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "GetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000557")]
	public Color32 get_outlineColor() { }

	[Address(RVA = "0x18CE9C0", Offset = "0x18CDBC0", Length = "0xCD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000559")]
	public float get_outlineWidth() { }

	[Address(RVA = "0x833A80", Offset = "0x832C80", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000581")]
	public TextOverflowModes get_overflowMode() { }

	[Address(RVA = "0x18CEA90", Offset = "0x18CDC90", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000553")]
	public bool get_overrideColorTags() { }

	[Address(RVA = "0x18CEAA0", Offset = "0x18CDCA0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60005B4")]
	public int get_pageToDisplay() { }

	[Address(RVA = "0x406CD0", Offset = "0x405ED0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000577")]
	public float get_paragraphSpacing() { }

	[Address(RVA = "0x18CEAB0", Offset = "0x18CDCB0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000592")]
	public bool get_parseCtrlCharacters() { }

	[Address(RVA = "0x18CEAC0", Offset = "0x18CDCC0", Length = "0x1F1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "get_scaleFactor", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600055F")]
	public float get_pixelsPerUnit() { }

	[Address(RVA = "0x18CECC0", Offset = "0x18CDEC0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "GetPreferredHeight", ReturnType = typeof(float))]
	[Token(Token = "0x60005D7")]
	public override float get_preferredHeight() { }

	[Address(RVA = "0x18CECE0", Offset = "0x18CDEE0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "GetPreferredWidth", ReturnType = typeof(float))]
	[Token(Token = "0x60005D6")]
	public override float get_preferredWidth() { }

	[Address(RVA = "0x18CED00", Offset = "0x18CDF00", Length = "0x99")]
	[CallerCount(Count = 51)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60005BE")]
	public RectTransform get_rectTransform() { }

	[Address(RVA = "0x18BD100", Offset = "0x18BC300", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "GetTextBounds", ReturnType = typeof(Bounds))]
	[DeduplicatedMethod]
	[Token(Token = "0x60005D9")]
	public override float get_renderedHeight() { }

	[Address(RVA = "0x18BD1E0", Offset = "0x18BC3E0", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "GetTextBounds", ReturnType = typeof(Bounds))]
	[DeduplicatedMethod]
	[Token(Token = "0x60005D8")]
	public override float get_renderedWidth() { }

	[Address(RVA = "0x18CEDA0", Offset = "0x18CDFA0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60005A2")]
	public TextRenderFlags get_renderMode() { }

	[Address(RVA = "0x18CEDB0", Offset = "0x18CDFB0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600058E")]
	public bool get_richText() { }

	[Address(RVA = "0x18CEDC0", Offset = "0x18CDFC0", Length = "0x10F")]
	[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005CE")]
	protected TMP_SpriteAnimator get_spriteAnimator() { }

	[Address(RVA = "0x18B1A00", Offset = "0x18B0C00", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600054B")]
	public TMP_SpriteAsset get_spriteAsset() { }

	[Address(RVA = "0x1551D80", Offset = "0x1550F80", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600054F")]
	public TMP_StyleSheet get_styleSheet() { }

	[Address(RVA = "0x18CF040", Offset = "0x18CE240", Length = "0xF3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000531")]
	public override string get_text() { }

	[Address(RVA = "0x18CEED0", Offset = "0x18CE0D0", Length = "0x5A")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MovePageUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "MovePageDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TMP_Text), Member = "GetTextBounds", ReturnType = typeof(Bounds))]
	[Token(Token = "0x60005C5")]
	public Bounds get_textBounds() { }

	[Address(RVA = "0x18CEF30", Offset = "0x18CE130", Length = "0x79")]
	[CallerCount(Count = 170)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TMP_TextInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60005B8")]
	public TMP_TextInfo get_textInfo() { }

	[Address(RVA = "0x3CBD70", Offset = "0x3CAF70", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000533")]
	public ITextPreprocessor get_textPreprocessor() { }

	[Address(RVA = "0x18CEFB0", Offset = "0x18CE1B0", Length = "0x7B")]
	[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextProcessingArray", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TMP_Text), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TMP_Style))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TMP_Style), Member = "get_NormalStyle", ReturnType = typeof(TMP_Style))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000551")]
	public TMP_Style get_textStyle() { }

	[Address(RVA = "0x18CF030", Offset = "0x18CE230", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600057B")]
	public TextWrappingModes get_textWrappingMode() { }

	[Address(RVA = "0x18CF140", Offset = "0x18CE340", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600054D")]
	public bool get_tintAllSprites() { }

	[Address(RVA = "0x18CF150", Offset = "0x18CE350", Length = "0x99")]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.UIController+<LoadThumbnail>d__134", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "GetModifiedMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(Material))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "OnPreRenderCanvas", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "SetupTemplate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_SubMeshUI), Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextMeshProUGUI), typeof(MaterialReference)}, ReturnType = typeof(TMP_SubMeshUI))]
	[CalledBy(Type = typeof(TMP_TextUtilities), Member = "FindIntersectingLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text), typeof(Vector3), typeof(Camera)}, ReturnType = typeof(int))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60005BD")]
	public Transform get_transform() { }

	[Address(RVA = "0x18CF1F0", Offset = "0x18CE3F0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60005B2")]
	public bool get_useMaxVisibleDescender() { }

	[Address(RVA = "0x18CF200", Offset = "0x18CE400", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60005A8")]
	public bool get_vertexBufferAutoSizeReduction() { }

	[Address(RVA = "0x18CF210", Offset = "0x18CE410", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600056B")]
	public VerticalAlignmentOptions get_verticalAlignment() { }

	[Address(RVA = "0x18CF220", Offset = "0x18CE420", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600059E")]
	public TextureMappingOptions get_verticalMapping() { }

	[Address(RVA = "0x18CF230", Offset = "0x18CE430", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000571")]
	public float get_wordSpacing() { }

	[Address(RVA = "0x18CF240", Offset = "0x18CE440", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600057F")]
	public float get_wordWrappingRatios() { }

	[Address(RVA = "0x18BBB60", Offset = "0x18BAD60", Length = "0x213")]
	[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000660")]
	private int GetAttributeParameters(Char[] chars, int startIndex, int length, ref Single[] parameters) { }

	[Address(RVA = "0x18BBD80", Offset = "0x18BAF80", Length = "0x24")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000634")]
	internal override Rect GetCanvasSpaceClippingRect() { }

	[Address(RVA = "0xE7ED70", Offset = "0xE7DF70", Length = "0x10")]
	[CallerCount(Count = 140)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000633")]
	protected override Bounds GetCompoundBounds() { }

	[Address(RVA = "0x18BBDB0", Offset = "0x18BAFB0", Length = "0x320")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetSpecialCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_FontAssetUtilities), Member = "GetCharacterFromFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_FontAsset), typeof(bool), typeof(FontStyles), typeof(FontWeight), typeof(Boolean&)}, ReturnType = typeof(TMP_Character))]
	[Calls(Type = typeof(TMP_FontAssetUtilities), Member = "GetCharacterFromFontAssets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_FontAsset), typeof(System.Collections.Generic.List`1<TMPro.TMP_FontAsset>), typeof(bool), typeof(FontStyles), typeof(FontWeight), typeof(Boolean&)}, ReturnType = typeof(TMP_Character))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_fallbackFontAssets", ReturnType = typeof(System.Collections.Generic.List`1<TMPro.TMP_FontAsset>))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_defaultFontAsset", ReturnType = typeof(TMP_FontAsset))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SpecialCharacter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Character), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000647")]
	protected void GetEllipsisSpecialCharacter(TMP_FontAsset fontAsset) { }

	[Address(RVA = "0x18BC0E0", Offset = "0x18BB2E0", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600064A")]
	protected TMP_FontAsset GetFontAssetForWeight(int fontWeight) { }

	[Address(RVA = "0x18BC260", Offset = "0x18BB460", Length = "0xB6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_TextParsingUtilities), Member = "ToUpperASCIIFast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600061A")]
	private int GetMarkupTagHashCode(TextBackingContainer styleDefinition, int readIndex) { }

	[Address(RVA = "0x18BC170", Offset = "0x18BB370", Length = "0xEF")]
	[CalledBy(Type = typeof(TMP_Text), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_TextParsingUtilities), Member = "ToUpperASCIIFast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000619")]
	private int GetMarkupTagHashCode(UInt32[] styleDefinition, int readIndex) { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005DD")]
	protected override Material GetMaterial(Material mat) { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005E1")]
	protected override Material[] GetMaterials(Material[] mats) { }

	[Address(RVA = "0x18BC470", Offset = "0x18BB670", Length = "0x115")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ShaderUtilities), Member = "GetPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(bool), typeof(bool)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ShaderUtilities), Member = "IsMaskingEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "HasProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005ED")]
	protected override float GetPaddingForMaterial(Material mat) { }

	[Address(RVA = "0x18BC320", Offset = "0x18BB520", Length = "0x140")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ShaderUtilities), Member = "GetShaderPropertyIDs", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ShaderUtilities), Member = "GetPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(bool), typeof(bool)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ShaderUtilities), Member = "IsMaskingEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "HasProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005EC")]
	protected override float GetPaddingForMaterial() { }

	[Address(RVA = "0x18BC590", Offset = "0x18BB790", Length = "0xE3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000650")]
	public override string GetParsedText() { }

	[Address(RVA = "0x18BC680", Offset = "0x18BB880", Length = "0xBD")]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetPreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetPreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetPreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600062B")]
	private float GetPreferredHeight(Vector2 margin) { }

	[Address(RVA = "0x18BC740", Offset = "0x18BB940", Length = "0x20A")]
	[CalledBy(Type = typeof(TMP_Text), Member = "get_preferredHeight", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetPreferredValues", ReturnType = typeof(Vector2))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "ParseInputText", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600062A")]
	protected float GetPreferredHeight() { }

	[Address(RVA = "0x18BCD80", Offset = "0x18BBF80", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "GetPreferredWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(TMP_Text), Member = "GetPreferredHeight", ReturnType = typeof(float))]
	[Token(Token = "0x6000623")]
	public Vector2 GetPreferredValues() { }

	[Address(RVA = "0x18BC950", Offset = "0x18BBB50", Length = "0x65")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CanvasUpdate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CanvasUpdate)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TMP_Text), Member = "ParseInputText", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "GetPreferredWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(TMP_Text), Member = "GetPreferredHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(float))]
	[Token(Token = "0x6000624")]
	public Vector2 GetPreferredValues(float width, float height) { }

	[Address(RVA = "0x18BC9C0", Offset = "0x18BBBC0", Length = "0x1A7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextBackingContainer), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TextBackingContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "PopulateTextProcessingArray", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Text), Member = "GetPreferredWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(TMP_Text), Member = "GetPreferredHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000625")]
	public Vector2 GetPreferredValues(string text) { }

	[Address(RVA = "0x18BCB70", Offset = "0x18BBD70", Length = "0x203")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextBackingContainer), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TextBackingContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "PopulateTextProcessingArray", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "GetPreferredHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000626")]
	public Vector2 GetPreferredValues(string text, float width, float height) { }

	[Address(RVA = "0x18BCDE0", Offset = "0x18BBFE0", Length = "0x1B9")]
	[CalledBy(Type = typeof(TMP_Text), Member = "get_preferredWidth", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetPreferredValues", ReturnType = typeof(Vector2))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "ParseInputText", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000627")]
	protected float GetPreferredWidth() { }

	[Address(RVA = "0x18BCFA0", Offset = "0x18BC1A0", Length = "0x9E")]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetPreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetPreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000628")]
	private float GetPreferredWidth(Vector2 margin) { }

	[Address(RVA = "0x18BD040", Offset = "0x18BC240", Length = "0x89")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000629")]
	private float GetPreferredWidth(Vector2 margin, TextWrappingModes wrapMode) { }

	[Address(RVA = "0x18BD0D0", Offset = "0x18BC2D0", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "GetTextBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Bounds))]
	[Token(Token = "0x6000631")]
	protected float GetRenderedHeight(bool onlyVisibleCharacters) { }

	[Address(RVA = "0x18BD100", Offset = "0x18BC300", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "GetTextBounds", ReturnType = typeof(Bounds))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000630")]
	private float GetRenderedHeight() { }

	[Address(RVA = "0x18BD130", Offset = "0x18BC330", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "GetTextBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Bounds))]
	[Token(Token = "0x600062D")]
	public Vector2 GetRenderedValues(bool onlyVisibleCharacters) { }

	[Address(RVA = "0x18BD170", Offset = "0x18BC370", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "GetTextBounds", ReturnType = typeof(Bounds))]
	[Token(Token = "0x600062C")]
	public Vector2 GetRenderedValues() { }

	[Address(RVA = "0x18BD1B0", Offset = "0x18BC3B0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "GetTextBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Bounds))]
	[Token(Token = "0x600062F")]
	protected float GetRenderedWidth(bool onlyVisibleCharacters) { }

	[Address(RVA = "0x18BD1E0", Offset = "0x18BC3E0", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "GetTextBounds", ReturnType = typeof(Bounds))]
	[DeduplicatedMethod]
	[Token(Token = "0x600062E")]
	private float GetRenderedWidth() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005DF")]
	protected override Material[] GetSharedMaterials() { }

	[Address(RVA = "0x18BD210", Offset = "0x18BC410", Length = "0x30")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "LoadFontAsset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "LoadFontAsset", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TMP_Text), Member = "GetEllipsisSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "GetUnderlineSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000646")]
	protected void GetSpecialCharacters(TMP_FontAsset fontAsset) { }

	[Address(RVA = "0x18BD420", Offset = "0x18BC620", Length = "0x124")]
	[CalledBy(Type = typeof(TMP_Text), Member = "get_textStyle", ReturnType = typeof(TMP_Style))]
	[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextProcessingArray", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "ReplaceOpeningStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextBackingContainer&), typeof(int), typeof(Int32&), typeof(TextProcessingElement[]&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_Text), Member = "ReplaceOpeningStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]&), typeof(int), typeof(Int32&), typeof(TextProcessingElement[]&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_Text), Member = "ReplaceClosingStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "InsertClosingStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_StyleSheet), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TMP_Style))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_defaultStyleSheet", ReturnType = typeof(TMP_StyleSheet))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000610")]
	private TMP_Style GetStyle(int hashCode) { }

	[Address(RVA = "0x18BD330", Offset = "0x18BC530", Length = "0xE6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_TextParsingUtilities), Member = "ToUpperASCIIFast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600061B")]
	private int GetStyleHashCode(ref UInt32[] text, int index, out int closeIndex) { }

	[Address(RVA = "0x18BD240", Offset = "0x18BC440", Length = "0xF0")]
	[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextProcessingArray", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_TextParsingUtilities), Member = "ToUpperASCIIFast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x600061C")]
	private int GetStyleHashCode(ref TextBackingContainer text, int index, out int closeIndex) { }

	[Address(RVA = "0x18BD550", Offset = "0x18BC750", Length = "0x33C")]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetRenderedValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetRenderedWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetRenderedHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(float))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000636")]
	protected Bounds GetTextBounds(bool onlyVisibleCharacters) { }

	[Address(RVA = "0x18BD890", Offset = "0x18BCA90", Length = "0x2FA")]
	[CalledBy(Type = typeof(TMP_Text), Member = "get_textBounds", ReturnType = typeof(Bounds))]
	[CalledBy(Type = typeof(TMP_Text), Member = "get_renderedWidth", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TMP_Text), Member = "get_renderedHeight", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetRenderedValues", ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetRenderedWidth", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetRenderedHeight", ReturnType = typeof(float))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000635")]
	protected Bounds GetTextBounds() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005EE")]
	protected override Vector3[] GetTextContainerLocalCorners() { }

	[Address(RVA = "0x18BDB90", Offset = "0x18BCD90", Length = "0x67E")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TMP_FontAssetUtilities), Member = "GetCharacterFromFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_FontAsset), typeof(bool), typeof(FontStyles), typeof(FontWeight), typeof(Boolean&)}, ReturnType = typeof(TMP_Character))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_defaultSpriteAsset", ReturnType = typeof(TMP_SpriteAsset))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TMP_FontAssetUtilities), Member = "GetCharacterFromFontAssets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_FontAsset), typeof(System.Collections.Generic.List`1<TMPro.TMP_FontAsset>), typeof(bool), typeof(FontStyles), typeof(FontWeight), typeof(Boolean&)}, ReturnType = typeof(TMP_Character))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "AddCharacterToLookupCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_Character), typeof(FontStyles), typeof(FontWeight), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_fallbackFontAssets", ReturnType = typeof(System.Collections.Generic.List`1<TMPro.TMP_FontAsset>))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_defaultFontAsset", ReturnType = typeof(TMP_FontAsset))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_FontAssetUtilities), Member = "GetSpriteCharacterFromSpriteAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_SpriteAsset), typeof(bool)}, ReturnType = typeof(TMP_SpriteCharacter))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600064B")]
	internal TMP_TextElement GetTextElement(uint unicode, TMP_FontAsset fontAsset, FontStyles fontStyle, FontWeight fontWeight, out bool isUsingAlternativeTypeface) { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000639")]
	public override TMP_TextInfo GetTextInfo(string text) { }

	[Address(RVA = "0x18BE690", Offset = "0x18BD890", Length = "0xCA")]
	[CalledBy(Type = typeof(TMP_Text), Member = "DrawUnderlineMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Int32&), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Color32)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "DrawTextHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Int32&), typeof(Color32)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetSpecialCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_FontAssetUtilities), Member = "GetCharacterFromFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_FontAsset), typeof(bool), typeof(FontStyles), typeof(FontWeight), typeof(Boolean&)}, ReturnType = typeof(TMP_Character))]
	[Calls(Type = typeof(SpecialCharacter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Character), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000648")]
	protected void GetUnderlineSpecialCharacter(TMP_FontAsset fontAsset) { }

	[Address(RVA = "0x18BE2E0", Offset = "0x18BD4E0", Length = "0xC1")]
	[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextProcessingArray", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Text), Member = "HexToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(uint))]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x600065A")]
	private uint GetUTF16(TextBackingContainer text, int i) { }

	[Address(RVA = "0x18BE210", Offset = "0x18BD410", Length = "0xC5")]
	[CalledBy(Type = typeof(TMP_Text), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Text), Member = "HexToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000659")]
	private uint GetUTF16(UInt32[] text, int i) { }

	[Address(RVA = "0x18BE530", Offset = "0x18BD730", Length = "0x153")]
	[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextProcessingArray", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Text), Member = "HexToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(uint))]
	[CallsDeduplicatedMethods(Count = 8)]
	[Token(Token = "0x600065D")]
	private uint GetUTF32(TextBackingContainer text, int i) { }

	[Address(RVA = "0x18BE3B0", Offset = "0x18BD5B0", Length = "0x179")]
	[CalledBy(Type = typeof(TMP_Text), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Text), Member = "HexToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600065C")]
	private uint GetUTF32(UInt32[] text, int i) { }

	[Address(RVA = "0x18BE760", Offset = "0x18BD960", Length = "0x2C1")]
	[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Text), Member = "HexToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600065F")]
	protected Color32 HexCharsToColor(Char[] hexChars, int startIndex, int length) { }

	[Address(RVA = "0x18BEA30", Offset = "0x18BDC30", Length = "0x662")]
	[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Text), Member = "HexToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600065E")]
	protected Color32 HexCharsToColor(Char[] hexChars, int tagCount) { }

	[Address(RVA = "0x18BF0A0", Offset = "0x18BE2A0", Length = "0xA8")]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetUTF16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetUTF16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextBackingContainer), typeof(int)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetUTF32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetUTF32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextBackingContainer), typeof(int)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(TMP_Text), Member = "HexCharsToColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int)}, ReturnType = typeof(Color32))]
	[CalledBy(Type = typeof(TMP_Text), Member = "HexCharsToColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(Color32))]
	[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 80)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000657")]
	protected uint HexToInt(char hex) { }

	[Address(RVA = "0x18BF1C0", Offset = "0x18BE3C0", Length = "0xA8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_Text), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TMP_Style))]
	[Calls(Type = typeof(TMP_Text), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000618")]
	private void InsertClosingStyleTag(ref TextProcessingElement[] charBuffer, ref int writeIndex) { }

	[Address(RVA = "0x18BF270", Offset = "0x18BE470", Length = "0xBD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_Text), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000612")]
	private void InsertClosingTextStyle(TMP_Style style, ref TextProcessingElement[] charBuffer, ref int writeIndex) { }

	[Address(RVA = "0x18BF330", Offset = "0x18BE530", Length = "0x9D3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Text), Member = "AdjustLineOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "SaveWordWrappingState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WordWrapState&), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "ResizeLineExtents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600063B")]
	internal void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender) { }

	[Address(RVA = "0x18BFD10", Offset = "0x18BEF10", Length = "0xAB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_Text), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000617")]
	private void InsertOpeningStyleTag(TMP_Style style, ref TextProcessingElement[] charBuffer, ref int writeIndex) { }

	[Address(RVA = "0x18BFDC0", Offset = "0x18BEFC0", Length = "0xBD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_Text), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000611")]
	private void InsertOpeningTextStyle(TMP_Style style, ref TextProcessingElement[] charBuffer, ref int writeIndex) { }

	[Address(RVA = "0x18BFE80", Offset = "0x18BF080", Length = "0x46C")]
	[CalledBy(Type = typeof(TMP_Text), Member = "InsertClosingStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextProcessingArray", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "InsertOpeningTextStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Style), typeof(TextProcessingElement[]&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "InsertClosingTextStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Style), typeof(TextProcessingElement[]&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "ReplaceOpeningStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextBackingContainer&), typeof(int), typeof(Int32&), typeof(TextProcessingElement[]&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_Text), Member = "ReplaceOpeningStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]&), typeof(int), typeof(Int32&), typeof(TextProcessingElement[]&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_Text), Member = "ReplaceClosingStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "InsertOpeningStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Style), typeof(TextProcessingElement[]&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(TMP_Text), Member = "ReplaceClosingStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "ReplaceOpeningStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]&), typeof(int), typeof(Int32&), typeof(TextProcessingElement[]&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "GetUTF32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(TMP_Text), Member = "GetMarkupTagHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(TMP_Text), Member = "ResizeInternalArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TMP_Text), Member = "GetUTF16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int)}, ReturnType = typeof(uint))]
	[Token(Token = "0x6000613")]
	private void InsertTextStyleInTextProcessingArray(ref TextProcessingElement[] charBuffer, ref int writeIndex, UInt32[] styleDefinition) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005F8")]
	protected override void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005F7")]
	protected override void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	[Address(RVA = "0x18C02F0", Offset = "0x18BF4F0", Length = "0xE5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000621")]
	private string InternalTextBackingArrayToString() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000656")]
	internal override void InternalUpdate() { }

	[Address(RVA = "0x18C03E0", Offset = "0x18BF5E0", Length = "0xE2")]
	[CalledBy(Type = typeof(TMP_Text), Member = "set_linkedTextComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "IsSelfOrLinkedAncestor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "IsSelfOrLinkedAncestor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000651")]
	internal bool IsSelfOrLinkedAncestor(TMP_Text targetTextComponent) { }

	[Address(RVA = "0x18C04D0", Offset = "0x18BF6D0", Length = "0x71")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000658")]
	private bool IsValidUTF16(TextBackingContainer text, int index) { }

	[Address(RVA = "0x18C0550", Offset = "0x18BF750", Length = "0x71")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600065B")]
	private bool IsValidUTF32(TextBackingContainer text, int index) { }

	[Address(RVA = "0x18C05D0", Offset = "0x18BF7D0", Length = "0x49B")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_defaultTextMeshProTextContainerSize", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_textWrappingMode", ReturnType = typeof(TextWrappingModes))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_fontFeatures", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.OTL_FeatureTag>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32Enum>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.UInt32Enum>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_enableParseEscapeCharacters", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_enableTintAllSprites", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_defaultFontSize", ReturnType = typeof(float))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_defaultTextAutoSizingMinRatio", ReturnType = typeof(float))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_defaultTextAutoSizingMaxRatio", ReturnType = typeof(float))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_enableExtraPadding", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_defaultTextMeshProUITextContainerSize", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_enableRaycastTarget", ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_autoSizeTextContainer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009740")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(TMP_Compatibility), Member = "ConvertTextAlignmentEnumValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAlignmentOptions)}, ReturnType = typeof(TextAlignmentOptions))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_isTextObjectScaleStatic", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000645")]
	protected void LoadDefaultSettings() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005DB")]
	protected override void LoadFontAsset() { }

	[Address(RVA = "0x18C0AB0", Offset = "0x18BFCB0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000654")]
	protected Vector2 PackUV(float x, float y, float scale) { }

	[Address(RVA = "0x18C0A70", Offset = "0x18BFC70", Length = "0x39")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000655")]
	protected float PackUV(float x, float y) { }

	[Address(RVA = "0x18C0AF0", Offset = "0x18BFCF0", Length = "0x1D9")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "OnPreRenderObject", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "OnPreRenderCanvas", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetPreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetPreferredWidth", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetPreferredHeight", ReturnType = typeof(float))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(TextBackingContainer), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TextBackingContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "PopulateTextProcessingArray", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60005F9")]
	protected void ParseInputText() { }

	[Address(RVA = "0x18C0CD0", Offset = "0x18BFED0", Length = "0x10C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextBackingContainer), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TextBackingContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60005FC")]
	private void PopulateTextBackingArray(StringBuilder sourceText, int start, int length) { }

	[Address(RVA = "0x18C0DE0", Offset = "0x18BFFE0", Length = "0xF7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextBackingContainer), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TextBackingContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60005FB")]
	private void PopulateTextBackingArray(string sourceText, int start, int length) { }

	[Address(RVA = "0x18C0EE0", Offset = "0x18C00E0", Length = "0x11D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextBackingContainer), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextBackingContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60005FD")]
	private void PopulateTextBackingArray(Char[] sourceText, int start, int length) { }

	[Address(RVA = "0x18C1000", Offset = "0x18C0200", Length = "0xC7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextBackingContainer), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TextBackingContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60005FA")]
	private void PopulateTextBackingArray(string sourceText) { }

	[Address(RVA = "0x18C10D0", Offset = "0x18C02D0", Length = "0xE28")]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetPreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TMP_Text), Member = "ParseInputText", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "SetTextInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "SetCharArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetPreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(TMP_Text), Member = "ResizeInternalArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "GetStyleHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextBackingContainer&), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_Text), Member = "ResizeInternalArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "ReplaceClosingStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_TextParsingUtilities), Member = "ToUpperASCIIFast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(TMP_Text), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TMP_Style))]
	[Calls(Type = typeof(TMP_TextParsingUtilities), Member = "ConvertToUTF32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(TMP_Text), Member = "get_textStyle", ReturnType = typeof(TMP_Style))]
	[Calls(Type = typeof(TMP_Text), Member = "GetUTF16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextBackingContainer), typeof(int)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(TMP_Text), Member = "GetUTF32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextBackingContainer), typeof(int)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(TMP_Text), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005FE")]
	private void PopulateTextProcessingArray() { }

	[Address(RVA = "0x18C1F20", Offset = "0x18C1120", Length = "0x12A")]
	[CalledBy(Type = typeof(TMP_Text), Member = "set_linkedTextComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "ReleaseLinkedTextComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "ReleaseLinkedTextComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "set_linkedTextComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000652")]
	internal void ReleaseLinkedTextComponent(TMP_Text targetTextComponent) { }

	[Address(RVA = "0x18CF250", Offset = "0x18CE450", Length = "0x105")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60005C7")]
	public static void remove_OnFontAssetRequest(Func<Int32, String, TMP_FontAsset> value) { }

	[Address(RVA = "0x18CF360", Offset = "0x18CE560", Length = "0xF2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60005CB")]
	public static void remove_OnMissingCharacter(MissingCharacterEventCallback value) { }

	[Address(RVA = "0x18CF460", Offset = "0x18CE660", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60005CD")]
	public override void remove_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[Address(RVA = "0x18CF520", Offset = "0x18CE720", Length = "0x105")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60005C9")]
	public static void remove_OnSpriteAssetRequest(Func<Int32, String, TMP_SpriteAsset> value) { }

	[Address(RVA = "0x18C2050", Offset = "0x18C1250", Length = "0xBB")]
	[CalledBy(Type = typeof(TMP_Text), Member = "PopulateTextProcessingArray", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_Text), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TMP_Style))]
	[Calls(Type = typeof(TMP_Text), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000616")]
	private void ReplaceClosingStyleTag(ref TextProcessingElement[] charBuffer, ref int writeIndex) { }

	[Address(RVA = "0x18C22C0", Offset = "0x18C14C0", Length = "0x192")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_TextParsingUtilities), Member = "ToUpperASCIIFast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TMP_Text), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TMP_Style))]
	[Calls(Type = typeof(TMP_Text), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x6000614")]
	private bool ReplaceOpeningStyleTag(ref TextBackingContainer sourceText, int srcIndex, out int srcOffset, ref TextProcessingElement[] charBuffer, ref int writeIndex) { }

	[Address(RVA = "0x18C2110", Offset = "0x18C1310", Length = "0x1A5")]
	[CalledBy(Type = typeof(TMP_Text), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_TextParsingUtilities), Member = "ToUpperASCIIFast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TMP_Text), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TMP_Style))]
	[Calls(Type = typeof(TMP_Text), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000615")]
	private bool ReplaceOpeningStyleTag(ref UInt32[] sourceText, int srcIndex, out int srcOffset, ref TextProcessingElement[] charBuffer, ref int writeIndex) { }

	[Address(RVA = "0x18C2460", Offset = "0x18C1660", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000649")]
	protected void ReplaceTagWithCharacter(Int32[] chars, int insertionIndex, int tagLength, char c) { }

	[Address(RVA = "0x7689A0", Offset = "0x767BA0", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600061D")]
	private void ResizeInternalArray(ref T[] array) { }

	[Address(RVA = "0x768930", Offset = "0x767B30", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600061E")]
	private void ResizeInternalArray(ref T[] array, int size) { }

	[Address(RVA = "0x18C24C0", Offset = "0x18C16C0", Length = "0x251")]
	[CalledBy(Type = typeof(TMP_Text), Member = "InsertNewLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Boolean&), typeof(Single&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000638")]
	protected void ResizeLineExtents(int size) { }

	[Address(RVA = "0x18C2720", Offset = "0x18C1920", Length = "0x61D")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextWrappingModes)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600063D")]
	internal int RestoreWordWrappingState(ref WordWrapState state) { }

	[Address(RVA = "0x18C2D40", Offset = "0x18C1F40", Length = "0x156D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(TMPro_ExtensionMethods), Member = "MinAlpha", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600063E")]
	protected override void SaveGlyphVertexInfo(float padding, float style_padding, Color32 vertexColor) { }

	[Address(RVA = "0x18C42B0", Offset = "0x18C34B0", Length = "0x9FD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x600063F")]
	protected override void SaveSpriteVertexInfo(Color32 vertexColor) { }

	[Address(RVA = "0x18C4CB0", Offset = "0x18C3EB0", Length = "0x5D2")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextWrappingModes)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TMP_Text), Member = "InsertNewLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Boolean&), typeof(Single&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600063C")]
	internal void SaveWordWrappingState(ref WordWrapState state, int index, int count) { }

	[Address(RVA = "0x18CF630", Offset = "0x18CE830", Length = "0x41")]
	[CalledBy(Type = "Polytoria.Datamodel.UILabel", Member = "set_JustifyText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.TextJustify"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.UITextInput", Member = "set_JustifyText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.TextJustify"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600056E")]
	public void set_alignment(TextAlignmentOptions value) { }

	[Address(RVA = "0x18CF680", Offset = "0x18CE880", Length = "0x33")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000544")]
	public void set_alpha(float value) { }

	[Address(RVA = "0x18CF6C0", Offset = "0x18CE8C0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x60005C0")]
	public override void set_autoSizeTextContainer(bool value) { }

	[Address(RVA = "0x18CF6D0", Offset = "0x18CE8D0", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000570")]
	public void set_characterSpacing(float value) { }

	[Address(RVA = "0x18CF730", Offset = "0x18CE930", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600057A")]
	public void set_characterWidthAdjustment(float value) { }

	[Address(RVA = "0x18CF820", Offset = "0x18CEA20", Length = "0x90")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000542")]
	public virtual void set_color(Color value) { }

	[Address(RVA = "0x18CF7D0", Offset = "0x18CE9D0", Length = "0x46")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000548")]
	public void set_colorGradient(VertexGradient value) { }

	[Address(RVA = "0x18CF790", Offset = "0x18CE990", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600054A")]
	public void set_colorGradientPreset(TMP_ColorGradient value) { }

	[Address(RVA = "0x18CF8B0", Offset = "0x18CEAB0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000591")]
	public void set_emojiFallbackSupport(bool value) { }

	[Address(RVA = "0x18CF910", Offset = "0x18CEB10", Length = "0x4C")]
	[CalledBy(Type = "Polytoria.Datamodel.UILabel", Member = "set_AutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.UITextInput", Member = "set_AutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000561")]
	public void set_enableAutoSizing(bool value) { }

	[Address(RVA = "0x18CF960", Offset = "0x18CEB60", Length = "0x37")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000599")]
	public void set_enableCulling(bool value) { }

	[Address(RVA = "0x18CF9A0", Offset = "0x18CEBA0", Length = "0x14D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32Enum>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32Enum>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000589")]
	public void set_enableKerning(bool value) { }

	[Address(RVA = "0x18CFAF0", Offset = "0x18CECF0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000546")]
	public void set_enableVertexGradient(bool value) { }

	[Address(RVA = "0x18CFB20", Offset = "0x18CED20", Length = "0x56")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600057E")]
	public void set_enableWordWrapping(bool value) { }

	[Address(RVA = "0x18CFB80", Offset = "0x18CED80", Length = "0x53")]
	[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600058D")]
	public void set_extraPadding(bool value) { }

	[Address(RVA = "0x18CFBE0", Offset = "0x18CEDE0", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMPro_ExtensionMethods), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32), typeof(Color32)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000556")]
	public void set_faceColor(Color32 value) { }

	[Address(RVA = "0x18CFC60", Offset = "0x18CEE60", Length = "0x2A")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005AB")]
	public void set_firstVisibleCharacter(int value) { }

	[Address(RVA = "0x18D0110", Offset = "0x18CF310", Length = "0xCE")]
	[CalledBy(Type = typeof(TMP_InputField), Member = "set_fontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "SetGlobalFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000538")]
	public void set_font(TMP_FontAsset value) { }

	[Address(RVA = "0x18CFC90", Offset = "0x18CEE90", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600058B")]
	public void set_fontFeatures(List<OTL_FeatureTag> value) { }

	[Address(RVA = "0x18CFCF0", Offset = "0x18CEEF0", Length = "0x10A")]
	[CalledBy(Type = "Polytoria.Datamodel.UILabel", Member = "UpdateOutline", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600053E")]
	public void set_fontMaterial(Material value) { }

	[Address(RVA = "0x18CFE00", Offset = "0x18CF000", Length = "0x55")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000540")]
	public override void set_fontMaterials(Material[] value) { }

	[Address(RVA = "0x18CFE60", Offset = "0x18CF060", Length = "0xBB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600053A")]
	public override void set_fontSharedMaterial(Material value) { }

	[Address(RVA = "0x18CFE00", Offset = "0x18CF000", Length = "0x55")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600053C")]
	public override void set_fontSharedMaterials(Material[] value) { }

	[Address(RVA = "0x18CFFE0", Offset = "0x18CF1E0", Length = "0x6D")]
	[CalledBy(Type = "Polytoria.Datamodel.Text3D", Member = "set_FontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.UILabel", Member = "set_FontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.UITextInput", Member = "set_FontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_DefaultControls), Member = "SetDefaultTextValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "set_pointSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "SetGlobalPointSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600055C")]
	public void set_fontSize(float value) { }

	[Address(RVA = "0x18CFF20", Offset = "0x18CF120", Length = "0x55")]
	[CalledBy(Type = "Polytoria.Datamodel.UILabel", Member = "set_MaxFontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.UITextInput", Member = "set_MaxFontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000565")]
	public void set_fontSizeMax(float value) { }

	[Address(RVA = "0x18CFF80", Offset = "0x18CF180", Length = "0x55")]
	[CalledBy(Type = "Polytoria.Datamodel.UILabel", Member = "set_MaxFontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.UITextInput", Member = "set_MaxFontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000563")]
	public void set_fontSizeMin(float value) { }

	[Address(RVA = "0x18D0050", Offset = "0x18CF250", Length = "0x53")]
	[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000567")]
	public void set_fontStyle(FontStyles value) { }

	[Address(RVA = "0x18D00B0", Offset = "0x18CF2B0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600055E")]
	public void set_fontWeight(FontWeight value) { }

	[Address(RVA = "0x18D01E0", Offset = "0x18CF3E0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005A5")]
	public void set_geometrySortingOrder(VertexSortingOrder value) { }

	[Address(RVA = "0x18D0210", Offset = "0x18CF410", Length = "0x23")]
	[CalledBy(Type = typeof(TMP_SubMesh), Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_SubMeshUI), Member = "OnDestroy", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005BA")]
	public void set_havePropertiesChanged(bool value) { }

	[Address(RVA = "0x18D0240", Offset = "0x18CF440", Length = "0x2A")]
	[CalledBy(Type = "Polytoria.Datamodel.Text3D", Member = "set_HorizontalAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HorizontalAlignmentOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600056A")]
	public void set_horizontalAlignment(HorizontalAlignmentOptions value) { }

	[Address(RVA = "0x18D0270", Offset = "0x18CF470", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600059D")]
	public void set_horizontalMapping(TextureMappingOptions value) { }

	[Address(RVA = "0x18D02A0", Offset = "0x18CF4A0", Length = "0x16")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600059B")]
	public void set_ignoreVisibility(bool value) { }

	[Address(RVA = "0x18D02C0", Offset = "0x18CF4C0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000597")]
	public void set_isOrthographic(bool value) { }

	[Address(RVA = "0x18D02F0", Offset = "0x18CF4F0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000595")]
	public void set_isOverlay(bool value) { }

	[Address(RVA = "0x18D0350", Offset = "0x18CF550", Length = "0x53")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000536")]
	public void set_isRightToLeftText(bool value) { }

	[Address(RVA = "0x18D03B0", Offset = "0x18CF5B0", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_UpdateManager), Member = "RegisterTextObjectForUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_UpdateManager), Member = "UnRegisterTextObjectForUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[Token(Token = "0x60005A7")]
	public void set_isTextObjectScaleStatic(bool value) { }

	[Address(RVA = "0x18D0450", Offset = "0x18CF650", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60005BC")]
	public void set_isUsingLegacyAnimationComponent(bool value) { }

	[Address(RVA = "0x18D0460", Offset = "0x18CF660", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_TextInfo), Member = "ResetVertexLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60005C3")]
	public void set_isVolumetricText(bool value) { }

	[Address(RVA = "0x18D0530", Offset = "0x18CF730", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000574")]
	public void set_lineSpacing(float value) { }

	[Address(RVA = "0x18D04D0", Offset = "0x18CF6D0", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000576")]
	public void set_lineSpacingAdjustment(float value) { }

	[Address(RVA = "0x18D0590", Offset = "0x18CF790", Length = "0x114")]
	[CalledBy(Type = typeof(TMP_Text), Member = "ReleaseLinkedTextComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "IsSelfOrLinkedAncestor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "ReleaseLinkedTextComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000586")]
	public void set_linkedTextComponent(TMP_Text value) { }

	[Address(RVA = "0x18D06B0", Offset = "0x18CF8B0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60005A1")]
	public void set_mappingUvLineOffset(float value) { }

	[Address(RVA = "0x18D06F0", Offset = "0x18CF8F0", Length = "0xB9")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60005B7")]
	public override void set_margin(Vector4 value) { }

	[Address(RVA = "0x18D07B0", Offset = "0x18CF9B0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005AD")]
	public void set_maxVisibleCharacters(int value) { }

	[Address(RVA = "0x18D07E0", Offset = "0x18CF9E0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005B1")]
	public void set_maxVisibleLines(int value) { }

	[Address(RVA = "0x18D0810", Offset = "0x18CFA10", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005AF")]
	public void set_maxVisibleWords(int value) { }

	[Address(RVA = "0x18D0840", Offset = "0x18CFA40", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMPro_ExtensionMethods), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32), typeof(Color32)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000558")]
	public void set_outlineColor(Color32 value) { }

	[Address(RVA = "0x18D08B0", Offset = "0x18CFAB0", Length = "0x63")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600055A")]
	public void set_outlineWidth(float value) { }

	[Address(RVA = "0x18D0920", Offset = "0x18CFB20", Length = "0x53")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000582")]
	public void set_overflowMode(TextOverflowModes value) { }

	[Address(RVA = "0x18D0980", Offset = "0x18CFB80", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000554")]
	public void set_overrideColorTags(bool value) { }

	[Address(RVA = "0x18D09B0", Offset = "0x18CFBB0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005B5")]
	public void set_pageToDisplay(int value) { }

	[Address(RVA = "0x18D09E0", Offset = "0x18CFBE0", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000578")]
	public void set_paragraphSpacing(float value) { }

	[Address(RVA = "0x18D0A40", Offset = "0x18CFC40", Length = "0x53")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000593")]
	public void set_parseCtrlCharacters(bool value) { }

	[Address(RVA = "0x18D0AA0", Offset = "0x18CFCA0", Length = "0x16")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60005A3")]
	public void set_renderMode(TextRenderFlags value) { }

	[Address(RVA = "0x18D0AC0", Offset = "0x18CFCC0", Length = "0x53")]
	[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "set_richText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "SetTextComponentRichTextMode", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600058F")]
	public void set_richText(bool value) { }

	[Address(RVA = "0x18D0B20", Offset = "0x18CFD20", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600054C")]
	public void set_spriteAsset(TMP_SpriteAsset value) { }

	[Address(RVA = "0x18D0B80", Offset = "0x18CFD80", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000550")]
	public void set_styleSheet(TMP_StyleSheet value) { }

	[Address(RVA = "0x18D0CB0", Offset = "0x18CFEB0", Length = "0xB0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000532")]
	public override void set_text(string value) { }

	[Address(RVA = "0x3CBD80", Offset = "0x3CAF80", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000534")]
	public void set_textPreprocessor(ITextPreprocessor value) { }

	[Address(RVA = "0x18D0BE0", Offset = "0x18CFDE0", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000552")]
	public void set_textStyle(TMP_Style value) { }

	[Address(RVA = "0x18D0C50", Offset = "0x18CFE50", Length = "0x53")]
	[CalledBy(Type = typeof(TMP_DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "EnforceContentType", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "SetTextComponentWrapMode", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600057C")]
	public void set_textWrappingMode(TextWrappingModes value) { }

	[Address(RVA = "0x18D0D60", Offset = "0x18CFF60", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600054E")]
	public void set_tintAllSprites(bool value) { }

	[Address(RVA = "0x18D0D90", Offset = "0x18CFF90", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005B3")]
	public void set_useMaxVisibleDescender(bool value) { }

	[Address(RVA = "0x18D0DC0", Offset = "0x18CFFC0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005A9")]
	public void set_vertexBufferAutoSizeReduction(bool value) { }

	[Address(RVA = "0x18D0DF0", Offset = "0x18CFFF0", Length = "0x2A")]
	[CalledBy(Type = "Polytoria.Datamodel.Text3D", Member = "set_VerticalAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VerticalAlignmentOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.UILabel", Member = "set_VerticalAlign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.TextVerticalAlign"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.UITextInput", Member = "set_VerticalAlign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.TextVerticalAlign"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600056C")]
	public void set_verticalAlignment(VerticalAlignmentOptions value) { }

	[Address(RVA = "0x18D0E20", Offset = "0x18D0020", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600059F")]
	public void set_verticalMapping(TextureMappingOptions value) { }

	[Address(RVA = "0x18D0E50", Offset = "0x18D0050", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000572")]
	public void set_wordSpacing(float value) { }

	[Address(RVA = "0x18D0EB0", Offset = "0x18D00B0", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000580")]
	public void set_wordWrappingRatios(float value) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600064C")]
	protected override void SetActiveSubMeshes(bool state) { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000622")]
	internal override int SetArraySizes(TextProcessingElement[] unicodeChars) { }

	[Address(RVA = "0x18C5410", Offset = "0x18C4610", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "SetCharArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600060E")]
	public void SetCharArray(Char[] sourceText) { }

	[Address(RVA = "0x18C5290", Offset = "0x18C4490", Length = "0x174")]
	[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "SetCharArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TextBackingContainer), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextBackingContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "PopulateTextProcessingArray", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600060F")]
	public void SetCharArray(Char[] sourceText, int start, int length) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005EA")]
	protected override void SetCulling() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005E6")]
	protected override void SetFaceColor(Color32 color) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005DE")]
	protected override void SetFontBaseMaterial(Material mat) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005E7")]
	protected override void SetOutlineColor(Color32 color) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005E8")]
	protected override void SetOutlineThickness(float thickness) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005E9")]
	protected override void SetShaderDepth() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005DC")]
	protected override void SetSharedMaterial(Material mat) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005E0")]
	protected override void SetSharedMaterials(Material[] materials) { }

	[Address(RVA = "0x18C5A10", Offset = "0x18C4C10", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000608")]
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6) { }

	[Address(RVA = "0x18C5B80", Offset = "0x18C4D80", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000602")]
	public void SetText(string sourceText, float arg0) { }

	[Address(RVA = "0x18C55D0", Offset = "0x18C47D0", Length = "0x158")]
	[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TextBackingContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000609")]
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7) { }

	[Address(RVA = "0x18C5580", Offset = "0x18C4780", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600060A")]
	public void SetText(StringBuilder sourceText) { }

	[Address(RVA = "0x18C5BD0", Offset = "0x18C4DD0", Length = "0x161")]
	[CalledBy(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextBackingContainer), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TextBackingContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "PopulateTextProcessingArray", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600060B")]
	private void SetText(StringBuilder sourceText, int start, int length) { }

	[Address(RVA = "0x18C5410", Offset = "0x18C4610", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "SetCharArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600060C")]
	public void SetText(Char[] sourceText) { }

	[Address(RVA = "0x18C5BC0", Offset = "0x18C4DC0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "SetCharArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x600060D")]
	public void SetText(Char[] sourceText, int start, int length) { }

	[Address(RVA = "0x18C5A80", Offset = "0x18C4C80", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000606")]
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4) { }

	[Address(RVA = "0x18C5B30", Offset = "0x18C4D30", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000605")]
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3) { }

	[Address(RVA = "0x18C5AE0", Offset = "0x18C4CE0", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000604")]
	public void SetText(string sourceText, float arg0, float arg1, float arg2) { }

	[Address(RVA = "0x18C5540", Offset = "0x18C4740", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000603")]
	public void SetText(string sourceText, float arg0, float arg1) { }

	[Address(RVA = "0x18C59B0", Offset = "0x18C4BB0", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_Text), Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000607")]
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) { }

	[Address(RVA = "0x18C5880", Offset = "0x18C4A80", Length = "0x12A")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextBackingContainer), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TextBackingContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TMP_Text), Member = "PopulateTextProcessingArray", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Obsolete("Use the SetText(string) function instead.")]
	[Token(Token = "0x6000601")]
	public void SetText(string sourceText, bool syncTextInputBox = true) { }

	[Address(RVA = "0x18C5880", Offset = "0x18C4A80", Length = "0x12A")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextBackingContainer), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TextBackingContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TMP_Text), Member = "PopulateTextProcessingArray", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000600")]
	public void SetText(string sourceText) { }

	[Address(RVA = "0x18C5440", Offset = "0x18C4640", Length = "0xF7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextBackingContainer), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TextBackingContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "PopulateTextProcessingArray", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60005FF")]
	private void SetTextInternal(string sourceText) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005E5")]
	protected void SetTextSortingOrder(Int32[] order) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005E4")]
	protected void SetTextSortingOrder(VertexSortingOrder order) { }

	[Address(RVA = "0x18C5D40", Offset = "0x18C4F40", Length = "0xA9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005E3")]
	protected void SetVertexColorGradient(TMP_ColorGradient gradient) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005F3")]
	public override void SetVertices(Vector3[] vertices) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005EB")]
	internal override void UpdateCulling() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005F0")]
	public override void UpdateGeometry(Mesh mesh, int index) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005F4")]
	public override void UpdateMeshPadding() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005F2")]
	public override void UpdateVertexData() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005F1")]
	public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	[Address(RVA = "0x18C5DF0", Offset = "0x18C4FF0", Length = "0x6D9A")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextWrappingModes)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18185A9C0")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "AddSpriteAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TMP_SpriteAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_defaultSpriteAssetPath", ReturnType = typeof(string))]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "TryGetSpriteAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TMP_SpriteAsset&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "AddFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMPro.TMP_TextProcessingStack`1<TMPro.MaterialReference>), Member = "Pop", ReturnType = typeof(MaterialReference))]
	[Calls(Type = typeof(TMPro.TMP_TextProcessingStack`1<System.Single>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_defaultSpriteAsset", ReturnType = typeof(TMP_SpriteAsset))]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "TryGetFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TMP_FontAsset&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMPro.TMP_TextProcessingStack`1<System.Single>), Member = "Pop", ReturnType = typeof(float))]
	[Calls(Type = typeof(TMP_SpriteAsset), Member = "get_spriteCharacterTable", ReturnType = typeof(System.Collections.Generic.List`1<TMPro.TMP_SpriteCharacter>))]
	[Calls(Type = typeof(MaterialReference), Member = "AddMaterialReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(TMP_SpriteAsset), typeof(MaterialReference[]&), typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_SpriteAnimator), Member = "DoSpriteAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TMP_SpriteAsset), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_SpriteAsset), Member = "SearchForSpriteByHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_SpriteAsset), typeof(int), typeof(bool), typeof(Int32&)}, ReturnType = typeof(TMP_SpriteAsset))]
	[Calls(Type = typeof(TMP_Text), Member = "HexCharsToColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B0E70")]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "TryGetColorGradientPreset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TMP_ColorGradient&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_defaultColorGradientPresetsPath", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_Text), Member = "get_spriteAnimator", ReturnType = typeof(TMP_SpriteAnimator))]
	[Calls(Type = typeof(TMP_Offset), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Offset), typeof(float)}, ReturnType = typeof(TMP_Offset))]
	[Calls(Type = typeof(TMPro.TMP_TextProcessingStack`1<TMPro.HighlightState>), Member = "Remove", ReturnType = typeof(HighlightState))]
	[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_TextUtilities), Member = "ToUpperFast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TMP_Text), Member = "HexCharsToColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(TMP_Text), Member = "ConvertToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "TryGetMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Material&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_defaultFontAssetPath", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_Text), Member = "GetAttributeParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(Single[]&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "AddFontMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MaterialReference), Member = "AddMaterialReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(TMP_FontAsset), typeof(MaterialReference[]&), typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F8390")]
	[Calls(Type = typeof(TMP_Text), Member = "ConvertToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(TMP_Text), Member = "HexToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(TMPro.TMP_TextProcessingStack`1<TMPro.MaterialReference>), Member = "Remove", ReturnType = typeof(MaterialReference))]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "AddColorGradientPreset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TMP_ColorGradient)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_LinkInfo), Member = "SetLinkID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 74)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000664")]
	internal bool ValidateHtmlTag(TextProcessingElement[] chars, int startIndex, out int endIndex) { }

}

