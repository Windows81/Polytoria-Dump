namespace System;

[Token(Token = "0x2000154")]
public struct ValueTuple : IEquatable<ValueTuple`4<T1, T2, T3, T4>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple`4<T1, T2, T3, T4>>, IValueTupleInternal, ITuple
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004A9")]
	public T1 Item1; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004AA")]
	public T2 Item2; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004AB")]
	public T3 Item3; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004AC")]
	public T4 Item4; //Field offset: 0x0

	[Token(Token = "0x170000FC")]
	private override int System.Runtime.CompilerServices.ITuple.Length
	{
		[Address(RVA = "0x2FFDE0", Offset = "0x2FEFE0", Length = "0x6")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BBB")]
		private get { } //Length: 6
	}

	[Address(RVA = "0x8AEC10", Offset = "0x8ADE10", Length = "0x36")]
	[CalledBy(Type = "System.Net.HttpWebRequest", Member = "CheckFinalStatus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.HttpWebResponse"}, ReturnType = "System.ValueTuple`4<Boolean, Boolean, Task`1<BufferOffsetSize>, WebException>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BAE")]
	public ValueTuple`4(T1 item1, T2 item2, T3 item3, T4 item4) { }

	[Address(RVA = "0x8A5D50", Offset = "0x8A4F50", Length = "0x1BD")]
	[CalledBy(Type = typeof(ValueTuple`4), Member = "System.IComparable.CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(System.Collections.Generic.Comparer`1<System.Boolean>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.Comparer`1<System.Boolean>))]
	[Calls(Type = typeof(System.Collections.Generic.Comparer`1<System.Object>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.Comparer`1<System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BB3")]
	public override int CompareTo(ValueTuple<T1, T2, T3, T4> other) { }

	[Address(RVA = "0x8A7C50", Offset = "0x8A6E50", Length = "0x121")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(ValueTuple`4), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ValueTuple`4<T1, T2, T3, T4>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BAF")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x8A7970", Offset = "0x8A6B70", Length = "0x1B6")]
	[CalledBy(Type = typeof(ValueTuple`4), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BCE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180023B10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BB0")]
	public override bool Equals(ValueTuple<T1, T2, T3, T4> other) { }

	[Address(RVA = "0x8A85F0", Offset = "0x8A77F0", Length = "0x10F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(ValueTuple), Member = "CombineHashCodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BB5")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x8A8140", Offset = "0x8A7340", Length = "0x139")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(ValueTuple), Member = "CombineHashCodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BB7")]
	private int GetHashCodeCore(IEqualityComparer comparer) { }

	[Address(RVA = "0x8A94E0", Offset = "0x8A86E0", Length = "0x33E")]
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
	[Token(Token = "0x6000BB4")]
	private override int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }

	[Address(RVA = "0x8AB6E0", Offset = "0x8AA8E0", Length = "0x271")]
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
	[Token(Token = "0x6000BB1")]
	private override bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }

	[Address(RVA = "0x8AB960", Offset = "0x8AAB60", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800485F0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BB6")]
	private override int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }

	[Address(RVA = "0x8AC0F0", Offset = "0x8AB2F0", Length = "0x1E3")]
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
	[Calls(Type = typeof(ValueTuple`4), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ValueTuple`4<T1, T2, T3, T4>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BB2")]
	private override int System.IComparable.CompareTo(object other) { }

	[Address(RVA = "0x8AB960", Offset = "0x8AAB60", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800485F0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BB8")]
	private override int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }

	[Address(RVA = "0x8AC2E0", Offset = "0x8AB4E0", Length = "0x221")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BBA")]
	private override string System.IValueTupleInternal.ToStringEnd() { }

	[Address(RVA = "0x2FFDE0", Offset = "0x2FEFE0", Length = "0x6")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BBB")]
	private override int System.Runtime.CompilerServices.ITuple.get_Length() { }

	[Address(RVA = "0x8AE6F0", Offset = "0x8AD8F0", Length = "0x24B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BB9")]
	public virtual string ToString() { }

}

