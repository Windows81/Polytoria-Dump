namespace UnityEngine.Rendering.PostProcessing;

[Extension]
[Token(Token = "0x2000082")]
internal static class PostProcessEffectRendererExtensions
{

	[Address(RVA = "0x1843230", Offset = "0x1842430", Length = "0x61")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.PostProcessing.PostProcessLayer+SerializedBundleRef>), typeof(PostProcessRenderContext), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderEffect", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	[Token(Token = "0x60001F1")]
	public static Exception RenderOrLog(PostProcessEffectRenderer self, PostProcessRenderContext context) { }

}

