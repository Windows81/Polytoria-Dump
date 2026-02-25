namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x20003B3")]
public class PartProxy : DynamicInstanceProxy
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000FFD")]
	private readonly Part part; //Field offset: 0x20

	[Token(Token = "0x17000BEF")]
	public bool Anchored
	{
		[Address(RVA = "0x4A6570", Offset = "0x4A5770", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002803")]
		 get { } //Length: 30
		[Address(RVA = "0x4A6780", Offset = "0x4A5980", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Part), Member = "set_Anchored", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002804")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BF6")]
	public float AngularDrag
	{
		[Address(RVA = "0x4A6590", Offset = "0x4A5790", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Part), Member = "get_AngularDrag", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002811")]
		 get { } //Length: 29
		[Address(RVA = "0x4A67A0", Offset = "0x4A59A0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Part), Member = "set_AngularDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002812")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BF8")]
	public Vector3 AngularVelocity
	{
		[Address(RVA = "0x4A65B0", Offset = "0x4A57B0", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Part), Member = "get_AngularVelocity", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002815")]
		 get { } //Length: 59
		[Address(RVA = "0x4A67C0", Offset = "0x4A59C0", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Part), Member = "set_AngularVelocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002816")]
		 set { } //Length: 53
	}

	[Token(Token = "0x17000BFA")]
	public float Bounciness
	{
		[Address(RVA = "0x4A65F0", Offset = "0x4A57F0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Part), Member = "get_Bounciness", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002819")]
		 get { } //Length: 29
		[Address(RVA = "0x4A6800", Offset = "0x4A5A00", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Part), Member = "set_Bounciness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600281A")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BF0")]
	public bool CanCollide
	{
		[Address(RVA = "0x4A6610", Offset = "0x4A5810", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002805")]
		 get { } //Length: 30
		[Address(RVA = "0x4A6820", Offset = "0x4A5A20", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Part), Member = "set_CanCollide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002806")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BFC")]
	public bool CastShadows
	{
		[Address(RVA = "0x4A6630", Offset = "0x4A5830", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600281D")]
		 get { } //Length: 30
		[Address(RVA = "0x4A6840", Offset = "0x4A5A40", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Part), Member = "set_CastShadows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600281E")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BEE")]
	public Color Color
	{
		[Address(RVA = "0x4A6650", Offset = "0x4A5850", Length = "0x24")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002801")]
		 get { } //Length: 36
		[Address(RVA = "0x4A6860", Offset = "0x4A5A60", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Part), Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002802")]
		 set { } //Length: 44
	}

	[Token(Token = "0x17000BF5")]
	public float Drag
	{
		[Address(RVA = "0x4A6680", Offset = "0x4A5880", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Part), Member = "get_Drag", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600280F")]
		 get { } //Length: 29
		[Address(RVA = "0x4A6890", Offset = "0x4A5A90", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Part), Member = "set_Drag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002810")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BFB")]
	public float Friction
	{
		[Address(RVA = "0x4A66A0", Offset = "0x4A58A0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Part), Member = "get_Friction", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600281B")]
		 get { } //Length: 29
		[Address(RVA = "0x4A68B0", Offset = "0x4A5AB0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Part), Member = "set_Friction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600281C")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BF1")]
	public bool IsSpawn
	{
		[Address(RVA = "0x4A66C0", Offset = "0x4A58C0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002807")]
		 get { } //Length: 30
		[Address(RVA = "0x4A68D0", Offset = "0x4A5AD0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Part), Member = "set_IsSpawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002808")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BF7")]
	public float Mass
	{
		[Address(RVA = "0x4A66E0", Offset = "0x4A58E0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Part), Member = "get_Mass", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002813")]
		 get { } //Length: 29
		[Address(RVA = "0x4A68F0", Offset = "0x4A5AF0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Part), Member = "set_Mass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002814")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BF3")]
	public PartMaterial Material
	{
		[Address(RVA = "0x4A6700", Offset = "0x4A5900", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600280B")]
		 get { } //Length: 29
		[Address(RVA = "0x4A6910", Offset = "0x4A5B10", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Part), Member = "set_Material", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PartMaterial)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600280C")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BF2")]
	public PartShape Shape
	{
		[Address(RVA = "0x4A6720", Offset = "0x4A5920", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002809")]
		 get { } //Length: 29
		[Address(RVA = "0x4A6930", Offset = "0x4A5B30", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Part), Member = "set_Shape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PartShape)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600280A")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BF9")]
	public bool UseGravity
	{
		[Address(RVA = "0x4A1250", Offset = "0x4A0450", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002817")]
		 get { } //Length: 30
		[Address(RVA = "0x4A6950", Offset = "0x4A5B50", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Part), Member = "set_UseGravity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002818")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BF4")]
	public Vector3 Velocity
	{
		[Address(RVA = "0x4A6740", Offset = "0x4A5940", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Part), Member = "get_Velocity", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600280D")]
		 get { } //Length: 59
		[Address(RVA = "0x4A6970", Offset = "0x4A5B70", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Part), Member = "set_Velocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600280E")]
		 set { } //Length: 53
	}

	[Address(RVA = "0x4A11B0", Offset = "0x4A03B0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x6002800")]
	public PartProxy(Part target) { }

	[Address(RVA = "0x4A63F0", Offset = "0x4A55F0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Part), Member = "AddForce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(ForceMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002821")]
	public void AddForce(Vector3 force, ForceMode mode = 0) { }

	[Address(RVA = "0x4A6390", Offset = "0x4A5590", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Part), Member = "AddForceAtPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(ForceMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002823")]
	public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode mode = 0) { }

	[Address(RVA = "0x4A6430", Offset = "0x4A5630", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Part), Member = "AddRelativeForce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(ForceMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002824")]
	public void AddRelativeForce(Vector3 force, ForceMode mode = 0) { }

	[Address(RVA = "0x4A6470", Offset = "0x4A5670", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Part), Member = "AddRelativeTorque", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(ForceMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002825")]
	public void AddRelativeTorque(Vector3 torque, ForceMode mode = 0) { }

	[Address(RVA = "0x4A64B0", Offset = "0x4A56B0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Part), Member = "AddTorque", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(ForceMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002822")]
	public void AddTorque(Vector3 torque, ForceMode mode = 0) { }

	[Address(RVA = "0x4A6570", Offset = "0x4A5770", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002803")]
	public bool get_Anchored() { }

	[Address(RVA = "0x4A6590", Offset = "0x4A5790", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Part), Member = "get_AngularDrag", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002811")]
	public float get_AngularDrag() { }

	[Address(RVA = "0x4A65B0", Offset = "0x4A57B0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Part), Member = "get_AngularVelocity", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002815")]
	public Vector3 get_AngularVelocity() { }

	[Address(RVA = "0x4A65F0", Offset = "0x4A57F0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Part), Member = "get_Bounciness", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002819")]
	public float get_Bounciness() { }

	[Address(RVA = "0x4A6610", Offset = "0x4A5810", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002805")]
	public bool get_CanCollide() { }

	[Address(RVA = "0x4A6630", Offset = "0x4A5830", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600281D")]
	public bool get_CastShadows() { }

	[Address(RVA = "0x4A6650", Offset = "0x4A5850", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002801")]
	public Color get_Color() { }

	[Address(RVA = "0x4A6680", Offset = "0x4A5880", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Part), Member = "get_Drag", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600280F")]
	public float get_Drag() { }

	[Address(RVA = "0x4A66A0", Offset = "0x4A58A0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Part), Member = "get_Friction", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600281B")]
	public float get_Friction() { }

	[Address(RVA = "0x4A66C0", Offset = "0x4A58C0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002807")]
	public bool get_IsSpawn() { }

	[Address(RVA = "0x4A66E0", Offset = "0x4A58E0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Part), Member = "get_Mass", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002813")]
	public float get_Mass() { }

	[Address(RVA = "0x4A6700", Offset = "0x4A5900", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600280B")]
	public PartMaterial get_Material() { }

	[Address(RVA = "0x4A6720", Offset = "0x4A5920", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002809")]
	public PartShape get_Shape() { }

	[Address(RVA = "0x4A1250", Offset = "0x4A0450", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002817")]
	public bool get_UseGravity() { }

	[Address(RVA = "0x4A6740", Offset = "0x4A5940", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Part), Member = "get_Velocity", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600280D")]
	public Vector3 get_Velocity() { }

	[Address(RVA = "0x4A64F0", Offset = "0x4A56F0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Part), Member = "MovePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600281F")]
	public void MovePosition(Vector3 pos) { }

	[Address(RVA = "0x4A6530", Offset = "0x4A5730", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Part), Member = "MoveRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002820")]
	public void MoveRotation(Vector3 rot) { }

	[Address(RVA = "0x4A6780", Offset = "0x4A5980", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Part), Member = "set_Anchored", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002804")]
	public void set_Anchored(bool value) { }

	[Address(RVA = "0x4A67A0", Offset = "0x4A59A0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Part), Member = "set_AngularDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002812")]
	public void set_AngularDrag(float value) { }

	[Address(RVA = "0x4A67C0", Offset = "0x4A59C0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Part), Member = "set_AngularVelocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002816")]
	public void set_AngularVelocity(Vector3 value) { }

	[Address(RVA = "0x4A6800", Offset = "0x4A5A00", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Part), Member = "set_Bounciness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600281A")]
	public void set_Bounciness(float value) { }

	[Address(RVA = "0x4A6820", Offset = "0x4A5A20", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Part), Member = "set_CanCollide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002806")]
	public void set_CanCollide(bool value) { }

	[Address(RVA = "0x4A6840", Offset = "0x4A5A40", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Part), Member = "set_CastShadows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600281E")]
	public void set_CastShadows(bool value) { }

	[Address(RVA = "0x4A6860", Offset = "0x4A5A60", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Part), Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002802")]
	public void set_Color(Color value) { }

	[Address(RVA = "0x4A6890", Offset = "0x4A5A90", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Part), Member = "set_Drag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002810")]
	public void set_Drag(float value) { }

	[Address(RVA = "0x4A68B0", Offset = "0x4A5AB0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Part), Member = "set_Friction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600281C")]
	public void set_Friction(float value) { }

	[Address(RVA = "0x4A68D0", Offset = "0x4A5AD0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Part), Member = "set_IsSpawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002808")]
	public void set_IsSpawn(bool value) { }

	[Address(RVA = "0x4A68F0", Offset = "0x4A5AF0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Part), Member = "set_Mass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002814")]
	public void set_Mass(float value) { }

	[Address(RVA = "0x4A6910", Offset = "0x4A5B10", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Part), Member = "set_Material", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PartMaterial)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600280C")]
	public void set_Material(PartMaterial value) { }

	[Address(RVA = "0x4A6930", Offset = "0x4A5B30", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Part), Member = "set_Shape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PartShape)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600280A")]
	public void set_Shape(PartShape value) { }

	[Address(RVA = "0x4A6950", Offset = "0x4A5B50", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Part), Member = "set_UseGravity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002818")]
	public void set_UseGravity(bool value) { }

	[Address(RVA = "0x4A6970", Offset = "0x4A5B70", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Part), Member = "set_Velocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600280E")]
	public void set_Velocity(Vector3 value) { }

}

