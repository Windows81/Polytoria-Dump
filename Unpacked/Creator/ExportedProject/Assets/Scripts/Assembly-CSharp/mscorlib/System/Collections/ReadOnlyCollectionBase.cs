namespace System.Collections;

[Token(Token = "0x20005A6")]
public abstract class ReadOnlyCollectionBase : ICollection, IEnumerable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40017C4")]
	private ArrayList _list; //Field offset: 0x10

	[Token(Token = "0x1700063E")]
	public override int Count
	{
		[Address(RVA = "0x1447820", Offset = "0x1446A20", Length = "0x30")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReadOnlyCollectionBase), Member = "get_InnerList", ReturnType = typeof(ArrayList))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60028ED")]
		 get { } //Length: 48
	}

	[Token(Token = "0x1700063D")]
	protected ArrayList InnerList
	{
		[Address(RVA = "0x1447860", Offset = "0x1446A60", Length = "0xA1")]
		[CalledBy(Type = typeof(ReadOnlyCollectionBase), Member = "get_Count", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(ReadOnlyCollectionBase), Member = "System.Collections.ICollection.get_SyncRoot", ReturnType = typeof(object))]
		[CalledBy(Type = typeof(ReadOnlyCollectionBase), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ReadOnlyCollectionBase), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
		[CalledBy(Type = "System.ComponentModel.ComponentCollection", Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.ComponentModel.IComponent")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009B80")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60028EC")]
		 get { } //Length: 161
	}

	[Token(Token = "0x1700063F")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0x14477E0", Offset = "0x14469E0", Length = "0x30")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReadOnlyCollectionBase), Member = "get_InnerList", ReturnType = typeof(ArrayList))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60028EE")]
		private get { } //Length: 48
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60028F1")]
	protected ReadOnlyCollectionBase() { }

	[Address(RVA = "0x1447820", Offset = "0x1446A20", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadOnlyCollectionBase), Member = "get_InnerList", ReturnType = typeof(ArrayList))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60028ED")]
	public override int get_Count() { }

	[Address(RVA = "0x1447860", Offset = "0x1446A60", Length = "0xA1")]
	[CalledBy(Type = typeof(ReadOnlyCollectionBase), Member = "get_Count", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ReadOnlyCollectionBase), Member = "System.Collections.ICollection.get_SyncRoot", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ReadOnlyCollectionBase), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReadOnlyCollectionBase), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[CalledBy(Type = "System.ComponentModel.ComponentCollection", Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.ComponentModel.IComponent")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009B80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60028EC")]
	protected ArrayList get_InnerList() { }

	[Address(RVA = "0x1447750", Offset = "0x1446950", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadOnlyCollectionBase), Member = "get_InnerList", ReturnType = typeof(ArrayList))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60028F0")]
	public override IEnumerator GetEnumerator() { }

	[Address(RVA = "0x1447790", Offset = "0x1446990", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadOnlyCollectionBase), Member = "get_InnerList", ReturnType = typeof(ArrayList))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60028EF")]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[Address(RVA = "0x14477E0", Offset = "0x14469E0", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadOnlyCollectionBase), Member = "get_InnerList", ReturnType = typeof(ArrayList))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60028EE")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

}

