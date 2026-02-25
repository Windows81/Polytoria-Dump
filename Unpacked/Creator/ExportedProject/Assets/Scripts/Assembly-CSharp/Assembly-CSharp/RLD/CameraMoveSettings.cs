namespace RLD;

[Token(Token = "0x200012C")]
public class CameraMoveSettings : Settings
{
	[Token(Token = "0x4000562")]
	private static readonly float _minMoveSpeed; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000563")]
	private float _moveSpeed; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x4000564")]
	private float _alternateMoveSpeed; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000565")]
	private float _accelerationRate; //Field offset: 0x30

	[Token(Token = "0x170004D1")]
	public float AccelerationRate
	{
		[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E32")]
		 get { } //Length: 6
		[Address(RVA = "0x500BC0", Offset = "0x4FFDC0", Length = "0xF")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E33")]
		 set { } //Length: 15
	}

	[Token(Token = "0x170004D0")]
	public float AlternateMoveSpeed
	{
		[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E30")]
		 get { } //Length: 6
		[Address(RVA = "0x53BA80", Offset = "0x53AC80", Length = "0x6B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000E31")]
		 set { } //Length: 107
	}

	[Token(Token = "0x170004CF")]
	public float MoveSpeed
	{
		[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E2E")]
		 get { } //Length: 6
		[Address(RVA = "0x53BAF0", Offset = "0x53ACF0", Length = "0x6B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000E2F")]
		 set { } //Length: 107
	}

	[Address(RVA = "0x53B9D0", Offset = "0x53ABD0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000E35")]
	private static CameraMoveSettings() { }

	[Address(RVA = "0x53BA10", Offset = "0x53AC10", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E34")]
	public CameraMoveSettings() { }

	[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E32")]
	public float get_AccelerationRate() { }

	[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E30")]
	public float get_AlternateMoveSpeed() { }

	[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E2E")]
	public float get_MoveSpeed() { }

	[Address(RVA = "0x500BC0", Offset = "0x4FFDC0", Length = "0xF")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E33")]
	public void set_AccelerationRate(float value) { }

	[Address(RVA = "0x53BA80", Offset = "0x53AC80", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000E31")]
	public void set_AlternateMoveSpeed(float value) { }

	[Address(RVA = "0x53BAF0", Offset = "0x53ACF0", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000E2F")]
	public void set_MoveSpeed(float value) { }

}

