namespace System.Net.Http.Headers;

[Token(Token = "0x2000048")]
public class RangeItemHeaderValue : ICloneable
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000D6")]
	private Nullable<Int64> <From>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000D7")]
	private Nullable<Int64> <To>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x17000055")]
	public private Nullable<Int64> From
	{
		[Address(RVA = "0x3E81B0", Offset = "0x3E73B0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001BB")]
		 get { } //Length: 11
		[Address(RVA = "0x2C1210", Offset = "0x2C0410", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001BC")]
		private set { } //Length: 8
	}

	[Token(Token = "0x17000056")]
	public private Nullable<Int64> To
	{
		[Address(RVA = "0x5AAB20", Offset = "0x5A9D20", Length = "0xB")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001BD")]
		 get { } //Length: 11
		[Address(RVA = "0x5AAC00", Offset = "0x5A9E00", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001BE")]
		private set { } //Length: 8
	}

	[Address(RVA = "0x161AC20", Offset = "0x1619E20", Length = "0x1D1")]
	[CalledBy(Type = typeof(RangeHeaderValue), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RangeHeaderValue&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001BA")]
	public RangeItemHeaderValue(Nullable<Int64> from, Nullable<Int64> to) { }

	[Address(RVA = "0x161A9B0", Offset = "0x1619BB0", Length = "0xC6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001C0")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x3E81B0", Offset = "0x3E73B0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001BB")]
	public Nullable<Int64> get_From() { }

	[Address(RVA = "0x5AAB20", Offset = "0x5A9D20", Length = "0xB")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001BD")]
	public Nullable<Int64> get_To() { }

	[Address(RVA = "0x161AA80", Offset = "0x1619C80", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Nullable`1<System.Int64>), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x60001C1")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2C1210", Offset = "0x2C0410", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001BC")]
	private void set_From(Nullable<Int64> value) { }

	[Address(RVA = "0x5AAC00", Offset = "0x5A9E00", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001BE")]
	private void set_To(Nullable<Int64> value) { }

	[Address(RVA = "0x1076940", Offset = "0x1075B40", Length = "0x7")]
	[CallerCount(Count = 134)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001BF")]
	private override object System.ICloneable.Clone() { }

	[Address(RVA = "0x161AAF0", Offset = "0x1619CF0", Length = "0x130")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(long), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x60001C2")]
	public virtual string ToString() { }

}

