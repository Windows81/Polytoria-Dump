namespace System.Collections.Generic;

[Token(Token = "0x20005E1")]
public class KeyNotFoundException : SystemException
{

	[Address(RVA = "0x1445030", Offset = "0x1444230", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002B13")]
	public KeyNotFoundException() { }

	[Address(RVA = "0x1445080", Offset = "0x1444280", Length = "0x1E")]
	[CalledBy(Type = typeof(ThrowHelper), Member = "GetKeyNotFoundException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(KeyNotFoundException))]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "ThrowKeyNotFoundException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Collections.Generic.SortedDictionary`2", Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[CalledBy(Type = "System.Collections.Generic.SortedList`2", Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.HybridReferenceDictionary`2", Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002B14")]
	public KeyNotFoundException(string message) { }

	[Address(RVA = "0x13225B0", Offset = "0x13217B0", Length = "0x1F")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B15")]
	protected KeyNotFoundException(SerializationInfo info, StreamingContext context) { }

}

