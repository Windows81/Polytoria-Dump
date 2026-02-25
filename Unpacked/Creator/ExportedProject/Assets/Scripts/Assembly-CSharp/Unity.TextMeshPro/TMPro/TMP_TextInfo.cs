namespace TMPro;

[Token(Token = "0x20000AC")]
public class TMP_TextInfo
{
	[Token(Token = "0x4000644")]
	internal static Vector2 k_InfinityVectorPositive; //Field offset: 0x0
	[Token(Token = "0x4000645")]
	internal static Vector2 k_InfinityVectorNegative; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000646")]
	public TMP_Text textComponent; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000647")]
	public int characterCount; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000648")]
	public int spriteCount; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000649")]
	public int spaceCount; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400064A")]
	public int wordCount; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400064B")]
	public int linkCount; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400064C")]
	public int lineCount; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400064D")]
	public int pageCount; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400064E")]
	public int materialCount; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400064F")]
	public TMP_CharacterInfo[] characterInfo; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000650")]
	public TMP_WordInfo[] wordInfo; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000651")]
	public TMP_LinkInfo[] linkInfo; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000652")]
	public TMP_LineInfo[] lineInfo; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000653")]
	public TMP_PageInfo[] pageInfo; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000654")]
	public TMP_MeshInfo[] meshInfo; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000655")]
	private TMP_MeshInfo[] m_CachedMeshInfo; //Field offset: 0x68

	[Address(RVA = "0x18F1380", Offset = "0x18F0580", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000693")]
	private static TMP_TextInfo() { }

	[Address(RVA = "0x18F13E0", Offset = "0x18F05E0", Length = "0x133")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000685")]
	public TMP_TextInfo() { }

	[Address(RVA = "0x18F16D0", Offset = "0x18F08D0", Length = "0x13B")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000686")]
	internal TMP_TextInfo(int characterCount) { }

	[Address(RVA = "0x18F1520", Offset = "0x18F0720", Length = "0x1A6")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000687")]
	public TMP_TextInfo(TMP_Text textComponent) { }

	[Address(RVA = "0x18F0D20", Offset = "0x18EFF20", Length = "0x6D")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000688")]
	internal void Clear() { }

	[Address(RVA = "0x18F05C0", Offset = "0x18EF7C0", Length = "0x146")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000689")]
	internal void ClearAllData() { }

	[Address(RVA = "0x18F0710", Offset = "0x18EF910", Length = "0xAE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_MeshInfo), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600068B")]
	public void ClearAllMeshInfo() { }

	[Address(RVA = "0x18F07C0", Offset = "0x18EF9C0", Length = "0x2D2")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600068E")]
	internal void ClearLineInfo() { }

	[Address(RVA = "0x18F0AA0", Offset = "0x18EFCA0", Length = "0xBB")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "ClearMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_MeshInfo), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600068A")]
	public void ClearMeshInfo(bool updateMesh) { }

	[Address(RVA = "0x18F0B60", Offset = "0x18EFD60", Length = "0xF4")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600068F")]
	internal void ClearPageInfo() { }

	[Address(RVA = "0x18F0C60", Offset = "0x18EFE60", Length = "0xBD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600068D")]
	public void ClearUnusedVertices(MaterialReference[] materials) { }

	[Address(RVA = "0x18F0D90", Offset = "0x18EFF90", Length = "0x52F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000690")]
	public TMP_MeshInfo[] CopyMeshInfoVertexData() { }

	[Address(RVA = "0x18F12C0", Offset = "0x18F04C0", Length = "0xBA")]
	[CalledBy(Type = typeof(TMP_Text), Member = "set_isVolumetricText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_MeshInfo), Member = "ResizeMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600068C")]
	public void ResetVertexLayout(bool isVolumetric) { }

	[Address(RVA = "0x768800", Offset = "0x767A00", Length = "0x7C")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000691")]
	public static void Resize(ref T[] array, int size) { }

	[Address(RVA = "0x768880", Offset = "0x767A80", Length = "0xA4")]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000692")]
	public static void Resize(ref T[] array, int size, bool isBlockAllocated) { }

}

