namespace System.ComponentModel;

[Token(Token = "0x2000198")]
internal sealed class WeakHashtable : Hashtable
{
	[Token(Token = "0x2000199")]
	private class WeakKeyComparer : IEqualityComparer
	{

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009D3")]
		public WeakKeyComparer() { }

		[Address(RVA = "0x17B0160", Offset = "0x17AF360", Length = "0x1A0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsUnknownMethods(Count = 6)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60009D1")]
		private override bool System.Collections.IEqualityComparer.Equals(object x, object y) { }

		[Address(RVA = "0x388290", Offset = "0x387490", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009D2")]
		private override int System.Collections.IEqualityComparer.GetHashCode(object obj) { }

	}

	[Token(Token = "0x4000665")]
	private static IEqualityComparer _comparer; //Field offset: 0x0

	[Address(RVA = "0x17B0080", Offset = "0x17AF280", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60009D0")]
	private static WeakHashtable() { }

	[Address(RVA = "0x17B0100", Offset = "0x17AF300", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(void))]
	[Token(Token = "0x60009CD")]
	internal WeakHashtable() { }

	[Address(RVA = "0x17B0060", Offset = "0x17AF260", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hashtable), Member = "Clear", ReturnType = typeof(void))]
	[Token(Token = "0x60009CE")]
	public virtual void Clear() { }

	[Address(RVA = "0x17B0070", Offset = "0x17AF270", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hashtable), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x60009CF")]
	public virtual void Remove(object key) { }

}

