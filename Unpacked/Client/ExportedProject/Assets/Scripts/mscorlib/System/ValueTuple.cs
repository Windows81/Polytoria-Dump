namespace System;

[Token(Token = "0x2000150")]
public struct ValueTuple : IEquatable<ValueTuple>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple>, IValueTupleInternal, ITuple
{

	[Token(Token = "0x170000F8")]
	private override int System.Runtime.CompilerServices.ITuple.Length
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B7D")]
		private get { } //Length: 3
	}

	[Address(RVA = "0x14CDDC0", Offset = "0x14CCFC0", Length = "0x20B")]
	[CalledBy(Type = typeof(ValueTuple`8), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueTuple`8), Member = "GetHashCodeCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HashHelpers), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000B84")]
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7, int h8) { }

	[Address(RVA = "0x14CD890", Offset = "0x14CCA90", Length = "0x189")]
	[CalledBy(Type = typeof(ValueTuple`8), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueTuple`8), Member = "GetHashCodeCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HashHelpers), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000B82")]
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6) { }

	[Address(RVA = "0x14CD740", Offset = "0x14CC940", Length = "0x148")]
	[CalledBy(Type = typeof(ValueTuple`5), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueTuple`5), Member = "GetHashCodeCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueTuple`8), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueTuple`8), Member = "GetHashCodeCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HashHelpers), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000B81")]
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5) { }

	[Address(RVA = "0x14CDBF0", Offset = "0x14CCDF0", Length = "0x107")]
	[CalledBy(Type = typeof(ValueTuple`4), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueTuple`4), Member = "GetHashCodeCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueTuple`8), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueTuple`8), Member = "GetHashCodeCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HashHelpers), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000B80")]
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4) { }

	[Address(RVA = "0x14CDD00", Offset = "0x14CCF00", Length = "0xBB")]
	[CalledBy(Type = typeof(ValueTuple`3), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueTuple`3), Member = "GetHashCodeCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueTuple`8), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueTuple`8), Member = "GetHashCodeCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HashHelpers), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000B7F")]
	internal static int CombineHashCodes(int h1, int h2, int h3) { }

	[Address(RVA = "0x14CD6D0", Offset = "0x14CC8D0", Length = "0x6F")]
	[CalledBy(Type = typeof(ValueTuple`2), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueTuple`2), Member = "GetHashCodeCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueTuple`8), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueTuple`8), Member = "GetHashCodeCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HashHelpers), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000B7E")]
	internal static int CombineHashCodes(int h1, int h2) { }

	[Address(RVA = "0x14CDA20", Offset = "0x14CCC20", Length = "0x1CA")]
	[CalledBy(Type = typeof(ValueTuple`8), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueTuple`8), Member = "GetHashCodeCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HashHelpers), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000B83")]
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7) { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B76")]
	public override int CompareTo(ValueTuple other) { }

	[Address(RVA = "0x14CDFD0", Offset = "0x14CD1D0", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000B72")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B73")]
	public override bool Equals(ValueTuple other) { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B78")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x14CE020", Offset = "0x14CD220", Length = "0x110")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000B77")]
	private override int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }

	[Address(RVA = "0x14CE140", Offset = "0x14CD340", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000B74")]
	private override bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B79")]
	private override int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }

	[Address(RVA = "0x14CE190", Offset = "0x14CD390", Length = "0x110")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000B75")]
	private override int System.IComparable.CompareTo(object other) { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B7A")]
	private override int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }

	[Address(RVA = "0x14CE2B0", Offset = "0x14CD4B0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000B7C")]
	private override string System.IValueTupleInternal.ToStringEnd() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B7D")]
	private override int System.Runtime.CompilerServices.ITuple.get_Length() { }

	[Address(RVA = "0x14CE2E0", Offset = "0x14CD4E0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000B7B")]
	public virtual string ToString() { }

}

