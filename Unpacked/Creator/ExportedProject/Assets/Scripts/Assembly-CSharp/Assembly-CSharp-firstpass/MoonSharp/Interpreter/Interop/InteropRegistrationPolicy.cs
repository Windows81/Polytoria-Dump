namespace MoonSharp.Interpreter.Interop;

[Token(Token = "0x20000D1")]
public static class InteropRegistrationPolicy
{

	[Token(Token = "0x1700011C")]
	public static IRegistrationPolicy Automatic
	{
		[Address(RVA = "0x322750", Offset = "0x321950", Length = "0x44")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60008A3")]
		 get { } //Length: 68
	}

	[Token(Token = "0x1700011A")]
	public static IRegistrationPolicy Default
	{
		[Address(RVA = "0x3227A0", Offset = "0x3219A0", Length = "0x44")]
		[CalledBy(Type = typeof(UserData), Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60008A1")]
		 get { } //Length: 68
	}

	[Obsolete("Please use InteropRegistrationPolicy.Default instead.")]
	[Token(Token = "0x1700011B")]
	public static IRegistrationPolicy Explicit
	{
		[Address(RVA = "0x3227F0", Offset = "0x3219F0", Length = "0x44")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60008A2")]
		 get { } //Length: 68
	}

	[Address(RVA = "0x322750", Offset = "0x321950", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60008A3")]
	public static IRegistrationPolicy get_Automatic() { }

	[Address(RVA = "0x3227A0", Offset = "0x3219A0", Length = "0x44")]
	[CalledBy(Type = typeof(UserData), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60008A1")]
	public static IRegistrationPolicy get_Default() { }

	[Address(RVA = "0x3227F0", Offset = "0x3219F0", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60008A2")]
	public static IRegistrationPolicy get_Explicit() { }

}

