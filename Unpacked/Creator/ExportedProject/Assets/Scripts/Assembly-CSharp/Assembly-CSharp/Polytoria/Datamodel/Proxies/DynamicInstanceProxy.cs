namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x200039F")]
public class DynamicInstanceProxy : InstanceProxy
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000FE9")]
	private readonly DynamicInstance dynamicInstance; //Field offset: 0x18

	[Token(Token = "0x17000B7F")]
	public Vector3 Forward
	{
		[Address(RVA = "0x4A35A0", Offset = "0x4A27A0", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DynamicInstance), Member = "get_Forward", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026FD")]
		 get { } //Length: 59
	}

	[Token(Token = "0x17000B79")]
	public Vector3 LocalPosition
	{
		[Address(RVA = "0x4A35E0", Offset = "0x4A27E0", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DynamicInstance), Member = "get_LocalPosition", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026F1")]
		 get { } //Length: 59
		[Address(RVA = "0x4A3860", Offset = "0x4A2A60", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DynamicInstance), Member = "set_LocalPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026F2")]
		 set { } //Length: 53
	}

	[Token(Token = "0x17000B7E")]
	public Quaternion LocalQuaternion
	{
		[Address(RVA = "0x4A3620", Offset = "0x4A2820", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DynamicInstance), Member = "get_LocalQuaternion", ReturnType = typeof(Quaternion))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026FB")]
		 get { } //Length: 51
		[Address(RVA = "0x4A38A0", Offset = "0x4A2AA0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DynamicInstance), Member = "set_LocalQuaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026FC")]
		 set { } //Length: 44
	}

	[Token(Token = "0x17000B7A")]
	public Vector3 LocalRotation
	{
		[Address(RVA = "0x4A3660", Offset = "0x4A2860", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DynamicInstance), Member = "get_LocalRotation", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026F3")]
		 get { } //Length: 59
		[Address(RVA = "0x4A38D0", Offset = "0x4A2AD0", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DynamicInstance), Member = "set_LocalRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026F4")]
		 set { } //Length: 53
	}

	[Token(Token = "0x17000B7C")]
	public Vector3 LocalSize
	{
		[Address(RVA = "0x4A36A0", Offset = "0x4A28A0", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DynamicInstance), Member = "get_LocalSize", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026F7")]
		 get { } //Length: 59
		[Address(RVA = "0x4A3910", Offset = "0x4A2B10", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DynamicInstance), Member = "set_LocalSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026F8")]
		 set { } //Length: 53
	}

	[Token(Token = "0x17000B77")]
	public Vector3 Position
	{
		[Address(RVA = "0x4A36E0", Offset = "0x4A28E0", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DynamicInstance), Member = "get_Position", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026ED")]
		 get { } //Length: 59
		[Address(RVA = "0x4A3950", Offset = "0x4A2B50", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DynamicInstance), Member = "set_Position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026EE")]
		 set { } //Length: 53
	}

	[Token(Token = "0x17000B7D")]
	public Quaternion Quaternion
	{
		[Address(RVA = "0x4A3720", Offset = "0x4A2920", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DynamicInstance), Member = "get_Quaternion", ReturnType = typeof(Quaternion))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026F9")]
		 get { } //Length: 51
		[Address(RVA = "0x4A3990", Offset = "0x4A2B90", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DynamicInstance), Member = "set_Quaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026FA")]
		 set { } //Length: 44
	}

	[Token(Token = "0x17000B81")]
	public Vector3 Right
	{
		[Address(RVA = "0x4A3760", Offset = "0x4A2960", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DynamicInstance), Member = "get_Right", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026FF")]
		 get { } //Length: 59
	}

	[Token(Token = "0x17000B78")]
	public Vector3 Rotation
	{
		[Address(RVA = "0x4A37A0", Offset = "0x4A29A0", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DynamicInstance), Member = "get_Rotation", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026EF")]
		 get { } //Length: 59
		[Address(RVA = "0x4A39C0", Offset = "0x4A2BC0", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DynamicInstance), Member = "set_Rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026F0")]
		 set { } //Length: 53
	}

	[Token(Token = "0x17000B7B")]
	public Vector3 Size
	{
		[Address(RVA = "0x4A37E0", Offset = "0x4A29E0", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DynamicInstance), Member = "get_Size", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026F5")]
		 get { } //Length: 59
		[Address(RVA = "0x4A3A00", Offset = "0x4A2C00", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DynamicInstance), Member = "set_Size", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026F6")]
		 set { } //Length: 53
	}

	[Token(Token = "0x17000B80")]
	public Vector3 Up
	{
		[Address(RVA = "0x4A3820", Offset = "0x4A2A20", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DynamicInstance), Member = "get_Up", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026FE")]
		 get { } //Length: 59
	}

	[Address(RVA = "0x4A1050", Offset = "0x4A0250", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x60026EC")]
	public DynamicInstanceProxy(DynamicInstance target) { }

	[Address(RVA = "0x4A35A0", Offset = "0x4A27A0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicInstance), Member = "get_Forward", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026FD")]
	public Vector3 get_Forward() { }

	[Address(RVA = "0x4A35E0", Offset = "0x4A27E0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicInstance), Member = "get_LocalPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026F1")]
	public Vector3 get_LocalPosition() { }

	[Address(RVA = "0x4A3620", Offset = "0x4A2820", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicInstance), Member = "get_LocalQuaternion", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026FB")]
	public Quaternion get_LocalQuaternion() { }

	[Address(RVA = "0x4A3660", Offset = "0x4A2860", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicInstance), Member = "get_LocalRotation", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026F3")]
	public Vector3 get_LocalRotation() { }

	[Address(RVA = "0x4A36A0", Offset = "0x4A28A0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicInstance), Member = "get_LocalSize", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026F7")]
	public Vector3 get_LocalSize() { }

	[Address(RVA = "0x4A36E0", Offset = "0x4A28E0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicInstance), Member = "get_Position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026ED")]
	public Vector3 get_Position() { }

	[Address(RVA = "0x4A3720", Offset = "0x4A2920", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicInstance), Member = "get_Quaternion", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026F9")]
	public Quaternion get_Quaternion() { }

	[Address(RVA = "0x4A3760", Offset = "0x4A2960", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicInstance), Member = "get_Right", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026FF")]
	public Vector3 get_Right() { }

	[Address(RVA = "0x4A37A0", Offset = "0x4A29A0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicInstance), Member = "get_Rotation", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026EF")]
	public Vector3 get_Rotation() { }

	[Address(RVA = "0x4A37E0", Offset = "0x4A29E0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicInstance), Member = "get_Size", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026F5")]
	public Vector3 get_Size() { }

	[Address(RVA = "0x4A3820", Offset = "0x4A2A20", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicInstance), Member = "get_Up", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026FE")]
	public Vector3 get_Up() { }

	[Address(RVA = "0x4A31D0", Offset = "0x4A23D0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicInstance), Member = "InverseTransformDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002708")]
	public Vector3 InverseTransformDirection(Vector3 direction) { }

	[Address(RVA = "0x4A3230", Offset = "0x4A2430", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicInstance), Member = "InverseTransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002706")]
	public Vector3 InverseTransformPoint(Vector3 point) { }

	[Address(RVA = "0x4A3290", Offset = "0x4A2490", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicInstance), Member = "InverseTransformVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600270A")]
	public Vector3 InverseTransformVector(Vector3 vector) { }

	[Address(RVA = "0x4A32F0", Offset = "0x4A24F0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicInstance), Member = "LookAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicInstance)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002702")]
	public void LookAt(DynamicInstance dynamicInstance) { }

	[Address(RVA = "0x4A3360", Offset = "0x4A2560", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicInstance), Member = "LookAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002701")]
	public void LookAt(Vector3 lookTarget) { }

	[Address(RVA = "0x4A3310", Offset = "0x4A2510", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicInstance), Member = "LookAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002700")]
	public void LookAt(Vector3 lookTarget, Vector3 worldUp) { }

	[Address(RVA = "0x4A3400", Offset = "0x4A2600", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicInstance), Member = "Rotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002705")]
	public void Rotate(Vector3 eulerAngles) { }

	[Address(RVA = "0x4A33A0", Offset = "0x4A25A0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicInstance), Member = "RotateAround", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002704")]
	public void RotateAround(Vector3 point, Vector3 axis, float angle) { }

	[Address(RVA = "0x4A3860", Offset = "0x4A2A60", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicInstance), Member = "set_LocalPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026F2")]
	public void set_LocalPosition(Vector3 value) { }

	[Address(RVA = "0x4A38A0", Offset = "0x4A2AA0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicInstance), Member = "set_LocalQuaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026FC")]
	public void set_LocalQuaternion(Quaternion value) { }

	[Address(RVA = "0x4A38D0", Offset = "0x4A2AD0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicInstance), Member = "set_LocalRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026F4")]
	public void set_LocalRotation(Vector3 value) { }

	[Address(RVA = "0x4A3910", Offset = "0x4A2B10", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicInstance), Member = "set_LocalSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026F8")]
	public void set_LocalSize(Vector3 value) { }

	[Address(RVA = "0x4A3950", Offset = "0x4A2B50", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicInstance), Member = "set_Position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026EE")]
	public void set_Position(Vector3 value) { }

	[Address(RVA = "0x4A3990", Offset = "0x4A2B90", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicInstance), Member = "set_Quaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026FA")]
	public void set_Quaternion(Quaternion value) { }

	[Address(RVA = "0x4A39C0", Offset = "0x4A2BC0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicInstance), Member = "set_Rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026F0")]
	public void set_Rotation(Vector3 value) { }

	[Address(RVA = "0x4A3A00", Offset = "0x4A2C00", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicInstance), Member = "set_Size", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026F6")]
	public void set_Size(Vector3 value) { }

	[Address(RVA = "0x4A3440", Offset = "0x4A2640", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicInstance), Member = "TransformDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002709")]
	public Vector3 TransformDirection(Vector3 direction) { }

	[Address(RVA = "0x4A34A0", Offset = "0x4A26A0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicInstance), Member = "TransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002707")]
	public Vector3 TransformPoint(Vector3 point) { }

	[Address(RVA = "0x4A3500", Offset = "0x4A2700", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicInstance), Member = "TransformVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600270B")]
	public Vector3 TransformVector(Vector3 vector) { }

	[Address(RVA = "0x4A3560", Offset = "0x4A2760", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicInstance), Member = "Translate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002703")]
	public void Translate(Vector3 translation) { }

}

