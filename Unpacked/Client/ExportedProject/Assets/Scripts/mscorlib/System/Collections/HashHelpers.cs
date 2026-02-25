namespace System.Collections;

[Token(Token = "0x2000591")]
internal static class HashHelpers
{
	[Token(Token = "0x40017A7")]
	public static readonly Int32[] primes; //Field offset: 0x0
	[Token(Token = "0x40017A8")]
	private static ConditionalWeakTable<Object, SerializationInfo> s_serializationInfoTable; //Field offset: 0x8

	[Token(Token = "0x1700061D")]
	internal static ConditionalWeakTable<Object, SerializationInfo> SerializationInfoTable
	{
		[Address(RVA = "0x143EC10", Offset = "0x143DE10", Length = "0xF1")]
		[CalledBy(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Dictionary`2), Member = "OnDeserialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ConditionalWeakTable`2), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Token(Token = "0x600287C")]
		internal get { } //Length: 241
	}

	[Address(RVA = "0x143EB80", Offset = "0x143DD80", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600287D")]
	private static HashHelpers() { }

	[Address(RVA = "0x143E840", Offset = "0x143DA40", Length = "0x73")]
	[CalledBy(Type = typeof(Dictionary`2), Member = "TryInsert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue", typeof(InsertionBehavior)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Dictionary`2), Member = "Resize", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Collections.Generic.HashSet`1", Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.HashSet`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Collections.Generic.HashSet`1", Member = "IncreaseCapacity", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x600287B")]
	public static int ExpandPrime(int oldSize) { }

	[Address(RVA = "0x143EC10", Offset = "0x143DE10", Length = "0xF1")]
	[CalledBy(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dictionary`2), Member = "OnDeserialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ConditionalWeakTable`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Token(Token = "0x600287C")]
	internal static ConditionalWeakTable<Object, SerializationInfo> get_SerializationInfoTable() { }

	[Address(RVA = "0x143E8C0", Offset = "0x143DAC0", Length = "0x203")]
	[CalledBy(Type = "System.Collections.Generic.HashSet`1", Member = "TrimExcess", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConditionalWeakTable`2), Member = "Rehash", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hashtable), Member = "expand", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hashtable), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dictionary`2), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Dictionary`2), Member = "EnsureCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Collections.Generic.HashSet`1", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>", "System.Collections.Generic.IEqualityComparer`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Collections.Generic.HashSet`1", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600287A")]
	public static int GetPrime(int min) { }

	[Address(RVA = "0x143EAD0", Offset = "0x143DCD0", Length = "0xA1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002879")]
	public static bool IsPrime(int candidate) { }

}

