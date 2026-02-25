namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000044")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal class TextGenerator
{
	[Token(Token = "0x2000045")]
	internal sealed class MissingCharacterEventCallback : MulticastDelegate
	{

		[Address(RVA = "0x1A59EE0", Offset = "0x1A590E0", Length = "0xA6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60001E1")]
		public MissingCharacterEventCallback(object object, IntPtr method) { }

		[Address(RVA = "0x335660", Offset = "0x334860", Length = "0x14")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001E2")]
		public override void Invoke(uint unicode, int stringIndex, TextInfo text, FontAsset fontAsset) { }

	}

	[Token(Token = "0x2000046")]
	internal struct SpecialCharacter
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000279")]
		public Character character; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400027A")]
		public FontAsset fontAsset; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400027B")]
		public Material material; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400027C")]
		public int materialIndex; //Field offset: 0x18

		[Address(RVA = "0x1A5A9B0", Offset = "0x1A59BB0", Length = "0x157")]
		[CalledBy(Type = typeof(TextGenerator), Member = "GetEllipsisSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextGenerator), Member = "GetUnderlineSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60001E3")]
		public SpecialCharacter(Character character, int materialIndex) { }

	}

	[Token(Token = "0x40001D3")]
	private const int k_Tab = 9; //Field offset: 0x0
	[Token(Token = "0x40001EE")]
	private const int k_RightSingleQuote = 8217; //Field offset: 0x0
	[Token(Token = "0x40001EF")]
	private const int k_Square = 9633; //Field offset: 0x0
	[Token(Token = "0x40001F0")]
	private const int k_HangulJamoStart = 4352; //Field offset: 0x0
	[Token(Token = "0x40001F1")]
	private const int k_HangulJamoEnd = 4607; //Field offset: 0x0
	[Token(Token = "0x40001F2")]
	private const int k_CjkStart = 11904; //Field offset: 0x0
	[Token(Token = "0x40001F3")]
	private const int k_CjkEnd = 40959; //Field offset: 0x0
	[Token(Token = "0x40001F4")]
	private const int k_HangulJameExtendedStart = 43360; //Field offset: 0x0
	[Token(Token = "0x40001F5")]
	private const int k_HangulJameExtendedEnd = 43391; //Field offset: 0x0
	[Token(Token = "0x40001F6")]
	private const int k_HangulSyllablesStart = 44032; //Field offset: 0x0
	[Token(Token = "0x40001ED")]
	private const int k_ParagraphSeparator = 8233; //Field offset: 0x0
	[Token(Token = "0x40001F7")]
	private const int k_HangulSyllablesEnd = 55295; //Field offset: 0x0
	[Token(Token = "0x40001F9")]
	private const int k_CjkIdeographsEnd = 64255; //Field offset: 0x0
	[Token(Token = "0x40001FA")]
	private const int k_CjkFormsStart = 65072; //Field offset: 0x0
	[Token(Token = "0x40001FB")]
	private const int k_CjkFormsEnd = 65103; //Field offset: 0x0
	[Token(Token = "0x40001FC")]
	private const int k_CjkHalfwidthStart = 65280; //Field offset: 0x0
	[Token(Token = "0x40001FD")]
	private const int k_CjkHalfwidthEnd = 65519; //Field offset: 0x0
	[Token(Token = "0x40001FE")]
	private const int k_EndOfText = 3; //Field offset: 0x0
	[Token(Token = "0x40001FF")]
	private const float k_FloatUnset = -32767; //Field offset: 0x0
	[Token(Token = "0x4000200")]
	private const int k_MaxCharacters = 8; //Field offset: 0x0
	[Token(Token = "0x4000201")]
	private static TextGenerator s_TextGenerator; //Field offset: 0x0
	[Token(Token = "0x40001F8")]
	private const int k_CjkIdeographsStart = 63744; //Field offset: 0x0
	[Token(Token = "0x40001EC")]
	private const int k_LineSeparator = 8232; //Field offset: 0x0
	[Token(Token = "0x40001EB")]
	private const int k_HorizontalEllipsis = 8230; //Field offset: 0x0
	[Token(Token = "0x40001DE")]
	private const int k_LesserThan = 60; //Field offset: 0x0
	[Token(Token = "0x40001D5")]
	private const int k_VerticalTab = 11; //Field offset: 0x0
	[Token(Token = "0x40001D6")]
	private const int k_CarriageReturn = 13; //Field offset: 0x0
	[Token(Token = "0x40001D7")]
	private const int k_Space = 32; //Field offset: 0x0
	[Token(Token = "0x40001D8")]
	private const int k_DoubleQuotes = 34; //Field offset: 0x0
	[Token(Token = "0x40001D9")]
	private const int k_NumberSign = 35; //Field offset: 0x0
	[Token(Token = "0x40001DA")]
	private const int k_PercentSign = 37; //Field offset: 0x0
	[Token(Token = "0x40001DB")]
	private const int k_SingleQuote = 39; //Field offset: 0x0
	[Token(Token = "0x40001DC")]
	private const int k_Plus = 43; //Field offset: 0x0
	[Token(Token = "0x40001DD")]
	private const int k_Period = 46; //Field offset: 0x0
	[Token(Token = "0x40001EA")]
	private const int k_WordJoiner = 8288; //Field offset: 0x0
	[Token(Token = "0x40001DF")]
	private const int k_Equal = 61; //Field offset: 0x0
	[Token(Token = "0x40001E0")]
	private const int k_GreaterThan = 62; //Field offset: 0x0
	[Token(Token = "0x40001E1")]
	private const int k_Underline = 95; //Field offset: 0x0
	[Token(Token = "0x40001E2")]
	private const int k_NoBreakSpace = 160; //Field offset: 0x0
	[Token(Token = "0x40001E3")]
	private const int k_SoftHyphen = 173; //Field offset: 0x0
	[Token(Token = "0x40001E4")]
	private const int k_HyphenMinus = 45; //Field offset: 0x0
	[Token(Token = "0x40001E5")]
	private const int k_FigureSpace = 8199; //Field offset: 0x0
	[Token(Token = "0x40001E6")]
	private const int k_Hyphen = 8208; //Field offset: 0x0
	[Token(Token = "0x40001E7")]
	private const int k_NonBreakingHyphen = 8209; //Field offset: 0x0
	[Token(Token = "0x40001E8")]
	private const int k_ZeroWidthSpace = 8203; //Field offset: 0x0
	[Token(Token = "0x40001E9")]
	private const int k_NarrowNoBreakSpace = 8239; //Field offset: 0x0
	[Token(Token = "0x40001D4")]
	private const int k_LineFeed = 10; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000202")]
	private static bool <IsExecutingJob>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x400020B")]
	private static MissingCharacterEventCallback OnMissingCharacter; //Field offset: 0x10
	[Token(Token = "0x4000277")]
	internal static readonly bool EnableTextAlignmentAssertions; //Field offset: 0x18
	[Token(Token = "0x4000278")]
	internal static readonly bool EnableCheckerboardPattern; //Field offset: 0x19
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000203")]
	private TextBackingContainer m_TextBackingArray; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000204")]
	internal TextProcessingElement[] m_TextProcessingArray; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000205")]
	internal int m_InternalTextProcessingArraySize; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x4000206")]
	protected bool m_VertexBufferAutoSizeReduction; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000207")]
	private Char[] m_HtmlTag; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000208")]
	internal HighlightState m_HighlightState; //Field offset: 0x38
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000209")]
	protected bool m_IsIgnoringAlignment; //Field offset: 0x4C
	[FieldOffset(Offset = "0x4D")]
	[Token(Token = "0x400020A")]
	protected bool m_IsTextTruncated; //Field offset: 0x4D
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400020C")]
	private Vector3[] m_RectTransformCorners; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400020D")]
	private float m_MarginWidth; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400020E")]
	private float m_MarginHeight; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400020F")]
	private float m_PreferredWidth; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000210")]
	private float m_PreferredHeight; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000211")]
	private FontAsset m_CurrentFontAsset; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000212")]
	private Material m_CurrentMaterial; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000213")]
	private int m_CurrentMaterialIndex; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000214")]
	private TextProcessingStack<MaterialReference> m_MaterialReferenceStack; //Field offset: 0x80
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000215")]
	private float m_Padding; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000216")]
	private SpriteAsset m_CurrentSpriteAsset; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000217")]
	private int m_TotalCharacterCount; //Field offset: 0xE8
	[FieldOffset(Offset = "0xEC")]
	[Token(Token = "0x4000218")]
	private float m_FontSize; //Field offset: 0xEC
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000219")]
	private float m_FontScaleMultiplier; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF4")]
	[Token(Token = "0x400021A")]
	private bool m_ShouldRenderBitmap; //Field offset: 0xF4
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x400021B")]
	private float m_CurrentFontSize; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x400021C")]
	private TextProcessingStack<Single> m_SizeStack; //Field offset: 0x100
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x400021D")]
	protected TextProcessingStack<Int32>[] m_TextStyleStacks; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x400021E")]
	protected int m_TextStyleStackDepth; //Field offset: 0x128
	[FieldOffset(Offset = "0x12C")]
	[Token(Token = "0x400021F")]
	private FontStyles m_FontStyleInternal; //Field offset: 0x12C
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000220")]
	private FontStyleStack m_FontStyleStack; //Field offset: 0x130
	[FieldOffset(Offset = "0x13C")]
	[Token(Token = "0x4000221")]
	private TextFontWeight m_FontWeightInternal; //Field offset: 0x13C
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4000222")]
	private TextProcessingStack<TextFontWeight> m_FontWeightStack; //Field offset: 0x140
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x4000223")]
	private TextAlignment m_LineJustification; //Field offset: 0x160
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x4000224")]
	private TextProcessingStack<TextAlignment> m_LineJustificationStack; //Field offset: 0x168
	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x4000225")]
	private float _m_BaselineOffset; //Field offset: 0x188
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4000226")]
	private TextProcessingStack<Single> m_BaselineOffsetStack; //Field offset: 0x190
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4000227")]
	private Color32 m_FontColor32; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B4")]
	[Token(Token = "0x4000228")]
	private Color32 m_HtmlColor; //Field offset: 0x1B4
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4000229")]
	private Color32 m_UnderlineColor; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1BC")]
	[Token(Token = "0x400022A")]
	private Color32 m_StrikethroughColor; //Field offset: 0x1BC
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x400022B")]
	private TextProcessingStack<Color32> m_ColorStack; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x400022C")]
	private TextProcessingStack<Color32> m_UnderlineColorStack; //Field offset: 0x1E0
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x400022D")]
	private TextProcessingStack<Color32> m_StrikethroughColorStack; //Field offset: 0x200
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x400022E")]
	private TextProcessingStack<Color32> m_HighlightColorStack; //Field offset: 0x220
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x400022F")]
	private TextProcessingStack<HighlightState> m_HighlightStateStack; //Field offset: 0x240
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x4000230")]
	private TextProcessingStack<Int32> m_ItalicAngleStack; //Field offset: 0x270
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x4000231")]
	private TextColorGradient m_ColorGradientPreset; //Field offset: 0x290
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x4000232")]
	private TextProcessingStack<TextColorGradient> m_ColorGradientStack; //Field offset: 0x298
	[FieldOffset(Offset = "0x2C0")]
	[Token(Token = "0x4000233")]
	private bool m_ColorGradientPresetIsTinted; //Field offset: 0x2C0
	[FieldOffset(Offset = "0x2C8")]
	[Token(Token = "0x4000234")]
	private TextProcessingStack<Int32> m_ActionStack; //Field offset: 0x2C8
	[FieldOffset(Offset = "0x2E8")]
	[Token(Token = "0x4000235")]
	private float _m_LineOffset; //Field offset: 0x2E8
	[FieldOffset(Offset = "0x2EC")]
	[Token(Token = "0x4000236")]
	private float _m_LineHeight; //Field offset: 0x2EC
	[FieldOffset(Offset = "0x2F0")]
	[Token(Token = "0x4000237")]
	private bool m_IsDrivenLineSpacing; //Field offset: 0x2F0
	[FieldOffset(Offset = "0x2F4")]
	[Token(Token = "0x4000238")]
	private float m_CSpacing; //Field offset: 0x2F4
	[FieldOffset(Offset = "0x2F8")]
	[Token(Token = "0x4000239")]
	private float m_MonoSpacing; //Field offset: 0x2F8
	[FieldOffset(Offset = "0x2FC")]
	[Token(Token = "0x400023A")]
	private bool m_DuoSpace; //Field offset: 0x2FC
	[FieldOffset(Offset = "0x300")]
	[Token(Token = "0x400023B")]
	private float _m_XAdvance; //Field offset: 0x300
	[FieldOffset(Offset = "0x304")]
	[Token(Token = "0x400023C")]
	private float m_TagLineIndent; //Field offset: 0x304
	[FieldOffset(Offset = "0x308")]
	[Token(Token = "0x400023D")]
	private float m_TagIndent; //Field offset: 0x308
	[FieldOffset(Offset = "0x310")]
	[Token(Token = "0x400023E")]
	private TextProcessingStack<Single> m_IndentStack; //Field offset: 0x310
	[FieldOffset(Offset = "0x330")]
	[Token(Token = "0x400023F")]
	private bool m_TagNoParsing; //Field offset: 0x330
	[FieldOffset(Offset = "0x334")]
	[Token(Token = "0x4000240")]
	private int m_CharacterCount; //Field offset: 0x334
	[FieldOffset(Offset = "0x338")]
	[Token(Token = "0x4000241")]
	private int m_FirstCharacterOfLine; //Field offset: 0x338
	[FieldOffset(Offset = "0x33C")]
	[Token(Token = "0x4000242")]
	private int m_LastCharacterOfLine; //Field offset: 0x33C
	[FieldOffset(Offset = "0x340")]
	[Token(Token = "0x4000243")]
	private int m_FirstVisibleCharacterOfLine; //Field offset: 0x340
	[FieldOffset(Offset = "0x344")]
	[Token(Token = "0x4000244")]
	private int m_LastVisibleCharacterOfLine; //Field offset: 0x344
	[FieldOffset(Offset = "0x348")]
	[Token(Token = "0x4000245")]
	private float m_MaxLineAscender; //Field offset: 0x348
	[FieldOffset(Offset = "0x34C")]
	[Token(Token = "0x4000246")]
	private float m_MaxLineDescender; //Field offset: 0x34C
	[FieldOffset(Offset = "0x350")]
	[Token(Token = "0x4000247")]
	private int m_LineNumber; //Field offset: 0x350
	[FieldOffset(Offset = "0x354")]
	[Token(Token = "0x4000248")]
	private int m_LineVisibleCharacterCount; //Field offset: 0x354
	[FieldOffset(Offset = "0x358")]
	[Token(Token = "0x4000249")]
	private int m_LineVisibleSpaceCount; //Field offset: 0x358
	[FieldOffset(Offset = "0x35C")]
	[Token(Token = "0x400024A")]
	private int m_FirstOverflowCharacterIndex; //Field offset: 0x35C
	[FieldOffset(Offset = "0x360")]
	[Token(Token = "0x400024B")]
	private float m_MarginLeft; //Field offset: 0x360
	[FieldOffset(Offset = "0x364")]
	[Token(Token = "0x400024C")]
	private float m_MarginRight; //Field offset: 0x364
	[FieldOffset(Offset = "0x368")]
	[Token(Token = "0x400024D")]
	private float m_Width; //Field offset: 0x368
	[FieldOffset(Offset = "0x36C")]
	[Token(Token = "0x400024E")]
	private Extents m_MeshExtents; //Field offset: 0x36C
	[FieldOffset(Offset = "0x37C")]
	[Token(Token = "0x400024F")]
	private float m_MaxCapHeight; //Field offset: 0x37C
	[FieldOffset(Offset = "0x380")]
	[Token(Token = "0x4000250")]
	private float m_MaxAscender; //Field offset: 0x380
	[FieldOffset(Offset = "0x384")]
	[Token(Token = "0x4000251")]
	private float m_MaxDescender; //Field offset: 0x384
	[FieldOffset(Offset = "0x388")]
	[Token(Token = "0x4000252")]
	private bool m_IsNonBreakingSpace; //Field offset: 0x388
	[FieldOffset(Offset = "0x390")]
	[Token(Token = "0x4000253")]
	private WordWrapState m_SavedWordWrapState; //Field offset: 0x390
	[FieldOffset(Offset = "0x728")]
	[Token(Token = "0x4000254")]
	private WordWrapState m_SavedLineState; //Field offset: 0x728
	[FieldOffset(Offset = "0xAC0")]
	[Token(Token = "0x4000255")]
	private WordWrapState m_SavedEllipsisState; //Field offset: 0xAC0
	[FieldOffset(Offset = "0xE58")]
	[Token(Token = "0x4000256")]
	private WordWrapState m_SavedLastValidState; //Field offset: 0xE58
	[FieldOffset(Offset = "0x11F0")]
	[Token(Token = "0x4000257")]
	private WordWrapState m_SavedSoftLineBreakState; //Field offset: 0x11F0
	[FieldOffset(Offset = "0x1588")]
	[Token(Token = "0x4000258")]
	private TextElementType m_TextElementType; //Field offset: 0x1588
	[FieldOffset(Offset = "0x1589")]
	[Token(Token = "0x4000259")]
	private bool m_isTextLayoutPhase; //Field offset: 0x1589
	[FieldOffset(Offset = "0x158C")]
	[Token(Token = "0x400025A")]
	private int m_SpriteIndex; //Field offset: 0x158C
	[FieldOffset(Offset = "0x1590")]
	[Token(Token = "0x400025B")]
	private Color32 m_SpriteColor; //Field offset: 0x1590
	[FieldOffset(Offset = "0x1598")]
	[Token(Token = "0x400025C")]
	private TextElement m_CachedTextElement; //Field offset: 0x1598
	[FieldOffset(Offset = "0x15A0")]
	[Token(Token = "0x400025D")]
	private Color32 m_HighlightColor; //Field offset: 0x15A0
	[FieldOffset(Offset = "0x15A4")]
	[Token(Token = "0x400025E")]
	private float m_CharWidthAdjDelta; //Field offset: 0x15A4
	[FieldOffset(Offset = "0x15A8")]
	[Token(Token = "0x400025F")]
	private float m_MaxFontSize; //Field offset: 0x15A8
	[FieldOffset(Offset = "0x15AC")]
	[Token(Token = "0x4000260")]
	private float m_MinFontSize; //Field offset: 0x15AC
	[FieldOffset(Offset = "0x15B0")]
	[Token(Token = "0x4000261")]
	private int m_AutoSizeIterationCount; //Field offset: 0x15B0
	[FieldOffset(Offset = "0x15B4")]
	[Token(Token = "0x4000262")]
	private int m_AutoSizeMaxIterationCount; //Field offset: 0x15B4
	[FieldOffset(Offset = "0x15B8")]
	[Token(Token = "0x4000263")]
	private float m_StartOfLineAscender; //Field offset: 0x15B8
	[FieldOffset(Offset = "0x15BC")]
	[Token(Token = "0x4000264")]
	private float m_LineSpacingDelta; //Field offset: 0x15BC
	[FieldOffset(Offset = "0x15C0")]
	[Token(Token = "0x4000265")]
	internal MaterialReference[] m_MaterialReferences; //Field offset: 0x15C0
	[FieldOffset(Offset = "0x15C8")]
	[Token(Token = "0x4000266")]
	private int m_SpriteCount; //Field offset: 0x15C8
	[FieldOffset(Offset = "0x15D0")]
	[Token(Token = "0x4000267")]
	private TextProcessingStack<Int32> m_StyleStack; //Field offset: 0x15D0
	[FieldOffset(Offset = "0x15F0")]
	[Token(Token = "0x4000268")]
	private TextProcessingStack<WordWrapState> m_EllipsisInsertionCandidateStack; //Field offset: 0x15F0
	[FieldOffset(Offset = "0x19A8")]
	[Token(Token = "0x4000269")]
	private int m_SpriteAnimationId; //Field offset: 0x19A8
	[FieldOffset(Offset = "0x19AC")]
	[Token(Token = "0x400026A")]
	private int m_ItalicAngle; //Field offset: 0x19AC
	[FieldOffset(Offset = "0x19B0")]
	[Token(Token = "0x400026B")]
	private Vector3 m_FXScale; //Field offset: 0x19B0
	[FieldOffset(Offset = "0x19BC")]
	[Token(Token = "0x400026C")]
	private Quaternion m_FXRotation; //Field offset: 0x19BC
	[FieldOffset(Offset = "0x19CC")]
	[Token(Token = "0x400026D")]
	private int m_LastBaseGlyphIndex; //Field offset: 0x19CC
	[FieldOffset(Offset = "0x19D0")]
	[Token(Token = "0x400026E")]
	private float m_PageAscender; //Field offset: 0x19D0
	[FieldOffset(Offset = "0x19D8")]
	[Token(Token = "0x400026F")]
	private RichTextTagAttribute[] m_XmlAttribute; //Field offset: 0x19D8
	[FieldOffset(Offset = "0x19E0")]
	[Token(Token = "0x4000270")]
	private Single[] m_AttributeParameterValues; //Field offset: 0x19E0
	[FieldOffset(Offset = "0x19E8")]
	[Token(Token = "0x4000271")]
	private Dictionary<Int32, Int32> m_MaterialReferenceIndexLookup; //Field offset: 0x19E8
	[FieldOffset(Offset = "0x19F0")]
	[Token(Token = "0x4000272")]
	private bool m_IsCalculatingPreferredValues; //Field offset: 0x19F0
	[FieldOffset(Offset = "0x19F1")]
	[Token(Token = "0x4000273")]
	private bool m_TintSprite; //Field offset: 0x19F1
	[FieldOffset(Offset = "0x19F8")]
	[Token(Token = "0x4000274")]
	protected SpecialCharacter m_Ellipsis; //Field offset: 0x19F8
	[FieldOffset(Offset = "0x1A18")]
	[Token(Token = "0x4000275")]
	protected SpecialCharacter m_Underline; //Field offset: 0x1A18
	[FieldOffset(Offset = "0x1A38")]
	[Token(Token = "0x4000276")]
	private TextElementInfo[] m_InternalTextElementInfo; //Field offset: 0x1A38

	[Token(Token = "0x17000058")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static bool IsExecutingJob
	{
		[Address(RVA = "0x1A58310", Offset = "0x1A57510", Length = "0x37")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CompilerGenerated]
		[Token(Token = "0x60001B3")]
		internal get { } //Length: 55
		[Address(RVA = "0x1A58380", Offset = "0x1A57580", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CompilerGenerated]
		[Token(Token = "0x60001B4")]
		internal set { } //Length: 60
	}

	[Token(Token = "0x17000059")]
	public bool isTextTruncated
	{
		[Address(RVA = "0x1A58360", Offset = "0x1A57560", Length = "0x7")]
		[CalledBy(Type = typeof(TextHandle), Member = "UpdateWithHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TextInfo))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x60001B6")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700005A")]
	private float m_BaselineOffset
	{
		[Address(RVA = "0x1A58370", Offset = "0x1A57570", Length = "0xB")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60001B7")]
		private get { } //Length: 11
		[Address(RVA = "0x1A583C0", Offset = "0x1A575C0", Length = "0x3E")]
		[CalledBy(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802898A0")]
		[Token(Token = "0x60001B8")]
		private set { } //Length: 62
	}

	[Token(Token = "0x1700005C")]
	private float m_LineHeight
	{
		[Address(RVA = "0x18CE830", Offset = "0x18CDA30", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001BB")]
		private get { } //Length: 9
		[Address(RVA = "0x1A58400", Offset = "0x1A57600", Length = "0x3E")]
		[CalledBy(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802898A0")]
		[Token(Token = "0x60001BC")]
		private set { } //Length: 62
	}

	[Token(Token = "0x1700005B")]
	private float m_LineOffset
	{
		[Address(RVA = "0x18CF230", Offset = "0x18CE430", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001B9")]
		private get { } //Length: 9
		[Address(RVA = "0x1A58440", Offset = "0x1A57640", Length = "0x3E")]
		[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802898A0")]
		[Token(Token = "0x60001BA")]
		private set { } //Length: 62
	}

	[Token(Token = "0x1700005D")]
	private float m_XAdvance
	{
		[Address(RVA = "0x406CD0", Offset = "0x405ED0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001BD")]
		private get { } //Length: 9
		[Address(RVA = "0x1A58480", Offset = "0x1A57680", Length = "0x88")]
		[CalledBy(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 25)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802898A0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[ContainsInvalidInstructions]
		[Token(Token = "0x60001BE")]
		private set { } //Length: 136
	}

	[Token(Token = "0x1700005E")]
	private bool NeedToRound
	{
		[Address(RVA = "0x1A58350", Offset = "0x1A57550", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001CD")]
		private get { } //Length: 8
	}

	[Address(RVA = "0x1A57910", Offset = "0x1A56B10", Length = "0xA00")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandle+<>c", Member = "<InitThreadArrays>b__4_1", ReturnType = typeof(TextGenerator))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandle+<>c", Member = "<get_generators>b__10_0", ReturnType = typeof(TextGenerator))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextBackingContainer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Offset), Member = "get_zero", ReturnType = typeof(Offset))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(UnityEngine.TextCore.Text.TextProcessingStack`1<UnityEngine.TextCore.Text.WordWrapState>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 17)]
	[Token(Token = "0x60001E0")]
	public TextGenerator() { }

	[Address(RVA = "0x1A3BB20", Offset = "0x1A3AD20", Length = "0x3AF2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GlyphValueRecord), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphValueRecord), typeof(GlyphValueRecord)}, ReturnType = typeof(GlyphValueRecord))]
	[Calls(Type = typeof(FontAsset), Member = "get_fontFeatureTable", ReturnType = typeof(FontFeatureTable))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGenerator), Member = "set_m_XAdvance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "get_boldStyleSpacing", ReturnType = typeof(float))]
	[Calls(Type = typeof(TextGenerator), Member = "RestoreWordWrappingState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WordWrapState&), typeof(TextInfo)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextGenerator), Member = "set_m_LineOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGenerator), Member = "SaveWordWrappingState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WordWrapState&), typeof(int), typeof(int), typeof(TextInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "Approximately", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "get_regularStyleSpacing", ReturnType = typeof(float))]
	[Calls(Type = typeof(FaceInfo), Member = "get_tabWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(FontAsset), Member = "get_tabMultiple", ReturnType = typeof(byte))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "IsHangul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "IsBaseGlyph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextSettings), Member = "get_lineBreakingRules", ReturnType = typeof(UnicodeLineBreakingRules))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "IsCJK", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnicodeLineBreakingRules), Member = "get_leadingCharactersLookup", ReturnType = typeof(System.Collections.Generic.HashSet`1<System.UInt32>))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.UInt32>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002400")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Debug), Member = "AssertFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180289280")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(GlyphPairAdjustmentRecord), Member = "get_firstAdjustmentRecord", ReturnType = typeof(GlyphAdjustmentRecord))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "get_characterLookupTable", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.Text.Character>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MaterialReference), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(FontAsset), typeof(SpriteAsset), typeof(Material), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(FontAsset), Member = "get_faceInfo", ReturnType = typeof(FaceInfo))]
	[Calls(Type = typeof(FontAsset), Member = "IsBitmap", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802898A0")]
	[Calls(Type = typeof(GlyphAdjustmentRecord), Member = "get_glyphValueRecord", ReturnType = typeof(GlyphValueRecord))]
	[Calls(Type = typeof(FaceInfo), Member = "get_ascentLine", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B0E70")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(char), Member = "IsLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "ToUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(SpriteAsset), Member = "get_faceInfo", ReturnType = typeof(FaceInfo))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GlyphPairAdjustmentRecord&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32Enum>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[CallsDeduplicatedMethods(Count = 92)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001D3")]
	protected override Vector2 CalculatePreferredValues(ref float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	[Address(RVA = "0x1A3F620", Offset = "0x1A3E820", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001C4")]
	private void ClearMarkupTagAttributes() { }

	[Address(RVA = "0x1A3F680", Offset = "0x1A3E880", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextInfo), Member = "ClearMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001CB")]
	private static void ClearMesh(bool updateMesh, TextInfo textInfo) { }

	[Address(RVA = "0x1A3F6B0", Offset = "0x1A3E8B0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001C2")]
	internal void CloseAllLinkTags(TextInfo textInfo) { }

	[Address(RVA = "0x1A3F720", Offset = "0x1A3E920", Length = "0x85")]
	[CalledBy(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001C1")]
	internal void CloseLastLinkTag(TextInfo textInfo) { }

	[Address(RVA = "0x1A3F7B0", Offset = "0x1A3E9B0", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001C3")]
	private void CloseLinkTag(TextInfo textInfo, int index) { }

	[Address(RVA = "0x1A3F820", Offset = "0x1A3EA20", Length = "0xFA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001DB")]
	private void ComputeMarginSize(Rect rect, Vector4 margins) { }

	[Address(RVA = "0x1A3F920", Offset = "0x1A3EB20", Length = "0x7D")]
	[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001DF")]
	protected void DoMissingGlyphCallback(uint unicode, int stringIndex, FontAsset fontAsset, TextInfo textInfo) { }

	[Address(RVA = "0x1A3F9A0", Offset = "0x1A3EBA0", Length = "0x598")]
	[CalledBy(Type = typeof(TextGenerator), Member = "LayoutPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextGenerator), Member = "GetUnderlineSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MeshInfo), Member = "ResizeMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "get_atlasWidth", ReturnType = typeof(int))]
	[Calls(Type = typeof(FontAsset), Member = "get_atlasHeight", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x60001CA")]
	private void DrawTextHighlight(Vector3 start, Vector3 end, Color32 highlightColor, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	[Address(RVA = "0x1A3FF40", Offset = "0x1A3F140", Length = "0xC2B")]
	[CalledBy(Type = typeof(TextGenerator), Member = "LayoutPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextGenerator), Member = "GetUnderlineSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MeshInfo), Member = "ResizeMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "get_faceInfo", ReturnType = typeof(FaceInfo))]
	[Calls(Type = typeof(FontAsset), Member = "get_atlasWidth", ReturnType = typeof(int))]
	[Calls(Type = typeof(FontAsset), Member = "get_atlasHeight", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 15)]
	[Token(Token = "0x60001C9")]
	private void DrawUnderlineMesh(Vector3 start, Vector3 end, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	[Address(RVA = "0x1A411E0", Offset = "0x1A403E0", Length = "0x187")]
	[CalledBy(Type = typeof(TextHandle), Member = "UpdateWithHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TextInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGenerator), Member = "Prepare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "UpdateFontAssetsInUpdateQueue", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGenerator), Member = "GenerateTextMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001B5")]
	public void GenerateText(TextGenerationSettings settings, TextInfo textInfo) { }

	[Address(RVA = "0x1A40B70", Offset = "0x1A3FD70", Length = "0x662")]
	[CalledBy(Type = typeof(TextGenerator), Member = "GenerateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextInfo), Member = "ClearMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshInfo), Member = "ClearUnusedVertices", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGenerator), Member = "LayoutPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "AssertFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextInfo), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802898A0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001BF")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal void GenerateTextMesh(TextGenerationSettings generationSettings, TextInfo textInfo) { }

	[Address(RVA = "0x1A58310", Offset = "0x1A57510", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CompilerGenerated]
	[Token(Token = "0x60001B3")]
	internal static bool get_IsExecutingJob() { }

	[Address(RVA = "0x1A58360", Offset = "0x1A57560", Length = "0x7")]
	[CalledBy(Type = typeof(TextHandle), Member = "UpdateWithHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TextInfo))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x60001B6")]
	public bool get_isTextTruncated() { }

	[Address(RVA = "0x1A58370", Offset = "0x1A57570", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60001B7")]
	private float get_m_BaselineOffset() { }

	[Address(RVA = "0x18CE830", Offset = "0x18CDA30", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001BB")]
	private float get_m_LineHeight() { }

	[Address(RVA = "0x18CF230", Offset = "0x18CE430", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001B9")]
	private float get_m_LineOffset() { }

	[Address(RVA = "0x406CD0", Offset = "0x405ED0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001BD")]
	private float get_m_XAdvance() { }

	[Address(RVA = "0x1A58350", Offset = "0x1A57550", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001CD")]
	private bool get_NeedToRound() { }

	[Address(RVA = "0x1A41370", Offset = "0x1A40570", Length = "0x34D")]
	[CalledBy(Type = typeof(TextGenerator), Member = "Prepare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "PrepareFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextProcessingElement[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextGenerator), Member = "GetSpecialCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextSettings), Member = "get_fallbackOSFontAssets", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset>))]
	[Calls(Type = typeof(FontAsset), Member = "IsRaster", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAssetUtilities), Member = "GetCharacterFromFontAssetsInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontAsset), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset>), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset>), typeof(bool), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(Character))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32Enum>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(SpecialCharacter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Character), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAssetUtilities), Member = "GetCharacterFromFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontAsset), typeof(bool), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(Character))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60001DD")]
	protected bool GetEllipsisSpecialCharacter(TextGenerationSettings generationSettings) { }

	[Address(RVA = "0x1A41820", Offset = "0x1A40A20", Length = "0x251")]
	[CalledBy(Type = typeof(TextHandle), Member = "UpdatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "get_characterLookupTable", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.Text.Character>))]
	[Calls(Type = typeof(TextGenerator), Member = "Prepare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001D1")]
	public Vector2 GetPreferredValues(TextGenerationSettings settings, TextInfo textInfo) { }

	[Address(RVA = "0x1A416C0", Offset = "0x1A408C0", Length = "0x156")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001D2")]
	private Vector2 GetPreferredValuesInternal(TextGenerationSettings generationSettings, TextInfo textInfo) { }

	[Address(RVA = "0x1A41A80", Offset = "0x1A40C80", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextGenerator), Member = "GetEllipsisSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGenerator), Member = "GetUnderlineSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60001DC")]
	protected bool GetSpecialCharacters(TextGenerationSettings generationSettings) { }

	[Address(RVA = "0x1A41AE0", Offset = "0x1A40CE0", Length = "0x53A")]
	[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextProcessingElement[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextSettings), Member = "get_fallbackOSFontAssets", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset>))]
	[Calls(Type = typeof(FontAsset), Member = "IsRaster", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(FontAsset), Member = "AddCharacterToLookupCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Character), typeof(FontStyles), typeof(TextFontWeight)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAssetUtilities), Member = "GetCharacterFromFontAssetsInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontAsset), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset>), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset>), typeof(bool), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(Character))]
	[Calls(Type = typeof(FontAssetUtilities), Member = "GetSpriteCharacterFromSpriteAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(SpriteAsset), typeof(bool)}, ReturnType = typeof(SpriteCharacter))]
	[Calls(Type = typeof(FontAsset), Member = "get_atlasPopulationMode", ReturnType = typeof(AtlasPopulationMode))]
	[Calls(Type = typeof(FontAssetUtilities), Member = "GetCharacterFromFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontAsset), typeof(bool), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(Character))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001D7")]
	private TextElement GetTextElement(TextGenerationSettings generationSettings, uint unicode, FontAsset fontAsset, FontStyles fontStyle, TextFontWeight fontWeight, out bool isUsingAlternativeTypeface, bool populateLigatures) { }

	[Address(RVA = "0x1A42020", Offset = "0x1A41220", Length = "0x300")]
	[CalledBy(Type = typeof(TextGenerator), Member = "DrawUnderlineMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "DrawTextHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "Prepare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "PrepareFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextGenerator), Member = "GetSpecialCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MaterialManager), Member = "GetFallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Material)}, ReturnType = typeof(Material))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SpecialCharacter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Character), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32Enum>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(MaterialReference), Member = "AddMaterialReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(FontAsset), typeof(MaterialReference[]&), typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(FontAssetUtilities), Member = "GetCharacterFromFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontAsset), typeof(bool), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(Character))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x60001DE")]
	protected bool GetUnderlineSpecialCharacter(TextGenerationSettings generationSettings) { }

	[Address(RVA = "0x1A42330", Offset = "0x1A41530", Length = "0x93D")]
	[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802898A0")]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "AdjustLineOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(float), typeof(TextInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "get_regularStyleSpacing", ReturnType = typeof(float))]
	[Calls(Type = typeof(TextGenerator), Member = "SaveWordWrappingState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WordWrapState&), typeof(int), typeof(int), typeof(TextInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "ResizeLineExtents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001D0")]
	private void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	[Address(RVA = "0x1A42C70", Offset = "0x1A41E70", Length = "0x363E")]
	[CalledBy(Type = typeof(TextGenerator), Member = "GenerateTextMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "FillSpriteVertexBuffers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGenerator), Member = "DrawTextHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "Approximately", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FaceInfo), Member = "get_strikethroughOffset", ReturnType = typeof(float))]
	[Calls(Type = typeof(ColorUtilities), Member = "CompareColors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32), typeof(Color32)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "get_faceInfo", ReturnType = typeof(FaceInfo))]
	[Calls(Type = typeof(TextGenerator), Member = "DrawUnderlineMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(char), Member = "IsPunctuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "IsLetterOrDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B0EA0")]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "FillCharacterVertexBuffers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802898A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B0F40")]
	[Calls(Type = typeof(char), Member = "IsSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "IsControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B0E70")]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Offset), Member = "get_zero", ReturnType = typeof(Offset))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(MeshInfo), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(HighlightState), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HighlightState), typeof(HighlightState)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 20)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001CC")]
	public void LayoutPhase(TextInfo textInfo, TextGenerationSettings generationSettings, float maxVisibleDescender) { }

	[Address(RVA = "0x1A462B0", Offset = "0x1A454B0", Length = "0x5848")]
	[CalledBy(Type = typeof(TextGenerator), Member = "GenerateTextMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GlyphPairAdjustmentRecord), Member = "get_firstAdjustmentRecord", ReturnType = typeof(GlyphAdjustmentRecord))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B0EA0")]
	[Calls(Type = typeof(char), Member = "IsSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGenerator), Member = "RestoreWordWrappingState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WordWrapState&), typeof(TextInfo)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint3x4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Matrix4x4), Member = "Rotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D8530")]
	[Calls(Type = typeof(FontAsset), Member = "get_boldStyleWeight", ReturnType = typeof(float))]
	[Calls(Type = typeof(UnityEngine.TextCore.Text.TextProcessingStack`1<UnityEngine.TextCore.Text.WordWrapState>), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(FontAsset), Member = "get_atlasRenderMode", ReturnType = typeof(GlyphRenderMode))]
	[Calls(Type = typeof(TextGenerator), Member = "set_m_XAdvance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "get_fontFeatureTable", ReturnType = typeof(FontFeatureTable))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "IsBaseGlyph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "get_boldStyleSpacing", ReturnType = typeof(float))]
	[Calls(Type = typeof(UnityEngine.TextCore.Text.TextProcessingStack`1<UnityEngine.TextCore.Text.WordWrapState>), Member = "Pop", ReturnType = typeof(WordWrapState))]
	[Calls(Type = typeof(TextGenerator), Member = "SaveSpriteVertexInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GlyphValueRecord), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphValueRecord), typeof(GlyphValueRecord)}, ReturnType = typeof(GlyphValueRecord))]
	[Calls(Type = typeof(UnicodeLineBreakingRules), Member = "get_followingCharactersLookup", ReturnType = typeof(System.Collections.Generic.HashSet`1<System.UInt32>))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.UInt32>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnicodeLineBreakingRules), Member = "get_leadingCharactersLookup", ReturnType = typeof(System.Collections.Generic.HashSet`1<System.UInt32>))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "IsCJK", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextSettings), Member = "get_lineBreakingRules", ReturnType = typeof(UnicodeLineBreakingRules))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "IsHangul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGenerator), Member = "InsertNewLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Boolean&), typeof(Single&), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGenerator), Member = "set_m_LineOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180289280")]
	[Calls(Type = typeof(FontAsset), Member = "get_tabMultiple", ReturnType = typeof(byte))]
	[Calls(Type = typeof(FaceInfo), Member = "get_tabWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(FontAsset), Member = "get_regularStyleSpacing", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800FFB40")]
	[Calls(Type = typeof(TextGenerator), Member = "SaveGlyphVertexInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "AdjustLineOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(float), typeof(TextInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GlyphAdjustmentRecord), Member = "get_glyphValueRecord", ReturnType = typeof(GlyphValueRecord))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GlyphPairAdjustmentRecord&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "ResizeLineExtents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MaterialReference), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(FontAsset), typeof(SpriteAsset), typeof(Material), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "IsBitmap", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802898A0")]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Offset), Member = "get_zero", ReturnType = typeof(Offset))]
	[Calls(Type = typeof(FontAsset), Member = "get_italicStyleSlant", ReturnType = typeof(byte))]
	[Calls(Type = typeof(FontAsset), Member = "get_faceInfo", ReturnType = typeof(FaceInfo))]
	[Calls(Type = typeof(FaceInfo), Member = "get_ascentLine", ReturnType = typeof(float))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32Enum>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextInfo), Member = "ClearLineInfo", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGenerator), Member = "SaveWordWrappingState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WordWrapState&), typeof(int), typeof(int), typeof(TextInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002140")]
	[Calls(Type = typeof(char), Member = "ToUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "IsLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(FontAsset), Member = "get_characterLookupTable", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.Text.Character>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B0E70")]
	[Calls(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(uint), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(UnityEngine.TextCore.Text.TextProcessingStack`1<UnityEngine.TextCore.Text.WordWrapState>), Member = "Clear", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 128)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001CF")]
	public void ParsingPhase(TextInfo textInfo, TextGenerationSettings generationSettings, out uint charCode, out float maxVisibleDescender) { }

	[Address(RVA = "0x1A4BB50", Offset = "0x1A4AD50", Length = "0x14DB")]
	[CalledBy(Type = typeof(TextGenerator), Member = "PrepareFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSettings), Member = "get_fallbackOSFontAssets", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "TryGetGlyphVariantIndexInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "GetGlyphVariantIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(FontAsset), Member = "TryAddGlyphVariantIndexInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "TryAddGlyphInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(FontAsset), Member = "GetGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Boolean&)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Glyph), Member = "get_atlasIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(MaterialManager), Member = "GetFallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset), typeof(Material), typeof(int)}, ReturnType = typeof(Material))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "get_fontFeatureTable", ReturnType = typeof(FontFeatureTable))]
	[Calls(Type = typeof(FontAssetUtilities), Member = "GetCharacterFromFontAssetsInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontAsset), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset>), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset>), typeof(bool), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(Character))]
	[Calls(Type = typeof(FontAssetUtilities), Member = "GetCharacterFromFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontAsset), typeof(bool), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(Character))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32Enum>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MaterialReference), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(FontAsset), typeof(SpriteAsset), typeof(Material), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialReference), Member = "AddMaterialReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(FontAsset), typeof(MaterialReference[]&), typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextGenerator), Member = "GetEllipsisSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MaterialManager), Member = "GetFallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Material)}, ReturnType = typeof(Material))]
	[Calls(Type = typeof(FontAsset), Member = "IsRaster", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(char), Member = "IsLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "ToUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "IsEmojiPresentationForm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "IsEmoji", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAssetUtilities), Member = "GetTextElementFromTextAssets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontAsset), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.TextAsset>), typeof(bool), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(TextElement))]
	[Calls(Type = typeof(TextGenerator), Member = "GetTextElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(uint), typeof(FontAsset), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(TextElement))]
	[Calls(Type = typeof(MaterialReference), Member = "AddMaterialReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(SpriteAsset), typeof(MaterialReference[]&), typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001DA")]
	private bool PopulateFontAsset(TextGenerationSettings generationSettings, TextProcessingElement[] textProcessingArray) { }

	[Address(RVA = "0x1A4D030", Offset = "0x1A4C230", Length = "0xFE")]
	[CalledBy(Type = typeof(TextGenerator), Member = "Prepare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "PrepareFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderedText), Member = "get_CharacterCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextBackingContainer), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderedText), Member = "GetEnumerator", ReturnType = typeof(Enumerator))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextBackingContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60001D8")]
	private void PopulateTextBackingArray(in RenderedText sourceText) { }

	[Address(RVA = "0x1A4D130", Offset = "0x1A4C330", Length = "0xDC8")]
	[CalledBy(Type = typeof(TextGenerator), Member = "Prepare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "PrepareFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "ResizeInternalArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "GetUTF16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextBackingContainer), typeof(int)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "IsValidUTF16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextBackingContainer), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "GetUTF32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextBackingContainer), typeof(int)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "IsValidUTF32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextBackingContainer), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "InsertOpeningTextStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextStyle), typeof(TextProcessingElement[]&), typeof(Int32&), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "InsertClosingStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "InsertClosingTextStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextStyle), typeof(TextProcessingElement[]&), typeof(Int32&), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "ReplaceClosingStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "GetMarkupTagHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextBackingContainer), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "ConvertToUTF32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "InsertOpeningStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextStyle), typeof(TextProcessingElement[]&), typeof(Int32&), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(int)}, ReturnType = typeof(TextStyle))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "ResizeInternalArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "ReplaceOpeningStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextBackingContainer&), typeof(int), typeof(Int32&), typeof(TextProcessingElement[]&), typeof(Int32&), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001D9")]
	private void PopulateTextProcessingArray(TextGenerationSettings generationSettings) { }

	[Address(RVA = "0x1A4E010", Offset = "0x1A4D210", Length = "0x286")]
	[CalledBy(Type = typeof(TextGenerator), Member = "GenerateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "GetPreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(FontAsset), Member = "IsBitmap", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGenerator), Member = "GetEllipsisSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGenerator), Member = "GetUnderlineSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextGenerator), Member = "PopulateTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGenerator), Member = "PopulateTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001D4")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal void Prepare(TextGenerationSettings generationSettings, TextInfo textInfo) { }

	[Address(RVA = "0x1A4DF20", Offset = "0x1A4D120", Length = "0xE2")]
	[CalledBy(Type = typeof(TextHandle), Member = "PrepareFontAsset", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TextGenerator), Member = "GetEllipsisSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGenerator), Member = "GetUnderlineSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGenerator), Member = "PopulateTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGenerator), Member = "PopulateTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGenerator), Member = "PopulateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextProcessingElement[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001D5")]
	internal bool PrepareFontAsset(TextGenerationSettings generationSettings) { }

	[Address(RVA = "0x1A4E2A0", Offset = "0x1A4D4A0", Length = "0x5D3")]
	[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802898A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001C6")]
	private int RestoreWordWrappingState(ref WordWrapState state, TextInfo textInfo) { }

	[Address(RVA = "0x1A4E880", Offset = "0x1A4DA80", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802898A0")]
	[Token(Token = "0x60001CE")]
	private float Round(float v) { }

	[Address(RVA = "0x1A4E8A0", Offset = "0x1A4DAA0", Length = "0xD38")]
	[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "MinAlpha", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(FontAsset), Member = "get_atlasWidth", ReturnType = typeof(int))]
	[Calls(Type = typeof(FontAsset), Member = "get_atlasHeight", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Token(Token = "0x60001C7")]
	private void SaveGlyphVertexInfo(float padding, float stylePadding, Color32 vertexColor, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	[Address(RVA = "0x1A4F5E0", Offset = "0x1A4E7E0", Length = "0x799")]
	[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ColorUtilities), Member = "MultiplyColors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32), typeof(Color32)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 18)]
	[Token(Token = "0x60001C8")]
	private void SaveSpriteVertexInfo(Color32 vertexColor, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	[Address(RVA = "0x1A4FD80", Offset = "0x1A4EF80", Length = "0x589")]
	[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "InsertNewLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Boolean&), typeof(Single&), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001C5")]
	private void SaveWordWrappingState(ref WordWrapState state, int index, int count, TextInfo textInfo) { }

	[Address(RVA = "0x1A58380", Offset = "0x1A57580", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CompilerGenerated]
	[Token(Token = "0x60001B4")]
	internal static void set_IsExecutingJob(bool value) { }

	[Address(RVA = "0x1A583C0", Offset = "0x1A575C0", Length = "0x3E")]
	[CalledBy(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802898A0")]
	[Token(Token = "0x60001B8")]
	private void set_m_BaselineOffset(float value) { }

	[Address(RVA = "0x1A58400", Offset = "0x1A57600", Length = "0x3E")]
	[CalledBy(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802898A0")]
	[Token(Token = "0x60001BC")]
	private void set_m_LineHeight(float value) { }

	[Address(RVA = "0x1A58440", Offset = "0x1A57640", Length = "0x3E")]
	[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802898A0")]
	[Token(Token = "0x60001BA")]
	private void set_m_LineOffset(float value) { }

	[Address(RVA = "0x1A58480", Offset = "0x1A57680", Length = "0x88")]
	[CalledBy(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802898A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60001BE")]
	private void set_m_XAdvance(float value) { }

	[Address(RVA = "0x1A50310", Offset = "0x1A4F510", Length = "0x1F32")]
	[CalledBy(Type = typeof(TextGenerator), Member = "Prepare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextGenerator), Member = "DoMissingGlyphCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(int), typeof(FontAsset), typeof(TextInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextSettings), Member = "get_fallbackOSFontAssets", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset>))]
	[Calls(Type = typeof(FontAssetUtilities), Member = "GetCharacterFromFontAssetsInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontAsset), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset>), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset>), typeof(bool), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(Character))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JobsUtility), Member = "get_IsExecutingJob", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FontAsset), Member = "TryGetGlyphVariantIndexInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "GetGlyphVariantIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(FontAsset), Member = "TryAddGlyphVariantIndexInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "TryAddGlyphInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "get_fontFeatureTable", ReturnType = typeof(FontFeatureTable))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(FontAsset), Member = "IsRaster", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "GetGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Boolean&)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Glyph), Member = "get_atlasIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(MaterialManager), Member = "GetFallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset), typeof(Material), typeof(int)}, ReturnType = typeof(Material))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialReference), Member = "AddMaterialReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(SpriteAsset), typeof(MaterialReference[]&), typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(MeshInfo), Member = "ResizeMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAssetUtilities), Member = "GetCharacterFromFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontAsset), typeof(bool), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(Character))]
	[Calls(Type = typeof(FontAssetUtilities), Member = "GetTextElementFromTextAssets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontAsset), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.TextAsset>), typeof(bool), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(TextElement))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MaterialReference), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(FontAsset), typeof(SpriteAsset), typeof(Material), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialReference), Member = "AddMaterialReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(FontAsset), typeof(MaterialReference[]&), typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TextInfo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGenerator), Member = "GetEllipsisSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(TextGenerator), Member = "GetTextElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(uint), typeof(FontAsset), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(TextElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(MaterialManager), Member = "GetFallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Material)}, ReturnType = typeof(Material))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32Enum>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SpriteAsset), Member = "get_spriteCharacterTable", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.SpriteCharacter>))]
	[Calls(Type = typeof(char), Member = "IsLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "ToUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "IsEmojiPresentationForm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "IsEmoji", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "get_atlasRenderMode", ReturnType = typeof(GlyphRenderMode))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 25)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001D6")]
	private int SetArraySizes(TextProcessingElement[] textProcessingArray, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	[Address(RVA = "0x1A52250", Offset = "0x1A51450", Length = "0x56B0")]
	[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextProcessingElement[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.TextCore.Text.TextProcessingStack`1<UnityEngine.TextCore.Text.HighlightState>), Member = "Remove", ReturnType = typeof(HighlightState))]
	[Calls(Type = typeof(UnityEngine.TextCore.Text.TextProcessingStack`1<System.Single>), Member = "Pop", ReturnType = typeof(float))]
	[Calls(Type = typeof(UnityEngine.TextCore.Text.TextProcessingStack`1<UnityEngine.TextCore.Text.MaterialReference>), Member = "Pop", ReturnType = typeof(MaterialReference))]
	[Calls(Type = typeof(UnityEngine.TextCore.Text.TextProcessingStack`1<System.Single>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "get_faceInfo", ReturnType = typeof(FaceInfo))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "HexCharsToColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "AddFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "TryGetFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(FontAsset&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "get_italicStyleSlant", ReturnType = typeof(byte))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "GetAttributeParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(Single[]&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800FFAC0")]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "TryGetSpriteAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(SpriteAsset&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181A3BAE0")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Offset), Member = "get_zero", ReturnType = typeof(Offset))]
	[Calls(Type = typeof(SpriteAsset), Member = "get_spriteCharacterTable", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.SpriteCharacter>))]
	[Calls(Type = typeof(SpriteAsset), Member = "SearchForSpriteByHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteAsset), typeof(int), typeof(bool), typeof(Int32&), typeof(TextSettings)}, ReturnType = typeof(SpriteAsset))]
	[Calls(Type = typeof(MaterialReference), Member = "AddMaterialReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(SpriteAsset), typeof(MaterialReference[]&), typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B0E70")]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "AddSpriteAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(SpriteAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkInfo), Member = "SetLinkId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.TextCore.Text.TextProcessingStack`1<UnityEngine.TextCore.Text.MaterialReference>), Member = "Remove", ReturnType = typeof(MaterialReference))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "ToUpperFast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "ConvertToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(TextGenerator), Member = "set_m_BaselineOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "TryGetMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Material&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TextGenerator), Member = "CloseLastLinkTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "AddFontMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MaterialReference), Member = "AddMaterialReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(FontAsset), typeof(MaterialReference[]&), typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F8390")]
	[Calls(Type = typeof(TextGenerator), Member = "set_m_LineHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGenerator), Member = "set_m_XAdvance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801CCAF0")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "TryGetColorGradientPreset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextColorGradient&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MaterialReferenceManager), Member = "AddColorGradientPreset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextColorGradient)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 87)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001C0")]
	private bool ValidateHtmlTag(TextProcessingElement[] chars, int startIndex, out int endIndex, TextGenerationSettings generationSettings, TextInfo textInfo, out bool isThreadSuccess) { }

}

