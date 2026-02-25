namespace Polytoria.Datamodel;

[Token(Token = "0x200031C")]
public struct RayResult
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C50")]
	private Vector3 <Origin>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000C51")]
	private Vector3 <Direction>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C52")]
	private Vector3 <Position>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000C53")]
	private Vector3 <Normal>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000C54")]
	private float <Distance>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000C55")]
	private Instance <Instance>k__BackingField; //Field offset: 0x38

	[Token(Token = "0x1700093A")]
	public Vector3 Direction
	{
		[Address(RVA = "0x3B9440", Offset = "0x3B8640", Length = "0x13")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6001D76")]
		 get { } //Length: 19
		[Address(RVA = "0x3B9470", Offset = "0x3B8670", Length = "0x10")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D77")]
		 set { } //Length: 16
	}

	[Token(Token = "0x1700093D")]
	public float Distance
	{
		[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6001D7C")]
		 get { } //Length: 6
		[Address(RVA = "0x2DD430", Offset = "0x2DC630", Length = "0x6")]
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D7D")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700093E")]
	public Instance Instance
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6001D7E")]
		 get { } //Length: 5
		[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D7F")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700093C")]
	public Vector3 Normal
	{
		[Address(RVA = "0x2DD160", Offset = "0x2DC360", Length = "0x13")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6001D7A")]
		 get { } //Length: 19
		[Address(RVA = "0x2DD420", Offset = "0x2DC620", Length = "0x10")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D7B")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000939")]
	public Vector3 Origin
	{
		[Address(RVA = "0x43C320", Offset = "0x43B520", Length = "0x12")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6001D74")]
		 get { } //Length: 18
		[Address(RVA = "0x43C340", Offset = "0x43B540", Length = "0xF")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D75")]
		 set { } //Length: 15
	}

	[Token(Token = "0x1700093B")]
	public Vector3 Position
	{
		[Address(RVA = "0x2DD290", Offset = "0x2DC490", Length = "0x13")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6001D78")]
		 get { } //Length: 19
		[Address(RVA = "0x2DD600", Offset = "0x2DC800", Length = "0x10")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D79")]
		 set { } //Length: 16
	}

	[Address(RVA = "0x3B9440", Offset = "0x3B8640", Length = "0x13")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6001D76")]
	public Vector3 get_Direction() { }

	[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6001D7C")]
	public float get_Distance() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6001D7E")]
	public Instance get_Instance() { }

	[Address(RVA = "0x2DD160", Offset = "0x2DC360", Length = "0x13")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6001D7A")]
	public Vector3 get_Normal() { }

	[Address(RVA = "0x43C320", Offset = "0x43B520", Length = "0x12")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6001D74")]
	public Vector3 get_Origin() { }

	[Address(RVA = "0x2DD290", Offset = "0x2DC490", Length = "0x13")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6001D78")]
	public Vector3 get_Position() { }

	[Address(RVA = "0x3B9470", Offset = "0x3B8670", Length = "0x10")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D77")]
	public void set_Direction(Vector3 value) { }

	[Address(RVA = "0x2DD430", Offset = "0x2DC630", Length = "0x6")]
	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D7D")]
	public void set_Distance(float value) { }

	[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D7F")]
	public void set_Instance(Instance value) { }

	[Address(RVA = "0x2DD420", Offset = "0x2DC620", Length = "0x10")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D7B")]
	public void set_Normal(Vector3 value) { }

	[Address(RVA = "0x43C340", Offset = "0x43B540", Length = "0xF")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D75")]
	public void set_Origin(Vector3 value) { }

	[Address(RVA = "0x2DD600", Offset = "0x2DC800", Length = "0x10")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D79")]
	public void set_Position(Vector3 value) { }

}

