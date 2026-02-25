namespace System;

[CLSCompliant(False)]
[ComVisible(True)]
[IsReadOnly]
[Token(Token = "0x20001D6")]
public struct UIntPtr : ISerializable, IEquatable<UIntPtr>
{
	[Token(Token = "0x400092F")]
	public static readonly UIntPtr Zero; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000930")]
	private readonly Void* _pointer; //Field offset: 0x0

	[Token(Token = "0x1700017B")]
	public static int Size
	{
		[Address(RVA = "0x3CE2B0", Offset = "0x3CD4B0", Length = "0x6")]
		[CallerCount(Count = 13)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001058")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x151EF50", Offset = "0x151E150", Length = "0x16")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600105A")]
	private static UIntPtr() { }

	[Address(RVA = "0x151EF80", Offset = "0x151E180", Length = "0x6")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600104B")]
	public UIntPtr(ulong value) { }

	[Address(RVA = "0x151EF70", Offset = "0x151E170", Length = "0x6")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600104C")]
	public UIntPtr(uint value) { }

	[Address(RVA = "0xC498F0", Offset = "0xC48AF0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	[Token(Token = "0x600104D")]
	public UIntPtr(Void* value) { }

	[Address(RVA = "0x151EE30", Offset = "0x151E030", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600104E")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x3CE2B0", Offset = "0x3CD4B0", Length = "0x6")]
	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001058")]
	public static int get_Size() { }

	[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
	[CallerCount(Count = 129)]
	[DeduplicatedMethod]
	[Token(Token = "0x600104F")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2D8A50", Offset = "0x2D7C50", Length = "0x7")]
	[CallerCount(Count = 1453)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6001053")]
	public static bool op_Equality(UIntPtr value1, UIntPtr value2) { }

	[Address(RVA = "0x151EF90", Offset = "0x151E190", Length = "0x6")]
	[CallerCount(Count = 142)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001055")]
	public static UIntPtr op_Explicit(ulong value) { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001056")]
	public static Void* op_Explicit(UIntPtr value) { }

	[Address(RVA = "0x64EB60", Offset = "0x64DD60", Length = "0x3")]
	[CallerCount(Count = 29)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001057")]
	public static UIntPtr op_Explicit(uint value) { }

	[Address(RVA = "0x38DBD0", Offset = "0x38CDD0", Length = "0x7")]
	[CallerCount(Count = 330)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6001054")]
	public static bool op_Inequality(UIntPtr value1, UIntPtr value2) { }

	[Address(RVA = "0x14A0AF0", Offset = "0x149FCF0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6001059")]
	private override bool System.IEquatable<System.UIntPtr>.Equals(UIntPtr other) { }

	[Address(RVA = "0x151EE90", Offset = "0x151E090", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001052")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
	[CallerCount(Count = 140)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001050")]
	public Void* ToPointer() { }

	[Address(RVA = "0x151EF30", Offset = "0x151E130", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ulong), Member = "ToString", ReturnType = typeof(string))]
	[Token(Token = "0x6001051")]
	public virtual string ToString() { }

}

