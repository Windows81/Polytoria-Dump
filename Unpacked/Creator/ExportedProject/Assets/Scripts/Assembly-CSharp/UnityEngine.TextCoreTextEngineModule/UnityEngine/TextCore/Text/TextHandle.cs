namespace UnityEngine.TextCore.Text;

[DebuggerDisplay("{settings.text}")]
[Token(Token = "0x200005A")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
internal class TextHandle
{
	[CompilerGenerated]
	[Token(Token = "0x200005B")]
	private sealed class <>c
	{
		[Token(Token = "0x400035A")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400035B")]
		public static Func<TextGenerationSettings> <>9__4_0; //Field offset: 0x8
		[Token(Token = "0x400035C")]
		public static Func<TextGenerator> <>9__4_1; //Field offset: 0x10
		[Token(Token = "0x400035D")]
		public static Func<TextInfo> <>9__4_2; //Field offset: 0x18
		[Token(Token = "0x400035E")]
		public static Func<TextGenerationSettings> <>9__7_0; //Field offset: 0x20
		[Token(Token = "0x400035F")]
		public static Func<TextGenerator> <>9__10_0; //Field offset: 0x28
		[Token(Token = "0x4000360")]
		public static Func<TextInfo> <>9__13_0; //Field offset: 0x30

		[Address(RVA = "0x1A6D460", Offset = "0x1A6C660", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60002B2")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002B3")]
		public <>c() { }

		[Address(RVA = "0x1A6CE80", Offset = "0x1A6C080", Length = "0x44")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(TextGenerator), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60002B8")]
		internal TextGenerator <get_generators>b__10_0() { }

		[Address(RVA = "0x1A6CED0", Offset = "0x1A6C0D0", Length = "0xA0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60002B7")]
		internal TextGenerationSettings <get_settingsArray>b__7_0() { }

		[Address(RVA = "0x1A6CF70", Offset = "0x1A6C170", Length = "0x44")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(TextInfo), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60002B9")]
		internal TextInfo <get_textInfosCommon>b__13_0() { }

		[Address(RVA = "0x1A6CD40", Offset = "0x1A6BF40", Length = "0xA0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60002B4")]
		internal TextGenerationSettings <InitThreadArrays>b__4_0() { }

		[Address(RVA = "0x1A6CDE0", Offset = "0x1A6BFE0", Length = "0x44")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(TextGenerator), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60002B5")]
		internal TextGenerator <InitThreadArrays>b__4_1() { }

		[Address(RVA = "0x1A6CE30", Offset = "0x1A6C030", Length = "0x44")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(TextInfo), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60002B6")]
		internal TextInfo <InitThreadArrays>b__4_2() { }

	}

	[Token(Token = "0x4000349")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static TextHandleTemporaryCache s_TemporaryCache; //Field offset: 0x0
	[Token(Token = "0x400034A")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static TextHandlePermanentCache s_PermanentCache; //Field offset: 0x8
	[Token(Token = "0x400034B")]
	private static TextGenerationSettings[] s_Settings; //Field offset: 0x10
	[Token(Token = "0x400034C")]
	private static TextGenerator[] s_Generators; //Field offset: 0x18
	[Token(Token = "0x400034D")]
	private static TextInfo[] s_TextInfosCommon; //Field offset: 0x20
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400034E")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal NativeTextGenerationSettings nativeSettings; //Field offset: 0x10
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400034F")]
	protected Vector2 pixelPreferedSize; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000350")]
	private Rect m_ScreenRect; //Field offset: 0x80
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000351")]
	private float m_LineHeightDefault; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x4000352")]
	private bool m_IsPlaceholder; //Field offset: 0x94
	[FieldOffset(Offset = "0x95")]
	[Token(Token = "0x4000353")]
	protected bool m_IsElided; //Field offset: 0x95
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000354")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal IntPtr textGenerationInfo; //Field offset: 0x98
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000355")]
	private LinkedListNode<TextInfo> <TextInfoNode>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000356")]
	private bool <IsCachedPermanent>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xA9")]
	[Token(Token = "0x4000357")]
	private bool <IsCachedTemporary>k__BackingField; //Field offset: 0xA9
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x4000358")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal int m_PreviousGenerationSettingsHash; //Field offset: 0xAC
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000359")]
	protected bool isDirty; //Field offset: 0xB0

	[Token(Token = "0x17000076")]
	internal int characterCount
	{
		[Address(RVA = "0x1A68C50", Offset = "0x1A67E50", Length = "0x43")]
		[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "get_m_CharacterCount", ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "get_characterCount", ReturnType = typeof(int))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(TextHandle), Member = "get_textInfo", ReturnType = typeof(TextInfo))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000283")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
		internal get { } //Length: 67
	}

	[Token(Token = "0x1700006F")]
	private static TextGenerator generator
	{
		[Address(RVA = "0x1A68CA0", Offset = "0x1A67EA0", Length = "0x207")]
		[CalledBy(Type = typeof(TextHandle), Member = "UpdatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextHandle), Member = "UpdateWithHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TextInfo))]
		[CalledBy(Type = typeof(TextHandle), Member = "PrepareFontAsset", ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(TextHandle), Member = "InitArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", "System.Func`1<T>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JobsUtility), Member = "get_ThreadIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000275")]
		private get { } //Length: 519
	}

	[Token(Token = "0x1700006C")]
	internal static TextGenerator[] generators
	{
		[Address(RVA = "0x1A68EB0", Offset = "0x1A680B0", Length = "0x1C7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(TextHandle), Member = "InitArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", "System.Func`1<T>"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000271")]
		internal get { } //Length: 455
	}

	[Token(Token = "0x17000073")]
	internal bool IsCachedPermanent
	{
		[Address(RVA = "0x2FDE10", Offset = "0x2FD010", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600027E")]
		internal get { } //Length: 8
		[Address(RVA = "0x2F5BD0", Offset = "0x2F4DD0", Length = "0x7")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600027F")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000074")]
	internal bool IsCachedTemporary
	{
		[Address(RVA = "0x1715D40", Offset = "0x1714F40", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000280")]
		internal get { } //Length: 8
		[Address(RVA = "0x1715DE0", Offset = "0x1714FE0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000281")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000078")]
	public override bool IsPlaceholder
	{
		[Address(RVA = "0x1230C30", Offset = "0x122FE30", Length = "0x8")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600028C")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000071")]
	internal Vector2 preferredSize
	{
		[Address(RVA = "0x1A69080", Offset = "0x1A68280", Length = "0x4A")]
		[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ComputeTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&), typeof(float), typeof(float), "System.Nullable`1<Single>"}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.GUIStyle", Member = "GetCursorPixelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), "UnityEngine.GUIContent", typeof(int)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.GUIStyle", Member = "GetPreferredSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Rect)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.GUIStyle", Member = "GetMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GUIStyle", typeof(Color), typeof(string), typeof(Rect), "UnityEngine.TextCore.Text.MeshInfoBindings[]&", typeof(Vector2&), typeof(Int32&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.GUIStyle", Member = "GetDimensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GUIStyle", typeof(Color), typeof(string), typeof(Rect), typeof(Vector2&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextEditor", Member = "GetLocalCursorPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000277")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
		internal get { } //Length: 74
	}

	[Token(Token = "0x17000070")]
	internal static TextGenerationSettings settings
	{
		[Address(RVA = "0x1A692A0", Offset = "0x1A684A0", Length = "0x207")]
		[CalledBy(Type = "UnityEngine.GUIStyle", Member = "GetMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GUIStyle", typeof(Color), typeof(string), typeof(Rect), "UnityEngine.TextCore.Text.MeshInfoBindings[]&", typeof(Vector2&), typeof(Int32&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "GetLineHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GUIStyle"}, ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GUIStyle", typeof(Rect), typeof(string), typeof(Color32), typeof(Boolean&)}, ReturnType = "UnityEngine.IMGUITextHandle")]
		[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GUIStyle", typeof(Rect), typeof(string), typeof(Color32)}, ReturnType = "UnityEngine.IMGUITextHandle")]
		[CalledBy(Type = typeof(TextHandle), Member = "UpdatePreferredSize", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextHandle), Member = "PrepareFontAsset", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextHandle), Member = "UpdateWithHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TextInfo))]
		[CalledBy(Type = typeof(TextHandlePermanentCache), Member = "AddTextInfoToCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextHandle)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Nullable`1<Single>"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "UpdateMesh", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ComputeSettingsAndUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ComputeTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&), typeof(float), typeof(float), "System.Nullable`1<Single>"}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(TextHandle), Member = "Update", ReturnType = typeof(TextInfo))]
		[CallerCount(Count = 25)]
		[Calls(Type = typeof(TextHandle), Member = "InitArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", "System.Func`1<T>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(JobsUtility), Member = "get_ThreadIndex", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000276")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
		internal get { } //Length: 519
	}

	[Token(Token = "0x1700006B")]
	internal static TextGenerationSettings[] settingsArray
	{
		[Address(RVA = "0x1A690D0", Offset = "0x1A682D0", Length = "0x1C7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(TextHandle), Member = "InitArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", "System.Func`1<T>"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000270")]
		internal get { } //Length: 455
	}

	[Token(Token = "0x17000077")]
	internal TextInfo textInfo
	{
		[Address(RVA = "0x1A696C0", Offset = "0x1A688C0", Length = "0x6E")]
		[CallerCount(Count = 58)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TextHandle), Member = "get_textInfoCommon", ReturnType = typeof(TextInfo))]
		[Token(Token = "0x6000289")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
		internal get { } //Length: 110
	}

	[Token(Token = "0x1700006E")]
	internal static TextInfo textInfoCommon
	{
		[Address(RVA = "0x1A694B0", Offset = "0x1A686B0", Length = "0x207")]
		[CalledBy(Type = typeof(TextHandle), Member = "get_textInfo", ReturnType = typeof(TextInfo))]
		[CalledBy(Type = typeof(TextHandle), Member = "UpdatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextHandle), Member = "UpdatePreferredSize", ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(TextHandle), Member = "InitArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", "System.Func`1<T>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JobsUtility), Member = "get_ThreadIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000274")]
		internal get { } //Length: 519
	}

	[Token(Token = "0x17000072")]
	internal LinkedListNode<TextInfo> TextInfoNode
	{
		[Address(RVA = "0x2DD260", Offset = "0x2DC460", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600027C")]
		internal get { } //Length: 8
		[Address(RVA = "0x2DD5C0", Offset = "0x2DC7C0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600027D")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x1700006D")]
	internal static TextInfo[] textInfosCommon
	{
		[Address(RVA = "0x1A69730", Offset = "0x1A68930", Length = "0x1C7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(TextHandle), Member = "InitArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", "System.Func`1<T>"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000272")]
		internal get { } //Length: 455
	}

	[Token(Token = "0x17000075")]
	internal bool useAdvancedText
	{
		[Address(RVA = "0x13BEDF0", Offset = "0x13BDFF0", Length = "0x14")]
		[CallerCount(Count = 65)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000282")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
		internal get { } //Length: 20
	}

	[Address(RVA = "0x1A689D0", Offset = "0x1A67BD0", Length = "0x1E3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x60002B1")]
	private static TextHandle() { }

	[Address(RVA = "0x1A68BC0", Offset = "0x1A67DC0", Length = "0x89")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.TextElement"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(bool), typeof(Boolean&)}, ReturnType = "UnityEngine.IMGUITextHandle")]
	[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(NativeTextGenerationSettings), Member = "get_Default", ReturnType = typeof(NativeTextGenerationSettings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600026D")]
	public TextHandle() { }

	[Address(RVA = "0x1A65C80", Offset = "0x1A64E80", Length = "0x91")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ComputeSettingsAndUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "UpdateMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextHandleTemporaryCache), Member = "AddTextInfoToCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextHandle), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000285")]
	public void AddTextInfoToTemporaryCache(int hashCode) { }

	[Address(RVA = "0x1A65D20", Offset = "0x1A64F20", Length = "0xD8")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "AddToPermanentCacheAndGenerateMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000284")]
	public override void AddToPermanentCacheAndGenerateMesh() { }

	[Address(RVA = "0x1A65E00", Offset = "0x1A65000", Length = "0xDA")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "GetVertexPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UIElements.TextUtilities", Member = "GetTextCoreSettingsForElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", typeof(bool)}, ReturnType = "UnityEngine.UIElements.UIR.TextCoreSettings")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FontAsset), Member = "get_faceInfo", ReturnType = typeof(FaceInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000292")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static float ConvertPixelUnitsToTextCoreRelativeUnits(float fontSize, FontAsset fontAsset) { }

	[Address(RVA = "0x1A65EE0", Offset = "0x1A650E0", Length = "0x105")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextHandle), Member = "RemoveTextInfoFromTemporaryCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextHandlePermanentCache), Member = "RemoveTextInfoFromCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600026E")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x1A65FF0", Offset = "0x1A651F0", Length = "0x14E")]
	[CalledBy(Type = "UnityEngine.UIElements.TextEventHandler", Member = "ATagOnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerUpEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextEventHandler", Member = "ATagOnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerMoveEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextEventHandler", Member = "LinkTagOnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerDownEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextEventHandler", Member = "LinkTagOnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerUpEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextEventHandler", Member = "LinkTagOnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerMoveEvent"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextHandle), Member = "get_textInfo", ReturnType = typeof(TextInfo))]
	[Calls(Type = typeof(TextInfo), Member = "FindIntersectingLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Rect), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600029A")]
	public int FindIntersectingLink(Vector3 position, bool inverseYAxis = true) { }

	[Address(RVA = "0x1A68C50", Offset = "0x1A67E50", Length = "0x43")]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "get_m_CharacterCount", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "get_characterCount", ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(TextHandle), Member = "get_textInfo", ReturnType = typeof(TextInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000283")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal int get_characterCount() { }

	[Address(RVA = "0x1A68CA0", Offset = "0x1A67EA0", Length = "0x207")]
	[CalledBy(Type = typeof(TextHandle), Member = "UpdatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextHandle), Member = "UpdateWithHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TextInfo))]
	[CalledBy(Type = typeof(TextHandle), Member = "PrepareFontAsset", ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TextHandle), Member = "InitArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", "System.Func`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JobsUtility), Member = "get_ThreadIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000275")]
	private static TextGenerator get_generator() { }

	[Address(RVA = "0x1A68EB0", Offset = "0x1A680B0", Length = "0x1C7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TextHandle), Member = "InitArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", "System.Func`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000271")]
	internal static TextGenerator[] get_generators() { }

	[Address(RVA = "0x2FDE10", Offset = "0x2FD010", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600027E")]
	internal bool get_IsCachedPermanent() { }

	[Address(RVA = "0x1715D40", Offset = "0x1714F40", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000280")]
	internal bool get_IsCachedTemporary() { }

	[Address(RVA = "0x1230C30", Offset = "0x122FE30", Length = "0x8")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600028C")]
	public override bool get_IsPlaceholder() { }

	[Address(RVA = "0x1A69080", Offset = "0x1A68280", Length = "0x4A")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ComputeTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&), typeof(float), typeof(float), "System.Nullable`1<Single>"}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.GUIStyle", Member = "GetCursorPixelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), "UnityEngine.GUIContent", typeof(int)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.GUIStyle", Member = "GetPreferredSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Rect)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.GUIStyle", Member = "GetMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GUIStyle", typeof(Color), typeof(string), typeof(Rect), "UnityEngine.TextCore.Text.MeshInfoBindings[]&", typeof(Vector2&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.GUIStyle", Member = "GetDimensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GUIStyle", typeof(Color), typeof(string), typeof(Rect), typeof(Vector2&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextEditor", Member = "GetLocalCursorPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000277")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal Vector2 get_preferredSize() { }

	[Address(RVA = "0x1A692A0", Offset = "0x1A684A0", Length = "0x207")]
	[CalledBy(Type = typeof(TextHandle), Member = "Update", ReturnType = typeof(TextInfo))]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ComputeSettingsAndUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "UpdateMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Nullable`1<Single>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextHandlePermanentCache), Member = "AddTextInfoToCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextHandle), Member = "UpdateWithHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TextInfo))]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ComputeTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&), typeof(float), typeof(float), "System.Nullable`1<Single>"}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TextHandle), Member = "UpdatePreferredSize", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GUIStyle", typeof(Rect), typeof(string), typeof(Color32)}, ReturnType = "UnityEngine.IMGUITextHandle")]
	[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GUIStyle", typeof(Rect), typeof(string), typeof(Color32), typeof(Boolean&)}, ReturnType = "UnityEngine.IMGUITextHandle")]
	[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "GetLineHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GUIStyle"}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.GUIStyle", Member = "GetMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GUIStyle", typeof(Color), typeof(string), typeof(Rect), "UnityEngine.TextCore.Text.MeshInfoBindings[]&", typeof(Vector2&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextHandle), Member = "PrepareFontAsset", ReturnType = typeof(bool))]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(JobsUtility), Member = "get_ThreadIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TextHandle), Member = "InitArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", "System.Func`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000276")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal static TextGenerationSettings get_settings() { }

	[Address(RVA = "0x1A690D0", Offset = "0x1A682D0", Length = "0x1C7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TextHandle), Member = "InitArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", "System.Func`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000270")]
	internal static TextGenerationSettings[] get_settingsArray() { }

	[Address(RVA = "0x1A696C0", Offset = "0x1A688C0", Length = "0x6E")]
	[CallerCount(Count = 58)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextHandle), Member = "get_textInfoCommon", ReturnType = typeof(TextInfo))]
	[Token(Token = "0x6000289")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal TextInfo get_textInfo() { }

	[Address(RVA = "0x1A694B0", Offset = "0x1A686B0", Length = "0x207")]
	[CalledBy(Type = typeof(TextHandle), Member = "get_textInfo", ReturnType = typeof(TextInfo))]
	[CalledBy(Type = typeof(TextHandle), Member = "UpdatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextHandle), Member = "UpdatePreferredSize", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TextHandle), Member = "InitArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", "System.Func`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JobsUtility), Member = "get_ThreadIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000274")]
	internal static TextInfo get_textInfoCommon() { }

	[Address(RVA = "0x2DD260", Offset = "0x2DC460", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600027C")]
	internal LinkedListNode<TextInfo> get_TextInfoNode() { }

	[Address(RVA = "0x1A69730", Offset = "0x1A68930", Length = "0x1C7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TextHandle), Member = "InitArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", "System.Func`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000272")]
	internal static TextInfo[] get_textInfosCommon() { }

	[Address(RVA = "0x13BEDF0", Offset = "0x13BDFF0", Length = "0x14")]
	[CallerCount(Count = 65)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000282")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal bool get_useAdvancedText() { }

	[Address(RVA = "0x1A66140", Offset = "0x1A65340", Length = "0xB5")]
	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "DrawCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(TextHandle), Member = "get_textInfo", ReturnType = typeof(TextInfo))]
	[Calls(Type = typeof(TextInfo), Member = "GetCharacterHeightFromIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60002A0")]
	public float GetCharacterHeightFromIndex(int index) { }

	[Address(RVA = "0x1A66200", Offset = "0x1A65400", Length = "0x56")]
	[CalledBy(Type = "UnityEngine.TextEditingUtilities", Member = "get_stringCursorIndex", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextEditingUtilities", Member = "get_stringSelectIndex", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextEditingUtilities", Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextEditOp"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextEditingUtilities", Member = "DeleteLineBack", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextEditingUtilities", Member = "DeleteWordBack", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextEditingUtilities", Member = "DeleteWordForward", ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(TextHandle), Member = "get_textInfo", ReturnType = typeof(TextInfo))]
	[Calls(Type = typeof(TextInfo), Member = "GetCorrespondingStringIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600029B")]
	public int GetCorrespondingStringIndex(int index) { }

	[Address(RVA = "0x1A66260", Offset = "0x1A65460", Length = "0xFC")]
	[CalledBy(Type = "UnityEngine.TextEditor", Member = "MoveCursorToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextEditor", Member = "MoveCursorToPosition_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "MoveCursorToPosition_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(TextHandle), Member = "get_textInfo", ReturnType = typeof(TextInfo))]
	[Calls(Type = typeof(TextInfo), Member = "GetCursorIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Rect), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000297")]
	public int GetCursorIndexFromPosition(Vector2 position, bool inverseYAxis = true) { }

	[Address(RVA = "0x1A66360", Offset = "0x1A65560", Length = "0x127")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(TextHandle), Member = "get_textInfo", ReturnType = typeof(TextInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000294")]
	public override Vector2 GetCursorPositionFromStringIndexUsingCharacterHeight(int index, bool inverseYAxis = true) { }

	[Address(RVA = "0x1A66490", Offset = "0x1A65690", Length = "0x12F")]
	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "UnityEngine.UIElements.ITextSelection.get_cursorPosition", ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "DrawHighlighting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.GUIStyle", Member = "GetCursorPixelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), "UnityEngine.GUIContent", typeof(int)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(TextHandle), Member = "get_textInfo", ReturnType = typeof(TextInfo))]
	[Calls(Type = typeof(TextInfo), Member = "GetCursorPositionFromStringIndexUsingLineHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Rect), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000295")]
	public Vector2 GetCursorPositionFromStringIndexUsingLineHeight(int index, bool useXAdvance = false, bool inverseYAxis = true) { }

	[Address(RVA = "0x1A665C0", Offset = "0x1A657C0", Length = "0xB9")]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "FindEndOfPreviousWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002A5")]
	public int GetEndOfPreviousWord(int currentIndex) { }

	[Address(RVA = "0x1A66680", Offset = "0x1A65880", Length = "0x91")]
	[CalledBy(Type = "UnityEngine.TextEditingUtilities", Member = "DeleteLineBack", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectGraphicalLineStart", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "MoveGraphicalLineStart", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "ExpandSelectGraphicalLineStart", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "GetGraphicalLineStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(TextHandle), Member = "GetLineInfoFromCharacterIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(LineInfo))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002A6")]
	public int GetFirstCharacterIndexOnLine(int currentIndex) { }

	[Address(RVA = "0x1A66720", Offset = "0x1A65920", Length = "0x166")]
	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "DrawNativeHighlighting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextSelectionService), Member = "GetHighlightRectangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(int)}, ReturnType = typeof(Rect[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000296")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal Rect[] GetHighlightRectangles(int cursorIndex, int selectIndex) { }

	[Address(RVA = "0x1A66890", Offset = "0x1A65A90", Length = "0x91")]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectGraphicalLineEnd", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "MoveGraphicalLineEnd", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "ExpandSelectGraphicalLineEnd", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "GetGraphicalLineEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(TextHandle), Member = "GetLineInfoFromCharacterIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(LineInfo))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002A7")]
	public int GetLastCharacterIndexOnLine(int currentIndex) { }

	[Address(RVA = "0x1A66BB0", Offset = "0x1A65DB0", Length = "0xB5")]
	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "DrawHighlighting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(TextHandle), Member = "get_textInfo", ReturnType = typeof(TextInfo))]
	[Calls(Type = typeof(TextInfo), Member = "GetLineHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600029E")]
	public float GetLineHeight(int lineNumber) { }

	[Address(RVA = "0x1A66930", Offset = "0x1A65B30", Length = "0x1B7")]
	[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "GetLineHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GUIStyle"}, ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "get_faceInfo", ReturnType = typeof(FaceInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000293")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule"})]
	internal static float GetLineHeightDefault(TextGenerationSettings settings) { }

	[Address(RVA = "0x1A66AF0", Offset = "0x1A65CF0", Length = "0xB5")]
	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "UnityEngine.UIElements.ITextSelection.get_lineHeightAtCursorPosition", ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(TextHandle), Member = "get_textInfo", ReturnType = typeof(TextInfo))]
	[Calls(Type = typeof(TextInfo), Member = "GetLineHeightFromCharacterIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600029F")]
	public float GetLineHeightFromCharacterIndex(int index) { }

	[Address(RVA = "0x1A66C70", Offset = "0x1A65E70", Length = "0x127")]
	[CalledBy(Type = typeof(TextHandle), Member = "GetFirstCharacterIndexOnLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextHandle), Member = "GetLastCharacterIndexOnLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextEditingUtilities", Member = "DeleteLineBack", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextHandle), Member = "get_textInfo", ReturnType = typeof(TextInfo))]
	[Calls(Type = typeof(TextInfo), Member = "GetLineInfoFromCharacterIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(LineInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600029C")]
	public LineInfo GetLineInfoFromCharacterIndex(int index) { }

	[Address(RVA = "0x1A66DA0", Offset = "0x1A65FA0", Length = "0x8A")]
	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "DrawHighlighting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(TextHandle), Member = "get_textInfo", ReturnType = typeof(TextInfo))]
	[Calls(Type = typeof(TextInfo), Member = "GetLineNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600029D")]
	public int GetLineNumber(int index) { }

	[Address(RVA = "0x1A66E30", Offset = "0x1A66030", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600027B")]
	protected override float GetPixelsPerPoint() { }

	[Address(RVA = "0x1A66E40", Offset = "0x1A66040", Length = "0xB9")]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "FindStartOfNextWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002A4")]
	public int GetStartOfNextWord(int currentIndex) { }

	[Address(RVA = "0x1A66F00", Offset = "0x1A66100", Length = "0xC3")]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectParagraphForward", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectCurrentParagraph", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "MoveParagraphForward", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "IndexOfEndOfLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextHandle), Member = "get_textInfo", ReturnType = typeof(TextInfo))]
	[Calls(Type = typeof(TextInfo), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002A8")]
	public int IndexOf(char value, int startIndex) { }

	[Address(RVA = "0x76CF80", Offset = "0x76C180", Length = "0xFE")]
	[CalledBy(Type = typeof(TextHandle), Member = "get_settings", ReturnType = typeof(TextGenerationSettings))]
	[CalledBy(Type = typeof(TextHandle), Member = "InitThreadArrays", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextHandle), Member = "get_settingsArray", ReturnType = typeof(TextGenerationSettings[]))]
	[CalledBy(Type = typeof(TextHandle), Member = "get_generators", ReturnType = typeof(TextGenerator[]))]
	[CalledBy(Type = typeof(TextHandle), Member = "get_textInfosCommon", ReturnType = typeof(TextInfo[]))]
	[CalledBy(Type = typeof(TextHandle), Member = "get_textInfoCommon", ReturnType = typeof(TextInfo))]
	[CalledBy(Type = typeof(TextHandle), Member = "get_generator", ReturnType = typeof(TextGenerator))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(JobsUtility), Member = "get_ThreadIndexCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000273")]
	private static void InitArray(ref T[] array, Func<T> createInstance) { }

	[Address(RVA = "0x1A66FD0", Offset = "0x1A661D0", Length = "0x3E6")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextJobSystem", Member = "PrepareTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext", typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TextHandle), Member = "InitArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", "System.Func`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600026F")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal static void InitThreadArrays() { }

	[Address(RVA = "0x191DD80", Offset = "0x191CF80", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002B0")]
	internal override bool IsAdvancedTextEnabledForElement() { }

	[Address(RVA = "0x1A673C0", Offset = "0x1A665C0", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600028B")]
	public bool IsDirty(int hashCode) { }

	[Address(RVA = "0x1A67400", Offset = "0x1A66600", Length = "0xC3")]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectParagraphBackward", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectCurrentParagraph", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "MoveParagraphBackward", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextHandle), Member = "get_textInfo", ReturnType = typeof(TextInfo))]
	[Calls(Type = typeof(TextInfo), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002A9")]
	public int LastIndexOf(char value, int startIndex) { }

	[Address(RVA = "0x1A674D0", Offset = "0x1A666D0", Length = "0x8A")]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectDown", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "MoveDown", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(TextHandle), Member = "get_textInfo", ReturnType = typeof(TextInfo))]
	[Calls(Type = typeof(TextInfo), Member = "LineDownCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000298")]
	public int LineDownCharacterPosition(int originalLogicalPos) { }

	[Address(RVA = "0x1A67560", Offset = "0x1A66760", Length = "0x8A")]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectUp", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "MoveUp", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(TextHandle), Member = "get_textInfo", ReturnType = typeof(TextInfo))]
	[Calls(Type = typeof(TextInfo), Member = "LineUpCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000299")]
	public int LineUpCharacterPosition(int originalLogicalPos) { }

	[Address(RVA = "0x1A675F0", Offset = "0x1A667F0", Length = "0xB9")]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "FindPrevSeperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "NextCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "FindEndOfClassification", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "UnityEngine.TextSelectingUtilities+Direction"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "FindStartOfNextWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "FindNextSeperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "MoveRight", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectCurrentWord", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectRight", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextEditingUtilities", Member = "Delete", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "MoveWordRight", ReturnType = typeof(void))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002A3")]
	public int NextCodePointIndex(int currentIndex) { }

	[Address(RVA = "0x1A676B0", Offset = "0x1A668B0", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600027A")]
	protected Vector2 PixelsToPoints(Vector2 pixel) { }

	[Address(RVA = "0x1A676F0", Offset = "0x1A668F0", Length = "0x30")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000278")]
	protected float PixelsToPoints(float pixel) { }

	[Address(RVA = "0x1A67720", Offset = "0x1A66920", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000279")]
	protected Vector2 PointsToPixels(Vector2 point) { }

	[Address(RVA = "0x1A67760", Offset = "0x1A66960", Length = "0x140")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextJobSystem+PrepareTextJobData", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextJobSystem", Member = "GenerateTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext", typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextHandle), Member = "get_settings", ReturnType = typeof(TextGenerationSettings))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextHandle), Member = "get_generator", ReturnType = typeof(TextGenerator))]
	[Calls(Type = typeof(TextGenerator), Member = "PrepareFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000290")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal bool PrepareFontAsset() { }

	[Address(RVA = "0x1A678B0", Offset = "0x1A66AB0", Length = "0xB9")]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "FindEndOfPreviousWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextEditingUtilities", Member = "Backspace", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectLeft", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectCurrentWord", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "MoveLeft", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "FindPrevSeperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "FindEndOfClassification", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "UnityEngine.TextSelectingUtilities+Direction"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "PreviousCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002A2")]
	public int PreviousCodePointIndex(int currentIndex) { }

	[Address(RVA = "0x1A67970", Offset = "0x1A66B70", Length = "0xB9")]
	[CalledBy(Type = "UnityEngine.UIElements.TextEditingManipulator", Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "OnDetachFromPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.DetachFromPanelEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextEventHandler", Member = "HandleLinkTag", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextEventHandler", Member = "HandleATag", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "ClearUnusedTextHandles", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextHandlePermanentCache), Member = "RemoveTextInfoFromCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000287")]
	public void RemoveTextInfoFromPermanentCache() { }

	[Address(RVA = "0x1A67A30", Offset = "0x1A66C30", Length = "0x74")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ComputeSettingsAndUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "UpdateMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "OnDetachFromPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.DetachFromPanelEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextHandle), Member = "Finalize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextHandlePermanentCache), Member = "AddTextInfoToCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000286")]
	public void RemoveTextInfoFromTemporaryCache() { }

	[Address(RVA = "0x1A67AB0", Offset = "0x1A66CB0", Length = "0xCE")]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectCurrentParagraph", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002AB")]
	public void SelectCurrentParagraph(ref int cursorIndex, ref int selectIndex) { }

	[Address(RVA = "0x1A67B80", Offset = "0x1A66D80", Length = "0xCE")]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectCurrentWord", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002AA")]
	public void SelectCurrentWord(int index, ref int cursorIndex, ref int selectIndex) { }

	[Address(RVA = "0x1A67C50", Offset = "0x1A66E50", Length = "0xB9")]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002AF")]
	public void SelectToEndOfParagraph(ref int cursorIndex) { }

	[Address(RVA = "0x1A67D10", Offset = "0x1A66F10", Length = "0xB9")]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectParagraphForward", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "MoveParagraphForward", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002AD")]
	public void SelectToNextParagraph(ref int cursorIndex) { }

	[Address(RVA = "0x1A67DD0", Offset = "0x1A66FD0", Length = "0xB9")]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectParagraphBackward", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "MoveParagraphBackward", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002AC")]
	public void SelectToPreviousParagraph(ref int cursorIndex) { }

	[Address(RVA = "0x1A67E90", Offset = "0x1A67090", Length = "0xB9")]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002AE")]
	public void SelectToStartOfParagraph(ref int cursorIndex) { }

	[Address(RVA = "0x2F5BD0", Offset = "0x2F4DD0", Length = "0x7")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600027F")]
	internal void set_IsCachedPermanent(bool value) { }

	[Address(RVA = "0x1715DE0", Offset = "0x1714FE0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000281")]
	internal void set_IsCachedTemporary(bool value) { }

	[Address(RVA = "0x2DD5C0", Offset = "0x2DC7C0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600027D")]
	internal void set_TextInfoNode(LinkedListNode<TextInfo> value) { }

	[Address(RVA = "0x1A67F50", Offset = "0x1A67150", Length = "0x8")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "SetDirty", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x600028A")]
	public override void SetDirty() { }

	[Address(RVA = "0x1A67F60", Offset = "0x1A67160", Length = "0x86")]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "get_selectedText", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectionService), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TextHandle), Member = "get_textInfo", ReturnType = typeof(TextInfo))]
	[Calls(Type = typeof(TextInfo), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002A1")]
	public string Substring(int startIndex, int length) { }

	[Address(RVA = "0x1A68950", Offset = "0x1A67B50", Length = "0x74")]
	[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "DoPollTouchScreenKeyboard", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextHandle), Member = "get_settings", ReturnType = typeof(TextGenerationSettings))]
	[Calls(Type = typeof(TextHandle), Member = "UpdateWithHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TextInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600028E")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal TextInfo Update() { }

	[Address(RVA = "0x1A67FF0", Offset = "0x1A671F0", Length = "0x65")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextJobSystem", Member = "PrepareTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext", typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextJobSystem", Member = "GenerateTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext", typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Time), Member = "get_frameCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000288")]
	public static void UpdateCurrentFrame() { }

	[Address(RVA = "0x1A68060", Offset = "0x1A67260", Length = "0x4AD")]
	[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(bool), typeof(Boolean&)}, ReturnType = "UnityEngine.IMGUITextHandle")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextHandle), Member = "get_textInfoCommon", ReturnType = typeof(TextInfo))]
	[Calls(Type = typeof(TextHandle), Member = "get_textInfo", ReturnType = typeof(TextInfo))]
	[Calls(Type = typeof(TextHandle), Member = "get_settings", ReturnType = typeof(TextGenerationSettings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000291")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule"})]
	internal void UpdatePreferredSize() { }

	[Address(RVA = "0x1A68510", Offset = "0x1A67710", Length = "0x9D")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ComputeTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&), typeof(float), typeof(float), "System.Nullable`1<Single>"}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextHandle), Member = "get_generator", ReturnType = typeof(TextGenerator))]
	[Calls(Type = typeof(TextHandle), Member = "get_textInfoCommon", ReturnType = typeof(TextInfo))]
	[Calls(Type = typeof(TextGenerator), Member = "GetPreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600028D")]
	protected void UpdatePreferredValues(TextGenerationSettings tgs) { }

	[Address(RVA = "0x1A685B0", Offset = "0x1A677B0", Length = "0x399")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ComputeSettingsAndUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "UpdateMesh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextHandle), Member = "Update", ReturnType = typeof(TextInfo))]
	[CalledBy(Type = typeof(TextHandlePermanentCache), Member = "AddTextInfoToCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextHandleTemporaryCache), Member = "AddTextInfoToCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextHandle), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(bool), typeof(Boolean&)}, ReturnType = "UnityEngine.IMGUITextHandle")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(TextHandle), Member = "get_textInfo", ReturnType = typeof(TextInfo))]
	[Calls(Type = typeof(TextHandle), Member = "get_generator", ReturnType = typeof(TextGenerator))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "get_faceInfo", ReturnType = typeof(FaceInfo))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextGenerator), Member = "GenerateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextHandle), Member = "get_settings", ReturnType = typeof(TextGenerationSettings))]
	[Calls(Type = typeof(TextGenerator), Member = "get_isTextTruncated", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600028F")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal TextInfo UpdateWithHash(int hashCode) { }

}

