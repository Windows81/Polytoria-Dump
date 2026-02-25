namespace UnityEngine.UIElements;

[Token(Token = "0x200024C")]
internal static class FilterFunctionDefinitionUtils
{
	[Token(Token = "0x40008E5")]
	private static FilterFunctionDefinition s_BlurDef; //Field offset: 0x0
	[Token(Token = "0x40008E6")]
	private static FilterFunctionDefinition s_TintDef; //Field offset: 0x8
	[Token(Token = "0x40008E7")]
	private static FilterFunctionDefinition s_OpacityDef; //Field offset: 0x10
	[Token(Token = "0x40008E8")]
	private static FilterFunctionDefinition s_InvertDef; //Field offset: 0x18
	[Token(Token = "0x40008E9")]
	private static FilterFunctionDefinition s_GrayscaleDef; //Field offset: 0x20
	[Token(Token = "0x40008EA")]
	private static FilterFunctionDefinition s_SepiaDef; //Field offset: 0x28

	[Address(RVA = "0x1C51610", Offset = "0x1C50810", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Token(Token = "0x6000FC5")]
	private static PostProcessingMargins ComputeHorizontalBlurMargins(FilterFunction func) { }

	[Address(RVA = "0x1C516D0", Offset = "0x1C508D0", Length = "0xBE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Token(Token = "0x6000FC6")]
	private static PostProcessingMargins ComputeVerticalBlurMargins(FilterFunction func) { }

	[Address(RVA = "0x1C51790", Offset = "0x1C50990", Length = "0x6E1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(FilterFunctionDefinitionUtils), Member = "GetBuiltinFilterName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FilterFunctionType)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Shader), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Shader))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000FC3")]
	private static FilterFunctionDefinition CreateBlurFilterFunctionDefinition() { }

	[Address(RVA = "0x1C51E80", Offset = "0x1C51080", Length = "0x463")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(FilterFunctionDefinitionUtils), Member = "GetBuiltinFilterName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FilterFunctionType)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Shader), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Shader))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000FC4")]
	private static FilterFunctionDefinition CreateColorEffectFilterFunctionDefinition(FilterFunctionType filterType) { }

	[Address(RVA = "0x1C522F0", Offset = "0x1C514F0", Length = "0x4C")]
	[CalledBy(Type = typeof(FilterFunction), Member = "GetDefinition", ReturnType = typeof(FilterFunctionDefinition))]
	[CalledBy(Type = typeof(FilterFunction), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000FC2")]
	public static FilterFunctionDefinition GetBuiltinDefinition(FilterFunctionType type) { }

	[Address(RVA = "0x1C52690", Offset = "0x1C51890", Length = "0x78")]
	[CalledBy(Type = typeof(FilterFunctionDefinitionUtils), Member = "CreateBlurFilterFunctionDefinition", ReturnType = typeof(FilterFunctionDefinition))]
	[CalledBy(Type = typeof(FilterFunctionDefinitionUtils), Member = "CreateColorEffectFilterFunctionDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FilterFunctionType)}, ReturnType = typeof(FilterFunctionDefinition))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000FC1")]
	public static string GetBuiltinFilterName(FilterFunctionType type) { }

	[Address(RVA = "0x1C52780", Offset = "0x1C51980", Length = "0x62D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Matrix4x4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000FC7")]
	private static void PrepareBuiltinColorEffectMaterialPropertyBlock(MaterialPropertyBlock mpb, FilterFunction func) { }

}

