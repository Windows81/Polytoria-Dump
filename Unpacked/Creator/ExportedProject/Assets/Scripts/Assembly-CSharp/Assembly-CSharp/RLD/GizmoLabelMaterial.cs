namespace RLD;

[Token(Token = "0x200007F")]
public class GizmoLabelMaterial : Singleton<GizmoLabelMaterial>
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001BD")]
	private Material _material; //Field offset: 0x10

	[Token(Token = "0x17000153")]
	public Material Material
	{
		[Address(RVA = "0x3D0620", Offset = "0x3CF820", Length = "0xBF")]
		[CalledBy(Type = typeof(GizmoLabelMaterial), Member = "SetZTestLess", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoLabelMaterial), Member = "SetZTestLessEqual", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoLabelMaterial), Member = "SetZWriteEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoLabelMaterial), Member = "SetZTestAlways", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoLabelMaterial), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoLabelMaterial), Member = "SetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoLabelMaterial), Member = "ResetValuesToSensibleDefaults", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoLabelMaterial), Member = "SetPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(MaterialPool), Member = "get_TintedTexture", ReturnType = typeof(Material))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000458")]
		 get { } //Length: 191
	}

	[Address(RVA = "0x3D05C0", Offset = "0x3CF7C0", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000461")]
	public GizmoLabelMaterial() { }

	[Address(RVA = "0x3D0620", Offset = "0x3CF820", Length = "0xBF")]
	[CalledBy(Type = typeof(GizmoLabelMaterial), Member = "ResetValuesToSensibleDefaults", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLabelMaterial), Member = "SetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLabelMaterial), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLabelMaterial), Member = "SetZTestAlways", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLabelMaterial), Member = "SetPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLabelMaterial), Member = "SetZTestLessEqual", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLabelMaterial), Member = "SetZTestLess", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLabelMaterial), Member = "SetZWriteEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(MaterialPool), Member = "get_TintedTexture", ReturnType = typeof(Material))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000458")]
	public Material get_Material() { }

	[Address(RVA = "0x3D02E0", Offset = "0x3CF4E0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoLabelMaterial), Member = "get_Material", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Material), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000459")]
	public void ResetValuesToSensibleDefaults() { }

	[Address(RVA = "0x3D0340", Offset = "0x3CF540", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoLabelMaterial), Member = "get_Material", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Material), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600045B")]
	public void SetColor(Color color) { }

	[Address(RVA = "0x3D03B0", Offset = "0x3CF5B0", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoLabelMaterial), Member = "get_Material", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Material), Member = "SetPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600045C")]
	public void SetPass(int passIndex) { }

	[Address(RVA = "0x3D03E0", Offset = "0x3CF5E0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoLabelMaterial), Member = "get_Material", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Material), Member = "SetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600045A")]
	public void SetTexture(Texture2D texture) { }

	[Address(RVA = "0x3D0440", Offset = "0x3CF640", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoLabelMaterial), Member = "get_Material", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Material), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600045F")]
	public void SetZTestAlways() { }

	[Address(RVA = "0x3D0500", Offset = "0x3CF700", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoLabelMaterial), Member = "get_Material", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Material), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000460")]
	public void SetZTestLess() { }

	[Address(RVA = "0x3D04A0", Offset = "0x3CF6A0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoLabelMaterial), Member = "get_Material", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Material), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600045E")]
	public void SetZTestLessEqual() { }

	[Address(RVA = "0x3D0560", Offset = "0x3CF760", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoLabelMaterial), Member = "get_Material", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Material), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600045D")]
	public void SetZWriteEnabled(bool isEnabled) { }

}

