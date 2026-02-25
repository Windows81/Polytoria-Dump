namespace Polytoria.Datamodel;

[Token(Token = "0x200035A")]
public class SkyBase : Instance
{
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000E35")]
	protected Material skyboxMaterial; //Field offset: 0xF8

	[Address(RVA = "0x46E780", Offset = "0x46D980", Length = "0x49")]
	[CalledBy(Type = typeof(GradientSky), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ImageSky), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Instance), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60022C7")]
	public SkyBase() { }

	[Address(RVA = "0x46E5E0", Offset = "0x46D7E0", Length = "0xB3")]
	[CalledBy(Type = typeof(GradientSky), Member = "Apply", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ImageSky), Member = "Apply", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderSettings), Member = "set_skybox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x60022C6")]
	protected override void Apply() { }

	[Address(RVA = "0x46E6A0", Offset = "0x46D8A0", Length = "0xB6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "FindChildOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Environment), Member = "set_Skybox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkyboxPreset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60022C5")]
	protected override void OnDisable() { }

	[Address(RVA = "0x46E760", Offset = "0x46D960", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60022C4")]
	protected override void OnEnable() { }

	[Address(RVA = "0x46A360", Offset = "0x469560", Length = "0x2C")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60022C3")]
	protected virtual void Start() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x60022C8")]
	public virtual bool Weaved() { }

}

