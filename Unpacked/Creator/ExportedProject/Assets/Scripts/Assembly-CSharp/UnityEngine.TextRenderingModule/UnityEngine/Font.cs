namespace UnityEngine;

[NativeClass("TextRendering::Font")]
[NativeHeader("Modules/TextRendering/Public/Font.h")]
[NativeHeader("Modules/TextRendering/Public/FontImpl.h")]
[StaticAccessor("TextRenderingPrivate", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x200000F")]
public sealed class Font : object
{
	[Token(Token = "0x2000010")]
	internal sealed class FontTextureRebuildCallback : MulticastDelegate
	{

		[Address(RVA = "0x2D8810", Offset = "0x2D7A10", Length = "0xA5")]
		[CallerCount(Count = 285)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000041")]
		public FontTextureRebuildCallback(object object, IntPtr method) { }

		[Address(RVA = "0x2BC000", Offset = "0x2BB200", Length = "0x16A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180288CC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802891B0")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000042")]
		public override void Invoke() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000053")]
	private static Action<Font> textureRebuilt; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000054")]
	private FontTextureRebuildCallback m_FontTextureRebuildCallback; //Field offset: 0x18

	[Token(Token = "0x14000001")]
	public static event Action<Font> textureRebuilt
	{
		[Address(RVA = "0x1A720F0", Offset = "0x1A712F0", Length = "0xD7")]
		[CalledBy(Type = "UnityEngine.UI.FontUpdateTracker", Member = "TrackText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Text"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600002B")]
		 add { } //Length: 215
		[Address(RVA = "0x1A724D0", Offset = "0x1A716D0", Length = "0xD7")]
		[CalledBy(Type = "UnityEngine.UI.FontUpdateTracker", Member = "UntrackText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Text"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600002C")]
		 remove { } //Length: 215
	}

	[Token(Token = "0x1700000A")]
	public bool dynamic
	{
		[Address(RVA = "0x1A72210", Offset = "0x1A71410", Length = "0x76")]
		[CalledBy(Type = "UnityEngine.UI.Text", Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.UI.Text", Member = "GetGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(TextGenerationSettings))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600002E")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700000B")]
	public int fontSize
	{
		[Address(RVA = "0x1A722D0", Offset = "0x1A714D0", Length = "0x76")]
		[CalledBy(Type = "UnityEngine.UI.Text", Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.GUIStyle", typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600002F")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000009")]
	public Material material
	{
		[Address(RVA = "0x1A72390", Offset = "0x1A71590", Length = "0x135")]
		[CalledBy(Type = "UnityEngine.UI.Text", Member = "get_mainTexture", ReturnType = typeof(Texture))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600002D")]
		 get { } //Length: 309
	}

	[Address(RVA = "0x1A72090", Offset = "0x1A71290", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Font), Member = "Internal_CreateFont", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000030")]
	public Font() { }

	[Address(RVA = "0x1A720F0", Offset = "0x1A712F0", Length = "0xD7")]
	[CalledBy(Type = "UnityEngine.UI.FontUpdateTracker", Member = "TrackText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Text"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600002B")]
	public static void add_textureRebuilt(Action<Font> value) { }

	[Address(RVA = "0x1A72210", Offset = "0x1A71410", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.UI.Text", Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UI.Text", Member = "GetGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(TextGenerationSettings))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002E")]
	public bool get_dynamic() { }

	[Address(RVA = "0x1A721D0", Offset = "0x1A713D0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003B")]
	private static bool get_dynamic_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1A722D0", Offset = "0x1A714D0", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.UI.Text", Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.GUIStyle", typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002F")]
	public int get_fontSize() { }

	[Address(RVA = "0x1A72290", Offset = "0x1A71490", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003C")]
	private static int get_fontSize_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1A72390", Offset = "0x1A71590", Length = "0x135")]
	[CalledBy(Type = "UnityEngine.UI.Text", Member = "get_mainTexture", ReturnType = typeof(Texture))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002D")]
	public Material get_material() { }

	[Address(RVA = "0x1A72350", Offset = "0x1A71550", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003A")]
	private static IntPtr get_material_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1A718D0", Offset = "0x1A70AD0", Length = "0xB1")]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "CalculateLengthOfDropdownText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "SetFiltersPostProcessing", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromDocs]
	[Token(Token = "0x6000038")]
	public bool GetCharacterInfo(char ch, out CharacterInfo info, int size) { }

	[Address(RVA = "0x1A71990", Offset = "0x1A70B90", Length = "0xA9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("TextRenderingPrivate::GetCharacterInfo", HasExplicitThis = True)]
	[Token(Token = "0x6000037")]
	public bool GetCharacterInfo(char ch, out CharacterInfo info, int size, FontStyle style) { }

	[Address(RVA = "0x1A71860", Offset = "0x1A70A60", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003F")]
	private static bool GetCharacterInfo_Injected(IntPtr _unity_self, char ch, out CharacterInfo info, int size, FontStyle style) { }

	[Address(RVA = "0x1A71A40", Offset = "0x1A70C40", Length = "0x2A")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(int), typeof(int), "UnityEngine.TextCore.LowLevel.GlyphRenderMode", typeof(int), typeof(int), "UnityEngine.TextCore.Text.AtlasPopulationMode", typeof(bool)}, ReturnType = "UnityEngine.TextCore.Text.FontAsset")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings", Member = "get_fallbackOSFontAssets", ReturnType = "System.Collections.Generic.List`1<FontAsset>")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings", Member = "GetOSFontAssetList", ReturnType = "System.Collections.Generic.List`1<FontAsset>")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings", Member = "GetGlobalFallbacks", ReturnType = "System.IntPtr[]")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000035")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal static String[] GetOSFallbacks() { }

	[Address(RVA = "0x1A71A70", Offset = "0x1A70C70", Length = "0x2A")]
	[CalledBy(Type = "TMPro.TMP_DynamicFontAssetUtilities", Member = "InitializeSystemFontReferenceCache", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000034")]
	public static String[] GetPathsToOSFonts() { }

	[Address(RVA = "0x1A71B70", Offset = "0x1A70D70", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000033")]
	private bool HasCharacter(int c) { }

	[Address(RVA = "0x1A71AE0", Offset = "0x1A70CE0", Length = "0x84")]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Event"}, ReturnType = "UnityEngine.UI.InputField+EditState")]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "IsValidChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.GUI", Member = "HandleTextFieldEventForDesktop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), "UnityEngine.GUIContent", typeof(bool), typeof(int), "UnityEngine.GUIStyle", "UnityEngine.TextEditor"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000032")]
	public bool HasCharacter(char c) { }

	[Address(RVA = "0x1A71AA0", Offset = "0x1A70CA0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003D")]
	private static bool HasCharacter_Injected(IntPtr _unity_self, int c) { }

	[Address(RVA = "0x1A71C50", Offset = "0x1A70E50", Length = "0x17C")]
	[CalledBy(Type = typeof(Font), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000036")]
	private static void Internal_CreateFont(Font self, string name) { }

	[Address(RVA = "0x1A71C00", Offset = "0x1A70E00", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003E")]
	private static void Internal_CreateFont_Injected(Font self, ref ManagedSpanWrapper name) { }

	[Address(RVA = "0x1A71DD0", Offset = "0x1A70FD0", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000031")]
	internal static void InvokeTextureRebuilt_Internal(Font font) { }

	[Address(RVA = "0x1A724D0", Offset = "0x1A716D0", Length = "0xD7")]
	[CalledBy(Type = "UnityEngine.UI.FontUpdateTracker", Member = "UntrackText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Text"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600002C")]
	public static void remove_textureRebuilt(Action<Font> value) { }

	[Address(RVA = "0x1A71EC0", Offset = "0x1A710C0", Length = "0x1C9")]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "CalculateLengthOfDropdownText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "SetFiltersPostProcessing", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000039")]
	public void RequestCharactersInTexture(string characters, int size, FontStyle style) { }

	[Address(RVA = "0x1A71E50", Offset = "0x1A71050", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000040")]
	private static void RequestCharactersInTexture_Injected(IntPtr _unity_self, ref ManagedSpanWrapper characters, int size, FontStyle style) { }

}

