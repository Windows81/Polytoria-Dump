namespace System.Runtime.Serialization;

[Token(Token = "0x20003D4")]
internal sealed class ValueTypeFixupInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F27")]
	private readonly long _containerID; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F28")]
	private readonly FieldInfo _parentField; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000F29")]
	private readonly Int32[] _parentIndex; //Field offset: 0x20

	[Token(Token = "0x170003A3")]
	public long ContainerID
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D03")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003A4")]
	public FieldInfo ParentField
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D04")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003A5")]
	public Int32[] ParentIndex
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D05")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1397D10", Offset = "0x1396F10", Length = "0x1EC")]
	[CalledBy(Type = typeof(ObjectHolder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(long), typeof(SerializationInfo), typeof(ISerializationSurrogate), typeof(long), typeof(FieldInfo), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectHolder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(long), typeof(SerializationInfo), typeof(ISerializationSurrogate), typeof(long), typeof(FieldInfo), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectHolder), Member = "UpdateData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SerializationInfo), typeof(ISerializationSurrogate), typeof(long), typeof(FieldInfo), typeof(Int32[]), typeof(ObjectManager)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001D02")]
	public ValueTypeFixupInfo(long containerID, FieldInfo member, Int32[] parentIndex) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D03")]
	public long get_ContainerID() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D04")]
	public FieldInfo get_ParentField() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D05")]
	public Int32[] get_ParentIndex() { }

}

