namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Camera/GraphicsSettings.h")]
[StaticAccessor("GetGraphicsSettings()", StaticAccessorType::Dot (0))]
[Token(Token = "0x20002C7")]
public sealed class GraphicsSettings : object
{
	[CompilerGenerated]
	[Token(Token = "0x20002C8")]
	private sealed class <>c
	{
		[Token(Token = "0x4000817")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x1992050", Offset = "0x1991250", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000DAF")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DB0")]
		public <>c() { }

		[Address(RVA = "0x1991E60", Offset = "0x1991060", Length = "0x180")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(GraphicsSettings), Member = "get_currentRenderPipeline", ReturnType = typeof(RenderPipelineAsset))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(GraphicsSettings), Member = "Internal_GetSettingsForRenderPipeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000DB1")]
		internal RenderPipelineGlobalSettings <.cctor>b__93_0() { }

	}

	[Token(Token = "0x4000816")]
	private static Lazy<RenderPipelineGlobalSettings> s_CurrentRenderPipelineGlobalSettings; //Field offset: 0x0

	[Token(Token = "0x17000229")]
	public static RenderPipelineAsset currentRenderPipeline
	{
		[Address(RVA = "0x1982600", Offset = "0x1981800", Length = "0xF9")]
		[CalledBy(Type = typeof(GraphicsSettings), Member = "Internal_GetCurrentRenderPipelineGlobalSettings", ReturnType = typeof(RenderPipelineGlobalSettings))]
		[CalledBy(Type = "RLD.RLDApp", Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.RLDApp", Member = "DetectRenderPipeline", ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.RLDApp", Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<>c), Member = "<.cctor>b__93_0", ReturnType = typeof(RenderPipelineGlobalSettings))]
		[CalledBy(Type = typeof(GraphicsSettings), Member = "GetDefaultShader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefaultShaderType)}, ReturnType = typeof(Shader))]
		[CalledBy(Type = typeof(GraphicsSettings), Member = "GetDefaultMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefaultMaterialType)}, ReturnType = typeof(Material))]
		[CalledBy(Type = typeof(RenderPipelineManager), Member = "CleanupRenderPipeline", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "get_scriptableRenderPipelineActive", ReturnType = typeof(bool))]
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000DA6")]
		 get { } //Length: 249
	}

	[NativeName("CurrentRenderPipeline")]
	[Token(Token = "0x17000228")]
	private static ScriptableObject INTERNAL_currentRenderPipeline
	{
		[Address(RVA = "0x1982580", Offset = "0x1981780", Length = "0x75")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000DA5")]
		private get { } //Length: 117
	}

	[Token(Token = "0x17000227")]
	public static bool lightsUseLinearIntensity
	{
		[Address(RVA = "0x1982700", Offset = "0x1981900", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000DA4")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x1982440", Offset = "0x1981640", Length = "0x101")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Lazy`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DAC")]
	private static GraphicsSettings() { }

	[Address(RVA = "0x1982600", Offset = "0x1981800", Length = "0xF9")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "get_scriptableRenderPipelineActive", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GraphicsSettings), Member = "GetDefaultMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefaultMaterialType)}, ReturnType = typeof(Material))]
	[CalledBy(Type = typeof(GraphicsSettings), Member = "GetDefaultShader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefaultShaderType)}, ReturnType = typeof(Shader))]
	[CalledBy(Type = typeof(<>c), Member = "<.cctor>b__93_0", ReturnType = typeof(RenderPipelineGlobalSettings))]
	[CalledBy(Type = typeof(RenderPipelineManager), Member = "CleanupRenderPipeline", ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.RLDApp", Member = "DetectRenderPipeline", ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.RLDApp", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GraphicsSettings), Member = "Internal_GetCurrentRenderPipelineGlobalSettings", ReturnType = typeof(RenderPipelineGlobalSettings))]
	[CalledBy(Type = "RLD.RLDApp", Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000DA6")]
	public static RenderPipelineAsset get_currentRenderPipeline() { }

	[Address(RVA = "0x1982580", Offset = "0x1981780", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000DA5")]
	private static ScriptableObject get_INTERNAL_currentRenderPipeline() { }

	[Address(RVA = "0x1982550", Offset = "0x1981750", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000DAD")]
	private static IntPtr get_INTERNAL_currentRenderPipeline_Injected() { }

	[Address(RVA = "0x1982700", Offset = "0x1981900", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000DA4")]
	public static bool get_lightsUseLinearIntensity() { }

	[Address(RVA = "0x1981A50", Offset = "0x1980C50", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GraphicsSettings), Member = "get_currentRenderPipeline", ReturnType = typeof(RenderPipelineAsset))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[ContainsInvalidInstructions]
	[RequiredByNativeCode]
	[Token(Token = "0x6000DA9")]
	[VisibleToOtherModules]
	internal static Material GetDefaultMaterial(DefaultMaterialType type) { }

	[Address(RVA = "0x1981D50", Offset = "0x1980F50", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GraphicsSettings), Member = "get_currentRenderPipeline", ReturnType = typeof(RenderPipelineAsset))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[ContainsInvalidInstructions]
	[RequiredByNativeCode]
	[Token(Token = "0x6000DA8")]
	[VisibleToOtherModules]
	internal static Shader GetDefaultShader(DefaultShaderType type) { }

	[Address(RVA = "0x1982090", Offset = "0x1981290", Length = "0x31")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "get_supportsDeferredShading", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "get_supportsDepthNormals", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("GetShaderModeScript")]
	[Token(Token = "0x6000DA7")]
	public static BuiltinShaderMode GetShaderMode(BuiltinShaderType type) { }

	[Address(RVA = "0x19820D0", Offset = "0x19812D0", Length = "0x14F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GraphicsSettings), Member = "get_currentRenderPipeline", ReturnType = typeof(RenderPipelineAsset))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GraphicsSettings), Member = "Internal_GetSettingsForRenderPipeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000DAB")]
	private static RenderPipelineGlobalSettings Internal_GetCurrentRenderPipelineGlobalSettings() { }

	[Address(RVA = "0x1982260", Offset = "0x1981460", Length = "0x1D5")]
	[CalledBy(Type = typeof(<>c), Member = "<.cctor>b__93_0", ReturnType = typeof(RenderPipelineGlobalSettings))]
	[CalledBy(Type = typeof(GraphicsSettings), Member = "Internal_GetCurrentRenderPipelineGlobalSettings", ReturnType = typeof(RenderPipelineGlobalSettings))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18195A050")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("GetSettingsForRenderPipeline")]
	[Token(Token = "0x6000DAA")]
	private static object Internal_GetSettingsForRenderPipeline(string renderpipelineName) { }

	[Address(RVA = "0x1982220", Offset = "0x1981420", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000DAE")]
	private static IntPtr Internal_GetSettingsForRenderPipeline_Injected(ref ManagedSpanWrapper renderpipelineName) { }

}

