namespace UnityEngine.TextCore.Text;

[Token(Token = "0x200005F")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
internal class TextInfo
{
	[Token(Token = "0x400036A")]
	private static Vector2 s_InfinityVectorPositive; //Field offset: 0x0
	[Token(Token = "0x400036B")]
	private static Vector2 s_InfinityVectorNegative; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400036C")]
	public int characterCount; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400036D")]
	public int spriteCount; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400036E")]
	public int spaceCount; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400036F")]
	public int wordCount; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000370")]
	public int linkCount; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000371")]
	public int lineCount; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000372")]
	public int materialCount; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000373")]
	public TextElementInfo[] textElementInfo; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000374")]
	public WordInfo[] wordInfo; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000375")]
	public LinkInfo[] linkInfo; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000376")]
	public LineInfo[] lineInfo; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000377")]
	public MeshInfo[] meshInfo; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000378")]
	public double lastTimeInCache; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000379")]
	public Action removedFromCache; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400037A")]
	public bool hasMultipleColors; //Field offset: 0x68

	[Address(RVA = "0x1A6F530", Offset = "0x1A6E730", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60002DE")]
	private static TextInfo() { }

	[Address(RVA = "0x1A6F590", Offset = "0x1A6E790", Length = "0x1BC")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandle+<>c", Member = "<InitThreadArrays>b__4_2", ReturnType = typeof(TextInfo))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandle+<>c", Member = "<get_textInfosCommon>b__13_0", ReturnType = typeof(TextInfo))]
	[CalledBy(Type = typeof(TextHandlePermanentCache), Member = "AddTextInfoToCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextHandleTemporaryCache), Member = "AddTextInfoToCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextHandle), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002C5")]
	public TextInfo() { }

	[Address(RVA = "0x1A6D7E0", Offset = "0x1A6C9E0", Length = "0x6D")]
	[CalledBy(Type = typeof(TextGenerator), Member = "GenerateTextMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60002C6")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal void Clear() { }

	[Address(RVA = "0x1A6D4D0", Offset = "0x1A6C6D0", Length = "0x286")]
	[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60002C8")]
	internal void ClearLineInfo() { }

	[Address(RVA = "0x1A6D760", Offset = "0x1A6C960", Length = "0x7F")]
	[CalledBy(Type = typeof(TextGenerator), Member = "GenerateTextMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "ClearMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MeshInfo), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60002C7")]
	internal void ClearMeshInfo(bool updateMesh) { }

	[Address(RVA = "0x1A6D850", Offset = "0x1A6CA50", Length = "0x26A")]
	[CalledBy(Type = typeof(TextInfo), Member = "FindNearestCharacterOnLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Token(Token = "0x60002D6")]
	private static float DistanceToLine(Vector3 a, Vector3 b, Vector3 point) { }

	[Address(RVA = "0x1A6DAC0", Offset = "0x1A6CCC0", Length = "0x51E")]
	[CalledBy(Type = typeof(TextHandle), Member = "FindIntersectingLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B0F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextInfo), Member = "PointIntersectRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002D2")]
	public int FindIntersectingLink(Vector3 position, Rect screenRect, bool inverseYAxis = true) { }

	[Address(RVA = "0x1A6DFE0", Offset = "0x1A6D1E0", Length = "0x454")]
	[CalledBy(Type = typeof(TextInfo), Member = "GetCursorIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Rect), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B0F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextInfo), Member = "PointIntersectRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextInfo), Member = "DistanceToLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002D1")]
	public int FindNearestCharacterOnLine(Vector2 position, int line, bool visibleOnly) { }

	[Address(RVA = "0x1A6E440", Offset = "0x1A6D640", Length = "0xC6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002D0")]
	public int FindNearestLine(Vector2 position) { }

	[Address(RVA = "0x1A6E510", Offset = "0x1A6D710", Length = "0x58")]
	[CalledBy(Type = typeof(TextHandle), Member = "GetCharacterHeightFromIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B0F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002DA")]
	public float GetCharacterHeightFromIndex(int index) { }

	[Address(RVA = "0x1A6E570", Offset = "0x1A6D770", Length = "0x57")]
	[CalledBy(Type = typeof(TextHandle), Member = "GetCorrespondingStringIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002D3")]
	public int GetCorrespondingStringIndex(int index) { }

	[Address(RVA = "0x1A6E5D0", Offset = "0x1A6D7D0", Length = "0x19E")]
	[CalledBy(Type = typeof(TextHandle), Member = "GetCursorIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextInfo), Member = "FindNearestCharacterOnLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B0F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002CD")]
	public int GetCursorIndexFromPosition(Vector2 position, Rect screenRect, bool inverseYAxis = true) { }

	[Address(RVA = "0x1A6E770", Offset = "0x1A6D970", Length = "0xE1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B0F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002CB")]
	public override Vector2 GetCursorPositionFromStringIndexUsingCharacterHeight(int index, Rect screenRect, float lineHeight, bool inverseYAxis = true) { }

	[Address(RVA = "0x1A6E860", Offset = "0x1A6DA60", Length = "0x125")]
	[CalledBy(Type = typeof(TextHandle), Member = "GetCursorPositionFromStringIndexUsingLineHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B0F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002CC")]
	public Vector2 GetCursorPositionFromStringIndexUsingLineHeight(int index, Rect screenRect, float lineHeight, bool useXAdvance = false, bool inverseYAxis = true) { }

	[Address(RVA = "0x1A6EA20", Offset = "0x1A6DC20", Length = "0x50")]
	[CalledBy(Type = typeof(TextHandle), Member = "GetLineHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60002D8")]
	public float GetLineHeight(int lineNumber) { }

	[Address(RVA = "0x1A6E990", Offset = "0x1A6DB90", Length = "0x88")]
	[CalledBy(Type = typeof(TextHandle), Member = "GetLineHeightFromCharacterIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60002D9")]
	public float GetLineHeightFromCharacterIndex(int index) { }

	[Address(RVA = "0x1A6EA80", Offset = "0x1A6DC80", Length = "0xC7")]
	[CalledBy(Type = typeof(TextHandle), Member = "GetLineInfoFromCharacterIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(LineInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60002D4")]
	public LineInfo GetLineInfoFromCharacterIndex(int index) { }

	[Address(RVA = "0x1A6EB50", Offset = "0x1A6DD50", Length = "0x4D")]
	[CalledBy(Type = typeof(TextHandle), Member = "GetLineNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60002D7")]
	public int GetLineNumber(int index) { }

	[Address(RVA = "0x1A6EBA0", Offset = "0x1A6DDA0", Length = "0xAB")]
	[CalledBy(Type = typeof(TextHandle), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002DC")]
	public int IndexOf(char value, int startIndex) { }

	[Address(RVA = "0x1A6EC50", Offset = "0x1A6DE50", Length = "0xAD")]
	[CalledBy(Type = typeof(TextHandle), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002DD")]
	public int LastIndexOf(char value, int startIndex) { }

	[Address(RVA = "0x1A6ED00", Offset = "0x1A6DF00", Length = "0x1D4")]
	[CalledBy(Type = typeof(TextHandle), Member = "LineDownCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B0F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002CE")]
	public int LineDownCharacterPosition(int originalPos) { }

	[Address(RVA = "0x1A6EEE0", Offset = "0x1A6E0E0", Length = "0x1CC")]
	[CalledBy(Type = typeof(TextHandle), Member = "LineUpCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B0F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002CF")]
	public int LineUpCharacterPosition(int originalPos) { }

	[Address(RVA = "0x1A6F0B0", Offset = "0x1A6E2B0", Length = "0x29E")]
	[CalledBy(Type = typeof(TextInfo), Member = "FindNearestCharacterOnLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextInfo), Member = "FindIntersectingLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Rect), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002D5")]
	private static bool PointIntersectRectangle(Vector3 m, Vector3 a, Vector3 b, Vector3 c, Vector3 d) { }

	[Address(RVA = "0x1A6F350", Offset = "0x1A6E550", Length = "0x38")]
	[CalledBy(Type = typeof(TextHandleTemporaryCache), Member = "ClearTemporaryCache", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextHandleTemporaryCache), Member = "AddTextInfoToCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextHandle), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextHandleTemporaryCache), Member = "RecycleTextInfoFromCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002C4")]
	public void RemoveFromCache() { }

	[Address(RVA = "0x768880", Offset = "0x767A80", Length = "0xA4")]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60002CA")]
	internal static void Resize(ref T[] array, int size, bool isBlockAllocated) { }

	[Address(RVA = "0x768800", Offset = "0x767A00", Length = "0x7C")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60002C9")]
	internal static void Resize(ref T[] array, int size) { }

	[Address(RVA = "0x1A6F390", Offset = "0x1A6E590", Length = "0x19F")]
	[CalledBy(Type = typeof(TextHandle), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002DB")]
	public string Substring(int startIndex, int length) { }

}

