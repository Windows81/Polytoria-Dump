namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
[Token(Token = "0x200001B")]
internal sealed class ChromaticAberrationRenderer : PostProcessEffectRenderer<ChromaticAberration>
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000056")]
	private Texture2D m_InternalSpectralLut; //Field offset: 0x20

	[Address(RVA = "0x182C080", Offset = "0x182B280", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PostProcessEffectRenderer`1), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x600002C")]
	public ChromaticAberrationRenderer() { }

	[Address(RVA = "0x182BCD0", Offset = "0x182AED0", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600002B")]
	public virtual void Release() { }

	[Address(RVA = "0x182BD40", Offset = "0x182AF40", Length = "0x33A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Texture), Member = "set_wrapMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureWrapMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "Apply", ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "SetPixels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "set_anisoLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Texture), Member = "set_filterMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FilterMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600002A")]
	public virtual void Render(PostProcessRenderContext context) { }

}

