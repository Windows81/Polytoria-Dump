namespace Mirror;

[Token(Token = "0x200003F")]
public struct RigidbodyState : PredictedState
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400015D")]
	private double <timestamp>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400015E")]
	private Vector3 <positionDelta>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400015F")]
	private Vector3 <position>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000160")]
	private Quaternion <rotationDelta>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000161")]
	private Quaternion <rotation>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000162")]
	private Vector3 <velocityDelta>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000163")]
	private Vector3 <velocity>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000164")]
	private Vector3 <angularVelocityDelta>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000165")]
	private Vector3 <angularVelocity>k__BackingField; //Field offset: 0x64

	[Token(Token = "0x17000023")]
	public override Vector3 angularVelocity
	{
		[Address(RVA = "0x12457F0", Offset = "0x12449F0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600022C")]
		 get { } //Length: 19
		[Address(RVA = "0x1245840", Offset = "0x1244A40", Length = "0x10")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600022D")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000022")]
	public override Vector3 angularVelocityDelta
	{
		[Address(RVA = "0x12457D0", Offset = "0x12449D0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600022A")]
		 get { } //Length: 19
		[Address(RVA = "0x1245830", Offset = "0x1244A30", Length = "0x10")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600022B")]
		 set { } //Length: 16
	}

	[Token(Token = "0x1700001D")]
	public override Vector3 position
	{
		[Address(RVA = "0x561A60", Offset = "0x560C60", Length = "0x13")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000220")]
		 get { } //Length: 19
		[Address(RVA = "0x5BD490", Offset = "0x5BC690", Length = "0x10")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000221")]
		 set { } //Length: 16
	}

	[Token(Token = "0x1700001C")]
	public override Vector3 positionDelta
	{
		[Address(RVA = "0x3B8780", Offset = "0x3B7980", Length = "0x13")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x600021E")]
		 get { } //Length: 19
		[Address(RVA = "0x3B8820", Offset = "0x3B7A20", Length = "0x10")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600021F")]
		 set { } //Length: 16
	}

	[Token(Token = "0x1700001F")]
	public override Quaternion rotation
	{
		[Address(RVA = "0x3B2180", Offset = "0x3B1380", Length = "0xB")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000224")]
		 get { } //Length: 11
		[Address(RVA = "0x3B2200", Offset = "0x3B1400", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000225")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700001E")]
	public override Quaternion rotationDelta
	{
		[Address(RVA = "0x5AAB20", Offset = "0x5A9D20", Length = "0xB")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000222")]
		 get { } //Length: 11
		[Address(RVA = "0x5AAC00", Offset = "0x5A9E00", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000223")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700001B")]
	public private override double timestamp
	{
		[Address(RVA = "0xCE36A0", Offset = "0xCE28A0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x600021C")]
		 get { } //Length: 5
		[Address(RVA = "0x120B300", Offset = "0x120A500", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600021D")]
		private set { } //Length: 5
	}

	[Token(Token = "0x17000021")]
	public override Vector3 velocity
	{
		[Address(RVA = "0x1245810", Offset = "0x1244A10", Length = "0x13")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000228")]
		 get { } //Length: 19
		[Address(RVA = "0x1245850", Offset = "0x1244A50", Length = "0x10")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000229")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000020")]
	public override Vector3 velocityDelta
	{
		[Address(RVA = "0x3B9190", Offset = "0x3B8390", Length = "0x13")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000226")]
		 get { } //Length: 19
		[Address(RVA = "0x5A8E70", Offset = "0x5A8070", Length = "0x10")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000227")]
		 set { } //Length: 16
	}

	[Address(RVA = "0x1245740", Offset = "0x1244940", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600022E")]
	public RigidbodyState(double timestamp, Vector3 positionDelta, Vector3 position, Quaternion rotationDelta, Quaternion rotation, Vector3 velocityDelta, Vector3 velocity, Vector3 angularVelocityDelta, Vector3 angularVelocity) { }

	[Address(RVA = "0x12457F0", Offset = "0x12449F0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x600022C")]
	public override Vector3 get_angularVelocity() { }

	[Address(RVA = "0x12457D0", Offset = "0x12449D0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x600022A")]
	public override Vector3 get_angularVelocityDelta() { }

	[Address(RVA = "0x561A60", Offset = "0x560C60", Length = "0x13")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6000220")]
	public override Vector3 get_position() { }

	[Address(RVA = "0x3B8780", Offset = "0x3B7980", Length = "0x13")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x600021E")]
	public override Vector3 get_positionDelta() { }

	[Address(RVA = "0x3B2180", Offset = "0x3B1380", Length = "0xB")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6000224")]
	public override Quaternion get_rotation() { }

	[Address(RVA = "0x5AAB20", Offset = "0x5A9D20", Length = "0xB")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6000222")]
	public override Quaternion get_rotationDelta() { }

	[Address(RVA = "0xCE36A0", Offset = "0xCE28A0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x600021C")]
	public override double get_timestamp() { }

	[Address(RVA = "0x1245810", Offset = "0x1244A10", Length = "0x13")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6000228")]
	public override Vector3 get_velocity() { }

	[Address(RVA = "0x3B9190", Offset = "0x3B8390", Length = "0x13")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6000226")]
	public override Vector3 get_velocityDelta() { }

	[Address(RVA = "0x1245510", Offset = "0x1244710", Length = "0x228")]
	[CalledBy(Type = typeof(PredictedRigidbody), Member = "OnReceivedState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(RigidbodyState)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "Slerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Quaternion), typeof(float)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180726960")]
	[Token(Token = "0x600022F")]
	public static RigidbodyState Interpolate(RigidbodyState a, RigidbodyState b, float t) { }

	[Address(RVA = "0x1245840", Offset = "0x1244A40", Length = "0x10")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600022D")]
	public override void set_angularVelocity(Vector3 value) { }

	[Address(RVA = "0x1245830", Offset = "0x1244A30", Length = "0x10")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600022B")]
	public override void set_angularVelocityDelta(Vector3 value) { }

	[Address(RVA = "0x5BD490", Offset = "0x5BC690", Length = "0x10")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000221")]
	public override void set_position(Vector3 value) { }

	[Address(RVA = "0x3B8820", Offset = "0x3B7A20", Length = "0x10")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600021F")]
	public override void set_positionDelta(Vector3 value) { }

	[Address(RVA = "0x3B2200", Offset = "0x3B1400", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000225")]
	public override void set_rotation(Quaternion value) { }

	[Address(RVA = "0x5AAC00", Offset = "0x5A9E00", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000223")]
	public override void set_rotationDelta(Quaternion value) { }

	[Address(RVA = "0x120B300", Offset = "0x120A500", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600021D")]
	private void set_timestamp(double value) { }

	[Address(RVA = "0x1245850", Offset = "0x1244A50", Length = "0x10")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000229")]
	public override void set_velocity(Vector3 value) { }

	[Address(RVA = "0x5A8E70", Offset = "0x5A8070", Length = "0x10")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000227")]
	public override void set_velocityDelta(Vector3 value) { }

}

