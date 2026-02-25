namespace System;

[Token(Token = "0x20001BC")]
internal class NullConsoleDriver : IConsoleDriver
{
	[Token(Token = "0x400072A")]
	private static readonly ConsoleKeyInfo EmptyConsoleKeyInfo; //Field offset: 0x0

	[Token(Token = "0x17000169")]
	public override ConsoleColor ForegroundColor
	{
		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F94")]
		 set { } //Length: 3
	}

	[Address(RVA = "0x14FBB00", Offset = "0x14FAD00", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ConsoleKeyInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(ConsoleKey), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000F98")]
	private static NullConsoleDriver() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F97")]
	public NullConsoleDriver() { }

	[Address(RVA = "0x14FBA90", Offset = "0x14FAC90", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000F95")]
	public override ConsoleKeyInfo ReadKey(bool intercept) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F96")]
	public override void ResetColor() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F94")]
	public override void set_ForegroundColor(ConsoleColor value) { }

}

