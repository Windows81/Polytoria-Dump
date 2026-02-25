namespace UnityEngine.UI;

[ExecuteAlways]
[Token(Token = "0x2000083")]
public abstract class BaseMeshEffect : UIBehaviour, IMeshModifier
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000270")]
	private Graphic m_Graphic; //Field offset: 0x20

	[Token(Token = "0x17000155")]
	protected Graphic graphic
	{
		[Address(RVA = "0x1CC8390", Offset = "0x1CC7590", Length = "0x8D")]
		[CalledBy(Type = typeof(BaseMeshEffect), Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseMeshEffect), Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseMeshEffect), Member = "OnDidApplyAnimationProperties", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Shadow), Member = "set_effectColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Shadow), Member = "set_effectDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Shadow), Member = "set_useGraphicAlpha", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000535")]
		 get { } //Length: 141
	}

	[Address(RVA = "0x3B01C0", Offset = "0x3AF3C0", Length = "0x7")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600053B")]
	protected BaseMeshEffect() { }

	[Address(RVA = "0x1CC8390", Offset = "0x1CC7590", Length = "0x8D")]
	[CalledBy(Type = typeof(BaseMeshEffect), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseMeshEffect), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseMeshEffect), Member = "OnDidApplyAnimationProperties", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Shadow), Member = "set_effectColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Shadow), Member = "set_effectDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Shadow), Member = "set_useGraphicAlpha", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000535")]
	protected Graphic get_graphic() { }

	[Address(RVA = "0x1CC7F70", Offset = "0x1CC7170", Length = "0x23C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mesh), Member = "SetUVs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Mesh), Member = "RecalculateBounds", ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "SetTriangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "SetTangents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "SetNormals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "SetColors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Color32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Mesh), Member = "SetVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(VertexHelper), Member = "InitializeListIfRequired", ReturnType = typeof(void))]
	[Calls(Type = typeof(VertexHelper), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000539")]
	public override void ModifyMesh(Mesh mesh) { }

	[Token(Token = "0x600053A")]
	public abstract void ModifyMesh(VertexHelper vh) { }

	[Address(RVA = "0x1CC81B0", Offset = "0x1CC73B0", Length = "0x9B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseMeshEffect), Member = "get_graphic", ReturnType = typeof(Graphic))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000538")]
	protected virtual void OnDidApplyAnimationProperties() { }

	[Address(RVA = "0x1CC8250", Offset = "0x1CC7450", Length = "0x9B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseMeshEffect), Member = "get_graphic", ReturnType = typeof(Graphic))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000537")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x1CC82F0", Offset = "0x1CC74F0", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseMeshEffect), Member = "get_graphic", ReturnType = typeof(Graphic))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000536")]
	protected virtual void OnEnable() { }

}

