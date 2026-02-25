namespace UnityEngine.UIElements;

[Token(Token = "0x2000476")]
internal class UITKTextHandle : TextHandle
{
	[Token(Token = "0x4000ED9")]
	private static TextLib s_TextLib; //Field offset: 0x0
	[Token(Token = "0x4000EE1")]
	internal static readonly float k_MinPadding; //Field offset: 0x8
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000ED6")]
	internal ATGTextEventHandler m_ATGTextEventHandler; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000ED7")]
	private List<ValueTuple`3<Int32, TagType, String>> m_Links; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000ED8")]
	internal Color atgHyperlinkColor; //Field offset: 0xC8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000EDA")]
	private float <LastPixelPerPoint>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xDC")]
	[Token(Token = "0x4000EDB")]
	private Nullable<Single> <MeasuredWidth>k__BackingField; //Field offset: 0xDC
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xE4")]
	[Token(Token = "0x4000EDC")]
	private float <RoundedWidth>k__BackingField; //Field offset: 0xE4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000EDD")]
	private Vector2 <ATGMeasuredSizes>k__BackingField; //Field offset: 0xE8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000EDE")]
	private Vector2 <ATGRoundedSizes>k__BackingField; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000EDF")]
	internal TextEventHandler m_TextEventHandler; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000EE0")]
	protected TextElement m_TextElement; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000EE2")]
	private bool wasAdvancedTextEnabledForElement; //Field offset: 0x108

	[Token(Token = "0x170008DD")]
	internal Vector2 ATGMeasuredSizes
	{
		[Address(RVA = "0x1B39D40", Offset = "0x1B38F40", Length = "0x19")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6002161")]
		internal get { } //Length: 25
		[Address(RVA = "0x1B3A0B0", Offset = "0x1B392B0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6002162")]
		internal set { } //Length: 8
	}

	[Token(Token = "0x170008DE")]
	internal Vector2 ATGRoundedSizes
	{
		[Address(RVA = "0x1B39D60", Offset = "0x1B38F60", Length = "0x19")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6002163")]
		internal get { } //Length: 25
		[Address(RVA = "0x1B3A0C0", Offset = "0x1B392C0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6002164")]
		internal set { } //Length: 8
	}

	[Token(Token = "0x170008DF")]
	public virtual bool IsPlaceholder
	{
		[Address(RVA = "0x1B39D80", Offset = "0x1B38F80", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextElement), Member = "get_showPlaceholderText", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002172")]
		 get { } //Length: 62
	}

	[Token(Token = "0x170008DA")]
	internal float LastPixelPerPoint
	{
		[Address(RVA = "0x1B39DC0", Offset = "0x1B38FC0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600215A")]
		internal get { } //Length: 9
		[Address(RVA = "0x1B3A0D0", Offset = "0x1B392D0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600215B")]
		internal set { } //Length: 9
	}

	[Token(Token = "0x170008D8")]
	private List<ValueTuple`3<Int32, TagType, String>> Links
	{
		[Address(RVA = "0x1B39DD0", Offset = "0x1B38FD0", Length = "0x84")]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ComputeNativeTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&), typeof(float), typeof(float), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "UpdateNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(System.ValueTuple`2<UnityEngine.TextCore.Text.NativeTextInfo, System.Boolean>))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "hasLinkAndHyperlink", ReturnType = typeof(System.ValueTuple`2<System.Boolean, System.Boolean>))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600214B")]
		private get { } //Length: 132
	}

	[Token(Token = "0x170008DB")]
	internal Nullable<Single> MeasuredWidth
	{
		[Address(RVA = "0x1B39E60", Offset = "0x1B39060", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600215D")]
		internal get { } //Length: 8
		[Address(RVA = "0x1B3A0E0", Offset = "0x1B392E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600215E")]
		internal set { } //Length: 8
	}

	[Token(Token = "0x170008DC")]
	internal float RoundedWidth
	{
		[Address(RVA = "0x1B39E70", Offset = "0x1B39070", Length = "0x9")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600215F")]
		internal get { } //Length: 9
		[Address(RVA = "0x1B3A0F0", Offset = "0x1B392F0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6002160")]
		internal set { } //Length: 9
	}

	[Token(Token = "0x170008D9")]
	protected private TextLib textLib
	{
		[Address(RVA = "0x1B39E80", Offset = "0x1B39080", Length = "0x5E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UITKTextHandle), Member = "InitTextLib", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6002156")]
		private get { } //Length: 94
	}

	[Address(RVA = "0x1B39C30", Offset = "0x1B38E30", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6002174")]
	private static UITKTextHandle() { }

	[Address(RVA = "0x1B39C70", Offset = "0x1B38E70", Length = "0xC3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TextEventHandler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002158")]
	public UITKTextHandle(TextElement te) { }

	[Address(RVA = "0x1B37690", Offset = "0x1B36890", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "AddToPermanentCacheAndGenerateMesh", ReturnType = typeof(void))]
	[Calls(Type = typeof(UITKTextHandle), Member = "CacheTextGenerationInfo", ReturnType = typeof(void))]
	[Calls(Type = typeof(UITKTextHandle), Member = "UpdateNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(System.ValueTuple`2<UnityEngine.TextCore.Text.NativeTextInfo, System.Boolean>))]
	[Calls(Type = typeof(UITKTextHandle), Member = "UpdateATGTextEventHandler", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600216B")]
	public virtual void AddToPermanentCacheAndGenerateMesh() { }

	[Address(RVA = "0x1B374F0", Offset = "0x1B366F0", Length = "0x196")]
	[CalledBy(Type = typeof(ATGTextEventHandler), Member = "HyperlinkOnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerUpEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ATGTextEventHandler), Member = "HyperlinkOnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ATGTextEventHandler), Member = "LinkTagOnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerDownEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ATGTextEventHandler), Member = "LinkTagOnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerUpEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ATGTextEventHandler), Member = "LinkTagOnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextLib", Member = "FindIntersectingLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(IntPtr)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002151")]
	internal ValueTuple<TagType, String> ATGFindIntersectingLink(Vector2 point) { }

	[Address(RVA = "0x1B37710", Offset = "0x1B36910", Length = "0x8B")]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "AddToPermanentCacheAndGenerateMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.ATGTextJobSystem+GenerateTextJobData", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextGenerationInfo", Member = "Create", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600214E")]
	public void CacheTextGenerationInfo() { }

	[Address(RVA = "0x1B377A0", Offset = "0x1B369A0", Length = "0x257")]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ComputeTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&), typeof(float), typeof(float), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.TextCore.Text.RenderedText", Member = "CreateString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UITKTextHandle), Member = "get_Links", ReturnType = typeof(System.Collections.Generic.List`1<System.ValueTuple`3<System.Int32, UnityEngine.TextCore.RichTextTagParser+TagType, System.String>>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "UnityEngine.TextCore.RichTextTagParser", Member = "CreateTextGenerationSettingsArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeTextGenerationSettings&), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<System.Int32, UnityEngine.TextCore.RichTextTagParser+TagType, System.String>>), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UITKTextHandle), Member = "InitTextLib", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextLib", Member = "MeasureText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.NativeTextGenerationSettings", typeof(IntPtr)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600214C")]
	private void ComputeNativeTextSize(in RenderedText textToMeasure, float width, float height, Nullable<Single> fontsize = null) { }

	[Address(RVA = "0x1B37A00", Offset = "0x1B36C00", Length = "0x138")]
	[CalledBy(Type = typeof(KeyboardTextEditorEventHandler), Member = "UpdateLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchScreenTextEditorEventHandler), Member = "DoPollTouchScreenKeyboard", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "RemoveTextInfoFromTemporaryCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(UITKTextHandle), Member = "UpdateNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(System.ValueTuple`2<UnityEngine.TextCore.Text.NativeTextInfo, System.Boolean>))]
	[Calls(Type = typeof(TextEventHandler), Member = "HandleLinkAndATagCallbacks", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEventHandler), Member = "HandleLinkTag", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEventHandler), Member = "HandleATag", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "UpdateWithHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "AddTextInfoToTemporaryCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UITKTextHandle), Member = "UpdateATGTextEventHandler", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_settings", ReturnType = "UnityEngine.TextCore.Text.TextGenerationSettings")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002166")]
	public void ComputeSettingsAndUpdate() { }

	[Address(RVA = "0x1B37B40", Offset = "0x1B36D40", Length = "0x18C")]
	[CalledBy(Type = typeof(TextUtilities), Member = "MeasureVisualElementTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement), typeof(RenderedText&), typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802898A0")]
	[Calls(Type = typeof(TextUtilities), Member = "IsAdvancedTextEnabledForElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_settings", ReturnType = "UnityEngine.TextCore.Text.TextGenerationSettings")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextGenerationSettings", Member = "set_renderedText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.RenderedText"}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "UpdatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UITKTextHandle), Member = "ComputeNativeTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&), typeof(float), typeof(float), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_preferredSize", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002165")]
	public Vector2 ComputeTextSize(in RenderedText textToMeasure, float width, float height, Nullable<Single> fontsize = null) { }

	[Address(RVA = "0x1B37CD0", Offset = "0x1B36ED0", Length = "0x61E")]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ComputeNativeTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&), typeof(float), typeof(float), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "UpdateNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(System.ValueTuple`2<UnityEngine.TextCore.Text.NativeTextInfo, System.Boolean>))]
	[CalledBy(Type = typeof(ATGTextJobSystem), Member = "GenerateTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ComputedStyle), Member = "get_textOverflow", ReturnType = typeof(TextOverflow))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextGeneratorUtilities", Member = "GetHorizontalAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAnchor)}, ReturnType = "UnityEngine.TextCore.HorizontalAlignment")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextGeneratorUtilities", Member = "GetVerticalAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAnchor)}, ReturnType = "UnityEngine.TextCore.VerticalAlignment")]
	[Calls(Type = typeof(ComputedStyle), Member = "get_letterSpacing", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_wordSpacing", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityParagraphSpacing", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_color", ReturnType = typeof(Color))]
	[Calls(Type = typeof(LanguageDirectionExtensions), Member = "toTextCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LanguageDirection)}, ReturnType = "UnityEngine.TextCore.LanguageDirection")]
	[Calls(Type = typeof(FontAsset), Member = "get_nativeFontAsset", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityTextAlign", ReturnType = typeof(TextAnchor))]
	[Calls(Type = typeof(UITKTextHandle), Member = "GetVertexPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityFontStyleAndWeight", ReturnType = typeof(FontStyle))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextGeneratorUtilities", Member = "LegacyStyleToNewStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontStyle)}, ReturnType = typeof(FontStyles))]
	[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(FontAsset), Member = "get_faceInfo", ReturnType = typeof(FaceInfo))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(TextUtilities), Member = "toTextCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextOverflow), typeof(OverflowInternal)}, ReturnType = "UnityEngine.TextCore.TextOverflow")]
	[Calls(Type = typeof(TextUtilities), Member = "toTextCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WhiteSpace), typeof(bool)}, ReturnType = "UnityEngine.TextCore.WhiteSpace")]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityTextOverflowPosition", ReturnType = typeof(TextOverflowPosition))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextUtilities), Member = "GetFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(FontAsset))]
	[Calls(Type = typeof(FontAsset), Member = "get_atlasPopulationMode", ReturnType = typeof(AtlasPopulationMode))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(TextUtilities), Member = "GetTextSettingsFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(TextSettings))]
	[Calls(Type = typeof(TextSettings), Member = "get_nativeTextSettings", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_overflow", ReturnType = typeof(OverflowInternal))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextElement), Member = "get_renderedText", ReturnType = "UnityEngine.TextCore.Text.RenderedText")]
	[Calls(Type = "UnityEngine.TextCore.Text.RenderedText", Member = "CreateString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ComputedStyle), Member = "get_fontSize", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityTextAutoSize", ReturnType = typeof(TextAutoSize))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_whiteSpace", ReturnType = typeof(WhiteSpace))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = "UnityEngine.TextCore.Text.RenderedText", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002153")]
	internal bool ConvertUssToNativeTextGenerationSettings(Nullable<Single> fontsize = null) { }

	[Address(RVA = "0x1B382F0", Offset = "0x1B374F0", Length = "0x88D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextElement), Member = "get_showPlaceholderText", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Math), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int), typeof(MidpointRounding)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityFontStyleAndWeight", ReturnType = typeof(FontStyle))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextGeneratorUtilities", Member = "LegacyStyleToNewStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontStyle)}, ReturnType = typeof(FontStyles))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityTextAlign", ReturnType = typeof(TextAnchor))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextGeneratorUtilities", Member = "LegacyAlignmentToNewAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAnchor)}, ReturnType = "UnityEngine.TextCore.Text.TextAlignment")]
	[Calls(Type = typeof(ComputedStyle), Member = "get_whiteSpace", ReturnType = typeof(WhiteSpace))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(TextUtilities), Member = "toTextWrappingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WhiteSpace), typeof(bool)}, ReturnType = "UnityEngine.TextCore.Text.TextWrappingMode")]
	[Calls(Type = typeof(ComputedStyle), Member = "get_textOverflow", ReturnType = typeof(TextOverflow))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_overflow", ReturnType = typeof(OverflowInternal))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_letterSpacing", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_wordSpacing", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityParagraphSpacing", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_color", ReturnType = typeof(Color))]
	[Calls(Type = typeof(VisualElement), Member = "get_playModeTintColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_fontSize", ReturnType = typeof(Length))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TextElement), Member = "get_renderedText", ReturnType = "UnityEngine.TextCore.Text.RenderedText")]
	[Calls(Type = typeof(System.Nullable`1<System.Single>), Member = "get_Value", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002400")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_settings", ReturnType = "UnityEngine.TextCore.Text.TextGenerationSettings")]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityTextAutoSize", ReturnType = typeof(TextAutoSize))]
	[Calls(Type = typeof(TextAutoSize), Member = "None", ReturnType = typeof(TextAutoSize))]
	[Calls(Type = typeof(TextAutoSize), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAutoSize), typeof(TextAutoSize)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextGenerationSettings", Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextUtilities), Member = "GetTextSettingsFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(TextSettings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextUtilities), Member = "GetFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(FontAsset))]
	[Calls(Type = typeof(UITKTextHandle), Member = "GetVertexPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityTextOverflowPosition", ReturnType = typeof(TextOverflowPosition))]
	[Calls(Type = "UnityEngine.TextCore.Text.RenderedText", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextGenerationSettings", Member = "set_renderedText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.RenderedText"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "IsBitmap", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600216D")]
	internal override bool ConvertUssToTextGenerationSettings(bool populateScreenRect, Nullable<Single> fontsize = null) { }

	[Address(RVA = "0x1B39D40", Offset = "0x1B38F40", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6002161")]
	internal Vector2 get_ATGMeasuredSizes() { }

	[Address(RVA = "0x1B39D60", Offset = "0x1B38F60", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6002163")]
	internal Vector2 get_ATGRoundedSizes() { }

	[Address(RVA = "0x1B39D80", Offset = "0x1B38F80", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextElement), Member = "get_showPlaceholderText", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002172")]
	public virtual bool get_IsPlaceholder() { }

	[Address(RVA = "0x1B39DC0", Offset = "0x1B38FC0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600215A")]
	internal float get_LastPixelPerPoint() { }

	[Address(RVA = "0x1B39DD0", Offset = "0x1B38FD0", Length = "0x84")]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ComputeNativeTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&), typeof(float), typeof(float), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "UpdateNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(System.ValueTuple`2<UnityEngine.TextCore.Text.NativeTextInfo, System.Boolean>))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "hasLinkAndHyperlink", ReturnType = typeof(System.ValueTuple`2<System.Boolean, System.Boolean>))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600214B")]
	private List<ValueTuple`3<Int32, TagType, String>> get_Links() { }

	[Address(RVA = "0x1B39E60", Offset = "0x1B39060", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600215D")]
	internal Nullable<Single> get_MeasuredWidth() { }

	[Address(RVA = "0x1B39E70", Offset = "0x1B39070", Length = "0x9")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600215F")]
	internal float get_RoundedWidth() { }

	[Address(RVA = "0x1B39E80", Offset = "0x1B39080", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UITKTextHandle), Member = "InitTextLib", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6002156")]
	protected private TextLib get_textLib() { }

	[Address(RVA = "0x1B38C40", Offset = "0x1B37E40", Length = "0x2E8")]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "InitTextLib", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Resources), Member = "FindObjectsOfTypeAll", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002154")]
	private TextAsset GetICUAsset() { }

	[Address(RVA = "0x1B38B80", Offset = "0x1B37D80", Length = "0xB9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Resources), Member = "FindObjectsOfTypeAll", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002155")]
	internal static TextAsset GetICUAssetStaticFalback() { }

	[Address(RVA = "0x1B38F30", Offset = "0x1B38130", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_scaledPixelsPerPoint", ReturnType = typeof(float))]
	[Token(Token = "0x6002159")]
	protected virtual float GetPixelsPerPoint() { }

	[Address(RVA = "0x1B38F60", Offset = "0x1B38160", Length = "0xE2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_textOverflow", ReturnType = typeof(TextOverflow))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityTextOverflowPosition", ReturnType = typeof(TextOverflowPosition))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_overflow", ReturnType = typeof(OverflowInternal))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600216C")]
	private TextOverflowMode GetTextOverflowMode() { }

	[Address(RVA = "0x1B39050", Offset = "0x1B38250", Length = "0x269")]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityTextOutlineWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_textShadow", ReturnType = typeof(TextShadow))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ComputedStyle), Member = "get_fontSize", ReturnType = typeof(Length))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "ConvertPixelUnitsToTextCoreRelativeUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(FontAsset)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600216F")]
	internal float GetVertexPadding(FontAsset fontAsset) { }

	[Address(RVA = "0x1B392C0", Offset = "0x1B384C0", Length = "0x14")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextJobSystem+GenerateTextJobData", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextEventHandler), Member = "HandleATag", ReturnType = typeof(void))]
	[Token(Token = "0x6002167")]
	public void HandleATag() { }

	[Address(RVA = "0x1B392E0", Offset = "0x1B384E0", Length = "0x14")]
	[CalledBy(Type = typeof(UITKTextJobSystem), Member = "AddDrawEntries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextEventHandler), Member = "HandleLinkAndATagCallbacks", ReturnType = typeof(void))]
	[Token(Token = "0x6002169")]
	public void HandleLinkAndATagCallbacks() { }

	[Address(RVA = "0x1B39300", Offset = "0x1B38500", Length = "0x14")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextJobSystem+GenerateTextJobData", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextEventHandler), Member = "HandleLinkTag", ReturnType = typeof(void))]
	[Token(Token = "0x6002168")]
	public void HandleLinkTag() { }

	[Address(RVA = "0x1B39EE0", Offset = "0x1B390E0", Length = "0x1C0")]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "UpdateATGTextEventHandler", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UITKTextHandle), Member = "get_Links", ReturnType = typeof(System.Collections.Generic.List`1<System.ValueTuple`3<System.Int32, UnityEngine.TextCore.RichTextTagParser+TagType, System.String>>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ValueTuple`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002150")]
	private ValueTuple<Boolean, Boolean> hasLinkAndHyperlink() { }

	[Address(RVA = "0x1B39320", Offset = "0x1B38520", Length = "0xEE")]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ComputeNativeTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&), typeof(float), typeof(float), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "UpdateNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(System.ValueTuple`2<UnityEngine.TextCore.Text.NativeTextInfo, System.Boolean>))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ProcessMeshInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.NativeTextInfo"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "get_textLib", ReturnType = "UnityEngine.TextCore.Text.TextLib")]
	[CalledBy(Type = typeof(ATGTextJobSystem), Member = "GenerateTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UITKTextHandle), Member = "GetICUAsset", ReturnType = typeof(TextAsset))]
	[Calls(Type = typeof(TextAsset), Member = "get_bytes", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextLib", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002157")]
	protected private void InitTextLib() { }

	[Address(RVA = "0x1B39410", Offset = "0x1B38610", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextUtilities), Member = "IsAdvancedTextEnabledForElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6002170")]
	internal virtual bool IsAdvancedTextEnabledForElement() { }

	[Address(RVA = "0x1B39420", Offset = "0x1B38620", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002173")]
	public bool IsElided() { }

	[Address(RVA = "0x1B39480", Offset = "0x1B38680", Length = "0xF0")]
	[CalledBy(Type = typeof(ATGTextJobSystem), Member = "AddDrawEntries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UITKTextHandle), Member = "InitTextLib", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextLib", Member = "ProcessMeshInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.NativeTextInfo", "UnityEngine.TextCore.NativeTextGenerationSettings"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600214F")]
	public void ProcessMeshInfos(NativeTextInfo textInfo) { }

	[Address(RVA = "0x1B39580", Offset = "0x1B38780", Length = "0x1FF")]
	[CalledBy(Type = typeof(TextElement), Member = "OnGenerateVisualContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ATGTextEventHandler), Member = "UnRegisterHyperlinkCallbacks", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextUtilities), Member = "IsAdvancedTextEnabledForElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextGenerationInfo", Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ATGTextEventHandler), Member = "UnRegisterLinkTagCallbacks", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TextEventHandler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandlePermanentCache", Member = "RemoveTextInfoFromCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextHandle"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEventHandler), Member = "OnDestroy", ReturnType = typeof(void))]
	[Calls(Type = typeof(ATGTextEventHandler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002171")]
	internal void ReleaseResourcesIfPossible() { }

	[Address(RVA = "0x1B3A0B0", Offset = "0x1B392B0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6002162")]
	internal void set_ATGMeasuredSizes(Vector2 value) { }

	[Address(RVA = "0x1B3A0C0", Offset = "0x1B392C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6002164")]
	internal void set_ATGRoundedSizes(Vector2 value) { }

	[Address(RVA = "0x1B3A0D0", Offset = "0x1B392D0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600215B")]
	internal void set_LastPixelPerPoint(float value) { }

	[Address(RVA = "0x1B3A0E0", Offset = "0x1B392E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600215E")]
	internal void set_MeasuredWidth(Nullable<Single> value) { }

	[Address(RVA = "0x1B3A0F0", Offset = "0x1B392F0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6002160")]
	internal void set_RoundedWidth(float value) { }

	[Address(RVA = "0x1B39780", Offset = "0x1B38980", Length = "0x12")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "SetDirty", ReturnType = typeof(void))]
	[Token(Token = "0x600215C")]
	public virtual void SetDirty() { }

	[Address(RVA = "0x1B397A0", Offset = "0x1B389A0", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityTextOverflowPosition", ReturnType = typeof(TextOverflowPosition))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600216E")]
	internal bool TextLibraryCanElide() { }

	[Address(RVA = "0x1B397E0", Offset = "0x1B389E0", Length = "0x7B")]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ComputeSettingsAndUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "AddToPermanentCacheAndGenerateMesh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ATGTextJobSystem), Member = "AddDrawEntries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UITKTextHandle), Member = "hasLinkAndHyperlink", ReturnType = typeof(System.ValueTuple`2<System.Boolean, System.Boolean>))]
	[Calls(Type = typeof(ATGTextEventHandler), Member = "UnRegisterLinkTagCallbacks", ReturnType = typeof(void))]
	[Calls(Type = typeof(ATGTextEventHandler), Member = "RegisterLinkTagCallbacks", ReturnType = typeof(void))]
	[Calls(Type = typeof(ATGTextEventHandler), Member = "UnRegisterHyperlinkCallbacks", ReturnType = typeof(void))]
	[Calls(Type = typeof(ATGTextEventHandler), Member = "RegisterHyperlinkCallbacks", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002152")]
	internal void UpdateATGTextEventHandler() { }

	[Address(RVA = "0x1B39860", Offset = "0x1B38A60", Length = "0xCF")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextJobSystem+GenerateTextJobData", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_settings", ReturnType = "UnityEngine.TextCore.Text.TextGenerationSettings")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "AddTextInfoToTemporaryCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "RemoveTextInfoFromTemporaryCache", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "UpdateWithHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600216A")]
	public void UpdateMesh() { }

	[Address(RVA = "0x1B39930", Offset = "0x1B38B30", Length = "0x2F7")]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ComputeSettingsAndUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "AddToPermanentCacheAndGenerateMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.ATGTextJobSystem+GenerateTextJobData", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UITKTextHandle), Member = "get_Links", ReturnType = typeof(System.Collections.Generic.List`1<System.ValueTuple`3<System.Int32, UnityEngine.TextCore.RichTextTagParser+TagType, System.String>>))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextLib", Member = "GenerateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.NativeTextGenerationSettings", typeof(IntPtr)}, ReturnType = "UnityEngine.TextCore.Text.NativeTextInfo")]
	[Calls(Type = typeof(UITKTextHandle), Member = "InitTextLib", ReturnType = typeof(void))]
	[Calls(Type = typeof(ATGTextEventHandler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextGenerationInfo", Member = "Create", ReturnType = typeof(IntPtr))]
	[Calls(Type = "UnityEngine.TextCore.NativeTextGenerationSettings", Member = "get_hasLink", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.ValueTuple`2<UnityEngine.TextCore.Text.NativeTextInfo, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.NativeTextInfo", typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.TextCore.RichTextTagParser", Member = "CreateTextGenerationSettingsArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeTextGenerationSettings&), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<System.Int32, UnityEngine.TextCore.RichTextTagParser+TagType, System.String>>), typeof(Color)}, ReturnType = typeof(void))]
	[Token(Token = "0x600214D")]
	public ValueTuple<NativeTextInfo, Boolean> UpdateNative(bool generateNativeSettings = true) { }

}

