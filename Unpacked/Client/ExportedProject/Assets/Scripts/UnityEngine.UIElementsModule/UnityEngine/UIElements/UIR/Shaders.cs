namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005A2")]
internal static class Shaders
{
	[Token(Token = "0x4001442")]
	public static readonly string k_AtlasBlit; //Field offset: 0x0
	[Token(Token = "0x4001443")]
	public static readonly string k_Editor; //Field offset: 0x8
	[Token(Token = "0x4001444")]
	public static readonly string k_Runtime; //Field offset: 0x10
	[Token(Token = "0x4001445")]
	public static readonly string k_RuntimeWorld; //Field offset: 0x18
	[Token(Token = "0x4001446")]
	public static readonly string k_RuntimeGaussianBlur; //Field offset: 0x20
	[Token(Token = "0x4001447")]
	public static readonly string k_RuntimeColorEffect; //Field offset: 0x28
	[Token(Token = "0x4001448")]
	public static readonly string k_ColorConversionBlit; //Field offset: 0x30
	[Token(Token = "0x4001449")]
	public static readonly string k_ForceGammaKeyword; //Field offset: 0x38
	[Token(Token = "0x400144A")]
	private static Material s_RuntimeMaterial; //Field offset: 0x40
	[Token(Token = "0x400144B")]
	private static Material s_RuntimeWorldMaterial; //Field offset: 0x48
	[Token(Token = "0x400144C")]
	private static Material s_EditorMaterial; //Field offset: 0x50
	[Token(Token = "0x400144D")]
	private static int s_RefCount; //Field offset: 0x58

	[Token(Token = "0x17000A22")]
	public static Material editorMaterial
	{
		[Address(RVA = "0x1B9F620", Offset = "0x1B9E820", Length = "0x57")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Shaders), Member = "GetOrCreateMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material&), typeof(string)}, ReturnType = typeof(Material))]
		[Token(Token = "0x6002847")]
		 get { } //Length: 87
	}

	[Token(Token = "0x17000A20")]
	public static Material runtimeMaterial
	{
		[Address(RVA = "0x1B9F680", Offset = "0x1B9E880", Length = "0x57")]
		[CalledBy(Type = typeof(UIRenderDevice), Member = "ApplyBatchState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EvaluationState&), typeof(Texture), typeof(Texture)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Shaders), Member = "GetOrCreateMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material&), typeof(string)}, ReturnType = typeof(Material))]
		[Token(Token = "0x6002845")]
		 get { } //Length: 87
	}

	[Token(Token = "0x17000A21")]
	public static Material runtimeWorldMaterial
	{
		[Address(RVA = "0x1B9F6E0", Offset = "0x1B9E8E0", Length = "0x57")]
		[CalledBy(Type = typeof(UIRenderDevice), Member = "GetOrCreateMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(Material))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Shaders), Member = "GetOrCreateMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material&), typeof(string)}, ReturnType = typeof(Material))]
		[Token(Token = "0x6002846")]
		 get { } //Length: 87
	}

	[Address(RVA = "0x1B9F3E0", Offset = "0x1B9E5E0", Length = "0x237")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600284B")]
	private static Shaders() { }

	[Address(RVA = "0x1B9F030", Offset = "0x1B9E230", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6002849")]
	public static void Acquire() { }

	[Address(RVA = "0x1B9F620", Offset = "0x1B9E820", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Shaders), Member = "GetOrCreateMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material&), typeof(string)}, ReturnType = typeof(Material))]
	[Token(Token = "0x6002847")]
	public static Material get_editorMaterial() { }

	[Address(RVA = "0x1B9F680", Offset = "0x1B9E880", Length = "0x57")]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "ApplyBatchState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EvaluationState&), typeof(Texture), typeof(Texture)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Shaders), Member = "GetOrCreateMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material&), typeof(string)}, ReturnType = typeof(Material))]
	[Token(Token = "0x6002845")]
	public static Material get_runtimeMaterial() { }

	[Address(RVA = "0x1B9F6E0", Offset = "0x1B9E8E0", Length = "0x57")]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "GetOrCreateMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(Material))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Shaders), Member = "GetOrCreateMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material&), typeof(string)}, ReturnType = typeof(Material))]
	[Token(Token = "0x6002846")]
	public static Material get_runtimeWorldMaterial() { }

	[Address(RVA = "0x1B9F090", Offset = "0x1B9E290", Length = "0x162")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Shaders), Member = "get_runtimeMaterial", ReturnType = typeof(Material))]
	[CalledBy(Type = typeof(Shaders), Member = "get_runtimeWorldMaterial", ReturnType = typeof(Material))]
	[CalledBy(Type = typeof(Shaders), Member = "get_editorMaterial", ReturnType = typeof(Material))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Shader), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Shader))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Token(Token = "0x6002848")]
	private static Material GetOrCreateMaterial(ref Material material, string shaderName) { }

	[Address(RVA = "0x1B9F200", Offset = "0x1B9E400", Length = "0x1DE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRUtility), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600284A")]
	public static void Release() { }

}

