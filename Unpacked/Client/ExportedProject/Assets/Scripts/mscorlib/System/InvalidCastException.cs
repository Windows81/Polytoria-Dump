namespace System;

[Token(Token = "0x2000103")]
public class InvalidCastException : SystemException
{

	[Address(RVA = "0x14A1900", Offset = "0x14A0B00", Length = "0x44")]
	[CalledBy(Type = typeof(Nullable`1), Member = "UnboxExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "System.Nullable`1<T>")]
	[CalledBy(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.BouncyCastle.Utilities.MemoableResetException", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionNoT", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Interpreter.InterpretedFrame"}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600080D")]
	public InvalidCastException() { }

	[Address(RVA = "0x14A1950", Offset = "0x14A0B50", Length = "0x1E")]
	[CallerCount(Count = 100)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600080E")]
	public InvalidCastException(string message) { }

	[Address(RVA = "0x14A18E0", Offset = "0x14A0AE0", Length = "0x1E")]
	[CalledBy(Type = "System.Collections.Concurrent.ConcurrentBag`1", Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x600080F")]
	public InvalidCastException(string message, Exception innerException) { }

	[Address(RVA = "0x13225B0", Offset = "0x13217B0", Length = "0x1F")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000810")]
	protected InvalidCastException(SerializationInfo info, StreamingContext context) { }

}

