namespace RLD;

[Token(Token = "0x20001BE")]
public class QuaternionRef
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000718")]
	private Quaternion _value; //Field offset: 0x10

	[Token(Token = "0x170005B7")]
	public Quaternion Value
	{
		[Address(RVA = "0x3E81B0", Offset = "0x3E73B0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001201")]
		 get { } //Length: 11
		[Address(RVA = "0x2C1210", Offset = "0x2C0410", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001202")]
		 set { } //Length: 8
	}

	[Address(RVA = "0x580A00", Offset = "0x57FC00", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001203")]
	public QuaternionRef() { }

	[Address(RVA = "0x5809A0", Offset = "0x57FBA0", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001204")]
	public QuaternionRef(Quaternion quat) { }

	[Address(RVA = "0x3E81B0", Offset = "0x3E73B0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001201")]
	public Quaternion get_Value() { }

	[Address(RVA = "0x2C1210", Offset = "0x2C0410", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001202")]
	public void set_Value(Quaternion value) { }

}

