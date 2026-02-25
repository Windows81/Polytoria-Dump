namespace UnityEngine;

[ExtensionOfNativeClass]
[NativeClass(null)]
[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
[RequiredByNativeCode]
[Token(Token = "0x2000157")]
public class ScriptableObject : object
{

	[Address(RVA = "0x196EFE0", Offset = "0x196E1E0", Length = "0x6E")]
	[CallerCount(Count = 36)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60009E9")]
	public ScriptableObject() { }

	[Address(RVA = "0x196EE80", Offset = "0x196E080", Length = "0x5F")]
	[CalledBy(Type = typeof(ScriptableObject), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "InitBundles", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessManager", Member = "ReloadBaseTypes", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessProfile", Member = "AddSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = "UnityEngine.Rendering.PostProcessing.PostProcessEffectSettings")]
	[CalledBy(Type = "Unity.Properties.TypeUtility+TypeConstructor`1", Member = "CreateScriptableObjectInstance", ReturnType = "T")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60009EA")]
	public static ScriptableObject CreateInstance(Type type) { }

	[Address(RVA = "0x758B90", Offset = "0x757D90", Length = "0x9F")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "CreateFontAssetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Font", typeof(int), "UnityEngine.TextCore.LowLevel.GlyphRenderMode", typeof(int), typeof(int), "UnityEngine.TextCore.Text.AtlasPopulationMode", typeof(bool)}, ReturnType = "UnityEngine.TextCore.Text.FontAsset")]
	[CalledBy(Type = "UnityEngine.UIElements.FilterFunctionDefinitionUtils", Member = "CreateBlurFilterFunctionDefinition", ReturnType = "UnityEngine.UIElements.FilterFunctionDefinition")]
	[CalledBy(Type = "UnityEngine.UIElements.FilterFunctionDefinitionUtils", Member = "CreateColorEffectFilterFunctionDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.FilterFunctionType"}, ReturnType = "UnityEngine.UIElements.FilterFunctionDefinition")]
	[CalledBy(Type = "UnityEngine.UIElements.PanelTextSettings", Member = "get_defaultPanelTextSettings", ReturnType = "UnityEngine.UIElements.PanelTextSettings")]
	[CalledBy(Type = "UnityEngine.UIElements.PanelTextSettings", Member = "InitializeDefaultPanelTextSettingsIfNull", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerConnection), Member = "get_instance", ReturnType = typeof(PlayerConnection))]
	[CalledBy(Type = typeof(PlayerConnection), Member = "CreateInstance", ReturnType = typeof(PlayerConnection))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "CreateFontAssetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Font", typeof(int), "UnityEngine.TextCore.LowLevel.GlyphRenderMode", typeof(int), typeof(int), "TMPro.AtlasPopulationMode", typeof(bool)}, ReturnType = "TMPro.TMP_FontAsset")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessVolume", Member = "get_profile", ReturnType = "UnityEngine.Rendering.PostProcessing.PostProcessProfile")]
	[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.GUIStyle", typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.RuntimeTextSettings", Member = "get_defaultTextSettings", ReturnType = "UnityEngine.RuntimeTextSettings")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(ScriptableObject))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009EB")]
	public static T CreateInstance() { }

	[Address(RVA = "0x196EFA0", Offset = "0x196E1A0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x60009EC")]
	private static void CreateScriptableObject(ScriptableObject self) { }

	[Address(RVA = "0x196EF30", Offset = "0x196E130", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(Name = "Scripting::CreateScriptableObjectWithType", IsFreeFunction = True, ThrowsException = True)]
	[Token(Token = "0x60009ED")]
	internal static ScriptableObject CreateScriptableObjectInstanceFromType(Type type, bool applyDefaultsAndReset) { }

	[Address(RVA = "0x196EEE0", Offset = "0x196E0E0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60009EE")]
	private static IntPtr CreateScriptableObjectInstanceFromType_Injected(Type type, bool applyDefaultsAndReset) { }

}

