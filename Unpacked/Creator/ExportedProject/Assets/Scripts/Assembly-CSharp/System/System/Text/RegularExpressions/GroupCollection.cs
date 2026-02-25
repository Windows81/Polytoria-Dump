namespace System.Text.RegularExpressions;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(System.Text.RegularExpressions.CollectionDebuggerProxy`1<System.Text.RegularExpressions.Group>))]
[DefaultMember("Item")]
[Token(Token = "0x20000E0")]
public class GroupCollection : IList<Group>, ICollection<Group>, IEnumerable<Group>, IEnumerable, IReadOnlyList<Group>, IReadOnlyCollection<Group>, IList, ICollection
{
	[Token(Token = "0x20000E1")]
	private sealed class Enumerator : IEnumerator<Group>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400035D")]
		private readonly GroupCollection _collection; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400035E")]
		private int _index; //Field offset: 0x18

		[Token(Token = "0x170000D7")]
		public override Group Current
		{
			[Address(RVA = "0x174F940", Offset = "0x174EB40", Length = "0x97")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(GroupCollection), Member = "GetGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Group))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x60004C3")]
			 get { } //Length: 151
		}

		[Token(Token = "0x170000D8")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x174F940", Offset = "0x174EB40", Length = "0x97")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(GroupCollection), Member = "GetGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Group))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x60004C4")]
			private get { } //Length: 151
		}

		[Address(RVA = "0x140E2F0", Offset = "0x140D4F0", Length = "0x39")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004C1")]
		internal Enumerator(GroupCollection collection) { }

		[Address(RVA = "0x174F940", Offset = "0x174EB40", Length = "0x97")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GroupCollection), Member = "GetGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Group))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60004C3")]
		public override Group get_Current() { }

		[Address(RVA = "0x174F8B0", Offset = "0x174EAB0", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60004C2")]
		public override bool MoveNext() { }

		[Address(RVA = "0x174F940", Offset = "0x174EB40", Length = "0x97")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GroupCollection), Member = "GetGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Group))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60004C4")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x14CF520", Offset = "0x14CE720", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004C5")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004C6")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400035A")]
	private readonly Match _match; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400035B")]
	private readonly Hashtable _captureMap; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400035C")]
	private Group[] _groups; //Field offset: 0x20

	[Token(Token = "0x170000D1")]
	public override int Count
	{
		[Address(RVA = "0x1750F70", Offset = "0x1750170", Length = "0x23")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60004A4")]
		 get { } //Length: 35
	}

	[Token(Token = "0x170000D0")]
	public override bool IsReadOnly
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004A3")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000D2")]
	public override Group Item
	{
		[Address(RVA = "0x1750AF0", Offset = "0x174FCF0", Length = "0x8")]
		[CallerCount(Count = 25)]
		[Calls(Type = typeof(GroupCollection), Member = "GetGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Group))]
		[DeduplicatedMethod]
		[Token(Token = "0x60004A5")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000D3")]
	public override object SyncRoot
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004AA")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000D4")]
	private override Group System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Item
	{
		[Address(RVA = "0x1750AF0", Offset = "0x174FCF0", Length = "0x8")]
		[CallerCount(Count = 25)]
		[Calls(Type = typeof(GroupCollection), Member = "GetGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Group))]
		[DeduplicatedMethod]
		[Token(Token = "0x60004B0")]
		private get { } //Length: 8
		[Address(RVA = "0x1750B00", Offset = "0x174FD00", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60004B1")]
		private set { } //Length: 78
	}

	[Token(Token = "0x170000D5")]
	private override bool System.Collections.IList.IsFixedSize
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004BB")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170000D6")]
	private override object System.Collections.IList.Item
	{
		[Address(RVA = "0x1750AF0", Offset = "0x174FCF0", Length = "0x8")]
		[CallerCount(Count = 25)]
		[Calls(Type = typeof(GroupCollection), Member = "GetGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Group))]
		[DeduplicatedMethod]
		[Token(Token = "0x60004BE")]
		private get { } //Length: 8
		[Address(RVA = "0x1750EF0", Offset = "0x17500F0", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60004BF")]
		private set { } //Length: 78
	}

	[Address(RVA = "0x331270", Offset = "0x330470", Length = "0x4E")]
	[CallerCount(Count = 37)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004A2")]
	internal GroupCollection(Match match, Hashtable caps) { }

	[Address(RVA = "0x1750F40", Offset = "0x1750140", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x60004C0")]
	internal GroupCollection() { }

	[Address(RVA = "0x174FBC0", Offset = "0x174EDC0", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GroupCollection), Member = "GetGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Group))]
	[Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60004AB")]
	public override void CopyTo(Array array, int arrayIndex) { }

	[Address(RVA = "0x174FCA0", Offset = "0x174EEA0", Length = "0x1ED")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GroupCollection), Member = "GetGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Group))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60004AC")]
	public override void CopyTo(Group[] array, int arrayIndex) { }

	[Address(RVA = "0x1750F70", Offset = "0x1750170", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004A4")]
	public override int get_Count() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004A3")]
	public override bool get_IsReadOnly() { }

	[Address(RVA = "0x1750AF0", Offset = "0x174FCF0", Length = "0x8")]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(GroupCollection), Member = "GetGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Group))]
	[DeduplicatedMethod]
	[Token(Token = "0x60004A5")]
	public override Group get_Item(int groupnum) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004AA")]
	public override object get_SyncRoot() { }

	[Address(RVA = "0x174FE90", Offset = "0x174F090", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004A6")]
	public override IEnumerator GetEnumerator() { }

	[Address(RVA = "0x17502F0", Offset = "0x174F4F0", Length = "0x4C5")]
	[CalledBy(Type = typeof(GroupCollection), Member = "System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Group))]
	[CalledBy(Type = typeof(Enumerator), Member = "get_Current", ReturnType = typeof(Group))]
	[CalledBy(Type = typeof(Enumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(GroupCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Group))]
	[CalledBy(Type = typeof(GroupCollection), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GroupCollection), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Group[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GroupCollection), Member = "System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Group)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(GroupCollection), Member = "System.Collections.IList.get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GroupCollection), Member = "GetGroupImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Group))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HashtableExtensions), Member = "TryGetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hashtable), typeof(object), "T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004A8")]
	private Group GetGroup(int groupnum) { }

	[Address(RVA = "0x174FF00", Offset = "0x174F100", Length = "0x3E7")]
	[CalledBy(Type = typeof(GroupCollection), Member = "GetGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Group))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(HashtableExtensions), Member = "TryGetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hashtable), typeof(object), "T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004A9")]
	private Group GetGroupImpl(int groupnum) { }

	[Address(RVA = "0x17507C0", Offset = "0x174F9C0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60004B2")]
	private override void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Add(Group item) { }

	[Address(RVA = "0x1750810", Offset = "0x174FA10", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60004B3")]
	private override void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Clear() { }

	[Address(RVA = "0x1750860", Offset = "0x174FA60", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Token(Token = "0x60004B4")]
	private override bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Contains(Group item) { }

	[Address(RVA = "0x17508C0", Offset = "0x174FAC0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60004B5")]
	private override bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Remove(Group item) { }

	[Address(RVA = "0x1750910", Offset = "0x174FB10", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004A7")]
	private override IEnumerator<Group> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group>.GetEnumerator() { }

	[Address(RVA = "0x1750AF0", Offset = "0x174FCF0", Length = "0x8")]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(GroupCollection), Member = "GetGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Group))]
	[DeduplicatedMethod]
	[Token(Token = "0x60004B0")]
	private override Group System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.get_Item(int index) { }

	[Address(RVA = "0x1750980", Offset = "0x174FB80", Length = "0xC8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>))]
	[Calls(Type = typeof(GroupCollection), Member = "GetGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Group))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004AD")]
	private override int System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.IndexOf(Group item) { }

	[Address(RVA = "0x1750A50", Offset = "0x174FC50", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60004AE")]
	private override void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Insert(int index, Group item) { }

	[Address(RVA = "0x1750AA0", Offset = "0x174FCA0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60004AF")]
	private override void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.RemoveAt(int index) { }

	[Address(RVA = "0x1750B00", Offset = "0x174FD00", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60004B1")]
	private override void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.set_Item(int index, Group value) { }

	[Address(RVA = "0x1750B50", Offset = "0x174FD50", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60004B6")]
	private override int System.Collections.IList.Add(object value) { }

	[Address(RVA = "0x1750BA0", Offset = "0x174FDA0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60004B7")]
	private override void System.Collections.IList.Clear() { }

	[Address(RVA = "0x1750BF0", Offset = "0x174FDF0", Length = "0x131")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004B8")]
	private override bool System.Collections.IList.Contains(object value) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004BB")]
	private override bool System.Collections.IList.get_IsFixedSize() { }

	[Address(RVA = "0x1750AF0", Offset = "0x174FCF0", Length = "0x8")]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(GroupCollection), Member = "GetGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Group))]
	[DeduplicatedMethod]
	[Token(Token = "0x60004BE")]
	private override object System.Collections.IList.get_Item(int index) { }

	[Address(RVA = "0x1750D30", Offset = "0x174FF30", Length = "0xC2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60004B9")]
	private override int System.Collections.IList.IndexOf(object value) { }

	[Address(RVA = "0x1750E00", Offset = "0x1750000", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60004BA")]
	private override void System.Collections.IList.Insert(int index, object value) { }

	[Address(RVA = "0x1750EA0", Offset = "0x17500A0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60004BC")]
	private override void System.Collections.IList.Remove(object value) { }

	[Address(RVA = "0x1750E50", Offset = "0x1750050", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60004BD")]
	private override void System.Collections.IList.RemoveAt(int index) { }

	[Address(RVA = "0x1750EF0", Offset = "0x17500F0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60004BF")]
	private override void System.Collections.IList.set_Item(int index, object value) { }

}

