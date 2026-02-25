namespace UnityEngine;

[NativeHeader("Runtime/Export/Debug/Debug.bindings.h")]
[NativeHeader("Runtime/Diagnostics/IntegrityCheck.h")]
[NativeHeader("Runtime/Diagnostics/Validation.h")]
[Token(Token = "0x200008A")]
public class Debug
{
	[Token(Token = "0x400019A")]
	internal static readonly ILogger s_DefaultLogger; //Field offset: 0x0
	[Token(Token = "0x400019B")]
	internal static ILogger s_Logger; //Field offset: 0x8

	[Token(Token = "0x17000065")]
	public static ILogger unityLogger
	{
		[Address(RVA = "0x1926A30", Offset = "0x1925C30", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x600024A")]
		 get { } //Length: 79
	}

	[Address(RVA = "0x1926920", Offset = "0x1925B20", Length = "0x107")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Logger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000264")]
	private static Debug() { }

	[Address(RVA = "0x1925020", Offset = "0x1924220", Length = "0xC5")]
	[CallerCount(Count = 56)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Conditional("UNITY_ASSERTIONS")]
	[Token(Token = "0x600025E")]
	public static void Assert(bool condition, string message) { }

	[Address(RVA = "0x1924F40", Offset = "0x1924140", Length = "0xD0")]
	[CallerCount(Count = 287)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Conditional("UNITY_ASSERTIONS")]
	[Token(Token = "0x600025D")]
	public static void Assert(bool condition) { }

	[Address(RVA = "0x1924E60", Offset = "0x1924060", Length = "0xD7")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "GenerateTextMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.TextCore.Text.TextInfo"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), "UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.TextCore.Text.TextInfo"}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B65E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Conditional("UNITY_ASSERTIONS")]
	[Token(Token = "0x600025F")]
	public static void AssertFormat(bool condition, string format, Object[] args) { }

	[Address(RVA = "0x19250F0", Offset = "0x19242F0", Length = "0x2A")]
	[CalledBy(Type = "RLD.GizmoBehaviour", Member = "ThrowReqBehaviourExeception", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.RLDApp", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.RLDApp", Member = "DetectRenderPipeline", ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.RTFocusCamera", Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("PauseEditor")]
	[Token(Token = "0x600024F")]
	public static void Break() { }

	[Address(RVA = "0x1925120", Offset = "0x1924320", Length = "0x280")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000262")]
	internal static bool CallOverridenDebugHandler(Exception exception, object obj) { }

	[Address(RVA = "0x19254C0", Offset = "0x19246C0", Length = "0xFB")]
	[CalledBy(Type = "Mirror.NetworkTransformHybrid", Member = "OnDeserializeBaseline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkReader", typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkTransformHybrid", Member = "OnDeserializeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkReader", typeof(byte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromDocs]
	[Token(Token = "0x600024B")]
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration) { }

	[Address(RVA = "0x1925420", Offset = "0x1924620", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("DebugDrawLine", IsThreadSafe = True)]
	[Token(Token = "0x600024C")]
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration, bool depthTest) { }

	[Address(RVA = "0x19253B0", Offset = "0x19245B0", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000265")]
	private static void DrawLine_Injected(in Vector3 start, in Vector3 end, in Color color, float duration, bool depthTest) { }

	[Address(RVA = "0x1925730", Offset = "0x1924930", Length = "0x17A")]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "IsGrounded", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromDocs]
	[Token(Token = "0x600024D")]
	public static void DrawRay(Vector3 start, Vector3 dir, Color color) { }

	[Address(RVA = "0x19255C0", Offset = "0x19247C0", Length = "0x161")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600024E")]
	public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration, bool depthTest) { }

	[Address(RVA = "0x1925900", Offset = "0x1924B00", Length = "0x1AE")]
	[CalledBy(Type = typeof(StackTraceUtility), Member = "ExtractStackTrace", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x6000250")]
	public static int ExtractStackTraceNoAlloc(Byte* buffer, int bufferMax, string projectFolder) { }

	[Address(RVA = "0x19258B0", Offset = "0x1924AB0", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000266")]
	private static int ExtractStackTraceNoAlloc_Injected(Byte* buffer, int bufferMax, ref ManagedSpanWrapper projectFolder) { }

	[Address(RVA = "0x1926A30", Offset = "0x1925C30", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600024A")]
	public static ILogger get_unityLogger() { }

	[Address(RVA = "0x1925AB0", Offset = "0x1924CB0", Length = "0x164")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000263")]
	internal static bool IsLoggingEnabled() { }

	[Address(RVA = "0x1926790", Offset = "0x1925990", Length = "0xC6")]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "UpgradeGlyphAdjustmentTableToFontFeatureTable", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_SpriteAsset", Member = "UpgradeSpriteAsset", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B65E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000252")]
	public static void Log(object message, object context) { }

	[Address(RVA = "0x1926860", Offset = "0x1925A60", Length = "0xB2")]
	[CallerCount(Count = 146)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000251")]
	public static void Log(object message) { }

	[Address(RVA = "0x1925CF0", Offset = "0x1924EF0", Length = "0xB5")]
	[CalledBy(Type = "UnityEngine.UIElements.StyleValueExtensions", Member = "ToScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleKeyword"}, ReturnType = "UnityEngine.UIElements.Scale")]
	[CalledBy(Type = "UnityEngine.UIElements.ComputedStyle", Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleSheets.StyleValue", "UnityEngine.UIElements.ComputedStyle&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.ComputedStyle", Member = "ApplyStyleValueManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleSheets.StyleValueManaged", "UnityEngine.UIElements.ComputedStyle&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.ComputedStyle", Member = "ApplyInitialValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleSheets.StylePropertyId"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleValueExtensions", Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Length"}, ReturnType = "UnityEngine.UIElements.Layout.LayoutValue")]
	[CalledBy(Type = "UnityEngine.UIElements.StyleValueExtensions", Member = "ToLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleKeyword"}, ReturnType = "UnityEngine.UIElements.Length")]
	[CalledBy(Type = "UnityEngine.UIElements.StyleValueExtensions", Member = "ToRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleKeyword"}, ReturnType = "UnityEngine.UIElements.Rotate")]
	[CalledBy(Type = "UnityEngine.UIElements.StyleValueExtensions", Member = "ToTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleKeyword"}, ReturnType = "UnityEngine.UIElements.Translate")]
	[CalledBy(Type = "UnityEngine.UIElements.StyleValueExtensions", Member = "ToTextAutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleKeyword"}, ReturnType = "UnityEngine.UIElements.TextAutoSize")]
	[CalledBy(Type = "UnityEngine.UIElements.StyleValueExtensions", Member = "ToLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleLength"}, ReturnType = "UnityEngine.UIElements.Length")]
	[CalledBy(Type = "UnityEngine.UIElements.StyleVariableResolver", Member = "ValidateResolvedValues", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Assert), Member = "Fail", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
	[Conditional("UNITY_ASSERTIONS")]
	[Token(Token = "0x6000260")]
	public static void LogAssertion(object message) { }

	[Address(RVA = "0x1925C20", Offset = "0x1924E20", Length = "0xC6")]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer", Member = "Tokenize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B65E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Conditional("UNITY_ASSERTIONS")]
	[Token(Token = "0x6000261")]
	public static void LogAssertionFormat(string format, Object[] args) { }

	[Address(RVA = "0x1925F60", Offset = "0x1925160", Length = "0xC3")]
	[CallerCount(Count = 31)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B65E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000255")]
	public static void LogError(object message, object context) { }

	[Address(RVA = "0x1926030", Offset = "0x1925230", Length = "0xB2")]
	[CallerCount(Count = 440)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000254")]
	public static void LogError(object message) { }

	[Address(RVA = "0x1925E90", Offset = "0x1925090", Length = "0xC3")]
	[CalledBy(Type = "UnityEngine.UIElements.VisualTreeAsset", Member = "CloneSetupRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElementAsset", "System.Collections.Generic.Dictionary`2<Int32, List`1<VisualElementAsset>>", "UnityEngine.UIElements.CreationContext"}, ReturnType = "UnityEngine.UIElements.VisualElement")]
	[CalledBy(Type = "UnityEngine.UIElements.EnumFieldHelpers", Member = "ExtractValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IUxmlAttributes", "UnityEngine.UIElements.CreationContext", typeof(Type&), typeof(Enum&), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.EventDispatcher", Member = "HandleRecursiveState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.EventDispatchUtilities", Member = "HandleEvent_BubbleUpAllDefaultActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase", "UnityEngine.UIElements.BaseVisualElementPanel", "UnityEngine.UIElements.VisualElement", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.DynamicAtlasPage", Member = "UpdateAtlasTexture", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TemplateContainer+UxmlTraits", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", "UnityEngine.UIElements.IUxmlAttributes", "UnityEngine.UIElements.CreationContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualTreeAsset", Member = "GetUxmlObjectFactory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UxmlObjectAsset"}, ReturnType = "UnityEngine.UIElements.IBaseUxmlObjectFactory")]
	[CalledBy(Type = "UnityEngine.UIElements.VisualTreeAsset", Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElementAsset", "UnityEngine.UIElements.CreationContext"}, ReturnType = "UnityEngine.UIElements.VisualElement")]
	[CalledBy(Type = "UnityEngine.UIElements.VisualTreeAsset", Member = "<Create>g__CreateError|82_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"<>c__DisplayClass82_0&"}, ReturnType = "UnityEngine.UIElements.VisualElement")]
	[CalledBy(Type = "SoftMasking.MaterialReplacer", Member = "TryCreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = "SoftMasking.IMaterialReplacer")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B65E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000256")]
	public static void LogErrorFormat(string format, Object[] args) { }

	[Address(RVA = "0x1925DB0", Offset = "0x1924FB0", Length = "0xD2")]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheet", Member = "CheckAccess", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "UnityEngine.UIElements.StyleValueType", "UnityEngine.UIElements.StyleValueHandle"}, ReturnType = "T")]
	[CalledBy(Type = "SoftMasking.SoftMask+WarningReporter", Member = "TextureRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), "SoftMasking.SoftMask+MaterialParameters+SampleMaskResult"}, ReturnType = typeof(void))]
	[CalledBy(Type = "SoftMasking.SoftMask+WarningReporter", Member = "ImageUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Image"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextGenerator", Member = "PopulateWithErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "UnityEngine.TextGenerationSettings", typeof(GameObject)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B6680")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000257")]
	public static void LogErrorFormat(object context, string format, Object[] args) { }

	[Address(RVA = "0x19261B0", Offset = "0x19253B0", Length = "0xBE")]
	[CalledBy(Type = "Mirror.NetworkIdentity", Member = "OnStartAuthority", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Tilemaps.Tilemap", Member = "SendTilemapTileChangedCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SyncTile[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Tilemaps.Tilemap", Member = "SendLoopEndedForTileAnimationCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Vector3Int>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Discovery.NetworkDiscoveryBase`2", Member = "ProcessClientRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Request", typeof(IPEndPoint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkIdentity", Member = "OnStopAuthority", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkIdentity", Member = "OnStopLocalPlayer", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Tilemaps.Tilemap", Member = "SendTilemapPositionsChangedCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Vector3Int>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkIdentity", Member = "OnStartLocalPlayer", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkIdentity", Member = "OnStartClient", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkIdentity", Member = "OnStopServer", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkIdentity", Member = "OnStartServer", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.CanvasUpdateRegistry", Member = "PerformUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpriteRenderer), Member = "InvokeSpriteChanged", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkIdentity", Member = "OnStopClient", ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000259")]
	public static void LogException(Exception exception, object context) { }

	[Address(RVA = "0x19260F0", Offset = "0x19252F0", Length = "0xB6")]
	[CallerCount(Count = 26)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000258")]
	public static void LogException(Exception exception) { }

	[Address(RVA = "0x1926270", Offset = "0x1925470", Length = "0x2A6")]
	[CalledBy(Type = "UnityEngine.UIElements.EventDispatcher", Member = "HandleRecursiveState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.EventDispatchUtilities", Member = "HandleEvent_BubbleUpAllDefaultActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase", "UnityEngine.UIElements.BaseVisualElementPanel", "UnityEngine.UIElements.VisualElement", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DebugLogHandler), Member = "Internal_Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogType), typeof(LogOption), typeof(string), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B6680")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000253")]
	public static void LogFormat(LogType logType, LogOption logOptions, object context, string format, Object[] args) { }

	[Address(RVA = "0x19266D0", Offset = "0x19258D0", Length = "0xB5")]
	[CallerCount(Count = 198)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600025A")]
	public static void LogWarning(object message) { }

	[Address(RVA = "0x1926600", Offset = "0x1925800", Length = "0xC6")]
	[CallerCount(Count = 45)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B65E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600025B")]
	public static void LogWarning(object message, object context) { }

	[Address(RVA = "0x1926520", Offset = "0x1925720", Length = "0xD5")]
	[CalledBy(Type = "UnityEngine.UIElements.StyleComplexSelector", Member = "CachePseudoStateMasks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleSheet"}, ReturnType = typeof(void))]
	[CalledBy(Type = "SoftMasking.SoftMaskable", Member = "GetModifiedMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(Material))]
	[CalledBy(Type = "SoftMasking.SoftMaskable", Member = "SetShaderNotSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextGenerator", Member = "ValidatedSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextGenerationSettings"}, ReturnType = "UnityEngine.TextGenerationSettings")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B6680")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600025C")]
	public static void LogWarningFormat(object context, string format, Object[] args) { }

}

