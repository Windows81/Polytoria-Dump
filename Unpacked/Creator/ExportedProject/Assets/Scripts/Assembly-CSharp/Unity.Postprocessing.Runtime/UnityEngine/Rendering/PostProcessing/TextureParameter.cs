namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x200005A")]
public sealed class TextureParameter : ParameterOverride<Texture>
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000160")]
	public TextureParameterDefault defaultState; //Field offset: 0x20

	[Address(RVA = "0x1855AC0", Offset = "0x1854CC0", Length = "0x40")]
	[CalledBy(Type = typeof(Bloom), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChromaticAberration), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Vignette), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.Rendering.PostProcessing.ParameterOverride`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60000E5")]
	public TextureParameter() { }

	[Address(RVA = "0x18555B0", Offset = "0x18547B0", Length = "0x507")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "GetLutStrip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(UnityEngine.Rendering.PostProcessing.ParameterOverride`1<System.Object>), Member = "Interp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextureLerper), Member = "get_instance", ReturnType = typeof(TextureLerper))]
	[Calls(Type = typeof(TextureLerper), Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(Texture), typeof(float)}, ReturnType = typeof(Texture))]
	[Calls(Type = typeof(TextureLerper), Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(Color), typeof(float)}, ReturnType = typeof(Texture))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x60000E4")]
	public virtual void Interp(Texture from, Texture to, float t) { }

}

