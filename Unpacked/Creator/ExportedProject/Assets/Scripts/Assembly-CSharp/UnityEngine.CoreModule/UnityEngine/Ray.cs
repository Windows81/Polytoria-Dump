namespace UnityEngine;

[Token(Token = "0x2000096")]
public struct Ray : IFormattable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001C3")]
	private Vector3 m_Origin; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40001C4")]
	private Vector3 m_Direction; //Field offset: 0xC

	[Token(Token = "0x17000070")]
	public Vector3 direction
	{
		[Address(RVA = "0x191F130", Offset = "0x191E330", Length = "0x13")]
		[CallerCount(Count = 19)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002C6")]
		 get { } //Length: 19
		[Address(RVA = "0x193A670", Offset = "0x1939870", Length = "0x41")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Token(Token = "0x60002C7")]
		 set { } //Length: 65
	}

	[Token(Token = "0x1700006F")]
	public Vector3 origin
	{
		[Address(RVA = "0x191F110", Offset = "0x191E310", Length = "0x12")]
		[CallerCount(Count = 34)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002C4")]
		 get { } //Length: 18
		[Address(RVA = "0x43C340", Offset = "0x43B540", Length = "0xF")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002C5")]
		 set { } //Length: 15
	}

	[Address(RVA = "0x193A610", Offset = "0x1939810", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x60002C3")]
	public Ray(Vector3 origin, Vector3 direction) { }

	[Address(RVA = "0x191F130", Offset = "0x191E330", Length = "0x13")]
	[CallerCount(Count = 19)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002C6")]
	public Vector3 get_direction() { }

	[Address(RVA = "0x191F110", Offset = "0x191E310", Length = "0x12")]
	[CallerCount(Count = 34)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002C4")]
	public Vector3 get_origin() { }

	[Address(RVA = "0x193A4B0", Offset = "0x19396B0", Length = "0x4E")]
	[CallerCount(Count = 49)]
	[Token(Token = "0x60002C8")]
	public Vector3 GetPoint(float distance) { }

	[Address(RVA = "0x193A670", Offset = "0x1939870", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x60002C7")]
	public void set_direction(Vector3 value) { }

	[Address(RVA = "0x43C340", Offset = "0x43B540", Length = "0xF")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002C5")]
	public void set_origin(Vector3 value) { }

	[Address(RVA = "0x193A500", Offset = "0x1939700", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18089CDB0")]
	[Token(Token = "0x60002C9")]
	public virtual string ToString() { }

	[Address(RVA = "0x193A510", Offset = "0x1939710", Length = "0xF8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D86A0")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002CA")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

