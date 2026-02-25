namespace System.Collections.Generic;

[Token(Token = "0x20001C9")]
internal sealed class TreeSet : SortedSet<T>
{

	[Address(RVA = "0x100AE80", Offset = "0x100A080", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SortedSet`1), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B28")]
	public TreeSet`1() { }

	[Address(RVA = "0x100AED0", Offset = "0x100A0D0", Length = "0x14")]
	[CalledBy(Type = typeof(SortedDictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SortedDictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SortedSet`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B29")]
	public TreeSet`1(IComparer<T> comparer) { }

	[Address(RVA = "0x100AEA0", Offset = "0x100A0A0", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SortedSet`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B2A")]
	public TreeSet`1(SerializationInfo siInfo, StreamingContext context) { }

	[Address(RVA = "0x100ADA0", Offset = "0x1009FA0", Length = "0xD2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SortedSet`1), Member = "AddIfNotPresent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B2B")]
	internal virtual bool AddIfNotPresent(T item) { }

}

