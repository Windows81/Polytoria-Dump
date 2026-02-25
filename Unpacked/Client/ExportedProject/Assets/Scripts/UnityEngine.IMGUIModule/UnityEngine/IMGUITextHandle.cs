namespace UnityEngine;

[Token(Token = "0x2000022")]
internal class IMGUITextHandle : TextHandle
{
	[Token(Token = "0x2000023")]
	public class TextHandleTuple
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000D2")]
		public float lastTimeUsed; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40000D3")]
		public int hashCode; //Field offset: 0x14

		[Address(RVA = "0x19C92A0", Offset = "0x19C84A0", Length = "0x37")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600023D")]
		public TextHandleTuple(float lastTimeUsed, int hashCode) { }

	}

	[Token(Token = "0x40000CD")]
	private static Dictionary<Int32, IMGUITextHandle> textHandles; //Field offset: 0x0
	[Token(Token = "0x40000CE")]
	private static LinkedList<TextHandleTuple> textHandlesTuple; //Field offset: 0x8
	[Token(Token = "0x40000CF")]
	private static float lastCleanupTime; //Field offset: 0x10
	[Token(Token = "0x40000D0")]
	private static int newHandlesSinceCleanup; //Field offset: 0x14
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40000CC")]
	internal LinkedListNode<TextHandleTuple> tuple; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40000D1")]
	internal bool isCachedOnNative; //Field offset: 0xC0

	[Address(RVA = "0x19C2840", Offset = "0x19C1A40", Length = "0xFC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600023C")]
	private static IMGUITextHandle() { }

	[Address(RVA = "0x19C2940", Offset = "0x19C1B40", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x600023B")]
	public IMGUITextHandle() { }

	[Address(RVA = "0x19C16F0", Offset = "0x19C08F0", Length = "0x249")]
	[CalledBy(Type = typeof(IMGUITextHandle), Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", typeof(bool), typeof(Boolean&)}, ReturnType = typeof(IMGUITextHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(GUIStyle), Member = "Internal_DestroyTextGenerator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "RemoveTextInfoFromPermanentCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LinkedList`1), Member = "RemoveFirst", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000235")]
	private static void ClearUnusedTextHandles() { }

	[Address(RVA = "0x19C1940", Offset = "0x19C0B40", Length = "0x58C")]
	[CalledBy(Type = typeof(IMGUITextHandle), Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(Rect), typeof(string), typeof(Color32)}, ReturnType = typeof(IMGUITextHandle))]
	[CalledBy(Type = typeof(IMGUITextHandle), Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(Rect), typeof(string), typeof(Color32), typeof(Boolean&)}, ReturnType = typeof(IMGUITextHandle))]
	[CalledBy(Type = typeof(IMGUITextHandle), Member = "GetLineHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle)}, ReturnType = typeof(float))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Font), Member = "get_fontSize", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextGeneratorUtilities", Member = "LegacyStyleToNewStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontStyle)}, ReturnType = typeof(FontStyles))]
	[Calls(Type = typeof(TextSettings), Member = "GetCachedFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(FontAsset))]
	[Calls(Type = typeof(FontAsset), Member = "IsBitmap", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002400")]
	[Calls(Type = typeof(GUIStyle), Member = "get_imagePosition", ReturnType = typeof(ImagePosition))]
	[Calls(Type = typeof(GUIStyle), Member = "get_alignment", ReturnType = typeof(TextAnchor))]
	[Calls(Type = typeof(GUIStyle), Member = "get_fontStyle", ReturnType = typeof(FontStyle))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextGeneratorUtilities", Member = "LegacyAlignmentToNewAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAnchor)}, ReturnType = "UnityEngine.TextCore.Text.TextAlignment")]
	[Calls(Type = typeof(GUIStyle), Member = "get_clipping", ReturnType = typeof(TextClipping))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextGenerationSettings", Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC070")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(GUIStyle), Member = "get_fontSize", ReturnType = typeof(int))]
	[Calls(Type = typeof(GUIStyle), Member = "get_wordWrap", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GUIStyle), Member = "GetDefaultFont", ReturnType = typeof(Font))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GUIStyle), Member = "get_font", ReturnType = typeof(Font))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(QualitySettings), Member = "get_activeColorSpace", ReturnType = typeof(ColorSpace))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(GUIStyle), Member = "get_richText", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000239")]
	private static void ConvertGUIStyleToGenerationSettings(TextGenerationSettings settings, GUIStyle style, Color textColor, string text, Rect rect) { }

	[Address(RVA = "0x19C1EF0", Offset = "0x19C10F0", Length = "0x9E")]
	[CalledBy(Type = typeof(GUIStyle), Member = "EmptyManagedCache", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedList`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000231")]
	internal static void EmptyManagedCache() { }

	[Address(RVA = "0x19C1F90", Offset = "0x19C1190", Length = "0x141")]
	[CalledBy(Type = typeof(GUIStyle), Member = "get_lineHeight", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(GUIStyle), Member = "GetCursorPixelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(int)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(GUIStyle), Member = "GetLineHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(Single&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_settings", ReturnType = "UnityEngine.TextCore.Text.TextGenerationSettings")]
	[Calls(Type = typeof(IMGUITextHandle), Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", typeof(GUIStyle), typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetLineHeightDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings"}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000238")]
	internal static float GetLineHeight(GUIStyle style) { }

	[Address(RVA = "0x19C20E0", Offset = "0x19C12E0", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000237")]
	protected virtual float GetPixelsPerPoint() { }

	[Address(RVA = "0x19C22A0", Offset = "0x19C14A0", Length = "0x14C")]
	[CalledBy(Type = typeof(GUIStyle), Member = "GetCursorPixelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(int)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(GUIStyle), Member = "GetPreferredSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Rect)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(GUIStyle), Member = "GetDimensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(Color), typeof(string), typeof(Rect), typeof(Vector2&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditor), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditor), Member = "UpdateTextHandle", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_settings", ReturnType = "UnityEngine.TextCore.Text.TextGenerationSettings")]
	[Calls(Type = typeof(IMGUITextHandle), Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", typeof(GUIStyle), typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IMGUITextHandle), Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", typeof(bool), typeof(Boolean&)}, ReturnType = typeof(IMGUITextHandle))]
	[Token(Token = "0x6000232")]
	internal static IMGUITextHandle GetTextHandle(GUIStyle style, Rect position, string content, Color32 textColor) { }

	[Address(RVA = "0x19C2140", Offset = "0x19C1340", Length = "0x153")]
	[CalledBy(Type = typeof(GUIStyle), Member = "GetMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(Color), typeof(string), typeof(Rect), typeof(MeshInfoBindings[]&), typeof(Vector2&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_settings", ReturnType = "UnityEngine.TextCore.Text.TextGenerationSettings")]
	[Calls(Type = typeof(IMGUITextHandle), Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", typeof(GUIStyle), typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IMGUITextHandle), Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", typeof(bool), typeof(Boolean&)}, ReturnType = typeof(IMGUITextHandle))]
	[Token(Token = "0x6000233")]
	internal static IMGUITextHandle GetTextHandle(GUIStyle style, Rect position, string content, Color32 textColor, ref bool isCached) { }

	[Address(RVA = "0x19C23F0", Offset = "0x19C15F0", Length = "0x40A")]
	[CalledBy(Type = typeof(IMGUITextHandle), Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(Rect), typeof(string), typeof(Color32)}, ReturnType = typeof(IMGUITextHandle))]
	[CalledBy(Type = typeof(IMGUITextHandle), Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(Rect), typeof(string), typeof(Color32), typeof(Boolean&)}, ReturnType = typeof(IMGUITextHandle))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "UpdatePreferredSize", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "UpdateWithHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IMGUITextHandle), Member = "ClearUnusedTextHandles", ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedList`1), Member = "AddLast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.LinkedListNode`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(LinkedList`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.LinkedListNode`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000236")]
	private static IMGUITextHandle GetTextHandle(TextGenerationSettings settings, bool isCalledFromNative, ref bool isCached) { }

	[Address(RVA = "0x19C2800", Offset = "0x19C1A00", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600023A")]
	private static TextOverflowMode LegacyClippingToNewOverflow(TextClipping clipping) { }

	[Address(RVA = "0x19C2820", Offset = "0x19C1A20", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000234")]
	private static bool ShouldCleanup(float currentTime, float lastTime, float cleanupThreshold) { }

}

