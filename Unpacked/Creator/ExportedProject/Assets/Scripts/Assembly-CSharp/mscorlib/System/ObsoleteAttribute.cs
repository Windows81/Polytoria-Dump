namespace System;

[AttributeUsage(6140, Inherited = False)]
[Token(Token = "0x200011F")]
public sealed class ObsoleteAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400044A")]
	private string _message; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400044B")]
	private bool _error; //Field offset: 0x18

	[Token(Token = "0x1700009A")]
	public bool IsError
	{
		[Address(RVA = "0x2FBD80", Offset = "0x2FAF80", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600091F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000099")]
	public string Message
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x600091E")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x14BB000", Offset = "0x14BA200", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600091B")]
	public ObsoleteAttribute() { }

	[Address(RVA = "0x14BB080", Offset = "0x14BA280", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600091C")]
	public ObsoleteAttribute(string message) { }

	[Address(RVA = "0x14BB030", Offset = "0x14BA230", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600091D")]
	public ObsoleteAttribute(string message, bool error) { }

	[Address(RVA = "0x2FBD80", Offset = "0x2FAF80", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600091F")]
	public bool get_IsError() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x600091E")]
	public string get_Message() { }

}

