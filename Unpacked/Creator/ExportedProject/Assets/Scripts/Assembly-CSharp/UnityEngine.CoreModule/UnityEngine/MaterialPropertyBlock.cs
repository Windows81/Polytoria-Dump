namespace UnityEngine;

[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Math/SphericalHarmonicsL2.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Shaders/ShaderPropertySheet.h")]
[Token(Token = "0x20000B3")]
public sealed class MaterialPropertyBlock
{
	[Token(Token = "0x20000B4")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x7CE590", Offset = "0x7CD790", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60003D3")]
		public static IntPtr ConvertToNative(MaterialPropertyBlock materialPropertyBlock) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000206")]
	internal IntPtr m_Ptr; //Field offset: 0x10

	[Address(RVA = "0x192F040", Offset = "0x192E240", Length = "0x3B")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.CommandList", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", typeof(IntPtr), typeof(IntPtr), typeof(Material)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderTreeCompositor", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderTreeManager"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderTreeManager", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BaseVisualElementPanel"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.TextureBlitter", Member = "BeginBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Part", Member = "UpdateMaterial", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PropertySheet", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003BD")]
	public MaterialPropertyBlock() { }

	[Address(RVA = "0x192E0D0", Offset = "0x192D2D0", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x60003BA")]
	private void Clear(bool keepMemory) { }

	[Address(RVA = "0x192E130", Offset = "0x192D330", Length = "0x53")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.CommandList", Member = "Reset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", typeof(Material)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice", Member = "EvaluateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderChainCommand", typeof(Material), typeof(Material), typeof(Texture), typeof(Texture), "System.Nullable`1<Rect>", typeof(float), typeof(bool), typeof(Exception&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.DepthOfFieldRenderer", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.GrainRenderer", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "RenderBuiltins", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "RenderFinalPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003BB")]
	public void Clear() { }

	[Address(RVA = "0x192E080", Offset = "0x192D280", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003D2")]
	private static void Clear_Injected(IntPtr _unity_self, bool keepMemory) { }

	[Address(RVA = "0x192E190", Offset = "0x192D390", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(Name = "MaterialPropertyBlockScripting::Create", IsFreeFunction = True)]
	[Token(Token = "0x60003B8")]
	private static IntPtr CreateImpl() { }

	[Address(RVA = "0x192E1C0", Offset = "0x192D3C0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(Name = "MaterialPropertyBlockScripting::Destroy", IsFreeFunction = True, IsThreadSafe = True)]
	[Token(Token = "0x60003B9")]
	private static void DestroyImpl(IntPtr mpb) { }

	[Address(RVA = "0x192E200", Offset = "0x192D400", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003BF")]
	private void Dispose() { }

	[Address(RVA = "0x192E290", Offset = "0x192D490", Length = "0xCE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003BE")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x192E3B0", Offset = "0x192D5B0", Length = "0x7E")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003C7")]
	public void SetBuffer(int nameID, ComputeBuffer value) { }

	[Address(RVA = "0x192E3B0", Offset = "0x192D5B0", Length = "0x7E")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NativeName("SetBufferFromScript")]
	[ThreadSafe]
	[Token(Token = "0x60003B6")]
	private void SetBufferImpl(int name, ComputeBuffer value) { }

	[Address(RVA = "0x192E360", Offset = "0x192D560", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003D0")]
	private static void SetBufferImpl_Injected(IntPtr _unity_self, int name, IntPtr value) { }

	[Address(RVA = "0x192E4F0", Offset = "0x192D6F0", Length = "0x66")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.BloomRenderer", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.VignetteRenderer", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003C4")]
	public void SetColor(int nameID, Color value) { }

	[Address(RVA = "0x192E560", Offset = "0x192D760", Length = "0x84")]
	[CalledBy(Type = "UnityEngine.UIElements.FilterFunctionDefinitionUtils", Member = "PrepareBuiltinColorEffectMaterialPropertyBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MaterialPropertyBlock), "UnityEngine.UIElements.FilterFunction"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderTreeCompositor", Member = "ApplyEffectParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PostProcessingPass", "UnityEngine.UIElements.FilterFunction", "UnityEngine.UIElements.VisualElement"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Part", Member = "UpdateMaterial", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003C3")]
	public void SetColor(string name, Color value) { }

	[Address(RVA = "0x192E480", Offset = "0x192D680", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("SetColorFromScript")]
	[ThreadSafe]
	[Token(Token = "0x60003B3")]
	private void SetColorImpl(int name, Color value) { }

	[Address(RVA = "0x192E430", Offset = "0x192D630", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003CD")]
	private static void SetColorImpl_Injected(IntPtr _unity_self, int name, in Color value) { }

	[Address(RVA = "0x192E640", Offset = "0x192D840", Length = "0x68")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003C1")]
	public void SetFloat(int nameID, float value) { }

	[Address(RVA = "0x192E6B0", Offset = "0x192D8B0", Length = "0x84")]
	[CalledBy(Type = "UnityEngine.UIElements.FilterFunctionDefinitionUtils", Member = "PrepareBuiltinColorEffectMaterialPropertyBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MaterialPropertyBlock), "UnityEngine.UIElements.FilterFunction"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderTreeCompositor", Member = "ApplyEffectParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PostProcessingPass", "UnityEngine.UIElements.FilterFunction", "UnityEngine.UIElements.VisualElement"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003C0")]
	public void SetFloat(string name, float value) { }

	[Address(RVA = "0x192E640", Offset = "0x192D840", Length = "0x68")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NativeName("SetFloatFromScript")]
	[ThreadSafe]
	[Token(Token = "0x60003B1")]
	private void SetFloatImpl(int name, float value) { }

	[Address(RVA = "0x192E5F0", Offset = "0x192D7F0", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003CB")]
	private static void SetFloatImpl_Injected(IntPtr _unity_self, int name, float value) { }

	[Address(RVA = "0x192E890", Offset = "0x192DA90", Length = "0x9F")]
	[CalledBy(Type = "UnityEngine.UIElements.FilterFunctionDefinitionUtils", Member = "PrepareBuiltinColorEffectMaterialPropertyBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MaterialPropertyBlock), "UnityEngine.UIElements.FilterFunction"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003C5")]
	public void SetMatrix(string name, Matrix4x4 value) { }

	[Address(RVA = "0x192E800", Offset = "0x192DA00", Length = "0x84")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ScreenSpaceReflectionsRenderer", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003C6")]
	public void SetMatrix(int nameID, Matrix4x4 value) { }

	[Address(RVA = "0x192E790", Offset = "0x192D990", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("SetMatrixFromScript")]
	[ThreadSafe]
	[Token(Token = "0x60003B4")]
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	[Address(RVA = "0x192E740", Offset = "0x192D940", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003CE")]
	private static void SetMatrixImpl_Injected(IntPtr _unity_self, int name, in Matrix4x4 value) { }

	[Address(RVA = "0x192E980", Offset = "0x192DB80", Length = "0xD5")]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003C9")]
	public void SetTexture(int nameID, Texture value) { }

	[Address(RVA = "0x192EA60", Offset = "0x192DC60", Length = "0xE2")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderTreeCompositor", Member = "ExecuteDrawOperation_PostOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderTreeCompositor+DrawOperation"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.SubpixelMorphologicalAntialiasing", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003C8")]
	public void SetTexture(string name, Texture value) { }

	[Address(RVA = "0x192E980", Offset = "0x192DB80", Length = "0xD5")]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NativeName("SetTextureFromScript")]
	[ThreadSafe]
	[Token(Token = "0x60003B5")]
	private void SetTextureImpl(int name, Texture value) { }

	[Address(RVA = "0x192E930", Offset = "0x192DB30", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003CF")]
	private static void SetTextureImpl_Injected(IntPtr _unity_self, int name, IntPtr value) { }

	[Address(RVA = "0x192EFD0", Offset = "0x192E1D0", Length = "0x66")]
	[CallerCount(Count = 71)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003C2")]
	public void SetVector(int nameID, Vector4 value) { }

	[Address(RVA = "0x192ECD0", Offset = "0x192DED0", Length = "0x25")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.CommandList", Member = "Execute", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.TextureSlotManager", Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.TextureId", typeof(float), typeof(float), typeof(bool), typeof(int), typeof(MaterialPropertyBlock), "UnityEngine.UIElements.UIR.CommandList"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003CA")]
	public void SetVectorArray(int nameID, Vector4[] values) { }

	[Address(RVA = "0x192ED00", Offset = "0x192DF00", Length = "0x204")]
	[CalledBy(Type = typeof(MaterialPropertyBlock), Member = "SetVectorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003BC")]
	private void SetVectorArray(int name, Vector4[] values, int count) { }

	[Address(RVA = "0x192EBB0", Offset = "0x192DDB0", Length = "0x11B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("SetVectorArrayFromScript")]
	[ThreadSafe]
	[Token(Token = "0x60003B7")]
	private void SetVectorArrayImpl(int name, Vector4[] values, int count) { }

	[Address(RVA = "0x192EB50", Offset = "0x192DD50", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003D1")]
	private static void SetVectorArrayImpl_Injected(IntPtr _unity_self, int name, ref ManagedSpanWrapper values, int count) { }

	[Address(RVA = "0x192EF60", Offset = "0x192E160", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("SetVectorFromScript")]
	[ThreadSafe]
	[Token(Token = "0x60003B2")]
	private void SetVectorImpl(int name, Vector4 value) { }

	[Address(RVA = "0x192EF10", Offset = "0x192E110", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003CC")]
	private static void SetVectorImpl_Injected(IntPtr _unity_self, int name, in Vector4 value) { }

}

