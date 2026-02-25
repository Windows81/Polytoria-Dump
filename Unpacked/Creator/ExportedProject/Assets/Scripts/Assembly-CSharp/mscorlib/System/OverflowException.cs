namespace System;

[Token(Token = "0x2000121")]
public class OverflowException : ArithmeticException
{

	[Address(RVA = "0x14BBD30", Offset = "0x14BAF30", Length = "0x44")]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.NewArrayBoundsInstruction", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Interpreter.InterpretedFrame"}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Xml.Linq.XHashtable`1+XHashtableState", Member = "Resize", ReturnType = "System.Xml.Linq.XHashtable`1<TValue>+XHashtableState<TValue>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArithmeticException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000926")]
	public OverflowException() { }

	[Address(RVA = "0x14BBD10", Offset = "0x14BAF10", Length = "0x1E")]
	[CallerCount(Count = 70)]
	[Calls(Type = typeof(ArithmeticException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000927")]
	public OverflowException(string message) { }

	[Address(RVA = "0x14BBD80", Offset = "0x14BAF80", Length = "0x1E")]
	[CalledBy(Type = typeof(byte), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(short), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(short))]
	[CalledBy(Type = typeof(sbyte), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(sbyte))]
	[CalledBy(Type = typeof(ushort), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(ushort))]
	[CalledBy(Type = typeof(Decimal), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(Decimal), Member = "ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(sbyte))]
	[CalledBy(Type = typeof(Decimal), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(short))]
	[CalledBy(Type = typeof(Decimal), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ArithmeticException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000928")]
	public OverflowException(string message, Exception innerException) { }

	[Address(RVA = "0x10BD4F0", Offset = "0x10BC6F0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000929")]
	protected OverflowException(SerializationInfo info, StreamingContext context) { }

}

