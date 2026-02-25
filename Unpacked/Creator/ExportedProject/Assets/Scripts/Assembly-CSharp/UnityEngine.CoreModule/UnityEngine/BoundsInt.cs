namespace UnityEngine;

[Token(Token = "0x2000093")]
[UsedByNativeCode]
public struct BoundsInt : IEquatable<BoundsInt>, IFormattable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001BE")]
	private Vector3Int m_Position; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40001BF")]
	private Vector3Int m_Size; //Field offset: 0xC

	[Token(Token = "0x1700006B")]
	public Vector3Int position
	{
		[Address(RVA = "0x191F110", Offset = "0x191E310", Length = "0x12")]
		[CallerCount(Count = 34)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002A7")]
		 get { } //Length: 18
		[Address(RVA = "0x43C340", Offset = "0x43B540", Length = "0xF")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002A8")]
		 set { } //Length: 15
	}

	[Token(Token = "0x1700006C")]
	public Vector3Int size
	{
		[Address(RVA = "0x191F130", Offset = "0x191E330", Length = "0x13")]
		[CallerCount(Count = 19)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002A9")]
		 get { } //Length: 19
		[Address(RVA = "0x3B9470", Offset = "0x3B8670", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002AA")]
		 set { } //Length: 16
	}

	[Address(RVA = "0x880C50", Offset = "0x87FE50", Length = "0x20")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002AB")]
	public BoundsInt(Vector3Int position, Vector3Int size) { }

	[Address(RVA = "0x191EEA0", Offset = "0x191E0A0", Length = "0x130")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002AE")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x191EE00", Offset = "0x191E000", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002AF")]
	public override bool Equals(BoundsInt other) { }

	[Address(RVA = "0x191F110", Offset = "0x191E310", Length = "0x12")]
	[CallerCount(Count = 34)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002A7")]
	public Vector3Int get_position() { }

	[Address(RVA = "0x191F130", Offset = "0x191E330", Length = "0x13")]
	[CallerCount(Count = 19)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002A9")]
	public Vector3Int get_size() { }

	[Address(RVA = "0x191EFE0", Offset = "0x191E1E0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3Int), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x60002B0")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x43C340", Offset = "0x43B540", Length = "0xF")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002A8")]
	public void set_position(Vector3Int value) { }

	[Address(RVA = "0x3B9470", Offset = "0x3B8670", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002AA")]
	public void set_size(Vector3Int value) { }

	[Address(RVA = "0x191F100", Offset = "0x191E300", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18191AFB0")]
	[Token(Token = "0x60002AC")]
	public virtual string ToString() { }

	[Address(RVA = "0x191F020", Offset = "0x191E220", Length = "0xD8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180E2ACE0")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002AD")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

