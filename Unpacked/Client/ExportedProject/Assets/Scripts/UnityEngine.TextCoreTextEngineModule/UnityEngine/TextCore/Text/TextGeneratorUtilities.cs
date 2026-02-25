namespace UnityEngine.TextCore.Text;

[Extension]
[Token(Token = "0x2000055")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
internal static class TextGeneratorUtilities
{
	[Token(Token = "0x4000342")]
	public static readonly Vector2 largePositiveVector2; //Field offset: 0x0
	[Token(Token = "0x4000343")]
	public static readonly Vector2 largeNegativeVector2; //Field offset: 0x8
	[Token(Token = "0x4000344")]
	private static readonly HashSet<UInt32> k_EmojiLookup; //Field offset: 0x10
	[Token(Token = "0x4000345")]
	private static readonly HashSet<UInt32> k_EmojiPresentationFormLookup; //Field offset: 0x18

	[Address(RVA = "0x1A649D0", Offset = "0x1A63BD0", Length = "0x189")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.UInt32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.UInt32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000245")]
	private static TextGeneratorUtilities() { }

	[Address(RVA = "0x1A609B0", Offset = "0x1A5FBB0", Length = "0x38F")]
	[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "InsertNewLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Boolean&), typeof(Single&), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600022D")]
	public static void AdjustLineOffset(int startIndex, int endIndex, float offset, TextInfo textInfo) { }

	[Address(RVA = "0x1A60D40", Offset = "0x1A5FF40", Length = "0x22")]
	[CalledBy(Type = typeof(TextGenerator), Member = "LayoutPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000215")]
	public static bool Approximately(float a, float b) { }

	[Address(RVA = "0x1A60EF0", Offset = "0x1A600F0", Length = "0x7B")]
	[CalledBy(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "ConvertToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(float))]
	[Token(Token = "0x6000218")]
	public static float ConvertToFloat(Char[] chars, int startIndex, int length) { }

	[Address(RVA = "0x1A60D70", Offset = "0x1A5FF70", Length = "0x17A")]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "ConvertToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "GetAttributeParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(Single[]&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000219")]
	public static float ConvertToFloat(Char[] chars, int startIndex, int length, out int lastIndex) { }

	[Address(RVA = "0x1A60F70", Offset = "0x1A60170", Length = "0xE")]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000233")]
	public static uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate) { }

	[Address(RVA = "0x1A60F80", Offset = "0x1A60180", Length = "0xA45")]
	[CalledBy(Type = typeof(TextGenerator), Member = "LayoutPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MeshInfo), Member = "ResizeMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180288CC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802898A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180289280")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "GammaToLinear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600022B")]
	public static void FillCharacterVertexBuffers(int i, bool convertToLinearSpace, TextGenerationSettings generationSettings, TextInfo textInfo, bool needToRound) { }

	[Address(RVA = "0x1A619D0", Offset = "0x1A60BD0", Length = "0x91A")]
	[CalledBy(Type = typeof(TextGenerator), Member = "LayoutPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "GammaToLinear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600022C")]
	public static void FillSpriteVertexBuffers(int i, bool convertToLinearSpace, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	[Address(RVA = "0x1A62370", Offset = "0x1A61570", Length = "0xAF")]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "GammaToLinear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32)}, ReturnType = typeof(Color32))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180289930")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600023E")]
	private static byte GammaToLinear(byte value) { }

	[Address(RVA = "0x1A622F0", Offset = "0x1A614F0", Length = "0x7D")]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "FillCharacterVertexBuffers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "FillSpriteVertexBuffers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "GammaToLinear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(byte))]
	[Token(Token = "0x600023D")]
	internal static Color32 GammaToLinear(Color32 c) { }

	[Address(RVA = "0x1A62420", Offset = "0x1A61620", Length = "0xE2")]
	[CalledBy(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "ConvertToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000239")]
	public static int GetAttributeParameters(Char[] chars, int startIndex, int length, ref Single[] parameters) { }

	[Address(RVA = "0x1A62510", Offset = "0x1A61710", Length = "0x2C")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Nullable`1<Single>"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000231")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static HorizontalAlignment GetHorizontalAlignment(TextAnchor anchor) { }

	[Address(RVA = "0x1A62560", Offset = "0x1A61760", Length = "0xE6")]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[]), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "ToUpperASCIIFast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000235")]
	public static int GetMarkupTagHashCode(UInt32[] styleDefinition, int readIndex) { }

	[Address(RVA = "0x1A62650", Offset = "0x1A61850", Length = "0xF3")]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "ToUpperASCIIFast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000234")]
	public static int GetMarkupTagHashCode(TextBackingContainer styleDefinition, int readIndex) { }

	[Address(RVA = "0x1A62930", Offset = "0x1A61B30", Length = "0xBA")]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "ReplaceOpeningStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextBackingContainer&), typeof(int), typeof(Int32&), typeof(TextProcessingElement[]&), typeof(Int32&), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "ReplaceOpeningStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]&), typeof(int), typeof(Int32&), typeof(TextProcessingElement[]&), typeof(Int32&), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "ReplaceClosingStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "InsertClosingStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextStyleSheet), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TextStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000224")]
	public static TextStyle GetStyle(TextGenerationSettings generationSetting, int hashCode) { }

	[Address(RVA = "0x1A62840", Offset = "0x1A61A40", Length = "0xE6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "ToUpperASCIIFast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000225")]
	public static int GetStyleHashCode(ref UInt32[] text, int index, out int closeIndex) { }

	[Address(RVA = "0x1A62750", Offset = "0x1A61950", Length = "0xE6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "ToUpperASCIIFast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000226")]
	public static int GetStyleHashCode(ref TextBackingContainer text, int index, out int closeIndex) { }

	[Address(RVA = "0x1A62AF0", Offset = "0x1A61CF0", Length = "0xDD")]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[]), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000227")]
	public static uint GetUTF16(UInt32[] text, int i) { }

	[Address(RVA = "0x1A629F0", Offset = "0x1A61BF0", Length = "0xF5")]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000228")]
	public static uint GetUTF16(TextBackingContainer text, int i) { }

	[Address(RVA = "0x1A62D30", Offset = "0x1A61F30", Length = "0x1A7")]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Token(Token = "0x600022A")]
	public static uint GetUTF32(TextBackingContainer text, int i) { }

	[Address(RVA = "0x1A62BD0", Offset = "0x1A61DD0", Length = "0x159")]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[]), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Token(Token = "0x6000229")]
	public static uint GetUTF32(UInt32[] text, int i) { }

	[Address(RVA = "0x1A62EE0", Offset = "0x1A620E0", Length = "0x2C")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Nullable`1<Single>"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000232")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static VerticalAlignment GetVerticalAlignment(TextAnchor anchor) { }

	[Address(RVA = "0x1A62F30", Offset = "0x1A62130", Length = "0x419")]
	[CalledBy(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 23)]
	[Token(Token = "0x6000216")]
	public static Color32 HexCharsToColor(Char[] hexChars, int startIndex, int tagCount) { }

	[Address(RVA = "0x18F7D80", Offset = "0x18F6F80", Length = "0xA8")]
	[CallerCount(Count = 49)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000217")]
	public static uint HexToInt(char hex) { }

	[Address(RVA = "0x1A63350", Offset = "0x1A62550", Length = "0xFB")]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(int)}, ReturnType = typeof(TextStyle))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[]), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000222")]
	internal static void InsertClosingStyleTag(ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<Int32>[]& textStyleStacks, ref TextGenerationSettings generationSettings) { }

	[Address(RVA = "0x1A63450", Offset = "0x1A62650", Length = "0xED")]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[]), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600021D")]
	internal static void InsertClosingTextStyle(TextStyle style, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<Int32>[]& textStyleStacks, ref TextGenerationSettings generationSettings) { }

	[Address(RVA = "0x1A63540", Offset = "0x1A62740", Length = "0xE7")]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[]), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000221")]
	internal static void InsertOpeningStyleTag(TextStyle style, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<Int32>[]& textStyleStacks, ref TextGenerationSettings generationSettings) { }

	[Address(RVA = "0x1A63630", Offset = "0x1A62830", Length = "0xED")]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[]), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600021C")]
	internal static void InsertOpeningTextStyle(TextStyle style, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<Int32>[]& textStyleStacks, ref TextGenerationSettings generationSettings) { }

	[Address(RVA = "0x1A63720", Offset = "0x1A62920", Length = "0x50E")]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "InsertOpeningTextStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextStyle), typeof(TextProcessingElement[]&), typeof(Int32&), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "InsertClosingTextStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextStyle), typeof(TextProcessingElement[]&), typeof(Int32&), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "ReplaceOpeningStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextBackingContainer&), typeof(int), typeof(Int32&), typeof(TextProcessingElement[]&), typeof(Int32&), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "ReplaceOpeningStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]&), typeof(int), typeof(Int32&), typeof(TextProcessingElement[]&), typeof(Int32&), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "ReplaceClosingStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "InsertOpeningStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextStyle), typeof(TextProcessingElement[]&), typeof(Int32&), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "InsertClosingStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "ReplaceClosingStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "ReplaceOpeningStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]&), typeof(int), typeof(Int32&), typeof(TextProcessingElement[]&), typeof(Int32&), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "GetMarkupTagHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "GetUTF32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "ResizeInternalArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "GetUTF16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int)}, ReturnType = typeof(uint))]
	[Token(Token = "0x6000223")]
	private static void InsertTextStyleInTextProcessingArray(ref TextProcessingElement[] charBuffer, ref int writeIndex, UInt32[] styleDefinition, ref int textStyleStackDepth, ref TextProcessingStack<Int32>[]& textStyleStacks, ref TextGenerationSettings generationSettings) { }

	[Address(RVA = "0x1A63C30", Offset = "0x1A62E30", Length = "0x10F")]
	[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600023B")]
	public static bool IsBaseGlyph(uint c) { }

	[Address(RVA = "0x1A63D40", Offset = "0x1A62F40", Length = "0x25")]
	[CalledBy(Type = "UnityEngine.UIElements.ATGTextJobSystem", Member = "ConvertMeshInfoToUIRVertex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.ATGMeshInfo[]", "UnityEngine.UIElements.TempMeshAllocator", "UnityEngine.UIElements.TextElement", "System.Collections.Generic.List`1<Texture2D>", "System.Collections.Generic.List`1<NativeSlice`1<Vertex>>", "System.Collections.Generic.List`1<NativeSlice`1<UInt16>>", "System.Collections.Generic.List`1<GlyphRenderMode>", "System.Collections.Generic.List`1<Single>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator", Member = "DrawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<NativeSlice`1<Vertex>>", "System.Collections.Generic.List`1<NativeSlice`1<UInt16>>", "System.Collections.Generic.List`1<Material>", "System.Collections.Generic.List`1<GlyphRenderMode>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600023A")]
	public static bool IsBitmapRendering(GlyphRenderMode glyphRenderMode) { }

	[Address(RVA = "0x1A63D70", Offset = "0x1A62F70", Length = "0xBC")]
	[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000244")]
	internal static bool IsCJK(uint c) { }

	[Address(RVA = "0x1A63EB0", Offset = "0x1A630B0", Length = "0x77")]
	[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextProcessingElement[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.UInt32>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000241")]
	internal static bool IsEmoji(uint c) { }

	[Address(RVA = "0x1A63E30", Offset = "0x1A63030", Length = "0x77")]
	[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextProcessingElement[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.UInt32>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000242")]
	internal static bool IsEmojiPresentationForm(uint c) { }

	[Address(RVA = "0x1A63F30", Offset = "0x1A63130", Length = "0x51")]
	[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000243")]
	internal static bool IsHangul(uint c) { }

	[Address(RVA = "0x1A63F90", Offset = "0x1A63190", Length = "0x6D")]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600023F")]
	public static bool IsValidUTF16(TextBackingContainer text, int index) { }

	[Address(RVA = "0x1A64000", Offset = "0x1A63200", Length = "0x6D")]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000240")]
	public static bool IsValidUTF32(TextBackingContainer text, int index) { }

	[Address(RVA = "0x1A64070", Offset = "0x1A63270", Length = "0x54")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Nullable`1<Single>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), "UnityEngine.GUIStyle", typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000230")]
	public static TextAlignment LegacyAlignmentToNewAlignment(TextAnchor anchor) { }

	[Address(RVA = "0x1A640F0", Offset = "0x1A632F0", Length = "0x24")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Nullable`1<Single>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Nullable`1<Single>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), "UnityEngine.GUIStyle", typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x600022F")]
	public static FontStyles LegacyStyleToNewStyle(FontStyle fontStyle) { }

	[Address(RVA = "0x1A64120", Offset = "0x1A63320", Length = "0x59")]
	[CalledBy(Type = typeof(TextGenerator), Member = "SaveGlyphVertexInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Extension]
	[Token(Token = "0x600023C")]
	public static Color MinAlpha(Color c1, Color c2) { }

	[Address(RVA = "0x1A64180", Offset = "0x1A63380", Length = "0x120")]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[]), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(int)}, ReturnType = typeof(TextStyle))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[]), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000220")]
	public static void ReplaceClosingStyleTag(ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<Int32>[]& textStyleStacks, ref TextGenerationSettings generationSettings) { }

	[Address(RVA = "0x1A644A0", Offset = "0x1A636A0", Length = "0x1EF")]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[]), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "ToUpperASCIIFast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(int)}, ReturnType = typeof(TextStyle))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[]), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600021F")]
	private static bool ReplaceOpeningStyleTag(ref UInt32[] sourceText, int srcIndex, out int srcOffset, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<Int32>[]& textStyleStacks, ref TextGenerationSettings generationSettings) { }

	[Address(RVA = "0x1A642B0", Offset = "0x1A634B0", Length = "0x1EF")]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "ToUpperASCIIFast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(int)}, ReturnType = typeof(TextStyle))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[]), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600021E")]
	public static bool ReplaceOpeningStyleTag(ref TextBackingContainer sourceText, int srcIndex, out int srcOffset, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<Int32>[]& textStyleStacks, ref TextGenerationSettings generationSettings) { }

	[Address(RVA = "0x76CD60", Offset = "0x76BF60", Length = "0x69")]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[]), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600021B")]
	public static void ResizeInternalArray(ref T[] array, int size) { }

	[Address(RVA = "0x76CCF0", Offset = "0x76BEF0", Length = "0x6C")]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600021A")]
	public static void ResizeInternalArray(ref T[] array) { }

	[Address(RVA = "0x1A64690", Offset = "0x1A63890", Length = "0x21C")]
	[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "InsertNewLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Boolean&), typeof(Single&), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600022E")]
	public static void ResizeLineExtents(int size, TextInfo textInfo) { }

	[Address(RVA = "0x1A64910", Offset = "0x1A63B10", Length = "0x57")]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "GetMarkupTagHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextBackingContainer), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "GetMarkupTagHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000237")]
	public static uint ToUpperASCIIFast(uint c) { }

	[Address(RVA = "0x1A648B0", Offset = "0x1A63AB0", Length = "0x55")]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "ReplaceOpeningStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextBackingContainer&), typeof(int), typeof(Int32&), typeof(TextProcessingElement[]&), typeof(Int32&), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "ReplaceOpeningStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]&), typeof(int), typeof(Int32&), typeof(TextProcessingElement[]&), typeof(Int32&), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "GetStyleHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]&), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "GetStyleHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextBackingContainer&), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000236")]
	public static char ToUpperASCIIFast(char c) { }

	[Address(RVA = "0x1A64970", Offset = "0x1A63B70", Length = "0x55")]
	[CalledBy(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000238")]
	public static char ToUpperFast(char c) { }

}

