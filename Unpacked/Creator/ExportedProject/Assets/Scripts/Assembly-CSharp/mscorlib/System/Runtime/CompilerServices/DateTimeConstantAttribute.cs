namespace System.Runtime.CompilerServices;

[AttributeUsage(2304, Inherited = False)]
[Token(Token = "0x200046B")]
public sealed class DateTimeConstantAttribute : CustomConstantAttribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400124E")]
	private DateTime _date; //Field offset: 0x10

	[Token(Token = "0x170003F6")]
	public virtual object Value
	{
		[Address(RVA = "0x13B7B10", Offset = "0x13B6D10", Length = "0x45")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Token(Token = "0x600201D")]
		 get { } //Length: 69
	}

	[Address(RVA = "0x13B7B10", Offset = "0x13B6D10", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Token(Token = "0x600201D")]
	public virtual object get_Value() { }

}

