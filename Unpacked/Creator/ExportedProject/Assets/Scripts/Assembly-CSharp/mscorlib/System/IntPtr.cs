namespace System;

[ComVisible(True)]
[IsReadOnly]
[Token(Token = "0x20001B3")]
public struct IntPtr : ISerializable, IEquatable<IntPtr>
{
	[Token(Token = "0x400071A")]
	public static readonly IntPtr Zero; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000719")]
	private readonly Void* m_value; //Field offset: 0x0

	[Token(Token = "0x17000162")]
	public static int Size
	{
		[Address(RVA = "0x3CE2B0", Offset = "0x3CD4B0", Length = "0x6")]
		[CallerCount(Count = 13)]
		[DeduplicatedMethod]
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		[Token(Token = "0x6000F56")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x14F6DF0", Offset = "0x14F5FF0", Length = "0x7")]
	[CalledBy(Type = typeof(RegistryKey), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SafeHandleZeroOrMinusOneIsInvalid), Member = "get_IsInvalid", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SafeHandleMinusOneIsInvalid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SafeHandleMinusOneIsInvalid), Member = "get_IsInvalid", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Display", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Display", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Awaitable+AwaitableHandle", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[ReliabilityContract(Consistency::MayCorruptInstance (2), Cer::MayFail (1))]
	[Token(Token = "0x6000F52")]
	public IntPtr(int value) { }

	[Address(RVA = "0xC498F0", Offset = "0xC48AF0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::MayCorruptInstance (2), Cer::MayFail (1))]
	[Token(Token = "0x6000F53")]
	public IntPtr(long value) { }

	[Address(RVA = "0xC498F0", Offset = "0xC48AF0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::MayCorruptInstance (2), Cer::MayFail (1))]
	[Token(Token = "0x6000F54")]
	public IntPtr(Void* value) { }

	[Address(RVA = "0x14F6E00", Offset = "0x14F6000", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SerializationInfo), Member = "GetInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F55")]
	private IntPtr(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x7C8BE0", Offset = "0x7C7DE0", Length = "0x7")]
	[CallerCount(Count = 63)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::MayCorruptInstance (2), Cer::MayFail (1))]
	[Token(Token = "0x6000F65")]
	public static IntPtr Add(IntPtr pointer, int offset) { }

	[Address(RVA = "0x14F6C90", Offset = "0x14F5E90", Length = "0x57")]
	[CalledBy(Type = "UnityEngine.AnimationCurve", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.AnimationCurve", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.AnimationCurve"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Gradient", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Gradient", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Gradient"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.ScriptableRenderContext", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ScriptableRenderContext"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.ScriptableRenderContext", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000F58")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x3CE2B0", Offset = "0x3CD4B0", Length = "0x6")]
	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6000F56")]
	public static int get_Size() { }

	[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
	[CallerCount(Count = 129)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F59")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x9E2EA0", Offset = "0x9E20A0", Length = "0x8")]
	[CallerCount(Count = 8)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6000F68")]
	internal bool IsNull() { }

	[Address(RVA = "0x7C8BE0", Offset = "0x7C7DE0", Length = "0x7")]
	[CallerCount(Count = 63)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::MayCorruptInstance (2), Cer::MayFail (1))]
	[Token(Token = "0x6000F66")]
	public static IntPtr op_Addition(IntPtr pointer, int offset) { }

	[Address(RVA = "0x2D8A50", Offset = "0x2D7C50", Length = "0x7")]
	[CallerCount(Count = 1453)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6000F5E")]
	public static bool op_Equality(IntPtr value1, IntPtr value2) { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F64")]
	public static Void* op_Explicit(IntPtr value) { }

	[Address(RVA = "0x1415AB0", Offset = "0x1414CB0", Length = "0x4")]
	[CallerCount(Count = 39)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::MayCorruptInstance (2), Cer::MayFail (1))]
	[Token(Token = "0x6000F60")]
	public static IntPtr op_Explicit(int value) { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::MayCorruptInstance (2), Cer::MayFail (1))]
	[Token(Token = "0x6000F61")]
	public static IntPtr op_Explicit(long value) { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::MayCorruptInstance (2), Cer::MayFail (1))]
	[Token(Token = "0x6000F62")]
	public static IntPtr op_Explicit(Void* value) { }

	[Address(RVA = "0x64EB60", Offset = "0x64DD60", Length = "0x3")]
	[CallerCount(Count = 29)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F63")]
	public static int op_Explicit(IntPtr value) { }

	[Address(RVA = "0x38DBD0", Offset = "0x38CDD0", Length = "0x7")]
	[CallerCount(Count = 330)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6000F5F")]
	public static bool op_Inequality(IntPtr value1, IntPtr value2) { }

	[Address(RVA = "0x14F6E60", Offset = "0x14F6060", Length = "0xA")]
	[CalledBy(Type = typeof(SpanHelpers), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(byte), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SpanHelpers), Member = "SequenceEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(Byte&), typeof(ulong)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SpanHelpers), Member = "SequenceCompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(int), typeof(Char&), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[ReliabilityContract(Consistency::MayCorruptInstance (2), Cer::MayFail (1))]
	[Token(Token = "0x6000F67")]
	public static IntPtr op_Subtraction(IntPtr pointer, int offset) { }

	[Address(RVA = "0x14A0AF0", Offset = "0x149FCF0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F69")]
	private override bool System.IEquatable<System.IntPtr>.Equals(IntPtr other) { }

	[Address(RVA = "0x14F6CF0", Offset = "0x14F5EF0", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000F57")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x7065B0", Offset = "0x7057B0", Length = "0x6")]
	[CallerCount(Count = 95)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6000F5A")]
	public long ToInt64() { }

	[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
	[CallerCount(Count = 140)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6000F5B")]
	public Void* ToPointer() { }

	[Address(RVA = "0x14F6DC0", Offset = "0x14F5FC0", Length = "0x23")]
	[CalledBy(Type = typeof(ValueTuple`5), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ValueTuple`5), Member = "System.IValueTupleInternal.ToStringEnd", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ValueTuple`8), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ValueTuple`8), Member = "System.IValueTupleInternal.ToStringEnd", ReturnType = typeof(string))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(long), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000F5C")]
	public virtual string ToString() { }

	[Address(RVA = "0x14F6D90", Offset = "0x14F5F90", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(long), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000F5D")]
	public string ToString(string format) { }

}

