namespace System.Collections.Generic;

[Token(Token = "0x20005E9")]
internal struct LargeArrayBuilder
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001868")]
	private readonly int _maxCapacity; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001869")]
	private T[] _first; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400186A")]
	private ArrayBuilder<T[]> _buffers; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400186B")]
	private T[] _current; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400186C")]
	private int _index; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400186D")]
	private int _count; //Field offset: 0x0

	[Address(RVA = "0xCE61D0", Offset = "0xCE53D0", Length = "0x3A")]
	[CalledBy(Type = typeof(EnumerableHelpers), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = "T[]")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800C9DE0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B6C")]
	public LargeArrayBuilder`1(bool initialize) { }

	[Address(RVA = "0xCE6340", Offset = "0xCE5540", Length = "0xD0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B6D")]
	public LargeArrayBuilder`1(int maxCapacity) { }

	[Address(RVA = "0xCE4D40", Offset = "0xCE3F40", Length = "0x2AC")]
	[CalledBy(Type = typeof(EnumerableHelpers), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = "T[]")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(LargeArrayBuilder`1), Member = "AddWithBufferAllocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T[]&", typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B6E")]
	public void AddRange(IEnumerable<T> items) { }

	[Address(RVA = "0xCE5640", Offset = "0xCE4840", Length = "0xB8")]
	[CalledBy(Type = typeof(LargeArrayBuilder`1), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(LargeArrayBuilder`1), Member = "AllocateBuffer", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B6F")]
	private void AddWithBufferAllocation(T item, ref T[] destination, ref int index) { }

	[Address(RVA = "0xCE5920", Offset = "0xCE4B20", Length = "0x1D6")]
	[CalledBy(Type = typeof(LargeArrayBuilder`1), Member = "AddWithBufferAllocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T[]&", typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(ArrayBuilder`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B74")]
	private void AllocateBuffer() { }

	[Address(RVA = "0xCE5C30", Offset = "0xCE4E30", Length = "0x152")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(ArrayBuilder`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B70")]
	public void CopyTo(T[] array, int arrayIndex, int count) { }

	[Address(RVA = "0xCE5EA0", Offset = "0xCE50A0", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(ArrayBuilder`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B71")]
	public T[] GetBuffer(int index) { }

	[Address(RVA = "0xCE6080", Offset = "0xCE5280", Length = "0x10C")]
	[CalledBy(Type = typeof(EnumerableHelpers), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = "T[]")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800C9BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B72")]
	public T[] ToArray() { }

	[Address(RVA = "0xCE6190", Offset = "0xCE5390", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B73")]
	public bool TryMove(out T[] array) { }

}

