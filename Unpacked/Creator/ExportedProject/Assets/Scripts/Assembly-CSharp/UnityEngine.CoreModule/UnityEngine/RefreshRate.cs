namespace UnityEngine;

[NativeType("Runtime/Graphics/RefreshRate.h")]
[Token(Token = "0x20000A4")]
public struct RefreshRate : IEquatable<RefreshRate>, IComparable<RefreshRate>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001DE")]
	public uint numerator; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40001DF")]
	public uint denominator; //Field offset: 0x4

	[Token(Token = "0x17000096")]
	public double value
	{
		[Address(RVA = "0x193C960", Offset = "0x193BB60", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600035C")]
		 get { } //Length: 26
	}

	[Address(RVA = "0x193C820", Offset = "0x193BA20", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ulong), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600035E")]
	public override int CompareTo(RefreshRate other) { }

	[Address(RVA = "0x193C880", Offset = "0x193BA80", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600035D")]
	public override bool Equals(RefreshRate other) { }

	[Address(RVA = "0x193C960", Offset = "0x193BB60", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600035C")]
	public double get_value() { }

	[Address(RVA = "0x193C8C0", Offset = "0x193BAC0", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(double), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600035F")]
	public virtual string ToString() { }

}

