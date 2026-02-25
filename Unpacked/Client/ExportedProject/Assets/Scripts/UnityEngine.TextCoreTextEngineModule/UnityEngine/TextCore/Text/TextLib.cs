namespace UnityEngine.TextCore.Text;

[NativeHeader("Modules/TextCoreTextEngine/Native/TextLib.h")]
[Token(Token = "0x2000056")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "Unity.UIElements.PlayModeTests"})]
internal class TextLib
{
	[Token(Token = "0x2000057")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x7CE590", Offset = "0x7CD790", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000251")]
		public static IntPtr ConvertToNative(TextLib textLib) { }

	}

	[Token(Token = "0x4000346")]
	public const int k_unconstrainedScreenSize = -1; //Field offset: 0x0
	[Token(Token = "0x4000348")]
	public static Func<TextAsset> GetICUAssetEditorDelegate; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000347")]
	private readonly IntPtr m_Ptr; //Field offset: 0x10

	[Address(RVA = "0x1A6A8C0", Offset = "0x1A69AC0", Length = "0xD3")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "InitTextLib", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000246")]
	public TextLib(Byte[] icuData) { }

	[Address(RVA = "0x1A69950", Offset = "0x1A68B50", Length = "0x3D")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ATGFindIntersectingLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = "System.ValueTuple`2<TagType, String>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(Name = "TextLib::FindIntersectingLink")]
	[Token(Token = "0x600024C")]
	public static int FindIntersectingLink(Vector2 point, IntPtr textGenerationInfo) { }

	[Address(RVA = "0x1A69900", Offset = "0x1A68B00", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000250")]
	private static int FindIntersectingLink_Injected(in Vector2 point, IntPtr textGenerationInfo) { }

	[Address(RVA = "0x1A69A90", Offset = "0x1A68C90", Length = "0x194")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "UpdateNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.ValueTuple`2<NativeTextInfo, Boolean>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000248")]
	public NativeTextInfo GenerateText(NativeTextGenerationSettings settings, IntPtr textGenerationInfo) { }

	[Address(RVA = "0x1A69A00", Offset = "0x1A68C00", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(Name = "TextLib::GenerateTextMesh", IsThreadSafe = True)]
	[Token(Token = "0x600024A")]
	private NativeTextInfo GenerateTextInternal(NativeTextGenerationSettings settings, IntPtr textGenerationInfo) { }

	[Address(RVA = "0x1A69990", Offset = "0x1A68B90", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600024E")]
	private static void GenerateTextInternal_Injected(IntPtr _unity_self, in NativeTextGenerationSettings settings, IntPtr textGenerationInfo, out NativeTextInfo ret) { }

	[Address(RVA = "0x1A69C70", Offset = "0x1A68E70", Length = "0xBC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000247")]
	private static IntPtr GetInstance(Byte[] icuData) { }

	[Address(RVA = "0x1A69C30", Offset = "0x1A68E30", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600024D")]
	private static IntPtr GetInstance_Injected(ref ManagedSpanWrapper icuData) { }

	[Address(RVA = "0x1A69DA0", Offset = "0x1A68FA0", Length = "0x7A")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ComputeNativeTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&), typeof(float), typeof(float), "System.Nullable`1<Single>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(Name = "TextLib::MeasureText")]
	[Token(Token = "0x600024B")]
	public Vector2 MeasureText(NativeTextGenerationSettings settings, IntPtr textGenerationInfo) { }

	[Address(RVA = "0x1A69D30", Offset = "0x1A68F30", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600024F")]
	private static void MeasureText_Injected(IntPtr _unity_self, in NativeTextGenerationSettings settings, IntPtr textGenerationInfo, out Vector2 ret) { }

	[Address(RVA = "0x1A69E20", Offset = "0x1A69020", Length = "0xA9C")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ProcessMeshInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeTextInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Glyph), Member = "get_atlasIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(FontAsset), Member = "TryAddGlyphInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "get_atlasHeight", ReturnType = typeof(int))]
	[Calls(Type = typeof(FontAsset), Member = "get_atlasWidth", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009740")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(FontAsset), Member = "GetFontAssetByID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(FontAsset))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400330")]
	[CallsDeduplicatedMethods(Count = 16)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000249")]
	public void ProcessMeshInfos(NativeTextInfo textInfo, NativeTextGenerationSettings settings) { }

}

