namespace System;

[Token(Token = "0x2000153")]
public struct ValueTuple : IEquatable<ValueTuple`3<T1, T2, T3>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple`3<T1, T2, T3>>, IValueTupleInternal, ITuple
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004A6")]
	public T1 Item1; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004A7")]
	public T2 Item2; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004A8")]
	public T3 Item3; //Field offset: 0x0

	[Token(Token = "0x170000FB")]
	private override int System.Runtime.CompilerServices.ITuple.Length
	{
		[Address(RVA = "0x300CD0", Offset = "0x2FFED0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BAD")]
		private get { } //Length: 6
	}

	[Address(RVA = "0x89CA30", Offset = "0x89BC30", Length = "0x19")]
	[CalledBy(Type = "UnityEngine.UIElements.BindingUpdater", Member = "VisitRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.DataBinding", typeof(Object&), "UnityEngine.UIElements.BindingContext&"}, ReturnType = "System.ValueTuple`3<Boolean, VisitReturnCode, BindingResult>")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor", Member = "ProcessTabEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Event", "UnityEngine.EventModifiers"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem", Member = "SendPositionBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Vector3", "UnityEngine.Vector3", typeof(int), "System.Nullable`1<Int32>", "System.Func`4<Vector3, Vector3, TArg, EventBase>", "TArg", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.RichTextTagParser", Member = "AddLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.RichTextTagParser+TagType", typeof(string), "System.Collections.Generic.List`1<ValueTuple`3<Int32, TagType, String>>"}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BA0")]
	public ValueTuple`3(T1 item1, T2 item2, T3 item3) { }

	[Address(RVA = "0x88D8F0", Offset = "0x88CAF0", Length = "0x16B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(System.Collections.Generic.Comparer`1<System.Boolean>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.Comparer`1<System.Boolean>))]
	[Calls(Type = typeof(System.Collections.Generic.Comparer`1<System.Int32Enum>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.Comparer`1<System.Int32Enum>))]
	[Calls(Type = typeof(System.Collections.Generic.Comparer`1<UnityEngine.UIElements.BindingResult>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.Comparer`1<UnityEngine.UIElements.BindingResult>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BA5")]
	public override int CompareTo(ValueTuple<T1, T2, T3> other) { }

	[Address(RVA = "0x88EBE0", Offset = "0x88DDE0", Length = "0x121")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(ValueTuple`3), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ValueTuple`3<T1, T2, T3>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BA1")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x88F5B0", Offset = "0x88E7B0", Length = "0x265")]
	[CalledBy(Type = typeof(ValueTuple`3), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BCE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180023C20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<UnityEngine.UIElements.BindingResult>), Member = "CreateComparer", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<UnityEngine.UIElements.BindingResult>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BA2")]
	public override bool Equals(ValueTuple<T1, T2, T3> other) { }

	[Address(RVA = "0x891A00", Offset = "0x890C00", Length = "0xE0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(ValueType), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(ValueTuple), Member = "CombineHashCodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BA7")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x891610", Offset = "0x890810", Length = "0x145")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(ValueTuple), Member = "CombineHashCodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BA9")]
	private int GetHashCodeCore(IEqualityComparer comparer) { }

	[Address(RVA = "0x892EE0", Offset = "0x8920E0", Length = "0x381")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009BA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BA6")]
	private override int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }

	[Address(RVA = "0x8968E0", Offset = "0x895AE0", Length = "0x2BB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BA3")]
	private override bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }

	[Address(RVA = "0x8979B0", Offset = "0x896BB0", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180041A10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BA8")]
	private override int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }

	[Address(RVA = "0x897DF0", Offset = "0x896FF0", Length = "0x1E3")]
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
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180040120")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BA4")]
	private override int System.IComparable.CompareTo(object other) { }

	[Address(RVA = "0x8979B0", Offset = "0x896BB0", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180041A10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BAA")]
	private override int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }

	[Address(RVA = "0x89A200", Offset = "0x899400", Length = "0x210")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(ValueType), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BAC")]
	private override string System.IValueTupleInternal.ToStringEnd() { }

	[Address(RVA = "0x300CD0", Offset = "0x2FFED0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BAD")]
	private override int System.Runtime.CompilerServices.ITuple.get_Length() { }

	[Address(RVA = "0x89AEA0", Offset = "0x89A0A0", Length = "0x23A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(ValueType), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BAB")]
	public virtual string ToString() { }

}

