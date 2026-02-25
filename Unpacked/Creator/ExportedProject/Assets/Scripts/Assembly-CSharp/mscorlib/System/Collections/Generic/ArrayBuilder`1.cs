namespace System.Collections.Generic;

[DefaultMember("Item")]
[Token(Token = "0x20005E7")]
internal struct ArrayBuilder
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001866")]
	private T[] _array; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001867")]
	private int _count; //Field offset: 0x0

	[Token(Token = "0x170006D1")]
	public int Capacity
	{
		[Address(RVA = "0xAF7740", Offset = "0xAF6940", Length = "0xD")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B65")]
		 get { } //Length: 13
	}

	[Token(Token = "0x170006D2")]
	public int Count
	{
		[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B66")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170006D3")]
	public T Item
	{
		[Address(RVA = "0xAF7750", Offset = "0xAF6950", Length = "0x2A")]
		[CalledBy(Type = typeof(LargeArrayBuilder`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LargeArrayBuilder`1), Member = "GetBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T[]")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B67")]
		 get { } //Length: 42
	}

	[Address(RVA = "0xAF6DE0", Offset = "0xAF5FE0", Length = "0xCC")]
	[CalledBy(Type = typeof(LargeArrayBuilder`1), Member = "AllocateBuffer", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18007BD20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B68")]
	public void Add(T item) { }

	[Address(RVA = "0xAF7030", Offset = "0xAF6230", Length = "0x149")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B6A")]
	private void EnsureCapacity(int minimum) { }

	[Address(RVA = "0xAF7740", Offset = "0xAF6940", Length = "0xD")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B65")]
	public int get_Capacity() { }

	[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B66")]
	public int get_Count() { }

	[Address(RVA = "0xAF7750", Offset = "0xAF6950", Length = "0x2A")]
	[CalledBy(Type = typeof(LargeArrayBuilder`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LargeArrayBuilder`1), Member = "GetBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T[]")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B67")]
	public T get_Item(int index) { }

	[Address(RVA = "0xAF73B0", Offset = "0xAF65B0", Length = "0x3E")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B69")]
	public void UncheckedAdd(T item) { }

}

