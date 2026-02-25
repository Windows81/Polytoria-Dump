namespace RLD;

[Token(Token = "0x200007D")]
public class GizmoCircularMaterial : Singleton<GizmoCircularMaterial>
{
	[Token(Token = "0x200007E")]
	internal enum Type
	{
		Circle = 0,
		Torus = 1,
		CylindricalTorus = 2,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001B5")]
	private Type _circularType; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001B6")]
	private Material _circleMaterial; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001B7")]
	private Material _torusMaterial; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001B8")]
	private Material _cylindricalTorusMaterial; //Field offset: 0x28

	[Token(Token = "0x1700014C")]
	public Material CircleMaterial
	{
		[Address(RVA = "0x3CC9E0", Offset = "0x3CBBE0", Length = "0xBF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(MaterialPool), Member = "get_CircleCull", ReturnType = typeof(Material))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600043C")]
		 get { } //Length: 191
	}

	[Token(Token = "0x17000150")]
	public Type CircularType
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000440")]
		 get { } //Length: 4
		[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000441")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700014E")]
	public Material CylindricalTorusMaterial
	{
		[Address(RVA = "0x3CCAA0", Offset = "0x3CBCA0", Length = "0xBF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(MaterialPool), Member = "get_CylindricalTorusCull", ReturnType = typeof(Material))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600043E")]
		 get { } //Length: 191
	}

	[Token(Token = "0x17000151")]
	public bool IsLit
	{
		[Address(RVA = "0x3CCB60", Offset = "0x3CBD60", Length = "0x57")]
		[CalledBy(Type = typeof(GizmoCircle3DBorder), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(GizmoCircularMaterial), Member = "get_Material", ReturnType = typeof(Material))]
		[Calls(Type = typeof(Material), Member = "GetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000442")]
		 get { } //Length: 87
	}

	[Token(Token = "0x17000152")]
	public float LightIntensity
	{
		[Address(RVA = "0x3CCBC0", Offset = "0x3CBDC0", Length = "0x50")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(GizmoCircularMaterial), Member = "get_Material", ReturnType = typeof(Material))]
		[Calls(Type = typeof(Material), Member = "GetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000443")]
		 get { } //Length: 80
	}

	[Token(Token = "0x1700014F")]
	public Material Material
	{
		[Address(RVA = "0x3CCC20", Offset = "0x3CBE20", Length = "0x235")]
		[CallerCount(Count = 33)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(MaterialPool), Member = "get_CylindricalTorusCull", ReturnType = typeof(Material))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(MaterialPool), Member = "get_TorusCull", ReturnType = typeof(Material))]
		[Calls(Type = typeof(MaterialPool), Member = "get_CircleCull", ReturnType = typeof(Material))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x600043F")]
		 get { } //Length: 565
	}

	[Token(Token = "0x1700014D")]
	public Material TorusMaterial
	{
		[Address(RVA = "0x3CCE60", Offset = "0x3CC060", Length = "0xBF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(MaterialPool), Member = "get_TorusCull", ReturnType = typeof(Material))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600043D")]
		 get { } //Length: 191
	}

	[Address(RVA = "0x3CC820", Offset = "0x3CBA20", Length = "0x1B9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GizmoCircularMaterial), Member = "get_Material", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Material), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000444")]
	public GizmoCircularMaterial() { }

	[Address(RVA = "0x3CC9E0", Offset = "0x3CBBE0", Length = "0xBF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MaterialPool), Member = "get_CircleCull", ReturnType = typeof(Material))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600043C")]
	public Material get_CircleMaterial() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000440")]
	public Type get_CircularType() { }

	[Address(RVA = "0x3CCAA0", Offset = "0x3CBCA0", Length = "0xBF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MaterialPool), Member = "get_CylindricalTorusCull", ReturnType = typeof(Material))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600043E")]
	public Material get_CylindricalTorusMaterial() { }

	[Address(RVA = "0x3CCB60", Offset = "0x3CBD60", Length = "0x57")]
	[CalledBy(Type = typeof(GizmoCircle3DBorder), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoCircularMaterial), Member = "get_Material", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Material), Member = "GetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000442")]
	public bool get_IsLit() { }

	[Address(RVA = "0x3CCBC0", Offset = "0x3CBDC0", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoCircularMaterial), Member = "get_Material", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Material), Member = "GetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000443")]
	public float get_LightIntensity() { }

	[Address(RVA = "0x3CCC20", Offset = "0x3CBE20", Length = "0x235")]
	[CallerCount(Count = 33)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MaterialPool), Member = "get_CylindricalTorusCull", ReturnType = typeof(Material))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MaterialPool), Member = "get_TorusCull", ReturnType = typeof(Material))]
	[Calls(Type = typeof(MaterialPool), Member = "get_CircleCull", ReturnType = typeof(Material))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600043F")]
	public Material get_Material() { }

	[Address(RVA = "0x3CCE60", Offset = "0x3CC060", Length = "0xBF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MaterialPool), Member = "get_TorusCull", ReturnType = typeof(Material))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600043D")]
	public Material get_TorusMaterial() { }

	[Address(RVA = "0x3CBDD0", Offset = "0x3CAFD0", Length = "0x16D")]
	[CalledBy(Type = typeof(GizmoCircle3DBorder), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoCircularMaterial), Member = "get_Material", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Material), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000445")]
	public void ResetValuesToSensibleDefaults() { }

	[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000441")]
	public void set_CircularType(Type value) { }

	[Address(RVA = "0x3CBF40", Offset = "0x3CB140", Length = "0x10D")]
	[CalledBy(Type = typeof(GizmoCircle3DBorder), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoCircularMaterial), Member = "get_Material", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Material), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "get_orthographic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600044B")]
	public void SetCamera(Camera camera) { }

	[Address(RVA = "0x3CC050", Offset = "0x3CB250", Length = "0x6A")]
	[CalledBy(Type = typeof(GizmoCircle3DBorder), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoCircularMaterial), Member = "get_Material", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Material), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600044F")]
	public void SetColor(Color color) { }

	[Address(RVA = "0x3CC0C0", Offset = "0x3CB2C0", Length = "0x60")]
	[CalledBy(Type = typeof(GizmoCircle3DBorder), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoCircularMaterial), Member = "get_Material", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000446")]
	public void SetCullAlphaScale(float scale) { }

	[Address(RVA = "0x3CC130", Offset = "0x3CB330", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoCircularMaterial), Member = "get_Material", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Material), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000454")]
	public void SetCullModeBack() { }

	[Address(RVA = "0x3CC190", Offset = "0x3CB390", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoCircularMaterial), Member = "get_Material", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Material), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000455")]
	public void SetCullModeFront() { }

	[Address(RVA = "0x3CC1F0", Offset = "0x3CB3F0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoCircularMaterial), Member = "get_Material", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Material), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000456")]
	public void SetCullModeOff() { }

	[Address(RVA = "0x3CC250", Offset = "0x3CB450", Length = "0xA4")]
	[CalledBy(Type = typeof(GizmoCircle3DBorder), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoCircularMaterial), Member = "get_Material", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600044A")]
	public void SetCylindricalTorusRadii(float hrzRadius, float vertRadius) { }

	[Address(RVA = "0x3CC300", Offset = "0x3CB500", Length = "0x97")]
	[CalledBy(Type = typeof(GizmoCircle3DBorder), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoCircularMaterial), Member = "get_Material", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Material), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600044D")]
	public void SetLightDirection(Vector3 lightDir) { }

	[Address(RVA = "0x3CC3A0", Offset = "0x3CB5A0", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoCircularMaterial), Member = "get_Material", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600044E")]
	public void SetLightIntensity(float intensity) { }

	[Address(RVA = "0x3CC410", Offset = "0x3CB610", Length = "0x5F")]
	[CalledBy(Type = typeof(GizmoCircle3DBorder), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoCircularMaterial), Member = "get_Material", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Material), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600044C")]
	public void SetLit(bool isLit) { }

	[Address(RVA = "0x3CC470", Offset = "0x3CB670", Length = "0x26")]
	[CalledBy(Type = typeof(GizmoCircle3DBorder), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GizmoCircularMaterial), Member = "get_Material", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Material), Member = "SetPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000457")]
	public void SetPass(int passIndex) { }

	[Address(RVA = "0x3CC4A0", Offset = "0x3CB6A0", Length = "0x10D")]
	[CalledBy(Type = typeof(GizmoCircle3DBorder), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoCircularMaterial), Member = "get_Material", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Material), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000447")]
	public void SetShapeCenter(Vector3 center) { }

	[Address(RVA = "0x3CC5B0", Offset = "0x3CB7B0", Length = "0x6D")]
	[CalledBy(Type = typeof(GizmoCircle3DBorder), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoCircularMaterial), Member = "get_Material", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000448")]
	public void SetTorusCoreRadius(float radius) { }

	[Address(RVA = "0x3CC620", Offset = "0x3CB820", Length = "0x67")]
	[CalledBy(Type = typeof(GizmoCircle3DBorder), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoCircularMaterial), Member = "get_Material", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000449")]
	public void SetTorusTubeRadius(float radius) { }

	[Address(RVA = "0x3CC690", Offset = "0x3CB890", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoCircularMaterial), Member = "get_Material", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Material), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000452")]
	public void SetZTestAlways() { }

	[Address(RVA = "0x3CC6F0", Offset = "0x3CB8F0", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoCircularMaterial), Member = "get_Material", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Material), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000451")]
	public void SetZTestEnabled(bool isEnabled) { }

	[Address(RVA = "0x3CC760", Offset = "0x3CB960", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoCircularMaterial), Member = "get_Material", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Material), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000453")]
	public void SetZTestLess() { }

	[Address(RVA = "0x3CC7C0", Offset = "0x3CB9C0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoCircularMaterial), Member = "get_Material", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Material), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000450")]
	public void SetZWriteEnabled(bool isEnabled) { }

}

