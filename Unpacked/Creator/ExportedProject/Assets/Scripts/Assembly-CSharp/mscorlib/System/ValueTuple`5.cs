namespace System;

[Token(Token = "0x2000155")]
public struct ValueTuple : IEquatable<ValueTuple`5<T1, T2, T3, T4, T5>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple`5<T1, T2, T3, T4, T5>>, IValueTupleInternal, ITuple
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004AD")]
	public T1 Item1; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004AE")]
	public T2 Item2; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004AF")]
	public T3 Item3; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004B0")]
	public T4 Item4; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004B1")]
	public T5 Item5; //Field offset: 0x0

	[Token(Token = "0x170000FD")]
	private override int System.Runtime.CompilerServices.ITuple.Length
	{
		[Address(RVA = "0x2FF950", Offset = "0x2FEB50", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BC9")]
		private get { } //Length: 6
	}

	[Address(RVA = "0x8B8340", Offset = "0x8B7540", Length = "0x1B")]
	[CalledBy(Type = typeof(Path), Member = "JoinInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BBC")]
	public ValueTuple`5(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5) { }

	[Address(RVA = "0x8AF1A0", Offset = "0x8AE3A0", Length = "0x1FB")]
	[CalledBy(Type = typeof(ValueTuple`5), Member = "System.IComparable.CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(System.Collections.Generic.Comparer`1<System.IntPtr>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.Comparer`1<System.IntPtr>))]
	[Calls(Type = typeof(System.Collections.Generic.Comparer`1<System.Int32>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.Comparer`1<System.Int32>))]
	[Calls(Type = typeof(System.Collections.Generic.Comparer`1<System.Boolean>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.Comparer`1<System.Boolean>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BC1")]
	public override int CompareTo(ValueTuple<T1, T2, T3, T4, T5> other) { }

	[Address(RVA = "0x8B0EF0", Offset = "0x8B00F0", Length = "0x11F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(ValueTuple`5), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ValueTuple`5<T1, T2, T3, T4, T5>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BBD")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x8B0BA0", Offset = "0x8AFDA0", Length = "0x202")]
	[CalledBy(Type = typeof(ValueTuple`5), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002E5E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180023D30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BCE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BBE")]
	public override bool Equals(ValueTuple<T1, T2, T3, T4, T5> other) { }

	[Address(RVA = "0x8B2740", Offset = "0x8B1940", Length = "0x14F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(ValueTuple), Member = "CombineHashCodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BC3")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x8B1180", Offset = "0x8B0380", Length = "0x217")]
	[CalledBy(Type = typeof(ValueTuple`5), Member = "System.Collections.IStructuralEquatable.GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueTuple`5), Member = "System.IValueTupleInternal.GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(ValueTuple), Member = "CombineHashCodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BC5")]
	private int GetHashCodeCore(IEqualityComparer comparer) { }

	[Address(RVA = "0x8B29E0", Offset = "0x8B1BE0", Length = "0x4BD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009BA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BC2")]
	private override int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }

	[Address(RVA = "0x8B3ED0", Offset = "0x8B30D0", Length = "0x3FC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BBF")]
	private override bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }

	[Address(RVA = "0x8B4C60", Offset = "0x8B3E60", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(ValueTuple`5), Member = "GetHashCodeCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BC4")]
	private override int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }

	[Address(RVA = "0x8B4F90", Offset = "0x8B4190", Length = "0x1DF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009BA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(ValueTuple`5), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ValueTuple`5<T1, T2, T3, T4, T5>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BC0")]
	private override int System.IComparable.CompareTo(object other) { }

	[Address(RVA = "0x8B4C60", Offset = "0x8B3E60", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(ValueTuple`5), Member = "GetHashCodeCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BC6")]
	private override int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }

	[Address(RVA = "0x8B6370", Offset = "0x8B5570", Length = "0x28A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(IntPtr), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BC8")]
	private override string System.IValueTupleInternal.ToStringEnd() { }

	[Address(RVA = "0x2FF950", Offset = "0x2FEB50", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BC9")]
	private override int System.Runtime.CompilerServices.ITuple.get_Length() { }

	[Address(RVA = "0x8B7BF0", Offset = "0x8B6DF0", Length = "0x2B4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(IntPtr), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BC7")]
	public virtual string ToString() { }

}

