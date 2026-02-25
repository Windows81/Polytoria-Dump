namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
[Token(Token = "0x2000047")]
internal sealed class VignetteRenderer : PostProcessEffectRenderer<Vignette>
{

	[Address(RVA = "0x183E060", Offset = "0x183D260", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PostProcessEffectRenderer`1), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x600009F")]
	public VignetteRenderer() { }

	[Address(RVA = "0x183DCB0", Offset = "0x183CEB0", Length = "0x3AB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x600009E")]
	public virtual void Render(PostProcessRenderContext context) { }

}

