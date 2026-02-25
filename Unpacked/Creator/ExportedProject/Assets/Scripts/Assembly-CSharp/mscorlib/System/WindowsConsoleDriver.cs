namespace System;

[Token(Token = "0x20001E1")]
internal class WindowsConsoleDriver : IConsoleDriver
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000963")]
	private IntPtr inputHandle; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000964")]
	private IntPtr outputHandle; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000965")]
	private short defaultAttribute; //Field offset: 0x20

	[Token(Token = "0x1700017F")]
	public override ConsoleColor ForegroundColor
	{
		[Address(RVA = "0x151FE20", Offset = "0x151F020", Length = "0xC4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
		[Calls(Type = typeof(WindowsConsoleDriver), Member = "SetConsoleTextAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(short)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001077")]
		 set { } //Length: 196
	}

	[Address(RVA = "0x151FD40", Offset = "0x151EF40", Length = "0xD5")]
	[CalledBy(Type = typeof(ConsoleDriver), Member = "CreateWindowsConsoleDriver", ReturnType = typeof(IConsoleDriver))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WindowsConsoleDriver), Member = "GetStdHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Handles)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001075")]
	public WindowsConsoleDriver() { }

	[Address(RVA = "0x151F7A0", Offset = "0x151E9A0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001076")]
	private static short GetAttrForeground(int attr, ConsoleColor color) { }

	[Address(RVA = "0x151F7B0", Offset = "0x151E9B0", Length = "0x93")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600107C")]
	private static bool GetConsoleScreenBufferInfo(IntPtr handle, out ConsoleScreenBufferInfo info) { }

	[Address(RVA = "0x151F850", Offset = "0x151EA50", Length = "0x81")]
	[CalledBy(Type = typeof(WindowsConsoleDriver), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600107B")]
	private static IntPtr GetStdHandle(Handles handle) { }

	[Address(RVA = "0x151F8E0", Offset = "0x151EAE0", Length = "0x23")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600107A")]
	private static bool IsModifierKey(short virtualKeyCode) { }

	[Address(RVA = "0x151F910", Offset = "0x151EB10", Length = "0x129")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600107E")]
	private static bool ReadConsoleInput(IntPtr handle, out InputRecord record, int length, out int nread) { }

	[Address(RVA = "0x151FA40", Offset = "0x151EC40", Length = "0x241")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
	[Calls(Type = typeof(ConsoleKeyInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(ConsoleKey), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(Marshal), Member = "GetLastWin32Error", ReturnType = typeof(int))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001078")]
	public override ConsoleKeyInfo ReadKey(bool intercept) { }

	[Address(RVA = "0x151FC90", Offset = "0x151EE90", Length = "0x10")]
	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6001079")]
	public override void ResetColor() { }

	[Address(RVA = "0x151FE20", Offset = "0x151F020", Length = "0xC4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
	[Calls(Type = typeof(WindowsConsoleDriver), Member = "SetConsoleTextAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(short)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001077")]
	public override void set_ForegroundColor(ConsoleColor value) { }

	[Address(RVA = "0x151FCA0", Offset = "0x151EEA0", Length = "0x93")]
	[CalledBy(Type = typeof(WindowsConsoleDriver), Member = "set_ForegroundColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConsoleColor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600107D")]
	private static bool SetConsoleTextAttribute(IntPtr handle, short attribute) { }

}

